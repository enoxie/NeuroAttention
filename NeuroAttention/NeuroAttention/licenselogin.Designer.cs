namespace NeuroAttention
{
    partial class LicenseLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LicenseLogin));
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.txt_email = new ns1.BunifuMetroTextbox();
            this.txt_license = new ns1.BunifuMetroTextbox();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.lbl_licenseinfo = new Guna.UI.WinForms.GunaLabel();
            this.timer_license = new System.Windows.Forms.Timer(this.components);
            this.btn_purchaselicense = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btn_back = new Guna.UI.WinForms.GunaAdvenceButton();
            this.SuspendLayout();
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.White;
            this.gunaLabel1.Location = new System.Drawing.Point(33, 144);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(78, 32);
            this.gunaLabel1.TabIndex = 1;
            this.gunaLabel1.Text = "Lisans";
            this.gunaLabel1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(185)))), ((int)(((byte)(185)))));
            this.gunaLabel2.Location = new System.Drawing.Point(36, 176);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(273, 17);
            this.gunaLabel2.TabIndex = 2;
            this.gunaLabel2.Text = "E-postanızı ve lisans anahtarınızı aşağıya girin";
            this.gunaLabel2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txt_email
            // 
            this.txt_email.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.txt_email.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(146)))), ((int)(((byte)(72)))));
            this.txt_email.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.txt_email.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(146)))), ((int)(((byte)(72)))));
            this.txt_email.BorderThickness = 2;
            this.txt_email.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_email.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_email.ForeColor = System.Drawing.Color.White;
            this.txt_email.isPassword = false;
            this.txt_email.Location = new System.Drawing.Point(39, 242);
            this.txt_email.Margin = new System.Windows.Forms.Padding(4);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(316, 36);
            this.txt_email.TabIndex = 4;
            this.txt_email.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_email.OnValueChanged += new System.EventHandler(this.txt_email_OnValueChanged);
            // 
            // txt_license
            // 
            this.txt_license.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.txt_license.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(146)))), ((int)(((byte)(72)))));
            this.txt_license.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.txt_license.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(146)))), ((int)(((byte)(72)))));
            this.txt_license.BorderThickness = 2;
            this.txt_license.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_license.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_license.ForeColor = System.Drawing.Color.White;
            this.txt_license.isPassword = false;
            this.txt_license.Location = new System.Drawing.Point(39, 303);
            this.txt_license.Margin = new System.Windows.Forms.Padding(4);
            this.txt_license.Name = "txt_license";
            this.txt_license.Size = new System.Drawing.Size(316, 36);
            this.txt_license.TabIndex = 5;
            this.txt_license.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_license.OnValueChanged += new System.EventHandler(this.txt_license_OnValueChanged);
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(185)))), ((int)(((byte)(185)))));
            this.gunaLabel3.Location = new System.Drawing.Point(36, 221);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(55, 17);
            this.gunaLabel3.TabIndex = 6;
            this.gunaLabel3.Text = "E-Posta:";
            this.gunaLabel3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(185)))), ((int)(((byte)(185)))));
            this.gunaLabel4.Location = new System.Drawing.Point(36, 282);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(98, 17);
            this.gunaLabel4.TabIndex = 7;
            this.gunaLabel4.Text = "Lisans Anahtarı:";
            this.gunaLabel4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_licenseinfo
            // 
            this.lbl_licenseinfo.AutoSize = true;
            this.lbl_licenseinfo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_licenseinfo.ForeColor = System.Drawing.Color.Red;
            this.lbl_licenseinfo.Location = new System.Drawing.Point(104, 410);
            this.lbl_licenseinfo.Name = "lbl_licenseinfo";
            this.lbl_licenseinfo.Size = new System.Drawing.Size(76, 17);
            this.lbl_licenseinfo.TabIndex = 10;
            this.lbl_licenseinfo.Text = "License info";
            this.lbl_licenseinfo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_licenseinfo.Visible = false;
            // 
            // timer_license
            // 
            this.timer_license.Tick += new System.EventHandler(this.timer_license_Tick);
            // 
            // btn_purchaselicense
            // 
            this.btn_purchaselicense.Animated = true;
            this.btn_purchaselicense.AnimationHoverSpeed = 0.07F;
            this.btn_purchaselicense.AnimationSpeed = 0.03F;
            this.btn_purchaselicense.BackColor = System.Drawing.Color.Transparent;
            this.btn_purchaselicense.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_purchaselicense.BaseColor = System.Drawing.Color.Transparent;
            this.btn_purchaselicense.BorderColor = System.Drawing.Color.Black;
            this.btn_purchaselicense.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btn_purchaselicense.CheckedBorderColor = System.Drawing.Color.Black;
            this.btn_purchaselicense.CheckedForeColor = System.Drawing.Color.White;
            this.btn_purchaselicense.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btn_purchaselicense.CheckedImage")));
            this.btn_purchaselicense.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btn_purchaselicense.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_purchaselicense.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_purchaselicense.FocusedColor = System.Drawing.Color.Empty;
            this.btn_purchaselicense.Font = new System.Drawing.Font("Infoma", 11.25F);
            this.btn_purchaselicense.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(185)))), ((int)(((byte)(185)))));
            this.btn_purchaselicense.Image = null;
            this.btn_purchaselicense.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_purchaselicense.ImageSize = new System.Drawing.Size(35, 35);
            this.btn_purchaselicense.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_purchaselicense.Location = new System.Drawing.Point(48, 346);
            this.btn_purchaselicense.Name = "btn_purchaselicense";
            this.btn_purchaselicense.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.btn_purchaselicense.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_purchaselicense.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.btn_purchaselicense.OnHoverImage = null;
            this.btn_purchaselicense.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_purchaselicense.OnPressedColor = System.Drawing.Color.Black;
            this.btn_purchaselicense.OnPressedDepth = 0;
            this.btn_purchaselicense.Radius = 15;
            this.btn_purchaselicense.Size = new System.Drawing.Size(290, 25);
            this.btn_purchaselicense.TabIndex = 9;
            this.btn_purchaselicense.Text = "Bir lisans anahtarı satın almak istiyorum";
            // 
            // btn_back
            // 
            this.btn_back.AnimationHoverSpeed = 0.07F;
            this.btn_back.AnimationSpeed = 0.03F;
            this.btn_back.BackColor = System.Drawing.Color.Transparent;
            this.btn_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
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
            this.btn_back.Image = global::NeuroAttention.Properties.Resources.licenseback;
            this.btn_back.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_back.ImageSize = new System.Drawing.Size(35, 35);
            this.btn_back.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_back.Location = new System.Drawing.Point(28, 99);
            this.btn_back.Name = "btn_back";
            this.btn_back.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.btn_back.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_back.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_back.OnHoverImage = global::NeuroAttention.Properties.Resources.licenseback2;
            this.btn_back.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_back.OnPressedColor = System.Drawing.Color.Empty;
            this.btn_back.Radius = 15;
            this.btn_back.Size = new System.Drawing.Size(42, 42);
            this.btn_back.TabIndex = 0;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // LicenseLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(405, 500);
            this.Controls.Add(this.lbl_licenseinfo);
            this.Controls.Add(this.btn_purchaselicense);
            this.Controls.Add(this.gunaLabel4);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.txt_license);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.btn_back);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LicenseLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "licenselogin";
            this.Load += new System.EventHandler(this.LicenseLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaAdvenceButton btn_back;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private ns1.BunifuMetroTextbox txt_email;
        private ns1.BunifuMetroTextbox txt_license;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaAdvenceButton btn_purchaselicense;
        private Guna.UI.WinForms.GunaLabel lbl_licenseinfo;
        private System.Windows.Forms.Timer timer_license;
    }
}