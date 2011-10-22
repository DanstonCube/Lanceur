using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DTC.Common;
using System.Net;
using System.Threading;

namespace DTC
{
    public partial class frmUpdate : Form
    {
        public frmUpdate()
        {
            InitializeComponent();
        }


        public void client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            double bytesIn = double.Parse(e.BytesReceived.ToString());
            double totalBytes = double.Parse(e.TotalBytesToReceive.ToString());
            double percentage = bytesIn / totalBytes * 100;
            
            //appel inter threads
            this.SetProgress(int.Parse(Math.Truncate(percentage).ToString()));
        }

        public void client_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            //MessageBox.Show("frmUpdate: Download Completed");
            this.SetProgress(0);
        }

        public void downloader_DownloadStarted(Download d)
        {
            this.SetText(d.DownloadUrl);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            btnCancel.Enabled = false;
            Downloader.Cancel = true;
            this.backgroundWorker1.CancelAsync();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            Downloader.Start();
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //this.Dispose();
        }

        private void frmUpdate_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.backgroundWorker1.CancelAsync();
        }

        private void frmUpdate_Load(object sender, EventArgs e)
        {
            Downloader.Cancel = false;
        }


        

        //----------------------
        //Fonctions interthreads
        //----------------------

        delegate void SetProgressCallback(int value);
        delegate void SetTextCallback(string text);
        delegate void SetLabelCallback(string text);
        delegate void SetCancelEnabledCallback(bool enabled);
        delegate void SetPackageCallback(string text);

        public void SetProgress(int value)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.progressBar1.InvokeRequired)
            {
                SetProgressCallback d = new SetProgressCallback(SetProgress);
                try
                {
                    this.Invoke(d, new object[] { value });
                }
                catch
                {
                }
            }
            else
            {
                this.progressBar1.Value = value;
            }
        }

        public void SetText(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                try
                {
                    this.Invoke(d, new object[] { text });
                }
                catch
                {
                }
            }
            else
            {
                this.Text = text;
            }
        }

        public void SetLabel(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.InvokeRequired)
            {
                SetLabelCallback d = new SetLabelCallback(SetLabel);
                try
                {
                    this.Invoke(d, new object[] { text });
                }
                catch
                {
                }
            }
            else
            {
                this.lblAction.Text = text;
            }
        }

        public void SetPackage(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.InvokeRequired)
            {
                SetPackageCallback d = new SetPackageCallback(SetPackage);
                try
                {
                    this.Invoke(d, new object[] { text });
                }
                catch
                {
                }
            }
            else
            {
                this.lblPackage.Text = text;
            }
        }


        public void SetCancelEnabled(bool enabled)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.InvokeRequired)
            {
                SetCancelEnabledCallback d = new SetCancelEnabledCallback(SetCancelEnabled);
                try
                {
                    this.Invoke(d, new object[] { enabled });
                }
                catch
                {
                }
            }
            else
            {
                this.btnCancel.Enabled = enabled;
            }
        }

    }
}
