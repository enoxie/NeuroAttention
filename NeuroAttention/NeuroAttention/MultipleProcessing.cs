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
    public partial class MultipleProcessing : Form
    {
        public MultipleProcessing()
        {
            InitializeComponent();
        }

        public int number1, number2, number3, number4, processnumber, rndoperators,rndoperators2;
        public int i = 1;
        public string operators;
        public string operators2;
        Random rnd = new Random();
        Random rndmath = new Random();



        public void randomColor()
        {
            if (checkbox_plus.Checked && checkbox_minus.Checked && checkbox_impact.Checked && checkbox_compartment.Checked)
            {
                if (lbl_color1.Visible == false || lbl_color3.Visible == false || lbl_color2.Visible == false || lbl_color4.Visible == false)
                {
                    lbl_color1.Location = new Point(70, 60);
                    lbl_color3.Location = new Point(160, 60);
                    lbl_color2.Location = new Point(70, 90);
                    lbl_color4.Location = new Point(160, 90);
                    lbl_color1.Visible = true;
                    lbl_color3.Visible = true;
                    lbl_color2.Visible = true;
                    lbl_color4.Visible = true;


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
                if (lbl_color1.Visible == false || lbl_color3.Visible == false || lbl_color2.Visible == false)
                {
                    lbl_color1.Show();
                    lbl_color2.Show();
                    lbl_color3.Show();
                }
                lbl_color4.Visible = false;
                lbl_color1.Location = new Point(70, 60);
                lbl_color2.Location = new Point(160, 60);
                lbl_color3.Location = new Point(70, 90);

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
                if (lbl_color1.Visible == false)
                {
                    lbl_color1.Show();
                }
                lbl_color2.Visible = false;
                lbl_color3.Visible = false;
                lbl_color4.Visible = false;
                lbl_color1.Location = new Point(70, 60);

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
                if (lbl_color3.Visible == false)
                {
                    lbl_color3.Show();
                }
                lbl_color1.Visible = false;
                lbl_color2.Visible = false;
                lbl_color4.Visible = false;
                lbl_color3.Location = new Point(110, 45);

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
                if (lbl_color2.Visible == false)
                {
                    lbl_color2.Show();
                }
                lbl_color1.Visible = false;
                lbl_color3.Visible = false;
                lbl_color4.Visible = false;
                lbl_color2.Location = new Point(110, 45);

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
                if (lbl_color4.Visible == false)
                {
                    lbl_color4.Show();
                }
                lbl_color1.Visible = false;
                lbl_color3.Visible = false;
                lbl_color2.Visible = false;
                lbl_color4.Location = new Point(110, 45);

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
                if (lbl_color1.Visible == false || lbl_color3.Visible == false)
                {
                    lbl_color1.Show();
                    lbl_color3.Show();
                }
                lbl_color2.Visible = false;
                lbl_color4.Visible = false;
                lbl_color1.Location = new Point(50, 45);
                lbl_color3.Location = new Point(lbl_color1.Location.X + 120, 45);

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
                if (lbl_color1.Visible == false || lbl_color2.Visible == false)
                {
                    lbl_color1.Show();
                    lbl_color2.Show();
                }
                lbl_color3.Visible = false;
                lbl_color4.Visible = false;
                lbl_color1.Location = new Point(50, 45);
                lbl_color2.Location = new Point(lbl_color1.Location.X + 120, 45);

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
                if (lbl_color1.Visible == false || lbl_color4.Visible == false)
                {
                    lbl_color1.Show();
                    lbl_color4.Show();
                }
                lbl_color3.Visible = false;
                lbl_color2.Visible = false;
                lbl_color1.Location = new Point(50, 45);
                lbl_color4.Location = new Point(lbl_color1.Location.X + 120, 45);

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
                if (lbl_color3.Visible == false || lbl_color2.Visible == false)
                {
                    lbl_color3.Show();
                    lbl_color2.Show();
                }
                lbl_color1.Visible = false;
                lbl_color4.Visible = false;
                lbl_color3.Location = new Point(50, 45);
                lbl_color2.Location = new Point(lbl_color1.Location.X + 120, 45);

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
                if (lbl_color3.Visible == false || lbl_color4.Visible == false)
                {
                    lbl_color3.Show();
                    lbl_color4.Show();
                }
                lbl_color1.Visible = false;
                lbl_color2.Visible = false;
                lbl_color3.Location = new Point(50, 45);
                lbl_color4.Location = new Point(lbl_color1.Location.X + 120, 45);

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
                if (lbl_color2.Visible == false || lbl_color4.Visible == false)
                {
                    lbl_color2.Show();
                    lbl_color4.Show();
                }
                lbl_color1.Visible = false;
                lbl_color3.Visible = false;
                lbl_color2.Location = new Point(50, 45);
                lbl_color4.Location = new Point(lbl_color1.Location.X + 120, 45);

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
                if (lbl_color1.Visible == false || lbl_color3.Visible == false || lbl_color2.Visible == false)
                {
                    lbl_color1.Show();
                    lbl_color3.Show();
                    lbl_color2.Show();
                }
                lbl_color4.Visible = false;
                lbl_color1.Location = new Point(50, 45);
                lbl_color3.Location = new Point(lbl_color1.Location.X + 120, 45);
                lbl_color2.Location = new Point(lbl_color3.Location.X + 120, 45);

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
                if (lbl_color3.Visible == false || lbl_color2.Visible == false || lbl_color4.Visible == false)
                {
                    lbl_color3.Show();
                    lbl_color2.Show();
                    lbl_color4.Show();
                }
                lbl_color1.Visible = false;
                lbl_color3.Location = new Point(50, 45);
                lbl_color2.Location = new Point(lbl_color3.Location.X + 60, 45);
                lbl_color4.Location = new Point(lbl_color2.Location.X + 60, 45);

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
                if (lbl_color1.Visible == false || lbl_color2.Visible == false || lbl_color4.Visible == false)
                {
                    lbl_color1.Show();
                    lbl_color2.Show();
                    lbl_color4.Show();
                }
                lbl_color3.Visible = false;
                lbl_color1.Location = new Point(50, 45);
                lbl_color2.Location = new Point(lbl_color1.Location.X + 60, 45);
                lbl_color4.Location = new Point(lbl_color2.Location.X + 60, 45);

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
                if (lbl_color1.Visible == false || lbl_color3.Visible == false || lbl_color4.Visible == false)
                {
                    lbl_color1.Show();
                    lbl_color3.Show();
                    lbl_color4.Show();
                }
                lbl_color2.Visible = false;
                lbl_color1.Location = new Point(50, 45);
                lbl_color3.Location = new Point(lbl_color1.Location.X + 60, 45);
                lbl_color4.Location = new Point(lbl_color3.Location.X + 60, 45);

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

            lbl_color1.ForeColor = Settings1.Default.color1;
            lbl_color3.ForeColor = Settings1.Default.color2;
            lbl_color2.ForeColor = Settings1.Default.color3;
            lbl_color4.ForeColor = Settings1.Default.color4;
            
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
            try
            {
                int numeric1 = int.Parse(txt_numericrange1.Text);
                int numeric2 = int.Parse(txt_numericrange2.Text);

                number1 = rnd.Next(numeric1, numeric2);
                number2 = rnd.Next(numeric1, numeric2);


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
                            break;
                        }
                    case 3:
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

                            break;
                        }
                    case 9:
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
                            break;
                        }
                    case 10:
                        {
                            Random rndmath = new Random();
                            int rndoperators = rndmath.Next(1, 3);

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
                            Random rndmath = new Random();
                            int rndoperators = rndmath.Next(1, 3);

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
                            Random rndmath = new Random();
                            int rndoperators = rndmath.Next(1, 3);

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
                            Random rndmath = new Random();
                            int rndoperators = rndmath.Next(1, 4);

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
                            Random rndmath = new Random();
                            int rndoperators = rndmath.Next(1, 4);

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
                            Random rndmath = new Random();
                            int rndoperators = rndmath.Next(1, 4);

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
            catch (Exception)
            {

                throw;
            }
            

        }

        public void randomNumber2()
        {

            try
            {
                int numeric1 = int.Parse(txt_numericrange1.Text);
                int numeric2 = int.Parse(txt_numericrange2.Text);

                number3 = rnd.Next(numeric1, numeric2);
                number4 = rnd.Next(numeric1, numeric2);
                processNumber();

                switch (processnumber)

                {
                    case 1:
                        {

                            rndoperators2 = rndmath.Next(1, 5);

                            if (rndoperators2 == 1)
                                operators2 = "+";


                            else if (rndoperators2 == 2)
                                operators2 = "-";


                            else if (rndoperators2 == 3)
                                operators2 = "x";

                            else if (rndoperators2 == 4)
                                operators2 = "÷";

                            if (rndoperators2 == 4)
                            {
                                if (number3 < number4)
                                {
                                    if (number4 % number3 == 0)
                                    {
                                        lbl_process2.Text = number4.ToString() + " " + operators2 + " " + number3.ToString();
                                    }

                                    else
                                    {
                                        lbl_process2.Text = number3.ToString() + " " + operators2 + " " + number3.ToString();
                                    }

                                }

                                else
                                {

                                    if (number3 % number4 == 0)
                                    {
                                        lbl_process2.Text = number3.ToString() + " " + operators2 + " " + number4.ToString();
                                    }

                                    else
                                    {

                                        lbl_process2.Text = number3.ToString() + " " + operators2 + " " + number3.ToString();
                                    }

                                }
                            }
                            else if (number3 < number4)
                            {
                                lbl_process2.Text = number4.ToString() + " " + operators2 + " " + number3.ToString();
                            }

                            else
                            {
                                lbl_process2.Text = number3.ToString() + " " + operators2 + " " + number4.ToString();
                            }

                            break;
                        }
                    case 2:
                        {

                            rndoperators2 = rndmath.Next(1, 3);

                            if (rndoperators2 == 1)
                                operators2 = "+";


                            else if (rndoperators2 == 2)
                                operators2 = "-";



                            if (number3 < number4)
                            {
                                lbl_process2.Text = number4.ToString() + " " + operators2 + " " + number3.ToString();
                            }

                            else
                                lbl_process2.Text = number3.ToString() + " " + operators2 + " " + number4.ToString();
                            break;
                        }
                    case 3:
                        {



                            rndoperators2 = rndmath.Next(1, 4);

                            if (rndoperators2 == 1)
                                operators2 = "+";

                            else if (rndoperators2 == 2)
                                operators2 = "-";

                            else if (rndoperators2 == 3)
                                operators2 = "x";

                            if (number3 < number4)
                            {
                                lbl_process2.Text = number4.ToString() + " " + operators2 + " " + number3.ToString();
                            }

                            else
                                lbl_process2.Text = number3.ToString() + " " + operators2 + " " + number4.ToString();
                            break;
                        }
                    case 4:
                        {
                            operators2 = "+";

                            if (number3 < number4)
                            {
                                lbl_process2.Text = number4.ToString() + " " + operators2 + " " + number3.ToString();
                            }

                            else
                                lbl_process2.Text = number3.ToString() + " " + operators2 + " " + number4.ToString();

                            break;
                        }
                    case 5:
                        {
                            operators2 = "-";

                            if (number3 < number4)
                            {
                                lbl_process2.Text = number4.ToString() + " " + operators2 + " " + number3.ToString();
                            }

                            else
                                lbl_process2.Text = number3.ToString() + " " + operators2 + " " + number4.ToString();
                            break;
                        }
                    case 6:
                        {
                            operators2 = "x";

                            if (number3 < number4)
                            {
                                lbl_process2.Text = number4.ToString() + " " + operators2 + " " + number3.ToString();
                            }

                            else
                                lbl_process2.Text = number3.ToString() + " " + operators2 + " " + number4.ToString();

                            break;
                        }
                    case 7:
                        {
                            operators2 = "÷";

                            if (number3 < number4)
                            {
                                if (number4 % number3 == 0)
                                {
                                    lbl_process2.Text = number4.ToString() + " " + operators2 + " " + number3.ToString();
                                }

                                else
                                {
                                    lbl_process2.Text = number3.ToString() + " " + operators2 + " " + number3.ToString();
                                }


                            }


                            else
                            {

                                if (number3 % number4 == 0)
                                {
                                    lbl_process2.Text = number3.ToString() + " " + operators2 + " " + number4.ToString();
                                }

                                else
                                {

                                    lbl_process2.Text = number4.ToString() + " " + operators2 + " " + number4.ToString();
                                }

                            }

                            break;
                        }
                    case 8:
                        {

                            rndoperators2 = rndmath.Next(1, 3);

                            if (rndoperators2 == 1)
                                operators2 = "-";

                            else if (rndoperators2 == 2)
                                operators2 = "x";


                            if (number3 < number4)
                            {
                                lbl_process2.Text = number4.ToString() + " " + operators2 + " " + number3.ToString();
                            }

                            else
                                lbl_process2.Text = number3.ToString() + " " + operators2 + " " + number4.ToString();

                            break;
                        }
                    case 9:
                        {

                            rndoperators2 = rndmath.Next(1, 3);

                            if (rndoperators2 == 1)
                                operators2 = "+";

                            else if (rndoperators2 == 2)
                                operators2 = "x";


                            if (number3 < number4)
                            {
                                lbl_process2.Text = number4.ToString() + " " + operators2 + " " + number3.ToString();
                            }

                            else
                                lbl_process2.Text = number3.ToString() + " " + operators2 + " " + number4.ToString();
                            break;
                        }
                    case 10:
                        {

                            rndoperators2 = rndmath.Next(1, 3);

                            if (rndoperators2 == 1)
                                operators2 = "+";

                            else if (rndoperators2 == 2)
                                operators2 = "÷";



                            if (rndoperators2 == 2)
                            {
                                if (number3 < number4)
                                {
                                    if (number4 % number3 == 0)
                                    {
                                        lbl_process2.Text = number4.ToString() + " " + operators2 + " " + number3.ToString();
                                    }

                                    else
                                    {
                                        lbl_process2.Text = number3.ToString() + " " + operators2 + " " + number3.ToString();
                                    }

                                }

                                else
                                {

                                    if (number3 % number4 == 0)
                                    {
                                        lbl_process2.Text = number3.ToString() + " " + operators2 + " " + number4.ToString();
                                    }

                                    else
                                    {

                                        lbl_process2.Text = number3.ToString() + " " + operators2 + " " + number3.ToString();
                                    }

                                }
                            }



                            else if (number3 < number4)
                            {
                                lbl_process2.Text = number4.ToString() + " " + operators2 + " " + number3.ToString();
                            }

                            else
                                lbl_process2.Text = number3.ToString() + " " + operators2 + " " + number4.ToString();
                            break;
                        }
                    case 11:
                        {

                            rndoperators2 = rndmath.Next(1, 3);

                            if (rndoperators2 == 1)
                                operators2 = "x";

                            else if (rndoperators2 == 2)
                                operators2 = "÷";


                            if (rndoperators2 == 2)
                            {
                                if (number3 < number4)
                                {
                                    if (number4 % number4 == 0)
                                    {
                                        lbl_process2.Text = number4.ToString() + " " + operators2 + " " + number3.ToString();
                                    }

                                    else
                                    {
                                        lbl_process2.Text = number3.ToString() + " " + operators2 + " " + number3.ToString();
                                    }

                                }

                                else
                                {

                                    if (number3 % number4 == 0)
                                    {
                                        lbl_process2.Text = number3.ToString() + " " + operators2 + " " + number4.ToString();
                                    }

                                    else
                                    {

                                        lbl_process2.Text = number3.ToString() + " " + operators2 + " " + number3.ToString();
                                    }

                                }
                            }

                            else if (number3 < number4)
                            {
                                lbl_process2.Text = number4.ToString() + " " + operators2 + " " + number3.ToString();
                            }

                            else
                                lbl_process2.Text = number3.ToString() + " " + operators2 + " " + number4.ToString();
                            break;
                        }
                    case 12:
                        {

                            rndoperators2 = rndmath.Next(1, 3);

                            if (rndoperators2 == 1)
                                operators2 = "-";

                            else if (rndoperators2 == 2)
                                operators2 = "÷";


                            if (rndoperators2 == 2)
                            {
                                if (number3 < number4)
                                {
                                    if (number4 % number3 == 0)
                                    {
                                        lbl_process2.Text = number4.ToString() + " " + operators2 + " " + number3.ToString();
                                    }

                                    else
                                    {
                                        lbl_process2.Text = number3.ToString() + " " + operators2 + " " + number3.ToString();
                                    }

                                }

                                else
                                {

                                    if (number3 % number4 == 0)
                                    {
                                        lbl_process2.Text = number3.ToString() + " " + operators2 + " " + number4.ToString();
                                    }

                                    else
                                    {

                                        lbl_process2.Text = number3.ToString() + " " + operators2 + " " + number3.ToString();
                                    }

                                }
                            }


                            else if (number1 < number2)
                            {
                                lbl_process.Text = number2.ToString() + " " + operators2 + " " + number1.ToString();
                            }

                            else
                                lbl_process.Text = number1.ToString() + " " + operators2 + " " + number2.ToString();
                            break;
                        }
                    case 13:
                        {

                            rndoperators2 = rndmath.Next(1, 4);

                            if (rndoperators2 == 1)
                                operators2 = "-";

                            else if (rndoperators2 == 2)
                                operators2 = "x";

                            else if (rndoperators2 == 3)
                                operators2 = "÷";

                            if (rndoperators2 == 3)
                            {
                                if (number3 < number4)
                                {
                                    if (number4 % number3 == 0)
                                    {
                                        lbl_process2.Text = number4.ToString() + " " + operators2 + " " + number3.ToString();
                                    }

                                    else
                                    {
                                        lbl_process2.Text = number3.ToString() + " " + operators2 + " " + number3.ToString();
                                    }

                                }

                                else
                                {

                                    if (number3 % number4 == 0)
                                    {
                                        lbl_process2.Text = number3.ToString() + " " + operators2 + " " + number4.ToString();
                                    }

                                    else
                                    {

                                        lbl_process2.Text = number3.ToString() + " " + operators2 + " " + number3.ToString();
                                    }

                                }
                            }
                            else if (number3 < number4)
                            {
                                lbl_process2.Text = number4.ToString() + " " + operators2 + " " + number3.ToString();
                            }

                            else
                                lbl_process2.Text = number3.ToString() + " " + operators2 + " " + number4.ToString();
                            break;
                        }
                    case 14:
                        {

                            rndoperators2 = rndmath.Next(1, 4);

                            if (rndoperators2 == 1)
                                operators2 = "+";

                            else if (rndoperators2 == 2)
                                operators2 = "-";

                            else if (rndoperators2 == 3)
                                operators2 = "÷";



                            if (rndoperators2 == 3)
                            {
                                if (number3 < number4)
                                {
                                    if (number4 % number3 == 0)
                                    {
                                        lbl_process2.Text = number4.ToString() + " " + operators2 + " " + number3.ToString();
                                    }

                                    else
                                    {
                                        lbl_process2.Text = number3.ToString() + " " + operators2 + " " + number3.ToString();
                                    }

                                }

                                else
                                {

                                    if (number3 % number4 == 0)
                                    {
                                        lbl_process2.Text = number3.ToString() + " " + operators2 + " " + number4.ToString();
                                    }

                                    else
                                    {

                                        lbl_process2.Text = number3.ToString() + " " + operators2 + " " + number3.ToString();
                                    }

                                }
                            }

                            else if (number3 < number4)
                            {
                                lbl_process2.Text = number4.ToString() + " " + operators2 + " " + number3.ToString();
                            }

                            else
                                lbl_process2.Text = number3.ToString() + " " + operators2 + " " + number4.ToString();
                            break;
                        }
                    case 15:
                        {

                            rndoperators2 = rndmath.Next(1, 4);

                            if (rndoperators2 == 1)
                                operators2 = "+";

                            else if (rndoperators2 == 2)
                                operators2 = "x";

                            else if (rndoperators2 == 3)
                                operators2 = "÷";

                            if (rndoperators2 == 3)
                            {
                                if (number3 < number4)
                                {
                                    if (number4 % number3 == 0)
                                    {
                                        lbl_process2.Text = number4.ToString() + " " + operators2 + " " + number3.ToString();
                                    }

                                    else
                                    {
                                        lbl_process2.Text = number3.ToString() + " " + operators2 + " " + number3.ToString();
                                    }

                                }

                                else
                                {

                                    if (number3 % number4 == 0)
                                    {
                                        lbl_process2.Text = number3.ToString() + " " + operators2 + " " + number4.ToString();
                                    }

                                    else
                                    {

                                        lbl_process2.Text = number3.ToString() + " " + operators2 + " " + number3.ToString();
                                    }

                                }
                            }
                            else if (number3 < number4)
                            {
                                lbl_process2.Text = number4.ToString() + " " + operators2 + " " + number3.ToString();
                            }

                            else
                                lbl_process2.Text = number3.ToString() + " " + operators2 + " " + number4.ToString();
                            break;
                        }


                }

            }
            catch (Exception)
            {

                throw;
            }
           





        }

        public void randomNumberMustAssignTask()
        {
            try
            {
                int numeric1 = int.Parse(txt_numericrange1.Text);
                int numeric2 = int.Parse(txt_numericrange2.Text);
                Random rnd = new Random();
                number1 = rnd.Next(numeric1, numeric2);
                number2 = rnd.Next(numeric1, numeric2);

                processNumber();
                switch (processnumber)
                {
                    case 1:
                        {
                            rndoperators = rndmath.Next(1, 5);

                            if (rndoperators == 1)
                                lbl_mustassignnumber.ForeColor = Settings1.Default.color1;


                            else if (rndoperators == 2)
                                lbl_mustassignnumber.ForeColor = Settings1.Default.color2;


                            else if (rndoperators == 3)
                                lbl_mustassignnumber.ForeColor = Settings1.Default.color3;

                            else if (rndoperators == 4)
                                lbl_mustassignnumber.ForeColor = Settings1.Default.color4;


                            if (rndoperators == 4)
                            {
                                if (number1 < number2)
                                {
                                    if (number2 % number1 == 0)
                                        lbl_mustassignnumber.Text = number2.ToString() + " " + "●" + " " + number1.ToString() + "=";

                                    else
                                        lbl_mustassignnumber.Text = number2.ToString() + " " + "●" + " " + number2.ToString() + "=";

                                }

                                else
                                {

                                    if (number1 % number2 == 0)
                                        lbl_mustassignnumber.Text = number1.ToString() + " " + "●" + " " + number2.ToString() + "=";

                                    else
                                        lbl_mustassignnumber.Text = number1.ToString() + " " + "●" + " " + number1.ToString() + "=";


                                }
                            }
                            else if (number1 < number2)
                                lbl_mustassignnumber.Text = number2.ToString() + " " + "●" + " " + number1.ToString() + "=";

                            else
                                lbl_mustassignnumber.Text = number1.ToString() + " " + "●" + " " + number2.ToString() + "=";

                            break;
                        }
                    case 2:
                        {
                            rndoperators = rndmath.Next(1, 3);

                            if (rndoperators == 1)
                                lbl_mustassignnumber.ForeColor = Settings1.Default.color1;


                            else if (rndoperators == 2)
                                lbl_mustassignnumber.ForeColor = Settings1.Default.color2;



                            if (number1 < number2)
                                lbl_mustassignnumber.Text = number2.ToString() + " " + "●" + " " + number1.ToString() + "=";

                            else
                                lbl_mustassignnumber.Text = number1.ToString() + " " + "●" + " " + number2.ToString() + "=";

                            break;
                        }
                    case 3:
                        {
                            rndoperators = rndmath.Next(1, 4);

                            if (rndoperators == 1)
                                lbl_mustassignnumber.ForeColor = Settings1.Default.color1;

                            else if (rndoperators == 2)
                                lbl_mustassignnumber.ForeColor = Settings1.Default.color2;

                            else if (rndoperators == 3)
                                lbl_mustassignnumber.ForeColor = Settings1.Default.color3;

                            if (number1 < number2)
                                lbl_mustassignnumber.Text = number2.ToString() + " " + "●" + " " + number1.ToString() + "=";

                            else
                                lbl_mustassignnumber.Text = number1.ToString() + " " + "●" + " " + number2.ToString() + "=";

                            break;
                        }
                    case 4:
                        {
                            lbl_mustassignnumber.ForeColor = Settings1.Default.color1;

                            if (number1 < number2)
                                lbl_mustassignnumber.Text = number2.ToString() + " " + "●" + " " + number1.ToString() + "=";

                            else
                                lbl_mustassignnumber.Text = number1.ToString() + " " + "●" + " " + number2.ToString() + "=";

                            break;
                        }
                    case 5:
                        {
                            lbl_mustassignnumber.ForeColor = Settings1.Default.color2;

                            if (number1 < number2)
                                lbl_mustassignnumber.Text = number2.ToString() + " " + "●" + " " + number1.ToString() + "=";

                            else
                                lbl_mustassignnumber.Text = number1.ToString() + " " + "●" + " " + number2.ToString() + "=";

                            break;
                        }
                    case 6:
                        {
                            lbl_mustassignnumber.ForeColor = Settings1.Default.color3;

                            if (number1 < number2)
                                lbl_mustassignnumber.Text = number2.ToString() + " " + "●" + " " + number1.ToString() + "=";

                            else
                                lbl_mustassignnumber.Text = number1.ToString() + " " + "●" + " " + number2.ToString() + "=";

                            break;
                        }
                    case 7:
                        {

                            lbl_mustassignnumber.ForeColor = Settings1.Default.color4;


                            if (number1 < number2)
                            {
                                if (number2 % number1 == 0)
                                    lbl_mustassignnumber.Text = number2.ToString() + " " + "●" + " " + number1.ToString() + "=";

                                else
                                    lbl_mustassignnumber.Text = number2.ToString() + " " + "●" + " " + number2.ToString() + "=";

                            }

                            else
                            {

                                if (number1 % number2 == 0)
                                    lbl_mustassignnumber.Text = number1.ToString() + " " + "●" + " " + number2.ToString() + "=";

                                else
                                    lbl_mustassignnumber.Text = number1.ToString() + " " + "●" + " " + number1.ToString() + "=";


                            }


                            break;
                        }
                    case 8:
                        {
                            rndoperators = rndmath.Next(1, 3);

                            if (rndoperators == 1)
                                lbl_mustassignnumber.ForeColor = Settings1.Default.color2;

                            else if (rndoperators == 2)
                                lbl_mustassignnumber.ForeColor = Settings1.Default.color3;


                            if (number1 < number2)
                                lbl_mustassignnumber.Text = number2.ToString() + " " + "●" + " " + number1.ToString() + "=";

                            else
                                lbl_mustassignnumber.Text = number1.ToString() + " " + "●" + " " + number2.ToString() + "=";

                            break;
                        }
                    case 9:
                        {
                            rndoperators = rndmath.Next(1, 3);

                            if (rndoperators == 1)
                                lbl_mustassignnumber.ForeColor = Settings1.Default.color1;

                            else if (rndoperators == 2)
                                lbl_mustassignnumber.ForeColor = Settings1.Default.color3;


                            if (number1 < number2)
                                lbl_mustassignnumber.Text = number2.ToString() + " " + "●" + " " + number1.ToString() + "=";

                            else
                                lbl_mustassignnumber.Text = number1.ToString() + " " + "●" + " " + number2.ToString() + "=";

                            break;
                        }
                    case 10:
                        {
                            rndoperators = rndmath.Next(1, 3);

                            if (rndoperators == 1)
                                lbl_mustassignnumber.ForeColor = Settings1.Default.color1;

                            else if (rndoperators == 2)
                                lbl_mustassignnumber.ForeColor = Settings1.Default.color4;


                            if (rndoperators == 2)
                            {
                                if (number1 < number2)
                                {
                                    if (number2 % number1 == 0)
                                        lbl_mustassignnumber.Text = number2.ToString() + " " + "●" + " " + number1.ToString() + "=";

                                    else
                                        lbl_mustassignnumber.Text = number2.ToString() + " " + "●" + " " + number2.ToString() + "=";

                                }

                                else
                                {

                                    if (number1 % number2 == 0)
                                        lbl_mustassignnumber.Text = number1.ToString() + " " + "●" + " " + number2.ToString() + "=";

                                    else
                                        lbl_mustassignnumber.Text = number1.ToString() + " " + "●" + " " + number1.ToString() + "=";


                                }
                            }

                            else if (number1 < number2)
                                lbl_mustassignnumber.Text = number2.ToString() + " " + "●" + " " + number1.ToString() + "=";

                            else
                                lbl_mustassignnumber.Text = number1.ToString() + " " + "●" + " " + number2.ToString() + "=";

                            break;
                        }
                    case 11:
                        {
                            rndoperators = rndmath.Next(1, 3);

                            if (rndoperators == 1)
                                lbl_mustassignnumber.ForeColor = Settings1.Default.color3;

                            else if (rndoperators == 2)
                                lbl_mustassignnumber.ForeColor = Settings1.Default.color4;


                            if (rndoperators == 2)
                            {
                                if (number1 < number2)
                                {
                                    if (number2 % number1 == 0)
                                        lbl_mustassignnumber.Text = number2.ToString() + " " + "●" + " " + number1.ToString() + "=";

                                    else
                                        lbl_mustassignnumber.Text = number2.ToString() + " " + "●" + " " + number2.ToString() + "=";

                                }

                                else
                                {

                                    if (number1 % number2 == 0)
                                        lbl_mustassignnumber.Text = number1.ToString() + " " + "●" + " " + number2.ToString() + "=";

                                    else
                                        lbl_mustassignnumber.Text = number1.ToString() + " " + "●" + " " + number1.ToString() + "=";


                                }
                            }
                            else if (number1 < number2)
                                lbl_mustassignnumber.Text = number2.ToString() + " " + "●" + " " + number1.ToString() + "=";

                            else
                                lbl_mustassignnumber.Text = number1.ToString() + " " + "●" + " " + number2.ToString() + "=";

                            break;
                        }
                    case 12:
                        {
                            rndoperators = rndmath.Next(1, 3);

                            if (rndoperators == 1)
                                lbl_mustassignnumber.ForeColor = Settings1.Default.color2;

                            else if (rndoperators == 2)
                                lbl_mustassignnumber.ForeColor = Settings1.Default.color4;



                            if (rndoperators == 2)
                            {
                                if (number1 < number2)
                                {
                                    if (number2 % number1 == 0)
                                        lbl_mustassignnumber.Text = number2.ToString() + " " + "●" + " " + number1.ToString() + "=";

                                    else
                                        lbl_mustassignnumber.Text = number2.ToString() + " " + "●" + " " + number2.ToString() + "=";

                                }

                                else
                                {

                                    if (number1 % number2 == 0)
                                        lbl_mustassignnumber.Text = number1.ToString() + " " + "●" + " " + number2.ToString() + "=";

                                    else
                                        lbl_mustassignnumber.Text = number1.ToString() + " " + "●" + " " + number1.ToString() + "=";


                                }
                            }
                            else if (number1 < number2)
                                lbl_mustassignnumber.Text = number2.ToString() + " " + "●" + " " + number1.ToString() + "=";

                            else
                                lbl_mustassignnumber.Text = number1.ToString() + " " + "●" + " " + number2.ToString() + "=";


                            break;
                        }
                    case 13:
                        {
                            rndoperators = rndmath.Next(1, 4);

                            if (rndoperators == 1)
                                lbl_mustassignnumber.ForeColor = Settings1.Default.color2;

                            else if (rndoperators == 2)
                                lbl_mustassignnumber.ForeColor = Settings1.Default.color3;

                            else if (rndoperators == 3)
                                lbl_mustassignnumber.ForeColor = Settings1.Default.color4;


                            if (rndoperators == 3)
                            {
                                if (number1 < number2)
                                {
                                    if (number2 % number1 == 0)
                                        lbl_mustassignnumber.Text = number2.ToString() + " " + "●" + " " + number1.ToString() + "=";

                                    else
                                        lbl_mustassignnumber.Text = number2.ToString() + " " + "●" + " " + number2.ToString() + "=";

                                }

                                else
                                {

                                    if (number1 % number2 == 0)
                                        lbl_mustassignnumber.Text = number1.ToString() + " " + "●" + " " + number2.ToString() + "=";

                                    else
                                        lbl_mustassignnumber.Text = number1.ToString() + " " + "●" + " " + number1.ToString() + "=";


                                }
                            }
                            else if (number1 < number2)
                                lbl_mustassignnumber.Text = number2.ToString() + " " + "●" + " " + number1.ToString() + "=";

                            else
                                lbl_mustassignnumber.Text = number1.ToString() + " " + "●" + " " + number2.ToString() + "=";

                            break;
                        }
                    case 14:
                        {
                            rndoperators = rndmath.Next(1, 4);

                            if (rndoperators == 1)
                                lbl_mustassignnumber.ForeColor = Settings1.Default.color1;

                            else if (rndoperators == 2)
                                lbl_mustassignnumber.ForeColor = Settings1.Default.color2;

                            else if (rndoperators == 3)
                                lbl_mustassignnumber.ForeColor = Settings1.Default.color4;


                            if (rndoperators == 3)
                            {
                                if (number1 < number2)
                                {
                                    if (number2 % number1 == 0)
                                        lbl_mustassignnumber.Text = number2.ToString() + " " + "●" + " " + number1.ToString() + "=";

                                    else
                                        lbl_mustassignnumber.Text = number2.ToString() + " " + "●" + " " + number2.ToString() + "=";

                                }

                                else
                                {

                                    if (number1 % number2 == 0)
                                        lbl_mustassignnumber.Text = number1.ToString() + " " + "●" + " " + number2.ToString() + "=";

                                    else
                                        lbl_mustassignnumber.Text = number1.ToString() + " " + "●" + " " + number1.ToString() + "=";


                                }
                            }
                            else if (number1 < number2)
                                lbl_mustassignnumber.Text = number2.ToString() + " " + "●" + " " + number1.ToString() + "=";

                            else
                                lbl_mustassignnumber.Text = number1.ToString() + " " + "●" + " " + number2.ToString() + "=";

                            break;
                        }
                    case 15:
                        {
                            rndoperators = rndmath.Next(1, 4);

                            if (rndoperators == 1)
                                lbl_mustassignnumber.ForeColor = Settings1.Default.color1;

                            else if (rndoperators == 2)
                                lbl_mustassignnumber.ForeColor = Settings1.Default.color3;

                            else if (rndoperators == 3)
                                lbl_mustassignnumber.ForeColor = Settings1.Default.color4;


                            if (rndoperators == 3)
                            {
                                if (number1 < number2)
                                {
                                    if (number2 % number1 == 0)
                                        lbl_mustassignnumber.Text = number2.ToString() + " " + "●" + " " + number1.ToString() + "=";

                                    else
                                        lbl_mustassignnumber.Text = number2.ToString() + " " + "●" + " " + number2.ToString() + "=";

                                }

                                else
                                {

                                    if (number1 % number2 == 0)
                                        lbl_mustassignnumber.Text = number1.ToString() + " " + "●" + " " + number2.ToString() + "=";

                                    else
                                        lbl_mustassignnumber.Text = number1.ToString() + " " + "●" + " " + number1.ToString() + "=";


                                }
                            }
                            else if (number1 < number2)
                                lbl_mustassignnumber.Text = number2.ToString() + " " + "●" + " " + number1.ToString() + "=";

                            else
                                lbl_mustassignnumber.Text = number1.ToString() + " " + "●" + " " + number2.ToString() + "=";

                            break;
                        }
                }

            }
            catch (Exception)
            {

                throw;
            }
          

        }

        public void randomNumberMustAssignTask2()
        {
            try
            {
                int numeric1 = int.Parse(txt_numericrange1.Text);
                int numeric2 = int.Parse(txt_numericrange2.Text);

                number3 = rnd.Next(numeric1, numeric2);
                number4 = rnd.Next(numeric1, numeric2);

                processNumber();
                switch (processnumber)
                {
                    case 1:
                        {

                            rndoperators2 = rndmath.Next(1, 5);

                            if (rndoperators2 == 1)
                                lbl_mustassignnumber2.ForeColor = Settings1.Default.color1;


                            else if (rndoperators2 == 2)
                                lbl_mustassignnumber2.ForeColor = Settings1.Default.color2;


                            else if (rndoperators2 == 3)
                                lbl_mustassignnumber2.ForeColor = Settings1.Default.color3;

                            else if (rndoperators2 == 4)
                                lbl_mustassignnumber2.ForeColor = Settings1.Default.color4;


                            if (rndoperators2 == 4)
                            {
                                if (number3 < number4)
                                {
                                    if (number4 % number3 == 0)
                                        lbl_mustassignnumber2.Text = number4.ToString() + " " + "●" + " " + number3.ToString() + "=";


                                    else
                                        lbl_mustassignnumber2.Text = number4.ToString() + " " + "●" + " " + number4.ToString() + "=";

                                }

                                else
                                {

                                    if (number3 % number4 == 0)
                                        lbl_mustassignnumber2.Text = number3.ToString() + " " + "●" + " " + number4.ToString() + "=";


                                    else
                                        lbl_mustassignnumber2.Text = number3.ToString() + " " + "●" + " " + number3.ToString() + "=";


                                }
                            }
                            else if (number3 < number4)
                                lbl_mustassignnumber2.Text = number4.ToString() + " " + "●" + " " + number3.ToString() + "=";


                            else
                                lbl_mustassignnumber2.Text = number3.ToString() + " " + "●" + " " + number4.ToString() + "=";

                            break;
                        }
                    case 2:
                        {

                            rndoperators2 = rndmath.Next(1, 3);

                            if (rndoperators2 == 1)
                                lbl_mustassignnumber2.ForeColor = Settings1.Default.color1;


                            else if (rndoperators2 == 2)
                                lbl_mustassignnumber2.ForeColor = Settings1.Default.color2;



                            if (number3 < number4)
                                lbl_mustassignnumber2.Text = number4.ToString() + " " + "●" + " " + number3.ToString() + "=";

                            else
                                lbl_mustassignnumber2.Text = number3.ToString() + " " + "●" + " " + number4.ToString() + "=";

                            break;
                        }
                    case 3:
                        {

                            rndoperators2 = rndmath.Next(1, 4);

                            if (rndoperators2 == 1)
                                lbl_mustassignnumber2.ForeColor = Settings1.Default.color1;

                            else if (rndoperators2 == 2)
                                lbl_mustassignnumber2.ForeColor = Settings1.Default.color2;

                            else if (rndoperators2 == 3)
                                lbl_mustassignnumber2.ForeColor = Settings1.Default.color3;

                            if (number3 < number4)
                                lbl_mustassignnumber2.Text = number4.ToString() + " " + "●" + " " + number3.ToString() + "=";

                            else
                                lbl_mustassignnumber2.Text = number3.ToString() + " " + "●" + " " + number4.ToString() + "=";

                            break;
                        }
                    case 4:
                        {
                            lbl_mustassignnumber2.ForeColor = Settings1.Default.color1;

                            if (number3 < number4)
                                lbl_mustassignnumber2.Text = number4.ToString() + " " + "●" + " " + number3.ToString() + "=";

                            else
                                lbl_mustassignnumber2.Text = number3.ToString() + " " + "●" + " " + number4.ToString() + "=";

                            break;
                        }
                    case 5:
                        {
                            lbl_mustassignnumber2.ForeColor = Settings1.Default.color2;

                            if (number3 < number4)
                                lbl_mustassignnumber2.Text = number4.ToString() + " " + "●" + " " + number3.ToString() + "=";

                            else
                                lbl_mustassignnumber2.Text = number3.ToString() + " " + "●" + " " + number4.ToString() + "=";

                            break;
                        }
                    case 6:
                        {
                            lbl_mustassignnumber2.ForeColor = Settings1.Default.color3;

                            if (number3 < number4)
                                lbl_mustassignnumber2.Text = number4.ToString() + " " + "●" + " " + number3.ToString() + "=";

                            else
                                lbl_mustassignnumber2.Text = number3.ToString() + " " + "●" + " " + number4.ToString() + "=";

                            break;
                        }
                    case 7:
                        {

                            lbl_mustassignnumber2.ForeColor = Settings1.Default.color4;


                            if (number3 < number4)
                            {
                                if (number4 % number3 == 0)
                                    lbl_mustassignnumber2.Text = number4.ToString() + " " + "●" + " " + number3.ToString() + "=";


                                else
                                    lbl_mustassignnumber2.Text = number4.ToString() + " " + "●" + " " + number4.ToString() + "=";

                            }

                            else
                            {

                                if (number3 % number4 == 0)
                                    lbl_mustassignnumber2.Text = number3.ToString() + " " + "●" + " " + number4.ToString() + "=";


                                else
                                    lbl_mustassignnumber2.Text = number3.ToString() + " " + "●" + " " + number3.ToString() + "=";


                            }

                            break;
                        }
                    case 8:
                        {

                            rndoperators2 = rndmath.Next(1, 3);

                            if (rndoperators == 1)
                                lbl_mustassignnumber2.ForeColor = Settings1.Default.color2;

                            else if (rndoperators == 2)
                                lbl_mustassignnumber2.ForeColor = Settings1.Default.color3;


                            if (number3 < number4)
                                lbl_mustassignnumber2.Text = number4.ToString() + " " + "●" + " " + number3.ToString() + "=";


                            else
                                lbl_mustassignnumber2.Text = number3.ToString() + " " + "●" + " " + number4.ToString() + "=";

                            break;
                        }
                    case 9:
                        {

                            rndoperators2 = rndmath.Next(1, 3);

                            if (rndoperators2 == 1)
                                lbl_mustassignnumber2.ForeColor = Settings1.Default.color1;

                            else if (rndoperators2 == 2)
                                lbl_mustassignnumber2.ForeColor = Settings1.Default.color3;


                            if (number3 < number4)
                                lbl_mustassignnumber2.Text = number4.ToString() + " " + "●" + " " + number3.ToString() + "=";

                            else
                                lbl_mustassignnumber2.Text = number3.ToString() + " " + "●" + " " + number4.ToString() + "=";

                            break;
                        }
                    case 10:
                        {

                            rndoperators2 = rndmath.Next(1, 3);

                            if (rndoperators2 == 1)
                                lbl_mustassignnumber2.ForeColor = Settings1.Default.color1;

                            else if (rndoperators2 == 2)
                                lbl_mustassignnumber2.ForeColor = Settings1.Default.color4;



                            if (rndoperators2 == 2)
                            {
                                if (number3 < number4)
                                {
                                    if (number4 % number3 == 0)
                                        lbl_mustassignnumber2.Text = number4.ToString() + " " + "●" + " " + number3.ToString() + "=";


                                    else
                                        lbl_mustassignnumber2.Text = number4.ToString() + " " + "●" + " " + number4.ToString() + "=";

                                }

                                else
                                {

                                    if (number3 % number4 == 0)
                                        lbl_mustassignnumber2.Text = number3.ToString() + " " + "●" + " " + number4.ToString() + "=";


                                    else
                                        lbl_mustassignnumber2.Text = number3.ToString() + " " + "●" + " " + number3.ToString() + "=";


                                }
                            }

                            else if (number3 < number4)
                                lbl_mustassignnumber2.Text = number4.ToString() + " " + "●" + " " + number3.ToString() + "=";


                            else
                                lbl_mustassignnumber2.Text = number3.ToString() + " " + "●" + " " + number4.ToString() + "=";

                            break;
                        }
                    case 11:
                        {

                            rndoperators2 = rndmath.Next(1, 3);

                            if (rndoperators2 == 1)
                                lbl_mustassignnumber2.ForeColor = Settings1.Default.color3;

                            else if (rndoperators2 == 2)
                                lbl_mustassignnumber2.ForeColor = Settings1.Default.color4;


                            if (rndoperators2 == 2)
                            {
                                if (number3 < number4)
                                {
                                    if (number4 % number3 == 0)
                                        lbl_mustassignnumber2.Text = number4.ToString() + " " + "●" + " " + number3.ToString() + "=";


                                    else
                                        lbl_mustassignnumber2.Text = number4.ToString() + " " + "●" + " " + number4.ToString() + "=";

                                }

                                else
                                {

                                    if (number3 % number4 == 0)
                                        lbl_mustassignnumber2.Text = number3.ToString() + " " + "●" + " " + number4.ToString() + "=";


                                    else
                                        lbl_mustassignnumber2.Text = number3.ToString() + " " + "●" + " " + number3.ToString() + "=";


                                }
                            }
                            else if (number3 < number4)
                                lbl_mustassignnumber2.Text = number4.ToString() + " " + "●" + " " + number3.ToString() + "=";


                            else
                                lbl_mustassignnumber2.Text = number3.ToString() + " " + "●" + " " + number4.ToString() + "=";

                            break;
                        }
                    case 12:
                        {

                            rndoperators2 = rndmath.Next(1, 3);

                            if (rndoperators2 == 1)
                                lbl_mustassignnumber2.ForeColor = Settings1.Default.color2;

                            else if (rndoperators2 == 2)
                                lbl_mustassignnumber2.ForeColor = Settings1.Default.color4;


                            if (rndoperators2 == 2)
                            {
                                if (number3 < number4)
                                {
                                    if (number4 % number3 == 0)
                                        lbl_mustassignnumber2.Text = number4.ToString() + " " + "●" + " " + number3.ToString() + "=";


                                    else
                                        lbl_mustassignnumber2.Text = number4.ToString() + " " + "●" + " " + number4.ToString() + "=";

                                }

                                else
                                {

                                    if (number3 % number4 == 0)
                                        lbl_mustassignnumber2.Text = number3.ToString() + " " + "●" + " " + number4.ToString() + "=";


                                    else
                                        lbl_mustassignnumber2.Text = number3.ToString() + " " + "●" + " " + number3.ToString() + "=";


                                }
                            }
                            else if (number3 < number4)
                                lbl_mustassignnumber2.Text = number4.ToString() + " " + "●" + " " + number3.ToString() + "=";


                            else
                                lbl_mustassignnumber2.Text = number3.ToString() + " " + "●" + " " + number4.ToString() + "=";

                            break;
                        }
                    case 13:
                        {

                            rndoperators2 = rndmath.Next(1, 4);

                            if (rndoperators2 == 1)
                                lbl_mustassignnumber2.ForeColor = Settings1.Default.color2;

                            else if (rndoperators2 == 2)
                                lbl_mustassignnumber2.ForeColor = Settings1.Default.color3;

                            else if (rndoperators2 == 3)
                                lbl_mustassignnumber2.ForeColor = Settings1.Default.color4;


                            if (rndoperators2 == 3)
                            {
                                if (number3 < number4)
                                {
                                    if (number4 % number3 == 0)
                                        lbl_mustassignnumber2.Text = number4.ToString() + " " + "●" + " " + number3.ToString() + "=";


                                    else
                                        lbl_mustassignnumber2.Text = number4.ToString() + " " + "●" + " " + number4.ToString() + "=";

                                }

                                else
                                {

                                    if (number3 % number4 == 0)
                                        lbl_mustassignnumber2.Text = number3.ToString() + " " + "●" + " " + number4.ToString() + "=";


                                    else
                                        lbl_mustassignnumber2.Text = number3.ToString() + " " + "●" + " " + number3.ToString() + "=";


                                }
                            }
                            else if (number3 < number4)
                                lbl_mustassignnumber2.Text = number4.ToString() + " " + "●" + " " + number3.ToString() + "=";


                            else
                                lbl_mustassignnumber2.Text = number3.ToString() + " " + "●" + " " + number4.ToString() + "=";

                            break;
                        }
                    case 14:
                        {

                            rndoperators2 = rndmath.Next(1, 4);

                            if (rndoperators2 == 1)
                                lbl_mustassignnumber2.ForeColor = Settings1.Default.color1;

                            else if (rndoperators2 == 2)
                                lbl_mustassignnumber2.ForeColor = Settings1.Default.color2;

                            else if (rndoperators2 == 3)
                                lbl_mustassignnumber2.ForeColor = Settings1.Default.color4;


                            if (rndoperators2 == 3)
                            {
                                if (number3 < number4)
                                {
                                    if (number4 % number3 == 0)
                                        lbl_mustassignnumber2.Text = number4.ToString() + " " + "●" + " " + number3.ToString() + "=";


                                    else
                                        lbl_mustassignnumber2.Text = number4.ToString() + " " + "●" + " " + number4.ToString() + "=";

                                }

                                else
                                {

                                    if (number3 % number4 == 0)
                                        lbl_mustassignnumber2.Text = number3.ToString() + " " + "●" + " " + number4.ToString() + "=";


                                    else
                                        lbl_mustassignnumber2.Text = number3.ToString() + " " + "●" + " " + number3.ToString() + "=";


                                }
                            }
                            else if (number3 < number4)
                                lbl_mustassignnumber2.Text = number4.ToString() + " " + "●" + " " + number3.ToString() + "=";


                            else
                                lbl_mustassignnumber2.Text = number3.ToString() + " " + "●" + " " + number4.ToString() + "=";

                            break;
                        }
                    case 15:
                        {

                            rndoperators2 = rndmath.Next(1, 4);

                            if (rndoperators2 == 1)
                                lbl_mustassignnumber2.ForeColor = Settings1.Default.color1;

                            else if (rndoperators2 == 2)
                                lbl_mustassignnumber2.ForeColor = Settings1.Default.color3;

                            else if (rndoperators2 == 3)
                                lbl_mustassignnumber2.ForeColor = Settings1.Default.color4;


                            if (rndoperators2 == 3)
                            {
                                if (number3 < number4)
                                {
                                    if (number4 % number3 == 0)
                                        lbl_mustassignnumber2.Text = number4.ToString() + " " + "●" + " " + number3.ToString() + "=";


                                    else
                                        lbl_mustassignnumber2.Text = number4.ToString() + " " + "●" + " " + number4.ToString() + "=";

                                }

                                else
                                {

                                    if (number3 % number4 == 0)
                                        lbl_mustassignnumber2.Text = number3.ToString() + " " + "●" + " " + number4.ToString() + "=";


                                    else
                                        lbl_mustassignnumber2.Text = number3.ToString() + " " + "●" + " " + number3.ToString() + "=";


                                }
                            }
                            else if (number3 < number4)
                                lbl_mustassignnumber2.Text = number4.ToString() + " " + "●" + " " + number3.ToString() + "=";


                            else
                                lbl_mustassignnumber2.Text = number3.ToString() + " " + "●" + " " + number4.ToString() + "=";

                            break;
                        }
                }
            }
            catch (Exception)
            {

                throw;
            }
           


        }

        private void timer_hidetime_Tick(object sender, EventArgs e)
        {
            panel_process.Visible = false;
            panel_mustasigntask.Visible = false;
            timer_screentime.Start();
            timer_hidetime.Stop();


        }

        private void btn_numerictimeupdown_MouseDown(object sender, MouseEventArgs e)
        {
            int numericsayi;
            switch (MouseButtons)
            {
                case MouseButtons.Right:
                    if (txt_numeric_numberoftransactions.Text != "")
                    {
                        numericsayi = int.Parse(txt_numeric_numberoftransactions.Text);
                        if (numericsayi != 0)
                        {
                            numericsayi -= 1;
                        }
                        txt_numeric_numberoftransactions.Text = numericsayi.ToString();

                    }
                    break;

                case MouseButtons.Left:
                    if (txt_numeric_numberoftransactions.Text != "")
                    {
                        numericsayi = int.Parse(txt_numeric_numberoftransactions.Text);
                        if (numericsayi >= 0)
                        {
                            numericsayi += 1;
                        }
                        txt_numeric_numberoftransactions.Text = numericsayi.ToString();
                    }
                    break;
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

        private void txt_numericscreentime_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;

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

        private void txt_numericrange2_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;

            }
        }

        private void txt_numerictime_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;

            }
        }

        private void btn_colortableok_Click(object sender, EventArgs e)
        {
            panel_colortable.Visible = false;

            if (checkbox_gostergizle.Checked == true)
            {

                    lbl_mustassignnumber.Font = new Font("Infoma Light", 66);
                    lbl_mustassignnumber2.Font = new Font("Infoma Light", 66);
                    randomNumberMustAssignTask();
                    randomNumberMustAssignTask2();
                    timer_screentime.Interval = int.Parse(txt_numericscreentime.Text);
                    timer_hidetime.Interval = int.Parse(txt_numericscreentime.Text);
                    timer_hidetime.Start();
                    panel_mustasigntask.Visible = true;
                    btn_stop.Visible = true;
                    btn_start.Visible = false;

                if (int.Parse(txt_numericrange1.Text) >= 100)
                {
                    lbl_mustassignnumber.Font = new Font("Infoma Light", 50);
                    lbl_mustassignnumber2.Font = new Font("Infoma Light", 50);
                }

            }

            else
            {
                randomNumberMustAssignTask();
                randomNumberMustAssignTask2();
                timer_screentime.Interval = int.Parse(txt_numericscreentime.Text);
                timer_screentime.Start();
                panel_mustasigntask.Visible = true;
                btn_stop.Visible = true;
                btn_start.Visible = false;

            }
        }

        private void cokluislem_Load(object sender, EventArgs e)
        {
          
            
        }

        private void timer_screentime_Tick(object sender, EventArgs e)
        {
        


            if (checkbox_gostergizle.Checked == true)
            {

                if (checkbox_plus.Checked == true || checkbox_minus.Checked == true || checkbox_impact.Checked == true || checkbox_compartment.Checked == true)
                {

                    if (checkbox_mustasigntask.Checked == true)
                    {
                        if (i != int.Parse(txt_numeric_numberoftransactions.Text))
                        {
                            panel_mustasigntask.Visible = true;
                            randomNumberMustAssignTask();
                            randomNumberMustAssignTask2();
                            timer_screentime.Stop();
                            timer_hidetime.Start();
                            i++;
                        }

                        else
                        {

                            timer_screentime.Stop();
                            panel_mustasigntask.Visible = false;
                            btn_stop.Visible = false;
                            btn_start.Visible = true;
                            i = 1;
                        }
                        
                    }

                    else
                    {
                        if (i != int.Parse(txt_numeric_numberoftransactions.Text))
                        {
                            randomNumber();
                            randomNumber2();
                            panel_process.Visible = true;
                            i++;
                            timer_screentime.Stop();
                            timer_hidetime.Start();
                        }

                        else
                        {
                            timer_screentime.Stop();
                            panel_process.Visible = false;
                            btn_stop.Visible = false;
                            btn_start.Visible = true;
                            i = 1;
                        }
                    }

                }



            }


            else if (checkbox_plus.Checked == true || checkbox_minus.Checked == true || checkbox_impact.Checked == true || checkbox_compartment.Checked == true)
            {

                if (checkbox_mustasigntask.Checked == true)
                {
                    randomNumberMustAssignTask();
                    randomNumberMustAssignTask2();
                    panel_mustasigntask.Visible = true;
                }

                else
                {
                    if (i != int.Parse(txt_numeric_numberoftransactions.Text))
                    {
                        randomNumber();
                        randomNumber2();
                        i++;
                        panel_process.Visible = true;
                    }

                    else
                    {
                        timer_screentime.Stop();
                        panel_process.Visible = false;
                        btn_stop.Visible = false;
                        btn_start.Visible = true;
                        i = 1;
                    }
                }

            }






        }

        private void btn_start_Click(object sender, EventArgs e)
        {


            if (checkbox_plus.Checked == false && checkbox_minus.Checked == false && checkbox_impact.Checked == false && checkbox_compartment.Checked == false || int.Parse(txt_numeric_numberoftransactions.Text) == 0 || int.Parse(txt_numericscreentime.Text) == 0 || int.Parse(txt_numericrange2.Text) < int.Parse(txt_numericrange1.Text) || int.Parse(txt_numericrange2.Text) == int.Parse(txt_numericrange1.Text))
            {
                DialogResult dresult = new DialogResult();
                dresult = MessageBox.Show("Lütfen ayarları doğru şekilde yapınız", "Uyarı", MessageBoxButtons.OK);
                btn_stop.Visible = false;
                btn_start.Visible = true;
                lbl_screentime.Focus();
            
            }


            else if (checkbox_mustasigntask.Checked == true)
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
                }
        
            }

            else if (checkbox_gostergizle.Checked == true)
            {
                if (int.Parse(txt_numericrange2.Text) < int.Parse(txt_numericrange1.Text) || int.Parse(txt_numericrange2.Text) == int.Parse(txt_numericrange1.Text))
                {
                    DialogResult dresult = new DialogResult();
                    dresult = MessageBox.Show("Lütfen ayarları doğru şekilde yapınız", "Uyarı", MessageBoxButtons.OK);
                }
                else
                {
                    lbl_process.Font = new Font("Infoma Light", 66);
                    lbl_process2.Font = new Font("Infoma Light", 66);
                    randomNumber();
                    randomNumber2();
                    timer_screentime.Interval = int.Parse(txt_numericscreentime.Text);
                    timer_hidetime.Interval = int.Parse(txt_numericscreentime.Text);
                    timer_hidetime.Start();
                    panel_process.Visible = true;
                    btn_stop.Visible = true;
                    btn_start.Visible = false;

                    if (int.Parse(txt_numericrange1.Text) >= 100)
                    {
                        lbl_process.Font = new Font("Infoma Light", 56);
                        lbl_process2.Font = new Font("Infoma Light", 56);
                    }
                }
              
            }

            else
            {
                lbl_process.Font = new Font("Infoma Light", 66);
                lbl_process2.Font = new Font("Infoma Light", 66);
                randomNumber();
                randomNumber2();
                timer_screentime.Interval = int.Parse(txt_numericscreentime.Text);
                timer_screentime.Start();
                panel_process.Visible = true;
                btn_stop.Visible = true;
                btn_start.Visible = false;

                if (int.Parse(txt_numericrange1.Text) >= 100)
                {
                    lbl_process.Font = new Font("Infoma Light", 56);
                    lbl_process2.Font = new Font("Infoma Light", 56);
                }

            }


        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            if (btn_start.Visible == false)
            {
                btn_stop.Visible = false;
                btn_start.Visible = true;
            }

            
            timer_screentime.Stop();
            timer_hidetime.Stop();
            i = 0;
            panel_process.Visible = false;
            lbl_process.Text = "";
            lbl_process2.Text = "";
            panel_mustasigntask.Visible = false;

        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide();
        }
    }
}
