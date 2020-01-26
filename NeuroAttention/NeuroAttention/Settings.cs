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
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            
            gunaComboBox_language.Text = "Türkçe";
            gunaComboBox_version.Text = "v1.0.0";


        }

        private void btn_loginenabled_Click(object sender, EventArgs e)
        {
            
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void gunaAdvenceButton2_Click(object sender, EventArgs e)
        {

        }

        private void gunaAdvenceButton2_Click_1(object sender, EventArgs e)
        {
            if (copyrights1.Visible == false)
            {
                copyrights1.Visible = true;
                gunaLabel_ayarlar.Visible = false;
                gunaLabel_mevcutsurum.Visible = false;
                gunaLabel_uygulamadili.Visible = false;
                gunaComboBox_language.Visible = false;
                gunaComboBox_version.Visible = false;
                gunaAdvenceButton_kullanimsozlesmesi.ForeColor = Color.Red;
            }

            else
            {
                copyrights1.Visible = false;
                gunaLabel_ayarlar.Visible = true;
                gunaLabel_mevcutsurum.Visible = true;
                gunaLabel_uygulamadili.Visible = true;
                gunaComboBox_language.Visible = true;
                gunaComboBox_version.Visible = true;
                gunaAdvenceButton_kullanimsozlesmesi.ForeColor = Color.FromArgb(51, 51, 51);
            }
        }
    }
}
