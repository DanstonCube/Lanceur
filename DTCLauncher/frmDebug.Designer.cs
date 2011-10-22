namespace DTC
{
    partial class frmDebug
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
            this.btnResetSettings = new System.Windows.Forms.Button();
            this.txtJarMD5 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtInstalledJarMD5 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMcVersion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtInstalledMcVersion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtJarVersion = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnResetSettings
            // 
            this.btnResetSettings.Location = new System.Drawing.Point(12, 167);
            this.btnResetSettings.Name = "btnResetSettings";
            this.btnResetSettings.Size = new System.Drawing.Size(231, 46);
            this.btnResetSettings.TabIndex = 0;
            this.btnResetSettings.Text = "Effacer settings.xml";
            this.btnResetSettings.UseVisualStyleBackColor = true;
            this.btnResetSettings.Click += new System.EventHandler(this.btnResetSettings_Click);
            // 
            // txtJarMD5
            // 
            this.txtJarMD5.Location = new System.Drawing.Point(12, 28);
            this.txtJarMD5.Name = "txtJarMD5";
            this.txtJarMD5.Size = new System.Drawing.Size(231, 20);
            this.txtJarMD5.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "MD5 Minecraft.jar INSTALL\\";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(249, 167);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(268, 46);
            this.button1.TabIndex = 3;
            this.button1.Text = "Editer settings.xml";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtInstalledJarMD5
            // 
            this.txtInstalledJarMD5.Location = new System.Drawing.Point(12, 70);
            this.txtInstalledJarMD5.Name = "txtInstalledJarMD5";
            this.txtInstalledJarMD5.Size = new System.Drawing.Size(231, 20);
            this.txtInstalledJarMD5.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "MD5 Minecraft.jar %installpath%";
            // 
            // txtMcVersion
            // 
            this.txtMcVersion.Location = new System.Drawing.Point(286, 28);
            this.txtMcVersion.Name = "txtMcVersion";
            this.txtMcVersion.Size = new System.Drawing.Size(231, 20);
            this.txtMcVersion.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(283, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Minecraft version launcher";
            // 
            // txtInstalledMcVersion
            // 
            this.txtInstalledMcVersion.Location = new System.Drawing.Point(286, 70);
            this.txtInstalledMcVersion.Name = "txtInstalledMcVersion";
            this.txtInstalledMcVersion.Size = new System.Drawing.Size(231, 20);
            this.txtInstalledMcVersion.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(283, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Minecraft version installee";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Program jar MD5";
            // 
            // txtJarVersion
            // 
            this.txtJarVersion.Location = new System.Drawing.Point(12, 106);
            this.txtJarVersion.Name = "txtJarVersion";
            this.txtJarVersion.Size = new System.Drawing.Size(231, 20);
            this.txtJarVersion.TabIndex = 7;
            // 
            // frmDebug
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 224);
            this.Controls.Add(this.txtJarVersion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtInstalledMcVersion);
            this.Controls.Add(this.txtMcVersion);
            this.Controls.Add(this.txtInstalledJarMD5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtJarMD5);
            this.Controls.Add(this.btnResetSettings);
            this.Name = "frmDebug";
            this.Text = "frmDebug";
            this.Load += new System.EventHandler(this.frmDebug_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnResetSettings;
        private System.Windows.Forms.TextBox txtJarMD5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtInstalledJarMD5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMcVersion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtInstalledMcVersion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtJarVersion;
    }
}