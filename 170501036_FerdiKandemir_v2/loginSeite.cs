using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _170501036_FerdiKandemir_v2
{
    public partial class loginSeite : Form
    {
        public loginSeite()
        {
            InitializeComponent();
            loginPasswortInput.UseSystemPasswordChar = true;
            string connectionString = "Data Source = EVT03114NB; Initial Catalog = Rechtsbuero_DB; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False";
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void loginEinloggenButton_Click(object sender, EventArgs e)
        {
            string BenutzerName = loginBenutzernameInput.Text;
            string passwort     = loginPasswortInput.Text;
            if ( BenutzerName == "" && passwort == "")
            {
                MessageBox.Show("Invalid Input. Check the username or password!");
            }
            string connectionString = "Data Source = EVT03114NB; Initial Catalog = Rechtsbuero_DB; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False";
            

            string nameToControl;
            string passwordToControl;
            string typeOfUserToControl;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                
                string commandForLoginGetBenutzerName = "select * from PersonTabelle where BenutzerName = @BenutzerName";
                

                SqlCommand cmd = new SqlCommand(commandForLoginGetBenutzerName, con);
                cmd.Parameters.AddWithValue("@BenutzerName", BenutzerName);
                con.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        nameToControl = reader["BenutzerName"].ToString();
                        passwordToControl = reader["Passwort"].ToString();
                        typeOfUserToControl = reader["BenutzerTyp"].ToString();
                        
                        if (passwort == passwordToControl)
                        {
                            if (typeOfUserToControl == "0")
                            {
                                new adminSeite().Show();
                                this.Hide();
                            }
                            else if (typeOfUserToControl == "1")
                            {
                                new rechtsAnwaltSeite().Show();
                                this.Hide();
                            }
                            
                        }
                        else
                        {
                            MessageBox.Show("Password is wrong. Please try again.");
                            loginPasswortInput.Clear();
                        }
                    }
                    con.Close();
                }
                

            }
            
            //bool exists = false;

            //SqlCommand cmd = new SqlCommand("select(*) from [Persontabelle] where BenutzerName = @BenutzerName", con);
            //exists = (int)cmd.ExecuteScalar() > 0;





           /* if (loginBenutzernameInput.Text =="admin" && loginPasswortInput.Text =="admin")
            {
                new adminSeite().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Fehlerhafte Benutzername oder Passwort!");
                loginBenutzernameInput.Clear();
                loginPasswortInput.Clear();
                loginBenutzernameInput.Focus();
            }*/
        }

        private void loginVerlassenButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
