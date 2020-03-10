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


        public int number1, number2,processnumber,rndoperators;
        public string operators;
        Random rndmath = new Random();
        Random rnd = new Random();
        public void randomNumberGenerator()
        {
            int numeric1 = (int)numeric_numberrange1.Value;
            int numeric2 = (int)numeric_numberrange2.Value;
            number1 = rnd.Next(numeric1, numeric2);
            number2 = rnd.Next(numeric1, numeric2);
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
                            lbl_mustassignoperator.ForeColor = Color.Blue;


                        else if (rndoperators == 2)
                            lbl_mustassignoperator.ForeColor = Color.Green;


                        else if (rndoperators == 3)
                            lbl_mustassignoperator.ForeColor = Color.Red;

                        else if (rndoperators == 4)
                            lbl_mustassignoperator.ForeColor = Color.Yellow;


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
                            lbl_mustassignoperator.ForeColor = Color.Blue;


                        else if (rndoperators == 2)
                            lbl_mustassignoperator.ForeColor = Color.Green;



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
                            lbl_mustassignoperator.ForeColor = Color.Blue;

                        else if (rndoperators == 2)
                            lbl_mustassignoperator.ForeColor = Color.Green;

                        else if (rndoperators == 3)
                            lbl_mustassignoperator.ForeColor = Color.Red;

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
                        lbl_mustassignoperator.ForeColor = Color.Blue;

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
                        lbl_mustassignoperator.ForeColor = Color.Green;

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
                        lbl_mustassignoperator.ForeColor = Color.Red;

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
                        lbl_mustassignoperator.ForeColor = Color.Yellow;

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

                case 8:
                    {
                        rndoperators = rndmath.Next(1, 3);

                        if (rndoperators == 1)
                            lbl_mustassignoperator.ForeColor = Color.Green;

                        else if (rndoperators == 2)
                            lbl_mustassignoperator.ForeColor = Color.Red;


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
                            lbl_mustassignoperator.ForeColor = Color.Blue;

                        else if (rndoperators == 2)
                            lbl_mustassignoperator.ForeColor = Color.Red;


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
                            lbl_mustassignoperator.ForeColor = Color.Blue;

                        else if (rndoperators == 2)
                            lbl_mustassignoperator.ForeColor = Color.Yellow;


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
                case 11:
                    {
                        rndoperators = rndmath.Next(1, 3);

                        if (rndoperators == 1)
                            lbl_mustassignoperator.ForeColor = Color.Red;

                        else if (rndoperators == 2)
                            lbl_mustassignoperator.ForeColor = Color.Yellow;


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
                case 12:
                    {
                        rndoperators = rndmath.Next(1, 3);

                        if (rndoperators == 1)
                            lbl_mustassignoperator.ForeColor = Color.Green;

                        else if (rndoperators == 2)
                            lbl_mustassignoperator.ForeColor = Color.Yellow;


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
                case 13:
                    {
                        rndoperators = rndmath.Next(1, 4);

                        if (rndoperators == 1)
                            lbl_mustassignoperator.ForeColor = Color.Green;

                        else if (rndoperators == 2)
                            lbl_mustassignoperator.ForeColor = Color.Red;

                        else if (rndoperators == 3)
                            lbl_mustassignoperator.ForeColor = Color.Yellow;


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
                case 14:
                    {
                        rndoperators = rndmath.Next(1, 4);

                        if (rndoperators == 1)
                            lbl_mustassignoperator.ForeColor = Color.Blue;

                        else if (rndoperators == 2)
                            lbl_mustassignoperator.ForeColor = Color.Green;

                        else if (rndoperators == 3)
                            lbl_mustassignoperator.ForeColor = Color.Yellow;


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
                case 15:
                    {
                        rndoperators = rndmath.Next(1, 4);

                        if (rndoperators == 1)
                            lbl_mustassignoperator.ForeColor = Color.Blue;

                        else if (rndoperators == 2)
                            lbl_mustassignoperator.ForeColor = Color.Red;

                        else if (rndoperators == 3)
                            lbl_mustassignoperator.ForeColor = Color.Yellow;


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
            }


        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            
             
            if(checkbox_plus.Checked == false && checkbox_minus.Checked == false && checkbox_impact.Checked == false && checkbox_compartment.Checked == false || numeric_time.Value == 0 || numeric_screentime.Value == 0)
            {
                MessageBox.Show("Ayarları doğru şekilde yapınız.");
                btn_stop.Visible = false;
                btn_start.Visible = true;
                numeric_time.Value = 60;
                numeric_screentime.Value = 1000;
                numeric_numberrange1.Value = 1;
                numeric_numberrange2.Value = 9;
                checkbox_plus.Checked = false;
                checkbox_minus.Checked = false;
                checkbox_impact.Checked = false;
                checkbox_compartment.Checked = false;
                lbl_screentime.Focus();
            }

            
           else if (checkbox_mustasigntask.Checked==true)
            {
                panel_colortable.Visible = true;
               

            }

            else if (checkbox_gostergizle.Checked == true)
            {
                randomNumber();
                timer_time.Interval = (int)numeric_time.Value * 1000;
                timer_screentime.Interval = (int)numeric_screentime.Value;
                timer_hidetime.Interval = (int)numeric_screentime.Value;
                timer_time.Start();
                timer_hidetime.Start();
                lbl_process.Visible = true;
                btn_start.Visible = false;
                btn_stop.Visible = true;


            }

            else
            { 
                randomNumber();
                timer_time.Interval = (int)numeric_time.Value * 1000;
                timer_screentime.Interval = (int)numeric_screentime.Value;
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
            
        }

       


        private void btn_colortableok_Click(object sender, EventArgs e)
        {
            panel_colortable.Visible=false;

              if (checkbox_gostergizle.Checked == true)
            {
                randomNumberMustAssignTask();
                timer_time.Interval = (int)numeric_time.Value * 1000;
                timer_screentime.Interval = (int)numeric_screentime.Value;
                timer_hidetime.Interval = (int)numeric_screentime.Value;
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
                timer_time.Interval = (int)numeric_time.Value * 1000;
                timer_screentime.Interval = (int)numeric_screentime.Value;
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

     

       
        private void btn_back_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            if (btn_start.Visible == false)
            {
                btn_stop.Visible = false;
                btn_start.Visible = true;
            }
            numeric_numberrange1.Value = 1;
            numeric_numberrange2.Value = 9;
            numeric_screentime.Value = 1000;
            numeric_time.Value = 60;
            timer_time.Stop();
            timer_screentime.Stop();
            timer_hidetime.Stop();
            checkbox_plus.Checked = false;
            checkbox_minus.Checked = false;
            checkbox_impact.Checked = false;
            checkbox_compartment.Checked = false;
            lbl_process.Visible = false;
            lbl_process.Text = "";
            panel_mustasigntask.Visible = false;
            

        }
    }
}
