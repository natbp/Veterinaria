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
    public partial class Form12 : Form
    {
        public int ide;
        public int? id;
        public Form12()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form8 admi = new Form8(ide,id);
            admi.ShowDialog();
            this.Close();
        }

        private void Form12_Load(object sender, EventArgs e)
        {
            obtenerdatos();
        }

        private void obtenerdatos()
        {
            using (CapaDatos.veterinariaEntities datos = new CapaDatos.veterinariaEntities())
            {
                var listado = from b in datos.veterinarios
                              select new { b.cedula_vet, b.nombre_vet, b.nombre_usuv, b.edad_vet, b.direccion_vet, b.correo_vet, b.telefono_vet, b.eps };
                dataGridView1.DataSource = listado.ToList();
            }
        }
    }
}
