using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProiectMTP_FotaBianca
{
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
        }

        private void labelX_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" && textBox2.Text == "")
            {
                MessageBox.Show("Username and Password fields are empty");

            }
            else
            {
                SqlConnection com = new SqlConnection("Data Source=Bianca\\SQLEXPRESS;Initial Catalog=Loginform;Integrated Security=True");
                com.Open();
                string st = "insert into tbl_login VALUES ('" + textBox1.Text + "','" + textBox2.Text + "')";
                SqlCommand cmd = new SqlCommand(st, com);
                cmd.ExecuteNonQuery();
                com.Close();
                MessageBox.Show("s-a creat");
            }



            //  SqlConnection com = new SqlConnection("Data Source=Bianca\\SQLEXPRESS;Initial Catalog=Loginform;Integrated Security=True");
            //com.Open();
            // string st = "select * from tbl_login where username=@username and password=@password";
            //SqlConnection com = new SqlConnection("Data Source=Bianca\\SQLEXPRESS;Initial Catalog=Loginform;Integrated Security=True");




        }

        private void Signup_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox2.PasswordChar = '\0';


            }
            else

                textBox2.PasswordChar = '*';
               
           
        }

    }
}