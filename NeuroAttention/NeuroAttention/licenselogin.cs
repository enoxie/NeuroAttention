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
    public partial class LicenseLogin : Form
    {
        public LicenseLogin()
        {
            InitializeComponent();
        }

        private void LicenseLogin_Load(object sender, EventArgs e)
        {

        }

        

        private void btn_back_Click(object sender, EventArgs e)
        {
            License license = new License();
            license.Show();
            this.Hide();
        }
    }
}
