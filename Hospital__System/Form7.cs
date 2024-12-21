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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
            DisplayRecprs();
            Patid();
            Docid();
            Patid();
            Testid();

        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\MATRIX\Documents\hospitalDb.mdf;Integrated Security=True;Connect Timeout=30");
        private void Docid()
        { 
            Con.Open();
        SqlCommand cmd =new  SqlCommand("Select DOCid from DOCTORTbl",Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("DOCid", typeof(int));
            dt.Load(rdr);
            Did.ValueMember = "DOCid";
            Did.DataSource = dt;
            Con.Close();
        }

        private void DocName()
        {
            Con.Open();
            string Query = "Select * from DOCTORTbl where DOCid =" + Did.SelectedValue.ToString()+"";
            SqlCommand cmd =new SqlCommand(Query,Con);
            DataTable dt =new DataTable();
            SqlDataAdapter sda =new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach(DataRow dr in dt.Rows)
            {
                DName.Text = dr["DOCName"].ToString();
            }
            Con.Close();
        }

        private void Patid()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("Select Patid from PatientTbl", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dtt = new DataTable();
            dtt.Columns.Add("Patid");
            dtt.Load(rdr);
            Pid.ValueMember = "Patid";
            Pid.DataSource = dtt;
            Con.Close();
        }
        private void PatName()
        {
            Con.Open();
            string Query = "Select * from PatientTbl where Patid =" + Pid.SelectedValue.ToString() + "";
            SqlCommand cmd = new SqlCommand(Query, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow pi in dt.Rows)
            {
                PName.Text = pi["PatName"].ToString();
            }
            Con.Close();
        }

        private void Testid()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("Select TestNum from TestTbl", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("TestNum", typeof(int));
            dt.Load(rdr);
            Tid.ValueMember = "TestNum";
            Tid.DataSource = dt;
            Con.Close();
        }
        private void TestName()
        {
            Con.Open();
            string Query = "Select * from TestTbl where TestNum =" + Tid.SelectedValue.ToString() + "";
            SqlCommand cmd = new SqlCommand(Query, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                TName.Text = dr["TestName"].ToString();
                cost.Text = dr["TestCost"].ToString();
            }
            Con.Close();
        }
        private void gunaDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            report.Text = "\n\n                           DOCTOR REPORT                   \n\n"+DateTime.Today.Date+"\n\n";
            report.Text += "*************************************************************\n";
            report.Text +="\n\n\tDortor: "+ gunaDataGridView1.SelectedRows[0].Cells[2].Value.ToString()+"\t\tpatient: "+ gunaDataGridView1.SelectedRows[0].Cells[4].Value.ToString()+"\n";
            report.Text +="\n\n\tTest: "+ gunaDataGridView1.SelectedRows[0].Cells[6].Value.ToString()+"\t\tMedicines: "+ gunaDataGridView1.SelectedRows[0].Cells[7].Value.ToString()+"\n";
        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }

        private void Did_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DocName();
        }

        private void Pid_SelectedIndexChanged(object sender, EventArgs e)
        {
            PatName();
        }

        private void Tid_SelectedIndexChanged(object sender, EventArgs e)
        {
            TestName();
        }
        private void DisplayRecprs()
        {
            Con.Open();
            String Query = "Select * from Tj";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);

            gunaDataGridView1.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {

            if (DName.Text == "" || PName.Text == "" || TName.Text == "" )
            {
                MessageBox.Show("Missing Info");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into Tj (DOCid,DOCName,patid,patName,LabTestid,LabTestName,Medicines,Cost)values(@DI,@DN,@PI,@PN,@TI,@TN,@Med,@Cost)", Con);
                    cmd.Parameters.AddWithValue("@DI", Did.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@DN", DName.Text);
                    cmd.Parameters.AddWithValue("@PI", Pid.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@PN", PName.Text);
                    cmd.Parameters.AddWithValue("@TI", Tid.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@TN",TName.Text );
                    cmd.Parameters.AddWithValue("@Med", Medicines.Text);
                    cmd.Parameters.AddWithValue("@Cost", cost.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Added");
                    Con.Close();
                    DisplayRecprs();
                    //clear();
                }
                catch (Exception EX)
                {
                    MessageBox.Show(EX.Message);
                }

            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(report.Text + "\n", new Font("Averia", 18, FontStyle.Regular), Brushes.Black, new Point(95, 80));
           
        }

        private void label11_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
