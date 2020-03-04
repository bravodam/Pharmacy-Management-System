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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnGP.Enabled = false;
            btnPatient.Enabled = false;
            btnDoctor.Enabled = false;
            button6.Enabled = false;
            btnPayment.Enabled = false;
            btnPharmacy.Enabled = false;

            btnHospital.Enabled = false;
            btnSpecialist.Enabled = false;
            btnConsultant.Enabled = false;
            btnPharmacist.Enabled = false;
            btnPharmacircle.Enabled = false;
            btnHelp.Enabled = false;
            btnSurgery.Enabled = false;


        }

        private void button3_Click(object sender, EventArgs e)
        {
            patient pat = new patient();
            pat.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            gpappointment gp = new gpappointment();
            gp.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DialogResult iExit;
            iExit = MessageBox.Show("Confirm If you want to Exit", " Pharamacy Management System",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
             
            if(iExit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if(txtUserName.Text =="q1" && txtPassWord.Text == "q2")
            {
                button6.Enabled = true;



                btnGP.Enabled = true;
                btnPatient.Enabled = true;
                btnDoctor.Enabled = true;
                button6.Enabled = true;
                btnPayment.Enabled = true;
                btnPharmacy.Enabled = true;



                btnHospital.Enabled = true;
                btnSpecialist.Enabled = true;
                btnConsultant.Enabled = true;
                btnPharmacist.Enabled = true;
                btnPharmacircle.Enabled = true;
                btnHelp.Enabled = true;
                btnSurgery.Enabled = true;


                txtUserName.Clear();
                txtPassWord.Clear();
            }

            else
            {
                MessageBox.Show("Please Enter a Correct Login Details", "Pharmacy Management System");

                txtUserName.Clear();
                txtPassWord.Clear();

                txtUserName.Focus();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            doctor doc = new doctor();
            doc.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            payment pay = new payment();
            pay.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pharmacy pha = new pharmacy();
            pha.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            txtUserName.Clear();
            txtPassWord.Clear();
            txtUserName.Focus();


            btnGP.Enabled = false;
            btnPatient.Enabled = false;
            btnDoctor.Enabled = false;
            button6.Enabled = false;
            btnPayment.Enabled = false;
            btnPharmacy.Enabled = false;

            btnHospital.Enabled = false;
            btnSpecialist.Enabled = false;
            btnConsultant.Enabled = false;
            btnPharmacist.Enabled = false;
            btnPharmacircle.Enabled = false;
            btnHelp.Enabled = false;
            btnSurgery.Enabled = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            txtUserName.Clear();
            txtPassWord.Clear();
            txtUserName.Focus();


            btnGP.Enabled = false;
            btnPatient.Enabled = false;
            btnDoctor.Enabled = false;
            button6.Enabled = false;
            btnPayment.Enabled = false;
            btnPharmacy.Enabled = false;

            btnHospital.Enabled = false;
            btnSpecialist.Enabled = false;
            btnConsultant.Enabled = false;
            btnPharmacist.Enabled = false;
            btnPharmacircle.Enabled = false;
            btnHelp.Enabled = false;
            btnSurgery.Enabled = false;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
