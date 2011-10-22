namespace BinVoxGui
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnBinvoxBrowse = new System.Windows.Forms.Button();
            this.btnCmdPrompt = new System.Windows.Forms.Button();
            this.btnObjBrowse = new System.Windows.Forms.Button();
            this.btnSchematicBrowse = new System.Windows.Forms.Button();
            this.tabMenu = new System.Windows.Forms.TabControl();
            this.tabOpen = new System.Windows.Forms.TabPage();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnBrowseBinvox = new System.Windows.Forms.Button();
            this.cboBinvox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabConvert = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.numericBi = new System.Windows.Forms.NumericUpDown();
            this.chkBi = new System.Windows.Forms.CheckBox();
            this.chkCb = new System.Windows.Forms.CheckBox();
            this.chkRi = new System.Windows.Forms.CheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCustomParams = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.optDown = new System.Windows.Forms.RadioButton();
            this.numericD = new System.Windows.Forms.NumericUpDown();
            this.optD = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.optDown256 = new System.Windows.Forms.RadioButton();
            this.optDown128 = new System.Windows.Forms.RadioButton();
            this.optDown64 = new System.Windows.Forms.RadioButton();
            this.optDown32 = new System.Windows.Forms.RadioButton();
            this.optDown16 = new System.Windows.Forms.RadioButton();
            this.optDown8 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.optTypeSchematic = new System.Windows.Forms.RadioButton();
            this.optTypeBinvox = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnBrowseObj = new System.Windows.Forms.Button();
            this.cboObj = new System.Windows.Forms.ComboBox();
            this.btnLaunchBinvox = new System.Windows.Forms.Button();
            this.btnLaunchViewvox = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.tabMenu.SuspendLayout();
            this.tabOpen.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.tabConvert.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericBi)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericD)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBinvoxBrowse
            // 
            this.btnBinvoxBrowse.Image = ((System.Drawing.Image)(resources.GetObject("btnBinvoxBrowse.Image")));
            this.btnBinvoxBrowse.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBinvoxBrowse.Location = new System.Drawing.Point(553, 65);
            this.btnBinvoxBrowse.Name = "btnBinvoxBrowse";
            this.btnBinvoxBrowse.Size = new System.Drawing.Size(144, 37);
            this.btnBinvoxBrowse.TabIndex = 0;
            this.btnBinvoxBrowse.Text = "Dossier \"Binvox\"";
            this.btnBinvoxBrowse.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnBinvoxBrowse.UseVisualStyleBackColor = true;
            this.btnBinvoxBrowse.Click += new System.EventHandler(this.btnBinvoxBrowse_Click);
            // 
            // btnCmdPrompt
            // 
            this.btnCmdPrompt.Image = ((System.Drawing.Image)(resources.GetObject("btnCmdPrompt.Image")));
            this.btnCmdPrompt.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCmdPrompt.Location = new System.Drawing.Point(553, 22);
            this.btnCmdPrompt.Name = "btnCmdPrompt";
            this.btnCmdPrompt.Size = new System.Drawing.Size(144, 37);
            this.btnCmdPrompt.TabIndex = 1;
            this.btnCmdPrompt.Text = "Invite de commande";
            this.btnCmdPrompt.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCmdPrompt.UseVisualStyleBackColor = true;
            this.btnCmdPrompt.Click += new System.EventHandler(this.btnCmdPrompt_Click);
            // 
            // btnObjBrowse
            // 
            this.btnObjBrowse.Image = ((System.Drawing.Image)(resources.GetObject("btnObjBrowse.Image")));
            this.btnObjBrowse.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnObjBrowse.Location = new System.Drawing.Point(553, 108);
            this.btnObjBrowse.Name = "btnObjBrowse";
            this.btnObjBrowse.Size = new System.Drawing.Size(144, 37);
            this.btnObjBrowse.TabIndex = 2;
            this.btnObjBrowse.Text = "Dossier \"Objets\"";
            this.btnObjBrowse.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnObjBrowse.UseVisualStyleBackColor = true;
            this.btnObjBrowse.Click += new System.EventHandler(this.btnObjBrowse_Click);
            // 
            // btnSchematicBrowse
            // 
            this.btnSchematicBrowse.Image = ((System.Drawing.Image)(resources.GetObject("btnSchematicBrowse.Image")));
            this.btnSchematicBrowse.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSchematicBrowse.Location = new System.Drawing.Point(553, 151);
            this.btnSchematicBrowse.Name = "btnSchematicBrowse";
            this.btnSchematicBrowse.Size = new System.Drawing.Size(144, 35);
            this.btnSchematicBrowse.TabIndex = 3;
            this.btnSchematicBrowse.Text = "Dossier \"Schematics\"";
            this.btnSchematicBrowse.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSchematicBrowse.UseVisualStyleBackColor = true;
            this.btnSchematicBrowse.Click += new System.EventHandler(this.btnSchematicBrowse_Click);
            // 
            // tabMenu
            // 
            this.tabMenu.Controls.Add(this.tabOpen);
            this.tabMenu.Controls.Add(this.tabConvert);
            this.tabMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.tabMenu.Location = new System.Drawing.Point(0, 0);
            this.tabMenu.Name = "tabMenu";
            this.tabMenu.SelectedIndex = 0;
            this.tabMenu.Size = new System.Drawing.Size(547, 327);
            this.tabMenu.TabIndex = 4;
            this.tabMenu.SelectedIndexChanged += new System.EventHandler(this.tabMenu_SelectedIndexChanged);
            // 
            // tabOpen
            // 
            this.tabOpen.Controls.Add(this.groupBox7);
            this.tabOpen.Controls.Add(this.btnBrowseBinvox);
            this.tabOpen.Controls.Add(this.cboBinvox);
            this.tabOpen.Controls.Add(this.label2);
            this.tabOpen.Controls.Add(this.label1);
            this.tabOpen.Location = new System.Drawing.Point(4, 22);
            this.tabOpen.Name = "tabOpen";
            this.tabOpen.Padding = new System.Windows.Forms.Padding(3);
            this.tabOpen.Size = new System.Drawing.Size(539, 301);
            this.tabOpen.TabIndex = 0;
            this.tabOpen.Text = "Visualiser";
            this.tabOpen.UseVisualStyleBackColor = true;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.label16);
            this.groupBox7.Controls.Add(this.label15);
            this.groupBox7.Controls.Add(this.label14);
            this.groupBox7.Controls.Add(this.label11);
            this.groupBox7.Controls.Add(this.label10);
            this.groupBox7.Controls.Add(this.label8);
            this.groupBox7.Controls.Add(this.label7);
            this.groupBox7.Controls.Add(this.label5);
            this.groupBox7.Controls.Add(this.label12);
            this.groupBox7.Controls.Add(this.label9);
            this.groupBox7.Controls.Add(this.label13);
            this.groupBox7.Controls.Add(this.label6);
            this.groupBox7.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox7.Location = new System.Drawing.Point(6, 129);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(525, 161);
            this.groupBox7.TabIndex = 17;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Rappel des touches :";
            // 
            // label16
            // 
            this.label16.Font = new System.Drawing.Font("Consolas", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(19, 142);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(478, 13);
            this.label16.TabIndex = 21;
            this.label16.Text = "*la couche en cours est affichée dans la fenètre noire sous la forme \"Slice_index" +
                " is now: XX\"";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(10, 127);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(169, 13);
            this.label15.TabIndex = 20;
            this.label15.Text = "K - Descendre d\'une couche*";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(10, 114);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(151, 13);
            this.label14.TabIndex = 19;
            this.label14.Text = "J - Monter d\'une couche*";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(370, 91);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "Z - Vue de";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(370, 67);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "X - Vue de";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(370, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Y - Vue du dessus";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(10, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(313, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "N - Changer le nombre de couches à afficher (1-2-3)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(211, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "A - Alterner la couleur des blocks";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(10, 17);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(403, 13);
            this.label12.TabIndex = 12;
            this.label12.Text = "CLIC GAUCHE - Bouger la vue (en maintenant le clic-gauche enfoncé)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(10, 43);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(433, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "CLIC DROIT - Zoomer (bouger la souris en maintenant clic-droit enfoncé)";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(10, 30);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(427, 13);
            this.label13.TabIndex = 13;
            this.label13.Text = "CLIC MOLETTE - Déplacer la vue (en maintenant le clic-molette enfoncé)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(10, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(295, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "S - Alterner vue d\'ensemble ou couche par couche";
            // 
            // btnBrowseBinvox
            // 
            this.btnBrowseBinvox.Location = new System.Drawing.Point(458, 94);
            this.btnBrowseBinvox.Name = "btnBrowseBinvox";
            this.btnBrowseBinvox.Size = new System.Drawing.Size(75, 21);
            this.btnBrowseBinvox.TabIndex = 3;
            this.btnBrowseBinvox.Text = "Parcourir...";
            this.btnBrowseBinvox.UseVisualStyleBackColor = true;
            this.btnBrowseBinvox.Click += new System.EventHandler(this.btnBrowseBinvox_Click);
            // 
            // cboBinvox
            // 
            this.cboBinvox.FormattingEnabled = true;
            this.cboBinvox.Location = new System.Drawing.Point(8, 95);
            this.cboBinvox.Name = "cboBinvox";
            this.cboBinvox.Size = new System.Drawing.Size(449, 21);
            this.cboBinvox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(534, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Choisissez un fichier \".binvox\" dans la liste ou cliquez sur parcourir pour chois" +
                "ir un autre fichier.";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(528, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Viewvox permet de visualiser les fichier .binvox générés par binvox, afin de pouv" +
                "oir les manipuler couche par couche.";
            // 
            // tabConvert
            // 
            this.tabConvert.Controls.Add(this.groupBox6);
            this.tabConvert.Controls.Add(this.groupBox5);
            this.tabConvert.Controls.Add(this.groupBox3);
            this.tabConvert.Controls.Add(this.groupBox2);
            this.tabConvert.Controls.Add(this.groupBox4);
            this.tabConvert.Location = new System.Drawing.Point(4, 22);
            this.tabConvert.Name = "tabConvert";
            this.tabConvert.Padding = new System.Windows.Forms.Padding(3);
            this.tabConvert.Size = new System.Drawing.Size(539, 301);
            this.tabConvert.TabIndex = 1;
            this.tabConvert.Text = "Convertir";
            this.tabConvert.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.numericBi);
            this.groupBox6.Controls.Add(this.chkBi);
            this.groupBox6.Controls.Add(this.chkCb);
            this.groupBox6.Controls.Add(this.chkRi);
            this.groupBox6.Location = new System.Drawing.Point(8, 153);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(514, 65);
            this.groupBox6.TabIndex = 35;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Paramètres supplémentaires";
            // 
            // numericBi
            // 
            this.numericBi.Location = new System.Drawing.Point(274, 41);
            this.numericBi.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericBi.Name = "numericBi";
            this.numericBi.Size = new System.Drawing.Size(65, 20);
            this.numericBi.TabIndex = 34;
            this.numericBi.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // chkBi
            // 
            this.chkBi.AutoSize = true;
            this.chkBi.Location = new System.Drawing.Point(21, 42);
            this.chkBi.Name = "chkBi";
            this.chkBi.Size = new System.Drawing.Size(247, 17);
            this.chkBi.TabIndex = 33;
            this.chkBi.Text = "(-bi) Type de block en sortie (pour .schematic) :";
            this.chkBi.UseVisualStyleBackColor = true;
            // 
            // chkCb
            // 
            this.chkCb.AutoSize = true;
            this.chkCb.Checked = true;
            this.chkCb.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkCb.Location = new System.Drawing.Point(274, 19);
            this.chkCb.Name = "chkCb";
            this.chkCb.Size = new System.Drawing.Size(195, 17);
            this.chkCb.TabIndex = 32;
            this.chkCb.Text = "(-cb) Centrer le modèle dans la boite";
            this.chkCb.UseVisualStyleBackColor = true;
            // 
            // chkRi
            // 
            this.chkRi.AutoSize = true;
            this.chkRi.Checked = true;
            this.chkRi.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkRi.Location = new System.Drawing.Point(21, 19);
            this.chkRi.Name = "chkRi";
            this.chkRi.Size = new System.Drawing.Size(171, 17);
            this.chkRi.TabIndex = 31;
            this.chkRi.Text = "(-ri) Enleve les blocks intérieurs";
            this.chkRi.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.txtCustomParams);
            this.groupBox5.Location = new System.Drawing.Point(8, 220);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(514, 78);
            this.groupBox5.TabIndex = 33;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Paramètres supplémentaires personnalisés";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "Saisir les paramètres";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(359, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "(Lancer binvox dans l\'invite de commande pour voir la liste des paramètres)";
            // 
            // txtCustomParams
            // 
            this.txtCustomParams.Location = new System.Drawing.Point(136, 27);
            this.txtCustomParams.Name = "txtCustomParams";
            this.txtCustomParams.Size = new System.Drawing.Size(354, 20);
            this.txtCustomParams.TabIndex = 33;
            this.txtCustomParams.TextChanged += new System.EventHandler(this.txtCustomParams_TextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.optDown);
            this.groupBox3.Controls.Add(this.numericD);
            this.groupBox3.Controls.Add(this.optD);
            this.groupBox3.Controls.Add(this.groupBox1);
            this.groupBox3.Location = new System.Drawing.Point(8, 90);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(514, 64);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Taille de sortie";
            // 
            // optDown
            // 
            this.optDown.AutoSize = true;
            this.optDown.Checked = true;
            this.optDown.Location = new System.Drawing.Point(21, 14);
            this.optDown.Name = "optDown";
            this.optDown.Size = new System.Drawing.Size(214, 17);
            this.optDown.TabIndex = 3;
            this.optDown.TabStop = true;
            this.optDown.Text = "Taille max. prédéfinie (meilleure qualitée)";
            this.optDown.UseVisualStyleBackColor = true;
            // 
            // numericD
            // 
            this.numericD.Increment = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numericD.Location = new System.Drawing.Point(241, 37);
            this.numericD.Maximum = new decimal(new int[] {
            1024,
            0,
            0,
            0});
            this.numericD.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numericD.Name = "numericD";
            this.numericD.Size = new System.Drawing.Size(64, 20);
            this.numericD.TabIndex = 21;
            this.numericD.Value = new decimal(new int[] {
            64,
            0,
            0,
            0});
            // 
            // optD
            // 
            this.optD.AutoSize = true;
            this.optD.Location = new System.Drawing.Point(21, 37);
            this.optD.Name = "optD";
            this.optD.Size = new System.Drawing.Size(179, 17);
            this.optD.TabIndex = 4;
            this.optD.Text = "Taille du cube max. personalisée";
            this.optD.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.optDown256);
            this.groupBox1.Controls.Add(this.optDown128);
            this.groupBox1.Controls.Add(this.optDown64);
            this.groupBox1.Controls.Add(this.optDown32);
            this.groupBox1.Controls.Add(this.optDown16);
            this.groupBox1.Controls.Add(this.optDown8);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(241, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(267, 31);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            // 
            // optDown256
            // 
            this.optDown256.AutoSize = true;
            this.optDown256.Location = new System.Drawing.Point(221, 9);
            this.optDown256.Name = "optDown256";
            this.optDown256.Size = new System.Drawing.Size(43, 17);
            this.optDown256.TabIndex = 26;
            this.optDown256.Text = "256";
            this.optDown256.UseVisualStyleBackColor = true;
            // 
            // optDown128
            // 
            this.optDown128.AutoSize = true;
            this.optDown128.Location = new System.Drawing.Point(172, 9);
            this.optDown128.Name = "optDown128";
            this.optDown128.Size = new System.Drawing.Size(43, 17);
            this.optDown128.TabIndex = 25;
            this.optDown128.Text = "128";
            this.optDown128.UseVisualStyleBackColor = true;
            // 
            // optDown64
            // 
            this.optDown64.AutoSize = true;
            this.optDown64.Checked = true;
            this.optDown64.Location = new System.Drawing.Point(129, 9);
            this.optDown64.Name = "optDown64";
            this.optDown64.Size = new System.Drawing.Size(37, 17);
            this.optDown64.TabIndex = 24;
            this.optDown64.TabStop = true;
            this.optDown64.Text = "64";
            this.optDown64.UseVisualStyleBackColor = true;
            // 
            // optDown32
            // 
            this.optDown32.AutoSize = true;
            this.optDown32.Location = new System.Drawing.Point(86, 9);
            this.optDown32.Name = "optDown32";
            this.optDown32.Size = new System.Drawing.Size(37, 17);
            this.optDown32.TabIndex = 23;
            this.optDown32.Text = "32";
            this.optDown32.UseVisualStyleBackColor = true;
            // 
            // optDown16
            // 
            this.optDown16.AutoSize = true;
            this.optDown16.Location = new System.Drawing.Point(43, 9);
            this.optDown16.Name = "optDown16";
            this.optDown16.Size = new System.Drawing.Size(37, 17);
            this.optDown16.TabIndex = 22;
            this.optDown16.Text = "16";
            this.optDown16.UseVisualStyleBackColor = true;
            // 
            // optDown8
            // 
            this.optDown8.AutoSize = true;
            this.optDown8.Location = new System.Drawing.Point(6, 9);
            this.optDown8.Name = "optDown8";
            this.optDown8.Size = new System.Drawing.Size(31, 17);
            this.optDown8.TabIndex = 21;
            this.optDown8.Text = "8";
            this.optDown8.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.optTypeSchematic);
            this.groupBox2.Controls.Add(this.optTypeBinvox);
            this.groupBox2.Location = new System.Drawing.Point(8, 48);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(514, 42);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Format de sortie";
            // 
            // optTypeSchematic
            // 
            this.optTypeSchematic.AutoSize = true;
            this.optTypeSchematic.Location = new System.Drawing.Point(158, 19);
            this.optTypeSchematic.Name = "optTypeSchematic";
            this.optTypeSchematic.Size = new System.Drawing.Size(140, 17);
            this.optTypeSchematic.TabIndex = 8;
            this.optTypeSchematic.Text = ".schematic (pour mcedit)";
            this.optTypeSchematic.UseVisualStyleBackColor = true;
            // 
            // optTypeBinvox
            // 
            this.optTypeBinvox.AutoSize = true;
            this.optTypeBinvox.Checked = true;
            this.optTypeBinvox.Location = new System.Drawing.Point(21, 19);
            this.optTypeBinvox.Name = "optTypeBinvox";
            this.optTypeBinvox.Size = new System.Drawing.Size(131, 17);
            this.optTypeBinvox.TabIndex = 7;
            this.optTypeBinvox.TabStop = true;
            this.optTypeBinvox.Text = ".binvox (pour viewvox)";
            this.optTypeBinvox.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnBrowseObj);
            this.groupBox4.Controls.Add(this.cboObj);
            this.groupBox4.Location = new System.Drawing.Point(8, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(514, 42);
            this.groupBox4.TabIndex = 25;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Fichier à convertir";
            // 
            // btnBrowseObj
            // 
            this.btnBrowseObj.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnBrowseObj.Location = new System.Drawing.Point(413, 15);
            this.btnBrowseObj.Name = "btnBrowseObj";
            this.btnBrowseObj.Size = new System.Drawing.Size(92, 21);
            this.btnBrowseObj.TabIndex = 4;
            this.btnBrowseObj.Text = "Parcourir...";
            this.btnBrowseObj.UseVisualStyleBackColor = true;
            this.btnBrowseObj.Click += new System.EventHandler(this.btnBrowseObj_Click);
            // 
            // cboObj
            // 
            this.cboObj.FormattingEnabled = true;
            this.cboObj.Location = new System.Drawing.Point(6, 15);
            this.cboObj.Name = "cboObj";
            this.cboObj.Size = new System.Drawing.Size(401, 21);
            this.cboObj.TabIndex = 3;
            // 
            // btnLaunchBinvox
            // 
            this.btnLaunchBinvox.Location = new System.Drawing.Point(553, 276);
            this.btnLaunchBinvox.Name = "btnLaunchBinvox";
            this.btnLaunchBinvox.Size = new System.Drawing.Size(144, 51);
            this.btnLaunchBinvox.TabIndex = 26;
            this.btnLaunchBinvox.Text = "Convertir";
            this.btnLaunchBinvox.UseVisualStyleBackColor = true;
            this.btnLaunchBinvox.Visible = false;
            this.btnLaunchBinvox.Click += new System.EventHandler(this.btnLaunchBinvox_Click);
            // 
            // btnLaunchViewvox
            // 
            this.btnLaunchViewvox.Location = new System.Drawing.Point(553, 276);
            this.btnLaunchViewvox.Name = "btnLaunchViewvox";
            this.btnLaunchViewvox.Size = new System.Drawing.Size(144, 51);
            this.btnLaunchViewvox.TabIndex = 4;
            this.btnLaunchViewvox.Text = "Visualiser";
            this.btnLaunchViewvox.UseVisualStyleBackColor = true;
            this.btnLaunchViewvox.Click += new System.EventHandler(this.btnLaunchViewvox_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 327);
            this.Controls.Add(this.tabMenu);
            this.Controls.Add(this.btnLaunchViewvox);
            this.Controls.Add(this.btnSchematicBrowse);
            this.Controls.Add(this.btnBinvoxBrowse);
            this.Controls.Add(this.btnLaunchBinvox);
            this.Controls.Add(this.btnObjBrowse);
            this.Controls.Add(this.btnCmdPrompt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DTC - Interface graphique pour binvox";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.tabMenu.ResumeLayout(false);
            this.tabOpen.ResumeLayout(false);
            this.tabOpen.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.tabConvert.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericBi)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericD)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBinvoxBrowse;
        private System.Windows.Forms.Button btnCmdPrompt;
        private System.Windows.Forms.Button btnObjBrowse;
        private System.Windows.Forms.Button btnSchematicBrowse;
        private System.Windows.Forms.TabControl tabMenu;
        private System.Windows.Forms.TabPage tabConvert;
        private System.Windows.Forms.NumericUpDown numericD;
        private System.Windows.Forms.RadioButton optD;
        private System.Windows.Forms.RadioButton optDown;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnBrowseObj;
        private System.Windows.Forms.ComboBox cboObj;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton optDown256;
        private System.Windows.Forms.RadioButton optDown128;
        private System.Windows.Forms.RadioButton optDown64;
        private System.Windows.Forms.RadioButton optDown32;
        private System.Windows.Forms.RadioButton optDown16;
        private System.Windows.Forms.RadioButton optDown8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton optTypeSchematic;
        private System.Windows.Forms.RadioButton optTypeBinvox;
        private System.Windows.Forms.TabPage tabOpen;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnBrowseBinvox;
        private System.Windows.Forms.ComboBox cboBinvox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.NumericUpDown numericBi;
        private System.Windows.Forms.CheckBox chkBi;
        private System.Windows.Forms.CheckBox chkCb;
        private System.Windows.Forms.CheckBox chkRi;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCustomParams;
        private System.Windows.Forms.Button btnLaunchBinvox;
        private System.Windows.Forms.Button btnLaunchViewvox;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}

