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
    public partial class Form5 : Form
    {

        public int ide;
        public int? id;
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (CapaDatos.veterinariaEntities datos = new CapaDatos.veterinariaEntities())
            {
                
                CapaDatos.mascotas mas = new CapaDatos.mascotas();
                mas.nombre_mascota = textBox1.Text;
                mas.raza = textBox2.Text;
                mas.peso = int.Parse(textBox4.Text);
                mas.edad_mascota = int.Parse(textBox5.Text);
                mas.descripcion = richTextBox1.Text;

                datos.mascotas.Add(mas);
                datos.SaveChanges();
                this.Close();
                Form8 admi = new Form8(ide,id);
                admi.Show();
                this.Close();

            }
        }
    }
}
