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
    public partial class ConstantAttention : Form
    {
        public ConstantAttention()
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

          if(checkbox_plus.Checked==true && checkbox_minus.Checked == true && checkbox_impact.Checked == true && checkbox_compartment.Checked == true)
            {

                Random rndmath = new Random();
                int rndoperators = rndmath.Next(1, 5);

                if (rndoperators == 1)
                    operators = "+";


                else if (rndoperators == 2)
                    operators = "-";


                else if (rndoperators == 3)
                    operators = "x";

                else if (rndoperators == 4)
                    operators = "÷";

                if (number1 < number2)
                {
                    lbl_process.Text = number2.ToString() + " " + operators + " " + number1.ToString();
                }

                else
                    lbl_process.Text = number1.ToString() + " " + operators + " " + number2.ToString();

            }


          else if(checkbox_plus.Checked == true && checkbox_minus.Checked == true && checkbox_impact.Checked == false && checkbox_compartment.Checked == false)
            {
                Random rndmath = new Random();
                int rndoperators = rndmath.Next(1, 3);

                if (rndoperators == 1)
                    operators = "+";


                else if (rndoperators == 2)
                    operators = "-";


          
                if (number1 < number2)
                {
                    lbl_process.Text = number2.ToString() + " " + operators + " " + number1.ToString();
                }

                else
                    lbl_process.Text = number1.ToString() + " " + operators + " " + number2.ToString();
            }

          else if(checkbox_plus.Checked == true && checkbox_minus.Checked == true && checkbox_impact.Checked == true && checkbox_compartment.Checked == false)
            {

                Random rndmath = new Random();
                int rndoperators = rndmath.Next(1, 4);

                if (rndoperators == 1)
                    operators = "+";

                else if (rndoperators == 2)
                    operators = "-";

                else if (rndoperators == 3)
                    operators = "x";

                if (number1 < number2)
                {
                    lbl_process.Text = number2.ToString() + " " + operators + " " + number1.ToString();
                }

                else
                    lbl_process.Text = number1.ToString() + " " + operators + " " + number2.ToString();
            }

          else if (checkbox_plus.Checked == true && checkbox_minus.Checked == false && checkbox_impact.Checked == false && checkbox_compartment.Checked == false)
            {
              

                    operators = "+";

                if (number1 < number2)
                {
                    lbl_process.Text = number2.ToString() + " " + operators + " " + number1.ToString();
                }

                else
                    lbl_process.Text = number1.ToString() + " " + operators + " " + number2.ToString();

            }

          else if (checkbox_plus.Checked == false && checkbox_minus.Checked == true && checkbox_impact.Checked == false && checkbox_compartment.Checked == false)
            {


                operators = "-";

                if (number1 < number2)
                {
                    lbl_process.Text = number2.ToString() + " " + operators + " " + number1.ToString();
                }

                else
                    lbl_process.Text = number1.ToString() + " " + operators + " " + number2.ToString();
            }

          else if (checkbox_plus.Checked == false && checkbox_minus.Checked == false && checkbox_impact.Checked == true && checkbox_compartment.Checked == false)
            {

                operators = "x";

                if (number1 < number2)
                {
                    lbl_process.Text = number2.ToString() + " " + operators + " " + number1.ToString();
                }

                else
                    lbl_process.Text = number1.ToString() + " " + operators + " " + number2.ToString();
            }

          else if (checkbox_plus.Checked == false && checkbox_minus.Checked == false && checkbox_impact.Checked == false && checkbox_compartment.Checked == true)
            {

                operators = "÷";

                if (number1 < number2)
                {
                    lbl_process.Text = number2.ToString() + " " + operators + " " + number1.ToString();
                }

                else
                    lbl_process.Text = number1.ToString() + " " + operators + " " + number2.ToString();
            }

          else if(checkbox_plus.Checked == false && checkbox_minus.Checked == true && checkbox_impact.Checked == true && checkbox_compartment.Checked == false)
            {
                Random rndmath = new Random();
                int rndoperators = rndmath.Next(1, 3);

                if (rndoperators == 1)
                    operators = "-";

                else if (rndoperators == 2)
                    operators = "x";


                if (number1 < number2)
                {
                    lbl_process.Text = number2.ToString() + " " + operators + " " + number1.ToString();
                }

                else
                    lbl_process.Text = number1.ToString() + " " + operators + " " + number2.ToString();
            }

          else if (checkbox_plus.Checked == true && checkbox_minus.Checked == false && checkbox_impact.Checked == true && checkbox_compartment.Checked == false)
            {
                Random rndmath = new Random();
                int rndoperators = rndmath.Next(1, 3);

                if (rndoperators == 1)
                    operators = "+";

                else if (rndoperators == 2)
                    operators = "x";


                if (number1 < number2)
                {
                    lbl_process.Text = number2.ToString() + " " + operators + " " + number1.ToString();
                }

                else
                    lbl_process.Text = number1.ToString() + " " + operators + " " + number2.ToString();
            }

          else if (checkbox_plus.Checked == true && checkbox_minus.Checked == false && checkbox_impact.Checked == false && checkbox_compartment.Checked == true)
            {
                Random rndmath = new Random();
                int rndoperators = rndmath.Next(1, 3);

                if (rndoperators == 1)
                    operators = "+";

                else if (rndoperators == 2)
                    operators = "÷";


                if (number1 < number2)
                {
                    lbl_process.Text = number2.ToString() + " " + operators + " " + number1.ToString();
                }

                else
                    lbl_process.Text = number1.ToString() + " " + operators + " " + number2.ToString();
            }

          else if (checkbox_plus.Checked == false && checkbox_minus.Checked == false && checkbox_impact.Checked == true && checkbox_compartment.Checked == true)
            {

                Random rndmath = new Random();
                int rndoperators = rndmath.Next(1, 3);

                if (rndoperators == 1)
                    operators = "x";

                else if (rndoperators == 2)
                    operators = "÷";


                if (number1 < number2)
                {
                    lbl_process.Text = number2.ToString() + " " + operators + " " + number1.ToString();
                }

                else
                    lbl_process.Text = number1.ToString() + " " + operators + " " + number2.ToString();
            }

          else if (checkbox_plus.Checked == false && checkbox_minus.Checked == true && checkbox_impact.Checked == false && checkbox_compartment.Checked == true)
            {

                Random rndmath = new Random();
                int rndoperators = rndmath.Next(1, 3);

                if (rndoperators == 1)
                    operators = "-";

                else if (rndoperators == 2)
                    operators = "÷";


                if (number1 < number2)
                {
                    lbl_process.Text = number2.ToString() + " " + operators + " " + number1.ToString();
                }

                else
                    lbl_process.Text = number1.ToString() + " " + operators + " " + number2.ToString();
            }

          else if(checkbox_plus.Checked == false && checkbox_minus.Checked == true && checkbox_impact.Checked == true && checkbox_compartment.Checked == true)
            {

                Random rndmath = new Random();
                int rndoperators = rndmath.Next(1, 4);

                if (rndoperators == 1)
                    operators = "-";

                else if (rndoperators == 2)
                    operators = "x";

                else if (rndoperators == 3)
                    operators = "÷";


                if (number1 < number2)
                {
                    lbl_process.Text = number2.ToString() + " " + operators + " " + number1.ToString();
                }

                else
                    lbl_process.Text = number1.ToString() + " " + operators + " " + number2.ToString();
            }

          else if (checkbox_plus.Checked == true && checkbox_minus.Checked == true && checkbox_impact.Checked == false && checkbox_compartment.Checked == true)
            {
                Random rndmath = new Random();
                int rndoperators = rndmath.Next(1, 4);

                if (rndoperators == 1)
                    operators = "+";

                else if (rndoperators == 2)
                    operators = "-";

                else if (rndoperators == 3)
                    operators = "÷";


                if (number1 < number2)
                {
                    lbl_process.Text = number2.ToString() + " " + operators + " " + number1.ToString();
                }

                else
                    lbl_process.Text = number1.ToString() + " " + operators + " " + number2.ToString();
            }

          else if(checkbox_plus.Checked == true && checkbox_minus.Checked == false && checkbox_impact.Checked == true && checkbox_compartment.Checked == true)
            {

                Random rndmath = new Random();
                int rndoperators = rndmath.Next(1, 4);

                if (rndoperators == 1)
                    operators = "+";

                else if (rndoperators == 2)
                    operators = "x";

                else if (rndoperators == 3)
                    operators = "÷";


                if (number1 < number2)
                {
                    lbl_process.Text = number2.ToString() + " " + operators + " " + number1.ToString();
                }

                else
                    lbl_process.Text = number1.ToString() + " " + operators + " " + number2.ToString();
            }

            else
            {
                
            }

        }


        private void btn_start_Click(object sender, EventArgs e)
        {
            if (btn_stop.Visible == false)
            {
                btn_stop.Visible = true;
                btn_start.Visible = false;
            }

            if(checkbox_plus.Checked == false && checkbox_minus.Checked == false && checkbox_impact.Checked == false && checkbox_compartment.Checked == false)
            {
                MessageBox.Show("Ayarları doğru şekilde yapınız.");
                btn_stop.Visible = false;
                btn_start.Visible = true;
                lbl_screentime.Focus();
            }


            else
            {
               randomNumber();
                timer1.Interval = (int)numeric_time.Value * 1000;
                timer2.Interval = (int)numeric_screentime.Value;
                timer1.Start();
                timer2.Start();
                lbl_process.Visible = true;

            }
            

          
                
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

        private void ConstantAttention_Load(object sender, EventArgs e)
        {

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
