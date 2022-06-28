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

    public partial class teamLeadSeite : Form
    {
        string connectionString = "Data Source = EVT03114NB; Initial Catalog = Rechtsbuero_DB; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False";
        private DataTable dtt = new DataTable();
        private DataTable dttt = new DataTable();
        private DataTable dtttt = new DataTable();
        private DataSet ds = new DataSet();
        private DataSet dss = new DataSet();
        private DataSet dsss = new DataSet();

        public teamLeadSeite(String benutzerID,String teamNum)
        {
            InitializeComponent();
            Globals.benID = benutzerID;
            Globals.teamNummer = teamNum;
            teamLeadDeinTeamPanel.Hide();
            loadHomePage();
            teamLeadFaellePanel.Hide();
        }

        static class Globals
        {
            // global int
            public static String benID;
            public static String benTyp;
            public static String teamNummer;

        }

        public void loadHomePage()
        {

            faelleOhneVerantGrid.DataSource = BindSourceFaelleOhneRa();
            faelleOhneVerantGrid.Refresh();

        }
        public void loadDeinTeamPage()
        {

            teamLeadDeinTeamGrid.DataSource = BindSourceDeinTeam();
            teamLeadDeinTeamGrid.Refresh();

        }

        public void loadFaellePage()
        {

            fallTabelleDataGridView.DataSource = BindSource();
            fallTabelleDataGridView.Refresh();

        }



        private void ifAMenuButtonClicked(String buttonName)
        {
            if (buttonName == "Home")
            {
                teamLeadHomeButton.BackColor = Color.Black;
                teamLeadHomeButton.ForeColor = Color.White;
                teamLeadFaelleButton.BackColor = Color.White;
                teamLeadFaelleButton.ForeColor = Color.Black;
                teamLeadTeamButton.BackColor = Color.White;
                teamLeadTeamButton.ForeColor = Color.Black;

                teamLeadHomePanel.Visible = true;
                loadHomePage();
                teamLeadDeinTeamPanel.Visible = false;
                teamLeadFaellePanel.Visible = false;
                
            }
            else if (buttonName == "Faelle")
            {
                teamLeadHomeButton.BackColor = Color.White;
                teamLeadHomeButton.ForeColor = Color.Black;
                teamLeadFaelleButton.BackColor = Color.Black;
                teamLeadFaelleButton.ForeColor = Color.White;
                teamLeadTeamButton.BackColor = Color.White;
                teamLeadTeamButton.ForeColor = Color.Black;

                teamLeadFaellePanel.Visible = true;
                loadFaellePage();
                teamLeadHomePanel.Visible = false;
                
                teamLeadDeinTeamPanel.Visible = false;
                
            }
            else if (buttonName == "DeinTeam")
            {
                teamLeadHomeButton.BackColor = Color.White;
                teamLeadHomeButton.ForeColor = Color.Black;
                teamLeadFaelleButton.BackColor = Color.White;
                teamLeadFaelleButton.ForeColor = Color.Black;
                teamLeadTeamButton.BackColor = Color.Black;
                teamLeadTeamButton.ForeColor = Color.White;

                teamLeadHomePanel.Visible = false;
                teamLeadDeinTeamPanel.Visible = true;
                loadDeinTeamPage();
                teamLeadFaellePanel.Visible = false;
            }
            else
            {
                teamLeadHomeButton.BackColor = Color.White;
                teamLeadFaelleButton.BackColor = Color.White;
                teamLeadTeamButton.BackColor = Color.White;
            }

        }

        

        

        private void tlExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void teamLeadHomeButton_Click(object sender, EventArgs e)
        {
            ifAMenuButtonClicked("Home");
        }

        private void teamLeadFaelleButton_Click(object sender, EventArgs e)
        {
            ifAMenuButtonClicked("Faelle");
        }

        private void teamLeadTeamButton_Click(object sender, EventArgs e)
        {
            ifAMenuButtonClicked("DeinTeam");
        }

        

        private void passwortAendernButton_Click(object sender, EventArgs e)
        {
            if ((tlBenNameAndern.Text != "") && (tlPwAndern.Text != ""))
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    
                    var cmd = new SqlCommand("update PersonTabelle set BenutzerName=@neuBenName,Passwort=@neuPass where BenutzerID=@benID", con);
                    con.Open();
                    cmd.Parameters.AddWithValue("@benID", Globals.benID);
                    cmd.Parameters.AddWithValue("@neuBenName", tlBenNameAndern.Text);
                    cmd.Parameters.AddWithValue("@neuPass", tlPwAndern.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Erfolgreiche Operation.");
                    con.Close();
                }

            }
            tlBenNameAndern.Clear();
            tlPwAndern.Clear();
        }
        public DataTable BindSource()
        {
            string sqlSelect = @"select * from FallTabelle";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {

                using (SqlCommand cmd = new SqlCommand(sqlSelect, conn))
                {
                    
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        ds.Clear();
                        adapter.Fill(ds);

                        dtt = ds.Tables[0];
                        conn.Close();
                    }
                }
            }
            return dtt;
        }

        public DataTable BindSourceDeinTeam()
        {
            string sqlSelect = @"select * from PersonTabelle where TeamNummer = @deinTeamNr";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(sqlSelect, conn))
                {
                    cmd.Parameters.AddWithValue("@deinTeamNr", Globals.teamNummer);
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        dss.Clear();
                        adapter.Fill(dss);

                        dttt = dss.Tables[0];
                        conn.Close();
                    }
                }
            }
            return dttt;
        }

        public DataTable BindSourceFaelleOhneRa()
        {
            string sqlSelect = @"select * from FallTabelle where Verantwortliche_PersonID IS NULL";
            String leer = "";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(sqlSelect, conn))
                {
                    
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        dsss.Clear();
                        adapter.Fill(dsss);

                        dtttt = dsss.Tables[0];
                        conn.Close();
                    }
                }
            }
            return dtttt;
        }


        private void fallZuweisenButton_Click(object sender, EventArgs e)
        {
            if((tlZuweisenRaID.Text != "") && (tlZuweisenFallID.Text != ""))
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    var cmd = new SqlCommand("update FallTabelle set Verantwortliche_PersonID=@verPersonID where [Fall ID]=@fallID", con);
                    con.Open();
                    cmd.Parameters.AddWithValue("@verPersonID", tlZuweisenRaID.Text);
                    cmd.Parameters.AddWithValue("@fallID", tlZuweisenFallID.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Erfolgreiche Operation.");
                    con.Close();
                }
            }
            tlZuweisenFallID.Clear();
            tlZuweisenRaID.Clear();
            fallTabelleDataGridView.DataSource = BindSource();
            fallTabelleDataGridView.Refresh();
            faelleOhneVerantGrid.DataSource = BindSourceFaelleOhneRa();
            faelleOhneVerantGrid.Refresh();
            
        }

        private void fallTabelleBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void faelleHinzu_Click(object sender, EventArgs e)
        {

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = @"insert into FallTabelle([Fall ID], [Fall Nummer], [Fall Name],[Fall Beschreibung],[Fall Typ],[Beklagter Vorname],[Beklagter Nachname]) values('" + hinFallId.Text + "','" + hinFallNr.Text + "','" + hinFallName.Text + "','" + hinFallBesch.Text+ "','"+hinFallTyp.Text+ "','"+hinVorname.Text+ "','"+hinNachname.Text+"')";
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }
            fallTabelleDataGridView.DataSource= BindSource();
            fallTabelleDataGridView.Refresh();
            hinFallId.Clear();
            hinFallNr.Clear();
            hinFallName.Clear();
            hinFallBesch.Clear();
            hinFallTyp.Clear();
            hinVorname.Clear();
            hinNachname.Clear();
        }

        private void teamLeadFallLoeschen_Click(object sender, EventArgs e)
        {
            if ((fallLoeschenID.Text != ""))
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    var cmd = new SqlCommand("delete from FallTabelle where [Fall ID]=@fallIDZumLoeschen", con);
                    con.Open();
                    cmd.Parameters.AddWithValue("@fallIDZumLoeschen", fallLoeschenID.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Erfolgreiche Operation.");
                    con.Close();
                }
            }
            fallTabelleDataGridView.DataSource = BindSource();
            fallTabelleDataGridView.Refresh();
            hinFallId.Clear();
            hinFallNr.Clear();
            hinFallName.Clear();
            hinFallBesch.Clear();
            hinFallTyp.Clear();
            hinVorname.Clear();
            hinNachname.Clear();
            fallLoeschenID.Clear();
        }
    }
}
