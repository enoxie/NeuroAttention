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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        public int number1, number2;
        public string operators;

        public void randomNumber()
        {
            int numeric1 = (int)numeric_numberrange1.Value;
            int numeric2 = (int)numeric_numberrange2.Value;
            Random rnd = new Random();
            number1 = rnd.Next(numeric1, numeric2);
            number2 = rnd.Next(numeric1, numeric2);

          

            Random rndmath = new Random();
            int rndoperators = rndmath.Next(1, 5);

            if (rndoperators == 1)
                operators = "+";


            else if (rndoperators == 2)
                operators = "-";


            else if (rndoperators == 3)
                operators = "x";

            else if (rndoperators == 4)
                operators = "/";

            if (number1 < number2)
            {
                lbl_process.Text = number2.ToString() + " " + operators + " " + number1.ToString();
            }

            else
                lbl_process.Text = number1.ToString() + " " + operators + " " + number2.ToString();

        }


        private void btn_start_Click(object sender, EventArgs e)
        {
            if (btn_stop.Visible == false)
            {
                btn_stop.Visible = true;
                btn_start.Visible = false;
            }

            randomNumber();
            timer1.Interval = (int)numeric_time.Value * 1000;
            timer2.Interval = (int)numeric_screentime.Value;
            timer1.Start();
            timer2.Start();
            lbl_process.Visible = true;
                
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            lbl_process.Visible = false;
            btn_stop.Visible = false;
            btn_start.Visible = true;
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            randomNumber();
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            if (btn_start.Visible == false)
            {
                btn_stop.Visible = false;
                btn_start.Visible = true;
            }

            timer1.Stop();
            timer2.Stop();
            lbl_process.Visible = false;
            lbl_process.Text = "";

        }
    }
}
