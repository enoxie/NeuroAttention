using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NeuroAttention
{
    public partial class License : Form
    {
        public License()
        {
            InitializeComponent();
        }

        private void btn_enterlicense_Click(object sender, EventArgs e)
        {
            LicenseLogin licenselog = new LicenseLogin();
            licenselog.Show();
            this.Hide();
        }

        private void License_Load(object sender, EventArgs e)
        {
            if (Login.recbylicense == 0)
            {
                lbl_info.Text = "Lisans Anahtarı Giriniz";
                pbox_license.Image = Properties.Resources.license_gif;
                lbl_licensetime.Visible = false;
                pbox_license.Location = new Point(100, 12);
                lbl_licenseinfo.Text = "Siteme Kayıtlı Lisans Anahtarı Giriniz";
                lbl_info.Location = new Point(lbl_info.Location.X + 6, lbl_info.Location.Y);
                lbl_licenseinfo.Location = new Point(lbl_licenseinfo.Location.X - 50, lbl_licenseinfo.Location.Y);
            }

            if (Login.recbylicense == 1)
            {
                gunaPanel_top.BackColor = Color.FromArgb(255, 146, 72);
                pbox_license.Image = null;
                pbox_license.BackgroundImage = Properties.Resources.LicenseExpired;
                pbox_license.BackgroundImageLayout = ImageLayout.Zoom;
                pbox_license.Size = new Size(150, 150);
                pbox_license.Location = new Point(125, 25);
                lbl_info.Text = "Lisans Süreniz Doldu!";
                lbl_licensetime.Visible = false;
                lbl_licenseinfo.Text = "Lütfen Lisans Anahtarı Giriniz";
                lbl_info.Location = new Point(lbl_info.Location.X + 8, lbl_info.Location.Y);
                lbl_licenseinfo.Location = new Point(lbl_licenseinfo.Location.X - 30, lbl_licenseinfo.Location.Y);
            }

        }
    }
}
