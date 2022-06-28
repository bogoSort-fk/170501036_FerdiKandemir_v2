
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
    public partial class rechtsAnwaltSeite : Form
    {
        string connectionString = "Data Source = EVT03114NB; Initial Catalog = Rechtsbuero_DB; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False";
        private DataTable dttt = new DataTable();
        private DataSet ds = new DataSet();
        public rechtsAnwaltSeite(String raID, String benutzerTyp, String teamNr)
        {
            InitializeComponent();
            Globals.benID = raID;
            Globals.teamNr = teamNr;
            loadData1();
            homePanel.Visible = true;
            loadHomePage();
            raFaellePanel.Visible = true;

        }
        static class Globals
        {
            // global int
            public static String benID;
            public static String benTyp;
            public static String teamNr;

        }
        public void loadHomePage()
        {
            raHomeTeamNr.Text = Globals.teamNr;
            String teamLeadVorname;
            String teamLeadNachname;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                var cmd = new SqlCommand("select * from PersonTabelle where TeamNummer=@teamNr AND BenutzerTyp = 2", con);
                
                cmd.Parameters.AddWithValue("@teamNr", Globals.teamNr);
                con.Open();
                using(SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        teamLeadVorname = reader["Vorname"].ToString();
                        teamLeadNachname = reader["Nachname"].ToString();
                        raHomeTeamLeiter.Text = teamLeadVorname + " " + teamLeadNachname;
                    }

                    con.Close();
                }
            }
            raDeinTeamTabelleGrid.DataSource = BindSourceDeinTeam();
            

        }
        private void ifAMenuButtonClicked(String buttonName)
        {
            if (buttonName == "Home")
            {
                raHomeButton.BackColor = Color.Black;
                raHomeButton.ForeColor = Color.White;
                raFallButton.BackColor = Color.White;
                raFallButton.ForeColor = Color.Black;
                

                raFaellePanel.Visible = true;
                homePanel.Visible = true;
                loadHomePage();
                
            }
            else if (buttonName == "Faelle")
            {
                raHomeButton.BackColor = Color.White;
                raHomeButton.ForeColor = Color.Black;
                raFallButton.BackColor = Color.Black;
                raFallButton.ForeColor = Color.White;
                

                raFaellePanel.Visible = true;
                homePanel.Visible = false;
            }
            
            else
            {
                raHomeButton.BackColor = Color.White;
                raFallButton.BackColor = Color.White;
               
            }
        }

        public void loadData1()
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(connectionString))
            {

                string commandForLoginGetBenutzerName = "select * from FallTabelle where (Verantwortliche_PersonID = @benutzerID)";


                SqlCommand cmd = new SqlCommand(commandForLoginGetBenutzerName, con);
                cmd.Parameters.AddWithValue("@benutzerID", Globals.benID);
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                con.Close();
                da.Dispose();
            }
            fallTabelleDataGridView.DataSource = dt;
        }

        public DataTable BindSourceDeinTeam()
        {
            string sqlSelect = @"select * from PersonTabelle where TeamNummer = @deinTeamNr";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(sqlSelect, conn))
                {
                    cmd.Parameters.AddWithValue("@deinTeamNr", Globals.teamNr);
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        ds.Clear();
                        adapter.Fill(ds);

                        dttt = ds.Tables[0];
                        conn.Close();
                    }
                }
            }
            return dttt;
        }




        private void rechtsAnwaltSeite_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'rechtsbuero_DBDataSet4.FallTabelle' table. You can move, or remove it, as needed.
            
        }
        private void raHomeButton_Click(object sender, EventArgs e)
        {
            ifAMenuButtonClicked("Home");
        }

        private void raFallButton_Click(object sender, EventArgs e)
        {
            ifAMenuButtonClicked("Faelle");
        }

        private void raSystemSettingsButton_Click(object sender, EventArgs e)
        {
            ifAMenuButtonClicked("Settings");
        }


        private void showFallTabelleWithFilter()
        {

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }



        private void raExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fallTabelleBindingSource2_CurrentChanged(object sender, EventArgs e)
        {

        }

      

        private void passwortAendern_Click(object sender, EventArgs e)
        {
            if((raBenNameAndern.Text !="") && (raPwAndern.Text != ""))
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    var cmd = new SqlCommand("update PersonTabelle set BenutzerName=@neuBenName,Passwort=@neuPass where BenutzerID=@benID", con);
                    con.Open();
                    cmd.Parameters.AddWithValue("@benID", Globals.benID);
                    cmd.Parameters.AddWithValue("@neuBenName", raBenNameAndern.Text);
                    cmd.Parameters.AddWithValue("@neuPass", raPwAndern.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Record Updated Successfully");
                    con.Close();
                }
                    
            }
            raBenNameAndern.Clear();
            raPwAndern.Clear();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
