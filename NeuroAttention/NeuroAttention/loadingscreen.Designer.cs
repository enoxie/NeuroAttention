namespace NeuroAttention
{
    partial class loadingscreen
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
            this.label_loading = new System.Windows.Forms.Label();
            this.label_gelistirici = new System.Windows.Forms.Label();
            this.bunifuProgressBar1 = new ns1.BunifuProgressBar();
            this.label_percentage = new System.Windows.Forms.Label();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label_loading
            // 
            this.label_loading.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_loading.ForeColor = System.Drawing.Color.White;
            this.label_loading.Location = new System.Drawing.Point(175, 160);
            this.label_loading.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_loading.Name = "label_loading";
            this.label_loading.Size = new System.Drawing.Size(260, 25);
            this.label_loading.TabIndex = 0;
            this.label_loading.Text = "YÜKLENİYOR";
            this.label_loading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_gelistirici
            // 
            this.label_gelistirici.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_gelistirici.ForeColor = System.Drawing.Color.White;
            this.label_gelistirici.Location = new System.Drawing.Point(180, 189);
            this.label_gelistirici.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_gelistirici.Name = "label_gelistirici";
            this.label_gelistirici.Size = new System.Drawing.Size(260, 33);
            this.label_gelistirici.TabIndex = 0;
            this.label_gelistirici.Text = "Yazılım Geliştiricisi\r\nEnes BİLGİ\r\n";
            this.label_gelistirici.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuProgressBar1
            // 
            this.bunifuProgressBar1.BackColor = System.Drawing.Color.Gainsboro;
            this.bunifuProgressBar1.BorderRadius = 5;
            this.bunifuProgressBar1.Location = new System.Drawing.Point(140, 267);
            this.bunifuProgressBar1.MaximumValue = 100;
            this.bunifuProgressBar1.Name = "bunifuProgressBar1";
            this.bunifuProgressBar1.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(116)))), ((int)(((byte)(62)))));
            this.bunifuProgressBar1.Size = new System.Drawing.Size(309, 4);
            this.bunifuProgressBar1.TabIndex = 1;
            this.bunifuProgressBar1.Value = 0;
            // 
            // label_percentage
            // 
            this.label_percentage.AutoSize = true;
            this.label_percentage.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_percentage.ForeColor = System.Drawing.Color.White;
            this.label_percentage.Location = new System.Drawing.Point(136, 275);
            this.label_percentage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_percentage.Name = "label_percentage";
            this.label_percentage.Size = new System.Drawing.Size(17, 19);
            this.label_percentage.TabIndex = 0;
            this.label_percentage.Text = "0";
            this.label_percentage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer3
            // 
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(38, 41);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(525, 406);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // loadingscreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(116)))), ((int)(((byte)(62)))));
            this.ClientSize = new System.Drawing.Size(600, 488);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bunifuProgressBar1);
            this.Controls.Add(this.label_percentage);
            this.Controls.Add(this.label_gelistirici);
            this.Controls.Add(this.label_loading);
            this.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "loadingscreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "loadingscreen";
            this.Load += new System.EventHandler(this.loadingscreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_loading;
        private System.Windows.Forms.Label label_gelistirici;
        private ns1.BunifuProgressBar bunifuProgressBar1;
        private System.Windows.Forms.Label label_percentage;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Panel panel1;
    }
}