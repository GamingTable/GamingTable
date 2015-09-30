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
    //Define a delegate to handle the communication between terminal and server
    public delegate void TerminalDelegate(String msg);

    public partial class Form1 : Form
    {
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
            //Local variables to hold values
            String smtpEmail = smtpUserNameTextBox.Text;
            String smtpPassword = smtpUserPasswordTextBox.Text;
            int smtpPort = (int)smtpPortNumericUD.Value;
            String smtpAddress = smtpAddressTextBox.Text;

            //Regex for making sur Email is valid
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(email);

            //Loop through Logins Table
            foreach(DataRow row in gamingTableDataSet.Logins)
            {
                //Look for matching usernames
                if(row.ItemArray[0].Equals(username))
                {
                    MessageBox.Show("Username already exists");
                    return;
                }
            }

            //Confirm the user inputs
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
                //Add a new row for the user
                GamingTableDataSet.LoginsRow newUserRow = gamingTableDataSet.Logins.NewLoginsRow();

                //Define the row values
                String EncryptedPass = HashPass(password);
                newUserRow.Username = username;
                newUserRow.Password = EncryptedPass;
                newUserRow.Email = email;

                //Check SMTP configuration
                if(String.IsNullOrWhiteSpace(smtpEmail) || String.IsNullOrWhiteSpace(smtpPassword) 
                    || String.IsNullOrWhiteSpace(smtpAddress) || smtpPort<=0)
                {
                    MessageBox.Show("Email configuration is not set up correctly!\nThe email cannot be sent !");
                }
                else
                {
                    //Add the row and reset the textboxes
                    gamingTableDataSet.Logins.Rows.Add(newUserRow);
                    updateLoginsTable();

                    registerUsername.Text = String.Empty;
                    registerPassword.Text = String.Empty;
                    registerConfirm.Text = String.Empty;
                    registerEmail.Text = String.Empty;
                    MessageBox.Show(username + " has been created");

                    SendMessage(email.ToString(), username.ToString(), password.ToString());
                }
            }
        }

        //Encrypting the password
        public String HashPass(String password)
        {
            SHA256 sha = new SHA256CryptoServiceProvider();

            //Compute the hash
            sha.ComputeHash(ASCIIEncoding.ASCII.GetBytes(password));

            //get hash result after compute it
            byte[] result = sha.Hash;

            StringBuilder strBuilder = new StringBuilder();
            for(int i=0;i<result.Length;i++)
            {
                //change it into 2 hexadecimal digits for each byte
                strBuilder.Append(result[i].ToString("x2"));
            }

            return strBuilder.ToString();
        }

        //Email sending through SMTP
        public void SendMessage(String ToAddress, string ToName, string password)
        {
            var client = new SmtpClient(smtpAddressTextBox.Text, (int)smtpPortNumericUD.Value)
            {
                Credentials = new NetworkCredential(smtpUserNameTextBox.Text, smtpUserPasswordTextBox.Text),
                EnableSsl = true
            };
            client.EnableSsl = true;

            client.Send(smtpUserNameTextBox.Text, ToAddress, "Merci !", 
                "Merci de vous être enregistré aujourd'hui !\n Vos identifiants sont :\n\n Username : " 
                + ToName.ToString() + "\nPassword : " + password.ToString());
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            AddUser(registerUsername.Text, registerPassword.Text, registerConfirm.Text, registerEmail.Text);
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            //Holding values
            String username = loginUsername.Text;
            String password = HashPass(loginPassword.Text);

            //Create a client
            client = new Client(username, password);

            try
            {
                //Launching the client
                ThreadStart clientStarter = () => client.Start(
                    clientIP.Text,
                    (int)clientPort.Value);
                clientThread = new Thread(clientStarter);
                clientThread.Start();

                //Disable the textboxes
                loginUsername.Enabled = false;
                loginPassword.Enabled = false;

                MessageBox.Show("Login Success");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error during login\n"+ex.ToString());
            }
        }

        //Synchronize the database table Logins and the dataset
        private void updateLoginsTable()
        {
            try
            {
                Validate();
                loginsBindingSource.EndEdit();
                loginsTableAdapter.Update(this.gamingTableDataSet.Logins);
            }
            catch (System.Exception e)
            {
                MessageBox.Show("Database synchronization failed\n"+e.ToString());
            }
        }

        private void servButton_Click(object sender, EventArgs e)
        {
            if(serverState == true)
            {
                try {

                    servTerminal.AppendLine("The server is shutting down...");

                    //Stopping the server
                    serverState = false;
                    //Waiting for it to stop
                    //serverThread.Join();


                    //Update label and button
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

                    //Creating the server
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
        //Add a method to write a new line in the TextBox
        public static void AppendLine(this TextBox source, string value)
        {
            if (source.Text.Length == 0)
                source.Text = value;
            else
                source.AppendText("\r\n" + value);
        }
    }
}
