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

            int numeric1 = (int)numeric_numberrange1.Value;
            int numeric2 = (int)numeric_numberrange2.Value;
            
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

        public void randomNumber2()
        {
            int numeric1 = (int)numeric_numberrange1.Value;
            int numeric2 = (int)numeric_numberrange2.Value;  
            
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


        public void randomNumberMustAssignTask()
        {
            int numeric1 = (int)numeric_numberrange1.Value;
            int numeric2 = (int)numeric_numberrange2.Value;
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
                            lbl_mustassignnumber.ForeColor = Color.Red;


                        else if (rndoperators == 2)
                            lbl_mustassignnumber.ForeColor = Color.Blue;


                        else if (rndoperators == 3)
                            lbl_mustassignnumber.ForeColor = Color.Yellow;

                        else if (rndoperators == 4)
                            lbl_mustassignnumber.ForeColor = Color.Green;


                        if (rndoperators == 4)
                        {
                            if (number1 < number2)
                            {
                                if (number2 % number1 == 0)
                                    lbl_mustassignnumber.Text = number2.ToString() + " " + "●" + " " + number1.ToString() + "=";
                           
                                else
                                    lbl_mustassignnumber.Text = number2.ToString() + " " +  "●" + " " + number2.ToString() + "=";

                            }

                            else
                            {

                                if (number1 % number2 == 0)
                                    lbl_mustassignnumber.Text = number1.ToString() + " " +  "●" + " " + number2.ToString() + "=";

                                else
                                    lbl_mustassignnumber.Text = number1.ToString() + " " +  "●" + " " + number1.ToString() + "=";


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
                            lbl_mustassignnumber.ForeColor = Color.Red;


                        else if (rndoperators == 2)
                            lbl_mustassignnumber.ForeColor = Color.Blue;



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
                            lbl_mustassignnumber.ForeColor = Color.Red;

                        else if (rndoperators == 2)
                            lbl_mustassignnumber.ForeColor = Color.Blue;

                        else if (rndoperators == 3)
                            lbl_mustassignnumber.ForeColor = Color.Yellow;

                        if (number1 < number2)
                            lbl_mustassignnumber.Text = number2.ToString() + " " + "●" + " " + number1.ToString() + "=";
  
                        else
                            lbl_mustassignnumber.Text = number1.ToString() + " " + "●" + " " + number2.ToString() + "=";
                       
                        break;
                    }
                case 4:
                    {
                        lbl_mustassignnumber.ForeColor = Color.Red;

                        if (number1 < number2)
                            lbl_mustassignnumber.Text = number2.ToString() + " " + "●" + " " + number1.ToString() + "=";  

                        else
                            lbl_mustassignnumber.Text = number1.ToString() + " " + "●" + " " + number2.ToString() + "=";
                  
                        break;
                    }
                case 5:
                    {
                        lbl_mustassignnumber.ForeColor = Color.Blue;

                        if (number1 < number2)
                            lbl_mustassignnumber.Text = number2.ToString() + " " + "●" + " " + number1.ToString() + "=";
                      
                        else
                            lbl_mustassignnumber.Text = number1.ToString() + " " + "●" + " " + number2.ToString() + "=";
          
                        break;
                    }
                case 6:
                    {
                        lbl_mustassignnumber.ForeColor = Color.Yellow;

                        if (number1 < number2)
                            lbl_mustassignnumber.Text = number2.ToString() + " " + "●" + " " + number1.ToString() + "=";

                        else
                            lbl_mustassignnumber.Text = number1.ToString() + " " + "●" + " " + number2.ToString() + "=";
                
                        break;
                    }
                case 7:
                    {

                        lbl_mustassignnumber.ForeColor = Color.Green;


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
                            lbl_mustassignnumber.ForeColor = Color.Blue;

                        else if (rndoperators == 2)
                            lbl_mustassignnumber.ForeColor = Color.Yellow;


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
                            lbl_mustassignnumber.ForeColor = Color.Red;

                        else if (rndoperators == 2)
                            lbl_mustassignnumber.ForeColor = Color.Yellow;


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
                            lbl_mustassignnumber.ForeColor = Color.Red;

                        else if (rndoperators == 2)
                            lbl_mustassignnumber.ForeColor = Color.Green;


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
                            lbl_mustassignnumber.ForeColor = Color.Yellow;

                        else if (rndoperators == 2)
                            lbl_mustassignnumber.ForeColor = Color.Green;


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
                            lbl_mustassignnumber.ForeColor = Color.Blue;

                        else if (rndoperators == 2)
                            lbl_mustassignnumber.ForeColor = Color.Green;



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
                            lbl_mustassignnumber.ForeColor = Color.Blue;

                        else if (rndoperators == 2)
                            lbl_mustassignnumber.ForeColor = Color.Yellow;

                        else if (rndoperators == 3)
                            lbl_mustassignnumber.ForeColor = Color.Green;


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
                            lbl_mustassignnumber.ForeColor = Color.Red;

                        else if (rndoperators == 2)
                            lbl_mustassignnumber.ForeColor = Color.Blue;

                        else if (rndoperators == 3)
                            lbl_mustassignnumber.ForeColor = Color.Green;


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
                            lbl_mustassignnumber.ForeColor = Color.Red;

                        else if (rndoperators == 2)
                            lbl_mustassignnumber.ForeColor = Color.Yellow;

                        else if (rndoperators == 3)
                            lbl_mustassignnumber.ForeColor = Color.Green;


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

        public void randomNumberMustAssignTask2()
        {
            int numeric1 = (int)numeric_numberrange1.Value;
            int numeric2 = (int)numeric_numberrange2.Value;
            
            number3 = rnd.Next(numeric1, numeric2);
            number4 = rnd.Next(numeric1, numeric2);

            processNumber();
            switch (processnumber)
            {
                case 1:
                    {
                        
                         rndoperators2 = rndmath.Next(1, 5);

                        if (rndoperators2 == 1)
                            lbl_mustassignnumber2.ForeColor = Color.Red;


                        else if (rndoperators2 == 2)
                            lbl_mustassignnumber2.ForeColor = Color.Blue;


                        else if (rndoperators2 == 3)
                            lbl_mustassignnumber2.ForeColor = Color.Yellow;

                        else if (rndoperators2 == 4)
                            lbl_mustassignnumber2.ForeColor = Color.Green;


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
                            lbl_mustassignnumber2.ForeColor = Color.Red;


                        else if (rndoperators2 == 2)
                            lbl_mustassignnumber2.ForeColor = Color.Blue;



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
                            lbl_mustassignnumber2.ForeColor = Color.Red;

                        else if (rndoperators2 == 2)
                            lbl_mustassignnumber2.ForeColor = Color.Blue;

                        else if (rndoperators2 == 3)
                            lbl_mustassignnumber2.ForeColor = Color.Yellow;

                        if (number3 < number4)
                            lbl_mustassignnumber2.Text = number4.ToString() + " " + "●" + " " + number3.ToString() + "=";
                        
                        else
                            lbl_mustassignnumber2.Text = number3.ToString() + " " + "●" + " " + number4.ToString() + "=";
                         
                        break;
                    }
                case 4:
                    {
                        lbl_mustassignnumber2.ForeColor = Color.Red;

                        if (number3 < number4)
                            lbl_mustassignnumber2.Text = number4.ToString() + " " + "●" + " " + number3.ToString() + "=";
                        
                        else
                            lbl_mustassignnumber2.Text = number3.ToString() + " " + "●" + " " + number4.ToString() + "=";
                         
                        break;
                    }
                case 5:
                    {
                        lbl_mustassignnumber2.ForeColor = Color.Blue;

                        if (number3 < number4)
                            lbl_mustassignnumber2.Text = number4.ToString() + " " + "●" + " " + number3.ToString() + "=";
                          
                        else
                            lbl_mustassignnumber2.Text = number3.ToString() + " " + "●" + " " + number4.ToString() + "=";
                          
                        break;
                    }
                case 6:
                    {
                        lbl_mustassignnumber2.ForeColor = Color.Yellow;

                        if (number3 < number4)
                            lbl_mustassignnumber2.Text = number4.ToString() + " " + "●" + " " + number3.ToString() + "=";
                       
                        else
                            lbl_mustassignnumber2.Text = number3.ToString() + " " + "●" + " " + number4.ToString() + "=";
                          
                        break;
                    }
                case 7:
                    {

                        lbl_mustassignnumber2.ForeColor = Color.Green;


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
                            lbl_mustassignnumber2.ForeColor = Color.Blue;

                        else if (rndoperators == 2)
                            lbl_mustassignnumber2.ForeColor = Color.Yellow;


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
                            lbl_mustassignnumber2.ForeColor = Color.Red;

                        else if (rndoperators2 == 2)
                            lbl_mustassignnumber2.ForeColor = Color.Yellow;


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
                            lbl_mustassignnumber2.ForeColor = Color.Red;

                        else if (rndoperators2 == 2)
                            lbl_mustassignnumber2.ForeColor = Color.Green;



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
                            lbl_mustassignnumber2.ForeColor = Color.Yellow;

                        else if (rndoperators2 == 2)
                            lbl_mustassignnumber2.ForeColor = Color.Green;


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
                            lbl_mustassignnumber2.ForeColor = Color.Blue;

                        else if (rndoperators2 == 2)
                            lbl_mustassignnumber2.ForeColor = Color.Green;


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
                            lbl_mustassignnumber2.ForeColor = Color.Blue;

                        else if (rndoperators2 == 2)
                            lbl_mustassignnumber2.ForeColor = Color.Yellow;

                        else if (rndoperators2 == 3)
                            lbl_mustassignnumber2.ForeColor = Color.Yellow;


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
                            lbl_mustassignnumber2.ForeColor = Color.Red;

                        else if (rndoperators2 == 2)
                            lbl_mustassignnumber2.ForeColor = Color.Blue;

                        else if (rndoperators2 == 3)
                            lbl_mustassignnumber2.ForeColor = Color.Green;


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
                            lbl_mustassignnumber2.ForeColor = Color.Red;

                        else if (rndoperators2 == 2)
                            lbl_mustassignnumber2.ForeColor = Color.Yellow;

                        else if (rndoperators2 == 3)
                            lbl_mustassignnumber2.ForeColor = Color.Green;


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


        // Checkbox tıklama işlemleri
        private void checkbox_1_Click(object sender, EventArgs e)
        {

            if(checkbox_2.Checked==false || checkbox_3.Checked == false || checkbox_4.Checked == false || checkbox_5.Checked == false || checkbox_6.Checked == false || checkbox_7.Checked == false || checkbox_8.Checked == false)
            {
                checkbox_1.Checked = true;
            }

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
            if (checkbox_1.Checked == false || checkbox_3.Checked == false || checkbox_4.Checked == false || checkbox_5.Checked == false || checkbox_6.Checked == false || checkbox_7.Checked == false || checkbox_8.Checked == false)
            {
                checkbox_2.Checked = true;
            }
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
            if (checkbox_1.Checked == false || checkbox_2.Checked == false || checkbox_4.Checked == false || checkbox_5.Checked == false || checkbox_6.Checked == false || checkbox_7.Checked == false || checkbox_8.Checked == false)
            {
                checkbox_3.Checked = true;
            }
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
            if (checkbox_1.Checked == false || checkbox_2.Checked == false || checkbox_3.Checked == false || checkbox_5.Checked == false || checkbox_6.Checked == false || checkbox_7.Checked == false || checkbox_8.Checked == false)
            {
                checkbox_4.Checked = true;
            }
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
            if (checkbox_1.Checked == false || checkbox_2.Checked == false || checkbox_3.Checked == false || checkbox_4.Checked == false || checkbox_6.Checked == false || checkbox_7.Checked == false || checkbox_8.Checked == false)
            {
                checkbox_5.Checked = true;
            }
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
            if (checkbox_1.Checked == false || checkbox_2.Checked == false || checkbox_3.Checked == false || checkbox_4.Checked == false || checkbox_5.Checked == false || checkbox_7.Checked == false || checkbox_8.Checked == false)
            {
                checkbox_6.Checked = true;
            }
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
            if (checkbox_1.Checked == false || checkbox_2.Checked == false || checkbox_3.Checked == false || checkbox_4.Checked == false || checkbox_5.Checked == false || checkbox_6.Checked == false || checkbox_8.Checked == false)
            {
                checkbox_7.Checked = true;
            }
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
            if (checkbox_1.Checked == false || checkbox_2.Checked == false || checkbox_3.Checked == false || checkbox_4.Checked == false || checkbox_5.Checked == false || checkbox_6.Checked == false || checkbox_7.Checked == false)
            {
                checkbox_8.Checked = true;
            }
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

        private void timer_hidetime_Tick(object sender, EventArgs e)
        {
            panel_process.Visible = false;
            panel_mustasigntask.Visible = false;
            panel_mustasigntask2.Visible = false;
            timer_screentime.Start();
            timer_hidetime.Stop();

         

        }

        private void btn_colortableok_Click(object sender, EventArgs e)
        {
            panel_colortable.Visible = false;

            if (checkbox_gostergizle.Checked == true)
            {
                randomNumberMustAssignTask();
                randomNumberMustAssignTask2();
                
                timer_screentime.Interval = (int)numeric_screentime.Value;
                timer_hidetime.Interval = (int)numeric_screentime.Value;
                timer_hidetime.Start();
                panel_mustasigntask.Visible = true;
                panel_mustasigntask2.Visible = true;
                btn_stop.Visible = true;
                btn_start.Visible = false;

            }

            else
            {
                randomNumberMustAssignTask();
                randomNumberMustAssignTask2();
                timer_screentime.Interval = (int)numeric_screentime.Value;
                timer_screentime.Start();
                panel_mustasigntask.Visible = true;
                panel_mustasigntask2.Visible = true;
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
                        if (i != numeric_numberoftransactions.Value)
                        {
                            panel_mustasigntask.Visible = true;
                            panel_mustasigntask2.Visible = true;
                            randomNumberMustAssignTask();
                            randomNumberMustAssignTask2();
                            timer_screentime.Stop();
                            timer_hidetime.Start();
                            i++;
                        }

                        else
                        {

                            timer_screentime.Stop();
                            checkbox_plus.Checked = false;
                            checkbox_minus.Checked = false;
                            checkbox_impact.Checked = false;
                            checkbox_compartment.Checked = false;
                            panel_mustasigntask.Visible = false;
                            panel_mustasigntask2.Visible = false;
                            btn_stop.Visible = false;
                            btn_start.Visible = true;
                            i = 1;
                        }
                        
                    }

                    else
                    {
                        if (i != numeric_numberoftransactions.Value)
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
                            checkbox_plus.Checked = false;
                            checkbox_minus.Checked = false;
                            checkbox_impact.Checked = false;
                            checkbox_compartment.Checked = false;
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
                    panel_mustasigntask2.Visible = true;
                }

                else
                {
                    if (i != numeric_numberoftransactions.Value)
                    {
                        randomNumber();
                        randomNumber2();
                        i++;
                        panel_process.Visible = true;
                    }

                    else
                    {
                        timer_screentime.Stop();
                        checkbox_plus.Checked = false;
                        checkbox_minus.Checked = false;
                        checkbox_impact.Checked = false;
                        checkbox_compartment.Checked = false;
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


            if (checkbox_plus.Checked == false && checkbox_minus.Checked == false && checkbox_impact.Checked == false && checkbox_compartment.Checked == false || numeric_numberoftransactions.Value == 0 || numeric_screentime.Value == 0)
            {
                MessageBox.Show("Ayarları doğru şekilde yapınız.");
                btn_stop.Visible = false;
                btn_start.Visible = true;
                lbl_screentime.Focus();
                numeric_numberoftransactions.Value = 15;
                numeric_screentime.Value = 1000;
                numeric_numberrange1.Value = 1;
                numeric_numberrange2.Value = 9;
                checkbox_plus.Checked = false;
                checkbox_minus.Checked = false;
                checkbox_impact.Checked = false;
                checkbox_compartment.Checked = false;


            }


            else if (checkbox_mustasigntask.Checked == true)
            {
                panel_colortable.Visible = true;
                
               
            }

            else if (checkbox_gostergizle.Checked == true)
            {
                randomNumber();
                randomNumber2();
                timer_screentime.Interval = (int)numeric_screentime.Value;
                timer_hidetime.Interval = (int)numeric_screentime.Value;
                timer_hidetime.Start();
                panel_process.Visible = true;
                btn_stop.Visible = true;
                btn_start.Visible = false;


            }

            else
            {
                randomNumber();
                randomNumber2();
                timer_screentime.Interval = (int)numeric_screentime.Value;
                timer_screentime.Start();
                panel_process.Visible = true;
                btn_stop.Visible = true;
                btn_start.Visible = false;

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

            checkbox_plus.Checked = false;
            checkbox_minus.Checked = false;
            checkbox_impact.Checked = false;
            checkbox_compartment.Checked = false;
            panel_process.Visible = false;
            lbl_process.Text = "";
            lbl_process2.Text = "";
            panel_mustasigntask.Visible = false;
            panel_mustasigntask2.Visible = false;

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
