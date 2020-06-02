namespace NeuroAttention
{
    partial class UpdateOK
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateOK));
            this.gunaPanel_updater = new Guna.UI.WinForms.GunaPanel();
            this.gunaPanel_checkupdate = new Guna.UI.WinForms.GunaPanel();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.gunaPanel_move = new Guna.UI.WinForms.GunaPanel();
            this.btn_checkupdate = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btn_more = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btn_back = new Guna.UI.WinForms.GunaAdvenceButton();
            this.lbl_updateinfo = new System.Windows.Forms.Label();
            this.gunaDragControl1 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.timer_checkupdate = new System.Windows.Forms.Timer(this.components);
            this.gunaPanel_updater.SuspendLayout();
            this.gunaPanel_checkupdate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaPanel_updater
            // 
            this.gunaPanel_updater.BackColor = System.Drawing.Color.Transparent;
            this.gunaPanel_updater.BackgroundImage = global::NeuroAttention.Properties.Resources.bg_updater;
            this.gunaPanel_updater.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gunaPanel_updater.Controls.Add(this.gunaPanel_checkupdate);
            this.gunaPanel_updater.Controls.Add(this.gunaPanel_move);
            this.gunaPanel_updater.Controls.Add(this.btn_checkupdate);
            this.gunaPanel_updater.Controls.Add(this.btn_more);
            this.gunaPanel_updater.Controls.Add(this.btn_back);
            this.gunaPanel_updater.Controls.Add(this.lbl_updateinfo);
            this.gunaPanel_updater.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaPanel_updater.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel_updater.Name = "gunaPanel_updater";
            this.gunaPanel_updater.Size = new System.Drawing.Size(400, 600);
            this.gunaPanel_updater.TabIndex = 20;
            // 
            // gunaPanel_checkupdate
            // 
            this.gunaPanel_checkupdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.gunaPanel_checkupdate.Controls.Add(this.gunaPictureBox1);
            this.gunaPanel_checkupdate.Location = new System.Drawing.Point(3, 257);
            this.gunaPanel_checkupdate.Name = "gunaPanel_checkupdate";
            this.gunaPanel_checkupdate.Size = new System.Drawing.Size(397, 343);
            this.gunaPanel_checkupdate.TabIndex = 24;
            this.gunaPanel_checkupdate.Visible = false;
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaPictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.gunaPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("gunaPictureBox1.Image")));
            this.gunaPictureBox1.Location = new System.Drawing.Point(150, 116);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(101, 84);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaPictureBox1.TabIndex = 23;
            this.gunaPictureBox1.TabStop = false;
            // 
            // gunaPanel_move
            // 
            this.gunaPanel_move.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaPanel_move.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel_move.Name = "gunaPanel_move";
            this.gunaPanel_move.Size = new System.Drawing.Size(400, 30);
            this.gunaPanel_move.TabIndex = 22;
            // 
            // btn_checkupdate
            // 
            this.btn_checkupdate.AnimationHoverSpeed = 0.07F;
            this.btn_checkupdate.AnimationSpeed = 0.03F;
            this.btn_checkupdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_checkupdate.BaseColor = System.Drawing.Color.Transparent;
            this.btn_checkupdate.BorderColor = System.Drawing.Color.Black;
            this.btn_checkupdate.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btn_checkupdate.CheckedBorderColor = System.Drawing.Color.Black;
            this.btn_checkupdate.CheckedForeColor = System.Drawing.Color.White;
            this.btn_checkupdate.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btn_checkupdate.CheckedImage")));
            this.btn_checkupdate.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btn_checkupdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_checkupdate.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_checkupdate.FocusedColor = System.Drawing.Color.Empty;
            this.btn_checkupdate.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_checkupdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_checkupdate.Image = null;
            this.btn_checkupdate.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_checkupdate.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_checkupdate.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_checkupdate.Location = new System.Drawing.Point(35, 541);
            this.btn_checkupdate.Name = "btn_checkupdate";
            this.btn_checkupdate.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.btn_checkupdate.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_checkupdate.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_checkupdate.OnHoverImage = null;
            this.btn_checkupdate.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_checkupdate.OnPressedColor = System.Drawing.Color.Black;
            this.btn_checkupdate.OnPressedDepth = 0;
            this.btn_checkupdate.Size = new System.Drawing.Size(333, 34);
            this.btn_checkupdate.TabIndex = 21;
            this.btn_checkupdate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_checkupdate.Click += new System.EventHandler(this.btn_checkupdate_Click);
            // 
            // btn_more
            // 
            this.btn_more.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_more.AnimationHoverSpeed = 0.07F;
            this.btn_more.AnimationSpeed = 0.03F;
            this.btn_more.BackColor = System.Drawing.Color.Transparent;
            this.btn_more.BaseColor = System.Drawing.Color.Transparent;
            this.btn_more.BorderColor = System.Drawing.Color.Black;
            this.btn_more.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btn_more.CheckedBorderColor = System.Drawing.Color.Black;
            this.btn_more.CheckedForeColor = System.Drawing.Color.White;
            this.btn_more.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btn_more.CheckedImage")));
            this.btn_more.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btn_more.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_more.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_more.FocusedColor = System.Drawing.Color.Empty;
            this.btn_more.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_more.ForeColor = System.Drawing.Color.White;
            this.btn_more.Image = null;
            this.btn_more.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_more.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_more.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_more.Location = new System.Drawing.Point(358, 36);
            this.btn_more.Name = "btn_more";
            this.btn_more.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.btn_more.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_more.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_more.OnHoverImage = null;
            this.btn_more.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_more.OnPressedColor = System.Drawing.Color.Black;
            this.btn_more.OnPressedDepth = 0;
            this.btn_more.Size = new System.Drawing.Size(40, 25);
            this.btn_more.TabIndex = 20;
            // 
            // btn_back
            // 
            this.btn_back.AnimationHoverSpeed = 0.07F;
            this.btn_back.AnimationSpeed = 0.03F;
            this.btn_back.BackColor = System.Drawing.Color.Transparent;
            this.btn_back.BaseColor = System.Drawing.Color.Transparent;
            this.btn_back.BorderColor = System.Drawing.Color.Black;
            this.btn_back.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btn_back.CheckedBorderColor = System.Drawing.Color.Black;
            this.btn_back.CheckedForeColor = System.Drawing.Color.White;
            this.btn_back.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btn_back.CheckedImage")));
            this.btn_back.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btn_back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_back.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_back.FocusedColor = System.Drawing.Color.Empty;
            this.btn_back.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_back.ForeColor = System.Drawing.Color.White;
            this.btn_back.Image = null;
            this.btn_back.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_back.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_back.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_back.Location = new System.Drawing.Point(6, 35);
            this.btn_back.Name = "btn_back";
            this.btn_back.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.btn_back.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_back.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_back.OnHoverImage = null;
            this.btn_back.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_back.OnPressedColor = System.Drawing.Color.Black;
            this.btn_back.OnPressedDepth = 0;
            this.btn_back.Size = new System.Drawing.Size(40, 25);
            this.btn_back.TabIndex = 18;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // lbl_updateinfo
            // 
            this.lbl_updateinfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_updateinfo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_updateinfo.Font = new System.Drawing.Font("Roboto Light", 10F);
            this.lbl_updateinfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.lbl_updateinfo.Location = new System.Drawing.Point(101, 425);
            this.lbl_updateinfo.Name = "lbl_updateinfo";
            this.lbl_updateinfo.Size = new System.Drawing.Size(194, 32);
            this.lbl_updateinfo.TabIndex = 15;
            this.lbl_updateinfo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // gunaDragControl1
            // 
            this.gunaDragControl1.TargetControl = this.gunaPanel_move;
            // 
            // timer_checkupdate
            // 
            this.timer_checkupdate.Tick += new System.EventHandler(this.timer_checkupdate_Tick);
            // 
            // UpdateOK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(400, 600);
            this.Controls.Add(this.gunaPanel_updater);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UpdateOK";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MayaClient - Yazılım Güncelleme";
            this.Load += new System.EventHandler(this.UpdateOK_Load);
            this.gunaPanel_updater.ResumeLayout(false);
            this.gunaPanel_checkupdate.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel gunaPanel_updater;
        private System.Windows.Forms.Label lbl_updateinfo;
        private Guna.UI.WinForms.GunaAdvenceButton btn_back;
        private Guna.UI.WinForms.GunaAdvenceButton btn_checkupdate;
        private Guna.UI.WinForms.GunaAdvenceButton btn_more;
        private Guna.UI.WinForms.GunaPanel gunaPanel_move;
        private Guna.UI.WinForms.GunaDragControl gunaDragControl1;
        private System.Windows.Forms.Timer timer_checkupdate;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private Guna.UI.WinForms.GunaPanel gunaPanel_checkupdate;
    }
}