using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryApp
{
    public partial class ShowCarti : Form
    {
        public ShowCarti()
        {
            InitializeComponent();
        }

        private void ShowCarti_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bibliotecaDataSet2.Carte' table. You can move, or remove it, as needed.
            this.carteTableAdapter.Fill(this.bibliotecaDataSet2.Carte);

        }
    }
}
