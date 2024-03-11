using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Windows.Forms;

namespace LibraryApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtAdress.Text = "";
            txtTelephone.Text = "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Connection.ConnectionString))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand("INSERT_Cititor", connection);
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@Nume_Prenume", txtName.Text);
                    command.Parameters.AddWithValue("@Adresa", txtAdress.Text);
                    command.Parameters.AddWithValue("@Telefon", txtTelephone.Text);


                    command.ExecuteNonQuery();
                    MessageBox.Show("Cititor inserat cu succes!");
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

        private void button1_Click(object sender, EventArgs e)
        {
            // show the form with datagrid view to see the data user insert in table/database
            ShowCititori show = new ShowCititori();
            show.Show();
        }

        private void imprumutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 imprumut = new Form2();
            imprumut.Show();
        }

        private void carteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 carte = new Form3();
            carte.Show();
        }
    }
}
