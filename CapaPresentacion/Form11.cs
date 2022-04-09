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
    public partial class Form11 : Form
    {
        public int ide;
        public int? id;
        public Form11()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form8 admi = new Form8(ide, id);
            admi.Show();
            this.Close();

        }

        private void Form11_Load(object sender, EventArgs e)
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
    }
}
