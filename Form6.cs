using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhamacyManagementSystem
{
    public partial class pharmacy : Form
    {
        public pharmacy()
        {
            InitializeComponent();
        }

        private void pharmacyBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pharmacyBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.myDatabaseProjectDataSet);

        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'myDatabaseProjectDataSet.Pharmacy' table. You can move, or remove it, as needed.
            this.pharmacyTableAdapter.Fill(this.myDatabaseProjectDataSet.Pharmacy);

        }
    }
}
