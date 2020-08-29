namespace LicenseServices
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txt_gun = new Guna.UI.WinForms.GunaTextBox();
            this.txt_dogrulamakodu = new Guna.UI.WinForms.GunaTextBox();
            this.txt_lisansanahtari = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.btn_generate = new Guna.UI.WinForms.GunaButton();
            this.SuspendLayout();
            // 
            // txt_gun
            // 
            this.txt_gun.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.txt_gun.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.txt_gun.BorderColor = System.Drawing.Color.Red;
            this.txt_gun.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_gun.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_gun.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_gun.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_gun.Font = new System.Drawing.Font("Museo Sans 100", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_gun.ForeColor = System.Drawing.Color.White;
            this.txt_gun.Location = new System.Drawing.Point(12, 212);
            this.txt_gun.Name = "txt_gun";
            this.txt_gun.PasswordChar = '\0';
            this.txt_gun.Size = new System.Drawing.Size(147, 25);
            this.txt_gun.TabIndex = 8;
            this.txt_gun.Text = "Gün";
            this.txt_gun.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_dogrulamakodu
            // 
            this.txt_dogrulamakodu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.txt_dogrulamakodu.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.txt_dogrulamakodu.BorderColor = System.Drawing.Color.Red;
            this.txt_dogrulamakodu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_dogrulamakodu.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_dogrulamakodu.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_dogrulamakodu.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_dogrulamakodu.Font = new System.Drawing.Font("Museo Sans 100", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_dogrulamakodu.ForeColor = System.Drawing.Color.White;
            this.txt_dogrulamakodu.Location = new System.Drawing.Point(191, 212);
            this.txt_dogrulamakodu.Name = "txt_dogrulamakodu";
            this.txt_dogrulamakodu.PasswordChar = '\0';
            this.txt_dogrulamakodu.Size = new System.Drawing.Size(147, 25);
            this.txt_dogrulamakodu.TabIndex = 9;
            this.txt_dogrulamakodu.Text = "Doğrulama Kodu";
            this.txt_dogrulamakodu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_lisansanahtari
            // 
            this.txt_lisansanahtari.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.txt_lisansanahtari.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.txt_lisansanahtari.BorderColor = System.Drawing.Color.Red;
            this.txt_lisansanahtari.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_lisansanahtari.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_lisansanahtari.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_lisansanahtari.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_lisansanahtari.Font = new System.Drawing.Font("Museo Sans 100", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_lisansanahtari.ForeColor = System.Drawing.Color.White;
            this.txt_lisansanahtari.Location = new System.Drawing.Point(93, 258);
            this.txt_lisansanahtari.Name = "txt_lisansanahtari";
            this.txt_lisansanahtari.PasswordChar = '\0';
            this.txt_lisansanahtari.Size = new System.Drawing.Size(147, 25);
            this.txt_lisansanahtari.TabIndex = 10;
            this.txt_lisansanahtari.Text = "Lisans Anahtarı";
            this.txt_lisansanahtari.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel1.Font = new System.Drawing.Font("Museo Sans 100", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.White;
            this.gunaLabel1.Location = new System.Drawing.Point(12, 9);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(118, 25);
            this.gunaLabel1.TabIndex = 11;
            this.gunaLabel1.Text = "MayaClient";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel2.Font = new System.Drawing.Font("Museo Sans 100", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.ForeColor = System.Drawing.Color.White;
            this.gunaLabel2.Location = new System.Drawing.Point(12, 34);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(189, 25);
            this.gunaLabel2.TabIndex = 12;
            this.gunaLabel2.Text = "Lisanslama Sistemi";
            // 
            // btn_generate
            // 
            this.btn_generate.AnimationHoverSpeed = 0.07F;
            this.btn_generate.AnimationSpeed = 0.03F;
            this.btn_generate.BackColor = System.Drawing.Color.Transparent;
            this.btn_generate.BaseColor = System.Drawing.Color.Transparent;
            this.btn_generate.BorderColor = System.Drawing.Color.Black;
            this.btn_generate.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_generate.FocusedColor = System.Drawing.Color.Empty;
            this.btn_generate.Font = new System.Drawing.Font("Museo Sans 100", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_generate.ForeColor = System.Drawing.Color.White;
            this.btn_generate.Image = null;
            this.btn_generate.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_generate.Location = new System.Drawing.Point(102, 333);
            this.btn_generate.Name = "btn_generate";
            this.btn_generate.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_generate.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_generate.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_generate.OnHoverImage = null;
            this.btn_generate.OnPressedColor = System.Drawing.Color.Black;
            this.btn_generate.Size = new System.Drawing.Size(138, 41);
            this.btn_generate.TabIndex = 7;
            this.btn_generate.Text = "Lisans Oluştur";
            this.btn_generate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_generate.Click += new System.EventHandler(this.btn_generate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(350, 400);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.txt_lisansanahtari);
            this.Controls.Add(this.txt_dogrulamakodu);
            this.Controls.Add(this.txt_gun);
            this.Controls.Add(this.btn_generate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI.WinForms.GunaTextBox txt_gun;
        private Guna.UI.WinForms.GunaTextBox txt_dogrulamakodu;
        private Guna.UI.WinForms.GunaTextBox txt_lisansanahtari;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaButton btn_generate;
    }
}

