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

        
        public int trackChanged;
        public WMPLib.WindowsMediaPlayer muzikcalar = new WMPLib.WindowsMediaPlayer();
        public string[] musicArray = new string[4];
        public string[] musicinfoArray = new string[4];
        public string[] musictitleArray = new string[4];
        public int musicid = 0;
        public bool musicStarted = false;
        public bool musicpaused = false;
        public int playlistmode = 0;
        public int processStarted = 0;
        public int number1, number2, processnumber, rndoperators;
        public string operators;
        Random rndmath = new Random();
        Random rnd = new Random();
        

        public void randomNumberGenerator()
        {
            int numeric1 = int.Parse(txt_numericrange1.Text);
            int numeric2 = int.Parse(txt_numericrange2.Text);
            number1 = rnd.Next(numeric1, numeric2+1);
            number2 = rnd.Next(numeric1, numeric2+1);
        }

        public void processNumber()
        {
            if (checkbox_plus.Checked == true && checkbox_minus.Checked == true && checkbox_impact.Checked == true && checkbox_compartment.Checked == true)
                processnumber = 1;

            else if (checkbox_plus.Checked == true && checkbox_minus.Checked == true && checkbox_impact.Checked == false && checkbox_compartment.Checked == false)
                processnumber = 2;

            else if (checkbox_plus.Checked == true && checkbox_minus.Checked == true && checkbox_impact.Checked == true && checkbox_compartment.Checked == false)
                processnumber = 3;

            else if (checkbox_plus.Checked == true && checkbox_minus.Checked == false && checkbox_impact.Checked == false && checkbox_compartment.Checked == false)
                processnumber = 4;

            else if (checkbox_plus.Checked == false && checkbox_minus.Checked == true && checkbox_impact.Checked == false && checkbox_compartment.Checked == false)
                processnumber = 5;

            else if (checkbox_plus.Checked == false && checkbox_minus.Checked == false && checkbox_impact.Checked == true && checkbox_compartment.Checked == false)
                processnumber = 6;

            else if (checkbox_plus.Checked == false && checkbox_minus.Checked == false && checkbox_impact.Checked == false && checkbox_compartment.Checked == true)
                processnumber = 7;

            else if (checkbox_plus.Checked == false && checkbox_minus.Checked == true && checkbox_impact.Checked == true && checkbox_compartment.Checked == false)
                processnumber = 8;

            else if (checkbox_plus.Checked == true && checkbox_minus.Checked == false && checkbox_impact.Checked == true && checkbox_compartment.Checked == false)
                processnumber = 9;

            else if (checkbox_plus.Checked == true && checkbox_minus.Checked == false && checkbox_impact.Checked == false && checkbox_compartment.Checked == true)
                processnumber = 10;

            else if (checkbox_plus.Checked == false && checkbox_minus.Checked == false && checkbox_impact.Checked == true && checkbox_compartment.Checked == true)
                processnumber = 11;

            else if (checkbox_plus.Checked == false && checkbox_minus.Checked == true && checkbox_impact.Checked == false && checkbox_compartment.Checked == true)
                processnumber = 12;

            else if (checkbox_plus.Checked == false && checkbox_minus.Checked == true && checkbox_impact.Checked == true && checkbox_compartment.Checked == true)
                processnumber = 13;

            else if (checkbox_plus.Checked == true && checkbox_minus.Checked == true && checkbox_impact.Checked == false && checkbox_compartment.Checked == true)
                processnumber = 14;

            else if (checkbox_plus.Checked == true && checkbox_minus.Checked == false && checkbox_impact.Checked == true && checkbox_compartment.Checked == true)
                processnumber = 15;

      
            else { }

        }


        public void randomNumber()
        {
            randomNumberGenerator();
            processNumber();
            switch (processnumber)
            {
                case 1:
                    {
                        
                        rndoperators = rndmath.Next(1, 5);

                        if (rndoperators == 1)
                            operators = "+";


                        else if (rndoperators == 2)
                            operators = "-";


                        else if (rndoperators == 3)
                            operators = "x";

                        else if (rndoperators == 4)
                            operators = "÷";

                        if (rndoperators == 4)
                        {

                            if (number1 < number2)
                            {
                                if (number2 % number1 == 0)
                                {
                                    lbl_process.Text = number2.ToString() + " " + operators + " " + number1.ToString();
                                }

                                else
                                {
                                    lbl_process.Text = number1.ToString() + " " + operators + " " + number1.ToString();
                                }

                            }

                            else
                            {

                                if (number1 % number2 == 0)
                                {
                                    lbl_process.Text = number1.ToString() + " " + operators + " " + number2.ToString();
                                }

                                else
                                {

                                    lbl_process.Text = number1.ToString() + " " + operators + " " + number1.ToString();
                                }

                            }
                        }
                        else if (number1 < number2)
                        {
                            lbl_process.Text = number2.ToString() + " " + operators + " " + number1.ToString();
                        }

                        else
                            lbl_process.Text = number1.ToString() + " " + operators + " " + number2.ToString();
                        break;
                    }
                case 2:
                    {
                        
                        rndoperators = rndmath.Next(1, 3);

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
                        break;
                    }

                case 3:
                    {
                        
                        rndoperators = rndmath.Next(1, 4);

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
                        break;
                    }
                case 4:
                    {

                        operators = "+";

                        if (number1 < number2)
                        {
                            lbl_process.Text = number2.ToString() + " " + operators + " " + number1.ToString();
                        }

                        else
                            lbl_process.Text = number1.ToString() + " " + operators + " " + number2.ToString();
                        break;
                    }
                case 5:
                    {
                        operators = "-";

                        if (number1 < number2)
                        {
                            lbl_process.Text = number2.ToString() + " " + operators + " " + number1.ToString();
                        }

                        else
                            lbl_process.Text = number1.ToString() + " " + operators + " " + number2.ToString();
                        break;
                    }
                case 6: 
                    {
                        operators = "x";

                        if (number1 < number2)
                        {
                            lbl_process.Text = number2.ToString() + " " + operators + " " + number1.ToString();
                        }

                        else
                            lbl_process.Text = number1.ToString() + " " + operators + " " + number2.ToString();
                        break; 
                    }
                case 7:
                    {
                        operators = "÷";

                        if (number1 < number2)
                        {
                            if (number2 % number1 == 0)
                            {
                                lbl_process.Text = number2.ToString() + " " + operators + " " + number1.ToString();
                            }

                            else
                            {
                                lbl_process.Text = number1.ToString() + " " + operators + " " + number1.ToString();
                            }


                        }


                        else
                        {

                            if (number1 % number2 == 0)
                            {
                                lbl_process.Text = number1.ToString() + " " + operators + " " + number2.ToString();
                            }

                            else
                            {

                                lbl_process.Text = number1.ToString() + " " + operators + " " + number1.ToString();
                            }

                        }

                        break;
                    }
                case 8:
                    {
                        rndoperators = rndmath.Next(1, 3);

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
                        break;
                    }
                case 9:
                    {  
                        rndoperators = rndmath.Next(1, 3);

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
                        break;
                    }
                case 10:
                    {
                        rndoperators = rndmath.Next(1, 3);

                        if (rndoperators == 1)
                            operators = "+";

                        else if (rndoperators == 2)
                            operators = "÷";



                        if (rndoperators == 2)
                        {
                            if (number1 < number2)
                            {
                                if (number2 % number1 == 0)
                                {
                                    lbl_process.Text = number2.ToString() + " " + operators + " " + number1.ToString();
                                }

                                else
                                {
                                    lbl_process.Text = number1.ToString() + " " + operators + " " + number1.ToString();
                                }

                            }

                            else
                            {

                                if (number1 % number2 == 0)
                                {
                                    lbl_process.Text = number1.ToString() + " " + operators + " " + number2.ToString();
                                }

                                else
                                {

                                    lbl_process.Text = number1.ToString() + " " + operators + " " + number1.ToString();
                                }

                            }
                        }



                        else if (number1 < number2)
                        {
                            lbl_process.Text = number2.ToString() + " " + operators + " " + number1.ToString();
                        }

                        else
                            lbl_process.Text = number1.ToString() + " " + operators + " " + number2.ToString();
                        break;
                    }
                case 11:
                    {
                        rndoperators = rndmath.Next(1, 3);

                        if (rndoperators == 1)
                            operators = "x";

                        else if (rndoperators == 2)
                            operators = "÷";


                        if (rndoperators == 2)
                        {
                            if (number1 < number2)
                            {
                                if (number2 % number1 == 0)
                                {
                                    lbl_process.Text = number2.ToString() + " " + operators + " " + number1.ToString();
                                }

                                else
                                {
                                    lbl_process.Text = number1.ToString() + " " + operators + " " + number1.ToString();
                                }

                            }

                            else
                            {

                                if (number1 % number2 == 0)
                                {
                                    lbl_process.Text = number1.ToString() + " " + operators + " " + number2.ToString();
                                }

                                else
                                {

                                    lbl_process.Text = number1.ToString() + " " + operators + " " + number1.ToString();
                                }

                            }
                        }

                        else if (number1 < number2)
                        {
                            lbl_process.Text = number2.ToString() + " " + operators + " " + number1.ToString();
                        }

                        else
                            lbl_process.Text = number1.ToString() + " " + operators + " " + number2.ToString();
                        break;
                    }
                case 12:
                    {
                        rndoperators = rndmath.Next(1, 3);

                        if (rndoperators == 1)
                            operators = "-";

                        else if (rndoperators == 2)
                            operators = "÷";


                        if (rndoperators == 2)
                        {
                            if (number1 < number2)
                            {
                                if (number2 % number1 == 0)
                                {
                                    lbl_process.Text = number2.ToString() + " " + operators + " " + number1.ToString();
                                }

                                else
                                {
                                    lbl_process.Text = number1.ToString() + " " + operators + " " + number1.ToString();
                                }

                            }

                            else
                            {

                                if (number1 % number2 == 0)
                                {
                                    lbl_process.Text = number1.ToString() + " " + operators + " " + number2.ToString();
                                }

                                else
                                {

                                    lbl_process.Text = number1.ToString() + " " + operators + " " + number1.ToString();
                                }

                            }
                        }


                        else if (number1 < number2)
                        {
                            lbl_process.Text = number2.ToString() + " " + operators + " " + number1.ToString();
                        }

                        else
                            lbl_process.Text = number1.ToString() + " " + operators + " " + number2.ToString();
                        break;
                    }
                case 13:
                    {
                        rndoperators = rndmath.Next(1, 4);

                        if (rndoperators == 1)
                            operators = "-";

                        else if (rndoperators == 2)
                            operators = "x";

                        else if (rndoperators == 3)
                            operators = "÷";

                        if (rndoperators == 3)
                        {
                            if (number1 < number2)
                            {
                                if (number2 % number1 == 0)
                                {
                                    lbl_process.Text = number2.ToString() + " " + operators + " " + number1.ToString();
                                }

                                else
                                {
                                    lbl_process.Text = number1.ToString() + " " + operators + " " + number1.ToString();
                                }

                            }

                            else
                            {

                                if (number1 % number2 == 0)
                                {
                                    lbl_process.Text = number1.ToString() + " " + operators + " " + number2.ToString();
                                }

                                else
                                {

                                    lbl_process.Text = number1.ToString() + " " + operators + " " + number1.ToString();
                                }

                            }
                        }
                        else if (number1 < number2)
                        {
                            lbl_process.Text = number2.ToString() + " " + operators + " " + number1.ToString();
                        }

                        else
                            lbl_process.Text = number1.ToString() + " " + operators + " " + number2.ToString();
                        break;
                    }
                case 14:
                    {
                        rndoperators = rndmath.Next(1, 4);

                        if (rndoperators == 1)
                            operators = "+";

                        else if (rndoperators == 2)
                            operators = "-";

                        else if (rndoperators == 3)
                            operators = "÷";



                        if (rndoperators == 3)
                        {
                            if (number1 < number2)
                            {
                                if (number2 % number1 == 0)
                                {
                                    lbl_process.Text = number2.ToString() + " " + operators + " " + number1.ToString();
                                }

                                else
                                {
                                    lbl_process.Text = number1.ToString() + " " + operators + " " + number1.ToString();
                                }

                            }

                            else
                            {

                                if (number1 % number2 == 0)
                                {
                                    lbl_process.Text = number1.ToString() + " " + operators + " " + number2.ToString();
                                }

                                else
                                {

                                    lbl_process.Text = number1.ToString() + " " + operators + " " + number1.ToString();
                                }

                            }
                        }

                        else if (number1 < number2)
                        {
                            lbl_process.Text = number2.ToString() + " " + operators + " " + number1.ToString();
                        }

                        else
                            lbl_process.Text = number1.ToString() + " " + operators + " " + number2.ToString();
                        break;
                    }
                case 15:
                    {
                        rndoperators = rndmath.Next(1, 4);

                        if (rndoperators == 1)
                            operators = "+";

                        else if (rndoperators == 2)
                            operators = "x";

                        else if (rndoperators == 3)
                            operators = "÷";

                        if (rndoperators == 3)
                        {
                            if (number1 < number2)
                            {
                                if (number2 % number1 == 0)
                                {
                                    lbl_process.Text = number2.ToString() + " " + operators + " " + number1.ToString();
                                }

                                else
                                {
                                    lbl_process.Text = number1.ToString() + " " + operators + " " + number1.ToString();
                                }

                            }

                            else
                            {

                                if (number1 % number2 == 0)
                                {
                                    lbl_process.Text = number1.ToString() + " " + operators + " " + number2.ToString();
                                }

                                else
                                {

                                    lbl_process.Text = number1.ToString() + " " + operators + " " + number1.ToString();
                                }

                            }
                        }
                        else if (number1 < number2)
                        {
                            lbl_process.Text = number2.ToString() + " " + operators + " " + number1.ToString();
                        }

                        else
                            lbl_process.Text = number1.ToString() + " " + operators + " " + number2.ToString();
                        break;
                    }
            }
         
        }

        public void randomColor()
        {
            if (checkbox_plus.Checked && checkbox_minus.Checked && checkbox_impact.Checked && checkbox_compartment.Checked)
            {
                if (btn_color1.Visible == false || btn_color2.Visible == false || btn_color3.Visible == false || btn_color4.Visible == false)
                {
                    btn_color1.Location = new Point(45, 45);
                    btn_color2.Location = new Point(90, 45);
                    btn_color3.Location = new Point(135, 45);
                    btn_color4.Location = new Point(180, 45);
                    btn_color1.Visible = true;
                    btn_color2.Visible = true;
                    btn_color3.Visible = true;
                    btn_color4.Visible = true;


                    int color = rnd.Next(1, 22);
                    if (color == 1)
                    {
                        Settings1.Default.color1 = Color.Green;
                        Settings1.Default.color2 = Color.Yellow;
                        Settings1.Default.color3 = Color.Blue;
                        Settings1.Default.color4 = Color.Red;
                        Settings1.Default.Save();
                    }
                    else if (color == 2)
                    {
                        Settings1.Default.color1 = Color.Red;
                        Settings1.Default.color2 = Color.Yellow;
                        Settings1.Default.color3 = Color.Blue;
                        Settings1.Default.color4 = Color.Green;
                        Settings1.Default.Save();
                    }

                    else if (color == 3)
                    {
                        Settings1.Default.color1 = Color.Yellow;
                        Settings1.Default.color2 = Color.Green;
                        Settings1.Default.color3 = Color.Red;
                        Settings1.Default.color4 = Color.Blue;
                        Settings1.Default.Save();
                    }
                    else if (color == 4)
                    {
                        Settings1.Default.color1 = Color.Red;
                        Settings1.Default.color2 = Color.Yellow;
                        Settings1.Default.color3 = Color.Blue;
                        Settings1.Default.color4 = Color.Green;
                        Settings1.Default.Save();
                    }
                    else if (color == 5)
                    {
                        Settings1.Default.color1 = Color.Blue;
                        Settings1.Default.color2 = Color.Green;
                        Settings1.Default.color3 = Color.Yellow;
                        Settings1.Default.color4 = Color.Red;
                        Settings1.Default.Save();
                    }

                    else if (color == 6)
                    {
                        Settings1.Default.color1 = Color.Green;
                        Settings1.Default.color2 = Color.Blue;
                        Settings1.Default.color3 = Color.Yellow;
                        Settings1.Default.color4 = Color.Red;
                        Settings1.Default.Save();
                    }
                    else if (color == 7)
                    {
                        Settings1.Default.color1 = Color.Red;
                        Settings1.Default.color2 = Color.Green;
                        Settings1.Default.color3 = Color.Yellow;
                        Settings1.Default.color4 = Color.Blue;
                        Settings1.Default.Save();
                    }
                    else if (color == 8)
                    {
                        Settings1.Default.color1 = Color.Green;
                        Settings1.Default.color2 = Color.Red;
                        Settings1.Default.color3 = Color.Yellow;
                        Settings1.Default.color4 = Color.Blue;
                        Settings1.Default.Save();
                    }



                    else if (color == 9)
                    {
                        Settings1.Default.color1 = Color.Red;
                        Settings1.Default.color2 = Color.Green;
                        Settings1.Default.color3 = Color.Blue;
                        Settings1.Default.color4 = Color.Yellow;
                        Settings1.Default.Save();
                    }

                    else if (color == 10)
                    {
                        Settings1.Default.color1 = Color.Green;
                        Settings1.Default.color2 = Color.Yellow;
                        Settings1.Default.color3 = Color.Red;
                        Settings1.Default.color4 = Color.Blue;
                        Settings1.Default.Save();
                    }

                    else if (color == 11)
                    {
                        Settings1.Default.color1 = Color.Yellow;
                        Settings1.Default.color2 = Color.Blue;
                        Settings1.Default.color3 = Color.Green;
                        Settings1.Default.color4 = Color.Red;
                        Settings1.Default.Save();
                    }


                    else if (color == 12)
                    {
                        Settings1.Default.color1 = Color.Yellow;
                        Settings1.Default.color2 = Color.Red;
                        Settings1.Default.color3 = Color.Blue;
                        Settings1.Default.color4 = Color.Green;
                        Settings1.Default.Save();
                    }

                    else if (color == 13)
                    {
                        Settings1.Default.color1 = Color.Red;
                        Settings1.Default.color2 = Color.Green;
                        Settings1.Default.color3 = Color.Yellow;
                        Settings1.Default.color4 = Color.Blue;
                        Settings1.Default.Save();
                    }
                    else if (color == 14)
                    {
                        Settings1.Default.color1 = Color.Green;
                        Settings1.Default.color2 = Color.Yellow;
                        Settings1.Default.color3 = Color.Red;
                        Settings1.Default.color4 = Color.Blue;
                        Settings1.Default.Save();
                    }
                    else if (color == 15)
                    {
                        Settings1.Default.color1 = Color.Red;
                        Settings1.Default.color2 = Color.Blue;
                        Settings1.Default.color3 = Color.Green;
                        Settings1.Default.color4 = Color.Yellow;
                        Settings1.Default.Save();
                    }

                    else if (color == 16)
                    {
                        Settings1.Default.color1 = Color.Green;
                        Settings1.Default.color2 = Color.Blue;
                        Settings1.Default.color3 = Color.Red;
                        Settings1.Default.color4 = Color.Yellow;
                        Settings1.Default.Save();
                    }
                    else if (color == 17)
                    {
                        Settings1.Default.color1 = Color.Red;
                        Settings1.Default.color2 = Color.Blue;
                        Settings1.Default.color3 = Color.Green;
                        Settings1.Default.color4 = Color.Yellow;
                        Settings1.Default.Save();
                    }

                    else if (color == 18)
                    {
                        Settings1.Default.color1 = Color.Green;
                        Settings1.Default.color2 = Color.Blue;
                        Settings1.Default.color3 = Color.Red;
                        Settings1.Default.color4 = Color.Yellow;
                        Settings1.Default.Save();
                    }
                    else if (color == 19)
                    {
                        Settings1.Default.color1 = Color.Red;
                        Settings1.Default.color2 = Color.Blue;
                        Settings1.Default.color3 = Color.Yellow;
                        Settings1.Default.color4 = Color.Green;
                        Settings1.Default.Save();
                    }
                    else if (color == 20)
                    {
                        Settings1.Default.color1 = Color.Yellow;
                        Settings1.Default.color2 = Color.Red;
                        Settings1.Default.color3 = Color.Green;
                        Settings1.Default.color4 = Color.Blue;
                        Settings1.Default.Save();
                    }

                    else if (color == 21)
                    {
                        Settings1.Default.color1 = Color.Red;
                        Settings1.Default.color2 = Color.Yellow;
                        Settings1.Default.color3 = Color.Green;
                        Settings1.Default.color4 = Color.Blue;
                        Settings1.Default.Save();
                    }


                }
            }
            else if (checkbox_plus.Checked && checkbox_minus.Checked && checkbox_impact.Checked && checkbox_compartment.Checked == false)
            {
                if (btn_color1.Visible == false || btn_color2.Visible == false || btn_color3.Visible == false)
                {
                    btn_color1.Show();
                    btn_color2.Show();
                    btn_color3.Show();
                }
                btn_color4.Visible = false;
                btn_color1.Location = new Point(50, 45);
                btn_color2.Location = new Point(btn_color1.Location.X + 60, 45);
                btn_color3.Location = new Point(btn_color2.Location.X + 60, 45);

                int color = rnd.Next(1, 22);
                if (color == 1)
                {
                    Settings1.Default.color1 = Color.Green;
                    Settings1.Default.color2 = Color.Yellow;
                    Settings1.Default.color3 = Color.Blue;
                    Settings1.Default.color4 = Color.Red;
                    Settings1.Default.Save();
                }
                else if (color == 2)
                {
                    Settings1.Default.color1 = Color.Red;
                    Settings1.Default.color2 = Color.Yellow;
                    Settings1.Default.color3 = Color.Blue;
                    Settings1.Default.color4 = Color.Green;
                    Settings1.Default.Save();
                }

                else if (color == 3)
                {
                    Settings1.Default.color1 = Color.Yellow;
                    Settings1.Default.color2 = Color.Green;
                    Settings1.Default.color3 = Color.Red;
                    Settings1.Default.color4 = Color.Blue;
                    Settings1.Default.Save();
                }
                else if (color == 4)
                {
                    Settings1.Default.color1 = Color.Red;
                    Settings1.Default.color2 = Color.Yellow;
                    Settings1.Default.color3 = Color.Blue;
                    Settings1.Default.color4 = Color.Green;
                    Settings1.Default.Save();
                }
                else if (color == 5)
                {
                    Settings1.Default.color1 = Color.Blue;
                    Settings1.Default.color2 = Color.Green;
                    Settings1.Default.color3 = Color.Yellow;
                    Settings1.Default.color4 = Color.Red;
                    Settings1.Default.Save();
                }

                else if (color == 6)
                {
                    Settings1.Default.color1 = Color.Green;
                    Settings1.Default.color2 = Color.Blue;
                    Settings1.Default.color3 = Color.Yellow;
                    Settings1.Default.color4 = Color.Red;
                    Settings1.Default.Save();
                }
                else if (color == 7)
                {
                    Settings1.Default.color1 = Color.Red;
                    Settings1.Default.color2 = Color.Green;
                    Settings1.Default.color3 = Color.Yellow;
                    Settings1.Default.color4 = Color.Blue;
                    Settings1.Default.Save();
                }
                else if (color == 8)
                {
                    Settings1.Default.color1 = Color.Green;
                    Settings1.Default.color2 = Color.Red;
                    Settings1.Default.color3 = Color.Yellow;
                    Settings1.Default.color4 = Color.Blue;
                    Settings1.Default.Save();
                }

                else if (color == 9)
                {
                    Settings1.Default.color1 = Color.Red;
                    Settings1.Default.color2 = Color.Green;
                    Settings1.Default.color3 = Color.Blue;
                    Settings1.Default.color4 = Color.Yellow;
                    Settings1.Default.Save();
                }

                else if (color == 10)
                {
                    Settings1.Default.color1 = Color.Green;
                    Settings1.Default.color2 = Color.Yellow;
                    Settings1.Default.color3 = Color.Red;
                    Settings1.Default.color4 = Color.Blue;
                    Settings1.Default.Save();
                }

                else if (color == 11)
                {
                    Settings1.Default.color1 = Color.Yellow;
                    Settings1.Default.color2 = Color.Blue;
                    Settings1.Default.color3 = Color.Green;
                    Settings1.Default.color4 = Color.Red;
                    Settings1.Default.Save();
                }


                else if (color == 12)
                {
                    Settings1.Default.color1 = Color.Yellow;
                    Settings1.Default.color2 = Color.Red;
                    Settings1.Default.color3 = Color.Blue;
                    Settings1.Default.color4 = Color.Green;
                    Settings1.Default.Save();
                }

                else if (color == 13)
                {
                    Settings1.Default.color1 = Color.Red;
                    Settings1.Default.color2 = Color.Green;
                    Settings1.Default.color3 = Color.Yellow;
                    Settings1.Default.color4 = Color.Blue;
                    Settings1.Default.Save();
                }
                else if (color == 14)
                {
                    Settings1.Default.color1 = Color.Green;
                    Settings1.Default.color2 = Color.Yellow;
                    Settings1.Default.color3 = Color.Red;
                    Settings1.Default.color4 = Color.Blue;
                    Settings1.Default.Save();
                }
                else if (color == 15)
                {
                    Settings1.Default.color1 = Color.Red;
                    Settings1.Default.color2 = Color.Blue;
                    Settings1.Default.color3 = Color.Green;
                    Settings1.Default.color4 = Color.Yellow;
                    Settings1.Default.Save();
                }

                else if (color == 16)
                {
                    Settings1.Default.color1 = Color.Green;
                    Settings1.Default.color2 = Color.Blue;
                    Settings1.Default.color3 = Color.Red;
                    Settings1.Default.color4 = Color.Yellow;
                    Settings1.Default.Save();
                }
                else if (color == 17)
                {
                    Settings1.Default.color1 = Color.Red;
                    Settings1.Default.color2 = Color.Blue;
                    Settings1.Default.color3 = Color.Green;
                    Settings1.Default.color4 = Color.Yellow;
                    Settings1.Default.Save();
                }

                else if (color == 18)
                {
                    Settings1.Default.color1 = Color.Green;
                    Settings1.Default.color2 = Color.Blue;
                    Settings1.Default.color3 = Color.Red;
                    Settings1.Default.color4 = Color.Yellow;
                    Settings1.Default.Save();
                }
                else if (color == 19)
                {
                    Settings1.Default.color1 = Color.Red;
                    Settings1.Default.color2 = Color.Blue;
                    Settings1.Default.color3 = Color.Yellow;
                    Settings1.Default.color4 = Color.Green;
                    Settings1.Default.Save();
                }
                else if (color == 20)
                {
                    Settings1.Default.color1 = Color.Yellow;
                    Settings1.Default.color2 = Color.Red;
                    Settings1.Default.color3 = Color.Green;
                    Settings1.Default.color4 = Color.Blue;
                    Settings1.Default.Save();
                }

                else if (color == 21)
                {
                    Settings1.Default.color1 = Color.Red;
                    Settings1.Default.color2 = Color.Yellow;
                    Settings1.Default.color3 = Color.Green;
                    Settings1.Default.color4 = Color.Blue;
                    Settings1.Default.Save();
                }

            }
            else if (checkbox_plus.Checked && checkbox_minus.Checked == false && checkbox_impact.Checked == false && checkbox_compartment.Checked == false)
            {
                if (btn_color1.Visible == false)
                {
                    btn_color1.Show();
                }
                btn_color2.Visible = false;
                btn_color3.Visible = false;
                btn_color4.Visible = false;
                btn_color1.Location = new Point(110, 45);

                int color = rnd.Next(1, 22);
                if (color == 1)
                {
                    Settings1.Default.color1 = Color.Green;
                    Settings1.Default.color2 = Color.Yellow;
                    Settings1.Default.color3 = Color.Blue;
                    Settings1.Default.color4 = Color.Red;
                    Settings1.Default.Save();
                }
                else if (color == 2)
                {
                    Settings1.Default.color1 = Color.Red;
                    Settings1.Default.color2 = Color.Yellow;
                    Settings1.Default.color3 = Color.Blue;
                    Settings1.Default.color4 = Color.Green;
                    Settings1.Default.Save();
                }

                else if (color == 3)
                {
                    Settings1.Default.color1 = Color.Yellow;
                    Settings1.Default.color2 = Color.Green;
                    Settings1.Default.color3 = Color.Red;
                    Settings1.Default.color4 = Color.Blue;
                    Settings1.Default.Save();
                }
                else if (color == 4)
                {
                    Settings1.Default.color1 = Color.Red;
                    Settings1.Default.color2 = Color.Yellow;
                    Settings1.Default.color3 = Color.Blue;
                    Settings1.Default.color4 = Color.Green;
                    Settings1.Default.Save();
                }
                else if (color == 5)
                {
                    Settings1.Default.color1 = Color.Blue;
                    Settings1.Default.color2 = Color.Green;
                    Settings1.Default.color3 = Color.Yellow;
                    Settings1.Default.color4 = Color.Red;
                    Settings1.Default.Save();
                }

                else if (color == 6)
                {
                    Settings1.Default.color1 = Color.Green;
                    Settings1.Default.color2 = Color.Blue;
                    Settings1.Default.color3 = Color.Yellow;
                    Settings1.Default.color4 = Color.Red;
                    Settings1.Default.Save();
                }
                else if (color == 7)
                {
                    Settings1.Default.color1 = Color.Red;
                    Settings1.Default.color2 = Color.Green;
                    Settings1.Default.color3 = Color.Yellow;
                    Settings1.Default.color4 = Color.Blue;
                    Settings1.Default.Save();
                }
                else if (color == 8)
                {
                    Settings1.Default.color1 = Color.Green;
                    Settings1.Default.color2 = Color.Red;
                    Settings1.Default.color3 = Color.Yellow;
                    Settings1.Default.color4 = Color.Blue;
                    Settings1.Default.Save();
                }

                else if (color == 9)
                {
                    Settings1.Default.color1 = Color.Red;
                    Settings1.Default.color2 = Color.Green;
                    Settings1.Default.color3 = Color.Blue;
                    Settings1.Default.color4 = Color.Yellow;
                    Settings1.Default.Save();
                }

                else if (color == 10)
                {
                    Settings1.Default.color1 = Color.Green;
                    Settings1.Default.color2 = Color.Yellow;
                    Settings1.Default.color3 = Color.Red;
                    Settings1.Default.color4 = Color.Blue;
                    Settings1.Default.Save();
                }

                else if (color == 11)
                {
                    Settings1.Default.color1 = Color.Yellow;
                    Settings1.Default.color2 = Color.Blue;
                    Settings1.Default.color3 = Color.Green;
                    Settings1.Default.color4 = Color.Red;
                    Settings1.Default.Save();
                }


                else if (color == 12)
                {
                    Settings1.Default.color1 = Color.Yellow;
                    Settings1.Default.color2 = Color.Red;
                    Settings1.Default.color3 = Color.Blue;
                    Settings1.Default.color4 = Color.Green;
                    Settings1.Default.Save();
                }

                else if (color == 13)
                {
                    Settings1.Default.color1 = Color.Red;
                    Settings1.Default.color2 = Color.Green;
                    Settings1.Default.color3 = Color.Yellow;
                    Settings1.Default.color4 = Color.Blue;
                    Settings1.Default.Save();
                }
                else if (color == 14)
                {
                    Settings1.Default.color1 = Color.Green;
                    Settings1.Default.color2 = Color.Yellow;
                    Settings1.Default.color3 = Color.Red;
                    Settings1.Default.color4 = Color.Blue;
                    Settings1.Default.Save();
                }
                else if (color == 15)
                {
                    Settings1.Default.color1 = Color.Red;
                    Settings1.Default.color2 = Color.Blue;
                    Settings1.Default.color3 = Color.Green;
                    Settings1.Default.color4 = Color.Yellow;
                    Settings1.Default.Save();
                }

                else if (color == 16)
                {
                    Settings1.Default.color1 = Color.Green;
                    Settings1.Default.color2 = Color.Blue;
                    Settings1.Default.color3 = Color.Red;
                    Settings1.Default.color4 = Color.Yellow;
                    Settings1.Default.Save();
                }
                else if (color == 17)
                {
                    Settings1.Default.color1 = Color.Red;
                    Settings1.Default.color2 = Color.Blue;
                    Settings1.Default.color3 = Color.Green;
                    Settings1.Default.color4 = Color.Yellow;
                    Settings1.Default.Save();
                }

                else if (color == 18)
                {
                    Settings1.Default.color1 = Color.Green;
                    Settings1.Default.color2 = Color.Blue;
                    Settings1.Default.color3 = Color.Red;
                    Settings1.Default.color4 = Color.Yellow;
                    Settings1.Default.Save();
                }
                else if (color == 19)
                {
                    Settings1.Default.color1 = Color.Red;
                    Settings1.Default.color2 = Color.Blue;
                    Settings1.Default.color3 = Color.Yellow;
                    Settings1.Default.color4 = Color.Green;
                    Settings1.Default.Save();
                }
                else if (color == 20)
                {
                    Settings1.Default.color1 = Color.Yellow;
                    Settings1.Default.color2 = Color.Red;
                    Settings1.Default.color3 = Color.Green;
                    Settings1.Default.color4 = Color.Blue;
                    Settings1.Default.Save();
                }

                else if (color == 21)
                {
                    Settings1.Default.color1 = Color.Red;
                    Settings1.Default.color2 = Color.Yellow;
                    Settings1.Default.color3 = Color.Green;
                    Settings1.Default.color4 = Color.Blue;
                    Settings1.Default.Save();
                }

            }
            else if (checkbox_plus.Checked == false && checkbox_minus.Checked && checkbox_impact.Checked == false && checkbox_compartment.Checked == false)
            {
                if (btn_color2.Visible == false)
                {
                    btn_color2.Show();
                }
                btn_color1.Visible = false;
                btn_color3.Visible = false;
                btn_color4.Visible = false;
                btn_color2.Location = new Point(110, 45);

                int color = rnd.Next(1, 22);
                if (color == 1)
                {
                    Settings1.Default.color1 = Color.Green;
                    Settings1.Default.color2 = Color.Yellow;
                    Settings1.Default.color3 = Color.Blue;
                    Settings1.Default.color4 = Color.Red;
                    Settings1.Default.Save();
                }
                else if (color == 2)
                {
                    Settings1.Default.color1 = Color.Red;
                    Settings1.Default.color2 = Color.Yellow;
                    Settings1.Default.color3 = Color.Blue;
                    Settings1.Default.color4 = Color.Green;
                    Settings1.Default.Save();
                }

                else if (color == 3)
                {
                    Settings1.Default.color1 = Color.Yellow;
                    Settings1.Default.color2 = Color.Green;
                    Settings1.Default.color3 = Color.Red;
                    Settings1.Default.color4 = Color.Blue;
                    Settings1.Default.Save();
                }
                else if (color == 4)
                {
                    Settings1.Default.color1 = Color.Red;
                    Settings1.Default.color2 = Color.Yellow;
                    Settings1.Default.color3 = Color.Blue;
                    Settings1.Default.color4 = Color.Green;
                    Settings1.Default.Save();
                }
                else if (color == 5)
                {
                    Settings1.Default.color1 = Color.Blue;
                    Settings1.Default.color2 = Color.Green;
                    Settings1.Default.color3 = Color.Yellow;
                    Settings1.Default.color4 = Color.Red;
                    Settings1.Default.Save();
                }

                else if (color == 6)
                {
                    Settings1.Default.color1 = Color.Green;
                    Settings1.Default.color2 = Color.Blue;
                    Settings1.Default.color3 = Color.Yellow;
                    Settings1.Default.color4 = Color.Red;
                    Settings1.Default.Save();
                }
                else if (color == 7)
                {
                    Settings1.Default.color1 = Color.Red;
                    Settings1.Default.color2 = Color.Green;
                    Settings1.Default.color3 = Color.Yellow;
                    Settings1.Default.color4 = Color.Blue;
                    Settings1.Default.Save();
                }
                else if (color == 8)
                {
                    Settings1.Default.color1 = Color.Green;
                    Settings1.Default.color2 = Color.Red;
                    Settings1.Default.color3 = Color.Yellow;
                    Settings1.Default.color4 = Color.Blue;
                    Settings1.Default.Save();
                }

                else if (color == 9)
                {
                    Settings1.Default.color1 = Color.Red;
                    Settings1.Default.color2 = Color.Green;
                    Settings1.Default.color3 = Color.Blue;
                    Settings1.Default.color4 = Color.Yellow;
                    Settings1.Default.Save();
                }

                else if (color == 10)
                {
                    Settings1.Default.color1 = Color.Green;
                    Settings1.Default.color2 = Color.Yellow;
                    Settings1.Default.color3 = Color.Red;
                    Settings1.Default.color4 = Color.Blue;
                    Settings1.Default.Save();
                }

                else if (color == 11)
                {
                    Settings1.Default.color1 = Color.Yellow;
                    Settings1.Default.color2 = Color.Blue;
                    Settings1.Default.color3 = Color.Green;
                    Settings1.Default.color4 = Color.Red;
                    Settings1.Default.Save();
                }


                else if (color == 12)
                {
                    Settings1.Default.color1 = Color.Yellow;
                    Settings1.Default.color2 = Color.Red;
                    Settings1.Default.color3 = Color.Blue;
                    Settings1.Default.color4 = Color.Green;
                    Settings1.Default.Save();
                }

                else if (color == 13)
                {
                    Settings1.Default.color1 = Color.Red;
                    Settings1.Default.color2 = Color.Green;
                    Settings1.Default.color3 = Color.Yellow;
                    Settings1.Default.color4 = Color.Blue;
                    Settings1.Default.Save();
                }
                else if (color == 14)
                {
                    Settings1.Default.color1 = Color.Green;
                    Settings1.Default.color2 = Color.Yellow;
                    Settings1.Default.color3 = Color.Red;
                    Settings1.Default.color4 = Color.Blue;
                    Settings1.Default.Save();
                }
                else if (color == 15)
                {
                    Settings1.Default.color1 = Color.Red;
                    Settings1.Default.color2 = Color.Blue;
                    Settings1.Default.color3 = Color.Green;
                    Settings1.Default.color4 = Color.Yellow;
                    Settings1.Default.Save();
                }

                else if (color == 16)
                {
                    Settings1.Default.color1 = Color.Green;
                    Settings1.Default.color2 = Color.Blue;
                    Settings1.Default.color3 = Color.Red;
                    Settings1.Default.color4 = Color.Yellow;
                    Settings1.Default.Save();
                }
                else if (color == 17)
                {
                    Settings1.Default.color1 = Color.Red;
                    Settings1.Default.color2 = Color.Blue;
                    Settings1.Default.color3 = Color.Green;
                    Settings1.Default.color4 = Color.Yellow;
                    Settings1.Default.Save();
                }

                else if (color == 18)
                {
                    Settings1.Default.color1 = Color.Green;
                    Settings1.Default.color2 = Color.Blue;
                    Settings1.Default.color3 = Color.Red;
                    Settings1.Default.color4 = Color.Yellow;
                    Settings1.Default.Save();
                }
                else if (color == 19)
                {
                    Settings1.Default.color1 = Color.Red;
                    Settings1.Default.color2 = Color.Blue;
                    Settings1.Default.color3 = Color.Yellow;
                    Settings1.Default.color4 = Color.Green;
                    Settings1.Default.Save();
                }
                else if (color == 20)
                {
                    Settings1.Default.color1 = Color.Yellow;
                    Settings1.Default.color2 = Color.Red;
                    Settings1.Default.color3 = Color.Green;
                    Settings1.Default.color4 = Color.Blue;
                    Settings1.Default.Save();
                }

                else if (color == 21)
                {
                    Settings1.Default.color1 = Color.Red;
                    Settings1.Default.color2 = Color.Yellow;
                    Settings1.Default.color3 = Color.Green;
                    Settings1.Default.color4 = Color.Blue;
                    Settings1.Default.Save();
                }
            }
            else if (checkbox_plus.Checked == false && checkbox_minus.Checked == false && checkbox_impact.Checked && checkbox_compartment.Checked == false)
            {
                if (btn_color3.Visible == false)
                {
                    btn_color3.Show();
                }
                btn_color1.Visible = false;
                btn_color2.Visible = false;
                btn_color4.Visible = false;
                btn_color3.Location = new Point(110, 45);

                int color = rnd.Next(1, 22);
                if (color == 1)
                {
                    Settings1.Default.color1 = Color.Green;
                    Settings1.Default.color2 = Color.Yellow;
                    Settings1.Default.color3 = Color.Blue;
                    Settings1.Default.color4 = Color.Red;
                    Settings1.Default.Save();
                }
                else if (color == 2)
                {
                    Settings1.Default.color1 = Color.Red;
                    Settings1.Default.color2 = Color.Yellow;
                    Settings1.Default.color3 = Color.Blue;
                    Settings1.Default.color4 = Color.Green;
                    Settings1.Default.Save();
                }

                else if (color == 3)
                {
                    Settings1.Default.color1 = Color.Yellow;
                    Settings1.Default.color2 = Color.Green;
                    Settings1.Default.color3 = Color.Red;
                    Settings1.Default.color4 = Color.Blue;
                    Settings1.Default.Save();
                }
                else if (color == 4)
                {
                    Settings1.Default.color1 = Color.Red;
                    Settings1.Default.color2 = Color.Yellow;
                    Settings1.Default.color3 = Color.Blue;
                    Settings1.Default.color4 = Color.Green;
                    Settings1.Default.Save();
                }
                else if (color == 5)
                {
                    Settings1.Default.color1 = Color.Blue;
                    Settings1.Default.color2 = Color.Green;
                    Settings1.Default.color3 = Color.Yellow;
                    Settings1.Default.color4 = Color.Red;
                    Settings1.Default.Save();
                }

                else if (color == 6)
                {
                    Settings1.Default.color1 = Color.Green;
                    Settings1.Default.color2 = Color.Blue;
                    Settings1.Default.color3 = Color.Yellow;
                    Settings1.Default.color4 = Color.Red;
                    Settings1.Default.Save();
                }
                else if (color == 7)
                {
                    Settings1.Default.color1 = Color.Red;
                    Settings1.Default.color2 = Color.Green;
                    Settings1.Default.color3 = Color.Yellow;
                    Settings1.Default.color4 = Color.Blue;
                    Settings1.Default.Save();
                }
                else if (color == 8)
                {
                    Settings1.Default.color1 = Color.Green;
                    Settings1.Default.color2 = Color.Red;
                    Settings1.Default.color3 = Color.Yellow;
                    Settings1.Default.color4 = Color.Blue;
                    Settings1.Default.Save();
                }

                else if (color == 9)
                {
                    Settings1.Default.color1 = Color.Red;
                    Settings1.Default.color2 = Color.Green;
                    Settings1.Default.color3 = Color.Blue;
                    Settings1.Default.color4 = Color.Yellow;
                    Settings1.Default.Save();
                }

                else if (color == 10)
                {
                    Settings1.Default.color1 = Color.Green;
                    Settings1.Default.color2 = Color.Yellow;
                    Settings1.Default.color3 = Color.Red;
                    Settings1.Default.color4 = Color.Blue;
                    Settings1.Default.Save();
                }

                else if (color == 11)
                {
                    Settings1.Default.color1 = Color.Yellow;
                    Settings1.Default.color2 = Color.Blue;
                    Settings1.Default.color3 = Color.Green;
                    Settings1.Default.color4 = Color.Red;
                    Settings1.Default.Save();
                }


                else if (color == 12)
                {
                    Settings1.Default.color1 = Color.Yellow;
                    Settings1.Default.color2 = Color.Red;
                    Settings1.Default.color3 = Color.Blue;
                    Settings1.Default.color4 = Color.Green;
                    Settings1.Default.Save();
                }

                else if (color == 13)
                {
                    Settings1.Default.color1 = Color.Red;
                    Settings1.Default.color2 = Color.Green;
                    Settings1.Default.color3 = Color.Yellow;
                    Settings1.Default.color4 = Color.Blue;
                    Settings1.Default.Save();
                }
                else if (color == 14)
                {
                    Settings1.Default.color1 = Color.Green;
                    Settings1.Default.color2 = Color.Yellow;
                    Settings1.Default.color3 = Color.Red;
                    Settings1.Default.color4 = Color.Blue;
                    Settings1.Default.Save();
                }
                else if (color == 15)
                {
                    Settings1.Default.color1 = Color.Red;
                    Settings1.Default.color2 = Color.Blue;
                    Settings1.Default.color3 = Color.Green;
                    Settings1.Default.color4 = Color.Yellow;
                    Settings1.Default.Save();
                }

                else if (color == 16)
                {
                    Settings1.Default.color1 = Color.Green;
                    Settings1.Default.color2 = Color.Blue;
                    Settings1.Default.color3 = Color.Red;
                    Settings1.Default.color4 = Color.Yellow;
                    Settings1.Default.Save();
                }
                else if (color == 17)
                {
                    Settings1.Default.color1 = Color.Red;
                    Settings1.Default.color2 = Color.Blue;
                    Settings1.Default.color3 = Color.Green;
                    Settings1.Default.color4 = Color.Yellow;
                    Settings1.Default.Save();
                }

                else if (color == 18)
                {
                    Settings1.Default.color1 = Color.Green;
                    Settings1.Default.color2 = Color.Blue;
                    Settings1.Default.color3 = Color.Red;
                    Settings1.Default.color4 = Color.Yellow;
                    Settings1.Default.Save();
                }
                else if (color == 19)
                {
                    Settings1.Default.color1 = Color.Red;
                    Settings1.Default.color2 = Color.Blue;
                    Settings1.Default.color3 = Color.Yellow;
                    Settings1.Default.color4 = Color.Green;
                    Settings1.Default.Save();
                }
                else if (color == 20)
                {
                    Settings1.Default.color1 = Color.Yellow;
                    Settings1.Default.color2 = Color.Red;
                    Settings1.Default.color3 = Color.Green;
                    Settings1.Default.color4 = Color.Blue;
                    Settings1.Default.Save();
                }

                else if (color == 21)
                {
                    Settings1.Default.color1 = Color.Red;
                    Settings1.Default.color2 = Color.Yellow;
                    Settings1.Default.color3 = Color.Green;
                    Settings1.Default.color4 = Color.Blue;
                    Settings1.Default.Save();
                }
            }
            else if (checkbox_plus.Checked == false && checkbox_minus.Checked == false && checkbox_impact.Checked == false && checkbox_compartment.Checked)
            {
                if (btn_color4.Visible == false)
                {
                    btn_color4.Show();
                }
                btn_color1.Visible = false;
                btn_color2.Visible = false;
                btn_color3.Visible = false;
                btn_color4.Location = new Point(110, 45);

                int color = rnd.Next(1, 22);
                if (color == 1)
                {
                    Settings1.Default.color1 = Color.Green;
                    Settings1.Default.color2 = Color.Yellow;
                    Settings1.Default.color3 = Color.Blue;
                    Settings1.Default.color4 = Color.Red;
                    Settings1.Default.Save();
                }
                else if (color == 2)
                {
                    Settings1.Default.color1 = Color.Red;
                    Settings1.Default.color2 = Color.Yellow;
                    Settings1.Default.color3 = Color.Blue;
                    Settings1.Default.color4 = Color.Green;
                    Settings1.Default.Save();
                }

                else if (color == 3)
                {
                    Settings1.Default.color1 = Color.Yellow;
                    Settings1.Default.color2 = Color.Green;
                    Settings1.Default.color3 = Color.Red;
                    Settings1.Default.color4 = Color.Blue;
                    Settings1.Default.Save();
                }
                else if (color == 4)
                {
                    Settings1.Default.color1 = Color.Red;
                    Settings1.Default.color2 = Color.Yellow;
                    Settings1.Default.color3 = Color.Blue;
                    Settings1.Default.color4 = Color.Green;
                    Settings1.Default.Save();
                }
                else if (color == 5)
                {
                    Settings1.Default.color1 = Color.Blue;
                    Settings1.Default.color2 = Color.Green;
                    Settings1.Default.color3 = Color.Yellow;
                    Settings1.Default.color4 = Color.Red;
                    Settings1.Default.Save();
                }

                else if (color == 6)
                {
                    Settings1.Default.color1 = Color.Green;
                    Settings1.Default.color2 = Color.Blue;
                    Settings1.Default.color3 = Color.Yellow;
                    Settings1.Default.color4 = Color.Red;
                    Settings1.Default.Save();
                }
                else if (color == 7)
                {
                    Settings1.Default.color1 = Color.Red;
                    Settings1.Default.color2 = Color.Green;
                    Settings1.Default.color3 = Color.Yellow;
                    Settings1.Default.color4 = Color.Blue;
                    Settings1.Default.Save();
                }
                else if (color == 8)
                {
                    Settings1.Default.color1 = Color.Green;
                    Settings1.Default.color2 = Color.Red;
                    Settings1.Default.color3 = Color.Yellow;
                    Settings1.Default.color4 = Color.Blue;
                    Settings1.Default.Save();
                }

                else if (color == 9)
                {
                    Settings1.Default.color1 = Color.Red;
                    Settings1.Default.color2 = Color.Green;
                    Settings1.Default.color3 = Color.Blue;
                    Settings1.Default.color4 = Color.Yellow;
                    Settings1.Default.Save();
                }

                else if (color == 10)
                {
                    Settings1.Default.color1 = Color.Green;
                    Settings1.Default.color2 = Color.Yellow;
                    Settings1.Default.color3 = Color.Red;
                    Settings1.Default.color4 = Color.Blue;
                    Settings1.Default.Save();
                }

                else if (color == 11)
                {
                    Settings1.Default.color1 = Color.Yellow;
                    Settings1.Default.color2 = Color.Blue;
                    Settings1.Default.color3 = Color.Green;
                    Settings1.Default.color4 = Color.Red;
                    Settings1.Default.Save();
                }


                else if (color == 12)
                {
                    Settings1.Default.color1 = Color.Yellow;
                    Settings1.Default.color2 = Color.Red;
                    Settings1.Default.color3 = Color.Blue;
                    Settings1.Default.color4 = Color.Green;
                    Settings1.Default.Save();
                }

                else if (color == 13)
                {
                    Settings1.Default.color1 = Color.Red;
                    Settings1.Default.color2 = Color.Green;
                    Settings1.Default.color3 = Color.Yellow;
                    Settings1.Default.color4 = Color.Blue;
                    Settings1.Default.Save();
                }
                else if (color == 14)
                {
                    Settings1.Default.color1 = Color.Green;
                    Settings1.Default.color2 = Color.Yellow;
                    Settings1.Default.color3 = Color.Red;
                    Settings1.Default.color4 = Color.Blue;
                    Settings1.Default.Save();
                }
                else if (color == 15)
                {
                    Settings1.Default.color1 = Color.Red;
                    Settings1.Default.color2 = Color.Blue;
                    Settings1.Default.color3 = Color.Green;
                    Settings1.Default.color4 = Color.Yellow;
                    Settings1.Default.Save();
                }

                else if (color == 16)
                {
                    Settings1.Default.color1 = Color.Green;
                    Settings1.Default.color2 = Color.Blue;
                    Settings1.Default.color3 = Color.Red;
                    Settings1.Default.color4 = Color.Yellow;
                    Settings1.Default.Save();
                }
                else if (color == 17)
                {
                    Settings1.Default.color1 = Color.Red;
                    Settings1.Default.color2 = Color.Blue;
                    Settings1.Default.color3 = Color.Green;
                    Settings1.Default.color4 = Color.Yellow;
                    Settings1.Default.Save();
                }

                else if (color == 18)
                {
                    Settings1.Default.color1 = Color.Green;
                    Settings1.Default.color2 = Color.Blue;
                    Settings1.Default.color3 = Color.Red;
                    Settings1.Default.color4 = Color.Yellow;
                    Settings1.Default.Save();
                }
                else if (color == 19)
                {
                    Settings1.Default.color1 = Color.Red;
                    Settings1.Default.color2 = Color.Blue;
                    Settings1.Default.color3 = Color.Yellow;
                    Settings1.Default.color4 = Color.Green;
                    Settings1.Default.Save();
                }
                else if (color == 20)
                {
                    Settings1.Default.color1 = Color.Yellow;
                    Settings1.Default.color2 = Color.Red;
                    Settings1.Default.color3 = Color.Green;
                    Settings1.Default.color4 = Color.Blue;
                    Settings1.Default.Save();
                }

                else if (color == 21)
                {
                    Settings1.Default.color1 = Color.Red;
                    Settings1.Default.color2 = Color.Yellow;
                    Settings1.Default.color3 = Color.Green;
                    Settings1.Default.color4 = Color.Blue;
                    Settings1.Default.Save();
                }
            }
            else if (checkbox_plus.Checked && checkbox_minus.Checked && checkbox_impact.Checked == false && checkbox_compartment.Checked == false)
            {
                if (btn_color1.Visible == false || btn_color2.Visible == false)
                {
                    btn_color1.Show();
                    btn_color2.Show();
                }
                btn_color3.Visible = false;
                btn_color4.Visible = false;
                btn_color1.Location = new Point(50, 45);
                btn_color2.Location = new Point(btn_color1.Location.X + 120, 45);

                int color = rnd.Next(1, 22);
                if (color == 1)
                {
                    Settings1.Default.color1 = Color.Green;
                    Settings1.Default.color2 = Color.Yellow;
                    Settings1.Default.color3 = Color.Blue;
                    Settings1.Default.color4 = Color.Red;
                    Settings1.Default.Save();
                }
                else if (color == 2)
                {
                    Settings1.Default.color1 = Color.Red;
                    Settings1.Default.color2 = Color.Yellow;
                    Settings1.Default.color3 = Color.Blue;
                    Settings1.Default.color4 = Color.Green;
                    Settings1.Default.Save();
                }

                else if (color == 3)
                {
                    Settings1.Default.color1 = Color.Yellow;
                    Settings1.Default.color2 = Color.Green;
                    Settings1.Default.color3 = Color.Red;
                    Settings1.Default.color4 = Color.Blue;
                    Settings1.Default.Save();
                }
                else if (color == 4)
                {
                    Settings1.Default.color1 = Color.Red;
                    Settings1.Default.color2 = Color.Yellow;
                    Settings1.Default.color3 = Color.Blue;
                    Settings1.Default.color4 = Color.Green;
                    Settings1.Default.Save();
                }
                else if (color == 5)
                {
                    Settings1.Default.color1 = Color.Blue;
                    Settings1.Default.color2 = Color.Green;
                    Settings1.Default.color3 = Color.Yellow;
                    Settings1.Default.color4 = Color.Red;
                    Settings1.Default.Save();
                }

                else if (color == 6)
                {
                    Settings1.Default.color1 = Color.Green;
                    Settings1.Default.color2 = Color.Blue;
                    Settings1.Default.color3 = Color.Yellow;
                    Settings1.Default.color4 = Color.Red;
                    Settings1.Default.Save();
                }
                else if (color == 7)
                {
                    Settings1.Default.color1 = Color.Red;
                    Settings1.Default.color2 = Color.Green;
                    Settings1.Default.color3 = Color.Yellow;
                    Settings1.Default.color4 = Color.Blue;
                    Settings1.Default.Save();
                }
                else if (color == 8)
                {
                    Settings1.Default.color1 = Color.Green;
                    Settings1.Default.color2 = Color.Red;
                    Settings1.Default.color3 = Color.Yellow;
                    Settings1.Default.color4 = Color.Blue;
                    Settings1.Default.Save();
                }

                else if (color == 9)
                {
                    Settings1.Default.color1 = Color.Red;
                    Settings1.Default.color2 = Color.Green;
                    Settings1.Default.color3 = Color.Blue;
                    Settings1.Default.color4 = Color.Yellow;
                    Settings1.Default.Save();
                }

                else if (color == 10)
                {
                    Settings1.Default.color1 = Color.Green;
                    Settings1.Default.color2 = Color.Yellow;
                    Settings1.Default.color3 = Color.Red;
                    Settings1.Default.color4 = Color.Blue;
                    Settings1.Default.Save();
                }

                else if (color == 11)
                {
                    Settings1.Default.color1 = Color.Yellow;
                    Settings1.Default.color2 = Color.Blue;
                    Settings1.Default.color3 = Color.Green;
                    Settings1.Default.color4 = Color.Red;
                    Settings1.Default.Save();
                }


                else if (color == 12)
                {
                    Settings1.Default.color1 = Color.Yellow;
                    Settings1.Default.color2 = Color.Red;
                    Settings1.Default.color3 = Color.Blue;
                    Settings1.Default.color4 = Color.Green;
                    Settings1.Default.Save();
                }

                else if (color == 13)
                {
                    Settings1.Default.color1 = Color.Red;
                    Settings1.Default.color2 = Color.Green;
                    Settings1.Default.color3 = Color.Yellow;
                    Settings1.Default.color4 = Color.Blue;
                    Settings1.Default.Save();
                }
                else if (color == 14)
                {
                    Settings1.Default.color1 = Color.Green;
                    Settings1.Default.color2 = Color.Yellow;
                    Settings1.Default.color3 = Color.Red;
                    Settings1.Default.color4 = Color.Blue;
                    Settings1.Default.Save();
                }
                else if (color == 15)
                {
                    Settings1.Default.color1 = Color.Red;
                    Settings1.Default.color2 = Color.Blue;
                    Settings1.Default.color3 = Color.Green;
                    Settings1.Default.color4 = Color.Yellow;
                    Settings1.Default.Save();
                }

                else if (color == 16)
                {
                    Settings1.Default.color1 = Color.Green;
                    Settings1.Default.color2 = Color.Blue;
                    Settings1.Default.color3 = Color.Red;
                    Settings1.Default.color4 = Color.Yellow;
                    Settings1.Default.Save();
                }
                else if (color == 17)
                {
                    Settings1.Default.color1 = Color.Red;
                    Settings1.Default.color2 = Color.Blue;
                    Settings1.Default.color3 = Color.Green;
                    Settings1.Default.color4 = Color.Yellow;
                    Settings1.Default.Save();
                }

                else if (color == 18)
                {
                    Settings1.Default.color1 = Color.Green;
                    Settings1.Default.color2 = Color.Blue;
                    Settings1.Default.color3 = Color.Red;
                    Settings1.Default.color4 = Color.Yellow;
                    Settings1.Default.Save();
                }
                else if (color == 19)
                {
                    Settings1.Default.color1 = Color.Red;
                    Settings1.Default.color2 = Color.Blue;
                    Settings1.Default.color3 = Color.Yellow;
                    Settings1.Default.color4 = Color.Green;
                    Settings1.Default.Save();
                }
                else if (color == 20)
                {
                    Settings1.Default.color1 = Color.Yellow;
                    Settings1.Default.color2 = Color.Red;
                    Settings1.Default.color3 = Color.Green;
                    Settings1.Default.color4 = Color.Blue;
                    Settings1.Default.Save();
                }

                else if (color == 21)
                {
                    Settings1.Default.color1 = Color.Red;
                    Settings1.Default.color2 = Color.Yellow;
                    Settings1.Default.color3 = Color.Green;
                    Settings1.Default.color4 = Color.Blue;
                    Settings1.Default.Save();
                }

            }
            else if (checkbox_plus.Checked && checkbox_minus.Checked == false && checkbox_impact.Checked && checkbox_compartment.Checked == false)
            {
                if (btn_color1.Visible == false || btn_color3.Visible == false)
                {
                    btn_color1.Show();
                    btn_color3.Show();
                }
                btn_color2.Visible = false;
                btn_color4.Visible = false;
                btn_color1.Location = new Point(50, 45);
                btn_color3.Location = new Point(btn_color1.Location.X + 120, 45);

                int color = rnd.Next(1, 22);
                if (color == 1)
                {
                    Settings1.Default.color1 = Color.Green;
                    Settings1.Default.color2 = Color.Yellow;
                    Settings1.Default.color3 = Color.Blue;
                    Settings1.Default.color4 = Color.Red;
                    Settings1.Default.Save();
                }
                else if (color == 2)
                {
                    Settings1.Default.color1 = Color.Red;
                    Settings1.Default.color2 = Color.Yellow;
                    Settings1.Default.color3 = Color.Blue;
                    Settings1.Default.color4 = Color.Green;
                    Settings1.Default.Save();
                }

                else if (color == 3)
                {
                    Settings1.Default.color1 = Color.Yellow;
                    Settings1.Default.color2 = Color.Green;
                    Settings1.Default.color3 = Color.Red;
                    Settings1.Default.color4 = Color.Blue;
                    Settings1.Default.Save();
                }
                else if (color == 4)
                {
                    Settings1.Default.color1 = Color.Red;
                    Settings1.Default.color2 = Color.Yellow;
                    Settings1.Default.color3 = Color.Blue;
                    Settings1.Default.color4 = Color.Green;
                    Settings1.Default.Save();
                }
                else if (color == 5)
                {
                    Settings1.Default.color1 = Color.Blue;
                    Settings1.Default.color2 = Color.Green;
                    Settings1.Default.color3 = Color.Yellow;
                    Settings1.Default.color4 = Color.Red;
                    Settings1.Default.Save();
                }

                else if (color == 6)
                {
                    Settings1.Default.color1 = Color.Green;
                    Settings1.Default.color2 = Color.Blue;
                    Settings1.Default.color3 = Color.Yellow;
                    Settings1.Default.color4 = Color.Red;
                    Settings1.Default.Save();
                }
                else if (color == 7)
                {
                    Settings1.Default.color1 = Color.Red;
                    Settings1.Default.color2 = Color.Green;
                    Settings1.Default.color3 = Color.Yellow;
                    Settings1.Default.color4 = Color.Blue;
                    Settings1.Default.Save();
                }
                else if (color == 8)
                {
                    Settings1.Default.color1 = Color.Green;
                    Settings1.Default.color2 = Color.Red;
                    Settings1.Default.color3 = Color.Yellow;
                    Settings1.Default.color4 = Color.Blue;
                    Settings1.Default.Save();
                }

                else if (color == 9)
                {
                    Settings1.Default.color1 = Color.Red;
                    Settings1.Default.color2 = Color.Green;
                    Settings1.Default.color3 = Color.Blue;
                    Settings1.Default.color4 = Color.Yellow;
                    Settings1.Default.Save();
                }

                else if (color == 10)
                {
                    Settings1.Default.color1 = Color.Green;
                    Settings1.Default.color2 = Color.Yellow;
                    Settings1.Default.color3 = Color.Red;
                    Settings1.Default.color4 = Color.Blue;
                    Settings1.Default.Save();
                }

                else if (color == 11)
                {
                    Settings1.Default.color1 = Color.Yellow;
                    Settings1.Default.color2 = Color.Blue;
                    Settings1.Default.color3 = Color.Green;
                    Settings1.Default.color4 = Color.Red;
                    Settings1.Default.Save();
                }


                else if (color == 12)
                {
                    Settings1.Default.color1 = Color.Yellow;
                    Settings1.Default.color2 = Color.Red;
                    Settings1.Default.color3 = Color.Blue;
                    Settings1.Default.color4 = Color.Green;
                    Settings1.Default.Save();
                }

                else if (color == 13)
                {
                    Settings1.Default.color1 = Color.Red;
                    Settings1.Default.color2 = Color.Green;
                    Settings1.Default.color3 = Color.Yellow;
                    Settings1.Default.color4 = Color.Blue;
                    Settings1.Default.Save();
                }
                else if (color == 14)
                {
                    Settings1.Default.color1 = Color.Green;
                    Settings1.Default.color2 = Color.Yellow;
                    Settings1.Default.color3 = Color.Red;
                    Settings1.Default.color4 = Color.Blue;
                    Settings1.Default.Save();
                }
                else if (color == 15)
                {
                    Settings1.Default.color1 = Color.Red;
                    Settings1.Default.color2 = Color.Blue;
                    Settings1.Default.color3 = Color.Green;
                    Settings1.Default.color4 = Color.Yellow;
                    Settings1.Default.Save();
                }

                else if (color == 16)
                {
                    Settings1.Default.color1 = Color.Green;
                    Settings1.Default.color2 = Color.Blue;
                    Settings1.Default.color3 = Color.Red;
                    Settings1.Default.color4 = Color.Yellow;
                    Settings1.Default.Save();
                }
                else if (color == 17)
                {
                    Settings1.Default.color1 = Color.Red;
                    Settings1.Default.color2 = Color.Blue;
                    Settings1.Default.color3 = Color.Green;
                    Settings1.Default.color4 = Color.Yellow;
                    Settings1.Default.Save();
                }

                else if (color == 18)
                {
                    Settings1.Default.color1 = Color.Green;
                    Settings1.Default.color2 = Color.Blue;
                    Settings1.Default.color3 = Color.Red;
                    Settings1.Default.color4 = Color.Yellow;
                    Settings1.Default.Save();
                }
                else if (color == 19)
                {
                    Settings1.Default.color1 = Color.Red;
                    Settings1.Default.color2 = Color.Blue;
                    Settings1.Default.color3 = Color.Yellow;
                    Settings1.Default.color4 = Color.Green;
                    Settings1.Default.Save();
                }
                else if (color == 20)
                {
                    Settings1.Default.color1 = Color.Yellow;
                    Settings1.Default.color2 = Color.Red;
                    Settings1.Default.color3 = Color.Green;
                    Settings1.Default.color4 = Color.Blue;
                    Settings1.Default.Save();
                }

                else if (color == 21)
                {
                    Settings1.Default.color1 = Color.Red;
                    Settings1.Default.color2 = Color.Yellow;
                    Settings1.Default.color3 = Color.Green;
                    Settings1.Default.color4 = Color.Blue;
                    Settings1.Default.Save();
                }
            }
            else if (checkbox_plus.Checked && checkbox_minus.Checked == false && checkbox_impact.Checked == false && checkbox_compartment.Checked)
            {
                if (btn_color1.Visible == false || btn_color4.Visible == false)
                {
                    btn_color1.Show();
                    btn_color4.Show();
                }
                btn_color2.Visible = false;
                btn_color3.Visible = false;
                btn_color1.Location = new Point(50, 45);
                btn_color4.Location = new Point(btn_color1.Location.X + 120, 45);

                int color = rnd.Next(1, 22);
                if (color == 1)
                {
                    Settings1.Default.color1 = Color.Green;
                    Settings1.Default.color2 = Color.Yellow;
                    Settings1.Default.color3 = Color.Blue;
                    Settings1.Default.color4 = Color.Red;
                    Settings1.Default.Save();
                }
                else if (color == 2)
                {
                    Settings1.Default.color1 = Color.Red;
                    Settings1.Default.color2 = Color.Yellow;
                    Settings1.Default.color3 = Color.Blue;
                    Settings1.Default.color4 = Color.Green;
                    Settings1.Default.Save();
                }

                else if (color == 3)
                {
                    Settings1.Default.color1 = Color.Yellow;
                    Settings1.Default.color2 = Color.Green;
                    Settings1.Default.color3 = Color.Red;
                    Settings1.Default.color4 = Color.Blue;
                    Settings1.Default.Save();
                }
                else if (color == 4)
                {
                    Settings1.Default.color1 = Color.Red;
                    Settings1.Default.color2 = Color.Yellow;
                    Settings1.Default.color3 = Color.Blue;
                    Settings1.Default.color4 = Color.Green;
                    Settings1.Default.Save();
                }
                else if (color == 5)
                {
                    Settings1.Default.color1 = Color.Blue;
                    Settings1.Default.color2 = Color.Green;
                    Settings1.Default.color3 = Color.Yellow;
                    Settings1.Default.color4 = Color.Red;
                    Settings1.Default.Save();
                }

                else if (color == 6)
                {
                    Settings1.Default.color1 = Color.Green;
                    Settings1.Default.color2 = Color.Blue;
                    Settings1.Default.color3 = Color.Yellow;
                    Settings1.Default.color4 = Color.Red;
                    Settings1.Default.Save();
                }
                else if (color == 7)
                {
                    Settings1.Default.color1 = Color.Red;
                    Settings1.Default.color2 = Color.Green;
                    Settings1.Default.color3 = Color.Yellow;
                    Settings1.Default.color4 = Color.Blue;
                    Settings1.Default.Save();
                }
                else if (color == 8)
                {
                    Settings1.Default.color1 = Color.Green;
                    Settings1.Default.color2 = Color.Red;
                    Settings1.Default.color3 = Color.Yellow;
                    Settings1.Default.color4 = Color.Blue;
                    Settings1.Default.Save();
                }

                else if (color == 9)
                {
                    Settings1.Default.color1 = Color.Red;
                    Settings1.Default.color2 = Color.Green;
                    Settings1.Default.color3 = Color.Blue;
                    Settings1.Default.color4 = Color.Yellow;
                    Settings1.Default.Save();
                }

                else if (color == 10)
                {
                    Settings1.Default.color1 = Color.Green;
                    Settings1.Default.color2 = Color.Yellow;
                    Settings1.Default.color3 = Color.Red;
                    Settings1.Default.color4 = Color.Blue;
                    Settings1.Default.Save();
                }

                else if (color == 11)
                {
                    Settings1.Default.color1 = Color.Yellow;
                    Settings1.Default.color2 = Color.Blue;
                    Settings1.Default.color3 = Color.Green;
                    Settings1.Default.color4 = Color.Red;
                    Settings1.Default.Save();
                }


                else if (color == 12)
                {
                    Settings1.Default.color1 = Color.Yellow;
                    Settings1.Default.color2 = Color.Red;
                    Settings1.Default.color3 = Color.Blue;
                    Settings1.Default.color4 = Color.Green;
                    Settings1.Default.Save();
                }

                else if (color == 13)
                {
                    Settings1.Default.color1 = Color.Red;
                    Settings1.Default.color2 = Color.Green;
                    Settings1.Default.color3 = Color.Yellow;
                    Settings1.Default.color4 = Color.Blue;
                    Settings1.Default.Save();
                }
                else if (color == 14)
                {
                    Settings1.Default.color1 = Color.Green;
                    Settings1.Default.color2 = Color.Yellow;
                    Settings1.Default.color3 = Color.Red;
                    Settings1.Default.color4 = Color.Blue;
                    Settings1.Default.Save();
                }
                else if (color == 15)
                {
                    Settings1.Default.color1 = Color.Red;
                    Settings1.Default.color2 = Color.Blue;
                    Settings1.Default.color3 = Color.Green;
                    Settings1.Default.color4 = Color.Yellow;
                    Settings1.Default.Save();
                }

                else if (color == 16)
                {
                    Settings1.Default.color1 = Color.Green;
                    Settings1.Default.color2 = Color.Blue;
                    Settings1.Default.color3 = Color.Red;
                    Settings1.Default.color4 = Color.Yellow;
                    Settings1.Default.Save();
                }
                else if (color == 17)
                {
                    Settings1.Default.color1 = Color.Red;
                    Settings1.Default.color2 = Color.Blue;
                    Settings1.Default.color3 = Color.Green;
                    Settings1.Default.color4 = Color.Yellow;
                    Settings1.Default.Save();
                }

                else if (color == 18)
                {
                    Settings1.Default.color1 = Color.Green;
                    Settings1.Default.color2 = Color.Blue;
                    Settings1.Default.color3 = Color.Red;
                    Settings1.Default.color4 = Color.Yellow;
                    Settings1.Default.Save();
                }
                else if (color == 19)
                {
                    Settings1.Default.color1 = Color.Red;
                    Settings1.Default.color2 = Color.Blue;
                    Settings1.Default.color3 = Color.Yellow;
                    Settings1.Default.color4 = Color.Green;
                    Settings1.Default.Save();
                }
                else if (color == 20)
                {
                    Settings1.Default.color1 = Color.Yellow;
                    Settings1.Default.color2 = Color.Red;
                    Settings1.Default.color3 = Color.Green;
                    Settings1.Default.color4 = Color.Blue;
                    Settings1.Default.Save();
                }

                else if (color == 21)
                {
                    Settings1.Default.color1 = Color.Red;
                    Settings1.Default.color2 = Color.Yellow;
                    Settings1.Default.color3 = Color.Green;
                    Settings1.Default.color4 = Color.Blue;
                    Settings1.Default.Save();
                }
            }
            else if (checkbox_plus.Checked == false && checkbox_minus.Checked && checkbox_impact.Checked && checkbox_compartment.Checked == false)
            {
                if (btn_color2.Visible == false || btn_color3.Visible == false)
                {
                    btn_color2.Show();
                    btn_color3.Show();
                }
                btn_color1.Visible = false;
                btn_color4.Visible = false;
                btn_color2.Location = new Point(50, 45);
                btn_color3.Location = new Point(btn_color1.Location.X + 120, 45);

                int color = rnd.Next(1, 22);
                if (color == 1)
                {
                    Settings1.Default.color1 = Color.Green;
                    Settings1.Default.color2 = Color.Yellow;
                    Settings1.Default.color3 = Color.Blue;
                    Settings1.Default.color4 = Color.Red;
                    Settings1.Default.Save();
                }
                else if (color == 2)
                {
                    Settings1.Default.color1 = Color.Red;
                    Settings1.Default.color2 = Color.Yellow;
                    Settings1.Default.color3 = Color.Blue;
                    Settings1.Default.color4 = Color.Green;
                    Settings1.Default.Save();
                }

                else if (color == 3)
                {
                    Settings1.Default.color1 = Color.Yellow;
                    Settings1.Default.color2 = Color.Green;
                    Settings1.Default.color3 = Color.Red;
                    Settings1.Default.color4 = Color.Blue;
                    Settings1.Default.Save();
                }
                else if (color == 4)
                {
                    Settings1.Default.color1 = Color.Red;
                    Settings1.Default.color2 = Color.Yellow;
                    Settings1.Default.color3 = Color.Blue;
                    Settings1.Default.color4 = Color.Green;
                    Settings1.Default.Save();
                }
                else if (color == 5)
                {
                    Settings1.Default.color1 = Color.Blue;
                    Settings1.Default.color2 = Color.Green;
                    Settings1.Default.color3 = Color.Yellow;
                    Settings1.Default.color4 = Color.Red;
                    Settings1.Default.Save();
                }

                else if (color == 6)
                {
                    Settings1.Default.color1 = Color.Green;
                    Settings1.Default.color2 = Color.Blue;
                    Settings1.Default.color3 = Color.Yellow;
                    Settings1.Default.color4 = Color.Red;
                    Settings1.Default.Save();
                }
                else if (color == 7)
                {
                    Settings1.Default.color1 = Color.Red;
                    Settings1.Default.color2 = Color.Green;
                    Settings1.Default.color3 = Color.Yellow;
                    Settings1.Default.color4 = Color.Blue;
                    Settings1.Default.Save();
                }
                else if (color == 8)
                {
                    Settings1.Default.color1 = Color.Green;
                    Settings1.Default.color2 = Color.Red;
                    Settings1.Default.color3 = Color.Yellow;
                    Settings1.Default.color4 = Color.Blue;
                    Settings1.Default.Save();
                }

                else if (color == 9)
                {
                    Settings1.Default.color1 = Color.Red;
                    Settings1.Default.color2 = Color.Green;
                    Settings1.Default.color3 = Color.Blue;
                    Settings1.Default.color4 = Color.Yellow;
                    Settings1.Default.Save();
                }

                else if (color == 10)
                {
                    Settings1.Default.color1 = Color.Green;
                    Settings1.Default.color2 = Color.Yellow;
                    Settings1.Default.color3 = Color.Red;
                    Settings1.Default.color4 = Color.Blue;
                    Settings1.Default.Save();
                }

                else if (color == 11)
                {
                    Settings1.Default.color1 = Color.Yellow;
                    Settings1.Default.color2 = Color.Blue;
                    Settings1.Default.color3 = Color.Green;
                    Settings1.Default.color4 = Color.Red;
                    Settings1.Default.Save();
                }


                else if (color == 12)
                {
                    Settings1.Default.color1 = Color.Yellow;
                    Settings1.Default.color2 = Color.Red;
                    Settings1.Default.color3 = Color.Blue;
                    Settings1.Default.color4 = Color.Green;
                    Settings1.Default.Save();
                }

                else if (color == 13)
                {
                    Settings1.Default.color1 = Color.Red;
                    Settings1.Default.color2 = Color.Green;
                    Settings1.Default.color3 = Color.Yellow;
                    Settings1.Default.color4 = Color.Blue;
                    Settings1.Default.Save();
                }
                else if (color == 14)
                {
                    Settings1.Default.color1 = Color.Green;
                    Settings1.Default.color2 = Color.Yellow;
                    Settings1.Default.color3 = Color.Red;
                    Settings1.Default.color4 = Color.Blue;
                    Settings1.Default.Save();
                }
                else if (color == 15)
                {
                    Settings1.Default.color1 = Color.Red;
                    Settings1.Default.color2 = Color.Blue;
                    Settings1.Default.color3 = Color.Green;
                    Settings1.Default.color4 = Color.Yellow;
                    Settings1.Default.Save();
                }

                else if (color == 16)
                {
                    Settings1.Default.color1 = Color.Green;
                    Settings1.Default.color2 = Color.Blue;
                    Settings1.Default.color3 = Color.Red;
                    Settings1.Default.color4 = Color.Yellow;
                    Settings1.Default.Save();
                }
                else if (color == 17)
                {
                    Settings1.Default.color1 = Color.Red;
                    Settings1.Default.color2 = Color.Blue;
                    Settings1.Default.color3 = Color.Green;
                    Settings1.Default.color4 = Color.Yellow;
                    Settings1.Default.Save();
                }

                else if (color == 18)
                {
                    Settings1.Default.color1 = Color.Green;
                    Settings1.Default.color2 = Color.Blue;
                    Settings1.Default.color3 = Color.Red;
                    Settings1.Default.color4 = Color.Yellow;
                    Settings1.Default.Save();
                }
                else if (color == 19)
                {
                    Settings1.Default.color1 = Color.Red;
                    Settings1.Default.color2 = Color.Blue;
                    Settings1.Default.color3 = Color.Yellow;
                    Settings1.Default.color4 = Color.Green;
                    Settings1.Default.Save();
                }
                else if (color == 20)
                {
                    Settings1.Default.color1 = Color.Yellow;
                    Settings1.Default.color2 = Color.Red;
                    Settings1.Default.color3 = Color.Green;
                    Settings1.Default.color4 = Color.Blue;
                    Settings1.Default.Save();
                }

                else if (color == 21)
                {
                    Settings1.Default.color1 = Color.Red;
                    Settings1.Default.color2 = Color.Yellow;
                    Settings1.Default.color3 = Color.Green;
                    Settings1.Default.color4 = Color.Blue;
                    Settings1.Default.Save();
                }
            }
            else if (checkbox_plus.Checked == false && checkbox_minus.Checked && checkbox_impact.Checked == false && checkbox_compartment.Checked)
            {
                if (btn_color2.Visible == false || btn_color4.Visible == false)
                {
                    btn_color2.Show();
                    btn_color4.Show();
                }
                btn_color1.Visible = false;
                btn_color3.Visible = false;
                btn_color2.Location = new Point(50, 45);
                btn_color4.Location = new Point(btn_color1.Location.X + 120, 45);

                int color = rnd.Next(1, 22);
                if (color == 1)
                {
                    Settings1.Default.color1 = Color.Green;
                    Settings1.Default.color2 = Color.Yellow;
                    Settings1.Default.color3 = Color.Blue;
                    Settings1.Default.color4 = Color.Red;
                    Settings1.Default.Save();
                }
                else if (color == 2)
                {
                    Settings1.Default.color1 = Color.Red;
                    Settings1.Default.color2 = Color.Yellow;
                    Settings1.Default.color3 = Color.Blue;
                    Settings1.Default.color4 = Color.Green;
                    Settings1.Default.Save();
                }

                else if (color == 3)
                {
                    Settings1.Default.color1 = Color.Yellow;
                    Settings1.Default.color2 = Color.Green;
                    Settings1.Default.color3 = Color.Red;
                    Settings1.Default.color4 = Color.Blue;
                    Settings1.Default.Save();
                }
                else if (color == 4)
                {
                    Settings1.Default.color1 = Color.Red;
                    Settings1.Default.color2 = Color.Yellow;
                    Settings1.Default.color3 = Color.Blue;
                    Settings1.Default.color4 = Color.Green;
                    Settings1.Default.Save();
                }
                else if (color == 5)
                {
                    Settings1.Default.color1 = Color.Blue;
                    Settings1.Default.color2 = Color.Green;
                    Settings1.Default.color3 = Color.Yellow;
                    Settings1.Default.color4 = Color.Red;
                    Settings1.Default.Save();
                }

                else if (color == 6)
                {
                    Settings1.Default.color1 = Color.Green;
                    Settings1.Default.color2 = Color.Blue;
                    Settings1.Default.color3 = Color.Yellow;
                    Settings1.Default.color4 = Color.Red;
                    Settings1.Default.Save();
                }
                else if (color == 7)
                {
                    Settings1.Default.color1 = Color.Red;
                    Settings1.Default.color2 = Color.Green;
                    Settings1.Default.color3 = Color.Yellow;
                    Settings1.Default.color4 = Color.Blue;
                    Settings1.Default.Save();
                }
                else if (color == 8)
                {
                    Settings1.Default.color1 = Color.Green;
                    Settings1.Default.color2 = Color.Red;
                    Settings1.Default.color3 = Color.Yellow;
                    Settings1.Default.color4 = Color.Blue;
                    Settings1.Default.Save();
                }

                else if (color == 9)
                {
                    Settings1.Default.color1 = Color.Red;
                    Settings1.Default.color2 = Color.Green;
                    Settings1.Default.color3 = Color.Blue;
                    Settings1.Default.color4 = Color.Yellow;
                    Settings1.Default.Save();
                }

                else if (color == 10)
                {
                    Settings1.Default.color1 = Color.Green;
                    Settings1.Default.color2 = Color.Yellow;
                    Settings1.Default.color3 = Color.Red;
                    Settings1.Default.color4 = Color.Blue;
                    Settings1.Default.Save();
                }

                else if (color == 11)
                {
                    Settings1.Default.color1 = Color.Yellow;
                    Settings1.Default.color2 = Color.Blue;
                    Settings1.Default.color3 = Color.Green;
                    Settings1.Default.color4 = Color.Red;
                    Settings1.Default.Save();
                }


                else if (color == 12)
                {
                    Settings1.Default.color1 = Color.Yellow;
                    Settings1.Default.color2 = Color.Red;
                    Settings1.Default.color3 = Color.Blue;
                    Settings1.Default.color4 = Color.Green;
                    Settings1.Default.Save();
                }

                else if (color == 13)
                {
                    Settings1.Default.color1 = Color.Red;
                    Settings1.Default.color2 = Color.Green;
                    Settings1.Default.color3 = Color.Yellow;
                    Settings1.Default.color4 = Color.Blue;
                    Settings1.Default.Save();
                }
                else if (color == 14)
                {
                    Settings1.Default.color1 = Color.Green;
                    Settings1.Default.color2 = Color.Yellow;
                    Settings1.Default.color3 = Color.Red;
                    Settings1.Default.color4 = Color.Blue;
                    Settings1.Default.Save();
                }
                else if (color == 15)
                {
                    Settings1.Default.color1 = Color.Red;
                    Settings1.Default.color2 = Color.Blue;
                    Settings1.Default.color3 = Color.Green;
                    Settings1.Default.color4 = Color.Yellow;
                    Settings1.Default.Save();
                }

                else if (color == 16)
                {
                    Settings1.Default.color1 = Color.Green;
                    Settings1.Default.color2 = Color.Blue;
                    Settings1.Default.color3 = Color.Red;
                    Settings1.Default.color4 = Color.Yellow;
                    Settings1.Default.Save();
                }
                else if (color == 17)
                {
                    Settings1.Default.color1 = Color.Red;
                    Settings1.Default.color2 = Color.Blue;
                    Settings1.Default.color3 = Color.Green;
                    Settings1.Default.color4 = Color.Yellow;
                    Settings1.Default.Save();
                }

                else if (color == 18)
                {
                    Settings1.Default.color1 = Color.Green;
                    Settings1.Default.color2 = Color.Blue;
                    Settings1.Default.color3 = Color.Red;
                    Settings1.Default.color4 = Color.Yellow;
                    Settings1.Default.Save();
                }
                else if (color == 19)
                {
                    Settings1.Default.color1 = Color.Red;
                    Settings1.Default.color2 = Color.Blue;
                    Settings1.Default.color3 = Color.Yellow;
                    Settings1.Default.color4 = Color.Green;
                    Settings1.Default.Save();
                }
                else if (color == 20)
                {
                    Settings1.Default.color1 = Color.Yellow;
                    Settings1.Default.color2 = Color.Red;
                    Settings1.Default.color3 = Color.Green;
                    Settings1.Default.color4 = Color.Blue;
                    Settings1.Default.Save();
                }

                else if (color == 21)
                {
                    Settings1.Default.color1 = Color.Red;
                    Settings1.Default.color2 = Color.Yellow;
                    Settings1.Default.color3 = Color.Green;
                    Settings1.Default.color4 = Color.Blue;
                    Settings1.Default.Save();
                }
            }
            else if (checkbox_plus.Checked == false && checkbox_minus.Checked == false && checkbox_impact.Checked && checkbox_compartment.Checked)
            {
                if (btn_color3.Visible == false || btn_color4.Visible == false)
                {
                    btn_color3.Show();
                    btn_color4.Show();
                }
                btn_color1.Visible = false;
                btn_color2.Visible = false;
                btn_color3.Location = new Point(50, 45);
                btn_color4.Location = new Point(btn_color1.Location.X + 120, 45);

                int color = rnd.Next(1, 22);
                if (color == 1)
                {
                    Settings1.Default.color1 = Color.Green;
                    Settings1.Default.color2 = Color.Yellow;
                    Settings1.Default.color3 = Color.Blue;
                    Settings1.Default.color4 = Color.Red;
                    Settings1.Default.Save();
                }
                else if (color == 2)
                {
                    Settings1.Default.color1 = Color.Red;
                    Settings1.Default.color2 = Color.Yellow;
                    Settings1.Default.color3 = Color.Blue;
                    Settings1.Default.color4 = Color.Green;
                    Settings1.Default.Save();
                }

                else if (color == 3)
                {
                    Settings1.Default.color1 = Color.Yellow;
                    Settings1.Default.color2 = Color.Green;
                    Settings1.Default.color3 = Color.Red;
                    Settings1.Default.color4 = Color.Blue;
                    Settings1.Default.Save();
                }
                else if (color == 4)
                {
                    Settings1.Default.color1 = Color.Red;
                    Settings1.Default.color2 = Color.Yellow;
                    Settings1.Default.color3 = Color.Blue;
                    Settings1.Default.color4 = Color.Green;
                    Settings1.Default.Save();
                }
                else if (color == 5)
                {
                    Settings1.Default.color1 = Color.Blue;
                    Settings1.Default.color2 = Color.Green;
                    Settings1.Default.color3 = Color.Yellow;
                    Settings1.Default.color4 = Color.Red;
                    Settings1.Default.Save();
                }

                else if (color == 6)
                {
                    Settings1.Default.color1 = Color.Green;
                    Settings1.Default.color2 = Color.Blue;
                    Settings1.Default.color3 = Color.Yellow;
                    Settings1.Default.color4 = Color.Red;
                    Settings1.Default.Save();
                }
                else if (color == 7)
                {
                    Settings1.Default.color1 = Color.Red;
                    Settings1.Default.color2 = Color.Green;
                    Settings1.Default.color3 = Color.Yellow;
                    Settings1.Default.color4 = Color.Blue;
                    Settings1.Default.Save();
                }
                else if (color == 8)
                {
                    Settings1.Default.color1 = Color.Green;
                    Settings1.Default.color2 = Color.Red;
                    Settings1.Default.color3 = Color.Yellow;
                    Settings1.Default.color4 = Color.Blue;
                    Settings1.Default.Save();
                }

                else if (color == 9)
                {
                    Settings1.Default.color1 = Color.Red;
                    Settings1.Default.color2 = Color.Green;
                    Settings1.Default.color3 = Color.Blue;
                    Settings1.Default.color4 = Color.Yellow;
                    Settings1.Default.Save();
                }

                else if (color == 10)
                {
                    Settings1.Default.color1 = Color.Green;
                    Settings1.Default.color2 = Color.Yellow;
                    Settings1.Default.color3 = Color.Red;
                    Settings1.Default.color4 = Color.Blue;
                    Settings1.Default.Save();
                }

                else if (color == 11)
                {
                    Settings1.Default.color1 = Color.Yellow;
                    Settings1.Default.color2 = Color.Blue;
                    Settings1.Default.color3 = Color.Green;
                    Settings1.Default.color4 = Color.Red;
                    Settings1.Default.Save();
                }


                else if (color == 12)
                {
                    Settings1.Default.color1 = Color.Yellow;
                    Settings1.Default.color2 = Color.Red;
                    Settings1.Default.color3 = Color.Blue;
                    Settings1.Default.color4 = Color.Green;
                    Settings1.Default.Save();
                }

                else if (color == 13)
                {
                    Settings1.Default.color1 = Color.Red;
                    Settings1.Default.color2 = Color.Green;
                    Settings1.Default.color3 = Color.Yellow;
                    Settings1.Default.color4 = Color.Blue;
                    Settings1.Default.Save();
                }
                else if (color == 14)
                {
                    Settings1.Default.color1 = Color.Green;
                    Settings1.Default.color2 = Color.Yellow;
                    Settings1.Default.color3 = Color.Red;
                    Settings1.Default.color4 = Color.Blue;
                    Settings1.Default.Save();
                }
                else if (color == 15)
                {
                    Settings1.Default.color1 = Color.Red;
                    Settings1.Default.color2 = Color.Blue;
                    Settings1.Default.color3 = Color.Green;
                    Settings1.Default.color4 = Color.Yellow;
                    Settings1.Default.Save();
                }

                else if (color == 16)
                {
                    Settings1.Default.color1 = Color.Green;
                    Settings1.Default.color2 = Color.Blue;
                    Settings1.Default.color3 = Color.Red;
                    Settings1.Default.color4 = Color.Yellow;
                    Settings1.Default.Save();
                }
                else if (color == 17)
                {
                    Settings1.Default.color1 = Color.Red;
                    Settings1.Default.color2 = Color.Blue;
                    Settings1.Default.color3 = Color.Green;
                    Settings1.Default.color4 = Color.Yellow;
                    Settings1.Default.Save();
                }

                else if (color == 18)
                {
                    Settings1.Default.color1 = Color.Green;
                    Settings1.Default.color2 = Color.Blue;
                    Settings1.Default.color3 = Color.Red;
                    Settings1.Default.color4 = Color.Yellow;
                    Settings1.Default.Save();
                }
                else if (color == 19)
                {
                    Settings1.Default.color1 = Color.Red;
                    Settings1.Default.color2 = Color.Blue;
                    Settings1.Default.color3 = Color.Yellow;
                    Settings1.Default.color4 = Color.Green;
                    Settings1.Default.Save();
                }
                else if (color == 20)
                {
                    Settings1.Default.color1 = Color.Yellow;
                    Settings1.Default.color2 = Color.Red;
                    Settings1.Default.color3 = Color.Green;
                    Settings1.Default.color4 = Color.Blue;
                    Settings1.Default.Save();
                }

                else if (color == 21)
                {
                    Settings1.Default.color1 = Color.Red;
                    Settings1.Default.color2 = Color.Yellow;
                    Settings1.Default.color3 = Color.Green;
                    Settings1.Default.color4 = Color.Blue;
                    Settings1.Default.Save();
                }
            }
            else if (checkbox_plus.Checked && checkbox_minus.Checked && checkbox_impact.Checked && checkbox_compartment.Checked == false)
            {
                if (btn_color1.Visible == false || btn_color2.Visible == false || btn_color3.Visible == false)
                {
                    btn_color1.Show();
                    btn_color2.Show();
                    btn_color3.Show();
                }
                btn_color4.Visible = false;
                btn_color1.Location = new Point(50, 45);
                btn_color2.Location = new Point(btn_color1.Location.X + 120, 45);
                btn_color3.Location = new Point(btn_color2.Location.X + 120, 45);

                int color = rnd.Next(1, 22);
                if (color == 1)
                {
                    Settings1.Default.color1 = Color.Green;
                    Settings1.Default.color2 = Color.Yellow;
                    Settings1.Default.color3 = Color.Blue;
                    Settings1.Default.color4 = Color.Red;
                    Settings1.Default.Save();
                }
                else if (color == 2)
                {
                    Settings1.Default.color1 = Color.Red;
                    Settings1.Default.color2 = Color.Yellow;
                    Settings1.Default.color3 = Color.Blue;
                    Settings1.Default.color4 = Color.Green;
                    Settings1.Default.Save();
                }

                else if (color == 3)
                {
                    Settings1.Default.color1 = Color.Yellow;
                    Settings1.Default.color2 = Color.Green;
                    Settings1.Default.color3 = Color.Red;
                    Settings1.Default.color4 = Color.Blue;
                    Settings1.Default.Save();
                }
                else if (color == 4)
                {
                    Settings1.Default.color1 = Color.Red;
                    Settings1.Default.color2 = Color.Yellow;
                    Settings1.Default.color3 = Color.Blue;
                    Settings1.Default.color4 = Color.Green;
                    Settings1.Default.Save();
                }
                else if (color == 5)
                {
                    Settings1.Default.color1 = Color.Blue;
                    Settings1.Default.color2 = Color.Green;
                    Settings1.Default.color3 = Color.Yellow;
                    Settings1.Default.color4 = Color.Red;
                    Settings1.Default.Save();
                }

                else if (color == 6)
                {
                    Settings1.Default.color1 = Color.Green;
                    Settings1.Default.color2 = Color.Blue;
                    Settings1.Default.color3 = Color.Yellow;
                    Settings1.Default.color4 = Color.Red;
                    Settings1.Default.Save();
                }
                else if (color == 7)
                {
                    Settings1.Default.color1 = Color.Red;
                    Settings1.Default.color2 = Color.Green;
                    Settings1.Default.color3 = Color.Yellow;
                    Settings1.Default.color4 = Color.Blue;
                    Settings1.Default.Save();
                }
                else if (color == 8)
                {
                    Settings1.Default.color1 = Color.Green;
                    Settings1.Default.color2 = Color.Red;
                    Settings1.Default.color3 = Color.Yellow;
                    Settings1.Default.color4 = Color.Blue;
                    Settings1.Default.Save();
                }

                else if (color == 9)
                {
                    Settings1.Default.color1 = Color.Red;
                    Settings1.Default.color2 = Color.Green;
                    Settings1.Default.color3 = Color.Blue;
                    Settings1.Default.color4 = Color.Yellow;
                    Settings1.Default.Save();
                }

                else if (color == 10)
                {
                    Settings1.Default.color1 = Color.Green;
                    Settings1.Default.color2 = Color.Yellow;
                    Settings1.Default.color3 = Color.Red;
                    Settings1.Default.color4 = Color.Blue;
                    Settings1.Default.Save();
                }

                else if (color == 11)
                {
                    Settings1.Default.color1 = Color.Yellow;
                    Settings1.Default.color2 = Color.Blue;
                    Settings1.Default.color3 = Color.Green;
                    Settings1.Default.color4 = Color.Red;
                    Settings1.Default.Save();
                }


                else if (color == 12)
                {
                    Settings1.Default.color1 = Color.Yellow;
                    Settings1.Default.color2 = Color.Red;
                    Settings1.Default.color3 = Color.Blue;
                    Settings1.Default.color4 = Color.Green;
                    Settings1.Default.Save();
                }

                else if (color == 13)
                {
                    Settings1.Default.color1 = Color.Red;
                    Settings1.Default.color2 = Color.Green;
                    Settings1.Default.color3 = Color.Yellow;
                    Settings1.Default.color4 = Color.Blue;
                    Settings1.Default.Save();
                }
                else if (color == 14)
                {
                    Settings1.Default.color1 = Color.Green;
                    Settings1.Default.color2 = Color.Yellow;
                    Settings1.Default.color3 = Color.Red;
                    Settings1.Default.color4 = Color.Blue;
                    Settings1.Default.Save();
                }
                else if (color == 15)
                {
                    Settings1.Default.color1 = Color.Red;
                    Settings1.Default.color2 = Color.Blue;
                    Settings1.Default.color3 = Color.Green;
                    Settings1.Default.color4 = Color.Yellow;
                    Settings1.Default.Save();
                }

                else if (color == 16)
                {
                    Settings1.Default.color1 = Color.Green;
                    Settings1.Default.color2 = Color.Blue;
                    Settings1.Default.color3 = Color.Red;
                    Settings1.Default.color4 = Color.Yellow;
                    Settings1.Default.Save();
                }
                else if (color == 17)
                {
                    Settings1.Default.color1 = Color.Red;
                    Settings1.Default.color2 = Color.Blue;
                    Settings1.Default.color3 = Color.Green;
                    Settings1.Default.color4 = Color.Yellow;
                    Settings1.Default.Save();
                }

                else if (color == 18)
                {
                    Settings1.Default.color1 = Color.Green;
                    Settings1.Default.color2 = Color.Blue;
                    Settings1.Default.color3 = Color.Red;
                    Settings1.Default.color4 = Color.Yellow;
                    Settings1.Default.Save();
                }
                else if (color == 19)
                {
                    Settings1.Default.color1 = Color.Red;
                    Settings1.Default.color2 = Color.Blue;
                    Settings1.Default.color3 = Color.Yellow;
                    Settings1.Default.color4 = Color.Green;
                    Settings1.Default.Save();
                }
                else if (color == 20)
                {
                    Settings1.Default.color1 = Color.Yellow;
                    Settings1.Default.color2 = Color.Red;
                    Settings1.Default.color3 = Color.Green;
                    Settings1.Default.color4 = Color.Blue;
                    Settings1.Default.Save();
                }

                else if (color == 21)
                {
                    Settings1.Default.color1 = Color.Red;
                    Settings1.Default.color2 = Color.Yellow;
                    Settings1.Default.color3 = Color.Green;
                    Settings1.Default.color4 = Color.Blue;
                    Settings1.Default.Save();
                }
            }
            else if (checkbox_plus.Checked == false && checkbox_minus.Checked && checkbox_impact.Checked && checkbox_compartment.Checked)
            {
                if (btn_color2.Visible == false || btn_color3.Visible == false || btn_color4.Visible == false)
                {
                    btn_color2.Show();
                    btn_color3.Show();
                    btn_color4.Show();
                }
                btn_color1.Visible = false;
                btn_color2.Location = new Point(50, 45);
                btn_color3.Location = new Point(btn_color2.Location.X + 60, 45);
                btn_color4.Location = new Point(btn_color3.Location.X + 60, 45);

                int color = rnd.Next(1, 22);
                if (color == 1)
                {
                    Settings1.Default.color1 = Color.Green;
                    Settings1.Default.color2 = Color.Yellow;
                    Settings1.Default.color3 = Color.Blue;
                    Settings1.Default.color4 = Color.Red;
                    Settings1.Default.Save();
                }
                else if (color == 2)
                {
                    Settings1.Default.color1 = Color.Red;
                    Settings1.Default.color2 = Color.Yellow;
                    Settings1.Default.color3 = Color.Blue;
                    Settings1.Default.color4 = Color.Green;
                    Settings1.Default.Save();
                }

                else if (color == 3)
                {
                    Settings1.Default.color1 = Color.Yellow;
                    Settings1.Default.color2 = Color.Green;
                    Settings1.Default.color3 = Color.Red;
                    Settings1.Default.color4 = Color.Blue;
                    Settings1.Default.Save();
                }
                else if (color == 4)
                {
                    Settings1.Default.color1 = Color.Red;
                    Settings1.Default.color2 = Color.Yellow;
                    Settings1.Default.color3 = Color.Blue;
                    Settings1.Default.color4 = Color.Green;
                    Settings1.Default.Save();
                }
                else if (color == 5)
                {
                    Settings1.Default.color1 = Color.Blue;
                    Settings1.Default.color2 = Color.Green;
                    Settings1.Default.color3 = Color.Yellow;
                    Settings1.Default.color4 = Color.Red;
                    Settings1.Default.Save();
                }

                else if (color == 6)
                {
                    Settings1.Default.color1 = Color.Green;
                    Settings1.Default.color2 = Color.Blue;
                    Settings1.Default.color3 = Color.Yellow;
                    Settings1.Default.color4 = Color.Red;
                    Settings1.Default.Save();
                }
                else if (color == 7)
                {
                    Settings1.Default.color1 = Color.Red;
                    Settings1.Default.color2 = Color.Green;
                    Settings1.Default.color3 = Color.Yellow;
                    Settings1.Default.color4 = Color.Blue;
                    Settings1.Default.Save();
                }
                else if (color == 8)
                {
                    Settings1.Default.color1 = Color.Green;
                    Settings1.Default.color2 = Color.Red;
                    Settings1.Default.color3 = Color.Yellow;
                    Settings1.Default.color4 = Color.Blue;
                    Settings1.Default.Save();
                }

                else if (color == 9)
                {
                    Settings1.Default.color1 = Color.Red;
                    Settings1.Default.color2 = Color.Green;
                    Settings1.Default.color3 = Color.Blue;
                    Settings1.Default.color4 = Color.Yellow;
                    Settings1.Default.Save();
                }

                else if (color == 10)
                {
                    Settings1.Default.color1 = Color.Green;
                    Settings1.Default.color2 = Color.Yellow;
                    Settings1.Default.color3 = Color.Red;
                    Settings1.Default.color4 = Color.Blue;
                    Settings1.Default.Save();
                }

                else if (color == 11)
                {
                    Settings1.Default.color1 = Color.Yellow;
                    Settings1.Default.color2 = Color.Blue;
                    Settings1.Default.color3 = Color.Green;
                    Settings1.Default.color4 = Color.Red;
                    Settings1.Default.Save();
                }


                else if (color == 12)
                {
                    Settings1.Default.color1 = Color.Yellow;
                    Settings1.Default.color2 = Color.Red;
                    Settings1.Default.color3 = Color.Blue;
                    Settings1.Default.color4 = Color.Green;
                    Settings1.Default.Save();
                }

                else if (color == 13)
                {
                    Settings1.Default.color1 = Color.Red;
                    Settings1.Default.color2 = Color.Green;
                    Settings1.Default.color3 = Color.Yellow;
                    Settings1.Default.color4 = Color.Blue;
                    Settings1.Default.Save();
                }
                else if (color == 14)
                {
                    Settings1.Default.color1 = Color.Green;
                    Settings1.Default.color2 = Color.Yellow;
                    Settings1.Default.color3 = Color.Red;
                    Settings1.Default.color4 = Color.Blue;
                    Settings1.Default.Save();
                }
                else if (color == 15)
                {
                    Settings1.Default.color1 = Color.Red;
                    Settings1.Default.color2 = Color.Blue;
                    Settings1.Default.color3 = Color.Green;
                    Settings1.Default.color4 = Color.Yellow;
                    Settings1.Default.Save();
                }

                else if (color == 16)
                {
                    Settings1.Default.color1 = Color.Green;
                    Settings1.Default.color2 = Color.Blue;
                    Settings1.Default.color3 = Color.Red;
                    Settings1.Default.color4 = Color.Yellow;
                    Settings1.Default.Save();
                }
                else if (color == 17)
                {
                    Settings1.Default.color1 = Color.Red;
                    Settings1.Default.color2 = Color.Blue;
                    Settings1.Default.color3 = Color.Green;
                    Settings1.Default.color4 = Color.Yellow;
                    Settings1.Default.Save();
                }

                else if (color == 18)
                {
                    Settings1.Default.color1 = Color.Green;
                    Settings1.Default.color2 = Color.Blue;
                    Settings1.Default.color3 = Color.Red;
                    Settings1.Default.color4 = Color.Yellow;
                    Settings1.Default.Save();
                }
                else if (color == 19)
                {
                    Settings1.Default.color1 = Color.Red;
                    Settings1.Default.color2 = Color.Blue;
                    Settings1.Default.color3 = Color.Yellow;
                    Settings1.Default.color4 = Color.Green;
                    Settings1.Default.Save();
                }
                else if (color == 20)
                {
                    Settings1.Default.color1 = Color.Yellow;
                    Settings1.Default.color2 = Color.Red;
                    Settings1.Default.color3 = Color.Green;
                    Settings1.Default.color4 = Color.Blue;
                    Settings1.Default.Save();
                }

                else if (color == 21)
                {
                    Settings1.Default.color1 = Color.Red;
                    Settings1.Default.color2 = Color.Yellow;
                    Settings1.Default.color3 = Color.Green;
                    Settings1.Default.color4 = Color.Blue;
                    Settings1.Default.Save();
                }
            }
            else if (checkbox_plus.Checked && checkbox_minus.Checked == false && checkbox_impact.Checked && checkbox_compartment.Checked)
            {
                if (btn_color1.Visible == false || btn_color3.Visible == false || btn_color4.Visible == false)
                {
                    btn_color1.Show();
                    btn_color3.Show();
                    btn_color4.Show();
                }
                btn_color2.Visible = false;
                btn_color1.Location = new Point(50, 45);
                btn_color3.Location = new Point(btn_color1.Location.X + 60, 45);
                btn_color4.Location = new Point(btn_color3.Location.X + 60, 45);

                int color = rnd.Next(1, 22);
                if (color == 1)
                {
                    Settings1.Default.color1 = Color.Green;
                    Settings1.Default.color2 = Color.Yellow;
                    Settings1.Default.color3 = Color.Blue;
                    Settings1.Default.color4 = Color.Red;
                    Settings1.Default.Save();
                }
                else if (color == 2)
                {
                    Settings1.Default.color1 = Color.Red;
                    Settings1.Default.color2 = Color.Yellow;
                    Settings1.Default.color3 = Color.Blue;
                    Settings1.Default.color4 = Color.Green;
                    Settings1.Default.Save();
                }

                else if (color == 3)
                {
                    Settings1.Default.color1 = Color.Yellow;
                    Settings1.Default.color2 = Color.Green;
                    Settings1.Default.color3 = Color.Red;
                    Settings1.Default.color4 = Color.Blue;
                    Settings1.Default.Save();
                }
                else if (color == 4)
                {
                    Settings1.Default.color1 = Color.Red;
                    Settings1.Default.color2 = Color.Yellow;
                    Settings1.Default.color3 = Color.Blue;
                    Settings1.Default.color4 = Color.Green;
                    Settings1.Default.Save();
                }
                else if (color == 5)
                {
                    Settings1.Default.color1 = Color.Blue;
                    Settings1.Default.color2 = Color.Green;
                    Settings1.Default.color3 = Color.Yellow;
                    Settings1.Default.color4 = Color.Red;
                    Settings1.Default.Save();
                }

                else if (color == 6)
                {
                    Settings1.Default.color1 = Color.Green;
                    Settings1.Default.color2 = Color.Blue;
                    Settings1.Default.color3 = Color.Yellow;
                    Settings1.Default.color4 = Color.Red;
                    Settings1.Default.Save();
                }
                else if (color == 7)
                {
                    Settings1.Default.color1 = Color.Red;
                    Settings1.Default.color2 = Color.Green;
                    Settings1.Default.color3 = Color.Yellow;
                    Settings1.Default.color4 = Color.Blue;
                    Settings1.Default.Save();
                }
                else if (color == 8)
                {
                    Settings1.Default.color1 = Color.Green;
                    Settings1.Default.color2 = Color.Red;
                    Settings1.Default.color3 = Color.Yellow;
                    Settings1.Default.color4 = Color.Blue;
                    Settings1.Default.Save();
                }

                else if (color == 9)
                {
                    Settings1.Default.color1 = Color.Red;
                    Settings1.Default.color2 = Color.Green;
                    Settings1.Default.color3 = Color.Blue;
                    Settings1.Default.color4 = Color.Yellow;
                    Settings1.Default.Save();
                }

                else if (color == 10)
                {
                    Settings1.Default.color1 = Color.Green;
                    Settings1.Default.color2 = Color.Yellow;
                    Settings1.Default.color3 = Color.Red;
                    Settings1.Default.color4 = Color.Blue;
                    Settings1.Default.Save();
                }

                else if (color == 11)
                {
                    Settings1.Default.color1 = Color.Yellow;
                    Settings1.Default.color2 = Color.Blue;
                    Settings1.Default.color3 = Color.Green;
                    Settings1.Default.color4 = Color.Red;
                    Settings1.Default.Save();
                }


                else if (color == 12)
                {
                    Settings1.Default.color1 = Color.Yellow;
                    Settings1.Default.color2 = Color.Red;
                    Settings1.Default.color3 = Color.Blue;
                    Settings1.Default.color4 = Color.Green;
                    Settings1.Default.Save();
                }

                else if (color == 13)
                {
                    Settings1.Default.color1 = Color.Red;
                    Settings1.Default.color2 = Color.Green;
                    Settings1.Default.color3 = Color.Yellow;
                    Settings1.Default.color4 = Color.Blue;
                    Settings1.Default.Save();
                }
                else if (color == 14)
                {
                    Settings1.Default.color1 = Color.Green;
                    Settings1.Default.color2 = Color.Yellow;
                    Settings1.Default.color3 = Color.Red;
                    Settings1.Default.color4 = Color.Blue;
                    Settings1.Default.Save();
                }
                else if (color == 15)
                {
                    Settings1.Default.color1 = Color.Red;
                    Settings1.Default.color2 = Color.Blue;
                    Settings1.Default.color3 = Color.Green;
                    Settings1.Default.color4 = Color.Yellow;
                    Settings1.Default.Save();
                }

                else if (color == 16)
                {
                    Settings1.Default.color1 = Color.Green;
                    Settings1.Default.color2 = Color.Blue;
                    Settings1.Default.color3 = Color.Red;
                    Settings1.Default.color4 = Color.Yellow;
                    Settings1.Default.Save();
                }
                else if (color == 17)
                {
                    Settings1.Default.color1 = Color.Red;
                    Settings1.Default.color2 = Color.Blue;
                    Settings1.Default.color3 = Color.Green;
                    Settings1.Default.color4 = Color.Yellow;
                    Settings1.Default.Save();
                }

                else if (color == 18)
                {
                    Settings1.Default.color1 = Color.Green;
                    Settings1.Default.color2 = Color.Blue;
                    Settings1.Default.color3 = Color.Red;
                    Settings1.Default.color4 = Color.Yellow;
                    Settings1.Default.Save();
                }
                else if (color == 19)
                {
                    Settings1.Default.color1 = Color.Red;
                    Settings1.Default.color2 = Color.Blue;
                    Settings1.Default.color3 = Color.Yellow;
                    Settings1.Default.color4 = Color.Green;
                    Settings1.Default.Save();
                }
                else if (color == 20)
                {
                    Settings1.Default.color1 = Color.Yellow;
                    Settings1.Default.color2 = Color.Red;
                    Settings1.Default.color3 = Color.Green;
                    Settings1.Default.color4 = Color.Blue;
                    Settings1.Default.Save();
                }

                else if (color == 21)
                {
                    Settings1.Default.color1 = Color.Red;
                    Settings1.Default.color2 = Color.Yellow;
                    Settings1.Default.color3 = Color.Green;
                    Settings1.Default.color4 = Color.Blue;
                    Settings1.Default.Save();
                }
            }
            else if (checkbox_plus.Checked && checkbox_minus.Checked && checkbox_impact.Checked == false && checkbox_compartment.Checked)
            {
                if (btn_color1.Visible == false || btn_color2.Visible == false || btn_color4.Visible == false)
                {
                    btn_color1.Show();
                    btn_color2.Show();
                    btn_color4.Show();
                }
                btn_color3.Visible = false;
                btn_color1.Location = new Point(50, 45);
                btn_color2.Location = new Point(btn_color1.Location.X + 60, 45);
                btn_color4.Location = new Point(btn_color2.Location.X + 60, 45);

                int color = rnd.Next(1, 22);
                if (color == 1)
                {
                    Settings1.Default.color1 = Color.Green;
                    Settings1.Default.color2 = Color.Yellow;
                    Settings1.Default.color3 = Color.Blue;
                    Settings1.Default.color4 = Color.Red;
                    Settings1.Default.Save();
                }
                else if (color == 2)
                {
                    Settings1.Default.color1 = Color.Red;
                    Settings1.Default.color2 = Color.Yellow;
                    Settings1.Default.color3 = Color.Blue;
                    Settings1.Default.color4 = Color.Green;
                    Settings1.Default.Save();
                }

                else if (color == 3)
                {
                    Settings1.Default.color1 = Color.Yellow;
                    Settings1.Default.color2 = Color.Green;
                    Settings1.Default.color3 = Color.Red;
                    Settings1.Default.color4 = Color.Blue;
                    Settings1.Default.Save();
                }
                else if (color == 4)
                {
                    Settings1.Default.color1 = Color.Red;
                    Settings1.Default.color2 = Color.Yellow;
                    Settings1.Default.color3 = Color.Blue;
                    Settings1.Default.color4 = Color.Green;
                    Settings1.Default.Save();
                }
                else if (color == 5)
                {
                    Settings1.Default.color1 = Color.Blue;
                    Settings1.Default.color2 = Color.Green;
                    Settings1.Default.color3 = Color.Yellow;
                    Settings1.Default.color4 = Color.Red;
                    Settings1.Default.Save();
                }

                else if (color == 6)
                {
                    Settings1.Default.color1 = Color.Green;
                    Settings1.Default.color2 = Color.Blue;
                    Settings1.Default.color3 = Color.Yellow;
                    Settings1.Default.color4 = Color.Red;
                    Settings1.Default.Save();
                }
                else if (color == 7)
                {
                    Settings1.Default.color1 = Color.Red;
                    Settings1.Default.color2 = Color.Green;
                    Settings1.Default.color3 = Color.Yellow;
                    Settings1.Default.color4 = Color.Blue;
                    Settings1.Default.Save();
                }
                else if (color == 8)
                {
                    Settings1.Default.color1 = Color.Green;
                    Settings1.Default.color2 = Color.Red;
                    Settings1.Default.color3 = Color.Yellow;
                    Settings1.Default.color4 = Color.Blue;
                    Settings1.Default.Save();
                }

                else if (color == 9)
                {
                    Settings1.Default.color1 = Color.Red;
                    Settings1.Default.color2 = Color.Green;
                    Settings1.Default.color3 = Color.Blue;
                    Settings1.Default.color4 = Color.Yellow;
                    Settings1.Default.Save();
                }

                else if (color == 10)
                {
                    Settings1.Default.color1 = Color.Green;
                    Settings1.Default.color2 = Color.Yellow;
                    Settings1.Default.color3 = Color.Red;
                    Settings1.Default.color4 = Color.Blue;
                    Settings1.Default.Save();
                }

                else if (color == 11)
                {
                    Settings1.Default.color1 = Color.Yellow;
                    Settings1.Default.color2 = Color.Blue;
                    Settings1.Default.color3 = Color.Green;
                    Settings1.Default.color4 = Color.Red;
                    Settings1.Default.Save();
                }


                else if (color == 12)
                {
                    Settings1.Default.color1 = Color.Yellow;
                    Settings1.Default.color2 = Color.Red;
                    Settings1.Default.color3 = Color.Blue;
                    Settings1.Default.color4 = Color.Green;
                    Settings1.Default.Save();
                }

                else if (color == 13)
                {
                    Settings1.Default.color1 = Color.Red;
                    Settings1.Default.color2 = Color.Green;
                    Settings1.Default.color3 = Color.Yellow;
                    Settings1.Default.color4 = Color.Blue;
                    Settings1.Default.Save();
                }
                else if (color == 14)
                {
                    Settings1.Default.color1 = Color.Green;
                    Settings1.Default.color2 = Color.Yellow;
                    Settings1.Default.color3 = Color.Red;
                    Settings1.Default.color4 = Color.Blue;
                    Settings1.Default.Save();
                }
                else if (color == 15)
                {
                    Settings1.Default.color1 = Color.Red;
                    Settings1.Default.color2 = Color.Blue;
                    Settings1.Default.color3 = Color.Green;
                    Settings1.Default.color4 = Color.Yellow;
                    Settings1.Default.Save();
                }

                else if (color == 16)
                {
                    Settings1.Default.color1 = Color.Green;
                    Settings1.Default.color2 = Color.Blue;
                    Settings1.Default.color3 = Color.Red;
                    Settings1.Default.color4 = Color.Yellow;
                    Settings1.Default.Save();
                }
                else if (color == 17)
                {
                    Settings1.Default.color1 = Color.Red;
                    Settings1.Default.color2 = Color.Blue;
                    Settings1.Default.color3 = Color.Green;
                    Settings1.Default.color4 = Color.Yellow;
                    Settings1.Default.Save();
                }

                else if (color == 18)
                {
                    Settings1.Default.color1 = Color.Green;
                    Settings1.Default.color2 = Color.Blue;
                    Settings1.Default.color3 = Color.Red;
                    Settings1.Default.color4 = Color.Yellow;
                    Settings1.Default.Save();
                }
                else if (color == 19)
                {
                    Settings1.Default.color1 = Color.Red;
                    Settings1.Default.color2 = Color.Blue;
                    Settings1.Default.color3 = Color.Yellow;
                    Settings1.Default.color4 = Color.Green;
                    Settings1.Default.Save();
                }
                else if (color == 20)
                {
                    Settings1.Default.color1 = Color.Yellow;
                    Settings1.Default.color2 = Color.Red;
                    Settings1.Default.color3 = Color.Green;
                    Settings1.Default.color4 = Color.Blue;
                    Settings1.Default.Save();
                }

                else if (color == 21)
                {
                    Settings1.Default.color1 = Color.Red;
                    Settings1.Default.color2 = Color.Yellow;
                    Settings1.Default.color3 = Color.Green;
                    Settings1.Default.color4 = Color.Blue;
                    Settings1.Default.Save();
                }
            }

            btn_color1.BaseColor = Settings1.Default.color1;
            btn_color1.OnHoverBaseColor = Settings1.Default.color1;
            btn_color2.BaseColor = Settings1.Default.color2;
            btn_color2.OnHoverBaseColor = Settings1.Default.color2;
            btn_color3.BaseColor = Settings1.Default.color3;
            btn_color3.OnHoverBaseColor = Settings1.Default.color3;
            btn_color4.BaseColor = Settings1.Default.color4;
            btn_color4.OnHoverBaseColor = Settings1.Default.color4;
        }


        public void randomNumberMustAssignTask()
        {
            randomNumberGenerator();

            processNumber();
            switch (processnumber)
            {
                case 1:
                    {
                        rndoperators = rndmath.Next(1, 5);

                        if (rndoperators == 1)
                            lbl_mustassignoperator.ForeColor = Settings1.Default.color1;


                        else if (rndoperators == 2)
                            lbl_mustassignoperator.ForeColor = Settings1.Default.color2;


                        else if (rndoperators == 3)
                            lbl_mustassignoperator.ForeColor = Settings1.Default.color3;

                        else if (rndoperators == 4)
                            lbl_mustassignoperator.ForeColor = Settings1.Default.color4;


                        if (rndoperators == 4)
                        {
                            if (number1 < number2)
                            {
                                if (number2 % number1 == 0)
                                {
                                    lbl_mustassignnumber1.Text = number2.ToString();
                                    lbl_mustassignnumber2.Text = number1.ToString();
                                }

                                else
                                {
                                    lbl_mustassignnumber1.Text = number2.ToString();
                                    lbl_mustassignnumber2.Text = number2.ToString();
                                }

                            }

                            else
                            {

                                if (number1 % number2 == 0)
                                {
                                    lbl_mustassignnumber1.Text = number1.ToString();
                                    lbl_mustassignnumber2.Text = number2.ToString();
                                }

                                else
                                {

                                    lbl_mustassignnumber1.Text = number1.ToString();
                                    lbl_mustassignnumber2.Text = number1.ToString();
                                }

                            }
                        }
                        else if (number1 < number2)
                        {
                            lbl_mustassignnumber1.Text = number2.ToString();
                            lbl_mustassignnumber2.Text = number1.ToString();
                        }

                        else
                        {
                            lbl_mustassignnumber1.Text = number1.ToString();
                            lbl_mustassignnumber2.Text = number2.ToString();
                        }
                            

                        break;
                    }
                case 2:
                    {
                        rndoperators = rndmath.Next(1, 3);

                        if (rndoperators == 1)
                            lbl_mustassignoperator.ForeColor = Settings1.Default.color1;


                        else if (rndoperators == 2)
                            lbl_mustassignoperator.ForeColor = Settings1.Default.color2;



                        if (number1 < number2)
                        {
                            lbl_mustassignnumber1.Text = number2.ToString();
                            lbl_mustassignnumber2.Text = number1.ToString();

                        }

                        else
                        {
                            lbl_mustassignnumber1.Text = number1.ToString();
                            lbl_mustassignnumber2.Text = number2.ToString();
                        }
                        break;
                    }
                case 3:
                    {
                        rndoperators = rndmath.Next(1, 4);

                        if (rndoperators == 1)
                            lbl_mustassignoperator.ForeColor = Settings1.Default.color1;

                        else if (rndoperators == 2)
                            lbl_mustassignoperator.ForeColor = Settings1.Default.color2;

                        else if (rndoperators == 3)
                            lbl_mustassignoperator.ForeColor = Settings1.Default.color3;

                        if (number1 < number2)
                        {
                            lbl_mustassignnumber1.Text = number2.ToString();
                            lbl_mustassignnumber2.Text = number1.ToString();
                        }

                        else
                        {
                            lbl_mustassignnumber1.Text = number1.ToString();
                            lbl_mustassignnumber2.Text = number2.ToString();
                        }

                        break;
                    }
                case 4:
                    {
                        lbl_mustassignoperator.ForeColor = Settings1.Default.color1;

                        if (number1 < number2)
                        {
                            lbl_mustassignnumber1.Text = number2.ToString();
                            lbl_mustassignnumber2.Text = number1.ToString();
                        }

                        else
                        {
                            lbl_mustassignnumber1.Text = number1.ToString();
                            lbl_mustassignnumber2.Text = number2.ToString();
                        }

                        break;
                    }
                case 5:
                    {
                        lbl_mustassignoperator.ForeColor = Settings1.Default.color2;

                        if (number1 < number2)
                        {
                            lbl_mustassignnumber1.Text = number2.ToString();
                            lbl_mustassignnumber2.Text = number1.ToString();
                        }

                        else
                        {
                            lbl_mustassignnumber1.Text = number1.ToString();
                            lbl_mustassignnumber2.Text = number2.ToString();
                        }

                        break;
                    }
                case 6:
                    {
                        lbl_mustassignoperator.ForeColor = Settings1.Default.color3;

                        if (number1 < number2)
                        {
                            lbl_mustassignnumber1.Text = number2.ToString();
                            lbl_mustassignnumber2.Text = number1.ToString();
                        }

                        else
                        {
                            lbl_mustassignnumber1.Text = number1.ToString();
                            lbl_mustassignnumber2.Text = number2.ToString();
                        }
                        break;
                    }
                case 7:
                    {
                        lbl_mustassignoperator.ForeColor = Settings1.Default.color4;

                        
                            if (number1 < number2)
                            {
                                if (number2 % number1 == 0)
                                {
                                    lbl_mustassignnumber1.Text = number2.ToString();
                                    lbl_mustassignnumber2.Text = number1.ToString();
                                }

                                else
                                {
                                    lbl_mustassignnumber1.Text = number2.ToString();
                                    lbl_mustassignnumber2.Text = number2.ToString();
                                }

                            }

                            else
                            {

                                if (number1 % number2 == 0)
                                {
                                    lbl_mustassignnumber1.Text = number1.ToString();
                                    lbl_mustassignnumber2.Text = number2.ToString();
                                }

                                else
                                {

                                    lbl_mustassignnumber1.Text = number1.ToString();
                                    lbl_mustassignnumber2.Text = number1.ToString();
                                }

                            }
                        
                      
                        break;
                    }

                case 8:
                    {
                        rndoperators = rndmath.Next(1, 3);

                        if (rndoperators == 1)
                            lbl_mustassignoperator.ForeColor = Settings1.Default.color2;

                        else if (rndoperators == 2)
                            lbl_mustassignoperator.ForeColor = Settings1.Default.color3;


                        if (number1 < number2)
                        {
                            lbl_mustassignnumber1.Text = number2.ToString();
                            lbl_mustassignnumber2.Text = number1.ToString();
                        }

                        else
                        {
                            lbl_mustassignnumber1.Text = number1.ToString();
                            lbl_mustassignnumber2.Text = number2.ToString();
                        }

                        break;
                    }
                case 9:
                    {
                        rndoperators = rndmath.Next(1, 3);

                        if (rndoperators == 1)
                            lbl_mustassignoperator.ForeColor = Settings1.Default.color1;

                        else if (rndoperators == 2)
                            lbl_mustassignoperator.ForeColor = Settings1.Default.color3;


                        if (number1 < number2)
                        {
                            lbl_mustassignnumber1.Text = number2.ToString();
                            lbl_mustassignnumber2.Text = number1.ToString();
                        }

                        else
                        {
                            lbl_mustassignnumber1.Text = number1.ToString();
                            lbl_mustassignnumber2.Text = number2.ToString();
                        }
                        break;
                    }
                case 10:
                    {
                        rndoperators = rndmath.Next(1, 3);

                        if (rndoperators == 1)
                            lbl_mustassignoperator.ForeColor = Settings1.Default.color1;

                        else if (rndoperators == 2)
                            lbl_mustassignoperator.ForeColor = Settings1.Default.color4;

                        if (rndoperators == 2)
                        {
                            if (number1 < number2)
                            {
                                if (number2 % number1 == 0)
                                {
                                    lbl_mustassignnumber1.Text = number2.ToString();
                                    lbl_mustassignnumber2.Text = number1.ToString();
                                }

                                else
                                {
                                    lbl_mustassignnumber1.Text = number2.ToString();
                                    lbl_mustassignnumber2.Text = number2.ToString();
                                }

                            }

                            else
                            {

                                if (number1 % number2 == 0)
                                {
                                    lbl_mustassignnumber1.Text = number1.ToString();
                                    lbl_mustassignnumber2.Text = number2.ToString();
                                }

                                else
                                {

                                    lbl_mustassignnumber1.Text = number1.ToString();
                                    lbl_mustassignnumber2.Text = number1.ToString();
                                }

                            }
                        }
                        else if (number1 < number2)
                        {
                            lbl_mustassignnumber1.Text = number2.ToString();
                            lbl_mustassignnumber2.Text = number1.ToString();
                        }

                        else
                        {
                            lbl_mustassignnumber1.Text = number1.ToString();
                            lbl_mustassignnumber2.Text = number2.ToString();
                        }

                       
                        break;
                    }
                case 11:
                    {
                        rndoperators = rndmath.Next(1, 3);

                        if (rndoperators == 1)
                            lbl_mustassignoperator.ForeColor = Settings1.Default.color3;

                        else if (rndoperators == 2)
                            lbl_mustassignoperator.ForeColor = Settings1.Default.color4;


                        if (rndoperators == 2)
                        {
                            if (number1 < number2)
                            {
                                if (number2 % number1 == 0)
                                {
                                    lbl_mustassignnumber1.Text = number2.ToString();
                                    lbl_mustassignnumber2.Text = number1.ToString();
                                }

                                else
                                {
                                    lbl_mustassignnumber1.Text = number2.ToString();
                                    lbl_mustassignnumber2.Text = number2.ToString();
                                }

                            }

                            else
                            {

                                if (number1 % number2 == 0)
                                {
                                    lbl_mustassignnumber1.Text = number1.ToString();
                                    lbl_mustassignnumber2.Text = number2.ToString();
                                }

                                else
                                {

                                    lbl_mustassignnumber1.Text = number1.ToString();
                                    lbl_mustassignnumber2.Text = number1.ToString();
                                }

                            }
                        }
                        else if (number1 < number2)
                        {
                            lbl_mustassignnumber1.Text = number2.ToString();
                            lbl_mustassignnumber2.Text = number1.ToString();
                        }

                        else
                        {
                            lbl_mustassignnumber1.Text = number1.ToString();
                            lbl_mustassignnumber2.Text = number2.ToString();
                        }


                        break;
                    }
                case 12:
                    {
                        rndoperators = rndmath.Next(1, 3);

                        if (rndoperators == 1)
                            lbl_mustassignoperator.ForeColor = Settings1.Default.color2;

                        else if (rndoperators == 2)
                            lbl_mustassignoperator.ForeColor = Settings1.Default.color4;


                        if (rndoperators == 2)
                        {
                            if (number1 < number2)
                            {
                                if (number2 % number1 == 0)
                                {
                                    lbl_mustassignnumber1.Text = number2.ToString();
                                    lbl_mustassignnumber2.Text = number1.ToString();
                                }

                                else
                                {
                                    lbl_mustassignnumber1.Text = number2.ToString();
                                    lbl_mustassignnumber2.Text = number2.ToString();
                                }

                            }

                            else
                            {

                                if (number1 % number2 == 0)
                                {
                                    lbl_mustassignnumber1.Text = number1.ToString();
                                    lbl_mustassignnumber2.Text = number2.ToString();
                                }

                                else
                                {

                                    lbl_mustassignnumber1.Text = number1.ToString();
                                    lbl_mustassignnumber2.Text = number1.ToString();
                                }

                            }
                        }
                        else if (number1 < number2)
                        {
                            lbl_mustassignnumber1.Text = number2.ToString();
                            lbl_mustassignnumber2.Text = number1.ToString();
                        }

                        else
                        {
                            lbl_mustassignnumber1.Text = number1.ToString();
                            lbl_mustassignnumber2.Text = number2.ToString();
                        }

                        break;
                    }
                case 13:
                    {
                        rndoperators = rndmath.Next(1, 4);

                        if (rndoperators == 1)
                            lbl_mustassignoperator.ForeColor = Settings1.Default.color2;

                        else if (rndoperators == 2)
                            lbl_mustassignoperator.ForeColor = Settings1.Default.color3;

                        else if (rndoperators == 3)
                            lbl_mustassignoperator.ForeColor = Settings1.Default.color4;

                        if (rndoperators == 3)
                        {
                            if (number1 < number2)
                            {
                                if (number2 % number1 == 0)
                                {
                                    lbl_mustassignnumber1.Text = number2.ToString();
                                    lbl_mustassignnumber2.Text = number1.ToString();
                                }

                                else
                                {
                                    lbl_mustassignnumber1.Text = number2.ToString();
                                    lbl_mustassignnumber2.Text = number2.ToString();
                                }

                            }

                            else
                            {

                                if (number1 % number2 == 0)
                                {
                                    lbl_mustassignnumber1.Text = number1.ToString();
                                    lbl_mustassignnumber2.Text = number2.ToString();
                                }

                                else
                                {

                                    lbl_mustassignnumber1.Text = number1.ToString();
                                    lbl_mustassignnumber2.Text = number1.ToString();
                                }

                            }
                        }
                        else if (number1 < number2)
                        {
                            lbl_mustassignnumber1.Text = number2.ToString();
                            lbl_mustassignnumber2.Text = number1.ToString();
                        }

                        else
                        {
                            lbl_mustassignnumber1.Text = number1.ToString();
                            lbl_mustassignnumber2.Text = number2.ToString();
                        }


                        break;
                    }
                case 14:
                    {
                        rndoperators = rndmath.Next(1, 4);

                        if (rndoperators == 1)
                            lbl_mustassignoperator.ForeColor = Settings1.Default.color1;

                        else if (rndoperators == 2)
                            lbl_mustassignoperator.ForeColor = Settings1.Default.color2;

                        else if (rndoperators == 3)
                            lbl_mustassignoperator.ForeColor = Settings1.Default.color4;


                        if (rndoperators == 3)
                        {
                            if (number1 < number2)
                            {
                                if (number2 % number1 == 0)
                                {
                                    lbl_mustassignnumber1.Text = number2.ToString();
                                    lbl_mustassignnumber2.Text = number1.ToString();
                                }

                                else
                                {
                                    lbl_mustassignnumber1.Text = number2.ToString();
                                    lbl_mustassignnumber2.Text = number2.ToString();
                                }

                            }

                            else
                            {

                                if (number1 % number2 == 0)
                                {
                                    lbl_mustassignnumber1.Text = number1.ToString();
                                    lbl_mustassignnumber2.Text = number2.ToString();
                                }

                                else
                                {

                                    lbl_mustassignnumber1.Text = number1.ToString();
                                    lbl_mustassignnumber2.Text = number1.ToString();
                                }

                            }
                        }
                        else if (number1 < number2)
                        {
                            lbl_mustassignnumber1.Text = number2.ToString();
                            lbl_mustassignnumber2.Text = number1.ToString();
                        }

                        else
                        {
                            lbl_mustassignnumber1.Text = number1.ToString();
                            lbl_mustassignnumber2.Text = number2.ToString();
                        }

                        break;
                    }
                case 15:
                    {
                        rndoperators = rndmath.Next(1, 4);

                        if (rndoperators == 1)
                            lbl_mustassignoperator.ForeColor = Settings1.Default.color1;

                        else if (rndoperators == 2)
                            lbl_mustassignoperator.ForeColor = Settings1.Default.color3;

                        else if (rndoperators == 3)
                            lbl_mustassignoperator.ForeColor = Settings1.Default.color4;


                        if (rndoperators == 3)
                        {
                            if (number1 < number2)
                            {
                                if (number2 % number1 == 0)
                                {
                                    lbl_mustassignnumber1.Text = number2.ToString();
                                    lbl_mustassignnumber2.Text = number1.ToString();
                                }

                                else
                                {
                                    lbl_mustassignnumber1.Text = number2.ToString();
                                    lbl_mustassignnumber2.Text = number2.ToString();
                                }

                            }

                            else
                            {

                                if (number1 % number2 == 0)
                                {
                                    lbl_mustassignnumber1.Text = number1.ToString();
                                    lbl_mustassignnumber2.Text = number2.ToString();
                                }

                                else
                                {

                                    lbl_mustassignnumber1.Text = number1.ToString();
                                    lbl_mustassignnumber2.Text = number1.ToString();
                                }

                            }
                        }
                        else if (number1 < number2)
                        {
                            lbl_mustassignnumber1.Text = number2.ToString();
                            lbl_mustassignnumber2.Text = number1.ToString();
                        }

                        else
                        {
                            lbl_mustassignnumber1.Text = number1.ToString();
                            lbl_mustassignnumber2.Text = number2.ToString();
                        }

                        break;
                    }
            }


        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            
             
            if(checkbox_plus.Checked == false && checkbox_minus.Checked == false && checkbox_impact.Checked == false && checkbox_compartment.Checked == false || int.Parse(txt_numerictime.Text) == 0 || int.Parse(txt_numericscreentime.Text) == 0  || int.Parse(txt_numericrange2.Text) < int.Parse(txt_numericrange1.Text) || int.Parse(txt_numericrange2.Text) == int.Parse(txt_numericrange1.Text))
            {
                DialogResult dresult = new DialogResult();
                dresult = MessageBox.Show("Lütfen ayarları doğru şekilde yapınız", "Uyarı", MessageBoxButtons.OK);
                btn_stop.Visible = false;
                btn_start.Visible = true;
                lbl_screentime.Focus();
            }

            
           else if (checkbox_mustasigntask.Checked==true)
            {
                if (int.Parse(txt_numericrange2.Text) < int.Parse(txt_numericrange1.Text) || int.Parse(txt_numericrange2.Text) == int.Parse(txt_numericrange1.Text))
                {
                    DialogResult dresult = new DialogResult();
                    dresult = MessageBox.Show("Lütfen ayarları doğru şekilde yapınız", "Uyarı", MessageBoxButtons.OK);
                }

                else
                {
                    randomColor();
                    panel_colortable.Visible = true;
                    processStarted = 1;
                }
              
            }

            else if (checkbox_gostergizle.Checked == true)
            {
                if(int.Parse(txt_numericrange2.Text) < int.Parse(txt_numericrange1.Text) || int.Parse(txt_numericrange2.Text) == int.Parse(txt_numericrange1.Text))
                {
                    DialogResult dresult = new DialogResult();
                    dresult = MessageBox.Show("Lütfen ayarları doğru şekilde yapınız", "Uyarı", MessageBoxButtons.OK);
                }
                else
                {
                    randomNumber();
                    timer_time.Interval = int.Parse(txt_numerictime.Text) * 1000;
                    timer_screentime.Interval = int.Parse(txt_numericscreentime.Text);
                    timer_hidetime.Interval = int.Parse(txt_numericscreentime.Text);
                    timer_time.Start();
                    timer_hidetime.Start();
                    lbl_process.Visible = true;
                    btn_start.Visible = false;
                    btn_stop.Visible = true;
                    processStarted = 1;
                }
              
            }

            else
            {
               
                    randomNumber();
                    timer_time.Interval = int.Parse(txt_numerictime.Text) * 1000;
                    timer_screentime.Interval = int.Parse(txt_numericscreentime.Text);
                    timer_time.Start();
                    timer_screentime.Start();
                    lbl_process.Visible = true;
                    btn_start.Visible = false;
                    btn_stop.Visible = true;
                

            }

           

          
                
        }

        private void timer_time_Tick(object sender, EventArgs e)
        {
            timer_time.Stop();
            timer_screentime.Stop();
            timer_hidetime.Stop();
            checkbox_plus.Checked = false;
            checkbox_minus.Checked = false;
            checkbox_impact.Checked = false;
            checkbox_compartment.Checked = false;
          
            lbl_process.Visible = false;
            panel_mustasigntask.Visible = false;
            btn_stop.Visible = false;
            btn_start.Visible = true;
            processStarted = 0;
        }

        private void timer_screentime_Tick(object sender, EventArgs e)
        {

            if(checkbox_gostergizle.Checked == true)
            {

               if (checkbox_plus.Checked == true || checkbox_minus.Checked == true || checkbox_impact.Checked == true || checkbox_compartment.Checked == true)
                {

                    if (checkbox_mustasigntask.Checked == true)
                    {

                        panel_mustasigntask.Visible = true;
                        randomNumberMustAssignTask();
                        timer_screentime.Stop();
                        timer_hidetime.Start();
                    }

                    else
                    {
                        lbl_process.Visible = true;
                        randomNumber();

                        timer_screentime.Stop();
                        timer_hidetime.Start();
                    }
                  
                }

                
                
            }


            else if (checkbox_plus.Checked == true || checkbox_minus.Checked == true || checkbox_impact.Checked == true || checkbox_compartment.Checked == true)
            {

                if (checkbox_mustasigntask.Checked == true)
                {
                    randomNumberMustAssignTask();
                    panel_mustasigntask.Visible = true;
                }

                else
                {
                    randomNumber();
                    lbl_process.Visible = true;
                }
                
            }


           
            
            
        }

        private void ConstantAttention_Load(object sender, EventArgs e)
        {
            musicArray[0] = @"https://enesbilgi.com/audio/1.mp3";
            musicArray[1] = @"https://enesbilgi.com/audio/2.mp3";
            musicArray[2] = @"https://enesbilgi.com/audio/3.mp3";
            musicArray[3] = @"https://enesbilgi.com/audio/4.mp3";
            musicinfoArray[0] = "Legend of the Eagle Bearer";
            musicinfoArray[1] = "Season Two Main Theme";
            musicinfoArray[2] = "Azura's Coast";
            musicinfoArray[3] = "Soundtrack";
            musictitleArray[0] = "Assassin's Creed Odyssey";
            musictitleArray[1] = "The Walking Dead";
            musictitleArray[2] = "Brad Derrick";
            musictitleArray[3] = "The Witcher";
           
        }

        private void btn_colortableok_Click(object sender, EventArgs e)
        {
            panel_colortable.Visible=false;

              if (checkbox_gostergizle.Checked == true)
            {
                randomNumberMustAssignTask();
                timer_time.Interval = int.Parse(txt_numerictime.Text) * 1000;
                timer_screentime.Interval = int.Parse(txt_numericscreentime.Text);
                timer_hidetime.Interval = int.Parse(txt_numericscreentime.Text);
                timer_time.Start();
                timer_hidetime.Start();
               panel_mustasigntask.Visible=true;
                lbl_process.Visible = false;
                btn_stop.Visible = true;
                btn_start.Visible = false;

            }

            else
            {
                randomNumberMustAssignTask();
                timer_time.Interval = int.Parse(txt_numerictime.Text) * 1000;
                timer_screentime.Interval = int.Parse(txt_numericscreentime.Text);
                timer_time.Start();
                timer_screentime.Start();
                panel_mustasigntask.Visible = true;
                lbl_process.Visible = false;
                btn_stop.Visible = true;
                btn_start.Visible = false;


            }


           
        }

        private void timer_hidetime_Tick(object sender, EventArgs e)
        {
            lbl_process.Visible = false;
            panel_mustasigntask.Visible = false;
            timer_screentime.Start();
            timer_hidetime.Stop();
        }

        private void btn_play_Click(object sender, EventArgs e)
        {
            
            if (musicStarted == false)
            {
               // lbl_currentduration.Visible = true;
              //  lbl_songduration.Visible = true;
                timer_musicinfo.Interval = 50;
                timer_musicinfo.Start();
                muzikcalar.URL = musicArray[musicid];
                muzikcalar.controls.play();
                musicStarted = true;
                lbl_songtitle.Text = musictitleArray[musicid];
                lbl_songinfo.Text = musicinfoArray[musicid];
                lbl_songinfo.Location = new Point(lbl_songtitle.Location.X + lbl_songtitle.Width, 8);
                lbl_songtitle.Visible = true;
                lbl_songinfo.Visible = true;
                btn_pause.Visible = true;
              
            }

            else if(musicpaused == true)
            {
                muzikcalar.controls.play();
                btn_pause.Visible = true;
                timer_musicinfo.Start();
                
            }

            else
            {

            }
            
        }
        private void btn_pause_Click(object sender, EventArgs e)
        {
            btn_pause.Visible = false;
            btn_play.Visible = true;
            timer_musicinfo.Stop();
            muzikcalar.controls.pause();
            musicpaused = true;
        }

        private void btn_volumeon_Click(object sender, EventArgs e)
        {
            trackChanged = trackbar_volume.Value;
            trackbar_volume.Value = 0;
            btn_volumeoff.Visible = true;
            btn_volumeon.Visible = false;
            muzikcalar.settings.volume = 0;
        }

        private void btn_volumeoff_Click(object sender, EventArgs e)
        {
            btn_volumeoff.Visible = false;
            btn_volumeon.Visible = true;
            trackbar_volume.Value = trackChanged;
            muzikcalar.settings.volume = trackChanged;
        }

       

        private void btn_next_Click(object sender, EventArgs e)
        {

            if (musicStarted == false)
            {
                

            }
            else
            {
                if (musicArray.Length - 1 > musicid)
                {
                    musicid += 1;
                }
                muzikcalar.URL = musicArray[musicid];
                muzikcalar.controls.play();
                musicStarted = true;

                lbl_songtitle.Text = musictitleArray[musicid];
                lbl_songinfo.Text = musicinfoArray[musicid];
                lbl_songtitle.Location = new Point(290, 9);
                lbl_songinfo.Location = new Point(290 + lbl_songtitle.Width, 9);
                lbl_songtitle.Visible = true;
                lbl_songinfo.Visible = true;
                btn_pause.Visible = true;
            }

           
        }

        private void trackbar_volume_ValueChanged(object sender, EventArgs e)
        {
            muzikcalar.settings.volume = trackbar_volume.Value;
            if(trackbar_volume.Value != 0)
            {
                
                btn_volumeon.Visible = true;
                btn_volumeoff.Visible = false;
            }

            if (trackbar_volume.Value > 0 & trackbar_volume.Value < 35)
            {
                btn_volumeon.BackgroundImage = NeuroAttention.Properties.Resources.icons8_voicelow_100;
            }
            else if (trackbar_volume.Value > 35)
            {
                btn_volumeon.BackgroundImage = NeuroAttention.Properties.Resources.icons8_voice_100;
            }
            else
            {
                btn_volumeon.Visible = false;
                btn_volumeoff.Visible = true;
            }
        }

        private void btn_previous_Click(object sender, EventArgs e)
        {
            if (musicStarted == false)
            {
                
            }

            else
            {
                if (musicArray.Length - musicArray.Length < musicid)
                {
                    musicid -= 1;
                }
                muzikcalar.URL = musicArray[musicid];
                muzikcalar.controls.play();
                musicStarted = true;
                timer_musicinfo.Start();
                lbl_songtitle.Text = musictitleArray[musicid];
                lbl_songinfo.Text = musicinfoArray[musicid];
                lbl_songtitle.Location = new Point(290, 9);
                lbl_songinfo.Location = new Point(290 + lbl_songtitle.Width, 9);
                lbl_songtitle.Visible = true;
                lbl_songinfo.Visible = true;
                btn_pause.Visible = true;
            }

           
        }

        private void timer_musicinfo_Tick(object sender, EventArgs e)
        {
          
            lbl_songtitle.Location = new Point(lbl_songtitle.Location.X - 2, 9);
            lbl_songinfo.Location = new Point(lbl_songinfo.Location.X - 2, 9);
            if (lbl_songtitle.Location.X < -lbl_songtitle.Width)
            {
                lbl_songtitle.Location = new Point(250, 20);
            }
            if (lbl_songinfo.Location.X < -lbl_songinfo.Width)
            {
                lbl_songinfo.Location = new Point(lbl_songtitle.Location.X + lbl_songtitle.Width, 20);
            }
        }

        private void timer_playlist_Tick(object sender, EventArgs e)
        {
            

            if(gunaPanel_bottom.Height != 320)
            {
                gunaPanel_bottom.Location = new Point(gunaPanel_bottom.Location.X, gunaPanel_bottom.Location.Y - 10);
                gunaPanel_bottom.Height += 10;
                gunaPanel_playlistinfo.Location = new Point(gunaPanel_playlistinfo.Location.X, gunaPanel_playlistinfo.Location.Y - 5);
             
            }
            else
            {
                playlistmode = 1;
                timer_playlist.Stop();
            }
            
        }

        private void timer_playlistreverse_Tick(object sender, EventArgs e)
        {
            if (gunaPanel_bottom.Height != 130)
            {
                gunaPanel_bottom.Location = new Point(gunaPanel_bottom.Location.X, gunaPanel_bottom.Location.Y + 10);
                gunaPanel_bottom.Height -= 10;
                gunaPanel_playlistinfo.Location = new Point(gunaPanel_playlistinfo.Location.X, gunaPanel_playlistinfo.Location.Y + 5);

            }
            else
            {
                playlistmode = 0;
                timer_playlistreverse.Stop();
            }
        }

        private void btn_numerictimeupdown_MouseDown(object sender, MouseEventArgs e)
        {
            int numericsayi;
            switch (MouseButtons)
            {
                case MouseButtons.Right:
                    if(txt_numerictime.Text != "")
                    {
                        numericsayi = int.Parse(txt_numerictime.Text);
                        if (numericsayi != 0)
                        {
                            numericsayi -= 1;
                        }
                        txt_numerictime.Text = numericsayi.ToString();

                    }
                    break;

                case MouseButtons.Left:
                    if(txt_numerictime.Text != "")
                    {
                        numericsayi = int.Parse(txt_numerictime.Text);
                        if (numericsayi >= 0)
                        {
                            numericsayi += 1;
                        }
                        txt_numerictime.Text = numericsayi.ToString();
                    }
                    break;
            }
        }

        private void txt_numerictime_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr !=8)
            {
                e.Handled = true;
              
            }
        }

        private void btn_numericrangeupdown1_MouseDown(object sender, MouseEventArgs e)
        {
            int numericsayi;
            switch (MouseButtons)
            {
                case MouseButtons.Right:
                    if (txt_numericrange1.Text != "")
                    {
                        numericsayi = int.Parse(txt_numericrange1.Text);
                        if (numericsayi != 0)
                        {
                            numericsayi -= 1;
                        }
                        txt_numericrange1.Text = numericsayi.ToString();

                    }
                    break;

                case MouseButtons.Left:
                    if (txt_numericrange1.Text != "")
                    {
                        numericsayi = int.Parse(txt_numericrange1.Text);
                        if (numericsayi >= 0)
                        {
                            numericsayi += 1;
                        }
                        txt_numericrange1.Text = numericsayi.ToString();
                    }
                    break;
            }
        }

        private void txt_numericrange1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;

            }
        }

        private void btn_numericrangeupdown2_MouseDown(object sender, MouseEventArgs e)
        {
            int numericsayi;
            switch (MouseButtons)
            {
                case MouseButtons.Right:
                    if (txt_numericrange2.Text != "")
                    {
                        numericsayi = int.Parse(txt_numericrange2.Text);
                        if (numericsayi != 0)
                        {
                            numericsayi -= 1;
                        }
                        txt_numericrange2.Text = numericsayi.ToString();

                    }
                    break;

                case MouseButtons.Left:
                    if (txt_numericrange2.Text != "")
                    {
                        numericsayi = int.Parse(txt_numericrange2.Text);
                        if (numericsayi >= 0)
                        {
                            numericsayi += 1;
                        }
                        txt_numericrange2.Text = numericsayi.ToString();
                    }
                    break;
            }
        }

        private void txt_numericrange2_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;

            }
        }

        private void txt_numericscreentime_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;

            }
        }

        private void btn_numericscreentimeupdown_MouseDown(object sender, MouseEventArgs e)
        {
            int numericsayi;
            switch (MouseButtons)
            {
                case MouseButtons.Right:
                    if (txt_numericscreentime.Text != "")
                    {
                        numericsayi = int.Parse(txt_numericscreentime.Text);
                        if (numericsayi != 0)
                        {
                            numericsayi -= 1;
                        }
                        txt_numericscreentime.Text = numericsayi.ToString();

                    }
                    break;

                case MouseButtons.Left:
                    if (txt_numericscreentime.Text != "")
                    {
                        numericsayi = int.Parse(txt_numericscreentime.Text);
                        if (numericsayi >= 0)
                        {
                            numericsayi += 1;
                        }
                        txt_numericscreentime.Text = numericsayi.ToString();
                    }
                    break;
            }
        }

        private void lbl_quickaction1_Click(object sender, EventArgs e)
        {

            if(btn_stop.Visible != true)
            {
                txt_numerictime.Text = "30";
                checkbox_plus.Checked = true;
                checkbox_minus.Checked = true;
                checkbox_impact.Checked = true;
                checkbox_compartment.Checked = true;
                checkbox_mustasigntask.Checked = false;
            }
           
        }

        private void lbl_quickaction2_Click(object sender, EventArgs e)
        {

            if(btn_stop.Visible != true)
            {
                txt_numerictime.Text = "60";
                txt_numericrange2.Text = "15";
                checkbox_plus.Checked = true;
                checkbox_minus.Checked = true;
                checkbox_impact.Checked = true;
                checkbox_compartment.Checked = true;
                checkbox_mustasigntask.Checked = false;
            }
        
        }

        private void lbl_quickaction3_Click(object sender, EventArgs e)
        {
            if(btn_stop.Visible != true)
            {
                txt_numerictime.Text = "30";
                txt_numericrange2.Text = "10";
                checkbox_plus.Checked = true;
                checkbox_minus.Checked = false;
                checkbox_impact.Checked = false;
                checkbox_compartment.Checked = true;
                checkbox_mustasigntask.Checked = true;
            }
         
        }

        private void lbl_quickaction4_Click(object sender, EventArgs e)
        {
            if(btn_stop.Visible != true)
            {
                txt_numerictime.Text = "30";
                txt_numericrange2.Text = "10";
                checkbox_plus.Checked = true;
                checkbox_minus.Checked = true;
                checkbox_impact.Checked = false;
                checkbox_compartment.Checked = false;
                checkbox_mustasigntask.Checked = true;
            }
           
        }

        private void checkbox_mustasigntask_Click(object sender, EventArgs e)
        {
            if (processStarted == 0)
            {
               
            }
            else
            {

                if(checkbox_mustasigntask.Checked == true)
                {
                    checkbox_mustasigntask.Checked = false;
                }

                else
                {
                    checkbox_mustasigntask.Checked = true;
                }
                
            }
        }

        private void btn_playlist_Click(object sender, EventArgs e)
        {
            if (playlistmode == 0)
            {
                timer_playlist.Start();
            }
            else
            {
                timer_playlistreverse.Start();
            }
           
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            muzikcalar.controls.stop();
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            if (btn_start.Visible == false)
            {
                btn_stop.Visible = false;
                btn_start.Visible = true;
            }
            timer_time.Stop();
            timer_screentime.Stop();
            timer_hidetime.Stop();
            lbl_process.Visible = false;
            panel_mustasigntask.Visible = false;
            lbl_process.Text = "";
            processStarted = 0;
        }
    }
}
