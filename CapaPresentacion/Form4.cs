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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            login.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (CapaDatos.veterinariaEntities datos = new CapaDatos.veterinariaEntities())
            {
                
                CapaDatos.clientes cli = new CapaDatos.clientes();
                cli.cedula_cli = int.Parse(textBox1.Text);
                cli.nombre_cli = textBox2.Text;
                cli.nombre_usuc = textBox3.Text;
                cli.contrasena_cli = textBox4.Text;
                cli.correo_cli = textBox5.Text;
                cli.direccion_cli = textBox6.Text;
                cli.telefono_cli = int.Parse(textBox7.Text);


              
                datos.clientes.Add(cli);
                datos.SaveChanges();
                this.Close();
                Form1 login = new Form1();
                login.ShowDialog();
                this.Close();

            }
        }
    }
}
