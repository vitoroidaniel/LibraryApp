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
    public partial class UpdateImprumut : Form
    {
        public UpdateImprumut()
        {
            InitializeComponent();
            FillImprumutComboBox();
            FillCititorComboBox();
            FillCarteComboBox();
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

                    cmbCititor.Items.Clear();

                    while (reader.Read())
                    {
                        cmbCititor.Items.Add(reader["Id"].ToString());
                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
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

                    cmbCarteImp.Items.Clear();

                    while (reader.Read())
                    {
                        cmbCarteImp.Items.Add(reader["Id"].ToString());
                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void FillImprumutComboBox()
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
            try
            {
                // Verificați dacă este selectat un element în combobox
                if (comboBox1.SelectedItem == null)
                    return;

                int selectedImprumutId = int.Parse(comboBox1.SelectedItem.ToString());

                // Recuperați datele imprumutului selectat din baza de date
                using (SqlConnection connection = new SqlConnection(Connection.ConnectionString))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand("SELECT Id_cititor, Id_carte, Data_imprumut, Data_returnarii FROM Imprumut WHERE Id = @Id", connection);
                    command.Parameters.AddWithValue("@Id", selectedImprumutId);

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        // Completați valorile în controalele corespunzătoare
                        cmbCititor.Text = reader["Id_cititor"].ToString();
                        cmbCarteImp.Text = reader["Id_carte"].ToString();
                        lblCurDate.Text = reader["Data_imprumut"].ToString(); // Dacă acesta este un control Label, este posibil să fie necesară o conversie de formatare
                        dateTimePicker1.Value = Convert.ToDateTime(reader["Data_returnarii"]);
                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Connection.ConnectionString))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand("UPDATE_Imprumut", connection);
                    command.CommandType = CommandType.StoredProcedure;

                    // Set the parameters for the stored procedure
                    command.Parameters.AddWithValue("@Id_cititor", cmbCititor.Text);
                    command.Parameters.AddWithValue("@Id_carte", cmbCarteImp.Text);
                    command.Parameters.AddWithValue("@Data_imprumut", DateTime.Parse(lblCurDate.Text));
                    command.Parameters.AddWithValue("@Data_returnarii", dateTimePicker1.Value);

                    command.ExecuteNonQuery();
                    MessageBox.Show("Imprumut actualizat cu succes!");
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
