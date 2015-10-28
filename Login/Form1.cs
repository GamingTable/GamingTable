using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Net;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Threading;

namespace Login
{
    // Define a delegate to handle the communication between terminal and server
    // A delegate is a function put into a variable to pass it
    // That's the best solution I found to let a different thread manipulate
    // a messagebox and add new lines (terminal of the server)
    public delegate void TerminalDelegate(String msg);

    public partial class Form1 : Form
    {
        // We create an object server and client (the program handle both of them temporarily to help testing)
        // We initialize the server state as down and we make 2 threads to handle the client and the server
        // We finally declare a delegate of the type we specified earlier (this is an instance)
        public Boolean serverState = false;
        private Server server;
        private Client client;
        private Thread serverThread, clientThread;
        public TerminalDelegate td;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'gamingTableDataSet.Logins'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.loginsTableAdapter.Fill(this.gamingTableDataSet.Logins);

        }

        private void AddUser(string username, string password, string confirmPass, string email)
        {
            // Local variables to hold values
            // smtp is a protocole sending email for the sign up confirmation
            // it contains the information configured in the parameters to define the expeditor
            String smtpEmail = smtpUserNameTextBox.Text;
            String smtpPassword = smtpUserPasswordTextBox.Text;
            int smtpPort = (int)smtpPortNumericUD.Value;
            String smtpAddress = smtpAddressTextBox.Text;

            // Regex for making sur Email is valid
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(email);

            // Loop through Logins Table
            foreach(DataRow row in gamingTableDataSet.Logins)
            {
                // Look for matching usernames and report an error
                if(row.ItemArray[0].Equals(username))
                {
                    MessageBox.Show("Username already exists");
                    return;
                }
            }

            // Confirm the user inputs
            // (password matching and size, email test, empty username)
            if(password != confirmPass)
            {
                MessageBox.Show("Passwords do not match");
            }
            else if(password.Length<8)
            {
                MessageBox.Show("Password must be at least 8 characters long");
            }
            else if(!match.Success)
            {
                MessageBox.Show("Invalid Email");
            }
            else if(username == null)
            {
                MessageBox.Show("Must have Username");
            }
            //If everything went right
            else
            {
                //Add a new row for the user in the Logins database from the gamingTableDataSet dataset
                GamingTableDataSet.LoginsRow newUserRow = gamingTableDataSet.Logins.NewLoginsRow();

                // Define the row values
                // Encrypt pass and add the values to the new row
                String EncryptedPass = HashPass(password);
                newUserRow.Username = username;
                newUserRow.Password = EncryptedPass;
                newUserRow.Email = email;

                // Check if the SMTP configuration of the server are ok
                if(String.IsNullOrWhiteSpace(smtpEmail) || String.IsNullOrWhiteSpace(smtpPassword) 
                    || String.IsNullOrWhiteSpace(smtpAddress) || smtpPort<=0)
                {
                    MessageBox.Show("Email configuration is not set up correctly!\nThe email cannot be sent !");
                }
                else
                {
                    // Add the newly defined row to the Logins table and update the table cache
                    gamingTableDataSet.Logins.Rows.Add(newUserRow);
                    updateLoginsTable();

                    // Reset the field values, display a confirmation box and send call the SendMessage function for the confirmation email
                    registerUsername.Text = String.Empty;
                    registerPassword.Text = String.Empty;
                    registerConfirm.Text = String.Empty;
                    registerEmail.Text = String.Empty;
                    MessageBox.Show(username + " has been created");

                    SendMessage(email.ToString(), username.ToString(), password.ToString());
                }
            }
        }

        // Method to encrypt the password
        public String HashPass(String password)
        {
            // Define a sha(256) hash
            SHA256 sha = new SHA256CryptoServiceProvider();

            // Compute the hash with the password
            sha.ComputeHash(ASCIIEncoding.ASCII.GetBytes(password));

            // Get hash result into a 8-bit array to convert it into a hexadecimal string
            byte[] result = sha.Hash;

            StringBuilder strBuilder = new StringBuilder();
            for(int i=0;i<result.Length;i++)
            {
                //change it into 2 hexadecimal digits for each byte
                strBuilder.Append(result[i].ToString("x2"));
            }

            return strBuilder.ToString();
        }

