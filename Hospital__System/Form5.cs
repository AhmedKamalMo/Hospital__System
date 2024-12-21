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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            DisplayRec();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\MATRIX\Documents\hospitalDb.mdf;Integrated Security=True;Connect Timeout=30");
        private void DisplayRec()
        {
            Con.Open();
            String Query = "Select * from TestTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);

            gunaDataGridView1.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            if (TName.Text == "" || TCost.Text == "")
            {
                MessageBox.Show("Missing Info");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into TestTbl (TestName,TestCost)values(@TN,@TC)", Con);
                    cmd.Parameters.AddWithValue("@TN", TName.Text);
                    cmd.Parameters.AddWithValue("@TC", TCost.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Added");
                    Con.Close();
                    DisplayRec();
                    clear();
                }
                catch (Exception EX)
                {
                    MessageBox.Show(EX.Message);
                }
            }
        }
        int key = 0;
        private void gunaDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TName.Text = gunaDataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            TCost.Text = gunaDataGridView1.SelectedRows[0].Cells[2].Value.ToString();
           
            if (TName.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(gunaDataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            if (TName.Text == "" || TCost.Text == "")
            {
                MessageBox.Show("Missing Info");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("update  TestTbl set TestName=@TN,TestCost=@TC where TestNum=@key", Con);
                    cmd.Parameters.AddWithValue("@TN", TName.Text);
                    cmd.Parameters.AddWithValue("@TC", TCost.Text);
                    cmd.Parameters.AddWithValue("@key", key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Added");
                    Con.Close();
                    DisplayRec();
                    clear();
                }
                catch (Exception EX)
                {
                    MessageBox.Show(EX.Message);
                }
            }
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("Select");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Delete TestTbl where TestNum=@key", Con);
                    cmd.Parameters.AddWithValue("@key", key);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("deleted");
                    Con.Close();
                    DisplayRec();
                    clear();
                }
                catch (Exception EX)
                {
                    MessageBox.Show(EX.Message);
                }
            }
        }
        private void clear()
        {
            TName.Text = "";
            TCost.Text = "";
            key = 0;
        }

        private void label11_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        private void Patients_Click(object sender, EventArgs e)
        {
            Form f = new Form3();
            f.Show();
            this.Hide();
        }

        private void Doctors_Click(object sender, EventArgs e)
        {
            Form f = new Form4();
            f.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Recptionists_Click(object sender, EventArgs e)
        {
            Form6 f = new Form6();
            f.Show();
            this.Hide();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
