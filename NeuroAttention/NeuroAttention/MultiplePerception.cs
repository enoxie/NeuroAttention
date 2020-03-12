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
    public partial class MultiplePerception : Form
    {
        public MultiplePerception()
        {
            InitializeComponent();
        }

       
        public int numberoflines, numberofcolumns, shapenumber, randomshapecolor, randomshapecolor2, randomshapecount, randomshapenumber, randomshapenumber2,
        randomshapenumber3, randomshapenumber4, randomshapenumber5, randomshapenumber6, randomshapenumber7, randomshapenumber8, randomshapenumber9, randomshapenumber10;
        public string shape, shape2, shape3, shape4;


        private void checkbox_shape1_Click(object sender, EventArgs e)
        {
            if(checkbox_shape2.Checked==false || checkbox_shape3.Checked == false || checkbox_shape4.Checked == false)
            {
                checkbox_shape1.Checked = true;
            }
            
           
            checkbox_shape2.Checked = false;
            checkbox_shape3.Checked = false;
            checkbox_shape4.Checked = false;
        }

        private void checkbox_shape2_Click(object sender, EventArgs e)
        {
            if (checkbox_shape1.Checked == false || checkbox_shape3.Checked == false || checkbox_shape4.Checked == false)
            {
                checkbox_shape2.Checked = true;
            }

            checkbox_shape1.Checked = false;
            checkbox_shape3.Checked = false;
            checkbox_shape4.Checked = false;
        }

        private void checkbox_shape3_Click(object sender, EventArgs e)
        {
            if (checkbox_shape1.Checked == false || checkbox_shape2.Checked == false || checkbox_shape4.Checked == false)
            {
                checkbox_shape3.Checked = true;
            }

            checkbox_shape1.Checked = false;
            checkbox_shape2.Checked = false;
            checkbox_shape4.Checked = false;
        }

        private void checkbox_shape4_Click(object sender, EventArgs e)
        {
            if (checkbox_shape1.Checked == false || checkbox_shape2.Checked == false || checkbox_shape3.Checked == false)
            {
                checkbox_shape4.Checked = true;
            }

            checkbox_shape1.Checked = false;
            checkbox_shape2.Checked = false;
            checkbox_shape3.Checked = false;
        }

        
        private void btn_resultok_Click(object sender, EventArgs e)
        {
            bunifuCustomDataGrid1.Rows.Clear();
            bunifuCustomDataGrid1.Visible = false;
            btn_resultok.Visible = false;
            a =0;
        }

       

        private void btn_logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            
        }

        private void bunifuCustomDataGrid1_SelectionChanged(object sender, EventArgs e)
        {
            bunifuCustomDataGrid1.ClearSelection();
        }

        
        public int i = 1;
        public int a = 0;
        public string[] shapearray = new string[5];
        
        
        Random rnd = new Random();

        public void shapeGenerator()
        {
            numberoflines = (int)numeric_numberoflines.Value;
            numberofcolumns = (int)numeric_numberofcolumns.Value;
            
        }

        public void randomShapeGenerator()
        {
            
        }

        public void shapeStyle()
        {
                shapearray[1] = "♥";
                shapearray[2] = "☪";
                shapearray[3] = "✿";
                shapearray[4] = "☂";
        }

      

        public void shapeNumber()
        {
            if (checkbox_shape1.Checked==true)
                shapenumber = 1;

            else if (checkbox_shape2.Checked == true)
                shapenumber = 2;

            else if (checkbox_shape3.Checked == true)
                shapenumber = 3;

            else if (checkbox_shape4.Checked == true)
                shapenumber = 4;

            else { }

        }


        public void randomShape()
        {
        
            
            shapeGenerator();
            shapeNumber();

            numberofcolumns = rnd.Next(1, (int)numeric_numberofcolumns.Value+1);
            switch (numberofcolumns)
            {
                case 1:
                    {

                        randomshapecolor = rnd.Next(1, 5);
                        if (randomshapecolor == 1)
                        {
                            lbl_shape.ForeColor = Color.Red;
                            
                        }
                        else if (randomshapecolor == 2)
                        {
                            lbl_shape.ForeColor = Color.Blue;
                           
                        }
                        else if (randomshapecolor == 3)
                        {
                            lbl_shape.ForeColor = Color.Yellow;
                            
                        }
                        else if (randomshapecolor == 4)
                        {
                            lbl_shape.ForeColor = Color.Green;
                            
                        }
                        switch (shapenumber)
                        {
                            case 1:
                                {

                                    randomshapenumber = rnd.Next(1, 1);
                                    lbl_shape.Visible = true;
                                    lbl_shape.Text = shapearray[randomshapenumber];

                                    break;
                                }
                            case 2:
                                {
                                    randomshapenumber = rnd.Next(1, 3);
                                    lbl_shape.Visible = true;
                                    lbl_shape.Text = shapearray[randomshapenumber];
                                    break;
                                }
                            case 3:
                                {
                                    randomshapenumber = rnd.Next(1, 4);
                                    lbl_shape.Visible = true;
                                    lbl_shape.Text = shapearray[randomshapenumber];
                                    break;
                                }
                            case 4:
                                {
                                    randomshapenumber = rnd.Next(1, 5);
                                    lbl_shape.Visible = true;
                                    lbl_shape.Text = shapearray[randomshapenumber];
                                    break;
                                }
                           

                        }




                        break;
                    }
                case 2:
                    {

                        randomshapecolor = rnd.Next(1, 5);
                        
                        if (randomshapecolor == 1)
                        {
                            lbl_shape.ForeColor = Color.Red;
                        }
                        else if (randomshapecolor == 2)
                        {
                            lbl_shape.ForeColor = Color.Blue;
                        }
                        else if (randomshapecolor == 3)
                        {
                            lbl_shape.ForeColor = Color.Yellow;
                        }
                        else if (randomshapecolor == 4)
                        {
                            lbl_shape.ForeColor = Color.Green;
                        }
                        
                        switch (shapenumber)
                        {
                            case 1:
                                {

                                    randomshapenumber = rnd.Next(1, 1);
                                    randomshapenumber2 = rnd.Next(1, 1);
                                    lbl_shape.Visible = true;
                                    lbl_shape.Text = shapearray[randomshapenumber] + shapearray[randomshapenumber2];
                                    break;
                                }
                            case 2:
                                {
                                    randomshapenumber = rnd.Next(1, 3);
                                    randomshapenumber2 = rnd.Next(1, 3);
                                    lbl_shape.Visible = true; 
                                    lbl_shape.Text = shapearray[randomshapenumber] + shapearray[randomshapenumber2];
                                    break;
                                }
                            case 3:
                                {
                                    randomshapenumber = rnd.Next(1, 4);
                                    randomshapenumber2 = rnd.Next(1, 4);
                                    lbl_shape.Visible = true;
                                    lbl_shape.Text = shapearray[randomshapenumber] + shapearray[randomshapenumber2];
                                    break;
                                }
                            case 4:
                                {
                                    randomshapenumber = rnd.Next(1, 5);
                                    randomshapenumber2 = rnd.Next(1, 5);
                                    lbl_shape.Visible = true;
                                    lbl_shape.Text = shapearray[randomshapenumber] + shapearray[randomshapenumber2];
                                    break;
                                }

                        }
                        break;
                    }
                case 3:
                    {

                        randomshapecolor = rnd.Next(1, 5);

                        if (randomshapecolor == 1)
                        {
                            lbl_shape.ForeColor = Color.Red;
                        }
                        else if (randomshapecolor == 2)
                        {
                            lbl_shape.ForeColor = Color.Blue;
                        }
                        else if (randomshapecolor == 3)
                        {
                            lbl_shape.ForeColor = Color.Yellow;
                        }
                        else if (randomshapecolor == 4)
                        {
                            lbl_shape.ForeColor = Color.Green;
                        }

                        switch (shapenumber)
                        {
                            case 1:
                                {

                                    randomshapenumber = rnd.Next(1, 1);
                                    randomshapenumber2 = rnd.Next(1, 1);
                                    randomshapenumber3 = rnd.Next(1, 1);
                                    lbl_shape.Visible = true;
                                    lbl_shape.Text = shapearray[randomshapenumber] + shapearray[randomshapenumber2] + shapearray[randomshapenumber3];
                                    break;
                                }
                            case 2:
                                {
                                    randomshapenumber = rnd.Next(1, 3);
                                    randomshapenumber2 = rnd.Next(1, 3);
                                    randomshapenumber3 = rnd.Next(1, 3);
                                    lbl_shape.Visible = true;
                                    lbl_shape.Text = shapearray[randomshapenumber] + shapearray[randomshapenumber2] + shapearray[randomshapenumber3];
                                    break;
                                }
                            case 3:
                                {
                                    randomshapenumber = rnd.Next(1, 4);
                                    randomshapenumber2 = rnd.Next(1, 4);
                                    randomshapenumber3 = rnd.Next(1, 4);
                                    lbl_shape.Visible = true;
                                    lbl_shape.Text = shapearray[randomshapenumber] + shapearray[randomshapenumber2] + shapearray[randomshapenumber3];
                                    break;
                                }
                            case 4:
                                {
                                    randomshapenumber = rnd.Next(1, 5);
                                    randomshapenumber2 = rnd.Next(1, 5);
                                    randomshapenumber3 = rnd.Next(1, 5);
                                    lbl_shape.Visible = true;
                                    lbl_shape.Text = shapearray[randomshapenumber] + shapearray[randomshapenumber2] + shapearray[randomshapenumber3];
                                    break;
                                }

                        }
                        break;
                    }
                case 4:
                    {

                        randomshapecolor = rnd.Next(1, 5);

                        if (randomshapecolor == 1)
                        {
                            lbl_shape.ForeColor = Color.Red;
                        }
                        else if (randomshapecolor == 2)
                        {
                            lbl_shape.ForeColor = Color.Blue;
                        }
                        else if (randomshapecolor == 3)
                        {
                            lbl_shape.ForeColor = Color.Yellow;
                        }
                        else if (randomshapecolor == 4)
                        {
                            lbl_shape.ForeColor = Color.Green;
                        }

                        switch (shapenumber)
                        {
                            case 1:
                                {

                                    randomshapenumber = rnd.Next(1, 1);
                                    randomshapenumber2 = rnd.Next(1, 1);
                                    randomshapenumber3 = rnd.Next(1, 1);
                                    randomshapenumber4 = rnd.Next(1, 1);
                                    lbl_shape.Visible = true;
                                    lbl_shape.Text = shapearray[randomshapenumber] + shapearray[randomshapenumber2] + shapearray[randomshapenumber3] + shapearray[randomshapenumber4];
                                    break;
                                }
                            case 2:
                                {
                                    randomshapenumber = rnd.Next(1, 3);
                                    randomshapenumber2 = rnd.Next(1, 3);
                                    randomshapenumber3 = rnd.Next(1, 3);
                                    randomshapenumber4 = rnd.Next(1, 3);
                                    lbl_shape.Visible = true;
                                    lbl_shape.Text = shapearray[randomshapenumber] + shapearray[randomshapenumber2] + shapearray[randomshapenumber3] + shapearray[randomshapenumber4];
                                    break;
                                }
                            case 3:
                                {
                                    randomshapenumber = rnd.Next(1, 4);
                                    randomshapenumber2 = rnd.Next(1, 4);
                                    randomshapenumber3 = rnd.Next(1, 4);
                                    randomshapenumber4 = rnd.Next(1, 4);
                                    lbl_shape.Visible = true;
                                    lbl_shape.Text = shapearray[randomshapenumber] + shapearray[randomshapenumber2] + shapearray[randomshapenumber3] + shapearray[randomshapenumber4];
                                    break;
                                }
                            case 4:
                                {
                                    randomshapenumber = rnd.Next(1, 5);
                                    randomshapenumber2 = rnd.Next(1, 5);
                                    randomshapenumber3 = rnd.Next(1, 5);
                                    randomshapenumber4 = rnd.Next(1, 5);
                                    lbl_shape.Visible = true;
                                    lbl_shape.Text = shapearray[randomshapenumber] + shapearray[randomshapenumber2] + shapearray[randomshapenumber3] + shapearray[randomshapenumber4];
                                    break;
                                }

                        }
                        break;
                    }
                case 5:
                    {

                        randomshapecolor = rnd.Next(1, 5);

                        if (randomshapecolor == 1)
                        {
                            lbl_shape.ForeColor = Color.Red;
                        }
                        else if (randomshapecolor == 2)
                        {
                            lbl_shape.ForeColor = Color.Blue;
                        }
                        else if (randomshapecolor == 3)
                        {
                            lbl_shape.ForeColor = Color.Yellow;
                        }
                        else if (randomshapecolor == 4)
                        {
                            lbl_shape.ForeColor = Color.Green;
                        }

                        switch (shapenumber)
                        {
                            case 1:
                                {

                                    randomshapenumber = rnd.Next(1, 1);
                                    randomshapenumber2 = rnd.Next(1, 1);
                                    randomshapenumber3 = rnd.Next(1, 1);
                                    randomshapenumber4 = rnd.Next(1, 1);
                                    randomshapenumber5 = rnd.Next(1, 1);
                                    lbl_shape.Visible = true;
                                    lbl_shape.Text = shapearray[randomshapenumber] + shapearray[randomshapenumber2] + shapearray[randomshapenumber3] + shapearray[randomshapenumber4]
                                        + shapearray[randomshapenumber5];
                                    break;
                                }
                            case 2:
                                {
                                    randomshapenumber = rnd.Next(1, 3);
                                    randomshapenumber2 = rnd.Next(1, 3);
                                    randomshapenumber3 = rnd.Next(1, 3);
                                    randomshapenumber4 = rnd.Next(1, 3);
                                    randomshapenumber5 = rnd.Next(1, 3);
                                    lbl_shape.Visible = true;
                                    lbl_shape.Text = shapearray[randomshapenumber] + shapearray[randomshapenumber2] + shapearray[randomshapenumber3] + shapearray[randomshapenumber4]
                                        + shapearray[randomshapenumber5];
                                    break;
                                }
                            case 3:
                                {
                                    randomshapenumber = rnd.Next(1, 4);
                                    randomshapenumber2 = rnd.Next(1, 4);
                                    randomshapenumber3 = rnd.Next(1, 4);
                                    randomshapenumber4 = rnd.Next(1, 4);
                                    randomshapenumber5 = rnd.Next(1, 4);
                                    lbl_shape.Visible = true;
                                    lbl_shape.Text = shapearray[randomshapenumber] + shapearray[randomshapenumber2] + shapearray[randomshapenumber3] + shapearray[randomshapenumber4]
                                         + shapearray[randomshapenumber5];
                                    break;
                                }
                            case 4:
                                {
                                    randomshapenumber = rnd.Next(1, 5);
                                    randomshapenumber2 = rnd.Next(1, 5);
                                    randomshapenumber3 = rnd.Next(1, 5);
                                    randomshapenumber4 = rnd.Next(1, 5);
                                    randomshapenumber5 = rnd.Next(1, 5);
                                    lbl_shape.Visible = true;
                                    lbl_shape.Text = shapearray[randomshapenumber] + shapearray[randomshapenumber2] + shapearray[randomshapenumber3] + shapearray[randomshapenumber4]
                                         + shapearray[randomshapenumber5];
                                    break;
                                }

                        }
                        break;
                    }
                case 6:
                    {

                        randomshapecolor = rnd.Next(1, 5);

                        if (randomshapecolor == 1)
                        {
                            lbl_shape.ForeColor = Color.Red;
                        }
                        else if (randomshapecolor == 2)
                        {
                            lbl_shape.ForeColor = Color.Blue;
                        }
                        else if (randomshapecolor == 3)
                        {
                            lbl_shape.ForeColor = Color.Yellow;
                        }
                        else if (randomshapecolor == 4)
                        {
                            lbl_shape.ForeColor = Color.Green;
                        }

                        switch (shapenumber)
                        {
                            case 1:
                                {

                                    randomshapenumber = rnd.Next(1, 1);
                                    randomshapenumber2 = rnd.Next(1, 1);
                                    randomshapenumber3 = rnd.Next(1, 1);
                                    randomshapenumber4 = rnd.Next(1, 1);
                                    randomshapenumber5 = rnd.Next(1, 1);
                                    randomshapenumber6 = rnd.Next(1, 1);
                                    lbl_shape.Visible = true;
                                    lbl_shape.Text = shapearray[randomshapenumber] + shapearray[randomshapenumber2] + shapearray[randomshapenumber3] + shapearray[randomshapenumber4]
                                        + shapearray[randomshapenumber5] + shapearray[randomshapenumber6];
                                    break;
                                }
                            case 2:
                                {
                                    randomshapenumber = rnd.Next(1, 3);
                                    randomshapenumber2 = rnd.Next(1, 3);
                                    randomshapenumber3 = rnd.Next(1, 3);
                                    randomshapenumber4 = rnd.Next(1, 3);
                                    randomshapenumber5 = rnd.Next(1, 3);
                                    randomshapenumber6 = rnd.Next(1, 3);
                                    lbl_shape.Visible = true;
                                    lbl_shape.Text = shapearray[randomshapenumber] + shapearray[randomshapenumber2] + shapearray[randomshapenumber3] + shapearray[randomshapenumber4]
                                        + shapearray[randomshapenumber5] + shapearray[randomshapenumber6];
                                    break;
                                }
                            case 3:
                                {
                                    randomshapenumber = rnd.Next(1, 4);
                                    randomshapenumber2 = rnd.Next(1, 4);
                                    randomshapenumber3 = rnd.Next(1, 4);
                                    randomshapenumber4 = rnd.Next(1, 4);
                                    randomshapenumber5 = rnd.Next(1, 4);
                                    randomshapenumber6 = rnd.Next(1, 4);
                                    lbl_shape.Visible = true;
                                    lbl_shape.Text = shapearray[randomshapenumber] + shapearray[randomshapenumber2] + shapearray[randomshapenumber3] + shapearray[randomshapenumber4]
                                         + shapearray[randomshapenumber5] + shapearray[randomshapenumber6];
                                    break;
                                }
                            case 4:
                                {
                                    randomshapenumber = rnd.Next(1, 5);
                                    randomshapenumber2 = rnd.Next(1, 5);
                                    randomshapenumber3 = rnd.Next(1, 5);
                                    randomshapenumber4 = rnd.Next(1, 5);
                                    randomshapenumber5 = rnd.Next(1, 5);
                                    randomshapenumber6 = rnd.Next(1, 5);
                                    lbl_shape.Visible = true;
                                    lbl_shape.Text = shapearray[randomshapenumber] + shapearray[randomshapenumber2] + shapearray[randomshapenumber3] + shapearray[randomshapenumber4]
                                         + shapearray[randomshapenumber5] + shapearray[randomshapenumber6];
                                    break;
                                }

                        }
                        break;
                    }
                case 7:
                    {

                        randomshapecolor = rnd.Next(1, 5);

                        if (randomshapecolor == 1)
                        {
                            lbl_shape.ForeColor = Color.Red;
                        }
                        else if (randomshapecolor == 2)
                        {
                            lbl_shape.ForeColor = Color.Blue;
                        }
                        else if (randomshapecolor == 3)
                        {
                            lbl_shape.ForeColor = Color.Yellow;
                        }
                        else if (randomshapecolor == 4)
                        {
                            lbl_shape.ForeColor = Color.Green;
                        }

                        switch (shapenumber)
                        {
                            case 1:
                                {

                                    randomshapenumber = rnd.Next(1, 1);
                                    randomshapenumber2 = rnd.Next(1, 1);
                                    randomshapenumber3 = rnd.Next(1, 1);
                                    randomshapenumber4 = rnd.Next(1, 1);
                                    randomshapenumber5 = rnd.Next(1, 1);
                                    randomshapenumber6 = rnd.Next(1, 1);
                                    randomshapenumber7 = rnd.Next(1, 1);
                                    lbl_shape.Visible = true;
                                    lbl_shape.Text = shapearray[randomshapenumber] + shapearray[randomshapenumber2] + shapearray[randomshapenumber3] + shapearray[randomshapenumber4]
                                        + shapearray[randomshapenumber5] + shapearray[randomshapenumber6] + shapearray[randomshapenumber7];
                                    break;
                                }
                            case 2:
                                {
                                    randomshapenumber = rnd.Next(1, 3);
                                    randomshapenumber2 = rnd.Next(1, 3);
                                    randomshapenumber3 = rnd.Next(1, 3);
                                    randomshapenumber4 = rnd.Next(1, 3);
                                    randomshapenumber5 = rnd.Next(1, 3);
                                    randomshapenumber6 = rnd.Next(1, 3);
                                    randomshapenumber7 = rnd.Next(1, 3);
                                    lbl_shape.Visible = true;
                                    lbl_shape.Text = shapearray[randomshapenumber] + shapearray[randomshapenumber2] + shapearray[randomshapenumber3] + shapearray[randomshapenumber4]
                                        + shapearray[randomshapenumber5] + shapearray[randomshapenumber6] + shapearray[randomshapenumber7];
                                    break;
                                }
                            case 3:
                                {
                                    randomshapenumber = rnd.Next(1, 4);
                                    randomshapenumber2 = rnd.Next(1, 4);
                                    randomshapenumber3 = rnd.Next(1, 4);
                                    randomshapenumber4 = rnd.Next(1, 4);
                                    randomshapenumber5 = rnd.Next(1, 4);
                                    randomshapenumber6 = rnd.Next(1, 4);
                                    randomshapenumber7 = rnd.Next(1, 4);
                                    lbl_shape.Visible = true;
                                    lbl_shape.Text = shapearray[randomshapenumber] + shapearray[randomshapenumber2] + shapearray[randomshapenumber3] + shapearray[randomshapenumber4]
                                         + shapearray[randomshapenumber5] + shapearray[randomshapenumber6] + shapearray[randomshapenumber7];
                                    break;
                                }
                            case 4:
                                {
                                    randomshapenumber = rnd.Next(1, 5);
                                    randomshapenumber2 = rnd.Next(1, 5);
                                    randomshapenumber3 = rnd.Next(1, 5);
                                    randomshapenumber4 = rnd.Next(1, 5);
                                    randomshapenumber5 = rnd.Next(1, 5);
                                    randomshapenumber6 = rnd.Next(1, 5);
                                    randomshapenumber7 = rnd.Next(1, 5);
                                    lbl_shape.Visible = true;
                                    lbl_shape.Text = shapearray[randomshapenumber] + shapearray[randomshapenumber2] + shapearray[randomshapenumber3] + shapearray[randomshapenumber4]
                                         + shapearray[randomshapenumber5] + shapearray[randomshapenumber6] + shapearray[randomshapenumber7];
                                    break;
                                }

                        }
                        break;
                    }
                case 8:
                    {

                        randomshapecolor = rnd.Next(1, 5);

                        if (randomshapecolor == 1)
                        {
                            lbl_shape.ForeColor = Color.Red;
                        }
                        else if (randomshapecolor == 2)
                        {
                            lbl_shape.ForeColor = Color.Blue;
                        }
                        else if (randomshapecolor == 3)
                        {
                            lbl_shape.ForeColor = Color.Yellow;
                        }
                        else if (randomshapecolor == 4)
                        {
                            lbl_shape.ForeColor = Color.Green;
                        }
                        switch (shapenumber)
                        {
                            case 1:
                                {

                                    randomshapenumber = rnd.Next(1, 1);
                                    randomshapenumber2 = rnd.Next(1, 1);
                                    randomshapenumber3 = rnd.Next(1, 1);
                                    randomshapenumber4 = rnd.Next(1, 1);
                                    randomshapenumber5 = rnd.Next(1, 1);
                                    randomshapenumber6 = rnd.Next(1, 1);
                                    randomshapenumber7 = rnd.Next(1, 1);
                                    randomshapenumber8 = rnd.Next(1, 1);
                                    lbl_shape.Visible = true;
                                    lbl_shape.Text = shapearray[randomshapenumber] + shapearray[randomshapenumber2] + shapearray[randomshapenumber3] + shapearray[randomshapenumber4]
                                        + shapearray[randomshapenumber5] + shapearray[randomshapenumber6] + shapearray[randomshapenumber7] + shapearray[randomshapenumber8];
                                    break;
                                }
                            case 2:
                                {
                                    randomshapenumber = rnd.Next(1, 3);
                                    randomshapenumber2 = rnd.Next(1, 3);
                                    randomshapenumber3 = rnd.Next(1, 3);
                                    randomshapenumber4 = rnd.Next(1, 3);
                                    randomshapenumber5 = rnd.Next(1, 3);
                                    randomshapenumber6 = rnd.Next(1, 3);
                                    randomshapenumber7 = rnd.Next(1, 3);
                                    randomshapenumber8 = rnd.Next(1, 3);
                                    lbl_shape.Visible = true;
                                    lbl_shape.Text = shapearray[randomshapenumber] + shapearray[randomshapenumber2] + shapearray[randomshapenumber3] + shapearray[randomshapenumber4]
                                        + shapearray[randomshapenumber5] + shapearray[randomshapenumber6] + shapearray[randomshapenumber7] + shapearray[randomshapenumber8];
                                    break;
                                }
                            case 3:
                                {
                                    randomshapenumber = rnd.Next(1, 4);
                                    randomshapenumber2 = rnd.Next(1, 4);
                                    randomshapenumber3 = rnd.Next(1, 4);
                                    randomshapenumber4 = rnd.Next(1, 4);
                                    randomshapenumber5 = rnd.Next(1, 4);
                                    randomshapenumber6 = rnd.Next(1, 4);
                                    randomshapenumber7 = rnd.Next(1, 4);
                                    randomshapenumber8 = rnd.Next(1, 4);
                                    lbl_shape.Visible = true;
                                    lbl_shape.Text = shapearray[randomshapenumber] + shapearray[randomshapenumber2] + shapearray[randomshapenumber3] + shapearray[randomshapenumber4]
                                         + shapearray[randomshapenumber5] + shapearray[randomshapenumber6] + shapearray[randomshapenumber7] + shapearray[randomshapenumber8];
                                    break;
                                }
                            case 4:
                                {
                                    randomshapenumber = rnd.Next(1, 5);
                                    randomshapenumber2 = rnd.Next(1, 5);
                                    randomshapenumber3 = rnd.Next(1, 5);
                                    randomshapenumber4 = rnd.Next(1, 5);
                                    randomshapenumber5 = rnd.Next(1, 5);
                                    randomshapenumber6 = rnd.Next(1, 5);
                                    randomshapenumber7 = rnd.Next(1, 5);
                                    randomshapenumber8 = rnd.Next(1, 5);
                                    lbl_shape.Visible = true;
                                    lbl_shape.Text = shapearray[randomshapenumber] + shapearray[randomshapenumber2] + shapearray[randomshapenumber3] + shapearray[randomshapenumber4]
                                         + shapearray[randomshapenumber5] + shapearray[randomshapenumber6] + shapearray[randomshapenumber7] + shapearray[randomshapenumber8];
                                    break;
                                }

                        }
                        break;
                    }
                case 9:
                    {

                        randomshapecolor = rnd.Next(1, 5);

                        if (randomshapecolor == 1)
                        {
                            lbl_shape.ForeColor = Color.Red;
                        }
                        else if (randomshapecolor == 2)
                        {
                            lbl_shape.ForeColor = Color.Blue;
                        }
                        else if (randomshapecolor == 3)
                        {
                            lbl_shape.ForeColor = Color.Yellow;
                        }
                        else if (randomshapecolor == 4)
                        {
                            lbl_shape.ForeColor = Color.Green;
                        }
                        switch (shapenumber)
                        {
                            case 1:
                                {

                                    randomshapenumber = rnd.Next(1, 1);
                                    randomshapenumber2 = rnd.Next(1, 1);
                                    randomshapenumber3 = rnd.Next(1, 1);
                                    randomshapenumber4 = rnd.Next(1, 1);
                                    randomshapenumber5 = rnd.Next(1, 1);
                                    randomshapenumber6 = rnd.Next(1, 1);
                                    randomshapenumber7 = rnd.Next(1, 1);
                                    randomshapenumber8 = rnd.Next(1, 1);
                                    randomshapenumber9 = rnd.Next(1, 1);
                                    lbl_shape.Visible = true;
                                    lbl_shape.Text = shapearray[randomshapenumber] + shapearray[randomshapenumber2] + shapearray[randomshapenumber3] + shapearray[randomshapenumber4]
                                        + shapearray[randomshapenumber5] + shapearray[randomshapenumber6] + shapearray[randomshapenumber7] + shapearray[randomshapenumber8]
                                        + shapearray[randomshapenumber9];
                                    break;
                                }
                            case 2:
                                {
                                    randomshapenumber = rnd.Next(1, 3);
                                    randomshapenumber2 = rnd.Next(1, 3);
                                    randomshapenumber3 = rnd.Next(1, 3);
                                    randomshapenumber4 = rnd.Next(1, 3);
                                    randomshapenumber5 = rnd.Next(1, 3);
                                    randomshapenumber6 = rnd.Next(1, 3);
                                    randomshapenumber7 = rnd.Next(1, 3);
                                    randomshapenumber8 = rnd.Next(1, 3);
                                    randomshapenumber9 = rnd.Next(1, 3);
                                    lbl_shape.Visible = true;
                                    lbl_shape.Text = shapearray[randomshapenumber] + shapearray[randomshapenumber2] + shapearray[randomshapenumber3] + shapearray[randomshapenumber4]
                                        + shapearray[randomshapenumber5] + shapearray[randomshapenumber6] + shapearray[randomshapenumber7] + shapearray[randomshapenumber8]
                                        + shapearray[randomshapenumber9];
                                    break;
                                }
                            case 3:
                                {
                                    randomshapenumber = rnd.Next(1, 4);
                                    randomshapenumber2 = rnd.Next(1, 4);
                                    randomshapenumber3 = rnd.Next(1, 4);
                                    randomshapenumber4 = rnd.Next(1, 4);
                                    randomshapenumber5 = rnd.Next(1, 4);
                                    randomshapenumber6 = rnd.Next(1, 4);
                                    randomshapenumber7 = rnd.Next(1, 4);
                                    randomshapenumber8 = rnd.Next(1, 4);
                                    randomshapenumber9 = rnd.Next(1, 4);
                                    lbl_shape.Visible = true;
                                    lbl_shape.Text = shapearray[randomshapenumber] + shapearray[randomshapenumber2] + shapearray[randomshapenumber3] + shapearray[randomshapenumber4]
                                         + shapearray[randomshapenumber5] + shapearray[randomshapenumber6] + shapearray[randomshapenumber7] + shapearray[randomshapenumber8]
                                         + shapearray[randomshapenumber9];
                                    break;
                                }
                            case 4:
                                {
                                    randomshapenumber = rnd.Next(1, 5);
                                    randomshapenumber2 = rnd.Next(1, 5);
                                    randomshapenumber3 = rnd.Next(1, 5);
                                    randomshapenumber4 = rnd.Next(1, 5);
                                    randomshapenumber5 = rnd.Next(1, 5);
                                    randomshapenumber6 = rnd.Next(1, 5);
                                    randomshapenumber7 = rnd.Next(1, 5);
                                    randomshapenumber8 = rnd.Next(1, 5);
                                    randomshapenumber9 = rnd.Next(1, 5);
                                    lbl_shape.Visible = true;
                                    lbl_shape.Text = shapearray[randomshapenumber] + shapearray[randomshapenumber2] + shapearray[randomshapenumber3] + shapearray[randomshapenumber4]
                                         + shapearray[randomshapenumber5] + shapearray[randomshapenumber6] + shapearray[randomshapenumber7] + shapearray[randomshapenumber8]
                                         + shapearray[randomshapenumber9];
                                    break;
                                }

                        }
                        break;
                    }
                case 10:
                    {

                        randomshapecolor = rnd.Next(1, 5);

                        if (randomshapecolor == 1)
                        {
                            lbl_shape.ForeColor = Color.Red;
                        }
                        else if (randomshapecolor == 2)
                        {
                            lbl_shape.ForeColor = Color.Blue;
                        }
                        else if (randomshapecolor == 3)
                        {
                            lbl_shape.ForeColor = Color.Yellow;
                        }
                        else if (randomshapecolor == 4)
                        {
                            lbl_shape.ForeColor = Color.Green;
                        }
                        switch (shapenumber)
                        {
                            case 1:
                                {

                                    randomshapenumber = rnd.Next(1, 1);
                                    randomshapenumber2 = rnd.Next(1, 1);
                                    randomshapenumber3 = rnd.Next(1, 1);
                                    randomshapenumber4 = rnd.Next(1, 1);
                                    randomshapenumber5 = rnd.Next(1, 1);
                                    randomshapenumber6 = rnd.Next(1, 1);
                                    randomshapenumber7 = rnd.Next(1, 1);
                                    randomshapenumber8 = rnd.Next(1, 1);
                                    randomshapenumber9 = rnd.Next(1, 1);
                                    randomshapenumber10 = rnd.Next(1, 1);
                                    lbl_shape.Visible = true;
                                    lbl_shape.Text = shapearray[randomshapenumber] + shapearray[randomshapenumber2] + shapearray[randomshapenumber3] + shapearray[randomshapenumber4]
                                        + shapearray[randomshapenumber5] + shapearray[randomshapenumber6] + shapearray[randomshapenumber7] + shapearray[randomshapenumber8]
                                        + shapearray[randomshapenumber9] + shapearray[randomshapenumber10];
                                    break;
                                }
                            case 2:
                                {
                                    randomshapenumber = rnd.Next(1, 3);
                                    randomshapenumber2 = rnd.Next(1, 3);
                                    randomshapenumber3 = rnd.Next(1, 3);
                                    randomshapenumber4 = rnd.Next(1, 3);
                                    randomshapenumber5 = rnd.Next(1, 3);
                                    randomshapenumber6 = rnd.Next(1, 3);
                                    randomshapenumber7 = rnd.Next(1, 3);
                                    randomshapenumber8 = rnd.Next(1, 3);
                                    randomshapenumber9 = rnd.Next(1, 3);
                                    lbl_shape.Visible = true;
                                    lbl_shape.Text = shapearray[randomshapenumber] + shapearray[randomshapenumber2] + shapearray[randomshapenumber3] + shapearray[randomshapenumber4]
                                        + shapearray[randomshapenumber5] + shapearray[randomshapenumber6] + shapearray[randomshapenumber7] + shapearray[randomshapenumber8]
                                        + shapearray[randomshapenumber9] + shapearray[randomshapenumber10];
                                    break;
                                }
                            case 3:
                                {
                                    randomshapenumber = rnd.Next(1, 4);
                                    randomshapenumber2 = rnd.Next(1, 4);
                                    randomshapenumber3 = rnd.Next(1, 4);
                                    randomshapenumber4 = rnd.Next(1, 4);
                                    randomshapenumber5 = rnd.Next(1, 4);
                                    randomshapenumber6 = rnd.Next(1, 4);
                                    randomshapenumber7 = rnd.Next(1, 4);
                                    randomshapenumber8 = rnd.Next(1, 4);
                                    randomshapenumber9 = rnd.Next(1, 4);
                                    lbl_shape.Visible = true;
                                    lbl_shape.Text = shapearray[randomshapenumber] + shapearray[randomshapenumber2] + shapearray[randomshapenumber3] + shapearray[randomshapenumber4]
                                         + shapearray[randomshapenumber5] + shapearray[randomshapenumber6] + shapearray[randomshapenumber7] + shapearray[randomshapenumber8]
                                         + shapearray[randomshapenumber9] + shapearray[randomshapenumber10];
                                    break;
                                }
                            case 4:
                                {
                                    randomshapenumber = rnd.Next(1, 5);
                                    randomshapenumber2 = rnd.Next(1, 5);
                                    randomshapenumber3 = rnd.Next(1, 5);
                                    randomshapenumber4 = rnd.Next(1, 5);
                                    randomshapenumber5 = rnd.Next(1, 5);
                                    randomshapenumber6 = rnd.Next(1, 5);
                                    randomshapenumber7 = rnd.Next(1, 5);
                                    randomshapenumber8 = rnd.Next(1, 5);
                                    randomshapenumber9 = rnd.Next(1, 5);
                                    lbl_shape.Visible = true;
                                    lbl_shape.Text = shapearray[randomshapenumber] + shapearray[randomshapenumber2] + shapearray[randomshapenumber3] + shapearray[randomshapenumber4]
                                         + shapearray[randomshapenumber5] + shapearray[randomshapenumber6] + shapearray[randomshapenumber7] + shapearray[randomshapenumber8]
                                         + shapearray[randomshapenumber9] + shapearray[randomshapenumber10];
                                    break;
                                }

                        }
                        break;
                    }

            }


            if (checkbox_showresult.Checked == true)
            {
                DataTable dt = new DataTable();
                string firstColum = lbl_shape.Text;
                string[] row = { firstColum };
                bunifuCustomDataGrid1.Rows.Add(row);
                bunifuCustomDataGrid1.Rows[a].DefaultCellStyle.ForeColor = lbl_shape.ForeColor;
                a++;
            }

            else
            {

            }
           
        }

        private void timer_screentime_Tick(object sender, EventArgs e)
        {
            shapeGenerator();

            if (checkbox_showhide.Checked == true)
            {

                if (i != numberoflines)
                {
                    
                    lbl_shape.Visible = true;
                    
                    randomShape();
                    timer_screentime.Stop();
                    timer_hidetime.Start();
                   
                    i++;
                }

                else
                {

                    if (checkbox_showresult.Checked == true)
                    {
                        bunifuCustomDataGrid1.Visible = true;
                        btn_resultok.Visible = true;
                        timer_screentime.Stop();
                        lbl_shape.Visible = false;
                        btn_stop.Visible = false;
                        btn_start.Visible = true;
                        i = 1;

                    }

                    else
                    {
                       
                        timer_screentime.Stop();
                        lbl_shape.Visible = false;
                        btn_stop.Visible = false;
                        btn_start.Visible = true;
                        i = 1;

                    }


                }

            }

            else
            {
                if (i != numberoflines)
                {

                    lbl_shape.Visible = true;

                    randomShape();
                 
                    i++;
                }


                else
                {
                    if (checkbox_showresult.Checked == true)
                    {
                        bunifuCustomDataGrid1.Visible = true;
                        btn_resultok.Visible = true;
                        timer_screentime.Stop();
                        lbl_shape.Visible = false;
                        btn_stop.Visible = false;
                        btn_start.Visible = true;
                        i = 1;

                    }

                    else
                    {

                        timer_screentime.Stop();
                        lbl_shape.Visible = false;
                        btn_stop.Visible = false;
                        btn_start.Visible = true;
                        i = 1;

                    }
                }
            }
           



        }

        private void btn_start_Click(object sender, EventArgs e)
        {


            if (numeric_numberoflines.Value == 0 || numeric_numberofcolumns.Value == 0 || checkbox_shape1.Checked==false && checkbox_shape2.Checked == false && checkbox_shape3.Checked == false && checkbox_shape4.Checked == false)
            {
                MessageBox.Show("Ayarları doğru şekilde yapınız.");
                btn_stop.Visible = false;
                btn_start.Visible = true;
                lbl_screentime.Focus();
                numeric_numberoflines.Value = 4;
                numeric_numberofcolumns.Value = 4;
                numeric_screentime.Value = 1000;
                checkbox_shape1.Checked = true;

            }

            if (bunifuCustomDataGrid1.Visible == true)
            {
                MessageBox.Show("Sonuç tablosunu kapatmadan işlem yapamazsınız.");
            }

            else
            {
                 if (checkbox_showhide.Checked == true)
                {
                    randomShape();
                    timer_screentime.Interval = (int)numeric_screentime.Value;
                    timer_hidetime.Interval = (int)numeric_screentime.Value;
                    timer_hidetime.Start();
                    lbl_shape.Visible = true;
                    btn_stop.Visible = true;
                    btn_start.Visible = false;


                }

                else
                {
                    randomShape();
                    timer_screentime.Interval = (int)numeric_screentime.Value;
                    timer_screentime.Start();
                    lbl_shape.Visible = true;
                    btn_stop.Visible = true;
                    btn_start.Visible = false;

                }
            }

           

           

        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            if (bunifuCustomDataGrid1.Visible == true)
            {
                MessageBox.Show("Sonuç tablosunu kapatmadan işlem yapamazsınız.");
            }
            if (btn_start.Visible == false)
            {
                btn_stop.Visible = false;
                btn_start.Visible = true;
            }


            timer_screentime.Stop();
            timer_hidetime.Stop();
            i = 1;
            a = 0;
            lbl_shape.Visible = false;
            lbl_shape.Text = "";
            bunifuCustomDataGrid1.Visible = false;
            numeric_screentime.Value = 1000;
            numeric_numberoflines.Value = 4;
            numeric_numberofcolumns.Value = 4;
            checkbox_shape1.Checked = true;
            checkbox_shape2.Checked = false;
            checkbox_shape3.Checked = false;
            checkbox_shape4.Checked = false;
            checkbox_showhide.Checked = true;
            checkbox_showresult.Checked = true;
        }

        private void timer_hidetime_Tick(object sender, EventArgs e)
        {
            lbl_shape.Visible = false;
            timer_screentime.Start();
            timer_hidetime.Stop();
            
        }

        private void MultiplePerception_Load(object sender, EventArgs e)
        {
            shapeStyle();
           

        }
    }
}
