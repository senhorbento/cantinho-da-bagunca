using System.Net.NetworkInformation;

namespace Teste_ping
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ping ping = new Ping();
            PingReply reply = ping.Send(textBox1.Text,250);
            if(reply.Status == 0)
            {
                MessageBox.Show(reply.Status.ToString());
            }
            
        }
    }
}