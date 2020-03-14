namespace SharpUpdate
{
    partial class MayaUpdaterDownloadForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MayaUpdaterDownloadForm));
            this.gunaPanel3 = new Guna.UI.WinForms.GunaPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClose = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaProgressBar1 = new Guna.UI.WinForms.GunaProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDownloading = new System.Windows.Forms.Label();
            this.lblProgress = new System.Windows.Forms.Label();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.gunaPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaPanel3
            // 
            this.gunaPanel3.BackColor = System.Drawing.Color.Transparent;
            this.gunaPanel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gunaPanel3.BackgroundImage")));
            this.gunaPanel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gunaPanel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gunaPanel3.Controls.Add(this.label2);
            this.gunaPanel3.Controls.Add(this.btnClose);
            this.gunaPanel3.Controls.Add(this.gunaProgressBar1);
            this.gunaPanel3.Controls.Add(this.label1);
            this.gunaPanel3.Controls.Add(this.lblDownloading);
            this.gunaPanel3.Controls.Add(this.lblProgress);
            this.gunaPanel3.Controls.Add(this.gunaPictureBox1);
            this.gunaPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaPanel3.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel3.Name = "gunaPanel3";
            this.gunaPanel3.Size = new System.Drawing.Size(400, 500);
            this.gunaPanel3.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Infoma Line", 15F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(18, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(346, 49);
            this.label2.TabIndex = 22;
            this.label2.Text = "MayaUpdater uzak sunucudan dosyaları indiriyor.";
            // 
            // btnClose
            // 
            this.btnClose.AnimationHoverSpeed = 0.07F;
            this.btnClose.AnimationSpeed = 0.03F;
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BaseColor = System.Drawing.Color.Transparent;
            this.btnClose.BorderColor = System.Drawing.Color.Black;
            this.btnClose.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnClose.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnClose.CheckedForeColor = System.Drawing.Color.White;
            this.btnClose.CheckedImage = null;
            this.btnClose.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnClose.FocusedColor = System.Drawing.Color.Empty;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Image = null;
            this.btnClose.ImageSize = new System.Drawing.Size(20, 20);
            this.btnClose.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnClose.Location = new System.Drawing.Point(208, 417);
            this.btnClose.Name = "btnClose";
            this.btnClose.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.btnClose.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnClose.OnHoverForeColor = System.Drawing.Color.White;
            this.btnClose.OnHoverImage = null;
            this.btnClose.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnClose.OnPressedColor = System.Drawing.Color.Black;
            this.btnClose.Size = new System.Drawing.Size(155, 45);
            this.btnClose.TabIndex = 21;
            this.btnClose.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // gunaProgressBar1
            // 
            this.gunaProgressBar1.BorderColor = System.Drawing.Color.Black;
            this.gunaProgressBar1.ColorStyle = Guna.UI.WinForms.ColorStyle.Default;
            this.gunaProgressBar1.IdleColor = System.Drawing.Color.Gainsboro;
            this.gunaProgressBar1.Location = new System.Drawing.Point(22, 306);
            this.gunaProgressBar1.Name = "gunaProgressBar1";
            this.gunaProgressBar1.ProgressMaxColor = System.Drawing.Color.Red;
            this.gunaProgressBar1.ProgressMinColor = System.Drawing.Color.Red;
            this.gunaProgressBar1.Size = new System.Drawing.Size(344, 23);
            this.gunaProgressBar1.TabIndex = 20;
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
            // lblDownloading
            // 
            this.lblDownloading.AutoSize = true;
            this.lblDownloading.Font = new System.Drawing.Font("Infoma Line", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDownloading.ForeColor = System.Drawing.Color.White;
            this.lblDownloading.Location = new System.Drawing.Point(16, 157);
            this.lblDownloading.Name = "lblDownloading";
            this.lblDownloading.Size = new System.Drawing.Size(346, 32);
            this.lblDownloading.TabIndex = 0;
            this.lblDownloading.Text = "Güncelleme İndiriliyor...";
            // 
            // lblProgress
            // 
            this.lblProgress.ForeColor = System.Drawing.Color.White;
            this.lblProgress.Location = new System.Drawing.Point(22, 332);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(344, 13);
            this.lblProgress.TabIndex = 2;
            this.lblProgress.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            // MayaUpdaterDownloadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 500);
            this.Controls.Add(this.gunaPanel3);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MayaUpdaterDownloadForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MayaUpdater - Yazılım Güncellemesi";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SharpUpdateDownloadForm_FormClosed);
            this.gunaPanel3.ResumeLayout(false);
            this.gunaPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel gunaPanel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDownloading;
        private System.Windows.Forms.Label lblProgress;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private Guna.UI.WinForms.GunaProgressBar gunaProgressBar1;
        private Guna.UI.WinForms.GunaAdvenceButton btnClose;
        private System.Windows.Forms.Label label2;
    }
}