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
    public partial class Form14 : Form
    {
        public int ide;
        public int? id;
        public Form14(int ide, int? id)
        {
            InitializeComponent();
            this.ide = ide;
            this.id = id;
        }

        private void obtenerdatos()
        {
            using (CapaDatos.veterinariaEntities datos = new CapaDatos.veterinariaEntities())
            {
                var listado = from b in datos.vacunas
                              select new { b.id_vacu, b.nombre_vacu, b.cantidad, b.valor };
                dataGridView1.DataSource = listado.ToList();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int? id = null;
            Form15 vacu = new Form15(ide, id);
            vacu.ShowDialog();
            obtenerdatos();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int? id = int.Parse(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString());
            if (id != null)
            {
                Form15 edit = new Form15(ide, id);
                edit.ShowDialog();
                obtenerdatos();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int? id = int.Parse(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString());
            if (id != null)
            {
                using (CapaDatos.veterinariaEntities datos = new CapaDatos.veterinariaEntities())
                {
                    CapaDatos.vacunas listado = datos.vacunas.Find(id);
                    datos.vacunas.Remove(listado);
                    datos.SaveChanges();
                }
                obtenerdatos();
            }
        }

        private void Form14_Load(object sender, EventArgs e)
        {
            obtenerdatos();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form8 admi = new Form8(ide, id);
            admi.Show();
            this.Close();
        }
    }
}
