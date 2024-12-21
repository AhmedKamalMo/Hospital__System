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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            DisplayRec();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\MATRIX\Documents\hospitalDb.mdf;Integrated Security=True;Connect Timeout=30");
        private void DisplayRec()
        {
            Con.Open();
            String Query = "Select * from DOCTORTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);

            gunaDataGridView1.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            if (DName.Text == "" || DPhone.Text == "" || DAdd.Text == "" || DPass.Text == "" )
            {
                MessageBox.Show("Missing Info");
            }
            else if (DPass.TextLength < 8)
            { MessageBox.Show("you should password greater than or equal 8"); }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into DOCTORTbl (DOCName,DOCDOB,DOCGEN,DOCSPEC,DOCEXP,DOCPHONE,DOCAdd,DOCpass)values(@DN,@DD,@DG,@DS,@DE,@DP,@DA,@DPA)", Con);
                    cmd.Parameters.AddWithValue("@DN", DName.Text);
                    cmd.Parameters.AddWithValue("@DD", DDOB.Value.Date);
                    cmd.Parameters.AddWithValue("@DG", DGe.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@DS", DSP.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@DE", DEXP.Text);
                    cmd.Parameters.AddWithValue("@DP", DPhone.Text);
                    cmd.Parameters.AddWithValue("@DA", DAdd.Text);
                    cmd.Parameters.AddWithValue("@DPA", DPass.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Added");
                    Con.Close();
                    DisplayRec();
                    //clear();
                }
                catch (Exception EX)
                {
                    MessageBox.Show(EX.Message);
                }

            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
        int key = 0;
        private void gunaDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DName.Text = gunaDataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            DDOB.Text = gunaDataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            DGe.Text = gunaDataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            DSP.Text = gunaDataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            DEXP.Text = gunaDataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            DPhone.Text = gunaDataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            DAdd.Text = gunaDataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            DPass.Text = gunaDataGridView1.SelectedRows[0].Cells[8].Value.ToString();
            if (DName.Text == "")
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
            if (DName.Text == "" || DPhone.Text == "" || DAdd.Text == "" || DPass.Text == "" || DGe.SelectedIndex == -1 || DSP.SelectedIndex == -1 || DEXP.Text == "")
            {
                MessageBox.Show("Missing Info");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("update DOCTORTbl set DOCName=@DN ,DOCDOB=@DD ,DOCGEN=@DG ,DOCSPEC=@DS,DOCEXP=@DE ,DOCPHONE=@DP ,DOCAdd=@DA,DOCpass=@DPA where DOCid=@key", Con);
                    cmd.Parameters.AddWithValue("@DN", DName.Text);
                    cmd.Parameters.AddWithValue("@DD", DDOB.Value.Date);
                    cmd.Parameters.AddWithValue("@DG", DGe.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@DS", DSP.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@DE", DEXP.Text);
                    cmd.Parameters.AddWithValue("@DP", DPhone.Text);
                    cmd.Parameters.AddWithValue("@DA", DAdd.Text);
                    cmd.Parameters.AddWithValue("@DPA", DPass.Text);
                    cmd.Parameters.AddWithValue("@key", key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Added");
                    Con.Close();
                    DisplayRec();
                    //clear();
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
                    SqlCommand cmd = new SqlCommand("Delete DOCTORTbl where DOCid=@key", Con);
                    cmd.Parameters.AddWithValue("@key", key);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("deleted");
                    Con.Close();
                    DisplayRec();
                    // clear();
                }
                catch (Exception EX)
                {
                    MessageBox.Show(EX.Message);
                }
            }
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

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DPass_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}

