namespace DTC
{
    partial class frmServeurs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmServeurs));
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.btnSaveServeur = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboForcePackage = new System.Windows.Forms.ComboBox();
            this.chkForcePackage = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDeleteServeur = new System.Windows.Forms.Button();
            this.btnLoadServeur = new System.Windows.Forms.Button();
            this.lstServeurs = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNom
            // 
            this.txtNom.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNom.Location = new System.Drawing.Point(119, 6);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(234, 20);
            this.txtNom.TabIndex = 1;
            // 
            // txtUrl
            // 
            this.txtUrl.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUrl.Location = new System.Drawing.Point(119, 30);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(234, 20);
            this.txtUrl.TabIndex = 2;
            // 
            // btnSaveServeur
            // 
            this.btnSaveServeur.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveServeur.Image = global::DTC.Properties.Resources.Save48;
            this.btnSaveServeur.Location = new System.Drawing.Point(359, 2);
            this.btnSaveServeur.Name = "btnSaveServeur";
            this.btnSaveServeur.Size = new System.Drawing.Size(109, 74);
            this.btnSaveServeur.TabIndex = 4;
            this.btnSaveServeur.Text = "Enregistrer";
            this.btnSaveServeur.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSaveServeur.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSaveServeur.UseVisualStyleBackColor = true;
            this.btnSaveServeur.Click += new System.EventHandler(this.btnSaveServeur_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Url du serveur";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nom du serveur";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 5;
            // 
            // cboForcePackage
            // 
            this.cboForcePackage.Enabled = false;
            this.cboForcePackage.FormattingEnabled = true;
            this.cboForcePackage.Location = new System.Drawing.Point(232, 57);
            this.cboForcePackage.Name = "cboForcePackage";
            this.cboForcePackage.Size = new System.Drawing.Size(121, 21);
            this.cboForcePackage.TabIndex = 9;
            // 
            // chkForcePackage
            // 
            this.chkForcePackage.AutoSize = true;
            this.chkForcePackage.Location = new System.Drawing.Point(12, 59);
            this.chkForcePackage.Name = "chkForcePackage";
            this.chkForcePackage.Size = new System.Drawing.Size(206, 17);
            this.chkForcePackage.TabIndex = 10;
            this.chkForcePackage.Text = "Forcer la version de Minecraft";
            this.chkForcePackage.UseVisualStyleBackColor = true;
            this.chkForcePackage.CheckedChanged += new System.EventHandler(this.chkForcePackage_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDeleteServeur);
            this.groupBox1.Controls.Add(this.btnLoadServeur);
            this.groupBox1.Controls.Add(this.lstServeurs);
            this.groupBox1.Location = new System.Drawing.Point(8, 84);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(460, 124);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Liste des serveurs enregistrés:";
            // 
            // btnDeleteServeur
            // 
            this.btnDeleteServeur.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteServeur.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteServeur.Image")));
            this.btnDeleteServeur.Location = new System.Drawing.Point(361, 67);
            this.btnDeleteServeur.Name = "btnDeleteServeur";
            this.btnDeleteServeur.Size = new System.Drawing.Size(93, 42);
            this.btnDeleteServeur.TabIndex = 11;
            this.btnDeleteServeur.Text = "Supprimer";
            this.btnDeleteServeur.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDeleteServeur.UseVisualStyleBackColor = true;
            this.btnDeleteServeur.Click += new System.EventHandler(this.btnDeleteServer_Click);
            // 
            // btnLoadServeur
            // 
            this.btnLoadServeur.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadServeur.Image = ((System.Drawing.Image)(resources.GetObject("btnLoadServeur.Image")));
            this.btnLoadServeur.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoadServeur.Location = new System.Drawing.Point(360, 19);
            this.btnLoadServeur.Name = "btnLoadServeur";
            this.btnLoadServeur.Size = new System.Drawing.Size(93, 42);
            this.btnLoadServeur.TabIndex = 10;
            this.btnLoadServeur.Text = "Modifier";
            this.btnLoadServeur.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLoadServeur.UseVisualStyleBackColor = true;
            this.btnLoadServeur.Click += new System.EventHandler(this.btnLoadServeur_Click);
            // 
            // lstServeurs
            // 
            this.lstServeurs.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstServeurs.FormattingEnabled = true;
            this.lstServeurs.Location = new System.Drawing.Point(16, 19);
            this.lstServeurs.Name = "lstServeurs";
            this.lstServeurs.Size = new System.Drawing.Size(329, 95);
            this.lstServeurs.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(8, 214);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(460, 59);
            this.button1.TabIndex = 13;
            this.button1.Text = "Fermer et revenir au launcher";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmServeurs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 278);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chkForcePackage);
            this.Controls.Add(this.cboForcePackage);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSaveServeur);
            this.Controls.Add(this.txtUrl);
            this.Controls.Add(this.txtNom);
            this.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmServeurs";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Serveurs";
            this.Load += new System.EventHandler(this.frmServeurs_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Button btnSaveServeur;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboForcePackage;
        private System.Windows.Forms.CheckBox chkForcePackage;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDeleteServeur;
        private System.Windows.Forms.Button btnLoadServeur;
        private System.Windows.Forms.ListBox lstServeurs;
        private System.Windows.Forms.Button button1;
    }
}