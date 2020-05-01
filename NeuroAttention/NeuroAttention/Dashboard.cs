using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
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

        /* Database Connection */
        public string conString = ("Data Source = 94.73.146.4; Initial Catalog = db60B; User Id = user60B; Password = PIuc71A0MQmp62Y;");
        //
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
       
     
         
        public void userInfo()
        {

            con = new SqlConnection(conString);
            cmd = new SqlCommand();
            con.Open();
            string username1 = "";
            cmd.Connection = con;
            cmd.CommandText = "SELECT personName FROM person where personid=(SELECT k_id FROM users where k_adi='" + Settings1.Default.username + "')";
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
               
                username1 = dr["personName"].ToString();

            }

            lbl_username.Text = "HOŞGELDİN," + " " +username1.ToUpper();
        }
        public void language(string culture)
        {

            Thread.CurrentThread.CurrentUICulture.ClearCachedData();
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(culture);

            


        }

        public void attentionInfo()
        {

            string dil = Settings1.Default["dil"].ToString();
            Application.CurrentCulture = new CultureInfo(dil);
            language(dil);

            if (dil == "tr-TR")
            {

                SqlConnection con = new SqlConnection(conString);
                SqlCommand cmd = new SqlCommand("SELECT * from attention_tr", con);
                DataTable dt = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(dt);
                con.Open();


                dgw_attention.DataSource = dt;
                int numRows = dt.Rows.Count;
                if (numRows > 1)
                {

                    gunaPanel_attention.Size = new Size(360, 350);

                    attention2.Location = new Point(20, 135);
                    gunaSeparator.Location = new Point(6, 120);
                    btn_moredetails.Location = new Point(6, 300);
                    attention2.Show();
                    lbl_attentiontitle.Text = dgw_attention.Rows[0].Cells[1].Value.ToString();
                    lbl_attentiontime.Text = dgw_attention.Rows[0].Cells[2].Value.ToString();
                    lbl_attentionmsg.Text = dgw_attention.Rows[0].Cells[3].Value.ToString();
                    lbl_attentiontitle2.Text = dgw_attention.Rows[1].Cells[1].Value.ToString();
                    lbl_attentiontime2.Text = dgw_attention.Rows[1].Cells[2].Value.ToString();
                    lbl_attentionmessage2.Text = dgw_attention.Rows[1].Cells[3].Value.ToString();

                }
                lbl_attentiontitle.Text = dgw_attention.Rows[0].Cells[1].Value.ToString();
                lbl_attentiontime.Text = dgw_attention.Rows[0].Cells[2].Value.ToString();
                lbl_attentionmsg.Text = dgw_attention.Rows[0].Cells[3].Value.ToString();

            }

            else if (dil == "en-US")
            {

                SqlConnection con = new SqlConnection(conString);
                SqlCommand cmd = new SqlCommand("SELECT * from attention_en", con);

                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                string attentiontitle = "";
                string attentiontime = "";
                string attentionmessage = "";





                while (dr.Read())
                {
                    attentiontitle = dr["attentiontitle"].ToString();
                    attentiontime = dr["attentiontime"].ToString();
                    attentionmessage = dr["attentionmessage"].ToString();
                }
                dr.Close();
                con.Close();

                lbl_attentiontitle.Text = attentiontitle;
                lbl_attentiontime.Text = attentiontime;
                lbl_attentionmsg.Text = attentionmessage;
            }
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            userInfo();
            attentionInfo();
            gunaDataGridView1.Rows.Add(3);

            
            gunaDataGridView1.Rows[0].Cells[1].Value = "Sürekli Dikkat Uygulaması";
            gunaDataGridView1.Rows[1].Cells[1].Value = "Çoklu Dikkat Uygulaması";
            gunaDataGridView1.Rows[2].Cells[1].Value = "İşleyen Bellek Uygulaması";
            gunaDataGridView1.Rows[3].Cells[1].Value = "Çoklu Algı Uygulaması";

            
        }

       
        private void btn_help_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.mayaacademia.com");
        }

        private void btn_attention_MouseHover(object sender, EventArgs e)
        {
            gunaPanel_attention.Visible = true;
        }

        private void btn_attention_MouseLeave(object sender, EventArgs e)
        {
            gunaPanel_attention.Visible = false;
        }

        
        private void btn_startapp_Click(object sender, EventArgs e)
        {

            switch (cpt)
            {
                case 1:
                    {
                        ConstantAttention constantattention = new ConstantAttention();
                        constantattention.Show();
                        this.Hide();
                        break;
                    }

                case 2:
                    {
                        MultipleProcessing cokluislem = new MultipleProcessing();
                        cokluislem.Show();
                        this.Hide();
                        break;
                    }

                case 3:
                    {
                        FunctioningMemory fmemory = new FunctioningMemory();
                        fmemory.Show();
                        this.Hide();
                        break;
                    }

                case 4:
                    {
                        MultiplePerception mperception = new MultiplePerception();
                        mperception.Show();
                        this.Hide();
                        break;
                    }


            }
            
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {

            if (panel_logout.Visible == false)
            {
                panel_logout.Show();
            }


            else
            {

            }

        }

        private void btn_logoutyes_Click(object sender, EventArgs e)
        {
            Settings1.Default.session = false;
            Settings1.Default.Save();
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void btn_logoutno_Click(object sender, EventArgs e)
        {
            panel_logout.Visible = false;
        }

        private void btn_nextapp_Click(object sender, EventArgs e)
        {
            if (cpt < gunaDataGridView1.Rows.Count)
            {
                cpt++;
                lbl_appname.Text = gunaDataGridView1.Rows[cpt - 1].Cells[1].Value.ToString();


            }

            else
            {

            }
        }

        private void btn_previousapp_Click(object sender, EventArgs e)
        {
            if (cpt > 1)
            {
                cpt--;
                lbl_appname.Text = gunaDataGridView1.Rows[cpt - 1].Cells[1].Value.ToString();



            }


            else
            {

            }
        }
    }
}
