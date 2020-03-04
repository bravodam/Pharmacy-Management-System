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
    public partial class doctor : Form
    {
        public doctor()
        {
            InitializeComponent();
        }

        private void doctorBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.doctorBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.myDatabaseProjectDataSet);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //this.doctorTableAdapter.Fill(this.myDatabaseProjectDataSet.Doctor);
        }

        private void patient_IDLabel_Click(object sender, EventArgs e)
        {

        }

        private void office_Phone_Number_2Label_Click(object sender, EventArgs e)
        {

        }

        private void gP_AppointmentTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void office_Phone_Number_1TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void doctor_s_Ref_NoTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void doctor__s_NHS_NoLabel_Click(object sender, EventArgs e)
        {

        }

        private void doctor__s_NHS_NoTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void firstNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void firstNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void surNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void surNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void medical_Center_NameLabel_Click(object sender, EventArgs e)
        {

        }

        private void medical_Center_NameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void address_Of_CentreLabel_Click(object sender, EventArgs e)
        {

        }

        private void address_Of_CentreTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void post_CodeLabel_Click(object sender, EventArgs e)
        {

        }

        private void post_CodeTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void medical_Centre_RefLabel_Click(object sender, EventArgs e)
        {

        }

        private void medical_Centre_RefTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void office_Phone_Number_1Label_Click(object sender, EventArgs e)
        {

        }

        private void doctor_s_Ref_NoLabel_Click(object sender, EventArgs e)
        {

        }

        private void office_Phone_Number_2TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void fax_NoLabel_Click(object sender, EventArgs e)
        {

        }

        private void fax_NoTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void email_AddressesLabel_Click(object sender, EventArgs e)
        {

        }

        private void email_AddressesTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void patient_NHS_NumberLabel_Click(object sender, EventArgs e)
        {

        }

        private void patient_NHS_NumberTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void eMIS_NumberLabel_Click(object sender, EventArgs e)
        {

        }

        private void eMIS_NumberTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void gP_AppointmentLabel_Click(object sender, EventArgs e)
        {

        }

        private void patient_IDTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult iExit;
            iExit = MessageBox.Show("Confirm If you want to Exit", " Pharamacy Management System",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (iExit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult iExit;
            iExit = MessageBox.Show("Confirm If you want to Exit the Doctor's Report", " Pharamacy Management System",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (iExit == DialogResult.Yes)
            {
                this.Hide();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.doctorBindingSource.AddNew();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            this.doctorBindingSource.RemoveCurrent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            this.doctorBindingSource.MoveNext();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            this.doctorBindingSource.MovePrevious();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.doctorBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(myDatabaseProjectDataSet);
        }
    }
}
