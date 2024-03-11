using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LibraryApp
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtISBN.Text = "";
            txtTitlu.Text = "";
            txtAutor.Text = "";
            cmbDomeniu.Text = "";
            txtEditura.Text = "";
            textBox1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Connection.ConnectionString))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand("INSERT_Carte", connection);
                    command.CommandType = CommandType.StoredProcedure;

                    // Set the parameters for the stored procedure
                    command.Parameters.AddWithValue("@ISBN", txtISBN.Text);
                    command.Parameters.AddWithValue("@Titlu", txtTitlu.Text);
                    command.Parameters.AddWithValue("@Autor", txtAutor.Text);
                    command.Parameters.AddWithValue("@Domeniu", cmbDomeniu.Text);
                    command.Parameters.AddWithValue("@Editura", txtEditura.Text);
                    command.Parameters.AddWithValue("@Anul_Editarii", textBox1.Text);

                    command.ExecuteNonQuery();
                    MessageBox.Show("Carte inserată cu succes!");
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show("Eroare SQL: " + sqlEx.Message);
            }
            catch (FormatException formatEx)
            {
                MessageBox.Show("Eroare de format: " + formatEx.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare: " + ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ShowCarti showCarti = new ShowCarti();
            showCarti.Show();
        }
    }
}
