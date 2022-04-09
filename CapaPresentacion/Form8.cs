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
    public partial class Form8 : Form
    {
        public int ide;
        public int? id;
        public Form8(int ide, int? id)
        {
            InitializeComponent();
            this.ide = ide;
            this.id = id;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
         
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form10 correo = new Form10();
            correo.ShowDialog();
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form11 mas = new Form11();
            mas.ShowDialog();
            this.Close();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form13 regis = new Form13();
            regis.Show();
            this.Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Form6 cli = new Form6();
            cli.ShowDialog();
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form12 vet = new Form12();
            vet.ShowDialog();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form14 vacu = new Form14(ide, id);
            vacu.Show();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form3 inicio = new Form3();
            inicio.Show();
            this.Close();
        }
    }
}
