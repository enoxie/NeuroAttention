using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
     

        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;


        /* Database Connection */
        public string conString = ("Data Source = 94.73.146.4; Initial Catalog = db60B; User Id = user60B; Password = PIuc71A0MQmp62Y;");
        //

        public void login()
        {
            string user = txt_kullaniciadi.Text;
            string pass = txt_sifre.Text;
            con = new SqlConnection(conString);
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM users where k_adi='" + user + "' AND k_sifre='" + pass + "'";
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("Tebrikler! Başarılı bir şekilde giriş yaptınız. https://mayaacademia.com");
                this.Hide();
                Dashboard dash = new Dashboard();
                dash.Show();
            }

            else if (user == "" || pass == "")
            {
                MessageBox.Show("Eksik yada hatalı bilgi girdiniz.");
            }

            else
            {
                MessageBox.Show("Geçerli bir kullanıcı adı veya şifre girmelisiniz.");
            }
            con.Close();


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

        

        private void txt_sifre_TextChanged(object sender, EventArgs e)
        {
            if (txt_kullaniciadi.Text != "KULLANICI ADI" & txt_sifre.Text != "ŞİFRE")
            {
                btn_logindisabled.Visible = false;
                btn_loginenabled.Visible = true;
            }

            else
            {
                btn_logindisabled.Visible = true;
                btn_loginenabled.Visible = false;
            }
        }

        private void txt_kullaniciadi_TextChanged(object sender, EventArgs e)
        {
            if(txt_kullaniciadi.Text!="KULLANICI ADI" & txt_sifre.Text!= "ŞİFRE")
            {
                btn_logindisabled.Visible = false;
                btn_loginenabled.Visible = true;
            }

            else
            {
                btn_logindisabled.Visible = true;
                btn_loginenabled.Visible = false;
            }
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

        private void gunaTileButton1_MouseHover(object sender, EventArgs e)
        {
            gunaElipsePanel_duyuru.Visible = true;
        }

        private void gunaTileButton1_MouseLeave(object sender, EventArgs e)
        {
            gunaElipsePanel_duyuru.Visible = false;
        }

        

        private void gunaPanel3_MouseLeave(object sender, EventArgs e)
        {
            gunaElipsePanel_duyuru.Visible = false;
        }

       

        private void gunaPanel2_MouseHover(object sender, EventArgs e)
        {
            gunaElipsePanel_duyuru.Visible = false;
        }

       

        private void btn_loginenabled_Click(object sender, EventArgs e)
        {
            login();
        }

        private void gunaTileButton2_Click(object sender, EventArgs e)
        {
            
            Settings settings = new Settings();
            settings.Show();
            this.Hide();
        }
    }
}
