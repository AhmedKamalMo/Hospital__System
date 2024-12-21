using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Hospital__System
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            Countpatient();
            CountDoctors();
            Countlab();
            if (Form1.Role == "Receptionist")
            {

                Doctors.Enabled = false;
                Laboratory.Enabled = false;
                Recptionists.Enabled = false;
            }
            
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\MATRIX\Documents\hospitalDb.mdf;Integrated Security=True;Connect Timeout=30");
        private void Countpatient()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) from PatientTbl",Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            panNum.Text = dt.Rows[0][0].ToString();
            Con.Close();
        }
        private void CountDoctors()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) from DOCTORTbl", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            DOCNum.Text = dt.Rows[0][0].ToString();
            Con.Close();
        }
        private void Countlab()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) from TestTbl", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            LABNum.Text = dt.Rows[0][0].ToString();
            Con.Close();
        }
        private void patient_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.Show();
            this.Hide();
        }

        private void Doctors_Click(object sender, EventArgs e)
        {
            Form4 f = new Form4();
            f.Show();
            this.Hide();
        }

        private void Laboratory_Click(object sender, EventArgs e)
        {
            Form5 f = new Form5();
            f.Show();
            this.Hide();
        }

        private void Recptionists_Click(object sender, EventArgs e)
        {
            Form6 f = new Form6();
            f.Show();
            this.Hide();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
