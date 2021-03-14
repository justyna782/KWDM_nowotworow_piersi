using System;
using System.Windows.Forms;

namespace KWDM_projekt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txt_client_aet.Text = "KLIENTL"; ;
            txt_server_aet.Text = "ARCHIWUM";
            txt_server_ip.Text = "127.0.0.1";
            txt_server_port.Text = "10100";
            txt_client_port.Text = "10104";
        }

        public static string myAET;       // moj AET - ustaw zgodnie z konfiguracją serwera PACS
        public static string callAET;    // AET serwera - j.w.
        public static string ipPACS;    // IP serwera - j.w.
        public static ushort portPACS;        // port serwera - j.w.
        public static ushort portMove;        // port zwrotny dla MOVE - j.w.


        private void btn_connect_Click(object sender, EventArgs e)
        {
            myAET = txt_client_aet.Text;
            callAET = txt_server_aet.Text;
            ipPACS = txt_server_ip.Text;
            portPACS = Convert.ToUInt16(txt_server_port.Text);
            portMove = Convert.ToUInt16(txt_client_port.Text);


            bool stan = gdcm.CompositeNetworkFunctions.CEcho(ipPACS, portPACS, myAET, callAET);


            if (stan)
            {
                this.Hide();
                var Form3 = new Main();
                Form3.Closed += (s, args) => this.Close();
                Form3.Show();
            }
            else
            {
                MessageBox.Show("Nie można połączyć z serwerem", "Bład", MessageBoxButtons.OK);
            }
        }

    }
}
