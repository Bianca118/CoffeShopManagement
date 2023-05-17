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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace ProiectMTP_FotaBianca
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

      

        
       
        private void button2_Click_1(object sender, EventArgs e)
        {
            Signup form = new Signup();
            form.Show();
            this.Hide();
        }

        
        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

       



        private void label4_Click(object sender, EventArgs e)
        {
           Signup form =new Signup();
            form.Show();
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
        if (textBox1.Text == "")
        {
            MessageBox.Show("Enter the password");

        }
        else
        {
            try
            {
                SqlConnection com = new SqlConnection("Data Source=Bianca\\SQLEXPRESS;Initial Catalog=Loginform;Integrated Security=True");
                //com.Open();
                string st = "select * from tbl_login where username=@username and password=@password";
                SqlCommand cmd = new SqlCommand(st, com);
                cmd.Parameters.AddWithValue("@username", textBox1.Text);
                cmd.Parameters.AddWithValue("@password", textBox2.Text);
                // cmd.ExecuteNonQuery();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                da.Fill(dt);
                // com.Close();
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("login executat cu succes");
                        Menu form2 = new Menu();

                        // Afișați Form2 și ascundeți Form1
                        form2.Show();
                        this.Hide();
                    }
                else
                {
                    MessageBox.Show("Username sau password incorecte");

                }
            }
            catch

            (Exception ex)
            {
                MessageBox.Show("" + ex);
            }

              
            } 
            
          
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
