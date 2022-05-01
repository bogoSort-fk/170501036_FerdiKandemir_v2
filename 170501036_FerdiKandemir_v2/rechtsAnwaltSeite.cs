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
    public partial class rechtsAnwaltSeite : Form
    {
        public rechtsAnwaltSeite()
        {
            InitializeComponent();
            //fallTabelleBindingNavigator.Hide();
        }

        private void adminUserPanelButton_Click(object sender, EventArgs e)
        {

        }

        private void fallTabelleBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.fallTabelleBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.rechtsbuero_DBDataSet1);

        }

        private void rechtsAnwaltSeite_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'rechtsbuero_DBDataSet1.FallTabelle' table. You can move, or remove it, as needed.
            this.fallTabelleTableAdapter.Fill(this.rechtsbuero_DBDataSet1.FallTabelle);

        }

        private void adminExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
