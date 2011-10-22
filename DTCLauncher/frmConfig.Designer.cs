namespace DTC
{
    partial class frmConfig
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnOk = new System.Windows.Forms.Button();
            this.chkAutoClose = new System.Windows.Forms.CheckBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.fBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.dlgFindJava = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.optSimpleMode = new System.Windows.Forms.RadioButton();
            this.optAdvancedMode = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblMemoireTexte = new System.Windows.Forms.Label();
            this.numMemory = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdFindJava = new System.Windows.Forms.Button();
            this.txtJavaPath = new System.Windows.Forms.TextBox();
            this.chkShowSkin = new System.Windows.Forms.CheckBox();
            this.chkShowAds = new System.Windows.Forms.CheckBox();
            this.btnRefreshSkin = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMemory)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(171, 328);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(168, 33);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "Sauvegarder";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // chkAutoClose
            // 
            this.chkAutoClose.AutoSize = true;
            this.chkAutoClose.Checked = true;
            this.chkAutoClose.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAutoClose.Location = new System.Drawing.Point(16, 12);
            this.chkAutoClose.Name = "chkAutoClose";
            this.chkAutoClose.Size = new System.Drawing.Size(425, 19);
            this.chkAutoClose.TabIndex = 1;
            this.chkAutoClose.Text = "Fermer automatiquement le lanceur en démarrant Minecraft.";
            this.chkAutoClose.UseVisualStyleBackColor = true;
            this.chkAutoClose.CheckedChanged += new System.EventHandler(this.chkAutoClose_CheckedChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(345, 328);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(168, 33);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Annuler";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // dlgFindJava
            // 
            this.dlgFindJava.Filter = "Exécutable Javaw.exe|javaw.exe";
            this.dlgFindJava.InitialDirectory = "%programfiles%";
            this.dlgFindJava.Title = "Sélectionnez le fichier Javaw.exe";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.optSimpleMode);
            this.groupBox1.Controls.Add(this.optAdvancedMode);
            this.groupBox1.Location = new System.Drawing.Point(12, 130);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(668, 84);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "Mode du launcher";
            // 
            // optSimpleMode
            // 
            this.optSimpleMode.AutoSize = true;
            this.optSimpleMode.Location = new System.Drawing.Point(204, 28);
            this.optSimpleMode.Name = "optSimpleMode";
            this.optSimpleMode.Size = new System.Drawing.Size(192, 17);
            this.optSimpleMode.TabIndex = 12;
            this.optSimpleMode.TabStop = true;
            this.optSimpleMode.Text = "Simple (DansTonCube uniquement)";
            this.optSimpleMode.UseVisualStyleBackColor = true;
            this.optSimpleMode.CheckedChanged += new System.EventHandler(this.optSimpleMode_CheckedChanged);
            // 
            // optAdvancedMode
            // 
            this.optAdvancedMode.AutoSize = true;
            this.optAdvancedMode.Location = new System.Drawing.Point(204, 51);
            this.optAdvancedMode.Name = "optAdvancedMode";
            this.optAdvancedMode.Size = new System.Drawing.Size(209, 17);
            this.optAdvancedMode.TabIndex = 13;
            this.optAdvancedMode.TabStop = true;
            this.optAdvancedMode.Text = "Avancé (plusieurs minecrafts possibles)";
            this.optAdvancedMode.UseVisualStyleBackColor = true;
            this.optAdvancedMode.CheckedChanged += new System.EventHandler(this.optAdvancedMode_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSize = true;
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.lblMemoireTexte);
            this.groupBox2.Controls.Add(this.numMemory);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cmdFindJava);
            this.groupBox2.Controls.Add(this.txtJavaPath);
            this.groupBox2.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 220);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(668, 100);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 15);
            this.label3.TabIndex = 14;
            this.label3.Text = "Mémoire allouée pour java";
            // 
            // lblMemoireTexte
            // 
            this.lblMemoireTexte.AutoSize = true;
            this.lblMemoireTexte.Enabled = false;
            this.lblMemoireTexte.Location = new System.Drawing.Point(309, 57);
            this.lblMemoireTexte.Name = "lblMemoireTexte";
            this.lblMemoireTexte.Size = new System.Drawing.Size(98, 15);
            this.lblMemoireTexte.TabIndex = 13;
            this.lblMemoireTexte.Text = "Mo de mémoire";
            // 
            // numMemory
            // 
            this.numMemory.Increment = new decimal(new int[] {
            256,
            0,
            0,
            0});
            this.numMemory.Location = new System.Drawing.Point(241, 55);
            this.numMemory.Maximum = new decimal(new int[] {
            4096,
            0,
            0,
            0});
            this.numMemory.Minimum = new decimal(new int[] {
            256,
            0,
            0,
            0});
            this.numMemory.Name = "numMemory";
            this.numMemory.Size = new System.Drawing.Size(62, 23);
            this.numMemory.TabIndex = 12;
            this.numMemory.Value = new decimal(new int[] {
            1024,
            0,
            0,
            0});
            this.numMemory.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "Chemin javaw.exe";
            // 
            // cmdFindJava
            // 
            this.cmdFindJava.Location = new System.Drawing.Point(603, 25);
            this.cmdFindJava.Name = "cmdFindJava";
            this.cmdFindJava.Size = new System.Drawing.Size(37, 23);
            this.cmdFindJava.TabIndex = 10;
            this.cmdFindJava.Text = "...";
            this.cmdFindJava.UseVisualStyleBackColor = true;
            this.cmdFindJava.Click += new System.EventHandler(this.cmdFindJava_Click);
            // 
            // txtJavaPath
            // 
            this.txtJavaPath.Location = new System.Drawing.Point(240, 25);
            this.txtJavaPath.Name = "txtJavaPath";
            this.txtJavaPath.Size = new System.Drawing.Size(357, 23);
            this.txtJavaPath.TabIndex = 9;
            // 
            // chkShowSkin
            // 
            this.chkShowSkin.AutoSize = true;
            this.chkShowSkin.Checked = true;
            this.chkShowSkin.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkShowSkin.Location = new System.Drawing.Point(16, 32);
            this.chkShowSkin.Name = "chkShowSkin";
            this.chkShowSkin.Size = new System.Drawing.Size(278, 19);
            this.chkShowSkin.TabIndex = 15;
            this.chkShowSkin.Text = "Afficher le skin sur le bouton jouer";
            this.chkShowSkin.UseVisualStyleBackColor = true;
            this.chkShowSkin.CheckedChanged += new System.EventHandler(this.chkShowSkin_CheckedChanged);
            // 
            // chkShowAds
            // 
            this.chkShowAds.AutoSize = true;
            this.chkShowAds.Location = new System.Drawing.Point(16, 105);
            this.chkShowAds.Name = "chkShowAds";
            this.chkShowAds.Size = new System.Drawing.Size(397, 19);
            this.chkShowAds.TabIndex = 16;
            this.chkShowAds.Text = "Afficher les annonces google (supportez le serveur !)";
            this.chkShowAds.UseVisualStyleBackColor = true;
            this.chkShowAds.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btnRefreshSkin
            // 
            this.btnRefreshSkin.Location = new System.Drawing.Point(35, 57);
            this.btnRefreshSkin.Name = "btnRefreshSkin";
            this.btnRefreshSkin.Size = new System.Drawing.Size(345, 28);
            this.btnRefreshSkin.TabIndex = 17;
            this.btnRefreshSkin.Text = "Rafraîchir les skins* (au prochain redémarrage)";
            this.btnRefreshSkin.UseVisualStyleBackColor = true;
            this.btnRefreshSkin.Click += new System.EventHandler(this.btnRefreshSkin_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(386, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(245, 15);
            this.label4.TabIndex = 18;
            this.label4.Text = "* Sur le launcher ET le site web !";
            // 
            // frmConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 365);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnRefreshSkin);
            this.Controls.Add(this.chkShowSkin);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.chkShowAds);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chkAutoClose);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmConfig";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Configuration avancée";
            this.Load += new System.EventHandler(this.frmConfig_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMemory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.CheckBox chkAutoClose;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.FolderBrowserDialog fBrowserDialog;
        private System.Windows.Forms.OpenFileDialog dlgFindJava;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton optAdvancedMode;
        private System.Windows.Forms.RadioButton optSimpleMode;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblMemoireTexte;
        private System.Windows.Forms.NumericUpDown numMemory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdFindJava;
        private System.Windows.Forms.TextBox txtJavaPath;
        private System.Windows.Forms.CheckBox chkShowSkin;
        private System.Windows.Forms.CheckBox chkShowAds;
        private System.Windows.Forms.Button btnRefreshSkin;
        private System.Windows.Forms.Label label4;
    }
}