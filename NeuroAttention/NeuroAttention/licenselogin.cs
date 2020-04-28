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
        SqlCommand cmd2;
        SqlDataReader dr;
        SqlDataReader dr2;
        /* Database Connection */
        public string conString = ("Data Source = 94.73.146.4; Initial Catalog = db60B; User Id = user60B; Password = PIuc71A0MQmp62Y;");
        //
        public int licenseaccess = 0;
        public string licensekey = "";
        public void license()
        {
            con = new SqlConnection(conString);
            cmd = new SqlCommand();
            con.Open();
            
            cmd.Connection = con;

            cmd.CommandText = "SELECT * FROM users,license WHERE k_mail Collate SQL_Latin1_General_CP1254_CS_AS ='" +txt_email.Text+"' AND license.license_key Collate SQL_Latin1_General_CP1254_CS_AS ='"+ txt_license.Text+"'";
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
                lbl_licensedenied.ForeColor = Color.Green;
               
            }

            else
            {
                lbl_licensedenied.ForeColor = Color.Red;
                lbl_licensedenied.Visible = true;
            }


     
            con.Close();
        }



        private void LicenseLogin_Load(object sender, EventArgs e)
        {

        }

        

        private void btn_back_Click(object sender, EventArgs e)
        {
            License license = new License();
            license.Show();
            this.Hide();
        }

        private void txt_email_OnValueChanged(object sender, EventArgs e)
        {
            license();
        }

        private void txt_license_OnValueChanged(object sender, EventArgs e)
        {
            license();
        }
    }
}
