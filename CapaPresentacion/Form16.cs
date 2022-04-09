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
    public partial class Form16 : Form
    {
        public int ide;
        public int? id;
        public Form16(int ide, int? id)
        {
            InitializeComponent();
            this.id = id;
            this.ide = ide;
        }

        private void Form16_Load(object sender, EventArgs e)
        {
            obtenerdatos();
        }
        private void obtenerdatos()
        {
            using (CapaDatos.veterinariaEntities datos = new CapaDatos.veterinariaEntities())
            {
                var listado = from b in datos.vacunas
                              select new { b.id_vacu, b.nombre_vacu, b.cantidad, b.valor };
                dataGridView1.DataSource = listado.ToList();


               /* DataTable t = new DataTable();
                t.Columns.Add("Cantidad", typeof(Decimal));
                t.Columns.Add("Precio", typeof(Decimal));
                DataColumn c = t.Columns.Add("Importe", typeof(Decimal));
                c.Expression = "[Cantidad] * [Valor]";
                this.dataGridView1.DataSource = t;*/
                int total = 0;
                int valor = 0;
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    valor = int.Parse(row.Cells["cantidad"].Value.ToString())*int.Parse(row.Cells["valor"].Value.ToString())+ int.Parse(row.Cells["cantidad"].Value.ToString()) * int.Parse(row.Cells["valor"].Value.ToString());
                    total += int.Parse(row.Cells["valor"].Value.ToString());
                }
                textBox1.Text = valor.ToString();
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

                Form14 edit = new Form14 (ide,id);

                edit.ShowDialog();
                obtenerdatos();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
