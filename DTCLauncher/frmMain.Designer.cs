namespace DTC
{
    partial class frmMain
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.timerPlayEnabled = new System.Windows.Forms.Timer(this.components);
            this.mnuTools = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.imgServerTest = new System.Windows.Forms.PictureBox();
            this.imgServerDown = new System.Windows.Forms.PictureBox();
            this.timerCheckUpdate = new System.Windows.Forms.Timer(this.components);
            this.bckCheckOnline = new System.ComponentModel.BackgroundWorker();
            this.bckCheckUpdate = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblPackages = new System.Windows.Forms.Label();
            this.tTip = new System.Windows.Forms.ToolTip(this.components);
            this.cboComptes = new System.Windows.Forms.ComboBox();
            this.btnPackages = new System.Windows.Forms.Button();
            this.mnuPackages = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuInstallMorePackages = new System.Windows.Forms.ToolStripMenuItem();
            this.btnServeurs = new System.Windows.Forms.Button();
            this.cboServeurs = new System.Windows.Forms.ComboBox();
            this.btnComptes = new System.Windows.Forms.Button();
            this.cboPackages = new System.Windows.Forms.ComboBox();
            this.btnMCLauncher = new System.Windows.Forms.Button();
            this.btnConfig = new System.Windows.Forms.Button();
            this.btnTools = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.lblPlayersOnline = new System.Windows.Forms.Label();
            this.imgServerUp = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bckGetSkin = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.imgServerTest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgServerDown)).BeginInit();
            this.mnuPackages.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgServerUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(-246, 116);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(80, 17);
            this.checkBox2.TabIndex = 4;
            this.checkBox2.Text = "checkBox1";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // webBrowser1
            // 
            this.webBrowser1.AllowWebBrowserDrop = false;
            this.webBrowser1.IsWebBrowserContextMenuEnabled = false;
            this.webBrowser1.Location = new System.Drawing.Point(0, 69);
            this.webBrowser1.Margin = new System.Windows.Forms.Padding(0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScriptErrorsSuppressed = true;
            this.webBrowser1.ScrollBarsEnabled = false;
            this.webBrowser1.Size = new System.Drawing.Size(488, 182);
            this.webBrowser1.TabIndex = 6;
            this.webBrowser1.Url = new System.Uri("", System.UriKind.Relative);
            this.webBrowser1.WebBrowserShortcutsEnabled = false;
            this.webBrowser1.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.webBrowser1_Navigated);
            this.webBrowser1.Navigating += new System.Windows.Forms.WebBrowserNavigatingEventHandler(this.webBrowser1_Navigating);
            this.webBrowser1.NewWindow += new System.ComponentModel.CancelEventHandler(this.webBrowser1_NewWindow);
            this.webBrowser1.LocationChanged += new System.EventHandler(this.webBrowser1_LocationChanged);
            // 
            // timerPlayEnabled
            // 
            this.timerPlayEnabled.Interval = 5000;
            this.timerPlayEnabled.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // mnuTools
            // 
            this.mnuTools.Name = "mnuTools";
            this.mnuTools.Size = new System.Drawing.Size(61, 4);
            this.mnuTools.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.mnuTools_ItemClicked);
            // 
            // imgServerTest
            // 
            this.imgServerTest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.imgServerTest.Image = ((System.Drawing.Image)(resources.GetObject("imgServerTest.Image")));
            this.imgServerTest.Location = new System.Drawing.Point(306, 5);
            this.imgServerTest.Name = "imgServerTest";
            this.imgServerTest.Size = new System.Drawing.Size(27, 28);
            this.imgServerTest.TabIndex = 15;
            this.imgServerTest.TabStop = false;
            this.imgServerTest.DoubleClick += new System.EventHandler(this.imgServerUp_DoubleClick);
            // 
            // imgServerDown
            // 
            this.imgServerDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.imgServerDown.Image = ((System.Drawing.Image)(resources.GetObject("imgServerDown.Image")));
            this.imgServerDown.Location = new System.Drawing.Point(306, 5);
            this.imgServerDown.Name = "imgServerDown";
            this.imgServerDown.Size = new System.Drawing.Size(28, 28);
            this.imgServerDown.TabIndex = 10;
            this.imgServerDown.TabStop = false;
            this.imgServerDown.Visible = false;
            this.imgServerDown.DoubleClick += new System.EventHandler(this.imgServerUp_DoubleClick);
            // 
            // timerCheckUpdate
            // 
            this.timerCheckUpdate.Enabled = true;
            this.timerCheckUpdate.Interval = 60000;
            this.timerCheckUpdate.Tick += new System.EventHandler(this.timerCheckUpdate_Tick);
            // 
            // bckCheckOnline
            // 
            this.bckCheckOnline.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bckCheckOnline_DoWork);
            this.bckCheckOnline.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bckCheckOnline_RunWorkerCompleted);
            // 
            // bckCheckUpdate
            // 
            this.bckCheckUpdate.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bckCheckUpdate_DoWork);
            this.bckCheckUpdate.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bckCheckUpdate_RunWorkerCompleted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(21, 505);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 19);
            this.label1.TabIndex = 15;
            this.label1.Text = "Compte :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 545);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 19);
            this.label4.TabIndex = 16;
            this.label4.Text = "Serveur :";
            // 
            // lblPackages
            // 
            this.lblPackages.AutoSize = true;
            this.lblPackages.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPackages.ForeColor = System.Drawing.Color.White;
            this.lblPackages.Location = new System.Drawing.Point(12, 578);
            this.lblPackages.Name = "lblPackages";
            this.lblPackages.Size = new System.Drawing.Size(81, 19);
            this.lblPackages.TabIndex = 17;
            this.lblPackages.Text = "Paquet :";
            this.lblPackages.Visible = false;
            // 
            // cboComptes
            // 
            this.cboComptes.BackColor = System.Drawing.Color.DarkKhaki;
            this.cboComptes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboComptes.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboComptes.ForeColor = System.Drawing.Color.Black;
            this.cboComptes.FormattingEnabled = true;
            this.cboComptes.Location = new System.Drawing.Point(39, 89);
            this.cboComptes.Name = "cboComptes";
            this.cboComptes.Size = new System.Drawing.Size(326, 27);
            this.cboComptes.TabIndex = 21;
            this.tTip.SetToolTip(this.cboComptes, "Compte Minecraft.net");
            this.cboComptes.SelectedIndexChanged += new System.EventHandler(this.cboComptes_SelectedIndexChanged);
            // 
            // btnPackages
            // 
            this.btnPackages.BackColor = System.Drawing.Color.Transparent;
            this.btnPackages.ContextMenuStrip = this.mnuPackages;
            this.btnPackages.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPackages.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnPackages.Image = ((System.Drawing.Image)(resources.GetObject("btnPackages.Image")));
            this.btnPackages.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPackages.Location = new System.Drawing.Point(369, 153);
            this.btnPackages.Name = "btnPackages";
            this.btnPackages.Size = new System.Drawing.Size(118, 28);
            this.btnPackages.TabIndex = 26;
            this.btnPackages.Text = "Paquets";
            this.btnPackages.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.tTip.SetToolTip(this.btnPackages, "Ouvrir le dossier de paquets");
            this.btnPackages.UseVisualStyleBackColor = false;
            this.btnPackages.Visible = false;
            this.btnPackages.Click += new System.EventHandler(this.btnPackages_Click);
            // 
            // mnuPackages
            // 
            this.mnuPackages.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuInstallMorePackages});
            this.mnuPackages.Name = "mnuPackages";
            this.mnuPackages.ShowImageMargin = false;
            this.mnuPackages.ShowItemToolTips = false;
            this.mnuPackages.Size = new System.Drawing.Size(247, 26);
            // 
            // mnuInstallMorePackages
            // 
            this.mnuInstallMorePackages.Name = "mnuInstallMorePackages";
            this.mnuInstallMorePackages.Size = new System.Drawing.Size(246, 22);
            this.mnuInstallMorePackages.Tag = "addpackages";
            this.mnuInstallMorePackages.Text = "Installer des paquets supplémentaires";
            this.mnuInstallMorePackages.Click += new System.EventHandler(this.mnuInstallMorePackages_Click);
            // 
            // btnServeurs
            // 
            this.btnServeurs.BackColor = System.Drawing.Color.Transparent;
            this.btnServeurs.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServeurs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnServeurs.Image = ((System.Drawing.Image)(resources.GetObject("btnServeurs.Image")));
            this.btnServeurs.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnServeurs.Location = new System.Drawing.Point(369, 120);
            this.btnServeurs.Name = "btnServeurs";
            this.btnServeurs.Size = new System.Drawing.Size(118, 28);
            this.btnServeurs.TabIndex = 24;
            this.btnServeurs.Text = "Serveurs";
            this.btnServeurs.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.tTip.SetToolTip(this.btnServeurs, "Edition de la liste des serveurs");
            this.btnServeurs.UseVisualStyleBackColor = false;
            this.btnServeurs.Click += new System.EventHandler(this.btnServeurs_Click);
            // 
            // cboServeurs
            // 
            this.cboServeurs.BackColor = System.Drawing.Color.DarkKhaki;
            this.cboServeurs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboServeurs.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboServeurs.ForeColor = System.Drawing.Color.Black;
            this.cboServeurs.FormattingEnabled = true;
            this.cboServeurs.Items.AddRange(new object[] {
            "danstoncube.com",
            "minefield.fr"});
            this.cboServeurs.Location = new System.Drawing.Point(39, 121);
            this.cboServeurs.Name = "cboServeurs";
            this.cboServeurs.Size = new System.Drawing.Size(326, 27);
            this.cboServeurs.TabIndex = 22;
            this.tTip.SetToolTip(this.cboServeurs, "Serveur");
            this.cboServeurs.SelectedIndexChanged += new System.EventHandler(this.cboServeurs_SelectedIndexChanged);
            // 
            // btnComptes
            // 
            this.btnComptes.BackColor = System.Drawing.Color.Transparent;
            this.btnComptes.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComptes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnComptes.Image = ((System.Drawing.Image)(resources.GetObject("btnComptes.Image")));
            this.btnComptes.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnComptes.Location = new System.Drawing.Point(369, 88);
            this.btnComptes.Name = "btnComptes";
            this.btnComptes.Size = new System.Drawing.Size(118, 29);
            this.btnComptes.TabIndex = 23;
            this.btnComptes.Text = "Comptes";
            this.btnComptes.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.tTip.SetToolTip(this.btnComptes, "Edition des comptes");
            this.btnComptes.UseVisualStyleBackColor = false;
            this.btnComptes.Click += new System.EventHandler(this.btnComptes_Click);
            // 
            // cboPackages
            // 
            this.cboPackages.BackColor = System.Drawing.Color.DarkKhaki;
            this.cboPackages.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPackages.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPackages.ForeColor = System.Drawing.Color.Black;
            this.cboPackages.FormattingEnabled = true;
            this.cboPackages.Location = new System.Drawing.Point(39, 154);
            this.cboPackages.Name = "cboPackages";
            this.cboPackages.Size = new System.Drawing.Size(326, 27);
            this.cboPackages.TabIndex = 25;
            this.tTip.SetToolTip(this.cboPackages, "Paquet");
            this.cboPackages.Visible = false;
            this.cboPackages.SelectedIndexChanged += new System.EventHandler(this.cboPackages_SelectedIndexChanged);
            // 
            // btnMCLauncher
            // 
            this.btnMCLauncher.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMCLauncher.Image = ((System.Drawing.Image)(resources.GetObject("btnMCLauncher.Image")));
            this.btnMCLauncher.Location = new System.Drawing.Point(11, 3);
            this.btnMCLauncher.Name = "btnMCLauncher";
            this.btnMCLauncher.Size = new System.Drawing.Size(72, 58);
            this.btnMCLauncher.TabIndex = 33;
            this.btnMCLauncher.Text = "Minecraft";
            this.btnMCLauncher.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMCLauncher.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tTip.SetToolTip(this.btnMCLauncher, "Minecraft Original");
            this.btnMCLauncher.UseVisualStyleBackColor = true;
            this.btnMCLauncher.Click += new System.EventHandler(this.btnMCLauncher_Click);
            // 
            // btnConfig
            // 
            this.btnConfig.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfig.Image = global::DTC.Properties.Resources.Wheel_32;
            this.btnConfig.Location = new System.Drawing.Point(83, 3);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(72, 58);
            this.btnConfig.TabIndex = 34;
            this.btnConfig.Text = "Config";
            this.btnConfig.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnConfig.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tTip.SetToolTip(this.btnConfig, "Configuration");
            this.btnConfig.UseVisualStyleBackColor = true;
            this.btnConfig.Click += new System.EventHandler(this.btnConfig_Click);
            // 
            // btnTools
            // 
            this.btnTools.ContextMenuStrip = this.mnuTools;
            this.btnTools.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTools.ForeColor = System.Drawing.Color.Black;
            this.btnTools.Image = global::DTC.Properties.Resources.Tools_32;
            this.btnTools.Location = new System.Drawing.Point(154, 3);
            this.btnTools.Name = "btnTools";
            this.btnTools.Size = new System.Drawing.Size(72, 58);
            this.btnTools.TabIndex = 39;
            this.btnTools.Text = "Outils";
            this.btnTools.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTools.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnTools.UseVisualStyleBackColor = true;
            this.btnTools.Click += new System.EventHandler(this.btnTools_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.Transparent;
            this.btnPlay.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnPlay.FlatAppearance.BorderSize = 0;
            this.btnPlay.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPlay.Image = global::DTC.Properties.Resources.Login_in48;
            this.btnPlay.Location = new System.Drawing.Point(340, 3);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(138, 58);
            this.btnPlay.TabIndex = 32;
            this.btnPlay.Text = "Jouer!";
            this.btnPlay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPlay.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnDTCLauncher_Click);
            // 
            // lblPlayersOnline
            // 
            this.lblPlayersOnline.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayersOnline.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayersOnline.ForeColor = System.Drawing.Color.White;
            this.lblPlayersOnline.Location = new System.Drawing.Point(233, 44);
            this.lblPlayersOnline.Name = "lblPlayersOnline";
            this.lblPlayersOnline.Size = new System.Drawing.Size(103, 13);
            this.lblPlayersOnline.TabIndex = 38;
            this.lblPlayersOnline.Text = "X connecté(es)\r\n";
            this.lblPlayersOnline.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // imgServerUp
            // 
            this.imgServerUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.imgServerUp.Image = ((System.Drawing.Image)(resources.GetObject("imgServerUp.Image")));
            this.imgServerUp.Location = new System.Drawing.Point(306, 6);
            this.imgServerUp.Name = "imgServerUp";
            this.imgServerUp.Size = new System.Drawing.Size(25, 24);
            this.imgServerUp.TabIndex = 35;
            this.imgServerUp.TabStop = false;
            this.imgServerUp.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(232, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 19);
            this.label3.TabIndex = 36;
            this.label3.Text = "Serveur";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(202)))), ((int)(((byte)(255)))));
            this.pictureBox3.Location = new System.Drawing.Point(713, 229);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(10, 66);
            this.pictureBox3.TabIndex = 40;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(202)))), ((int)(((byte)(255)))));
            this.pictureBox4.Location = new System.Drawing.Point(656, 155);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(11, 74);
            this.pictureBox4.TabIndex = 41;
            this.pictureBox4.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.btnComptes);
            this.panel1.Controls.Add(this.btnServeurs);
            this.panel1.Controls.Add(this.btnPackages);
            this.panel1.Controls.Add(this.cboComptes);
            this.panel1.Controls.Add(this.cboPackages);
            this.panel1.Controls.Add(this.cboServeurs);
            this.panel1.Location = new System.Drawing.Point(-5, 250);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(493, 187);
            this.panel1.TabIndex = 42;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(202)))), ((int)(((byte)(255)))));
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel2.Controls.Add(this.imgServerUp);
            this.panel2.Controls.Add(this.btnConfig);
            this.panel2.Controls.Add(this.btnTools);
            this.panel2.Controls.Add(this.btnMCLauncher);
            this.panel2.Controls.Add(this.imgServerTest);
            this.panel2.Controls.Add(this.btnPlay);
            this.panel2.Controls.Add(this.imgServerDown);
            this.panel2.Controls.Add(this.lblPlayersOnline);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(0, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(488, 70);
            this.panel2.TabIndex = 43;
            // 
            // bckGetSkin
            // 
            this.bckGetSkin.WorkerSupportsCancellation = true;
            this.bckGetSkin.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bckGetSkin_DoWork);
            this.bckGetSkin.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bckGetSkin_RunWorkerCompleted);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(202)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(487, 436);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.lblPackages);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DansTonCube !";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgServerTest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgServerDown)).EndInit();
            this.mnuPackages.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgServerUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.PictureBox imgServerDown;
        private System.Windows.Forms.Timer timerPlayEnabled;
        private System.Windows.Forms.Timer timerCheckUpdate;
        private System.ComponentModel.BackgroundWorker bckCheckOnline;
        private System.ComponentModel.BackgroundWorker bckCheckUpdate;
        private System.Windows.Forms.PictureBox imgServerTest;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblPackages;
        private System.Windows.Forms.ToolTip tTip;
        private System.Windows.Forms.ContextMenuStrip mnuTools;
        private System.Windows.Forms.ComboBox cboComptes;
        private System.Windows.Forms.Button btnPackages;
        private System.Windows.Forms.Button btnServeurs;
        private System.Windows.Forms.ComboBox cboServeurs;
        private System.Windows.Forms.Button btnComptes;
        private System.Windows.Forms.ComboBox cboPackages;
        private System.Windows.Forms.Button btnMCLauncher;
        private System.Windows.Forms.Button btnTools;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnConfig;
        private System.Windows.Forms.Label lblPlayersOnline;
        private System.Windows.Forms.PictureBox imgServerUp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ContextMenuStrip mnuPackages;
        private System.Windows.Forms.ToolStripMenuItem mnuInstallMorePackages;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.ComponentModel.BackgroundWorker bckGetSkin;
    }
}

