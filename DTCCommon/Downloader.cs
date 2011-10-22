using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Threading;

namespace DTC.Common
{


    public class Download
    {
        public bool Downloading = false;
        public bool Cancel = false;
        public bool Error = false;
        
        public string DownloadUrl = "";
        public string DownloadFile = "";
        public string package = "";

        public double bytesIn=0;
        public double totalBytes=0;
        public double percentage=0;

        public int result = -1;


        public string type = "file";
    }

    public class ArchiveDownload : Download
    {
        public ArchiveDownload()
        {
            this.type = "package";
        }
    }


    public class FileDownload : Download
    {
        public FileDownload()
        {
            this.type = "file";
        }
    }



    public class Downloader
    {
        public static bool Error = false;
        public static bool Downloading = false;
        public static bool Cancel = false;
        public static bool EmptyQueue = false;
        
        private static WebClient client = new WebClient();

        public static Collection<Download> DownloadQueue = new Collection<Download>();

        
        public delegate void DownloadStartedEventHandler(Download d);
        public delegate void DownloadFinishedEventHandler(Download d);
        public delegate void DownloadErrorEventHandler(Download d);
        
        public static event DownloadStartedEventHandler DownloadStarted;
        public static event DownloadFinishedEventHandler DownloadFinished;
        public static event DownloadErrorEventHandler DownloadError;
        
        public static event EventHandler DownloadsCanceled;
        public static event EventHandler DownloadsFinished;
    
        public static event DownloadProgressChangedEventHandler DownloadProgress;
        public static event AsyncCompletedEventHandler DownloadFileCompleted;

        public static Download CurrentDownload
        {
            get
            {
                return (DownloadQueue.Count > 0) ? DownloadQueue[0] : null;
            }
        }


        public static void Init()
        {
            client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(client_DownloadProgressChanged);
            client.DownloadFileCompleted += new AsyncCompletedEventHandler(client_DownloadFileCompleted);
            DownloadQueue.Clear();
            Downloading = false;
            Cancel = false;
            EmptyQueue = true;
        }

       
       
        private static void QueueEnd()
        {
            Downloading = false;
            EmptyQueue = true;
            //raise event

            Console.WriteLine("FIN QUEUE");
        }

        static void client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
    	{
            Downloader.Downloading = true;

    	    double bytesIn = double.Parse(e.BytesReceived.ToString());
    	    double totalBytes = double.Parse(e.TotalBytesToReceive.ToString());
    	    double percentage = bytesIn / totalBytes * 100;
         

            if (Downloader.DownloadProgress != null)
            {
                Downloader.DownloadProgress(sender, e);
            }

    	    
    	}

        static void client_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
	    {
            //Thread.Sleep(5000);

            if (e.Error != null)
            {
                Console.WriteLine("FIN DL, ERREUR: " + e.Error.InnerException);
                Error = true;
            }
            else
            {
                Error = false;
                Console.WriteLine("FIN DL"); 
                if (Downloader.DownloadFileCompleted != null)
                {
                    Downloader.DownloadFileCompleted(sender, e);
                }
            }

            Downloader.Downloading = false;
	    }



        public static int QueueIndex = 0;

        public static void Start()
        {
            bool Canceled = false;


            //raise event START DL (fichier, destination)


            while(DownloadQueue.Count > 0)
            {
                Download dL = DownloadQueue[0];

                Downloading = true;

                Console.WriteLine("DEBUT DL");

                //EVENT DOWNLOAD_STARTED
                if (Downloader.DownloadStarted != null)
                {
                    Downloader.DownloadStarted(dL);
                }



                Error = false;

                try
                {
                    client.DownloadFileAsync(new Uri(dL.DownloadUrl), dL.DownloadFile);
                }
                catch (UriFormatException u)
                {
                    Error = true;
                    throw u;
                }
                catch (Exception E)
                {
                    Error = true;
                    throw E;
                }




                //attend signal OK prochain
                while (Downloading && !Cancel)
                {
                    Thread.Sleep(10);
                    //do rien
                }
             
                if (Cancel)
                {
                    if (!Canceled) Canceled = true;
                    client.CancelAsync();     
                    
                    //EVENT DOWNLOADS_CANCELED
                    if (DownloadsCanceled != null)
                    {
                        DownloadsCanceled(null, new EventArgs());
                    }

                    DownloadQueue.Clear();
                    
                    Console.WriteLine("CANCELED");

                    return;
                }
                else if(Error)
                {
                    //EVENT DOWNLOAD_ERROR
                    if (Downloader.DownloadError != null)
                    {
                        Downloader.DownloadError(dL);
                    }
                    Error = false;
                }
                else
                {
                    //EVENT DOWNLOAD_FINISHED
                    if (Downloader.DownloadFinished != null)
                    {
                        Downloader.DownloadFinished(dL);
                    }
                }

                DownloadQueue.Remove(dL);


                //EVENT DOWNLOADS_FINISHED
                if (DownloadsFinished != null)
                {
                    DownloadsFinished(null, new EventArgs());
                }
            }

            QueueEnd();
        }





    }
}
