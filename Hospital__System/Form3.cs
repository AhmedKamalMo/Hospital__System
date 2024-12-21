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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            DisplayRec();
            if (Form1.Role == "Receptionist")
            {
                
                Doctors.Enabled = false;
                Laboratory.Enabled = false;
                Recptionists.Enabled = false;
            }
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\MATRIX\Documents\hospitalDb.mdf;Integrated Security=True;Connect Timeout=30");
        private void DisplayRec()
        {
            Con.Open();
            String Query = "Select * from PatientTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);

            gunaDataGridView1.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            if (PName.Text == "" || Pphone.Text == "" || PAdd.Text == "" || PGen.SelectedIndex == -1 || PHIV.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Info");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into PatientTbl (PatName,PatGen,PatDOB,PatAdd,PatPhone,PatHIV)values(@PN,@PG,@PD,@PA,@PP,@PH)", Con);
                    cmd.Parameters.AddWithValue("@PN", PName.Text);
                    cmd.Parameters.AddWithValue("@PG", PGen.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@PD", PDOB.Value.Date);
                    cmd.Parameters.AddWithValue("@PA", PAdd.Text);
                    cmd.Parameters.AddWithValue("@pp", Pphone.Text);
                    cmd.Parameters.AddWithValue("@PH", PHIV.SelectedItem.ToString());
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

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            if (PName.Text == "" || Pphone.Text == "" || PAdd.Text == "" || PGen.SelectedIndex == -1 || PHIV.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Info");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("update PatientTbl set PatName= @PN,PatGen= @PG,PatDOB=@PD,PatAdd=@PA,PatPhone=@PP,PatHIV=@PH where Patid=@key", Con);
                    cmd.Parameters.AddWithValue("@PN", PName.Text);
                    cmd.Parameters.AddWithValue("@PG", PGen.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@PD", PDOB.Value.Date);
                    cmd.Parameters.AddWithValue("@PA", PAdd.Text);
                    cmd.Parameters.AddWithValue("@pp", Pphone.Text);
                    cmd.Parameters.AddWithValue("@PH", PHIV.SelectedItem.ToString());
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
        int key = 0;
        private void gunaDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            PName.Text = gunaDataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            PGen.Text = gunaDataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            PDOB.Text = gunaDataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            PAdd.Text = gunaDataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            Pphone.Text = gunaDataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            PHIV.Text = gunaDataGridView1.SelectedRows[0].Cells[6].Value.ToString();

            if (PName.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(gunaDataGridView1.SelectedRows[0].Cells[0].Value.ToString());
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
                    SqlCommand cmd = new SqlCommand("Delete PatientTbl where Patid=@key", Con);
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
            PName.Text = "";
            Pphone.Text = "";
            PAdd.Text = "";
            PGen.SelectedIndex = -1 ;
            PHIV.SelectedIndex = -1;
            key = 0;
        }

        private void label11_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Form4 f = new Form4();
            f.Show();
            this.Hide();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Form5 f = new Form5();
            f.Show();
            this.Hide();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            Form6 f = new Form6();
            f.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}