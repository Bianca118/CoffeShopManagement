using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Microsoft.VisualBasic;

namespace ProiectMTP_FotaBianca
{
    public partial class FormMain : Form


    {
        public string name = "{?}";


        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            getCategory();
        }



        private void lblQuery_Click(object sender, EventArgs e)
        {

            /*
                        // Conectați-vă la baza de date
                        SqlConnection com = new SqlConnection("Data Source=Bianca\\SQLEXPRESS;Initial Catalog=Loginform;Integrated Security=True");

                        // Deschideți conexiunea
                        com.Open();

                        // Definește interogarea SQL pentru a obține numele utilizatorului curent
                        string query = "SELECT username where username=@username AS CurrentUser";

                        // Creează un obiect SqlCommand și setează interogarea SQL și conexiunea
                        SqlCommand cmd = new SqlCommand(query, com);

                        // Execută comanda și obține rezultatele
                        SqlDataReader reader = cmd.ExecuteReader();

                        // Verificați dacă există rezultate și obțineți numele utilizatorului curent
                        if (reader.HasRows)
                        {
                            reader.Read();
                            string currentUser = reader["CurrentUser"].ToString();

                            // Afișează numele utilizatorului curent într-o casetă de dialog
                           lblQuery.Text = currentUser;
                        }

                        // Închideți reader și conexiunea
                        reader.Close();
                        com.Close();

                    }
                }
            */
        }

        private void getCategory()
        {
            SqlConnection com = new SqlConnection("Data Source=Bianca\\SQLEXPRESS;Initial Catalog=Loginform;Integrated Security=True");
            com.Open();
            string tabel_date = "select * from Categorii";
            SqlDataAdapter da = new SqlDataAdapter(tabel_date, com);
            DataTable d = new DataTable();
            da.Fill(d);
            comboBox1.DataSource = d;
            comboBox1.ValueMember = "CatNume";
            com.Close();
        }
        private void btnAdaugare_Click(object sender, EventArgs e)
        {

            SqlConnection com = new SqlConnection("Data Source=Bianca\\SQLEXPRESS;Initial Catalog=Loginform;Integrated Security=True");
            string query = "insert into Produse values(" + textBox1.Text + ", '" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + comboBox1.Text + "')";
            SqlCommand sc = new SqlCommand(query, com);
            sc.CommandTimeout = 60;
            com.Open();
            SqlDataReader myReader = sc.ExecuteReader();
            com.Close();
            MessageBox.Show("Adaugare reusita!");




        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection com = new SqlConnection("Data Source=Bianca\\SQLEXPRESS;Initial Catalog=Loginform;Integrated Security=True");
            com.Open();
            string tabel_date = "select * from Produse";
            SqlDataAdapter da = new SqlDataAdapter(tabel_date, com);
            DataSet ds = new DataSet();
            da.Fill(ds, "Produse");
            dataGridView1.DataSource = ds.Tables["Produse"].DefaultView;
            com.Close();
        }

        private void btnActualizare_Click(object sender, EventArgs e)
        {
            SqlConnection com = new SqlConnection("Data Source=Bianca\\SQLEXPRESS;Initial Catalog=Loginform;Integrated Security=True");

            string query = "UPDATE  Produse SET ProdNume='" + textBox2.Text + "',ProdCat='" + comboBox1.Text + "', ProdPret= '" + textBox3.Text + "' where ID=" + textBox1.Text + "";
            SqlCommand sc = new SqlCommand(query, com);
            com.Open();
            SqlDataReader myReader = sc.ExecuteReader();
            com.Close();
            MessageBox.Show("Update reusit!");

        }

        private void btnStergere_Click(object sender, EventArgs e)
        {

            string numeProdus = Interaction.InputBox("Introduceți numele produsului pe care doriți să-l ștergeți:", "Ștergere produs", "");

            if (!string.IsNullOrEmpty(numeProdus))
            {
                SqlConnection con = new SqlConnection("Data Source=Bianca\\SQLEXPRESS;Initial Catalog=Loginform;Integrated Security=True");
                con.Open();
                string query = "DELETE FROM Produse WHERE ProdNume=@numeProdus";
                SqlCommand com = new SqlCommand(query, con);
                com.Parameters.AddWithValue("@numeProdus", numeProdus);
                com.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Produsul a fost șters cu succes!");
            }

        }
        private void button2_Click(object sender, EventArgs e)
        {


            FormCauta form3 = new FormCauta();

            // Afișați Form3 și ascundeți Form2
            form3.Show();
            this.Hide();

        }

        private void label7_Click(object sender, EventArgs e)
        {
            FormCat formCat = new FormCat();
            formCat.Show();
            this.Hide();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            FormMain formProd = new FormMain();
            formProd.Show(); this.Hide();

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
                    textBox4.Text = selectedRow.Cells[3].Value.ToString();
                    comboBox1.Text = selectedRow.Cells[4].Value.ToString();
                }
            }
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

        private void textBox4_Validated(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            FormCat formCat = new FormCat();
            formCat.Show();
            this.Hide();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            FormMain formProd = new FormMain();
            formProd.Show(); this.Hide();

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            Form1 formLogin=new Form1();
            formLogin.Show(); this.Hide();
        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void btnProd_Click(object sender, EventArgs e)
        {
            FormMain main = new FormMain();
            main.Show(); this.Hide();
        }

        private void btnCategorii_Click(object sender, EventArgs e)
        {
            FormCat main = new FormCat();
            main.Show(); this.Hide();
        }
    }
}