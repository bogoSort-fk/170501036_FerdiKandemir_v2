using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _170501036_FerdiKandemir_v2
{
    public partial class adminSeite : Form
    {
        public adminSeite()
        {
            InitializeComponent();
            //string connectionString = "Data Source = EVT03114NB; Initial Catalog = Rechtsbuero_DB; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False";
            adminUserPanelSeite.Hide();
            personTabelleBindingNavigator.Hide();


        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void ifAMenuButtonClicked(String buttonName)
        {
            if(buttonName=="Home")
            {
                adminHomeButton.BackColor = Color.Black;
                adminHomeButton.ForeColor = Color.White;
                adminUserPanelButton.BackColor = Color.White;
                adminUserPanelButton.ForeColor = Color.Black;

                adminUserPanelSeite.Visible = false;
                personTabelleBindingNavigator.Visible = false;
            }
            else if(buttonName=="UserPanel")
            {
                adminHomeButton.BackColor = Color.White;
                adminHomeButton.ForeColor = Color.Black;
                adminUserPanelButton.BackColor = Color.Black;
                adminUserPanelButton.ForeColor = Color.White;

                adminUserPanelSeite.Visible = true;
                personTabelleBindingNavigator.Visible = true;
            }
            else if(buttonName == "Settings")
            {
                adminHomeButton.BackColor = Color.White;
                adminHomeButton.ForeColor = Color.Black;
                adminUserPanelButton.BackColor = Color.White;
                adminUserPanelButton.ForeColor = Color.Black;

                adminUserPanelSeite.Visible = false;
                personTabelleBindingNavigator.Visible = false;
            }
            else
            {
                adminHomeButton.BackColor = Color.White;
                adminUserPanelButton.BackColor = Color.White;
            }
        }

 

        private void personTableDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void adminHomeButton_Click(object sender, EventArgs e)
        {
            ifAMenuButtonClicked("Home");

        }

        private void adminUserPanelButton_Click(object sender, EventArgs e)
        {
            ifAMenuButtonClicked("UserPanel");
            
        }

       

        private void adminExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void adminSystemSettingsButton_Click(object sender, EventArgs e)
        {
            ifAMenuButtonClicked("Settings");
        }

        private void adminHomePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void personTabelleBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.personTabelleBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.rechtsbuero_DBDataSet);

        }

        private void adminSeite_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'rechtsbuero_DBDataSet.PersonTabelle' table. You can move, or remove it, as needed.
            this.personTabelleTableAdapter.Fill(this.rechtsbuero_DBDataSet.PersonTabelle);

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }

        private void personTabelleBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void userDataTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
