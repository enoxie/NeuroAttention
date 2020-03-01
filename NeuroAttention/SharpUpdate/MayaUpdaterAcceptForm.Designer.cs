namespace SharpUpdate
{
    partial class MayaUpdaterAcceptForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MayaUpdaterAcceptForm));
            this.lblUpdateAvailable = new System.Windows.Forms.Label();
            this.lblNewVersion = new System.Windows.Forms.Label();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.btnYes = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnNo = new Guna.UI.WinForms.GunaAdvenceButton();
            this.lbl_updateinfo = new System.Windows.Forms.Label();
            this.lbl_currentVersion = new System.Windows.Forms.Label();
            this.gunaPanel3 = new Guna.UI.WinForms.GunaPanel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            this.gunaPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblUpdateAvailable
            // 
            this.lblUpdateAvailable.AutoSize = true;
            this.lblUpdateAvailable.BackColor = System.Drawing.Color.Transparent;
            this.lblUpdateAvailable.Font = new System.Drawing.Font("Museo Sans 100", 20F);
            this.lblUpdateAvailable.ForeColor = System.Drawing.Color.White;
            this.lblUpdateAvailable.Location = new System.Drawing.Point(26, 149);
            this.lblUpdateAvailable.Name = "lblUpdateAvailable";
            this.lblUpdateAvailable.Size = new System.Drawing.Size(159, 64);
            this.lblUpdateAvailable.TabIndex = 1;
            this.lblUpdateAvailable.Text = "Yeni Sürüm \r\nMevcut";
            // 
            // lblNewVersion
            // 
            this.lblNewVersion.BackColor = System.Drawing.Color.Transparent;
            this.lblNewVersion.Font = new System.Drawing.Font("Museo Sans 500", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewVersion.ForeColor = System.Drawing.Color.White;
            this.lblNewVersion.Location = new System.Drawing.Point(33, 383);
            this.lblNewVersion.Name = "lblNewVersion";
            this.lblNewVersion.Size = new System.Drawing.Size(154, 19);
            this.lblNewVersion.TabIndex = 2;
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("gunaPictureBox1.Image")));
            this.gunaPictureBox1.Location = new System.Drawing.Point(0, 0);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(131, 94);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaPictureBox1.TabIndex = 11;
            this.gunaPictureBox1.TabStop = false;
            // 
            // btnYes
            // 
            this.btnYes.AnimationHoverSpeed = 0.07F;
            this.btnYes.AnimationSpeed = 0.03F;
            this.btnYes.BackColor = System.Drawing.Color.Red;
            this.btnYes.BaseColor = System.Drawing.Color.Transparent;
            this.btnYes.BorderColor = System.Drawing.Color.Black;
            this.btnYes.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnYes.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnYes.CheckedForeColor = System.Drawing.Color.White;
            this.btnYes.CheckedImage = null;
            this.btnYes.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnYes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnYes.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnYes.FocusedColor = System.Drawing.Color.Empty;
            this.btnYes.Font = new System.Drawing.Font("Museo Sans 700", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYes.ForeColor = System.Drawing.Color.White;
            this.btnYes.Image = null;
            this.btnYes.ImageSize = new System.Drawing.Size(20, 20);
            this.btnYes.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnYes.Location = new System.Drawing.Point(32, 418);
            this.btnYes.Name = "btnYes";
            this.btnYes.OnHoverBaseColor = System.Drawing.Color.Red;
            this.btnYes.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnYes.OnHoverForeColor = System.Drawing.Color.White;
            this.btnYes.OnHoverImage = null;
            this.btnYes.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnYes.OnPressedColor = System.Drawing.Color.Black;
            this.btnYes.Size = new System.Drawing.Size(157, 47);
            this.btnYes.TabIndex = 13;
            this.btnYes.Text = "GÜNCELLE";
            this.btnYes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // btnNo
            // 
            this.btnNo.AnimationHoverSpeed = 0.07F;
            this.btnNo.AnimationSpeed = 0.03F;
            this.btnNo.BackColor = System.Drawing.Color.Transparent;
            this.btnNo.BaseColor = System.Drawing.Color.Transparent;
            this.btnNo.BorderColor = System.Drawing.Color.Black;
            this.btnNo.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnNo.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnNo.CheckedForeColor = System.Drawing.Color.White;
            this.btnNo.CheckedImage = null;
            this.btnNo.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnNo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNo.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnNo.FocusedColor = System.Drawing.Color.Empty;
            this.btnNo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnNo.ForeColor = System.Drawing.Color.White;
            this.btnNo.Image = null;
            this.btnNo.ImageSize = new System.Drawing.Size(20, 20);
            this.btnNo.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnNo.Location = new System.Drawing.Point(209, 419);
            this.btnNo.Name = "btnNo";
            this.btnNo.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.btnNo.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnNo.OnHoverForeColor = System.Drawing.Color.White;
            this.btnNo.OnHoverImage = null;
            this.btnNo.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnNo.OnPressedColor = System.Drawing.Color.Black;
            this.btnNo.Size = new System.Drawing.Size(155, 45);
            this.btnNo.TabIndex = 14;
            this.btnNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // lbl_updateinfo
            // 
            this.lbl_updateinfo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_updateinfo.Font = new System.Drawing.Font("Museo Sans 100", 15F);
            this.lbl_updateinfo.ForeColor = System.Drawing.Color.White;
            this.lbl_updateinfo.Location = new System.Drawing.Point(28, 241);
            this.lbl_updateinfo.Name = "lbl_updateinfo";
            this.lbl_updateinfo.Size = new System.Drawing.Size(305, 142);
            this.lbl_updateinfo.TabIndex = 15;
            this.lbl_updateinfo.Text = "Güncelleme hakkında bilgi";
            // 
            // lbl_currentVersion
            // 
            this.lbl_currentVersion.BackColor = System.Drawing.Color.Transparent;
            this.lbl_currentVersion.Font = new System.Drawing.Font("Museo Sans 500", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_currentVersion.ForeColor = System.Drawing.Color.White;
            this.lbl_currentVersion.Location = new System.Drawing.Point(33, 364);
            this.lbl_currentVersion.Name = "lbl_currentVersion";
            this.lbl_currentVersion.Size = new System.Drawing.Size(154, 19);
            this.lbl_currentVersion.TabIndex = 16;
            // 
            // gunaPanel3
            // 
            this.gunaPanel3.BackColor = System.Drawing.Color.Transparent;
            this.gunaPanel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gunaPanel3.BackgroundImage")));
            this.gunaPanel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gunaPanel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gunaPanel3.Controls.Add(this.label1);
            this.gunaPanel3.Controls.Add(this.lbl_currentVersion);
            this.gunaPanel3.Controls.Add(this.gunaPictureBox1);
            this.gunaPanel3.Controls.Add(this.lbl_updateinfo);
            this.gunaPanel3.Controls.Add(this.lblUpdateAvailable);
            this.gunaPanel3.Controls.Add(this.btnNo);
            this.gunaPanel3.Controls.Add(this.lblNewVersion);
            this.gunaPanel3.Controls.Add(this.btnYes);
            this.gunaPanel3.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel3.Name = "gunaPanel3";
            this.gunaPanel3.Size = new System.Drawing.Size(400, 500);
            this.gunaPanel3.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.label1.Font = new System.Drawing.Font("Museo Sans 100", 20F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(97, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 32);
            this.label1.TabIndex = 17;
            this.label1.Text = "Updater";
            // 
            // SharpUpdateAcceptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(400, 500);
            this.Controls.Add(this.gunaPanel3);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SharpUpdateAcceptForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            this.gunaPanel3.ResumeLayout(false);
            this.gunaPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblUpdateAvailable;
        private System.Windows.Forms.Label lblNewVersion;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private Guna.UI.WinForms.GunaAdvenceButton btnYes;
        private Guna.UI.WinForms.GunaAdvenceButton btnNo;
        private System.Windows.Forms.Label lbl_updateinfo;
        private System.Windows.Forms.Label lbl_currentVersion;
        private Guna.UI.WinForms.GunaPanel gunaPanel3;
        private System.Windows.Forms.Label label1;
    }
}