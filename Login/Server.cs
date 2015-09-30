using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Data;
using System.Windows.Forms;
using System.Threading;


namespace Login
{
    class Server
    {
        private GamingTableDataSet gamingTableDataSet;
        private static List<Player> players;
        private String ipAddress;
        private int port;
        private Form1 form;

        public Server(Form1 f, String ip, int p)
        {
            ipAddress = ip;
            port = p;
           form = f;
        }

        //Define the delegate method in this class
        public void appendTerminal(string msg)
        {
            //If the form thread is not busy
            if (form.InvokeRequired)
                form.Invoke(new TerminalDelegate(form.appendTerminal),msg);
            else
                form.appendTerminal(msg);
        }

        public void Start()
        {
            try
            {
                //Listening to incoming connections
                TcpListener connections = new TcpListener(IPAddress.Parse(ipAddress), port);
                connections.Start();
                

                appendTerminal("Server started on " + ipAddress + ":" + port);
                appendTerminal("Waiting for connexions...");

                //While the server is running
                while(form.serverState)
                {
                    while(!connections.Pending() && form.serverState)
                    {
                        Thread.Sleep(1000);
                    }

                }

                //Shutdown the tcplistener
                connections.Stop();

            }
            catch (Exception ex)
            {
                appendTerminal("The server stopped");
                appendTerminal(ex.ToString());
            }    
        }

        //Test the account validity
        private Boolean ConnexionAttempt(String username, String password)
        {
            foreach (DataRow row in gamingTableDataSet.Logins)
            {
                //Search username and test the password
                if (row.ItemArray[0].Equals(username) 
                    && row.ItemArray[1].Equals(password))
                {
                    players.Add(new Player(username));
                    appendTerminal("The user " + username + " has been successfully logged in");
                    return true;
                }
                else
                {
                    appendTerminal("Login Error : the user " + username + " can't be found in the database");
                    return false;
                }
            }
            return false;
        }
    }
}
