using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NeuroAttention
{
    public partial class UpdateOK : Form, ISharpUpdatable
    {
        public UpdateOK()
        {
            InitializeComponent();
            updater = new MayaUpdater(this);
        }
        private MayaUpdater updater;
        public static int checkupdate;
        public static int updateresult;
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

        private void UpdateOK_Load(object sender, EventArgs e)
        {
            timer_checkupdate.Interval = 2000;
            string version = Assembly.GetExecutingAssembly().GetName().Version.ToString();
            lbl_updateinfo.Text = "MayaClient" + " " + "v" + version[0] + version[1] + version[2] + version[3] + version[4].ToString();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Settings settings = new Settings();
            settings.Show();

        }

        private void btn_checkupdate_Click(object sender, EventArgs e)
        {
            timer_checkupdate.Start();
            gunaPanel_checkupdate.Show();
        }

        private void timer_checkupdate_Tick(object sender, EventArgs e)
        {
            updater.DoUpdate();
            this.Hide();
            timer_checkupdate.Stop();
        }
    }
}
