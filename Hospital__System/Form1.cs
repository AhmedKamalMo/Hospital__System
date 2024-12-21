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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\MATRIX\Documents\hospitalDb.mdf;Integrated Security=True;Connect Timeout=30");

        private void bunifuMetroTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }
        public static string Role;
        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)
                MessageBox.Show("Select Your role");
            else if (comboBox1.SelectedIndex == 0)
            {
                if (textBox1.Text == "" || textBox2.Text == "")
                    MessageBox.Show("Enter Admin name and Password");
                else if (textBox1.Text == "Admin" && textBox2.Text == "Admin")
                {
                    Role = "Admin";
                    Form3 f = new Form3();
                    f.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("wrong ");
                }
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                if (textBox1.Text == "" || textBox2.Text == "")
                    MessageBox.Show("Enter Doctor Name and Password");
                else
                {
                    Con.Open();
                    SqlDataAdapter sda =new SqlDataAdapter("Select Count(*) from DOCTORTbl where DOCName='"+textBox1.Text+"'and DOCpass='"+textBox2.Text+"'",Con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows[0][0].ToString() == "1")
                    {
                        MessageBox.Show("Welcome DR/" + textBox1.Text);
                        Role = "Doctor";
                        Form7 f = new Form7();
                        f.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("NOT found");
                    }
                    Con.Close();
                }
            }
            else 
            {
                if (textBox1.Text == "" || textBox2.Text == "")
                    MessageBox.Show("Enter Receptionist Name and Password");
                else
                {
                    Role = "Receptionist";
                    Con.Open();
                    SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) from ReceptionistTbl where RecepName='" + textBox1.Text + "'and RecepPass='" + textBox2.Text + "'", Con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows[0][0].ToString() == "1")
                    {
                        Form2 f = new Form2();
                        f.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("NOT found");
                    }
                    Con.Close();
                }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = -1;
            textBox1.Text = ""; 
            textBox2.Text = "";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
