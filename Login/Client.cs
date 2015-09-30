using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;

namespace Login
{
    class Client
    {
        String username, password;
        public Client(String name, String pass)
        {
            username = name;
            password = pass;
        }

        public void Start(
            String ipAddress,
            int port)
        {
            //Defining the connexion parameters
            IPEndPoint ipep = new IPEndPoint(
                IPAddress.Parse(ipAddress), port);
            Socket server = new Socket(AddressFamily.InterNetwork,
                SocketType.Stream, ProtocolType.Tcp);

            //Trying to connect
            try
            {
                server.Connect(ipep);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Couldn't connect to the server\n"+ex.ToString());
            }


        }
    }
}
