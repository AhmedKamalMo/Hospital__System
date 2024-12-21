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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
            DisplayRec();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\MATRIX\Documents\hospitalDb.mdf;Integrated Security=True;Connect Timeout=30");

        private void DisplayRec()
        {
            Con.Open();
            String Query = "Select * from ReceptionistTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);

            gunaDataGridView1.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            if (RName.Text == "" || RPhone.Text == "" || RAddress.Text == "" || RPass.Text == "")
            {
                MessageBox.Show("Missing Info");
            }
            else {
                try{
                Con.Open();
                SqlCommand cmd = new SqlCommand("insert into ReceptionistTbl (RecepName,RecepPhone,RecepAdd,RecepPass)values(@RN,@RP,@RA,@RPA)", Con);
                cmd.Parameters.AddWithValue("@RN", RName.Text);
                cmd.Parameters.AddWithValue("@RP", RPhone.Text);
                cmd.Parameters.AddWithValue("@RA", RAddress.Text);
                cmd.Parameters.AddWithValue("@RPA", RPass.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Added");
                Con.Close();
                DisplayRec();
                clear();
            }catch(Exception EX)
                {
                            MessageBox.Show(EX.Message);            
            }
            
            }
        }
        int key = 0;
        private void gunaDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            RName.Text = gunaDataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            RPhone.Text = gunaDataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            RAddress.Text = gunaDataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            RPass.Text = gunaDataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            if (RName.Text == "")
            {
                key = 0;
            }
                else
                {
                    key = Convert.ToInt32(RName.Text = gunaDataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                }
        
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            if (RName.Text == "" || RPhone.Text == "" || RAddress.Text == "" || RPass.Text == "")
            {
                MessageBox.Show("Missing Info");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("update ReceptionistTbl set RecepName=@RN,RecepPhone=@RP,RecepAdd=@RA,RecepPass=@RPA where Recepid=@key", Con);
                    cmd.Parameters.AddWithValue("@RN", RName.Text);
                    cmd.Parameters.AddWithValue("@RP", RPhone.Text);
                    cmd.Parameters.AddWithValue("@RA", RAddress.Text);
                    cmd.Parameters.AddWithValue("@RPA", RPass.Text);
                    cmd.Parameters.AddWithValue("@key", key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("updated");
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
            if (key==0)
            {
                MessageBox.Show("Select");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Delete ReceptionistTbl where Recepid=@key", Con);
                    cmd.Parameters.AddWithValue("@key",key);

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
            RName.Text = "" ;
            RPhone.Text = "" ;
            RAddress.Text ="" ; 
            RPass.Text = "";
            key = 0;
        }

        private void label11_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Form f = new Form3();
            f.Show();
            this.Hide();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Form f = new Form4();
            f.Show();
            this.Hide();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Form6 f = new Form6();
            f.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
