using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using Server;

namespace QueueRoom
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Name = "Partie de";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Parse the IP address
            IPAddress ipAdd = IPAddress.Parse("localhost");
            //Create a new instance of the Monitor class and pass the IP address to the constructor
            Monitor myMono = new Monitor(ipAdd);
            //Bind the event to an event handler
            myMono.StatusChangedEvent += new StatusChangedHandler(myMono_StatusChanged);
            //Call the metode that starts monitoring for connections
            myMono.StartMonitoring();
            //Let the user know
            ChatBox.AppendText("Server is ON");
        }
        public void myMono_StatusChanged(object sender, StatusChangedEventArgs e)
        {
            ChatBox.AppendText("Monitor message : " + e.EventMessage);
        }
    }
}
