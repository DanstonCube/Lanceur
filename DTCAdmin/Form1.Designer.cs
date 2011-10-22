namespace DTCAdmin
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.ListViewGroup listViewGroup3 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "TOTO",
            "TITI"}, -1);
            this.label1 = new System.Windows.Forms.Label();
            this.tabPackages = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSaveXml = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.txtPackagesFile = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.listViewFiles = new System.Windows.Forms.ListView();
            this.columnHeaderFile = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderUrl = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderMD5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderMD5Local = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel5 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.txtIcon = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chkShowInLauncher = new System.Windows.Forms.CheckBox();
            this.numericVersion = new System.Windows.Forms.NumericUpDown();
            this.chkForceInstall = new System.Windows.Forms.CheckBox();
            this.chkOptionnal = new System.Windows.Forms.CheckBox();
            this.cboType = new System.Windows.Forms.ComboBox();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtRun = new System.Windows.Forms.TextBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnExportPackageXml = new System.Windows.Forms.Button();
            this.btnUpdateMD5s = new System.Windows.Forms.Button();
            this.btnIncrementVersion = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtArchive = new System.Windows.Forms.TextBox();
            this.txtFolder = new System.Windows.Forms.TextBox();
            this.txtLabel = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.tabPackages.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericVersion)).BeginInit();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // tabPackages
            // 
            this.tabPackages.Controls.Add(this.tabPage1);
            this.tabPackages.Controls.Add(this.tabPage2);
            this.tabPackages.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabPackages.ImageList = this.imageList1;
            this.tabPackages.Location = new System.Drawing.Point(0, 0);
            this.tabPackages.Name = "tabPackages";
            this.tabPackages.SelectedIndex = 0;
            this.tabPackages.Size = new System.Drawing.Size(749, 18);
            this.tabPackages.TabIndex = 5;
            this.tabPackages.SelectedIndexChanged += new System.EventHandler(this.tabPackages_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 23);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(741, 0);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 23);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(741, 0);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "KO.png");
            this.imageList1.Images.SetKeyName(1, "OK.png");
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 499);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(749, 10);
            this.panel1.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.btnSaveXml);
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Controls.Add(this.txtPackagesFile);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(749, 63);
            this.panel2.TabIndex = 10;
            // 
            // btnSaveXml
            // 
            this.btnSaveXml.Location = new System.Drawing.Point(424, 8);
            this.btnSaveXml.Name = "btnSaveXml";
            this.btnSaveXml.Size = new System.Drawing.Size(159, 48);
            this.btnSaveXml.TabIndex = 13;
            this.btnSaveXml.Text = "ENREGISTRER PACKAGES.XML";
            this.btnSaveXml.UseVisualStyleBackColor = true;
            this.btnSaveXml.Click += new System.EventHandler(this.btnSaveXml_Click);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.button4);
            this.panel7.Controls.Add(this.button3);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel7.Location = new System.Drawing.Point(602, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(147, 63);
            this.panel7.TabIndex = 12;
            // 
            // button4
            // 
            this.button4.Enabled = false;
            this.button4.Location = new System.Drawing.Point(3, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(138, 23);
            this.button4.TabIndex = 12;
            this.button4.Text = "Uploader Packages.xml";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(3, 33);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(138, 23);
            this.button3.TabIndex = 12;
            this.button3.Text = "Uploader Tous";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // txtPackagesFile
            // 
            this.txtPackagesFile.Location = new System.Drawing.Point(12, 10);
            this.txtPackagesFile.Name = "txtPackagesFile";
            this.txtPackagesFile.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtPackagesFile.Size = new System.Drawing.Size(363, 20);
            this.txtPackagesFile.TabIndex = 9;
            this.txtPackagesFile.Text = "D:\\DOCZ\\My Dropbox\\DEV\\DansTonCube\\SERVEURDEV\\Packages";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(381, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(37, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(2, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(138, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Uploader";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.tabPackages);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 63);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(749, 436);
            this.panel3.TabIndex = 11;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 18);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(749, 418);
            this.panel4.TabIndex = 6;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.listViewFiles);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 281);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(749, 137);
            this.panel6.TabIndex = 1;
            // 
            // listViewFiles
            // 
            this.listViewFiles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.listViewFiles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderFile,
            this.columnHeaderUrl,
            this.columnHeaderMD5,
            this.columnHeaderMD5Local});
            this.listViewFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            listViewGroup3.Header = "ListViewGroup";
            listViewGroup3.Name = "listViewGroup1";
            this.listViewFiles.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup3});
            this.listViewFiles.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem3});
            this.listViewFiles.Location = new System.Drawing.Point(0, 0);
            this.listViewFiles.Name = "listViewFiles";
            this.listViewFiles.ShowGroups = false;
            this.listViewFiles.Size = new System.Drawing.Size(749, 137);
            this.listViewFiles.TabIndex = 9;
            this.listViewFiles.UseCompatibleStateImageBehavior = false;
            this.listViewFiles.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderFile
            // 
            this.columnHeaderFile.Text = "Destination";
            this.columnHeaderFile.Width = 236;
            // 
            // columnHeaderUrl
            // 
            this.columnHeaderUrl.Text = "Url";
            this.columnHeaderUrl.Width = 84;
            // 
            // columnHeaderMD5
            // 
            this.columnHeaderMD5.Text = "MD5";
            this.columnHeaderMD5.Width = 204;
            // 
            // columnHeaderMD5Local
            // 
            this.columnHeaderMD5Local.Text = "MD5 (local)";
            this.columnHeaderMD5Local.Width = 215;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel5.Controls.Add(this.label10);
            this.panel5.Controls.Add(this.txtIcon);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.chkShowInLauncher);
            this.panel5.Controls.Add(this.numericVersion);
            this.panel5.Controls.Add(this.chkForceInstall);
            this.panel5.Controls.Add(this.chkOptionnal);
            this.panel5.Controls.Add(this.cboType);
            this.panel5.Controls.Add(this.txtUrl);
            this.panel5.Controls.Add(this.label9);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Controls.Add(this.txtRun);
            this.panel5.Controls.Add(this.panel8);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.txtArchive);
            this.panel5.Controls.Add(this.txtFolder);
            this.panel5.Controls.Add(this.txtLabel);
            this.panel5.Controls.Add(this.txtName);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(749, 281);
            this.panel5.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 183);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(27, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "Run";
            // 
            // txtIcon
            // 
            this.txtIcon.Location = new System.Drawing.Point(53, 152);
            this.txtIcon.Name = "txtIcon";
            this.txtIcon.Size = new System.Drawing.Size(281, 20);
            this.txtIcon.TabIndex = 23;
            this.txtIcon.TextChanged += new System.EventHandler(this.txtIcon_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Icon";
            // 
            // chkShowInLauncher
            // 
            this.chkShowInLauncher.AutoSize = true;
            this.chkShowInLauncher.Location = new System.Drawing.Point(343, 103);
            this.chkShowInLauncher.Name = "chkShowInLauncher";
            this.chkShowInLauncher.Size = new System.Drawing.Size(112, 17);
            this.chkShowInLauncher.TabIndex = 21;
            this.chkShowInLauncher.Text = "show_in_launcher";
            this.chkShowInLauncher.UseVisualStyleBackColor = true;
            this.chkShowInLauncher.CheckedChanged += new System.EventHandler(this.chkShowInLauncher_CheckedChanged);
            // 
            // numericVersion
            // 
            this.numericVersion.Location = new System.Drawing.Point(387, 37);
            this.numericVersion.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numericVersion.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericVersion.Name = "numericVersion";
            this.numericVersion.Size = new System.Drawing.Size(76, 20);
            this.numericVersion.TabIndex = 20;
            this.numericVersion.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericVersion.ValueChanged += new System.EventHandler(this.numericVersion_ValueChanged);
            // 
            // chkForceInstall
            // 
            this.chkForceInstall.AutoSize = true;
            this.chkForceInstall.Location = new System.Drawing.Point(343, 83);
            this.chkForceInstall.Name = "chkForceInstall";
            this.chkForceInstall.Size = new System.Drawing.Size(82, 17);
            this.chkForceInstall.TabIndex = 19;
            this.chkForceInstall.Text = "force_install";
            this.chkForceInstall.UseVisualStyleBackColor = true;
            this.chkForceInstall.CheckedChanged += new System.EventHandler(this.chkForceInstall_CheckedChanged);
            // 
            // chkOptionnal
            // 
            this.chkOptionnal.AutoSize = true;
            this.chkOptionnal.Location = new System.Drawing.Point(343, 63);
            this.chkOptionnal.Name = "chkOptionnal";
            this.chkOptionnal.Size = new System.Drawing.Size(69, 17);
            this.chkOptionnal.TabIndex = 18;
            this.chkOptionnal.Text = "optionnal";
            this.chkOptionnal.UseVisualStyleBackColor = true;
            this.chkOptionnal.CheckedChanged += new System.EventHandler(this.chkOptionnal_CheckedChanged);
            // 
            // cboType
            // 
            this.cboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboType.FormattingEnabled = true;
            this.cboType.Items.AddRange(new object[] {
            "",
            "program",
            "tool",
            "minecraft"});
            this.cboType.Location = new System.Drawing.Point(53, 9);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(145, 21);
            this.cboType.TabIndex = 17;
            this.cboType.SelectedIndexChanged += new System.EventHandler(this.cboType_SelectedIndexChanged);
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(53, 126);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(281, 20);
            this.txtUrl.TabIndex = 16;
            this.txtUrl.TextChanged += new System.EventHandler(this.txtUrl_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(5, 84);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Dossier";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Label";
            // 
            // txtRun
            // 
            this.txtRun.AcceptsReturn = true;
            this.txtRun.Location = new System.Drawing.Point(53, 183);
            this.txtRun.Multiline = true;
            this.txtRun.Name = "txtRun";
            this.txtRun.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtRun.Size = new System.Drawing.Size(540, 90);
            this.txtRun.TabIndex = 13;
            this.txtRun.WordWrap = false;
            this.txtRun.TextChanged += new System.EventHandler(this.txtRun_TextChanged);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.btnExportPackageXml);
            this.panel8.Controls.Add(this.btnUpdateMD5s);
            this.panel8.Controls.Add(this.btnIncrementVersion);
            this.panel8.Controls.Add(this.button2);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel8.Location = new System.Drawing.Point(602, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(147, 281);
            this.panel8.TabIndex = 12;
            this.panel8.Paint += new System.Windows.Forms.PaintEventHandler(this.panel8_Paint);
            // 
            // btnExportPackageXml
            // 
            this.btnExportPackageXml.Location = new System.Drawing.Point(2, 32);
            this.btnExportPackageXml.Name = "btnExportPackageXml";
            this.btnExportPackageXml.Size = new System.Drawing.Size(139, 20);
            this.btnExportPackageXml.TabIndex = 14;
            this.btnExportPackageXml.Text = "SRV Package.xml";
            this.btnExportPackageXml.UseVisualStyleBackColor = true;
            this.btnExportPackageXml.Click += new System.EventHandler(this.btnExportPackageXml_Click);
            // 
            // btnUpdateMD5s
            // 
            this.btnUpdateMD5s.Location = new System.Drawing.Point(2, 84);
            this.btnUpdateMD5s.Name = "btnUpdateMD5s";
            this.btnUpdateMD5s.Size = new System.Drawing.Size(138, 23);
            this.btnUpdateMD5s.TabIndex = 13;
            this.btnUpdateMD5s.Text = "MAJ MD5";
            this.btnUpdateMD5s.UseVisualStyleBackColor = true;
            this.btnUpdateMD5s.Click += new System.EventHandler(this.btnUpdateMD5s_Click);
            // 
            // btnIncrementVersion
            // 
            this.btnIncrementVersion.Location = new System.Drawing.Point(2, 57);
            this.btnIncrementVersion.Name = "btnIncrementVersion";
            this.btnIncrementVersion.Size = new System.Drawing.Size(138, 23);
            this.btnIncrementVersion.TabIndex = 12;
            this.btnIncrementVersion.Text = "Version++";
            this.btnIncrementVersion.UseVisualStyleBackColor = true;
            this.btnIncrementVersion.Click += new System.EventHandler(this.btnIncrementVersion_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 129);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "DL Url";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Archive";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(340, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "version";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nom";
            // 
            // txtArchive
            // 
            this.txtArchive.Location = new System.Drawing.Point(53, 104);
            this.txtArchive.Name = "txtArchive";
            this.txtArchive.Size = new System.Drawing.Size(281, 20);
            this.txtArchive.TabIndex = 3;
            this.txtArchive.TextChanged += new System.EventHandler(this.txtArchive_TextChanged);
            // 
            // txtFolder
            // 
            this.txtFolder.Location = new System.Drawing.Point(53, 81);
            this.txtFolder.Name = "txtFolder";
            this.txtFolder.Size = new System.Drawing.Size(281, 20);
            this.txtFolder.TabIndex = 2;
            this.txtFolder.TextChanged += new System.EventHandler(this.txtFolder_TextChanged);
            // 
            // txtLabel
            // 
            this.txtLabel.Location = new System.Drawing.Point(53, 59);
            this.txtLabel.Name = "txtLabel";
            this.txtLabel.Size = new System.Drawing.Size(281, 20);
            this.txtLabel.TabIndex = 1;
            this.txtLabel.TextChanged += new System.EventHandler(this.txtLabel_TextChanged);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(53, 36);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(281, 20);
            this.txtName.TabIndex = 0;
            this.txtName.Text = "txtName";
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(749, 509);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(590, 360);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabPackages.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericVersion)).EndInit();
            this.panel8.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabPackages;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtPackagesFile;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.ListView listViewFiles;
        private System.Windows.Forms.ColumnHeader columnHeaderFile;
        private System.Windows.Forms.ColumnHeader columnHeaderUrl;
        private System.Windows.Forms.ColumnHeader columnHeaderMD5;
        private System.Windows.Forms.ColumnHeader columnHeaderMD5Local;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtArchive;
        private System.Windows.Forms.TextBox txtFolder;
        private System.Windows.Forms.TextBox txtLabel;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtRun;
        private System.Windows.Forms.ComboBox cboType;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtIcon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkShowInLauncher;
        private System.Windows.Forms.NumericUpDown numericVersion;
        private System.Windows.Forms.CheckBox chkForceInstall;
        private System.Windows.Forms.CheckBox chkOptionnal;
        private System.Windows.Forms.Button btnUpdateMD5s;
        private System.Windows.Forms.Button btnIncrementVersion;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnSaveXml;
        private System.Windows.Forms.Button btnExportPackageXml;
    }
}

