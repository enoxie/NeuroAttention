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
    public partial class LoadingScreen : Form
    {
        Timer timer1 = new Timer();
        Timer timer2 = new Timer();

        public bool InternetKontrol()
        {
            try
            {
                System.Net.Sockets.TcpClient kontrol_client = new System.Net.Sockets.TcpClient("www.google.com.tr", 80);
                kontrol_client.Close();
                return true;
            }
            catch (Exception)

            {
                return false;

            }
        }



        public void networkStatus()
        {
            bool kontrol = InternetKontrol(); // Kontrol fonksiyonumuzu çağırdık
                                              // Eğer internet varsa true yoksa false değeri gelecek. Bunu if ile kontrol edelim

            if (kontrol == true)
            {

                MessageBox.Show("Sunucu ile bağlantı kuruldu.", "Bağlantı Kuruldu", MessageBoxButtons.OK, MessageBoxIcon.None);
                Login login = new Login();
                login.Show();
                this.Hide();
            }
            else
            {

                MessageBox.Show("Sunucu ile bağlantı kurulamadı. Bağlantınızın doğruluğundan emin olun veya ISP ile görüşünüz.", "Bağlantı Kesildi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Application.Exit();
              
            }


                

        }

        protected override CreateParams CreateParams
        {
            get
            {
                // Turn on WS_EX_TOOLWINDOW style bit
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x80;
                return cp;
            }
        }




        public LoadingScreen()
        {
            InitializeComponent();
            defaul();
        }




        void defaul()
        {
            this.label_loading.Top = 229;
            this.label_gelistirici.Top = 220;
            this.label_percentage.Left = 130;
            this.label_gelistirici.Visible = false;
            this.label_loading.BringToFront();
            this.label_gelistirici.BringToFront();
            this.label_percentage.BringToFront();
            this.bunifuProgressBar1.BringToFront();
            this.bunifuProgressBar1.Value = 0;

        }


        int plus = 1;
        int lblplus = 3;
        void move(object sender, EventArgs e)
        {
            if(label_percentage.Left < 500 && bunifuProgressBar1.Value < 100)
            {
                bunifuProgressBar1.Value += plus;
                label_percentage.Left += lblplus;
                label_percentage.Text = bunifuProgressBar1.Value.ToString() + "%";

            }

            if(label_percentage.Text == "100%")
            {

                timer1.Stop();
                timer2.Start();
                label_percentage.Visible=false;
            }

            
        }

        int tp = 1;

        void labelmovetop(object sender, EventArgs e)
        {
            label_loading.Top -= tp;
            if(label_loading.Top< 203)
            {
                label_gelistirici.Visible = true;
                label_gelistirici.Top += tp;
            }
            
            if (label_loading.Top < 198)
            {
                timer2.Stop();


                networkStatus();
                


            }

           

        }


        private void loadingscreen_Load(object sender, EventArgs e)
        {
            timer1.Tick += new EventHandler(move);
            timer2.Tick += new EventHandler(labelmovetop);
            timer1.Interval = 20;
            timer2.Interval = 10;
            
            timer1.Start();

        }

        private void timer3_Tick(object sender, EventArgs e)
        {
           
            
           

        }

        private void timer4_Tick(object sender, EventArgs e)
        {
           
        }

        private void timer5_Tick(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.panel1.ClientRectangle, Color.FromArgb(0, 192, 192), ButtonBorderStyle.Solid);
        }
    }
}
