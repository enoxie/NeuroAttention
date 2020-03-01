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
    public partial class cokluislem : Form
    {
        public cokluislem()
        {
            InitializeComponent();
        }

        public int number1, number2, number3, number4, processnumber;
        public string operators;
        

        public void randomNumberGenerator()
        {
            int numeric1 = (int)numeric_numberrange1.Value;
            int numeric2 = (int)numeric_numberrange2.Value;
            Random rnd = new Random();
            Random rnd2 = new Random();
            number1 = rnd.Next(numeric1, numeric2);
            number2 = rnd.Next(numeric1, numeric2);
            number3 = rnd.Next(numeric1, numeric2);
            number4 = rnd.Next(numeric1, numeric2);
        }

        public void processNumber()
        {
            if (checkbox_plus.Checked == true && checkbox_minus.Checked == true && checkbox_impact.Checked == true && checkbox_compartment.Checked == true)
                processnumber = 1;

            else if (checkbox_plus.Checked == true && checkbox_minus.Checked == true && checkbox_impact.Checked == false && checkbox_compartment.Checked == false)
                processnumber = 2;

            else if (checkbox_plus.Checked == true && checkbox_minus.Checked == true && checkbox_impact.Checked == false && checkbox_compartment.Checked == false)
                processnumber = 3;

            else if (checkbox_plus.Checked == true && checkbox_minus.Checked == true && checkbox_impact.Checked == true && checkbox_compartment.Checked == false)
                processnumber = 4;

            else if (checkbox_plus.Checked == true && checkbox_minus.Checked == false && checkbox_impact.Checked == false && checkbox_compartment.Checked == false)
                processnumber = 5;

            else if (checkbox_plus.Checked == false && checkbox_minus.Checked == true && checkbox_impact.Checked == false && checkbox_compartment.Checked == false)
                processnumber = 6;

            else if (checkbox_plus.Checked == false && checkbox_minus.Checked == false && checkbox_impact.Checked == true && checkbox_compartment.Checked == false)
                processnumber = 7;

            else if (checkbox_plus.Checked == false && checkbox_minus.Checked == false && checkbox_impact.Checked == false && checkbox_compartment.Checked == true)
                processnumber = 8;

            else if (checkbox_plus.Checked == false && checkbox_minus.Checked == true && checkbox_impact.Checked == true && checkbox_compartment.Checked == false)
                processnumber = 9;

            else if (checkbox_plus.Checked == true && checkbox_minus.Checked == false && checkbox_impact.Checked == true && checkbox_compartment.Checked == false)
                processnumber = 10;

            else if (checkbox_plus.Checked == true && checkbox_minus.Checked == false && checkbox_impact.Checked == false && checkbox_compartment.Checked == true)
                processnumber = 11;

            else if (checkbox_plus.Checked == false && checkbox_minus.Checked == false && checkbox_impact.Checked == true && checkbox_compartment.Checked == true)
                processnumber = 12;

            else if (checkbox_plus.Checked == false && checkbox_minus.Checked == true && checkbox_impact.Checked == false && checkbox_compartment.Checked == true)
                processnumber = 13;

            else if (checkbox_plus.Checked == false && checkbox_minus.Checked == true && checkbox_impact.Checked == true && checkbox_compartment.Checked == true)
                processnumber = 14;

            else if (checkbox_plus.Checked == true && checkbox_minus.Checked == true && checkbox_impact.Checked == false && checkbox_compartment.Checked == true)
                processnumber = 15;

            else if (checkbox_plus.Checked == true && checkbox_minus.Checked == false && checkbox_impact.Checked == true && checkbox_compartment.Checked == true)
                processnumber = 16;

            else { }

        }

        public void randomNumberNormal()
        {
            randomNumberGenerator();
            processNumber();

                switch (processnumber)
            
           {
                case 1:
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
                        {
                            lbl_process.Text = number1.ToString() + " " + operators + " " + number2.ToString();
                        }
                            
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
                case 4:
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
                case 5:
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
                case 6:
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
                case 7:
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

                case 8:
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
                case 9:
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
                case 10:
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
                case 11:
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
                case 12:
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
                case 13:
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
                case 14:
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
                case 15:
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
                case 16:
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

        public void randomNumberNormal2()
        {
            randomNumberGenerator();
            processNumber();

            switch (processnumber)

            {
                case 1:
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

                        if (rndoperators == 4)
                        {
                            if (number3 < number4)
                            {
                                if (number4 % number3 == 0)
                                {
                                    lbl_process2.Text = number4.ToString() + " " + operators + " " + number3.ToString();
                                }

                                else
                                {
                                    lbl_process2.Text = number3.ToString() + " " + operators + " " + number3.ToString();
                                }

                            }

                            else
                            {

                                if (number3 % number4 == 0)
                                {
                                    lbl_process2.Text = number3.ToString() + " " + operators + " " + number4.ToString();
                                }

                                else
                                {

                                    lbl_process2.Text = number3.ToString() + " " + operators + " " + number3.ToString();
                                }

                            }
                        }
                        else if (number3 < number4)
                        {
                            lbl_process2.Text = number4.ToString() + " " + operators + " " + number3.ToString();
                        }

                        else
                        {
                            lbl_process2.Text = number3.ToString() + " " + operators + " " + number4.ToString();
                        }

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



                        if (number3 < number4)
                        {
                            lbl_process2.Text = number4.ToString() + " " + operators + " " + number3.ToString();
                        }

                        else
                            lbl_process2.Text = number3.ToString() + " " + operators + " " + number4.ToString();
                        break;
                    }

                case 3:
                    {
                        Random rndmath = new Random();
                        int rndoperators = rndmath.Next(1, 3);

                        if (rndoperators == 1)
                            operators = "+";


                        else if (rndoperators == 2)
                            operators = "-";



                        if (number3 < number4)
                        {
                            lbl_process2.Text = number4.ToString() + " " + operators + " " + number3.ToString();
                        }

                        else
                            lbl_process2.Text = number3.ToString() + " " + operators + " " + number4.ToString();
                        break;
                    }
                case 4:
                    {
                        Random rndmath = new Random();
                        int rndoperators = rndmath.Next(1, 4);

                        if (rndoperators == 1)
                            operators = "+";

                        else if (rndoperators == 2)
                            operators = "-";

                        else if (rndoperators == 3)
                            operators = "x";

                        if (number3 < number4)
                        {
                            lbl_process2.Text = number4.ToString() + " " + operators + " " + number3.ToString();
                        }

                        else
                            lbl_process2.Text = number3.ToString() + " " + operators + " " + number4.ToString();

                        break;
                    }
                case 5:
                    {
                        operators = "+";

                        if (number3 < number4)
                        {
                            lbl_process2.Text = number4.ToString() + " " + operators + " " + number3.ToString();
                        }

                        else
                            lbl_process2.Text = number3.ToString() + " " + operators + " " + number4.ToString();
                        break;
                    }
                case 6:
                    {
                        operators = "-";

                        if (number3 < number4)
                        {
                            lbl_process2.Text = number4.ToString() + " " + operators + " " + number3.ToString();
                        }

                        else
                            lbl_process2.Text = number3.ToString() + " " + operators + " " + number4.ToString();

                        break;
                    }
                case 7:
                    {
                        operators = "x";

                        if (number3 < number4)
                        {
                            lbl_process2.Text = number4.ToString() + " " + operators + " " + number3.ToString();
                        }

                        else
                            lbl_process2.Text = number3.ToString() + " " + operators + " " + number4.ToString();
                        break;
                    }

                case 8:
                    {
                        operators = "÷";

                        if (number3 < number4)
                        {
                            if (number2 % number1 == 0)
                            {
                                lbl_process2.Text = number4.ToString() + " " + operators + " " + number3.ToString();
                            }

                            else
                            {
                                lbl_process2.Text = number4.ToString() + " " + operators + " " + number3.ToString();
                            }


                        }


                        else
                        {

                            if (number3 % number4 == 0)
                            {
                                lbl_process2.Text = number3.ToString() + " " + operators + " " + number4.ToString();
                            }

                            else
                            {

                                lbl_process2.Text = number3.ToString() + " " + operators + " " + number3.ToString();
                            }

                        }

                        break;
                    }
                case 9:
                    {
                        Random rndmath = new Random();
                        int rndoperators = rndmath.Next(1, 3);

                        if (rndoperators == 1)
                            operators = "-";

                        else if (rndoperators == 2)
                            operators = "x";


                        if (number3 < number4)
                        {
                            lbl_process2.Text = number4.ToString() + " " + operators + " " + number3.ToString();
                        }

                        else
                            lbl_process2.Text = number3.ToString() + " " + operators + " " + number4.ToString();
                        break;
                    }
                case 10:
                    {
                        Random rndmath = new Random();
                        int rndoperators = rndmath.Next(1, 3);

                        if (rndoperators == 1)
                            operators = "+";

                        else if (rndoperators == 2)
                            operators = "x";


                        if (number3 < number4)
                        {
                            lbl_process2.Text = number4.ToString() + " " + operators + " " + number3.ToString();
                        }

                        else
                            lbl_process2.Text = number3.ToString() + " " + operators + " " + number4.ToString();
                        break;
                    }
                case 11:
                    {
                        Random rndmath = new Random();
                        int rndoperators = rndmath.Next(1, 3);

                        if (rndoperators == 1)
                            operators = "+";

                        else if (rndoperators == 2)
                            operators = "÷";



                        if (rndoperators == 2)
                        {
                            if (number3 < number4)
                            {
                                if (number4 % number3 == 0)
                                {
                                    lbl_process2.Text = number4.ToString() + " " + operators + " " + number3.ToString();
                                }

                                else
                                {
                                    lbl_process2.Text = number3.ToString() + " " + operators + " " + number3.ToString();
                                }

                            }

                            else
                            {

                                if (number3 % number4 == 0)
                                {
                                    lbl_process2.Text = number4.ToString() + " " + operators + " " + number3.ToString();
                                }

                                else
                                {

                                    lbl_process2.Text = number3.ToString() + " " + operators + " " + number3.ToString();
                                }

                            }
                        }



                        else if (number3 < number4)
                        {
                            lbl_process2.Text = number4.ToString() + " " + operators + " " + number3.ToString();
                        }

                        else
                            lbl_process2.Text = number3.ToString() + " " + operators + " " + number4.ToString();
                        break;
                    }
                case 12:
                    {
                        Random rndmath = new Random();
                        int rndoperators = rndmath.Next(1, 3);

                        if (rndoperators == 1)
                            operators = "x";

                        else if (rndoperators == 2)
                            operators = "÷";


                        if (rndoperators == 2)
                        {
                            if (number3 < number4)
                            {
                                if (number4 % number3 == 0)
                                {
                                    lbl_process2.Text = number4.ToString() + " " + operators + " " + number3.ToString();
                                }

                                else
                                {
                                    lbl_process2.Text = number3.ToString() + " " + operators + " " + number3.ToString();
                                }

                            }

                            else
                            {

                                if (number3 % number4 == 0)
                                {
                                    lbl_process2.Text = number3.ToString() + " " + operators + " " + number4.ToString();
                                }

                                else
                                {

                                    lbl_process2.Text = number3.ToString() + " " + operators + " " + number3.ToString();
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
                        int rndoperators = rndmath.Next(1, 3);

                        if (rndoperators == 1)
                            operators = "-";

                        else if (rndoperators == 2)
                            operators = "÷";


                        if (rndoperators == 2)
                        {
                            if (number3 < number4)
                            {
                                if (number4 % number3 == 0)
                                {
                                    lbl_process2.Text = number4.ToString() + " " + operators + " " + number3.ToString();
                                }

                                else
                                {
                                    lbl_process2.Text = number3.ToString() + " " + operators + " " + number3.ToString();
                                }

                            }

                            else
                            {

                                if (number3 % number4 == 0)
                                {
                                    lbl_process2.Text = number3.ToString() + " " + operators + " " + number4.ToString();
                                }

                                else
                                {

                                    lbl_process2.Text = number3.ToString() + " " + operators + " " + number3.ToString();
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
                            operators = "-";

                        else if (rndoperators == 2)
                            operators = "x";

                        else if (rndoperators == 3)
                            operators = "÷";

                        if (rndoperators == 3)
                        {
                            if (number3 < number4)
                            {
                                if (number4 % number3 == 0)
                                {
                                    lbl_process2.Text = number4.ToString() + " " + operators + " " + number3.ToString();
                                }

                                else
                                {
                                    lbl_process2.Text = number3.ToString() + " " + operators + " " + number3.ToString();
                                }

                            }

                            else
                            {

                                if (number3 % number4 == 0)
                                {
                                    lbl_process2.Text = number3.ToString() + " " + operators + " " + number4.ToString();
                                }

                                else
                                {

                                    lbl_process2.Text = number3.ToString() + " " + operators + " " + number3.ToString();
                                }

                            }
                        }
                        else if (number3 < number4)
                        {
                            lbl_process2.Text = number4.ToString() + " " + operators + " " + number3.ToString();
                        }

                        else
                            lbl_process2.Text = number3.ToString() + " " + operators + " " + number3.ToString();
                        break;
                    }
                case 15:
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
                            if (number3 < number4)
                            {
                                if (number4 % number3 == 0)
                                {
                                    lbl_process2.Text = number4.ToString() + " " + operators + " " + number3.ToString();
                                }

                                else
                                {
                                    lbl_process2.Text = number3.ToString() + " " + operators + " " + number3.ToString();
                                }

                            }

                            else
                            {

                                if (number3 % number4 == 0)
                                {
                                    lbl_process2.Text = number3.ToString() + " " + operators + " " + number4.ToString();
                                }

                                else
                                {

                                    lbl_process2.Text = number3.ToString() + " " + operators + " " + number3.ToString();
                                }

                            }
                        }

                        else if (number3 < number4)
                        {
                            lbl_process2.Text = number4.ToString() + " " + operators + " " + number3.ToString();
                        }

                        else
                            lbl_process2.Text = number3.ToString() + " " + operators + " " + number4.ToString();
                        break;
                    }
                case 16:
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
                            if (number3 < number4)
                            {
                                if (number4 % number3 == 0)
                                {
                                    lbl_process2.Text = number4.ToString() + " " + operators + " " + number3.ToString();
                                }

                                else
                                {
                                    lbl_process2.Text = number3.ToString() + " " + operators + " " + number3.ToString();
                                }

                            }

                            else
                            {

                                if (number3 % number4 == 0)
                                {
                                    lbl_process2.Text = number3.ToString() + " " + operators + " " + number4.ToString();
                                }

                                else
                                {

                                    lbl_process2.Text = number3.ToString() + " " + operators + " " + number3.ToString();
                                }

                            }
                        }
                        else if (number3 < number4)
                        {
                            lbl_process2.Text = number4.ToString() + " " + operators + " " + number3.ToString();
                        }

                        else
                            lbl_process2.Text = number3.ToString() + " " + operators + " " + number4.ToString();
                        break;
                    }

            }






        }




        // Checkbox tıklama işlemleri
        private void checkbox_1_Click(object sender, EventArgs e)
        {
            int checkbox = 1;

            switch (checkbox)
            {
                case 1:
                    {
                        checkbox_2.Checked = false;
                        checkbox_3.Checked = false;
                        checkbox_4.Checked = false;
                        checkbox_5.Checked = false;
                        checkbox_6.Checked = false;
                        checkbox_7.Checked = false;
                        checkbox_8.Checked = false;
                        break;
                    }
            }


           
        }
        private void checkbox_2_Click(object sender, EventArgs e)
        {

            int checkbox = 2;


            switch (checkbox)
            {
                case 2:
                    {
                        checkbox_1.Checked = false;
                        checkbox_3.Checked = false;
                        checkbox_4.Checked = false;
                        checkbox_5.Checked = false;
                        checkbox_6.Checked = false;
                        checkbox_7.Checked = false;
                        checkbox_8.Checked = false;
                        break;
                    }
            }
            
        }
        private void checkbox_3_Click(object sender, EventArgs e)
        {

            int checkbox = 3;

            switch (checkbox)
            {
                case 3:
                    {
                        checkbox_1.Checked = false;
                        checkbox_2.Checked = false;
                        checkbox_4.Checked = false;
                        checkbox_5.Checked = false;
                        checkbox_6.Checked = false;
                        checkbox_7.Checked = false;
                        checkbox_8.Checked = false;
                        break;
                    }
            }

        }
        private void checkbox_4_Click(object sender, EventArgs e)
        {

            int checkbox = 4;

            switch (checkbox)
            {
                case 4:
                    {
                        checkbox_1.Checked = false;
                        checkbox_2.Checked = false;
                        checkbox_3.Checked = false;
                        checkbox_5.Checked = false;
                        checkbox_6.Checked = false;
                        checkbox_7.Checked = false;
                        checkbox_8.Checked = false;
                        break;
                    }
            }

           
        }
        private void checkbox_5_Click(object sender, EventArgs e)
        {

            int checkbox = 5;


            switch (checkbox)
            {
                case 5:
                    {
                        checkbox_1.Checked = false;
                        checkbox_2.Checked = false;
                        checkbox_3.Checked = false;
                        checkbox_4.Checked = false;
                        checkbox_6.Checked = false;
                        checkbox_7.Checked = false;
                        checkbox_8.Checked = false;
                        break;
                    }
            }

        }
        private void checkbox_6_Click(object sender, EventArgs e)
        {

            int checkbox = 6;

            switch (checkbox)
            {
                case 6:
                    {
                        checkbox_1.Checked = false;
                        checkbox_2.Checked = false;
                        checkbox_3.Checked = false;
                        checkbox_4.Checked = false;
                        checkbox_5.Checked = false;
                        checkbox_7.Checked = false;
                        checkbox_8.Checked = false;
                        break;
                    }
            }

        }
        private void checkbox_7_Click(object sender, EventArgs e)
        {

            int checkbox = 7;

            switch (checkbox)
            {
                case 7:
                    {
                        checkbox_1.Checked = false;
                        checkbox_2.Checked = false;
                        checkbox_3.Checked = false;
                        checkbox_4.Checked = false;
                        checkbox_5.Checked = false;
                        checkbox_6.Checked = false;
                        checkbox_8.Checked = false;
                        break;
                    }
            }
         
        }

        private void checkbox_8_Click(object sender, EventArgs e)
        {

            int checkbox = 8;


            switch (checkbox)
            {
                case 8:
                    {
                        checkbox_1.Checked = false;
                        checkbox_2.Checked = false;
                        checkbox_3.Checked = false;
                        checkbox_4.Checked = false;
                        checkbox_5.Checked = false;
                        checkbox_6.Checked = false;
                        checkbox_7.Checked = false;
                        break;
                    }
            }

          
        }

        private void checkbox_plus_Click(object sender, EventArgs e)
        {
            
        }

        private void timer_time_Tick(object sender, EventArgs e)
        {
            timer_time.Stop();
            timer_screentime.Stop();
            checkbox_plus.Checked = false;
            checkbox_minus.Checked = false;
            checkbox_impact.Checked = false;
            checkbox_compartment.Checked = false;
            checkbox_colorplus.Checked = false;
            checkbox_colorminus.Checked = false;
            checkbox_colorimpact.Checked = false;
            checkbox_colorcompartment.Checked = false;
            lbl_process.Visible = false;
            lbl_process2.Visible = false;
            btn_stop.Visible = false;
            btn_start.Visible = true;
        }

        private void cokluislem_Load(object sender, EventArgs e)
        {
            
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            randomNumberNormal();
            randomNumberNormal2();
        }

        private void btn_start_Click(object sender, EventArgs e)
        {

            if (btn_stop.Visible == false)
            {
                btn_stop.Visible = true;
                btn_start.Visible = false;
            }

            if (checkbox_plus.Checked == false && checkbox_minus.Checked == false && checkbox_impact.Checked == false && checkbox_compartment.Checked == false && checkbox_colorplus.Checked == false && checkbox_colorminus.Checked == false && checkbox_colorimpact.Checked == false && checkbox_colorcompartment.Checked == false)
            {
                MessageBox.Show("Ayarları doğru şekilde yapınız.");
                btn_stop.Visible = false;
                btn_start.Visible = true;
                lbl_screentime.Focus();
            }

            else
            {
                randomNumberNormal();
                randomNumberNormal2();
                timer_time.Interval = (int)numeric_time.Value * 1000;
                timer_screentime.Interval = (int)numeric_screentime.Value;
                timer_time.Start();
                timer_screentime.Start();
                lbl_process.Visible = true;
                lbl_process2.Visible = true;

            }



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
            
            lbl_process.Visible = false;
            lbl_process2.Visible = false;
            lbl_process.Text = "";
          
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
