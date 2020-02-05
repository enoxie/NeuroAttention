namespace NeuroAttention
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.btn_stop = new Guna.UI.WinForms.GunaTileButton();
            this.btn_start = new Guna.UI.WinForms.GunaTileButton();
            this.gunaGroupBox2 = new Guna.UI.WinForms.GunaGroupBox();
            this.gunaCheckBox5 = new Guna.UI.WinForms.GunaCheckBox();
            this.gunaCheckBox6 = new Guna.UI.WinForms.GunaCheckBox();
            this.gunaCheckBox7 = new Guna.UI.WinForms.GunaCheckBox();
            this.gunaCheckBox8 = new Guna.UI.WinForms.GunaCheckBox();
            this.gunaGroupBox1 = new Guna.UI.WinForms.GunaGroupBox();
            this.checkbox_compartment = new Guna.UI.WinForms.GunaCheckBox();
            this.checkbox_impact = new Guna.UI.WinForms.GunaCheckBox();
            this.checkbox_minus = new Guna.UI.WinForms.GunaCheckBox();
            this.checkbox_plus = new Guna.UI.WinForms.GunaCheckBox();
            this.gunaVSeparator2 = new Guna.UI.WinForms.GunaVSeparator();
            this.gunaVSeparator1 = new Guna.UI.WinForms.GunaVSeparator();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.numeric_screentime = new Guna.UI.WinForms.GunaNumeric();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.numeric_numberrange2 = new Guna.UI.WinForms.GunaNumeric();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaSeparator1 = new Guna.UI.WinForms.GunaSeparator();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.numeric_time = new Guna.UI.WinForms.GunaNumeric();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.numeric_numberrange1 = new Guna.UI.WinForms.GunaNumeric();
            this.lbl_process = new Guna.UI.WinForms.GunaLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.gunaPanel1.SuspendLayout();
            this.gunaGroupBox2.SuspendLayout();
            this.gunaGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaPanel1.Controls.Add(this.btn_stop);
            this.gunaPanel1.Controls.Add(this.gunaGroupBox1);
            this.gunaPanel1.Controls.Add(this.numeric_numberrange2);
            this.gunaPanel1.Controls.Add(this.btn_start);
            this.gunaPanel1.Controls.Add(this.gunaLabel3);
            this.gunaPanel1.Controls.Add(this.gunaLabel4);
            this.gunaPanel1.Controls.Add(this.gunaGroupBox2);
            this.gunaPanel1.Controls.Add(this.gunaSeparator1);
            this.gunaPanel1.Controls.Add(this.numeric_screentime);
            this.gunaPanel1.Controls.Add(this.numeric_numberrange1);
            this.gunaPanel1.Controls.Add(this.gunaLabel2);
            this.gunaPanel1.Controls.Add(this.gunaVSeparator2);
            this.gunaPanel1.Controls.Add(this.gunaLabel5);
            this.gunaPanel1.Controls.Add(this.gunaLabel1);
            this.gunaPanel1.Controls.Add(this.numeric_time);
            this.gunaPanel1.Controls.Add(this.gunaVSeparator1);
            this.gunaPanel1.Location = new System.Drawing.Point(269, 0);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(741, 196);
            this.gunaPanel1.TabIndex = 0;
            // 
            // btn_stop
            // 
            this.btn_stop.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_stop.Animated = true;
            this.btn_stop.AnimationHoverSpeed = 0.07F;
            this.btn_stop.AnimationSpeed = 0.03F;
            this.btn_stop.BackColor = System.Drawing.Color.Transparent;
            this.btn_stop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_stop.BaseColor = System.Drawing.Color.White;
            this.btn_stop.BorderColor = System.Drawing.Color.Transparent;
            this.btn_stop.BorderSize = 2;
            this.btn_stop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_stop.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_stop.FocusedColor = System.Drawing.Color.Empty;
            this.btn_stop.Font = new System.Drawing.Font("Segoe UI Light", 15.75F);
            this.btn_stop.ForeColor = System.Drawing.Color.White;
            this.btn_stop.Image = ((System.Drawing.Image)(resources.GetObject("btn_stop.Image")));
            this.btn_stop.ImageSize = new System.Drawing.Size(35, 35);
            this.btn_stop.Location = new System.Drawing.Point(628, 28);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_stop.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btn_stop.OnHoverForeColor = System.Drawing.Color.Empty;
            this.btn_stop.OnHoverImage = null;
            this.btn_stop.OnPressedColor = System.Drawing.Color.Black;
            this.btn_stop.Radius = 20;
            this.btn_stop.Size = new System.Drawing.Size(64, 64);
            this.btn_stop.TabIndex = 39;
            this.btn_stop.Visible = false;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // btn_start
            // 
            this.btn_start.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_start.Animated = true;
            this.btn_start.AnimationHoverSpeed = 0.07F;
            this.btn_start.AnimationSpeed = 0.03F;
            this.btn_start.BackColor = System.Drawing.Color.Transparent;
            this.btn_start.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_start.BaseColor = System.Drawing.Color.White;
            this.btn_start.BorderColor = System.Drawing.Color.Transparent;
            this.btn_start.BorderSize = 2;
            this.btn_start.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_start.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_start.FocusedColor = System.Drawing.Color.Empty;
            this.btn_start.Font = new System.Drawing.Font("Segoe UI Light", 15.75F);
            this.btn_start.ForeColor = System.Drawing.Color.White;
            this.btn_start.Image = ((System.Drawing.Image)(resources.GetObject("btn_start.Image")));
            this.btn_start.ImageSize = new System.Drawing.Size(50, 50);
            this.btn_start.Location = new System.Drawing.Point(628, 28);
            this.btn_start.Name = "btn_start";
            this.btn_start.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_start.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btn_start.OnHoverForeColor = System.Drawing.Color.Empty;
            this.btn_start.OnHoverImage = null;
            this.btn_start.OnPressedColor = System.Drawing.Color.Black;
            this.btn_start.Radius = 20;
            this.btn_start.Size = new System.Drawing.Size(64, 64);
            this.btn_start.TabIndex = 38;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // gunaGroupBox2
            // 
            this.gunaGroupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gunaGroupBox2.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox2.BaseColor = System.Drawing.Color.White;
            this.gunaGroupBox2.BorderColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBox2.Controls.Add(this.gunaCheckBox5);
            this.gunaGroupBox2.Controls.Add(this.gunaCheckBox6);
            this.gunaGroupBox2.Controls.Add(this.gunaCheckBox7);
            this.gunaGroupBox2.Controls.Add(this.gunaCheckBox8);
            this.gunaGroupBox2.LineColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBox2.Location = new System.Drawing.Point(423, 85);
            this.gunaGroupBox2.Name = "gunaGroupBox2";
            this.gunaGroupBox2.Size = new System.Drawing.Size(158, 70);
            this.gunaGroupBox2.TabIndex = 14;
            this.gunaGroupBox2.Text = "Görev Atamalı";
            this.gunaGroupBox2.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // gunaCheckBox5
            // 
            this.gunaCheckBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaCheckBox5.BaseColor = System.Drawing.Color.White;
            this.gunaCheckBox5.CheckedOffColor = System.Drawing.Color.Gray;
            this.gunaCheckBox5.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaCheckBox5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaCheckBox5.FillColor = System.Drawing.Color.White;
            this.gunaCheckBox5.Location = new System.Drawing.Point(125, 38);
            this.gunaCheckBox5.Name = "gunaCheckBox5";
            this.gunaCheckBox5.Size = new System.Drawing.Size(33, 20);
            this.gunaCheckBox5.TabIndex = 18;
            this.gunaCheckBox5.Text = "/";
            // 
            // gunaCheckBox6
            // 
            this.gunaCheckBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaCheckBox6.BaseColor = System.Drawing.Color.White;
            this.gunaCheckBox6.CheckedOffColor = System.Drawing.Color.Gray;
            this.gunaCheckBox6.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaCheckBox6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaCheckBox6.FillColor = System.Drawing.Color.White;
            this.gunaCheckBox6.Location = new System.Drawing.Point(84, 38);
            this.gunaCheckBox6.Name = "gunaCheckBox6";
            this.gunaCheckBox6.Size = new System.Drawing.Size(35, 20);
            this.gunaCheckBox6.TabIndex = 17;
            this.gunaCheckBox6.Text = "x";
            // 
            // gunaCheckBox7
            // 
            this.gunaCheckBox7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaCheckBox7.BaseColor = System.Drawing.Color.White;
            this.gunaCheckBox7.CheckedOffColor = System.Drawing.Color.Gray;
            this.gunaCheckBox7.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaCheckBox7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaCheckBox7.FillColor = System.Drawing.Color.White;
            this.gunaCheckBox7.Location = new System.Drawing.Point(45, 38);
            this.gunaCheckBox7.Name = "gunaCheckBox7";
            this.gunaCheckBox7.Size = new System.Drawing.Size(33, 20);
            this.gunaCheckBox7.TabIndex = 16;
            this.gunaCheckBox7.Text = "-";
            // 
            // gunaCheckBox8
            // 
            this.gunaCheckBox8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaCheckBox8.BaseColor = System.Drawing.Color.White;
            this.gunaCheckBox8.CheckedOffColor = System.Drawing.Color.Gray;
            this.gunaCheckBox8.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaCheckBox8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaCheckBox8.FillColor = System.Drawing.Color.White;
            this.gunaCheckBox8.Location = new System.Drawing.Point(3, 38);
            this.gunaCheckBox8.Name = "gunaCheckBox8";
            this.gunaCheckBox8.Size = new System.Drawing.Size(36, 20);
            this.gunaCheckBox8.TabIndex = 15;
            this.gunaCheckBox8.Text = "+";
            // 
            // gunaGroupBox1
            // 
            this.gunaGroupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gunaGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox1.BaseColor = System.Drawing.Color.White;
            this.gunaGroupBox1.BorderColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBox1.Controls.Add(this.checkbox_compartment);
            this.gunaGroupBox1.Controls.Add(this.checkbox_impact);
            this.gunaGroupBox1.Controls.Add(this.checkbox_minus);
            this.gunaGroupBox1.Controls.Add(this.checkbox_plus);
            this.gunaGroupBox1.LineColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBox1.Location = new System.Drawing.Point(423, 11);
            this.gunaGroupBox1.Name = "gunaGroupBox1";
            this.gunaGroupBox1.Size = new System.Drawing.Size(158, 70);
            this.gunaGroupBox1.TabIndex = 13;
            this.gunaGroupBox1.Text = "Normal";
            this.gunaGroupBox1.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // checkbox_compartment
            // 
            this.checkbox_compartment.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkbox_compartment.BaseColor = System.Drawing.Color.White;
            this.checkbox_compartment.CheckedOffColor = System.Drawing.Color.Gray;
            this.checkbox_compartment.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.checkbox_compartment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkbox_compartment.FillColor = System.Drawing.Color.White;
            this.checkbox_compartment.Location = new System.Drawing.Point(125, 38);
            this.checkbox_compartment.Name = "checkbox_compartment";
            this.checkbox_compartment.Size = new System.Drawing.Size(33, 20);
            this.checkbox_compartment.TabIndex = 18;
            this.checkbox_compartment.Text = "/";
            // 
            // checkbox_impact
            // 
            this.checkbox_impact.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkbox_impact.BaseColor = System.Drawing.Color.White;
            this.checkbox_impact.CheckedOffColor = System.Drawing.Color.Gray;
            this.checkbox_impact.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.checkbox_impact.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkbox_impact.FillColor = System.Drawing.Color.White;
            this.checkbox_impact.Location = new System.Drawing.Point(84, 38);
            this.checkbox_impact.Name = "checkbox_impact";
            this.checkbox_impact.Size = new System.Drawing.Size(35, 20);
            this.checkbox_impact.TabIndex = 17;
            this.checkbox_impact.Text = "x";
            // 
            // checkbox_minus
            // 
            this.checkbox_minus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkbox_minus.BaseColor = System.Drawing.Color.White;
            this.checkbox_minus.CheckedOffColor = System.Drawing.Color.Gray;
            this.checkbox_minus.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.checkbox_minus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkbox_minus.FillColor = System.Drawing.Color.White;
            this.checkbox_minus.Location = new System.Drawing.Point(45, 38);
            this.checkbox_minus.Name = "checkbox_minus";
            this.checkbox_minus.Size = new System.Drawing.Size(33, 20);
            this.checkbox_minus.TabIndex = 16;
            this.checkbox_minus.Text = "-";
            // 
            // checkbox_plus
            // 
            this.checkbox_plus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkbox_plus.BaseColor = System.Drawing.Color.White;
            this.checkbox_plus.CheckedOffColor = System.Drawing.Color.Gray;
            this.checkbox_plus.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.checkbox_plus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkbox_plus.FillColor = System.Drawing.Color.White;
            this.checkbox_plus.Location = new System.Drawing.Point(3, 38);
            this.checkbox_plus.Name = "checkbox_plus";
            this.checkbox_plus.Size = new System.Drawing.Size(36, 20);
            this.checkbox_plus.TabIndex = 15;
            this.checkbox_plus.Text = "+";
            // 
            // gunaVSeparator2
            // 
            this.gunaVSeparator2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gunaVSeparator2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gunaVSeparator2.LineColor = System.Drawing.Color.Silver;
            this.gunaVSeparator2.Location = new System.Drawing.Point(727, 1);
            this.gunaVSeparator2.Name = "gunaVSeparator2";
            this.gunaVSeparator2.Size = new System.Drawing.Size(10, 171);
            this.gunaVSeparator2.TabIndex = 12;
            // 
            // gunaVSeparator1
            // 
            this.gunaVSeparator1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gunaVSeparator1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gunaVSeparator1.LineColor = System.Drawing.Color.Silver;
            this.gunaVSeparator1.Location = new System.Drawing.Point(3, 1);
            this.gunaVSeparator1.Name = "gunaVSeparator1";
            this.gunaVSeparator1.Size = new System.Drawing.Size(10, 171);
            this.gunaVSeparator1.TabIndex = 11;
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Infoma Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel5.Location = new System.Drawing.Point(273, 26);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(56, 12);
            this.gunaLabel5.TabIndex = 10;
            this.gunaLabel5.Text = "Milisaniye";
            // 
            // numeric_screentime
            // 
            this.numeric_screentime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numeric_screentime.BaseColor = System.Drawing.Color.White;
            this.numeric_screentime.BorderColor = System.Drawing.Color.Silver;
            this.numeric_screentime.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.numeric_screentime.ButtonForeColor = System.Drawing.Color.White;
            this.numeric_screentime.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.numeric_screentime.ForeColor = System.Drawing.Color.Black;
            this.numeric_screentime.Location = new System.Drawing.Point(163, 17);
            this.numeric_screentime.Maximum = ((long)(9999999));
            this.numeric_screentime.Minimum = ((long)(1000));
            this.numeric_screentime.Name = "numeric_screentime";
            this.numeric_screentime.Size = new System.Drawing.Size(104, 30);
            this.numeric_screentime.TabIndex = 9;
            this.numeric_screentime.Text = "gunaNumeric4";
            this.numeric_screentime.Value = ((long)(1000));
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Infoma Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.Location = new System.Drawing.Point(29, 23);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(108, 19);
            this.gunaLabel4.TabIndex = 8;
            this.gunaLabel4.Text = "Ekran Süresi";
            // 
            // numeric_numberrange2
            // 
            this.numeric_numberrange2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numeric_numberrange2.BaseColor = System.Drawing.Color.White;
            this.numeric_numberrange2.BorderColor = System.Drawing.Color.Silver;
            this.numeric_numberrange2.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.numeric_numberrange2.ButtonForeColor = System.Drawing.Color.White;
            this.numeric_numberrange2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.numeric_numberrange2.ForeColor = System.Drawing.Color.Black;
            this.numeric_numberrange2.Location = new System.Drawing.Point(218, 62);
            this.numeric_numberrange2.Maximum = ((long)(9999999));
            this.numeric_numberrange2.Minimum = ((long)(0));
            this.numeric_numberrange2.Name = "numeric_numberrange2";
            this.numeric_numberrange2.Size = new System.Drawing.Size(49, 30);
            this.numeric_numberrange2.TabIndex = 7;
            this.numeric_numberrange2.Text = "gunaNumeric2";
            this.numeric_numberrange2.Value = ((long)(9));
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Infoma Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.Location = new System.Drawing.Point(273, 118);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(39, 12);
            this.gunaLabel3.TabIndex = 6;
            this.gunaLabel3.Text = "Saniye";
            // 
            // gunaSeparator1
            // 
            this.gunaSeparator1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gunaSeparator1.LineColor = System.Drawing.Color.Silver;
            this.gunaSeparator1.Location = new System.Drawing.Point(9, 166);
            this.gunaSeparator1.Name = "gunaSeparator1";
            this.gunaSeparator1.Size = new System.Drawing.Size(723, 10);
            this.gunaSeparator1.TabIndex = 5;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Infoma Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.Location = new System.Drawing.Point(91, 113);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(46, 19);
            this.gunaLabel2.TabIndex = 4;
            this.gunaLabel2.Text = "Süre";
            // 
            // numeric_time
            // 
            this.numeric_time.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numeric_time.BaseColor = System.Drawing.Color.White;
            this.numeric_time.BorderColor = System.Drawing.Color.Silver;
            this.numeric_time.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.numeric_time.ButtonForeColor = System.Drawing.Color.White;
            this.numeric_time.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.numeric_time.ForeColor = System.Drawing.Color.Black;
            this.numeric_time.Location = new System.Drawing.Point(163, 107);
            this.numeric_time.Maximum = ((long)(9999999));
            this.numeric_time.Minimum = ((long)(0));
            this.numeric_time.Name = "numeric_time";
            this.numeric_time.Size = new System.Drawing.Size(104, 30);
            this.numeric_time.TabIndex = 3;
            this.numeric_time.Text = "gunaNumeric3";
            this.numeric_time.Value = ((long)(60));
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Infoma Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(41, 68);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(96, 19);
            this.gunaLabel1.TabIndex = 2;
            this.gunaLabel1.Text = "Sayı Aralığı";
            // 
            // numeric_numberrange1
            // 
            this.numeric_numberrange1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numeric_numberrange1.BaseColor = System.Drawing.Color.White;
            this.numeric_numberrange1.BorderColor = System.Drawing.Color.Silver;
            this.numeric_numberrange1.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.numeric_numberrange1.ButtonForeColor = System.Drawing.Color.White;
            this.numeric_numberrange1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.numeric_numberrange1.ForeColor = System.Drawing.Color.Black;
            this.numeric_numberrange1.Location = new System.Drawing.Point(163, 62);
            this.numeric_numberrange1.Maximum = ((long)(9999999));
            this.numeric_numberrange1.Minimum = ((long)(0));
            this.numeric_numberrange1.Name = "numeric_numberrange1";
            this.numeric_numberrange1.Size = new System.Drawing.Size(49, 30);
            this.numeric_numberrange1.TabIndex = 0;
            this.numeric_numberrange1.Text = "gunaNumeric1";
            this.numeric_numberrange1.Value = ((long)(1));
            // 
            // lbl_process
            // 
            this.lbl_process.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_process.Font = new System.Drawing.Font("Infoma Light", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_process.Location = new System.Drawing.Point(348, 292);
            this.lbl_process.Name = "lbl_process";
            this.lbl_process.Size = new System.Drawing.Size(652, 213);
            this.lbl_process.TabIndex = 40;
            this.lbl_process.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_process.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.lbl_process);
            this.Controls.Add(this.gunaPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel1.PerformLayout();
            this.gunaGroupBox2.ResumeLayout(false);
            this.gunaGroupBox2.PerformLayout();
            this.gunaGroupBox1.ResumeLayout(false);
            this.gunaGroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaNumeric numeric_numberrange1;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaNumeric numeric_time;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaSeparator gunaSeparator1;
        private Guna.UI.WinForms.GunaNumeric numeric_screentime;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaNumeric numeric_numberrange2;
        private Guna.UI.WinForms.GunaVSeparator gunaVSeparator2;
        private Guna.UI.WinForms.GunaVSeparator gunaVSeparator1;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI.WinForms.GunaGroupBox gunaGroupBox2;
        private Guna.UI.WinForms.GunaCheckBox gunaCheckBox5;
        private Guna.UI.WinForms.GunaCheckBox gunaCheckBox6;
        private Guna.UI.WinForms.GunaCheckBox gunaCheckBox7;
        private Guna.UI.WinForms.GunaCheckBox gunaCheckBox8;
        private Guna.UI.WinForms.GunaGroupBox gunaGroupBox1;
        private Guna.UI.WinForms.GunaCheckBox checkbox_compartment;
        private Guna.UI.WinForms.GunaCheckBox checkbox_impact;
        private Guna.UI.WinForms.GunaCheckBox checkbox_minus;
        private Guna.UI.WinForms.GunaCheckBox checkbox_plus;
        private Guna.UI.WinForms.GunaTileButton btn_start;
        private Guna.UI.WinForms.GunaTileButton btn_stop;
        private Guna.UI.WinForms.GunaLabel lbl_process;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}