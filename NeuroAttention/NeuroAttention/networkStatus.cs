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
    public partial class NetworkStatus : Form
    {

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                // turn on WS_EX_TOOLWINDOW style bit
                cp.ExStyle |= 0x80;
                return cp;
            }
        }

        public NetworkStatus()
        {
            InitializeComponent();
            this.BackColor = Color.LimeGreen;
            this.TransparencyKey = Color.LimeGreen;
        }

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
                this.Hide();
                Login login = new Login();
                login.Show();

            }
            else
            {
                this.Hide();
                NetworkStatusFailed nsfailed = new NetworkStatusFailed();
                nsfailed.Show();
                
            }

        }



        private int sayi = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            sayi = sayi + 1;


            if (sayi == 3)
            {
                networkStatus();
                timer1.Stop();
               
                this.Hide();


            }

            else
            {

            }
        }

        private void NetworkStatus_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            this.FormBorderStyle = FormBorderStyle.None;
            this.ShowInTaskbar = false;
            timer1.Start();

        }
    }
}
