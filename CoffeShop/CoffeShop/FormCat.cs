using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProiectMTP_FotaBianca
{
    public partial class FormCat : Form 
    {
        public FormCat()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAdaugare_Click(object sender, EventArgs e)
        {
            SqlConnection com = new SqlConnection("Data Source=Bianca\\SQLEXPRESS;Initial Catalog=Loginform;Integrated Security=True");

            string query = "insert into Categorii (id,CatNume, CatDescriere) values(@id, @nume, @descr)";
            SqlCommand sc = new SqlCommand(query, com);
            sc.CommandTimeout = 60;
            com.Open();
            sc.Parameters.AddWithValue("@id", textBox1.Text);
            sc.Parameters.AddWithValue("@nume", textBox2.Text);
            sc.Parameters.AddWithValue("@descr", textBox3.Text);
         

            SqlDataReader myReader = sc.ExecuteReader();
            com.Close();
            MessageBox.Show("Adaugare reusita!");


        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            SqlConnection com = new SqlConnection("Data Source=Bianca\\SQLEXPRESS;Initial Catalog=Loginform;Integrated Security=True");
            com.Open();
            string tabel_date = "select * from Categorii";
            SqlDataAdapter da = new SqlDataAdapter(tabel_date, com);
            DataSet ds = new DataSet();
            da.Fill(ds, "Categorii");
            dataGridView1.DataSource = ds.Tables["Categorii"].DefaultView;
            com.Close();
        }

        private void lblCat_Click(object sender, EventArgs e)
        {

      
                FormCat formCat = new FormCat();
                formCat.Show();
                this.Hide();
           
        }

        private void lblProd_Click(object sender, EventArgs e)
        {
            FormMain formProd = new FormMain();
            formProd.Show();
            this.Hide();
        }

        private void lblLogout_Click(object sender, EventArgs e)
        {
            Form1 formLogin= new Form1();
            formLogin.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

                if (selectedRow != null)
                {
                    textBox1.Text = selectedRow.Cells[0].Value.ToString();
                    textBox2.Text = selectedRow.Cells[1].Value.ToString();
                    textBox3.Text = selectedRow.Cells[2].Value.ToString();
               
                }
            }
        }

        private void btnActualizare_Click(object sender, EventArgs e)
        {

            SqlConnection com = new SqlConnection("Data Source=Bianca\\SQLEXPRESS;Initial Catalog=Loginform;Integrated Security=True");
            string query = "UPDATE Categorii SET CatNume='" + textBox2.Text + "',CatDescriere='" +textBox3.Text + "' where id=" + textBox1.Text + "";
            SqlCommand sc = new SqlCommand(query, com);
            com.Open();
            SqlDataReader myReader = sc.ExecuteReader();
            com.Close();
            MessageBox.Show("Update reusit!");
        }

        private void textBox1_Validated(object sender, EventArgs e)
        {

        }

        private void textBox2_Validated(object sender, EventArgs e)
        {

        }

        private void textBox3_Validated(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
                    }

        private void btnCategorii_Click(object sender, EventArgs e)
        {
            FormCat form=new FormCat();
            form.Show();
            this.Hide();
                  
        }

        private void btnProd_Click(object sender, EventArgs e)
        {
            FormMain form = new FormMain();
            form.Show();
            this.Hide();
        }

        private void btnStergere_Click(object sender, EventArgs e)
        {
            string numeCat = Interaction.InputBox("Introduceți numele produsului pe care doriți să-l ștergeți:", "Ștergere produs", "");

            if (!string.IsNullOrEmpty(numeCat))
            {
                SqlConnection con = new SqlConnection("Data Source=Bianca\\SQLEXPRESS;Initial Catalog=Loginform;Integrated Security=True");
                con.Open();
                string query = "DELETE FROM Categorii WHERE CatNume=@numeCat";
                SqlCommand com = new SqlCommand(query, con);
                com.Parameters.AddWithValue("@numeCat", numeCat);
                com.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Produsul a fost șters cu succes!");
            }
        }
    }
}
