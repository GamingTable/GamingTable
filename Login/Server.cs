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
        // The object Server possesses:
        //      a dataset from the database
        //      a list of players (can't distinguish GM from adventurers)
        //      and its own ip address and port number
        //      Then we declare the winForm object GUI of the server
        private GamingTableDataSet gamingTableDataSet;
        private static List<Player> players;
        private String ipAddress;
        private int port;
        private Form1 form;

        public Server(Form1 f, String ip, int p)
        {
            // The constructor instantiates the object parameters
            ipAddress = ip;
            port = p;
            form = f;
        }

        // Define the delegate method in this class
        // both Form and Server must know what is appendTerminal to pass it
        public void appendTerminal(string msg)
        {
            // To pass the message from the server to the terminal, we have to call the form thread
            // InvokeRequired inform us if the thread can be called safely or not
            if (form.InvokeRequired)
                // If we cannot directly call it, we define a delegate that will do it later
                form.Invoke(new TerminalDelegate(form.appendTerminal),msg);
            else
                form.appendTerminal(msg);
        }

        public void Start()
        {
            // Method for the launching event
            try
            {
                // A TcpListener will run in the background to get the ongoing tcp connexions
                TcpListener connections = new TcpListener(IPAddress.Parse(ipAddress), port);
                connections.Start();
                
                // Notify the terminal that the server is up
                appendTerminal("Server started on " + ipAddress + ":" + port);
                appendTerminal("Waiting for connexions...");

                // If form has its serverstate value changed to false, the server stop its working loop
                while(form.serverState)
                {
                    // Here are the commands for the server while running

                    while(!connections.Pending() && form.serverState)
                    {
                        // While the server is running, check if connexions are waiting or sleep 1000ms
                        Thread.Sleep(1000);
                    }

                }

                // Shutdown the tcplistener
                connections.Stop();

            }
            catch (Exception ex)
            {
                appendTerminal("The server stopped");
                appendTerminal(ex.ToString());
            }    
        }

        // Method to determine if the login access is correct
        private Boolean ConnexionAttempt(String username, String password)
        {
            // Receive a tuple (user,pass) and check the values in every row of the Logins dataset
            // Note that password is encrypted in sha(256)
            foreach (DataRow row in gamingTableDataSet.Logins)
            {
                // Compare this row values with the tuple (user,pass)
                if (row.ItemArray[0].Equals(username) 
                    && row.ItemArray[1].Equals(password))
                {
                    // If it matches, add this user to the online players list and notify the terminal
                    players.Add(new Player(username));
                    appendTerminal("The user " + username + " has been successfully logged in");
                    return true;
                }
                else
                {
                    // Notify the terminal that no tuple (user,pass) corresponds to the input one
                    appendTerminal("Login Error : the user " + username + " can't be found in the database");
                    return false;
                }
            }
            return false;
        }
    }
}
