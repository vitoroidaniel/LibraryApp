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
    public partial class UpdateCititor : Form
    {
        public UpdateCititor()
        {
            InitializeComponent();
            FillCititorComboBox();
        }

        private void FillCititorComboBox()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Connection.ConnectionString))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand("SELECT Id FROM Cititor", connection);
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Connection.ConnectionString))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand("UPDATE_Cititor", connection);
                    command.CommandType = CommandType.StoredProcedure;

                    // Set the parameters for the stored procedure
                    command.Parameters.AddWithValue("@Id", int.Parse(comboBox1.SelectedItem.ToString()));
                    command.Parameters.AddWithValue("@Nume_Prenume", txtName.Text);
                    command.Parameters.AddWithValue("@Adresa", txtAdress.Text);
                    command.Parameters.AddWithValue("@Telefon", txtTelephone.Text);

                    command.ExecuteNonQuery();
                    MessageBox.Show("Datele cititorului au fost actualizate cu succes!");
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
    }
}
