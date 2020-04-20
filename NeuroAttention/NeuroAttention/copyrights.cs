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
    public partial class Copyrights : UserControl
    {
        public Copyrights()
        {
            InitializeComponent();
        }

        private Guna.UI.Lib.ScrollBar.PanelScrollHelper vScrollHelper;
       
        private void button1_Click(object sender, EventArgs e)
        {
            

        }


        private void button2_Click(object sender, EventArgs e)
        {
        
        }

        private void copyrights_Load(object sender, EventArgs e)
        {
            vScrollHelper = new Guna.UI.Lib.ScrollBar.PanelScrollHelper(panel1, gunaVScrollBar1, true);
          

                lbl_description.Location = new Point(6, lbl_description.Height);
                panel1.Controls.Add(lbl_description);
            

            vScrollHelper.UpdateScrollBar();
           
        }
    }
}
