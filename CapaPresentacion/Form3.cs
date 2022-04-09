using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 ingreso = new Form1();
            ingreso.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form7 vet = new Form7();
            vet.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form9 vet = new Form9();
            vet.Show();
        }
    }
}
