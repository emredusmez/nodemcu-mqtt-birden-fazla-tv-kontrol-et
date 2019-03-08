using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using uPLibrary.Networking.M2Mqtt;

namespace KumandaKontrol
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        void KomutYolla(string komut)
        {
            if (lsbTvListesi.CheckedItems.Count != 0)
            {
                for (int x = 0; x <= lsbTvListesi.CheckedItems.Count - 1; x++)
                {
                    var s = ((CheckedListboxItem)lsbTvListesi.CheckedItems[x]).Id;
                    client.Publish("kumanda/" + s.ToString(), Encoding.ASCII.GetBytes(komut));
                }
            }
        }
        
        private void btnSesAcKapat_Click(object sender, EventArgs e)
        {
            KomutYolla("919");
        }
        MqttClient client = new MqttClient(IPAddress.Parse("10.0.0.39"));
        private void Form1_Load(object sender, EventArgs e)
        {

            for (int i = 1; i < 11; i++)
            {
                lsbTvListesi.Items.Add(new CheckedListboxItem {Id=i,Text="Televizyon "+i });
            }
            string clientId = Guid.NewGuid().ToString();
            client.Connect(clientId);
        }

        private void btnKapatAC_Click(object sender, EventArgs e)
        {
            KomutYolla("2956");
        }

        private void btnYukari_Click(object sender, EventArgs e)
        {
            KomutYolla("906");
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            KomutYolla(" 913");
        }

        private void btnSag_Click(object sender, EventArgs e)
        {
            KomutYolla("943");
        }

        private void btnSol_Click(object sender, EventArgs e)
        {
            KomutYolla("918");
        }

        private void btnAsagi_Click(object sender, EventArgs e)
        {
            KomutYolla("941");
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            KomutYolla("904");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            KomutYolla("898");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            KomutYolla("899");
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            KomutYolla("900");
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            KomutYolla("901");
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            KomutYolla("902");
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            KomutYolla("903");
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            KomutYolla("897");
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            KomutYolla("905");
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            KomutYolla("896");
        }

        private void btnSesYukselt_Click(object sender, EventArgs e)
        {
            KomutYolla("945");
        }

        private void btnSesDusur_Click(object sender, EventArgs e)
        {
            KomutYolla("946");
        }

        private void btn77_Click(object sender, EventArgs e)
        {
            KomutYolla("2951");
            Thread.Sleep(800);
            KomutYolla("903");
        }

        private void btn80_Click(object sender, EventArgs e)
        {
            KomutYolla("897");
            Thread.Sleep(800);
            KomutYolla("2944");
        }

        private void btn78_Click(object sender, EventArgs e)
        {
            KomutYolla("2951");
            Thread.Sleep(800);
            KomutYolla("897");
        }

        private void btn79_Click(object sender, EventArgs e)
        {
            KomutYolla("2951");
            Thread.Sleep(800);
            KomutYolla("905");
        }

        private void btn81_Click(object sender, EventArgs e)
        {
            KomutYolla("897");
            Thread.Sleep(800);
            KomutYolla("2952");
        }

        private void btn82_Click(object sender, EventArgs e)
        {
            KomutYolla("897");
            Thread.Sleep(800);
            KomutYolla("898");
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            KomutYolla("939");
        }

        private void hakkındaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("İletişim: ydmez6@gmail.com");
        }
    }
}
