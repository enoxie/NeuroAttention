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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void txt_kullaniciadi_MouseHover(object sender, EventArgs e)
        {
            txt_kullaniciadi.BaseColor = Color.FromArgb(231, 231, 231);
        }

        private void txt_kullaniciadi_MouseLeave(object sender, EventArgs e)
        {
            txt_kullaniciadi.BaseColor = Color.FromArgb(237, 237, 237);
        }

        private void txt_kullaniciadi_Enter(object sender, EventArgs e)
        {
            txt_kullaniciadi.BorderSize = 2;

            if (txt_kullaniciadi.Text == "KULLANICI ADI")
            {
                txt_kullaniciadi.Text = "";
            }
        }

        private void txt_kullaniciadi_Leave(object sender, EventArgs e)
        {
            txt_kullaniciadi.BorderSize = 0;

            if (txt_kullaniciadi.Text == "")
                txt_kullaniciadi.Text = "KULLANICI ADI";


        }

        private void txt_sifre_MouseHover(object sender, EventArgs e)
        {
            txt_sifre.BaseColor = Color.FromArgb(231, 231, 231);
        }

        private void txt_sifre_MouseLeave(object sender, EventArgs e)
        {
            txt_sifre.BaseColor = Color.FromArgb(237, 237, 237);
        }

        private void txt_sifre_Enter(object sender, EventArgs e)
        {
            
            txt_sifre.BorderSize = 2;

            if (txt_sifre.Text == "ŞİFRE")
            {
                txt_sifre.Text = "";
            }
        }

        private void txt_sifre_Leave(object sender, EventArgs e)
        {
            txt_sifre.BorderSize = 0;
            if (txt_sifre.Text == "")
                txt_sifre.Text = "ŞİFRE";

        }

        private void gunaPanel_leftside_MouseClick(object sender, MouseEventArgs e)
        {
            txt_kullaniciadi.BorderSize = 0;
            txt_sifre.BorderSize = 0;
            gunaPanel_leftside.Focus();

        
        }

        private void btn_logindisabled_Click(object sender, EventArgs e)
        {

        }

        private void txt_sifre_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txt_kullaniciadi_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void gunaAdvenceButton5_Click(object sender, EventArgs e)
        {
            if (checked_session.Checked == false)
            {
                checked_session.Checked = true;
            }

            else
            {
                checked_session.Checked = false;
            }
        }

      
    }
}