        // Method to send email through the protocole SMTP
        public void SendMessage(String ToAddress, string ToName, string password)
        {
            // Define a new smtp client corresponding to the configuration tab fields
            // The smtp client is the sender of the email. Here it's temporarily a gmail account of mine.
            var client = new SmtpClient(smtpAddressTextBox.Text, (int)smtpPortNumericUD.Value)
            {
                Credentials = new NetworkCredential(smtpUserNameTextBox.Text, smtpUserPasswordTextBox.Text),
                EnableSsl = true
            };
            // Ask to use the security protocol for transferring our request
            client.EnableSsl = true;
            // Use the smtp client to send an email to the specified user address (en français dans le texte)
            client.Send(smtpUserNameTextBox.Text, ToAddress, "Merci !", 
                "Merci de vous être enregistré aujourd'hui !\n Vos identifiants sont :\n\n Username : " 
                + ToName.ToString() + "\nPassword : " + password.ToString());
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            // Call the AddUser method when someone tries to sign up
            AddUser(registerUsername.Text, registerPassword.Text, registerConfirm.Text, registerEmail.Text);
        }

        // The sign in method
        private void loginButton_Click(object sender, EventArgs e)
        {
            // Holding values enetered by the user
            String username = loginUsername.Text;
            String password = HashPass(loginPassword.Text);

            // Create a new client and send it the login values
            client = new Client(username, password);

            try
            {
                // The launcher program is not the client program
                // therefore it must be launched in a particular thread
                ThreadStart clientStarter = () => client.Start(
                    clientIP.Text,
                    (int)clientPort.Value);
                clientThread = new Thread(clientStarter);
                clientThread.Start();

                // Disable the textboxes (can't be edited while logged in)
                loginUsername.Enabled = false;
                loginPassword.Enabled = false;

                MessageBox.Show("Login Success");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error during login\n"+ex.ToString());
            }
        }

        // Method to synchronize the database table Logins with the Database
        private void updateLoginsTable()
        {
            try
            {
                // We acknowledge every changements in the dataset
                // Then we lock the Logins table from the database
                // And we use the adapter table to synchronize the database with our dataset
                Validate();
                loginsBindingSource.EndEdit();
                loginsTableAdapter.Update(this.gamingTableDataSet.Logins);
            }
            catch (System.Exception e)
            {
                // Is output when the synchronization failed
                MessageBox.Show("Database synchronization failed\n"+e.ToString());
            }
        }

        private void servButton_Click(object sender, EventArgs e)
        {
            // If the server is up, we shut it down. Otherwise, we launch the server (switch method)
            if(serverState == true)
            {
                try {
                    // Notify the terminal textbox
                    servTerminal.AppendLine("The server is shutting down...");

                    // Stopping the server
                    serverState = false;
                    //Waiting for it to stop
                    //serverThread.Join();


                    // Update label and button to match the server state
                    servButton.Text = "Start Server";
                    servLabel.ForeColor = Color.Firebrick;
                    
                }
                catch(Exception ex)
                {
                    servTerminal.AppendLine("Fatal Error : the server can't stop");
                    servTerminal.AppendLine(ex.ToString());
                }
            }
            else
            {
                //Starting the server
                try {
                    servTerminal.AppendLine("The server is launching...");

                    // Creating the server by sending its network information
                    // servIP might be a local IP to play in local or remote IP to play remotely
                    server = new Server(this, servIP.Text, (int)servPort.Value);

                    //Starting the server
                    serverThread = new Thread(server.Start);
                    serverThread.Start();

                    //Update label and button
                    servButton.Text = "Stop Server";
                    servLabel.ForeColor = Color.ForestGreen;

                    //Change server state
                    serverState = true;
                }
                catch (Exception ex)
                {
                    servTerminal.AppendLine("Fatal Error : the server can't start");
                    servTerminal.AppendLine(ex.ToString());
                }
            }
        }

        //To be called from outside the thread
        public void appendTerminal(String msg)
        {
            servTerminal.AppendLine(msg);
        }

    }

    public static class WinFormsExtension
    {
        // Add a method to write a new line in the TextBox / Server Terminal
        public static void AppendLine(this TextBox source, string value)
        {
            if (source.Text.Length == 0)
                source.Text = value;
            else
                source.AppendText("\r\n" + value);
        }
    }
}
