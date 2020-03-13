using System;
using System.Collections;
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
    public partial class FunctioningMemory : Form
    {
        public FunctioningMemory()
        {
            InitializeComponent();
        }
        private Guna.UI.Lib.ScrollBar.PanelScrollHelper vScrollHelper;
        public int number1, number2, number3,number1sum,number2sum,number3sum, color,color1, color2,number1colorsum,number2colorsum,number3colorsum;
        Random rnd = new Random();
        public int i = 1;
        ArrayList number1array = new ArrayList();
        ArrayList number2array = new ArrayList();
        ArrayList number3array = new ArrayList();
        ArrayList number1colorarray = new ArrayList();
        ArrayList number2colorarray = new ArrayList();
        ArrayList number3colorarray = new ArrayList();
        public void randomNumber()
        {

            int numeric1 = (int)numeric_numberrange1.Value;
            int numeric2 = (int)numeric_numberrange2.Value;

            number1 = rnd.Next(numeric1, numeric2);
            number2 = rnd.Next(numeric1, numeric2);
            number3 = rnd.Next(numeric1, numeric2);

            number1sum += number1;
            number2sum += number2;
            number3sum += number3;
            if (checkbox_twocolumns.Checked == true)
            {
                lbl_number.Text = number1.ToString();
                lbl_number2.Text = number2.ToString();
               
                if(checkbox_mustasigntask.Checked==true)
                {
                    color1 = rnd.Next(1, 3);

                    switch (color1)
                    {
                        case 1:
                            {
                                number1colorarray.Add(lbl_number.Text);
                                lbl_number.ForeColor = Color.Red;
                                color2 = 2;
                                break;

                            }

                        case 2:
                            {
                                number2colorarray.Add(lbl_number.Text);
                                lbl_number.ForeColor = Color.Green;
                                color2 = 1;
                                break;
                            }
                    }

                    switch (color2)
                    {
                        case 1:
                            {
                                number1colorarray.Add(lbl_number2.Text);
                                lbl_number2.ForeColor = Color.Red;
                                break;
                            }

                        case 2:
                            {
                                number2colorarray.Add(lbl_number2.Text);
                                lbl_number2.ForeColor = Color.Green;
                                break;
                            }
                    }




                }


            }

            else
            {
                lbl_number.Text = number1.ToString();
                lbl_number2.Text = number2.ToString();
                lbl_number3.Text = number3.ToString();

                if (checkbox_mustasigntask.Checked == true)
                {
                    color = rnd.Next(1, 7);

                       switch (color)
                        {
                            case 1:
                                {

                                    number1colorarray.Add(lbl_number.Text);
                                    number2colorarray.Add(lbl_number2.Text);
                                    number3colorarray.Add(lbl_number3.Text);
                                    lbl_number.ForeColor = Color.Red;
                                    lbl_number2.ForeColor = Color.Green;
                                    lbl_number3.ForeColor = Color.Blue;
                                    break;
                                }

                        case 2:
                            {
                                number1colorarray.Add(lbl_number2.Text);
                                number2colorarray.Add(lbl_number.Text);
                                number3colorarray.Add(lbl_number3.Text);
                                lbl_number.ForeColor = Color.Green;
                                lbl_number2.ForeColor = Color.Red;
                                lbl_number3.ForeColor = Color.Blue;
                                break;
                            }

                        case 3:
                            {
                                number1colorarray.Add(lbl_number3.Text);
                                number2colorarray.Add(lbl_number2.Text);
                                number3colorarray.Add(lbl_number.Text);
                                lbl_number.ForeColor = Color.Blue;
                                lbl_number2.ForeColor = Color.Green;
                                lbl_number3.ForeColor = Color.Red;
                                break;
                            }
                        case 4:
                            {
                                number1colorarray.Add(lbl_number.Text);
                                number2colorarray.Add(lbl_number3.Text);
                                number3colorarray.Add(lbl_number2.Text);
                                lbl_number.ForeColor = Color.Red;
                                lbl_number2.ForeColor = Color.Blue;
                                lbl_number3.ForeColor = Color.Green;
                                break;
                            }
                        case 5:
                            {
                                number1colorarray.Add(lbl_number2.Text);
                                number2colorarray.Add(lbl_number3.Text);
                                number3colorarray.Add(lbl_number.Text);
                                lbl_number.ForeColor = Color.Blue;
                                lbl_number2.ForeColor = Color.Red;
                                lbl_number3.ForeColor = Color.Green;
                                break;
                            }
                        case 6:
                            {
                                number1colorarray.Add(lbl_number3.Text);
                                number2colorarray.Add(lbl_number.Text);
                                number3colorarray.Add(lbl_number2.Text);
                                lbl_number.ForeColor = Color.Green;
                                lbl_number2.ForeColor = Color.Blue;
                                lbl_number3.ForeColor = Color.Red;
                                break;
                            }

                        }




                }

            }

            
            number1array.Add(number1);
            number2array.Add(number2);
            number3array.Add(number3);
                
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
            panel_results.Visible = false;
            number1array.Clear();
            number2array.Clear();
            number3array.Clear();
            number1colorarray.Clear();
            number2colorarray.Clear();
            number3colorarray.Clear();
            number1sum = 0;
            number2sum = 0;
            number3sum = 0;
            number1colorsum = 0;
            number2colorsum = 0;
            number3colorsum = 0;
            numeric_screentime.Value = 1000;
            numeric_numberrange1.Value = 1;
            numeric_numberrange2.Value = 9;
            numeric_numberoftransactions.Value = 5;
            checkbox_showresult.Checked = true;
            checkbox_showhide.Checked = true;
            checkbox_mustasigntask.Checked = false;
            checkbox_twocolumns.Checked = true;
            checkbox_threecolumns.Checked = false;
            lbl_number1result.Text = "";
            lbl_number2result.Text = "";
            lbl_number3result.Text = "";
            panel_process.Visible = false;
            timer_screentime.Stop();
            btn_stop.Visible = false;
            btn_start.Visible = true;
            i = 1;

        }

        private void btn_start_Click(object sender, EventArgs e)
        {

            if (numeric_numberoftransactions.Value == 0 || numeric_screentime.Value == 0)
            {
                MessageBox.Show("Ayarları doğru şekilde yapınız.");
                btn_stop.Visible = false;
                btn_start.Visible = true;
                lbl_screentime.Focus();
                numeric_numberoftransactions.Value = 5;
                numeric_screentime.Value = 1000;
                numeric_numberrange1.Value = 1;
                numeric_numberrange2.Value = 9;
               
            }

          

            else if (checkbox_showhide.Checked == true)
            {

                if (checkbox_mustasigntask.Checked != true)
                {
                    lbl_number.ForeColor = Color.Black;
                    lbl_number2.ForeColor = Color.Black;
                    lbl_number3.ForeColor = Color.Black;
                    lbl_number1result.ForeColor = Color.Black;
                    lbl_number2result.ForeColor = Color.Black;
                    lbl_number3result.ForeColor = Color.Black;
                }

                if (panel_results.Visible != true)
                {
                    
                    if (checkbox_twocolumns.Checked == true)
                    {
                        lbl_number.Visible = true;
                        lbl_number2.Visible = true;
                        lbl_number3.Visible = false;
                    }

                    else
                    {
                        lbl_number.Visible = true;
                        lbl_number2.Visible = true;
                        lbl_number3.Visible = true;
                    }



                    randomNumber();
                    timer_screentime.Interval = (int)numeric_screentime.Value;
                    timer_hidetime.Interval = (int)numeric_screentime.Value;
                    timer_hidetime.Start();
                    panel_process.Visible = true;
                    btn_stop.Visible = true;
                    btn_start.Visible = false;
                }

                else
                {
                    MessageBox.Show("İşlem yapmadan önce sonuç tablosunu kapatmalısınız.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }



              

              

            }

            else
            {
                if (checkbox_mustasigntask.Checked != true)
                {
                    lbl_number.ForeColor = Color.Black;
                    lbl_number2.ForeColor = Color.Black;
                    lbl_number3.ForeColor = Color.Black;
                    lbl_number1result.ForeColor = Color.Black;
                    lbl_number2result.ForeColor = Color.Black;
                    lbl_number3result.ForeColor = Color.Black;
                }

                if (panel_results.Visible != true)
                {
                    
                    if (checkbox_twocolumns.Checked == true)
                    {
                        lbl_number.Visible = true;
                        lbl_number2.Visible = true;
                        lbl_number3.Visible = false;
                    }

                    else
                    {
                        lbl_number.Visible = true;
                        lbl_number2.Visible = true;
                        lbl_number3.Visible = true;
                    }



                    randomNumber();
                    timer_screentime.Interval = (int)numeric_screentime.Value;
                    timer_screentime.Start();
                    panel_process.Visible = true;
                    btn_stop.Visible = true;
                    btn_start.Visible = false;
                }

                else
                {
                    MessageBox.Show("İşlem yapmadan önce sonuç tablosunu kapatmalısınız.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }




            }



        }

        private void btn_resultok_Click(object sender, EventArgs e)
        {
            gunaVScrollBar1.Visible = false;
            panel_results.Visible = false;
            number1array.Clear();
            number2array.Clear();
            number3array.Clear();
            number1colorarray.Clear();
            number2colorarray.Clear();
            number3colorarray.Clear();
            number1sum = 0;
            number2sum = 0;
            number3sum = 0;
            number1colorsum = 0;
            number2colorsum = 0;
            number3colorsum = 0;
            numeric_screentime.Value = 1000;
            numeric_numberrange1.Value = 1;
            numeric_numberrange2.Value = 9;
            numeric_numberoftransactions.Value = 5;
            checkbox_showresult.Checked = true;
            checkbox_showhide.Checked = true;
            checkbox_mustasigntask.Checked = false;
            checkbox_twocolumns.Checked = true;
            checkbox_threecolumns.Checked = false;
            lbl_number1result.Text = "";
            lbl_number2result.Text = "";
            lbl_number3result.Text = "";
            panel_process.Visible = false;
            timer_screentime.Stop();
            btn_stop.Visible = false;
            btn_start.Visible = true;
            i = 1;


        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
        }

        private void timer_hidetime_Tick(object sender, EventArgs e)
        {
            panel_process.Visible = false;
            timer_screentime.Start();
            timer_hidetime.Stop();

        }

        private void checkbox_twocolumns_Click(object sender, EventArgs e)
        {
            if (checkbox_threecolumns.Checked == false)
            {
                checkbox_twocolumns.Checked = true;
            }

            checkbox_threecolumns.Checked = false;
        }

        private void checkbox_threecolumns_Click(object sender, EventArgs e)
        {
            if (checkbox_twocolumns.Checked == false)
            {
                checkbox_threecolumns.Checked = true;
            }
            checkbox_twocolumns.Checked = false;
        }

        private void timer_screentime_Tick(object sender, EventArgs e)
        {
            if (checkbox_twocolumns.Checked == true)
            {
                lbl_number.Visible = true;
                lbl_number2.Visible = true;
                lbl_number3.Visible = false;
            }

            else
            {
                lbl_number.Visible = true;
                lbl_number2.Visible = true;
                lbl_number3.Visible = true;
            }

            if (checkbox_showhide.Checked == true)
            {

                if (i != numeric_numberoftransactions.Value)
                {
                    randomNumber();
                    panel_process.Visible = true;
                    timer_screentime.Stop();
                    timer_hidetime.Start();
                    i++;
                    
                    
                    
                }

                else
                {

              
                    if (checkbox_showresult.Checked)
                    {
                        

                        if (checkbox_mustasigntask.Checked)
                        {
                            panel_results.Visible = true;
                            if (checkbox_twocolumns.Checked == true)
                            {
                                for (int i = 0; i < numeric_numberoftransactions.Value; i++)
                                {
                                    lbl_number1result.Text = lbl_number1result.Text + "\n" + number1colorarray[i].ToString();
                                    lbl_number2result.Text = lbl_number2result.Text + "\n" + number2colorarray[i].ToString();

                                }


                                for (int i = 0; i < number1colorarray.Count; i++)
                                {
                                    number1colorsum += Convert.ToInt32(number1colorarray[i]);
                                    number2colorsum += Convert.ToInt32(number2colorarray[i]);
                                }

                                lbl_number1result.ForeColor = Color.Red;
                                lbl_number2result.ForeColor = Color.Green;
                                lbl_number1sum.Text = number1colorsum.ToString();
                                lbl_number1sum.Location = new Point(lbl_number1result.Location.X, lbl_number1result.Location.Y + lbl_number1result.Height + 10);
                                lbl_number1sum.ForeColor = Color.Red;
                                lbl_number2sum.Text = number2colorsum.ToString();
                                lbl_number2sum.Location = new Point(lbl_number2result.Location.X, lbl_number2result.Location.Y + lbl_number2result.Height + 10);
                                lbl_number2sum.ForeColor = Color.Green;
                                lbl_number3result.Visible = false;
                                lbl_number3sum.Visible = false;
                                gunaSeparator1.Location = new Point(70, lbl_number2sum.Location.Y - 15);
                                vScrollHelper = new Guna.UI.Lib.ScrollBar.PanelScrollHelper(panel_results, gunaVScrollBar1, true);
                                vScrollHelper.UpdateScrollBar();

                            }

                            else
                            {
                                for (int i = 0; i < numeric_numberoftransactions.Value; i++)
                                {
                                    lbl_number1result.Text = lbl_number1result.Text + "\n" + number1colorarray[i].ToString();
                                    lbl_number2result.Text = lbl_number2result.Text + "\n" + number2colorarray[i].ToString();
                                    lbl_number3result.Text = lbl_number3result.Text + "\n" + number3colorarray[i].ToString();
                                }


                                for (int i = 0; i < number1colorarray.Count; i++)
                                {
                                    number1colorsum += Convert.ToInt32(number1colorarray[i]);
                                    number2colorsum += Convert.ToInt32(number2colorarray[i]);
                                    number3colorsum += Convert.ToInt32(number3colorarray[i]);
                                }

                                lbl_number1result.ForeColor = Color.Red;
                                lbl_number2result.ForeColor = Color.Green;
                                lbl_number3result.ForeColor = Color.Blue;
                                lbl_number3result.Visible = true;
                                lbl_number3sum.Visible = true;
                                lbl_number1sum.Text = number1colorsum.ToString();
                                lbl_number1sum.Location = new Point(lbl_number1result.Location.X, lbl_number1result.Location.Y + lbl_number1result.Height + 10);
                                lbl_number1sum.ForeColor = Color.Red;
                                lbl_number2sum.Text = number2colorsum.ToString();
                                lbl_number2sum.Location = new Point(lbl_number2result.Location.X, lbl_number2result.Location.Y + lbl_number2result.Height + 10);
                                lbl_number2sum.ForeColor = Color.Green;
                                lbl_number3sum.Text = number3colorsum.ToString();
                                lbl_number3sum.Location = new Point(lbl_number3result.Location.X, lbl_number3result.Location.Y + lbl_number3result.Height + 10);
                                lbl_number3sum.ForeColor = Color.Blue;
                                btn_resultok.Visible = true;
                                lbl_resulttable.Visible = true;
                                gunaSeparator1.Location = new Point(70, lbl_number2sum.Location.Y - 15);
                                vScrollHelper = new Guna.UI.Lib.ScrollBar.PanelScrollHelper(panel_results, gunaVScrollBar1, true);
                                vScrollHelper.UpdateScrollBar();
                            }
                        }

                        else
                        {
                            panel_results.Visible = true;
                            if (checkbox_twocolumns.Checked == true)
                            {
                                for (int i = 0; i < numeric_numberoftransactions.Value; i++)
                                {
                                    lbl_number1result.Text = lbl_number1result.Text + "\n" + number1array[i].ToString();
                                    lbl_number2result.Text = lbl_number2result.Text + "\n" + number2array[i].ToString();

                                }

                                lbl_number1sum.Text = number1sum.ToString();
                                lbl_number1sum.Location = new Point(lbl_number1result.Location.X, lbl_number1result.Location.Y + lbl_number1result.Height + 10);
                                lbl_number1sum.ForeColor = Color.Red;
                                lbl_number2sum.Text = number2sum.ToString();
                                lbl_number2sum.Location = new Point(lbl_number2result.Location.X, lbl_number2result.Location.Y + lbl_number2result.Height + 10);
                                lbl_number2sum.ForeColor = Color.Red;
                                lbl_number3result.Visible = false;
                                lbl_number3sum.Visible = false;
                                gunaSeparator1.Location = new Point(70, lbl_number2sum.Location.Y - 15);
                                vScrollHelper = new Guna.UI.Lib.ScrollBar.PanelScrollHelper(panel_results, gunaVScrollBar1, true);
                                vScrollHelper.UpdateScrollBar();

                            }

                            else
                            {
                                for (int i = 0; i < numeric_numberoftransactions.Value; i++)
                                {
                                    lbl_number1result.Text = lbl_number1result.Text + "\n" + number1array[i].ToString();
                                    lbl_number2result.Text = lbl_number2result.Text + "\n" + number2array[i].ToString();
                                    lbl_number3result.Text = lbl_number3result.Text + "\n" + number3array[i].ToString();
                                }

                                lbl_number3result.Visible = true;
                                lbl_number3sum.Visible = true;
                                lbl_number1sum.Text = number1sum.ToString();
                                lbl_number1sum.Location = new Point(lbl_number1result.Location.X, lbl_number1result.Location.Y + lbl_number1result.Height + 10);
                                lbl_number1sum.ForeColor = Color.Red;
                                lbl_number2sum.Text = number2sum.ToString();
                                lbl_number2sum.Location = new Point(lbl_number2result.Location.X, lbl_number2result.Location.Y + lbl_number2result.Height + 10);
                                lbl_number2sum.ForeColor = Color.Red;
                                lbl_number3sum.Text = number3sum.ToString();
                                lbl_number3sum.Location = new Point(lbl_number3result.Location.X, lbl_number3result.Location.Y + lbl_number3result.Height + 10);
                                lbl_number3sum.ForeColor = Color.Red;
                                btn_resultok.Visible = true;
                                lbl_resulttable.Visible = true;
                                gunaSeparator1.Location = new Point(70, lbl_number2sum.Location.Y - 15);
                                vScrollHelper = new Guna.UI.Lib.ScrollBar.PanelScrollHelper(panel_results, gunaVScrollBar1, true);
                                vScrollHelper.UpdateScrollBar();
                            }
                        }


                    }


                    else
                    {

                    }

                  
                    numeric_screentime.Value = 1000;
                    numeric_numberrange1.Value = 1;
                    numeric_numberrange2.Value = 9;
                    numeric_numberoftransactions.Value = 5;
                    checkbox_showresult.Checked = true;
                    checkbox_showhide.Checked = true;
                    checkbox_mustasigntask.Checked = false;
                    checkbox_twocolumns.Checked = true;
                    checkbox_threecolumns.Checked = false;
                    panel_process.Visible = false;
                    timer_screentime.Stop();
                    btn_stop.Visible = false;
                    btn_start.Visible = true;
                    number1sum = 0;
                    number2sum = 0;
                    number3sum = 0;
                    number1colorsum = 0;
                    number2colorsum = 0;
                    number3colorsum = 0;
                    number1array.Clear();
                    number2array.Clear();
                    number3array.Clear();
                    number1colorarray.Clear();
                    number2colorarray.Clear();
                    number3colorarray.Clear();
                    i = 1;


                }
            }

            else
            {
                if (i != numeric_numberoftransactions.Value)
                {
                    randomNumber();
                    panel_process.Visible = true;
                    
                    i++;
                }

                else
                {
                    panel_process.Visible = false;
                    timer_screentime.Stop();
                    if (checkbox_showresult.Checked)
                    {

                        if (checkbox_mustasigntask.Checked)
                        {
                            panel_results.Visible = true;
                            if (checkbox_twocolumns.Checked == true)
                            {
                                for (int i = 0; i < numeric_numberoftransactions.Value; i++)
                                {
                                    lbl_number1result.Text = lbl_number1result.Text + "\n" + number1colorarray[i].ToString();
                                    lbl_number2result.Text = lbl_number2result.Text + "\n" + number2colorarray[i].ToString();

                                }


                                for (int i = 0; i < number1colorarray.Count; i++)
                                {
                                    number1colorsum += Convert.ToInt32(number1colorarray[i]);
                                    number2colorsum += Convert.ToInt32(number2colorarray[i]);
                                }

                                lbl_number1result.ForeColor = Color.Red;
                                lbl_number2result.ForeColor = Color.Green;
                                lbl_number1sum.Text = number1colorsum.ToString();
                                lbl_number1sum.Location = new Point(lbl_number1result.Location.X, lbl_number1result.Location.Y + lbl_number1result.Height + 10);
                                lbl_number1sum.ForeColor = Color.Red;
                                lbl_number2sum.Text = number2colorsum.ToString();
                                lbl_number2sum.Location = new Point(lbl_number2result.Location.X, lbl_number2result.Location.Y + lbl_number2result.Height + 10);
                                lbl_number2sum.ForeColor = Color.Green;
                                lbl_number3result.Visible = false;
                                lbl_number3sum.Visible = false;
                                gunaSeparator1.Location = new Point(70, lbl_number2sum.Location.Y - 15);
                                vScrollHelper = new Guna.UI.Lib.ScrollBar.PanelScrollHelper(panel_results, gunaVScrollBar1, true);
                                vScrollHelper.UpdateScrollBar();

                            }

                            else
                            {
                                for (int i = 0; i < numeric_numberoftransactions.Value; i++)
                                {
                                    lbl_number1result.Text = lbl_number1result.Text + "\n" + number1colorarray[i].ToString();
                                    lbl_number2result.Text = lbl_number2result.Text + "\n" + number2colorarray[i].ToString();
                                    lbl_number3result.Text = lbl_number3result.Text + "\n" + number3colorarray[i].ToString();
                                }


                                for (int i = 0; i < number1colorarray.Count; i++)
                                {
                                    number1colorsum += Convert.ToInt32(number1colorarray[i]);
                                    number2colorsum += Convert.ToInt32(number2colorarray[i]);
                                    number3colorsum += Convert.ToInt32(number3colorarray[i]);
                                }

                                lbl_number3result.Visible = true;
                                lbl_number3sum.Visible = true;
                                lbl_number1sum.Text = number1colorsum.ToString();
                                lbl_number1sum.Location = new Point(lbl_number1result.Location.X, lbl_number1result.Location.Y + lbl_number1result.Height + 10);
                                lbl_number1sum.ForeColor = Color.Red;
                                lbl_number2sum.Text = number2colorsum.ToString();
                                lbl_number2sum.Location = new Point(lbl_number2result.Location.X, lbl_number2result.Location.Y + lbl_number2result.Height + 10);
                                lbl_number2sum.ForeColor = Color.Green;
                                lbl_number3sum.Text = number3colorsum.ToString();
                                lbl_number3sum.Location = new Point(lbl_number3result.Location.X, lbl_number3result.Location.Y + lbl_number3result.Height + 10);
                                lbl_number3sum.ForeColor = Color.Blue;
                                btn_resultok.Visible = true;
                                lbl_resulttable.Visible = true;
                                gunaSeparator1.Location = new Point(70, lbl_number2sum.Location.Y - 15);
                                vScrollHelper = new Guna.UI.Lib.ScrollBar.PanelScrollHelper(panel_results, gunaVScrollBar1, true);
                                vScrollHelper.UpdateScrollBar();
                            }
                        }

                        else
                        {
                            panel_results.Visible = true;
                            if (checkbox_twocolumns.Checked == true)
                            {
                                for (int i = 0; i < numeric_numberoftransactions.Value; i++)
                                {
                                    lbl_number1result.Text = lbl_number1result.Text + "\n" + number1array[i].ToString();
                                    lbl_number2result.Text = lbl_number2result.Text + "\n" + number2array[i].ToString();

                                }

                                lbl_number1sum.Text = number1sum.ToString();
                                lbl_number1sum.Location = new Point(lbl_number1result.Location.X, lbl_number1result.Location.Y + lbl_number1result.Height + 10);
                                lbl_number1sum.ForeColor = Color.Red;
                                lbl_number2sum.Text = number2sum.ToString();
                                lbl_number2sum.Location = new Point(lbl_number2result.Location.X, lbl_number2result.Location.Y + lbl_number2result.Height + 10);
                                lbl_number2sum.ForeColor = Color.Red;
                                lbl_number3result.Visible = false;
                                lbl_number3sum.Visible = false;
                                gunaSeparator1.Location = new Point(70, lbl_number2sum.Location.Y - 15);
                                vScrollHelper = new Guna.UI.Lib.ScrollBar.PanelScrollHelper(panel_results, gunaVScrollBar1, true);
                                vScrollHelper.UpdateScrollBar();

                            }

                            else
                            {
                                for (int i = 0; i < numeric_numberoftransactions.Value; i++)
                                {
                                    lbl_number1result.Text = lbl_number1result.Text + "\n" + number1array[i].ToString();
                                    lbl_number2result.Text = lbl_number2result.Text + "\n" + number2array[i].ToString();
                                    lbl_number3result.Text = lbl_number3result.Text + "\n" + number3array[i].ToString();
                                }

                                lbl_number3result.Visible = true;
                                lbl_number3sum.Visible = true;
                                lbl_number1sum.Text = number1sum.ToString();
                                lbl_number1sum.Location = new Point(lbl_number1result.Location.X, lbl_number1result.Location.Y + lbl_number1result.Height + 10);
                                lbl_number1sum.ForeColor = Color.Red;
                                lbl_number2sum.Text = number2sum.ToString();
                                lbl_number2sum.Location = new Point(lbl_number2result.Location.X, lbl_number2result.Location.Y + lbl_number2result.Height + 10);
                                lbl_number2sum.ForeColor = Color.Red;
                                lbl_number3sum.Text = number3sum.ToString();
                                lbl_number3sum.Location = new Point(lbl_number3result.Location.X, lbl_number3result.Location.Y + lbl_number3result.Height + 10);
                                lbl_number3sum.ForeColor = Color.Red;
                                btn_resultok.Visible = true;
                                lbl_resulttable.Visible = true;
                                gunaSeparator1.Location = new Point(70, lbl_number2sum.Location.Y - 15);
                                vScrollHelper = new Guna.UI.Lib.ScrollBar.PanelScrollHelper(panel_results, gunaVScrollBar1, true);
                                vScrollHelper.UpdateScrollBar();
                            }
                        }


                    }


                    else
                    {
                        numeric_screentime.Value = 1000;
                        numeric_numberrange1.Value = 1;
                        numeric_numberrange2.Value = 9;
                        numeric_numberoftransactions.Value = 5;
                        checkbox_showresult.Checked = true;
                        checkbox_showhide.Checked = true;
                        checkbox_mustasigntask.Checked = false;
                        checkbox_twocolumns.Checked = true;
                        checkbox_threecolumns.Checked = false;
                        panel_process.Visible = false;
                        timer_screentime.Stop();
                        btn_stop.Visible = false;
                        btn_start.Visible = true;
                        number1sum = 0;
                        number2sum = 0;
                        number3sum = 0;
                        number1array.Clear();
                        number2array.Clear();
                        number3array.Clear();
                        number1colorarray.Clear();
                        number2colorarray.Clear();
                        number3colorarray.Clear();
                        i = 1;
                    }

                  

                }

            }

            

        }

        private void FunctioningMemory_Load(object sender, EventArgs e)
        {

        }
    }
}
