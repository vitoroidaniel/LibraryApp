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
    public partial class ShowCititori : Form
    {
        public ShowCititori()
        {
            InitializeComponent();
        }

        private void ShowCititori_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bibliotecaDataSet.Cititor' table. You can move, or remove it, as needed.
            this.cititorTableAdapter.Fill(this.bibliotecaDataSet.Cititor);

        }
    }
}
