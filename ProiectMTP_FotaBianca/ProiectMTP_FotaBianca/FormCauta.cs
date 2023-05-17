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

namespace ProiectMTP_FotaBianca
{
    public partial class FormCauta : Form
    {
        public FormCauta()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            if (textBox1.Text == "")
            {
                MessageBox.Show("Introduce elementul de cautat");
            
            }
            else
            {
 //cautare nume
            SqlConnection com = new SqlConnection("Data Source=Bianca\\SQLEXPRESS;Initial Catalog=Loginform;Integrated Security=True");
            com.Open();
            string stmt = "select * from Produse where ProdNume='" + textBox1.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(stmt, com);
            DataSet ds = new DataSet();
            da.Fill(ds, "Produse");
            dataGridView1.DataSource = ds.Tables["Produse"].DefaultView;
            com.Close();
            da.Dispose();
            ds.Dispose();
            }
           
        }

        private void button2_Click(object sender, EventArgs e)

        {

            //cautare id
            SqlConnection com = new SqlConnection("Data Source=Bianca\\SQLEXPRESS;Initial Catalog=Loginform;Integrated Security=True");
            com.Open();
            string stmt = "select * from Produse where ID='" + textBox2.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(stmt, com);
            DataSet ds = new DataSet();
            da.Fill(ds, "Produse");
            dataGridView1.DataSource = ds.Tables["Produse"].DefaultView;
            com.Close();
            da.Dispose();
            ds.Dispose();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            FormMain main = new FormMain();
            main.Show();
            this.Hide();
        }
    }
}
