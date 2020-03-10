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
    public partial class NetworkStatusFailed : Form
    {
        public NetworkStatusFailed()
        {
            InitializeComponent();
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
                Application.Restart();
                
                
            }
            else
            {

                Application.Restart();
               
            }




        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_tryAgain_Click(object sender, EventArgs e)
        {
            networkStatus();
        }

        private void NetworkStatusFailed_Load(object sender, EventArgs e)
        {

        }
    }
}
