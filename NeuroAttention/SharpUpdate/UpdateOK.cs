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

namespace SharpUpdate
{
    public partial class UpdateOK : Form
    {
        public UpdateOK()
        {
            InitializeComponent();
        }

        private void UpdateOK_Load(object sender, EventArgs e)
        {
            string version = Assembly.GetExecutingAssembly().GetName().Version.ToString();   
            lbl_updateinfo.Text = "Uygulamanız güncel sürümdedir." + " \n\nUygulamanızın sürümü:" + " " + "v" + version[0] + version[1] + version[2] + version[3] + version[4].ToString();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
