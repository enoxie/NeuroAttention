using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.Globalization;
using System.Threading;
using SharpUpdate;

namespace NeuroAttention
{
    public partial class Settings : Form, ISharpUpdatable
    {


        private MayaUpdater updater;
        public bool InternetKontrol()
        {
            try
            {
                System.Net.Sockets.TcpClient kontrol_client = new System.Net.Sockets.TcpClient("www.google.com.tr", 80);
                kontrol_client.Close();
                return true;
            }
            catch (Exception)

            {
                return false;

            }
        }

        public void networkStatus()
        {
            bool kontrol = InternetKontrol(); // Kontrol fonksiyonumuzu çağırdık
                                              // Eğer internet varsa true yoksa false değeri gelecek. Bunu if ile kontrol edelim

            if (kontrol == true)
            {
                this.Hide();
                updater.DoUpdate();
            }
            else
            {

                MessageBox.Show("Sunucu ile bağlantı kurulamadı. Bağlantınızın doğruluğundan emin olun veya ISP ile görüşünüz.", "Bağlantı Kesildi", MessageBoxButtons.OK, MessageBoxIcon.Warning);


            }


        }


            public Settings()
        {
            InitializeComponent();
            
            updater = new MayaUpdater(this);
        }

        public string ApplicationName
        {
            get { return "NeuroAttention"; }
        }

        public string ApplicationID
        {
            get { return "NeuroAttention"; }
        }

        public Assembly ApplicationAssembly
        {
            get { return Assembly.GetExecutingAssembly(); }
        }

        public Icon ApplicationIcon
        {
            get { return this.Icon; }
        }

        public Uri UpdateXmlLocation
        {
            get { return new Uri("http://www.enesbilgi.com/test/update.xml"); }
        }

        public Form Context
        {
            get { return this; }
        }





        public void language(string culture)
        {

            Thread.CurrentThread.CurrentUICulture.ClearCachedData();
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(culture);

            lbl_settings.Text = Localization.lbl_settings;
            lbl_currentversion.Text = Localization.lbl_currentversion;
            lbl_applanguage.Text = Localization.lbl_applanguage;
            btn_kullanimsozlesmesi.Text = Localization.btn_kullanimsozlesmesi;
            
           
        }


        private void Settings_Load(object sender, EventArgs e)
        {

            
            string version = Assembly.GetExecutingAssembly().GetName().Version.ToString();
            cbox_version.Items.Add("v" + version[0] + version[1] + version[2] + version[3] + version[4].ToString());
            cbox_version.SelectedItem = "v" + version[0] + version[1] + version[2] + version[3] + version[4].ToString();
            btn_version.Text= "v" + version[0] + version[1] + version[2] + version[3] + version[4].ToString();
            string dil = Settings1.Default["dil"].ToString();
            Application.CurrentCulture = new CultureInfo(dil);
            language(dil);

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

        private void btn_back_Click(object sender, EventArgs e)
        {
            
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void cbox_language_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cbox_language.SelectedIndex == 0)
            {

                language("tr-TR");
                Settings1.Default.dil = "tr-TR";
                Settings1.Default.Save();
                cbox_language.Items.Clear();
                cbox_language.Items.Add("Türkçe");
                cbox_language.Items.Add("İngilizce");
                cbox_language.Items.Add("Almanca");
                cbox_language.SelectedItem = "Türkçe";
                Application.CurrentCulture = new CultureInfo("tr-TR");
                Application.Restart();


            }

            else if (cbox_language.SelectedIndex == 1)
            {


                language("en-US");
                Settings1.Default.dil = "en-US";
                Settings1.Default.Save();
                cbox_language.Items.Clear();
                cbox_language.Items.Add("Turkish");
                cbox_language.Items.Add("English");
                cbox_language.Items.Add("German");
                cbox_language.SelectedItem = "English";
                Application.CurrentCulture = new CultureInfo("en-US");
                Application.Restart();
            }

            else if (cbox_language.SelectedIndex == 2)
            {

                language("de-DE");
                Settings1.Default.dil = "de-DE";
                Settings1.Default.Save();
                cbox_language.Items.Clear();
                cbox_language.Items.Add("Türkisch");
                cbox_language.Items.Add("Englisch");
                cbox_language.Items.Add("Deutsch");
                cbox_language.SelectedItem = "Deustch";
                Application.CurrentCulture = new CultureInfo("de-DE");
                Application.Restart();

            }
        }

        private void btn_kullanimsozlesmesi_Click(object sender, EventArgs e)
        {
            if (copyrights.Visible == false)
            {
                lbl_title.Visible = true;
                // this.copyrights.Location = new System.Drawing.Point(26, 64);
                //this.lbl_title.Location = new System.Drawing.Point(26, 45);
                copyrights.Show();
                btn_kullanimsozlesmesi.ForeColor = Color.FromArgb(209, 54, 57);
                lbl_settings.Visible = false;
                lbl_currentversion.Visible = false;
                lbl_applanguage.Visible = false;
                cbox_language.Visible = false;
                cbox_version.Visible = false;
                btn_checkupdate.Visible = false;
            }

            else
            {
                lbl_title.Visible = false;
                copyrights.Hide();
                btn_kullanimsozlesmesi.ForeColor = Color.FromArgb(51, 51, 51);
                lbl_settings.Visible = true;
                lbl_currentversion.Visible = true;
                lbl_applanguage.Visible = true;
                cbox_language.Visible = true;
                cbox_version.Visible = true;
                btn_checkupdate.Visible = true;
            }
                

        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            
            
        }

        private void pbox_logo_Click(object sender, EventArgs e)
        {
            if (copyrights.Visible == true)
            {
                lbl_title.Visible = false;
                copyrights.Hide();
                btn_kullanimsozlesmesi.ForeColor = Color.FromArgb(51, 51, 51);
                lbl_settings.Visible = true;
                lbl_currentversion.Visible = true;
                lbl_applanguage.Visible = true;
                cbox_language.Visible = true;
                cbox_version.Visible = true;
                btn_checkupdate.Visible = true;
            }

            else
            {

            }
        }

        private void btn_checkupdate_Click(object sender, EventArgs e)
        {
            networkStatus();
        }

        private void btn_version_Click(object sender, EventArgs e)
        {

            if (copyrights.Visible != true)
            {
                Version versiyon = new Version();
                versiyon.Show();
            }

            else
            {

            }
        }

        private void gunaControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
