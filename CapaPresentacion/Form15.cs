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
    public partial class Form15 : Form
    {
        public int? id;
        public int ide;
        CapaDatos.vacunas lista = null;
        public Form15(int ide, int? id)
        {
            InitializeComponent();
            this.ide = ide;
            this.id = id;
            if (id != null)
            {
                cargarDatosFormulario();
            }
        }

        private void cargarDatosFormulario()
        {
            using (CapaDatos.veterinariaEntities datos = new CapaDatos.veterinariaEntities())
            {
                lista = datos.vacunas.Find(id);
                textBox1.Text = lista.nombre_vacu;
                textBox2.Text = lista.cantidad.ToString();
                textBox3.Text = lista.valor.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (CapaDatos.veterinariaEntities datos = new CapaDatos.veterinariaEntities())
            {
                if (id == null)
                {
                    lista = new CapaDatos.vacunas();
                }
                lista.nombre_vacu = textBox1.Text;
                lista.cantidad = int.Parse(textBox2.Text);
                lista.valor = int.Parse(textBox3.Text);
                if (id == null)
                {
                    datos.vacunas.Add(lista);
                }
                else
                {
                    datos.Entry(lista).State = System.Data.Entity.EntityState.Modified;
                }
                Form15 nvacu = new Form15(ide, id);
                nvacu.Show();
                this.Close();
                datos.SaveChanges();
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form8 admi = new Form8(ide, id);
            admi.Show();
            this.Close();
        }
    }
}
