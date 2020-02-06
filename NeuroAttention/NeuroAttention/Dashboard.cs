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
        int cpt = 1;
        
        private void Dashboard_Load(object sender, EventArgs e)
        {
            gunaDataGridView1.Rows.Add(3);

            gunaDataGridView1.Rows[0].Cells[0].Value = Image.FromFile("im_car\\1.png");
            gunaDataGridView1.Rows[1].Cells[0].Value = Image.FromFile("im_car\\2.png");
            gunaDataGridView1.Rows[2].Cells[0].Value = Image.FromFile("im_car\\3.png");
            gunaDataGridView1.Rows[3].Cells[0].Value = Image.FromFile("im_car\\4.png");

            gunaDataGridView1.Rows[0].Cells[1].Value = "Sürekli Dikkat Uygulaması";
            gunaDataGridView1.Rows[1].Cells[1].Value = "Çoklu Dikkat Uygulaması";
            gunaDataGridView1.Rows[2].Cells[1].Value = "İşleyen Bellek Uygulaması";
            gunaDataGridView1.Rows[3].Cells[1].Value = "Çoklu Algı Uygulaması";

            gunaDataGridView1.Rows[0].Cells[2].Value = "Normal işlem ve görev atamalı işlem özelliği vardır.";
            gunaDataGridView1.Rows[1].Cells[2].Value = "İşlem sayısı, normal işlem ve görev atamalı işlem\n özelliği vardır.";
            gunaDataGridView1.Rows[2].Cells[2].Value = "Görev atamalı, sütun sayısı özelliği vardır.";
            gunaDataGridView1.Rows[3].Cells[2].Value = "İşlem miktarı, basamak sayısı ve görev ataması\n özelliği vardır.";
        }

        private void gunaCircleButton2_Click(object sender, EventArgs e)
        {
            if (cpt < gunaDataGridView1.Rows.Count)
            {
                cpt++;
                gunaPictureBox_car.Image = (Image)gunaDataGridView1.Rows[cpt - 1].Cells[0].Value;
                lbl_appname.Text = gunaDataGridView1.Rows[cpt - 1].Cells[1].Value.ToString();
                lbl_details.Text = gunaDataGridView1.Rows[cpt - 1].Cells[2].Value.ToString();

            }
           
            else
            {

            }
           
        }

        private void gunaCircleButton1_Click(object sender, EventArgs e)
        {
            if (cpt > 1)
            {
                cpt--;
                lbl_appname.Text = gunaDataGridView1.Rows[cpt - 1].Cells[1].Value.ToString();
                lbl_details.Text = gunaDataGridView1.Rows[cpt - 1].Cells[2].Value.ToString();
                gunaPictureBox_car.Image = (Image)gunaDataGridView1.Rows[cpt-1].Cells[0].Value;
                

            }

           
            else
            {

            }
                
            
        }

        private void btn_startapp_Click(object sender, EventArgs e)
        {
            if (cpt == 1)
            {
                ConstantAttention constantattention = new ConstantAttention();
                constantattention.Show();
                this.Hide();
            }

            else
            {

            }
        }
    }
}
