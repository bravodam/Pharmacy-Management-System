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
    public partial class gpappointment : Form
    {
        public gpappointment()
        {
            InitializeComponent();
        }

        private void gP_AppointmentBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.gP_AppointmentBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.myDatabaseProjectDataSet);

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'myDatabaseProjectDataSet.GP_Appointment' table. You can move, or remove it, as needed.
            this.gP_AppointmentTableAdapter.Fill(this.myDatabaseProjectDataSet.GP_Appointment);

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult iExit;
            iExit = MessageBox.Show("Confirm If you want to Exit the Doctor's Report", " Pharamacy Management System",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (iExit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.gP_AppointmentBindingSource.AddNew();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            this.gP_AppointmentBindingSource.RemoveCurrent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            this.gP_AppointmentBindingSource.MoveNext();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            this.gP_AppointmentBindingSource.MovePrevious();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.gP_AppointmentBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(myDatabaseProjectDataSet);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult iExit;
            iExit = MessageBox.Show("Confirm If you want to Exit the GP Appointment", " Pharamacy Management Systems",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (iExit == DialogResult.Yes)
            {
                this.Hide();
            }
        }
    }
}
