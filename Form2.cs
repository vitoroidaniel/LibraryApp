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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            SetCurrentDate();
            FillCititorComboBox();
            FillCarteComboBox();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            cmbCititor.Text = "";
            cmbCarteImp.Text = "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Connection.ConnectionString))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand("INSERT_Imprumut", connection);
                    command.CommandType = CommandType.StoredProcedure;

                    // Set the parameters for the stored procedure
                    command.Parameters.AddWithValue("@Id_cititor", cmbCititor.Text);
                    command.Parameters.AddWithValue("@Id_carte", cmbCarteImp.Text);
                    command.Parameters.AddWithValue("@Data_imprumut", DateTime.Parse(lblCurDate.Text));
                    command.Parameters.AddWithValue("@Data_returnarii", dateTimePicker1.Value); 

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

        private void SetCurrentDate()
        {
            // Get the current date
            DateTime currentDate = DateTime.Now;

            lblCurDate.Text = currentDate.ToString("dd/MM/yyyy");
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

        private void button3_Click(object sender, EventArgs e)
        {
            ShowImprumut showImprumut = new ShowImprumut();
            showImprumut.Show();
        }
    }
}
