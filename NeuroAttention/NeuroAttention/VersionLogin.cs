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
    public partial class VersionLogin : Form
    {
        public VersionLogin()
        {
            InitializeComponent();
        }

        private void VersionLogin_Load(object sender, EventArgs e)
        {
            string version = Assembly.GetExecutingAssembly().GetName().Version.ToString();
            lbl_version.Text = "v" + version[0] + version[1] + version[2] + version[3] + version[4].ToString();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
