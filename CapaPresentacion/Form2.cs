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
    public partial class Form2 : Form
    {
        public int ide;
        public int? id;
        public Form2()
        {
            InitializeComponent();
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form6 consulta = new Form6();
            consulta.ShowDialog();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form4 cliente = new Form4();
            cliente.ShowDialog();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form5 mascota = new Form5();
            mascota.ShowDialog();
            this.Close();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void refrescar_vacunas()
        {
            using (CapaDatos.veterinariaEntities datos = new CapaDatos.veterinariaEntities())
            {
                var listado = from b in datos.vacunas
                              select new { b.id_vacu, b.nombre_vacu, b.cantidad, b.valor };
            

            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form16 vac = new Form16(ide,id);
            vac.Show();
            refrescar_vacunas();

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void refrescar_mascotas()
        {
            using (CapaDatos.veterinariaEntities datos = new CapaDatos.veterinariaEntities())
            {
                var listado = from b in datos.mascotas
                              select new { b.id, b.nombre_mascota, b.edad_mascota, b.raza, b.peso, b.descripcion };


            }

        }


        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Form17 vac = new Form17();
            vac.Show();
            refrescar_mascotas();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form3 inicio = new Form3();
            inicio.Show();
            this.Close();
        }
    }
}
