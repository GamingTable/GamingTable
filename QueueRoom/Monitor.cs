using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace Server
{
    public delegate void StatusChangedHandler(object sender, StatusChangedEventArgs e);

    class Monitor
    {
        //Storing IP address
        IPAddress ipAddress;

        //Constructor setting the IP
        public Monitor(IPAddress ipAdd)
        {
            ipAddress = ipAdd;
        }

        //Declare the event
        public event StatusChangedHandler StatusChangedEvent;
        //The thread that will hold the connection listener
        private Thread thListener;
        //The TCP object that listens for connections
        private TcpListener tlServer;
        //The thread that will send information to the client
        private Thread thSender;
        //Will thell the while loop to keep monitoring for connections
        bool ServRunning = false;
        
        public void StartMonitoring()
        {
            //Get the IP of the first network device
            IPAddress ipaLocal = ipAddress;
            if(tlServer==null)
            {
                //Create the TCP listener object using the IP of the server
                tlServer = new TcpListener(ipaLocal, 5713);
            }
            //Start the TCP listener and listen for connections
            tlServer.Start();

            //The while loop will check for true in this before checking for connections
            ServRunning = true;

            //Start the new thread that hosts the listener
            thListener = new Thread(KeepListening);
            thListener.Start();
        }

        private void KeepListening()
        {
            TcpClient tcServer;
            //While the server is running
            while(ServRunning == true)
            {
                //Accept a pending connection
                tcServer = tlServer.AcceptTcpClient();
                //Start a new thread where our new client who just connected will be managed
                thSender = new Thread(new ParameterizedThreadStart(AcceptClient));
                //The thread calls the AcceptClient() method
                thSender.Start(tcServer);
            }
        }

        //Occurs when a new client is accepted
        private void AcceptClient(object newClient)
        {
            //Set the argument to a message
            StatusChangedEventArgs evArg = new StatusChangedEventArgs("A client just connected");
            //Fire the event because a new client was accepted
            StatusChangedEvent(this, evArg);
        }
    }

    public class StatusChangedEventArgs : EventArgs
    {
        //This will stor our event message
        private string EventMsg;

        //Definition of the property to retrieve the message in the event handler back in Form1
        public string EventMessage
        {
            get
            {
                return EventMsg;
            }
        }

        //Constructor
        public StatusChangedEventArgs(string strEventMsg)
        {
            EventMsg = strEventMsg;
        }
    }
}
