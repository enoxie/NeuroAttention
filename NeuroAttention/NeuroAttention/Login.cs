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
using System.Net.Mail;
using System.Net;

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
        public string mail;
        public string password;
        /* Database Connection */
        public string conString = ("Data Source = 94.73.146.4; Initial Catalog = db60B; User Id = user60B; Password = PIuc71A0MQmp62Y;");
        //

        public static string username;
        public static string recbyusername
        {
            get { return username; }
            set { username = value; }
        }


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
            btn_moredetails.Text = Localization.btn_moredetails;


        }


        public void forgotPassword()
        {
            pbox_loading.Visible = true;
            pbox_logo.Visible = false;
            panel_forgotpassword.Visible = false;
            btn_register.Visible = false;
            btn_forgotpassword.Visible = false;
            lbl_signin.Visible = false;
            txt_username.Visible = false;
            txt_password.Visible = false;
            btn_session.Visible = false;
            btn_language.Visible = false;
            btn_languageicon.Visible = false;
            btn_version.Visible = false;
            checked_session.Visible = false;

            string user = txt_fusername.Text;
            bool kayitsorgu;
            
            con = new SqlConnection(conString);
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM users where k_adi='" + user + "'";
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                kayitsorgu = true;

                mail = dr["k_mail"].ToString();
                password = dr["k_sifre"].ToString();

            }

            else
            {
                kayitsorgu = false;
            }

            if (kayitsorgu == true)
            {
                
                /*MailMessage message = new MailMessage();
                SmtpClient client = new SmtpClient();

                client.Credentials = new NetworkCredential("JemappelleWine@windowslive.com", "enoxie2k17");
                client.Port = 587;
                client.Host = "smtp.live.com";
                client.EnableSsl = true;
                message.To.Add(mail);
                message.From = new MailAddress("JemappelleWine@windowslive.com", "enoxie2k17");
                message.Subject = "MayaAcademia Giriş Şifreniz";
                message.Body = "MayaAcademia Giriş Şifreniz:" + " " + password + " " + "\nGiriş yapmaya çalışan siz değilseniz en kısa sürede yetkiliye ulaşınız. \n\n Destek Hesaplarımız \n admin@enesbilgi.com \n support@enesbilgi.com";

                client.Send(message);
                */
                timer_resetpassword.Start();
                btn_disabledlogin.Visible = false;

                

                forgotPasswordSMS();
                
            }

            else
            {
                timer_resetpassworddenied.Start();
            }
            



        }


        public void forgotPasswordSMS()
        {

            SqlConnection con = new SqlConnection(conString);
            SqlCommand cmd = new SqlCommand("SELECT * from users where k_adi = '" + txt_fusername.Text +"'", con);
            
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            string telno = "";
            string sifre = "";

            while (dr.Read())
            {
                telno = dr["k_telefon"].ToString();
                sifre = dr["k_sifre"].ToString();
            }

            dr.Close();
            con.Close();

            //kno.Text= MÜŞTERİ NUMARASI
            //kad.Text= KULLANICI ADI
            //ksifre.Text= ŞİFRE
            //orjinator.Text= ORJİNATÖR (ONAYLI VE TAM DOĞRU OLMALIDIR)

            //xml içerisinde aşağıdaki gibi değerleri gönderebilirsiniz..
            //<zaman>2014-04-17 08:30:00</zaman>//sms gitmeye başlama zamanı
            //<zamanasimi>2014-04-17 10:30:00</zamanasimi>//son gönderim deneme zamanı
            string tur = "Normal";
            tur = "Turkce";
            string kNo = "38074";
            string kAd = "905376097218";
            string kSifre = "1811ou72";
            string orjinator = "8505909237";
            string mesaj = "MAYAACADEMIA Giriş Şifreniz:" + " " + sifre;
            string smsNN = "data=<sms><kno>" + kNo + "</kno><kulad>" + kAd + "</kulad><sifre>" + kSifre + "</sifre>" +
            "<gonderen>" + orjinator + "</gonderen>" +
            "<telmesajlar>" +
            "<telmesaj><tel>" + telno + "</tel><mesaj>" + mesaj + "</mesaj></telmesaj>" + 
            "</telmesajlar>" +
            "<tur>" + tur + "</tur></sms>";
            string post = XmlPost("http://panel.vatansms.com/panel/smsgonderNNpost.php", smsNN);
        }

        private string XmlPost(string PostAddress, string xmlData)
        {
            using (WebClient wUpload = new WebClient())
            {
                wUpload.Headers.Add("Content-Type", "application/x-www-form-urlencoded");
                Byte[] bPostArray = Encoding.UTF8.GetBytes(xmlData);
                Byte[] bResponse = wUpload.UploadData(PostAddress, "POST", bPostArray);
                Char[] sReturnChars = Encoding.UTF8.GetChars(bResponse);
                string sWebPage = new string(sReturnChars);
                return sWebPage;

               
            }


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
                if (lbl_accessdenied.Visible == true)
                    lbl_accessdenied.Visible = false;
                timer_login.Start();
                pbox_loading.Visible = true;
                panel_forgotpassword.Visible = false;
                btn_logindisabled.Visible = false;
                btn_loginenabled.Visible = false;            
                lbl_signin.Visible = false;
                txt_username.Visible = false;
                txt_password.Visible = false;
                btn_session.Visible = false;
                btn_language.Visible = false;
                btn_languageicon.Visible = false;
                btn_version.Visible = false;
                checked_session.Visible = false;
                btn_register.Visible = false;
                btn_forgotpassword.Visible = false;
                pbox_logo.Visible = false;

            }

            

            else
            {
                if (lbl_accessdenied.Visible == true)
                    lbl_accessdenied.Visible = false;
                timer_logindenied.Start();
                pbox_loading.Visible = true;
                panel_forgotpassword.Visible = false;
                btn_logindisabled.Visible = false;
                btn_loginenabled.Visible = false;
                lbl_signin.Visible = false;
                txt_username.Visible = false;
                txt_password.Visible = false;
                btn_session.Visible = false;
                btn_language.Visible = false;
                btn_languageicon.Visible = false;
                btn_version.Visible = false;
                checked_session.Visible = false;
                btn_register.Visible = false;
                btn_forgotpassword.Visible = false;
                pbox_logo.Visible = false;
                
            }
            con.Close();


        }

        private void Login_Load(object sender, EventArgs e)
        {
            
            
            
            timer_login.Interval = 2000;
            timer_logindenied.Interval = 1500;
            timer_resetpassword.Interval = 1500;
            timer_resetpassworddenied.Interval = 1500;
            timer_btnforgotpassword.Interval = 600;
            timer_backtologin.Interval = 600;
            string version =  Assembly.GetExecutingAssembly().GetName().Version.ToString();
            btn_version.Text = "v" + version[0] + version[1] + version[2] + version[3] + version[4].ToString();
            string dil = Settings1.Default["dil"].ToString();
            Application.CurrentCulture = new CultureInfo(dil);
            language(dil);

            if(dil == "tr-TR")
            {
                btn_googleplay.BackgroundImage = Resources.googleplay_tr;
                btn_appstore.BackgroundImage = Resources.appstore_tr;
                SqlConnection con = new SqlConnection(conString);
                SqlCommand cmd = new SqlCommand("SELECT * from attention_tr", con);
                DataTable dt = new DataTable();
               
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(dt);
                con.Open();
               
              
                dgw_attention.DataSource = dt;
                int numRows = dt.Rows.Count;
                if (numRows > 1)
                {

                    gunaPanel_attention.Size = new Size(360, 350);
                    
                    attention2.Location = new Point(20, 135);
                    gunaSeparator.Location = new Point(6, 120);
                    btn_moredetails.Location = new Point(6, 300);
                    attention2.Show();
                    lbl_attentiontitle.Text = dgw_attention.Rows[0].Cells[1].Value.ToString();
                    lbl_attentiontime.Text = dgw_attention.Rows[0].Cells[2].Value.ToString();
                    lbl_attentionmsg.Text = dgw_attention.Rows[0].Cells[3].Value.ToString();
                    lbl_attentiontitle2.Text = dgw_attention.Rows[1].Cells[1].Value.ToString();
                    lbl_attentiontime2.Text= dgw_attention.Rows[1].Cells[2].Value.ToString();
                    lbl_attentionmessage2.Text= dgw_attention.Rows[1].Cells[3].Value.ToString();

                }
                lbl_attentiontitle.Text = dgw_attention.Rows[0].Cells[1].Value.ToString();
                lbl_attentiontime.Text = dgw_attention.Rows[0].Cells[2].Value.ToString();
                lbl_attentionmsg.Text = dgw_attention.Rows[0].Cells[3].Value.ToString();

            }
            
            else if (dil == "en-US")
            {
                btn_googleplay.BackgroundImage = Resources.googleplay_en;
                btn_appstore.BackgroundImage = Resources.appstore_en;
                SqlConnection con = new SqlConnection(conString);
                SqlCommand cmd = new SqlCommand("SELECT * from attention_en", con);

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

            else if(dil == "de-DE")
            {
                btn_googleplay.BackgroundImage = Resources.googleplay_de;
                btn_appstore.BackgroundImage = Resources.appstore_de;
            }
            

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

            if (txt_username.Text == "KULLANICI ADI" || txt_username.Text == "USERNAME" || txt_username.Text == "BENUTZERNAME") 
            {
                txt_username.Text = "";
            }
        }

        private void txt_kullaniciadi_Leave(object sender, EventArgs e)
        {
            string dil = Settings1.Default["dil"].ToString();
            txt_username.BorderSize = 0;

            if(dil == "tr-TR")
            {
                if (txt_username.Text == "")
                    txt_username.Text = "KULLANICI ADI";
            }

            else if (dil =="en-US")
            {
                if (txt_username.Text == "")
                    txt_username.Text = "USERNAME";
            }

            else if (dil=="de-DE")
            {
                if (txt_username.Text == "")
                    txt_username.Text = "BENUTZERNAME";
            }
           


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

            if (txt_password.Text == "ŞİFRE" || txt_password.Text=="PASSWORD" || txt_password.Text == "PASSWORT")
            {
                txt_password.Text = "";
            }
        }

        private void txt_sifre_Leave(object sender, EventArgs e)
        {
            string dil = Settings1.Default["dil"].ToString();
            txt_password.BorderSize = 0;
            if (dil == "tr-TR")
            {
                if (txt_password.Text == "")
                    txt_password.Text = "ŞİFRE";
            }

            else if (dil == "en-US")
            {
                if (txt_password.Text == "")
                    txt_password.Text = "PASSWORD";
            }

            else if (dil == "de-DE")
            {
                if (txt_password.Text == "")
                    txt_password.Text = "PASSWORT";
            }
            


        }

        private void gunaPanel_leftside_MouseClick(object sender, MouseEventArgs e)
        {
            txt_username.BorderSize = 0;
            txt_password.BorderSize = 0;
            gunaPanel_left.Focus();

        
        }

        

        private void txt_sifre_TextChanged(object sender, EventArgs e)
        {
            string dil = Settings1.Default["dil"].ToString();

            if (dil == "tr-TR")
            {
                if (txt_username.Text != "KULLANICI ADI" & txt_password.Text != "ŞİFRE" && txt_username.Text != "" && txt_password.Text != "")
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

            else if(dil == "en-US")
            {
                if (txt_username.Text != "USERNAME" & txt_password.Text != "PASSWORD" && txt_username.Text != "" && txt_password.Text != "")
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

            else if (dil == "de-DE")
            {
                if (txt_username.Text != "BENUTZERNAME" & txt_password.Text != "PASSWORT" && txt_username.Text != "" && txt_password.Text != "")
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
            
        }

        private void txt_kullaniciadi_TextChanged(object sender, EventArgs e)
        {
            string dil = Settings1.Default["dil"].ToString();

            if (dil == "tr-TR")
            {
                if (txt_username.Text != "KULLANICI ADI" & txt_password.Text != "ŞİFRE" && txt_username.Text != "" && txt_password.Text != "")
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

            else if (dil == "en-US")
            {
                if (txt_username.Text != "USERNAME" & txt_password.Text != "PASSWORD" && txt_username.Text != "" && txt_password.Text != "")
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

            else if (dil == "de-DE")
            {
                if (txt_username.Text != "BENUTZERNAME" & txt_password.Text != "PASSWORT" && txt_username.Text != "" && txt_password.Text != "")
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

        private void btn_languageicon_Click(object sender, EventArgs e)
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

            else if (CultureInfo.CurrentCulture.Name == "en-US")
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

        private void btn_forgotpassword_Click(object sender, EventArgs e)
        {
            
            if (panel_forgotpassword.Visible == false)
            {
                timer_btnforgotpassword.Start();
                if (lbl_accessdenied.Visible == true)
                    lbl_accessdenied.Visible = false;
                pbox_logo.Visible = false;
                btn_register.Visible = false;
                btn_forgotpassword.Visible = false;
                lbl_signin.Visible = false;
                txt_username.Visible = false;
                txt_password.Visible = false;
                btn_session.Visible = false;
                btn_language.Visible = false;
                btn_logindisabled.Visible = false;
                btn_loginenabled.Visible = false;
                btn_languageicon.Visible = false;
                btn_version.Visible = false;
                checked_session.Visible = false;
                pbox_loading.Visible = true;
                pbox_logo.Focus();
                this.pbox_logo.Location = new Point(100, 60);

            }
           

            

          
                
        }

        private void btn_version_Click(object sender, EventArgs e)
        {
           /* VersionLogin versionlogin = new VersionLogin();
            versionlogin.Show();*/
        }

        private void btn_backtologin_Click(object sender, EventArgs e)
        {

            timer_backtologin.Start();
            pbox_logo.Visible = false;
            panel_forgotpassword.Visible = false;
            pbox_loading.Visible = true;
            txt_username.Text = "KULLANICI ADI";
            txt_password.Text = "ŞİFRE";
            
            
            

        }

       
        private void txt_fusername_Enter(object sender, EventArgs e)
        {
            txt_fusername.BorderSize = 2;

            if (txt_fusername.Text == "KULLANICI ADI")
            {
                txt_fusername.Text = "";
            }
        }

        private void txt_fusername_Leave(object sender, EventArgs e)
        {
            txt_fusername.BorderSize = 0;

            if (txt_fusername.Text == "")
                txt_fusername.Text = "KULLANICI ADI";
        }

        private void txt_fusername_MouseHover(object sender, EventArgs e)
        {
            txt_fusername.BaseColor = Color.FromArgb(231, 231, 231);
        }

        private void txt_fusername_MouseLeave(object sender, EventArgs e)
        {
            txt_fusername.BaseColor = Color.FromArgb(237, 237, 237);
        }

        private void txt_fusername_TextChanged(object sender, EventArgs e)
        {
            if (txt_fusername.Text != "KULLANICI ADI" && txt_fusername.Text != "")
            {
                btn_disabledlogin.Visible = false;
                btn_login.Visible = true;
            }

            else
            {
                btn_disabledlogin.Visible = true;
                btn_login.Visible = false;
            }
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            
            forgotPassword();
            
        }

       


        private void timer_btnforgotpassword_Tick(object sender, EventArgs e)
        {
            timer_btnforgotpassword.Stop();
            panel_forgotpassword.Visible = true;
            pbox_loading.Visible = false;
            pbox_logo.Visible = true;
            
        }

        private void timer_login_Tick(object sender, EventArgs e)
        {
            timer_login.Stop();

            this.Hide();
            username = txt_username.Text;
            Dashboard dash = new Dashboard();
            dash.Show();
        }

        private void timer_logindenied_Tick(object sender, EventArgs e)
        {
            timer_logindenied.Stop();
            lbl_accessdenied.Visible = true;
            pbox_loading.Visible = false;
            btn_logindisabled.Visible = true;
            btn_loginenabled.Visible = true;
            lbl_signin.Visible = true;
            txt_username.Visible = true;
            txt_password.Visible = true;
            btn_session.Visible = true;
            btn_language.Visible = true;
            btn_languageicon.Visible = true;
            btn_version.Visible = true;
            checked_session.Visible = true;
            btn_register.Visible = true;
            btn_forgotpassword.Visible = true;
            pbox_logo.Visible = true;
            txt_username.Text = "KULLANICI ADI";
            txt_password.Text = "ŞİFRE";
            btn_loginenabled.Visible = false;
        }

        private void timer_resetpassword_Tick(object sender, EventArgs e)
        {
            timer_resetpassword.Stop();
            txt_fusername.Text = "KULLANICI ADI";
            panel_forgotpassword.Visible = true;
            btn_disabledlogin.Visible = true;
            btn_login.Visible = true;
            if (lbl_resetpassinfo.Visible == true)
                lbl_resetpassinfo.Visible = false;
            pbox_loading.Visible = false;
            pbox_logo.Visible = true;
            pbox_logo.Focus();
            MessageBox.Show("Giriş şifreniz sistemde kayıtlı telefon numarasına gönderildi.");
        }

        private void timer_resetpassworddenied_Tick(object sender, EventArgs e)
        {
            timer_resetpassworddenied.Stop();
            lbl_resetpassinfo.Visible = true;
            pbox_logo.Visible = true;
            pbox_logo.Focus();
            txt_fusername.Text = "KULLANICI ADI";
            pbox_loading.Visible = false;
            panel_forgotpassword.Visible = true;
        }

        private void timer_backtologin_Tick(object sender, EventArgs e)
        {
            timer_backtologin.Stop();
            pbox_loading.Visible = false;

            pbox_logo.Visible = true;
            lbl_resetpassinfo.Visible = false;
            txt_fusername.Text = "KULLANICI ADI";
            btn_register.Visible = true;
            btn_forgotpassword.Visible = true;
            lbl_signin.Visible = true;
            txt_username.Visible = true;
            txt_password.Visible = true;
            btn_session.Visible = true;
            btn_language.Visible = true;
            btn_languageicon.Visible = true;
            btn_version.Visible = true;
            checked_session.Visible = true;
            btn_logindisabled.Visible = true;
            btn_loginenabled.Visible = false;
            this.pbox_logo.Location = new Point(33, 61);
        }

        private void gunaTileButton1_Click(object sender, EventArgs e)
        {

        }

        private void txt_password_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                login();
            }

            else
            {

            }
        }

        private void txt_username_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                login();
            }

            else
            {

            }
        }

        private void gunaControlBox_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
    }

