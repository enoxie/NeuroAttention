using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NeuroAttention
{
    public partial class ForgotPassword : UserControl
    {
        public ForgotPassword()
        {
            InitializeComponent();
        }

        private void txt_username_Enter(object sender, EventArgs e)
        {
            txt_username.BorderSize = 2;

            if (txt_username.Text == "KULLANICI ADI")
            {
                txt_username.Text = "";
            }
        }

        private void txt_username_Leave(object sender, EventArgs e)
        {
            txt_username.BorderSize = 0;

            if (txt_username.Text == "")
                txt_username.Text = "KULLANICI ADI";
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            
        }
    }
}
