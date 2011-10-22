using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Net;
using System.Xml;
using System.Threading;
using System.Net.Cache;
using DTC.Common;

namespace DTC
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        public void asyncWebRequest_DownloadStringCompleted(object sender, DownloadStringCompletedEventArgs e)
        {
	        if (e.Error != null)
	        {
	            MessageBox.Show(e.Error.Message);
	            return;
	        }
	 
	        if (e.Result != null && e.Result.Length > 0)
	        {
	            Program.dtchttpversion = e.Result;

	        }
	        else
	        {
	     
	        }
            CheckButtonColor();
        }

        public void CheckDTCUpdate()
        {
            WebClient httpRequest = new WebClient();

            try
            {
                httpRequest.CachePolicy = new RequestCachePolicy(RequestCacheLevel.CacheIfAvailable);
                httpRequest.DownloadStringCompleted += new DownloadStringCompletedEventHandler(this.asyncWebRequest_DownloadStringCompleted);
                httpRequest.DownloadStringAsync(new Uri("http://www.danstoncube.com/launcher/dtcversion.txt"));
                

            }
            catch (WebException E)
            {
                switch (E.Status)
                {
                    case WebExceptionStatus.ProtocolError:
                        MessageBox.Show("Impossible de vérifier la version, lancement sans vérification !");
                        return;

                    default:
                        MessageBox.Show("Erreur inconnue lors de la vérification des versions: " + E.Message);
                        return;
                }
            }
            catch (Exception fatal)
            {
                MessageBox.Show("Erreur inconnue lors de la vérification des versions: " + fatal.Message);
                return;
            }
           

        }

        public void CheckDTCUpdateSync()
        {
            WebClient httpRequest = new WebClient();
            String returnString = "";

            try
            {
                httpRequest.CachePolicy = new RequestCachePolicy(RequestCacheLevel.NoCacheNoStore);
                returnString = httpRequest.DownloadString(new Uri("http://www.danstoncube.com/launcher/dtcversion.txt"));
            }
            catch (WebException E)
            {
                switch (E.Status)
                {
                    case WebExceptionStatus.ProtocolError:
                        MessageBox.Show("Impossible de vérifier la version, lancement sans vérification !");
                        return;

                    default:
                        MessageBox.Show("Erreur inconnue lors de la vérification des versions: " + E.Message);
                        return;
                }
            }
            catch (Exception fatal)
            {
                MessageBox.Show("Erreur inconnue lors de la vérification des versions: " + fatal.Message);
                return;
            }

            Program.dtchttpversion = returnString;
        }

        private void CheckDTCOnlineSync()
        {
            WebClient httpRequest = new WebClient();
            Random rnd = new Random();

            String returnString = "";
            String randomStr = rnd.Next().ToString();

            try
            { 
                httpRequest.CachePolicy = new RequestCachePolicy(RequestCacheLevel.NoCacheNoStore);
                //returnString = httpRequest.DownloadString(new Uri(Program.serverinfourl + randomStr));
                returnString = httpRequest.DownloadString(new Uri(Program.serverinfourl));
            }
            catch (WebException E)
            {
                switch (E.Status)
                {
                    case WebExceptionStatus.ProtocolError:
                        return;

                    default:
                        return;
                }
            }
            catch (Exception fatal)
            {
                MessageBox.Show("Erreur inconnue lors de la vérification de la disponibilité du serveur: " + fatal.Message);
                return;
            }

            Program.serveronline = (returnString != "");
            Program.playersonline = 0;

            /*
             * 
             * {"timestamp":1311584967837,"hasStorm":false,"updates":[{"type": "playerjoin","playerName": "Hyulidan","account": "Hyulidan","timestamp": 1311584959960}],"isThundering":false,"servertime":12513,"players":[{"name":"DocteurZoidberg","armor":0,"account":"DocteurZoidberg","health":0,"type":"player","z":-133.65625,"y":68.0,"world":"Bisounours","x":-47.71875},{"name":"Dirk74","armor":0,"account":"Dirk74","health":0,"type":"player","z":-179.35646656218378,"y":64.0,"world":"Entrainement","x":-36.52855161045669},{"name":"Hyulidan","armor":0,"account":"Hyulidan","health":0,"type":"player","z":18.0625,"y":83.0,"world":"Bisounours","x":-68.6875}]}
             */
            //{"name":"Dirk74"

            List<string> players = new List<string>();

            if (returnString != "")
            {
                int compteur = 0;
                int lastindex = 0;

                lastindex = returnString.IndexOf("\"players\"");
                lastindex = returnString.IndexOf("\"name\"", lastindex + 1);
                while (lastindex > 0)
                {
                    int pnameindex = 0;
                    int pnameindex2 = 0;
                    int pnameindex3 = 0;
                    pnameindex = returnString.IndexOf(":", lastindex + 1) + 1;
                    pnameindex2 = returnString.IndexOf("\"", pnameindex + 1) + 1;
                    pnameindex3 = returnString.IndexOf("\"", pnameindex2 + 1);

                    string pname = returnString.Substring(pnameindex2, pnameindex3 - pnameindex2);

                    if (pname != "")
                    {
                        if (!players.Contains(pname))
                        {
                            players.Add(pname);
                            compteur++;
                        }
                    }

                    lastindex = returnString.IndexOf("\"name\"", lastindex + 1);
                }
                Program.playersonline = compteur;
            }
  
        }


        private void Form1_Load(object sender, EventArgs e)
        { 
            Text = "Lanceur DansTonCube !   v" + Program.dtcversion;
            //cboTools.SelectedItem = cboTools.Items[0]; 
           
            if (!Launcher.TestConfig())
            {
                //TODO: erreur impossible d'initialiser le fichier de configuration
                #if !DEBUG
                Application.Exit();
                return;
                #endif
            }
            
            if (!Launcher.TestJavaBin())
            {
                //TODO: a faire si pas de java trouvé !
            }

            Init();
        }




        public void LoadAccounts()
        {
            cboComptes.Items.Clear();
            foreach (XmlElement compte in Config._config.SelectNodes("//account"))
            {
                cboComptes.Items.Add(compte.GetAttribute("login"));
            }

            string strLastAccount = Config.GetLastaccount();

            if (strLastAccount == "")
            {
                try
                {
                    cboComptes.SelectedIndex = 0;
                    Config.SetLastAccount(cboComptes.Text);
                }
                catch { }
            }
            else
            {
                cboComptes.SelectedItem = strLastAccount;
            }

        }



        public void LoadServeurs()
        {
            cboServeurs.Items.Clear();

            try
            {
                Program.xmlstaticservers.LoadXml(Program.serversxml);
            }
            catch(Exception E)
            {
                #if DEBUG
                    throw E;
                #endif
            }


            foreach (XmlElement serveur in Program.xmlstaticservers.SelectNodes("//serveur"))
            {
                cboServeurs.Items.Add(serveur.GetAttribute("nom"));
            }


            foreach (XmlElement serveur in Config._config.SelectNodes("//serveur"))
            {
                cboServeurs.Items.Add(serveur.GetAttribute("nom"));
            }
            

            string strLastServ = Config.GetLastServ();

            if (strLastServ == "")
            {
                try
                {
                    cboServeurs.SelectedIndex = 0;
                    Config.SetLastServ(cboServeurs.Text);
                }
                catch { }
            }
            else
            {
                cboServeurs.SelectedItem = strLastServ;
            }


            if ((cboServeurs.Items.Count > 0) && (cboServeurs.Text == ""))
            {
                cboServeurs.SelectedIndex = 0;
                Config.SetLastServ(cboServeurs.Text);
            }



            cboServeurs_SelectedIndexChanged(null, new EventArgs());


        }


        public void LoadPackages()
        {
            foreach(cPackage p in ClientPackages.Packages.GetPackages())
            {
                if (p.GetParam("show_in_launcher") != "false")
                {
                    string pType = p.GetParam("type");
                    if (pType.ToLower() != "tool" && pType.ToLower() != "program")
                    {
                        //cboPackages.Items.Add(p.Name);
                        cboPackages.Items.Add(p);
                    }
                }
            }

            //todo: add default
            //cboPackages.SelectedItem = ClientPackages.Packages.GetPackage(Program.defaultpackage);
            SelectPackage(Program.defaultpackage);
        }

        public void SelectPackage(string s)
        {
            for (int i = 0; i < cboPackages.Items.Count; i++)
            {
                cPackage p = null;
                try
                {
                    p = (cPackage) cboPackages.Items[i];
                    if (p.Name == s)
                    {
                        cboPackages.SelectedItem = cboPackages.Items[i];
                        return;
                    }
                }
                catch
                {

                }
            }


           
        }

        public void SelectPackage(cPackage p)
        {
            SelectPackage(p.Name);
        }



        public void LoadTools()
        {
            bool hasIcons = false;
            bool hasItems = false;

            foreach (cPackage p in ClientPackages.Packages.GetPackages())
            {
                string pType = p.GetParam("type");
                if (pType.ToLower() == "tool")
                {
                    hasItems = true;

                    string sImagePath = (p.GetParam("icon") != "") ? DTC.Common.Paths.ComputePath(p.GetParam("icon"),p.Name) : "";
                    Bitmap imgIcon = null;
                    if (File.Exists(sImagePath))
                    {
                         imgIcon =new Bitmap(sImagePath);
                    }

                    //Image imgIcon = new ImageConverter(
                    //imgIcon.
                    ToolStripItem newItem;
                    
                    

                    if (imgIcon != null)
                    {
                        newItem = mnuTools.Items.Add(p.Label, imgIcon);
                        hasIcons = true;
                    }
                    else
                    {
                        newItem = mnuTools.Items.Add(p.Label);
                    }

                    newItem.Text = p.Label;
                    newItem.Tag = p.Name;

                    //mnuTools.Items.Add(
                }
               
            }

            if (hasIcons)
            {
                mnuTools.ShowImageMargin = true;
            }
            else
            {
                mnuTools.ShowImageMargin = false;
            }


            //hasItems = false;
            if(hasItems)
            {
                btnTools.Visible = true;
            }
            else
            {
                //btnConfig.Left -= btnTools.Width + (btnMCLauncher.Left - btnTools.Left - btnTools.Width);
                btnTools.Visible = false;
            }
           
        }









        public void CheckButtonColor()
        {
            return;

            
            if((Program.dtchttpversion == "") || (Program.dtchttpversion != Program.dtcversion))
            {
                btnPlay.BackColor = Color.Red;
                btnPlay.ForeColor = Color.White;
                btnPlay.Enabled = true;
            }
            else if((cboComptes.Text == "") ||(cboServeurs.Text == ""))
            {
                btnPlay.BackColor = Color.Orange;
                btnPlay.ForeColor = Color.Black;
                btnPlay.Enabled = true;
            }
            else if(Program.dtchttpversion == Program.dtcversion)
            {
                btnPlay.BackColor = Color.Green;
                btnPlay.ForeColor = Color.Black;
                btnPlay.Enabled = true;
            }
        }

        private void btnMCLauncher_Click(object sender, EventArgs e)
        {
            Program.RunOriginalMinecraft();

            btnMCLauncher.Enabled = false;
            this.Cursor = Cursors.WaitCursor;
            timerPlayEnabled.Enabled = true;
        }

        private void btnDTCLauncher_Click(object sender, EventArgs e)
        {
            /*
            if (cboComptes.Items.Count == 0)
            {
                DialogResult result = MessageBox.Show(this,"Vous devez configurer un compte pour jouer.\nVoulez vous le faire maintenant ?", "Configuration du compte", MessageBoxButtons.YesNo );
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    cmdConfig_Click(sender, e);
                    return;
                }
                return;
            
            }
            else if (cboComptes.Text == "")
            {
                MessageBox.Show("Vous devez choisir un compte pour jouer.\nCliquez sur configurer pour configurer les comptes");
                return;
            }
            */



            //variables locales
            string strUser = cboComptes.Text;
            string strPass = "";
            string strServer = "";
            string strPackage = "";



            /* Récupération information Compte */


            XmlElement compte = (XmlElement) Config._config.SelectSingleNode("//account[@login='" + strUser + "']");
            if (compte != null)
            {
                strPass = compte.GetAttribute("pass");
            }


            /* Récupération information Serveur */

            XmlElement serveur = null;

            serveur = (XmlElement)Program.xmlstaticservers.SelectSingleNode("//serveur[@nom='" + cboServeurs.Text + "']");
            if (serveur == null)
            {
                serveur = (XmlElement)Config._config.SelectSingleNode("//serveur[@nom='" + cboServeurs.Text + "']");
            }
            
            if (serveur != null)
            {
                strServer = serveur.GetAttribute("url");
                strPackage = serveur.GetAttribute("package");
            }



            //Détermination du paquet à prendre.
            //todo: "ou paquet qui n'existe pas"
            if (strPackage == "")
            {
                strPackage = ((cPackage)(cboPackages.SelectedItem)).Name;
                //todo: "ou n'existe pas"
                if (strPackage == "")
                {
                    strPackage = Program.defaultpackage;
                }

            }



            Program.RunMinecraft(strPackage, strUser, strPass, strServer);


            if (Config.GetAutoClose())
            {
                Application.Exit();
            }


            btnPlay.Enabled = false;
            this.Cursor = Cursors.WaitCursor;
            timerPlayEnabled.Enabled = true;
        }

        private void cboComptes_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckButtonColor();
            Config.SetLastAccount(cboComptes.Text);

            if (Config.GetShowSkin())
            {
                skinname = cboComptes.Text;

                if (File.Exists(DTC.Common.Paths.GetTempPath() + "\\" + skinname + ".png"))
                {
                    try
                    {
                        Bitmap tmp = new Bitmap(DTC.Common.Paths.GetTempPath() + "\\" + skinname + ".png");
                        btnPlay.Image = tmp;
                    }
                    catch
                    {
                        btnPlay.Image = DTC.Properties.Resources.Login_in48;
                    }
                }
                else
                {
                    bckGetSkin.RunWorkerAsync();
                }
            }
        }

        private void btnComptes_Click(object sender, EventArgs e)
        {
            frmComptes fComptes = new frmComptes();
            fComptes.ShowDialog(this);
            LoadAccounts();
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            frmConfig fConfig = new frmConfig();
            fConfig.ShowDialog(this);
            
        }


        private void webBrowser1_NewWindow(object sender, CancelEventArgs e)
        {
            e.Cancel = true;
            Program.NavigateUrl(((WebBrowser)sender).StatusText);
        }

        private void imgServerUp_DoubleClick(object sender, EventArgs e)
        {

            frmDebug fDebug = new frmDebug();
            fDebug.ShowDialog(this);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timerPlayEnabled.Enabled = false;
            btnMCLauncher.Enabled = true;
            btnPlay.Enabled = true;            
            this.Cursor = Cursors.Default;
        }

       
        private void timerCheckUpdate_Tick(object sender, EventArgs e)
        {
            bckCheckOnline.RunWorkerAsync();
        }

      
        public void Init()
        { 
            //

            //webBrowser1.Url = new Uri(Program.htmlpageurl);


            if (Config.GetRefreshSkin())
            {
                foreach(string file in Directory.GetFiles(DTC.Common.Paths.GetTempPath(),"*.png"))
                {
                    string test = file;

                    try
                    {
                        File.Delete(file);
                    }
                    catch (Exception E)
                    {
                        string tutu = "p";
                    }


                }

                Config.SetRefreshSkin(false);

            }


            if (Config.GetShowAds())
            {
                webBrowser1.Url = new Uri("http://www.danstoncube.com/twitter_ads/");
                webBrowser1.AllowNavigation = true;
            }
            else
            {
                webBrowser1.Url = new Uri("http://www.danstoncube.com/twitter/");
                //webBrowser1.AllowNavigation = false;
            }



            if (!Config.GetSimple())
            {
                cboPackages.Visible = true;
                btnPackages.Visible = true;
                lblPackages.Visible = true;
            }
            else
            {
                this.Height -= (cboPackages.Height + (cboServeurs.Top - cboComptes.Top - cboComptes.Height));
            }
            
            
            bckCheckOnline.RunWorkerAsync();
            
            this.Show();

            
            LoadPackages();
            LoadTools();
            LoadServeurs();

          

 





            bool testAccount = Program.CheckAccount();
            if (!testAccount)
            {
                MessageBox.Show(this, "Vous n'avez pas configuré de compte, ouverture de la configuration des comptes.");
                frmComptes fComptes = new frmComptes();
                fComptes.ShowDialog(this);
            }

            
            LoadAccounts();

            //
            bckCheckUpdate.RunWorkerAsync();
            //loading = false;
        }


       

      

        private void bckCheckOnline_DoWork(object sender, DoWorkEventArgs e)
        {
            CheckDTCOnlineSync();
        }

        private void bckCheckOnline_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (Program.serveronline)
            {
                lblPlayersOnline.Text = Program.playersonline.ToString() + " connecté(e)" + (Program.playersonline > 1 ? "s":"");
                lblPlayersOnline.Visible = true;
                imgServerTest.Visible = false;
                imgServerDown.Visible = false;
                imgServerUp.Visible = true;
            }
            else
            {
                lblPlayersOnline.Visible = false;
                imgServerTest.Visible = false;
                imgServerDown.Visible = true;
                imgServerUp.Visible = false;
            }
        }

        private void bckCheckUpdate_DoWork(object sender, DoWorkEventArgs e)
        {
            //CheckDTCUpdateSync();
        }





        private void bckCheckUpdate_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {


            /*
            if (Program.dtchttpversion == "")
            {
                MessageBox.Show("Impossible de savoir quelle est la dernière version du launcher sur le site !\nLancement sans vérification de version.");
            }
            else if(Program.dtchttpversion != Program.dtcversion)
            {
                MessageBox.Show("Votre launcher n'est pas à jour !\nL'application va se fermer automatiquement.\nPour mettre à jour le lanceur relancez-le tout simplement.","DTCLauncher", MessageBoxButtons.OK, MessageBoxIcon.Stop);
#if !DEBUG
                Application.Exit();
#endif
            }
            */


            CheckButtonColor();
        }

        private void btnServeurs_Click(object sender, EventArgs e)
        {
            frmServeurs fServeurs = new frmServeurs();
            fServeurs.ShowDialog(this);
            LoadServeurs();
        }

        private void cboServeurs_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckButtonColor();

            Config.SetLastServ(cboServeurs.Text);

            XmlElement server = null;
            server = (XmlElement) Program.xmlstaticservers.SelectSingleNode("//serveur[@nom='" + cboServeurs.Text + "']");
            if (server == null)
            {
                server = (XmlElement)Config._config.SelectSingleNode("//serveur[@nom='" + cboServeurs.Text + "']");
            }

            if (server != null)
            {
                if (server.GetAttribute("package") != "")
                {
                    cboPackages.Enabled = false;
                    //cboPackages.Text = server.GetAttribute("package");
                    //cboPackages.SelectedItem = ClientPackages.Packages.GetPackage(server.GetAttribute("package"));
                    SelectPackage(server.GetAttribute("package"));
                }
                else
                {                    
                    //cboPackages.Text = Config.GetLastPackage();
                    //cboPackages.SelectedItem = ClientPackages.Packages.GetPackage(Config.GetLastPackage());
                    SelectPackage(Config.GetLastPackage());
                    cboPackages.Enabled = true;
                }
            }
        }

       

        private void imgServerTest_DoubleClick(object sender, EventArgs e)
        {
            frmDebug fDebug = new frmDebug();
            fDebug.ShowDialog(this);
        }

      

        private void cboPackages_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (((ComboBox)sender).Enabled)
            {
                Config.SetLastPackage(cboPackages.Text);
            }
        }

        private void btnPackages_Click(object sender, EventArgs e)
        {
            Process p = new Process();
            p.StartInfo.FileName = "explorer.exe";
            p.StartInfo.Arguments = DTC.Common.Paths.GetLocalPackagesDir();
            p.Start();
        }



        private void btnTools_Click(object sender, EventArgs e)
        {
            mnuTools.Show(btnTools, new Point(5, 5 + (btnTools.Height / 2)));
        }



        private void mnuTools_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            //a remplacer par une fonction RunPackage("packagename");
            cPackage p = null;
            p = ClientPackages.Packages.GetPackage(e.ClickedItem.Tag.ToString());
            if (p == null) return;
            string runcmd = "";
            runcmd = p.GetParam("run");
            File.WriteAllText(".\\run.bat", DTC.Common.Paths.ComputePath(runcmd));
            Program.RunBatchFile(".\\run.bat");
            File.Delete(".\\run.bat");
        }

        private void mnuInstallMorePackages_Click(object sender, EventArgs e)
        {
            frmAddPackages fAddP = new frmAddPackages();
            fAddP.Show();
        }

        public static string skinname = "";
        private void bckGetSkin_DoWork(object sender, DoWorkEventArgs e)
        {
            
            string mcskinurl = String.Format(Program.skinurl, skinname);


            WebClient wc = new WebClient();
         
            try
            {
                wc.DownloadFile(new Uri(mcskinurl), DTC.Common.Paths.GetTempPath() + "\\" + skinname + ".png");
            }
            catch (WebException E)
            {
                switch (E.Status)
                {
                    case WebExceptionStatus.ProtocolError:
                        btnPlay.Image = DTC.Properties.Resources.Login_in48;
                        return;

                    default:
                        btnPlay.Image = DTC.Properties.Resources.Login_in48;
                        return;
                }
            }
            catch (Exception fatal)
            {
                btnPlay.Image = DTC.Properties.Resources.Login_in48;
                //MessageBox.Show("Erreur inconnue lors du téléchargement du skin: " + fatal.Message);
                return;
            }



        }

        private void bckGetSkin_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (File.Exists(DTC.Common.Paths.GetTempPath() + "\\" + skinname + ".png"))
            {
                try
                {
                    Bitmap tmp = new Bitmap(DTC.Common.Paths.GetTempPath() + "\\" + skinname + ".png");
                    btnPlay.Image = tmp;
                }
                catch
                {
                    btnPlay.Image = DTC.Properties.Resources.Login_in48;
                }
            }
        }



        private bool loading = true;
        private int ncount = 0;
        private void webBrowser1_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {

            if (Config.GetShowAds())
            {

                ncount++;
                if (ncount > 2)
                {
                    e.Cancel = true;
                    Program.NavigateUrl(e.Url.ToString());
                }
                else
                {
                    loading = false;
                }
            }
            else
            {
                ncount++;
                if (ncount > 1)
                {
                    e.Cancel = true;
                    Program.NavigateUrl(e.Url.ToString());
                }
                else
                {
                    loading = false;
                }
                
            }
        }

        private void webBrowser1_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            //loading = false;
        }

        private void webBrowser1_LocationChanged(object sender, EventArgs e)
        {
            loading = true;
        }

        
    }
}
