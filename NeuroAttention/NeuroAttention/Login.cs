using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Reflection;
using NeuroAttention.Properties;


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
            
            public void language(string culture)
        {

            Thread.CurrentThread.CurrentUICulture.ClearCachedData();
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(culture);

            btn_forgotpassword.Text = Localization.btn_forgotpassword;
            btn_register.Text = Localization.btn_register;
            btn_session.Text = Localization.btn_session;
            lbl_signin.Text = Localization.lbl_signin;
            txt_username.Text = Localization.txt_username;
            txt_password.Text = Localization.txt_password;
            btn_language.Text = Localization.btn_language;
            lbl_title.Text = Localization.lbl_title;
            cbox_language.SelectedItem = Localization.cbox_language;
            btn_loginenabled.Visible = false;
            btn_logindisabled.Visible = true;
          
        }


        public void login()
        {
           
            string user = txt_username.Text;
            string pass = txt_password.Text;
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
            string version =  Assembly.GetExecutingAssembly().GetName().Version.ToString();
            btn_version.Text = "v" + version[0] + version[1] + version[2] + version[3] + version[4].ToString();
            string dil = Settings1.Default["dil"].ToString();
            Application.CurrentCulture = new CultureInfo(dil);
            language(dil);
            SqlConnection con = new SqlConnection(conString);
            SqlCommand cmd = new SqlCommand("SELECT * from attention", con);

            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            string attentiontitle = "";
            string attentiontime = "";
            string attentionmessage = "";
            




            while (dr.Read())
            {
                attentiontitle = dr["attentiontitle"].ToString();
                attentiontime = dr["attentiontime"].ToString();
                attentionmessage = dr["attentionmessage"].ToString();
            }
            dr.Close();
            con.Close();

            lbl_attentiontitle.Text = attentiontitle;
            lbl_attentiontime.Text = attentiontime;
            lbl_attentionmsg.Text = attentionmessage;
            

        }

        private void txt_kullaniciadi_MouseHover(object sender, EventArgs e)
        {
            txt_username.BaseColor = Color.FromArgb(231, 231, 231);
        }

        private void txt_kullaniciadi_MouseLeave(object sender, EventArgs e)
        {
            txt_username.BaseColor = Color.FromArgb(237, 237, 237);
        }

        private void txt_kullaniciadi_Enter(object sender, EventArgs e)
        {
            txt_username.BorderSize = 2;

            if (txt_username.Text == "KULLANICI ADI")
            {
                txt_username.Text = "";
            }
        }

        private void txt_kullaniciadi_Leave(object sender, EventArgs e)
        {
            txt_username.BorderSize = 0;

            if (txt_username.Text == "")
                txt_username.Text = "KULLANICI ADI";


        }

        private void txt_sifre_MouseHover(object sender, EventArgs e)
        {
            txt_password.BaseColor = Color.FromArgb(231, 231, 231);
        }

        private void txt_sifre_MouseLeave(object sender, EventArgs e)
        {
            txt_password.BaseColor = Color.FromArgb(237, 237, 237);
        }

        private void txt_sifre_Enter(object sender, EventArgs e)
        {
            
            txt_password.BorderSize = 2;

            if (txt_password.Text == "ŞİFRE")
            {
                txt_password.Text = "";
            }
        }

        private void txt_sifre_Leave(object sender, EventArgs e)
        {
            txt_password.BorderSize = 0;
            if (txt_password.Text == "")
                txt_password.Text = "ŞİFRE";

        }

        private void gunaPanel_leftside_MouseClick(object sender, MouseEventArgs e)
        {
            txt_username.BorderSize = 0;
            txt_password.BorderSize = 0;
            gunaPanel_left.Focus();

        
        }

        

        private void txt_sifre_TextChanged(object sender, EventArgs e)
        {
            if (txt_username.Text != "KULLANICI ADI" & txt_password.Text != "ŞİFRE")
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
            if(txt_username.Text!="KULLANICI ADI" & txt_password.Text!= "ŞİFRE")
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
                btn_session.ForeColor = Color.Black;
            }

            else
            {
                checked_session.Checked = false;
                btn_session.ForeColor = Color.FromArgb(126, 126, 126);
            }
        }

        private void gunaTileButton1_MouseHover(object sender, EventArgs e)
        {
            gunaPanel_attention.Visible = true;
        }

        private void gunaTileButton1_MouseLeave(object sender, EventArgs e)
        {
            gunaPanel_attention.Visible = false;
        }

        

        private void gunaPanel3_MouseLeave(object sender, EventArgs e)
        {
            gunaPanel_attention.Visible = false;
        }

       

        private void gunaPanel2_MouseHover(object sender, EventArgs e)
        {
            gunaPanel_attention.Visible = false;
        }

       

        private void btn_loginenabled_Click(object sender, EventArgs e)
        {
            login();
        }

        private void btn_settings_Click(object sender, EventArgs e)
        {
            
            Settings settings = new Settings();
            settings.Show();
            this.Hide();
        }

        private void btn_help_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.mayaacademia.com");
        }

        private void btn_language_Click(object sender, EventArgs e)
        {
            cbox_server.SelectedItem = "TR NATRO - db60";
            panel_language.Show();
            pbox_logo.Hide();
            btn_language.Hide();
            btn_languageicon.Hide();


            if (CultureInfo.CurrentCulture.Name == "tr-TR")
            {
                cbox_language.Items.Clear();
                cbox_language.Items.Add("Türkçe");
                cbox_language.Items.Add("İngilizce");
                cbox_language.Items.Add("Almanca");
                cbox_language.SelectedItem = "Türkçe";
            }

            else if(CultureInfo.CurrentCulture.Name == "en-US")
            {
                cbox_language.Items.Clear();
                cbox_language.Items.Add("Turkish");
                cbox_language.Items.Add("English");
                cbox_language.Items.Add("German");
                cbox_language.SelectedItem = "English";
            }

            else if (CultureInfo.CurrentCulture.Name == "de-DE")
            {
                cbox_language.Items.Clear();
                cbox_language.Items.Add("Türkisch");
                cbox_language.Items.Add("Englisch");
                cbox_language.Items.Add("Deutsch");
                cbox_language.SelectedItem = "Deutsch";
            }


        }

        private void gunaPanel_right_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_languageicon_Click(object sender, EventArgs e)
        {
            cbox_server.SelectedItem = "TR NATRO - db60";
            panel_language.Show();
            pbox_logo.Hide();
            btn_language.Hide();
            btn_languageicon.Hide();
        }

        private void cbox_language_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cbox_language.SelectedIndex==0)
            {
                
                language("tr-TR");
                Settings1.Default.dil = "tr-TR";
                Settings1.Default.Save();
                panel_language.Hide();
                pbox_logo.Show();
                btn_language.Show();
                btn_languageicon.Show();
                Application.CurrentCulture = new CultureInfo("tr-TR");
                Application.Restart();
               

            }

            else if (cbox_language.SelectedIndex==1)
            {
               
                
                language("en-US");
                Settings1.Default.dil = "en-US";
                Settings1.Default.Save();
                panel_language.Hide();
                pbox_logo.Show();
                btn_language.Show();
                btn_languageicon.Show();
                cbox_language.Items.Clear();
                cbox_language.Items.Add("Turkish");
                cbox_language.Items.Add("English");
                cbox_language.Items.Add("German");
                cbox_language.SelectedItem = "English";
                Application.CurrentCulture = new CultureInfo("en-US");        
                Application.Restart();
            }

            else if (cbox_language.SelectedIndex==2)
            {
               
                language("de-DE");
                Settings1.Default.dil = "de-DE";
                Settings1.Default.Save();
                panel_language.Hide();
                pbox_logo.Show();
                btn_language.Show();
                btn_languageicon.Show();
                cbox_language.Items.Clear();
                cbox_language.Items.Add("Türkisch");
                cbox_language.Items.Add("Englisch");
                cbox_language.Items.Add("Deutsch");
                cbox_language.SelectedItem = "Deustch";
                Application.CurrentCulture = new CultureInfo("de-DE");
                Application.Restart();

            }
        }

        private void cbox_language_SelectedValueChanged(object sender, EventArgs e)
        {

        }
    }
}
