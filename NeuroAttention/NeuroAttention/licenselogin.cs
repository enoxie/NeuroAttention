using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NeuroAttention
{
    public partial class LicenseLogin : Form
    {
        public LicenseLogin()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        /* Database Connection */
        public string conString = ("Data Source = 94.73.146.4; Initial Catalog = db60B; User Id = user60B; Password = PIuc71A0MQmp62Y;");
        //
        public int licenseaccess = 0;
        public int timerlicense = 1;
        public string licensekey = "";
        public void license()
        {
            con = new SqlConnection(conString);
            cmd = new SqlCommand();
            con.Open();
            
            cmd.Connection = con;

            cmd.CommandText = "SELECT * FROM users,license WHERE k_mail Collate SQL_Latin1_General_CP1254_CS_AS ='" +txt_email.Text+"' AND license.license_key Collate SQL_Latin1_General_CP1254_CS_AS ='"+ txt_license.Text+ "' AND  license.license_used='false'";
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                licenseaccess = 1;
                licensekey = dr["license_key"].ToString();

            }

            else
            {
                licenseaccess = 0;
            }

            
            if (licenseaccess == 1)
            {
                lbl_licenseinfo.ForeColor = Color.Green;
                lbl_licenseinfo.Text = "Lisans anahtarı onaylandı";
                timer_license.Start();
                

            }

            else
            {
                lbl_licenseinfo.ForeColor = Color.Red;
                lbl_licenseinfo.Visible = true;
                lbl_licenseinfo.Text = "Lisans anahtarı onaylanmadı";
                timer_license.Stop();
            }


     
            con.Close();
        }

        public void dolicense()
        {
            con = new SqlConnection(conString);
            cmd = new SqlCommand();
            con.Open();
           
            cmd.Connection = con;
            DateTime startDate = DateTime.Now;
            DateTime expiryDate = startDate.AddDays(30);
            String dateexpiry = expiryDate.ToString();
            cmd.CommandText = "UPDATE users set k_licensekey=@license,k_licenseaccess=@access, k_licenseexpirydate=@expirydate where k_mail=@email";
            cmd.Parameters.AddWithValue("@license", txt_license.Text);
            cmd.Parameters.AddWithValue("@access", 1);
            cmd.Parameters.AddWithValue("@email", txt_email.Text);
            cmd.Parameters.AddWithValue("@used", "true");
            cmd.Parameters.AddWithValue("@expirydate", dateexpiry);
            cmd.ExecuteNonQuery();
            
            con.Close();

            con = new SqlConnection(conString);
            cmd = new SqlCommand();
            con.Open();

            cmd.Connection = con;

            cmd.CommandText = "UPDATE license set license_used=@used where license_key=@license";
            cmd.Parameters.AddWithValue("@license", txt_license.Text);
            cmd.Parameters.AddWithValue("@used", "true");
            cmd.ExecuteNonQuery();
            con.Close();




        }


        private void LicenseLogin_Load(object sender, EventArgs e)
        {
            timer_license.Interval = 1000;
        }

        

        private void btn_back_Click(object sender, EventArgs e)
        {
            License license = new License();
            license.Show();
            this.Hide();
        }

        private void txt_email_OnValueChanged(object sender, EventArgs e)
        {
            if (txt_email.Text == "" && txt_license.Text == "")
            {
                lbl_licenseinfo.Visible = false;
            }
            else
            {
                license();
            }
            
        }

        private void txt_license_OnValueChanged(object sender, EventArgs e)
        {
            if (txt_email.Text == "" && txt_license.Text == "")
            {
                lbl_licenseinfo.Visible = false;
            }
            else
            {
                license();
            }
            
        }

        private void timer_license_Tick(object sender, EventArgs e)
        {
            lbl_licenseinfo.ForeColor = Color.FromArgb(185, 185, 185);

            if (timerlicense == 1)
            {
                lbl_licenseinfo.Text = "Lisanslama işlemi yapılıyor.. 1/3";
                timerlicense++;
            }

            else if(timerlicense == 2)
            {
                lbl_licenseinfo.Text = "Lisanslama işlemi yapılıyor.. 2/3";
                timerlicense++;
            }

            else if (timerlicense == 3)
            {
                lbl_licenseinfo.Text = "Lisanslama işlemi yapılıyor.. 3/3";
                dolicense();
                
                timerlicense++;

            }
            else if (timerlicense == 4)
            {
                timer_license.Stop();
                this.Hide();
                Login login = new Login();
                login.Show();
                
            }
        }
    }
}
