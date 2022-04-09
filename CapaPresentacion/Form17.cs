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
    public partial class Form17 : Form
    {
        public Form17()
        {
            InitializeComponent();
        }

        private void Form17_Load(object sender, EventArgs e)
        {
            obtenerdatos();
        }

        private void obtenerdatos()
        {
            using (CapaDatos.veterinariaEntities datos = new CapaDatos.veterinariaEntities())
            {
                var listado = from b in datos.mascotas
                              select new { b.id, b.nombre_mascota, b.edad_mascota, b.raza, b.peso, b.descripcion };
                dataGridView1.DataSource = listado.ToList();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int? id = int.Parse(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString());
            if (id != null)
            {

                CapaPresentacion.Form5 edit = new CapaPresentacion.Form5();

                edit.ShowDialog();
                obtenerdatos();
            }
        }
    }
}
