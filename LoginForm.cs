using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using SchedulingApplication.Database;
using System.Configuration;
using System.Data;
using System.Diagnostics.Metrics;
using System.Globalization;
using System.Text;
using System.IO;

namespace SchedulingApplication
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        // Get the location from region > format using culture info
        string country = CultureInfo.CurrentCulture.DisplayName;


        // Login Button
        private void loginButton_Click(object sender, EventArgs e)
        {
            // When the login button is clicked, test if the criteria fits
            // if it does, allow the user to enter the main page.
            string query = "SELECT COUNT(*) FROM user WHERE username=@username AND password=@password";
            MySqlCommand mySqlCommand = new MySqlCommand(query, DBConnection.connection);
            mySqlCommand.Parameters.AddWithValue("@username", usernameTextBox.Text);
            mySqlCommand.Parameters.AddWithValue("@password", passwordTextBox.Text);
            int count = Convert.ToInt32(mySqlCommand.ExecuteScalar());


            // Connect to Login_History file
            DateTime timestamp = DateTime.Now;
            timestamp = timestamp.ToUniversalTime();
            string myfile = @"C:\Users\noahf\OneDrive\Desktop\C#\SchedulingApplication\Login_History.txt";

            string currentUser = usernameTextBox.Text;

            // if login credentials correct, close login form and go to menu. Then input current user.
            if (count > 0)
            {
                this.Close();
                DialogResult = DialogResult.OK;

                // Input the current user
                User.InputUserId(currentUser);

                // Add timestamp to login history file
                using (StreamWriter streamWriter = File.AppendText(myfile))
                {
                    streamWriter.WriteLine($"'{currentUser}' logged in successfully at: {timestamp} - UTC");
                }
                

            }
            else
            {
                // clear text and show message if login doesn't work. Change to Polish if poland
                if (country == "Estonian (Estonia)")
                {
                    MessageBox.Show("Kehtetud sisselogimismandaadid.");
                }
                else
                {
                    MessageBox.Show("Invalid Login Credentials");
                }
                usernameTextBox.Clear();
                passwordTextBox.Clear();


                // Add timestamp to login history file
                using (StreamWriter streamWriter = File.AppendText(myfile))
                {
                    streamWriter.WriteLine($"'{currentUser}' failed to login at: {timestamp} - UTC");
                }
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            // Display the country in the location text box, get rid of language and paranthesis
            int cut = country.IndexOf("(");
            cut++;
            locationTextBox.Text = country.Substring(cut, country.Length - cut - 1);

            if (country == "Estonian (Estonia)")
            {
                usernameLabel.Text = "Kasutajanimi:";
                passwordLabel.Text = "Parool:";
                locationLabel.Text = "Asukoht:";
            }
        }
    }
}
