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
    public partial class Form6 : Form
    {
        public int ide;
        public int? id;
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form8 admi = new Form8(ide,id);
            admi.ShowDialog();
            this.Close();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            obtenerdatos();
        }

        private void obtenerdatos()
        {
            using (CapaDatos.veterinariaEntities datos = new CapaDatos.veterinariaEntities())
            {
                var listado = from b in datos.clientes
                              select new { b.cedula_cli, b.nombre_cli, b.nombre_usuc, b.direccion_cli, b.correo_cli, b.telefono_cli };
                dataGridView1.DataSource = listado.ToList();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
