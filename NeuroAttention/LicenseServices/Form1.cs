using SKGL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LicenseServices
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_generate_Click(object sender, EventArgs e)
        {
            Generate generate = new Generate();
            generate.secretPhase = txt_dogrulamakodu.Text;
            txt_lisansanahtari.Text = generate.doKey(int.Parse(txt_gun.Text));
        }
    }
}
