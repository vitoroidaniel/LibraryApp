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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 cititor = new Form1();
            cititor.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 carte = new Form2();
            carte.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 imprumut = new Form3();
            imprumut.Show();
        }
    }
}
