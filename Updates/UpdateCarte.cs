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

namespace LibraryApp
{
    public partial class UpdateCarte : Form
    {
        public UpdateCarte()
        {
            InitializeComponent();
            FillCarteComboBox();
        }

        private void FillCarteComboBox()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Connection.ConnectionString))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand("SELECT Id FROM Carte", connection);
                    SqlDataReader reader = command.ExecuteReader();

                    comboBox1.Items.Clear();

                    while (reader.Read())
                    {
                        comboBox1.Items.Add(reader["Id"].ToString());
                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void UpdateCarte_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Connection.ConnectionString))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand("SELECT * FROM Carte WHERE Id = @Id", connection);
                    command.Parameters.AddWithValue("@Id", comboBox1.SelectedItem.ToString());

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        txtISBN.Text = reader["ISBN"].ToString();
                        txtTitlu.Text = reader["Titlu"].ToString();
                        txtAutor.Text = reader["Autor"].ToString();
                        cmbDomeniu.Text = reader["Domeniu"].ToString();
                        txtEditura.Text = reader["Editura"].ToString();
                        textBox1.Text = reader["Anul_Editarii"].ToString();
                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Connection.ConnectionString))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand("UPDATE_Carte", connection);
                    command.CommandType = CommandType.StoredProcedure;

                    // Set the parameters for the stored procedure
                    command.Parameters.AddWithValue("@Id", comboBox1.SelectedItem.ToString());
                    command.Parameters.AddWithValue("@ISBN", txtISBN.Text);
                    command.Parameters.AddWithValue("@Titlu", txtTitlu.Text);
                    command.Parameters.AddWithValue("@Autor", txtAutor.Text);
                    command.Parameters.AddWithValue("@Domeniu", cmbDomeniu.Text);
                    command.Parameters.AddWithValue("@Editura", txtEditura.Text);
                    command.Parameters.AddWithValue("@Anul_Editarii", int.Parse(textBox1.Text));

                    command.ExecuteNonQuery();
                    MessageBox.Show("Datele cărții au fost actualizate cu succes!");
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

        private void button2_Click(object sender, EventArgs e)
        {
            txtISBN.Text = "";
            txtTitlu.Text = "";
            txtAutor.Text = "";
            cmbDomeniu.Text = "";
            txtEditura.Text = "";
            textBox1.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ShowCarti showCarti = new ShowCarti();
            showCarti.Show();
        }
    }
}
