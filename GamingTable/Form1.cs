using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Threading;

namespace GamingTable
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonJoin_Click(object sender, EventArgs e)
        {
            //Create a TCP client
            TcpClient tcpServer = new TcpClient();
            //Connect it to the specified IP address + port
            tcpServer.Connect(IPAddress.Text, 5713);
            //Close the connection
            tcpServer.Close();
        }

        private void ButtonHost_Click(object sender, EventArgs e)
        {
            //Hide this form
            /*this.Hide();
            Server host = new Server();
            Thread serv = new Thread(new ParameterizedThreadStart(Server.Program.Start);
            serv.Start(Nickname.Text,IPAddress.Text);*/
        }
    }
}
