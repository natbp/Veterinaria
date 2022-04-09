using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class Form9 : Form
    {
        public int ide;
        public int? id;
        public Form9()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 inicio = new Form3();
            inicio.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String Usuario = textBox1.Text;
            String password = textBox2.Text;
            loguearse(Usuario, password);
            Form8 admin = new Form8(ide,id);
            admin.Show();
            this.Close();
        }

        private void loguearse(String usuario, String password)
        {


            using (CapaDatos.veterinariaEntities datos = new CapaDatos.veterinariaEntities())
            {
                byte[] tmpSource = Encoding.ASCII.GetBytes(password);
                byte[] tmpHash = new MD5CryptoServiceProvider().ComputeHash(tmpSource);
                String contrasena = Convert.ToBase64String(tmpHash);
                var lista = datos.administracion.Where(C => C.nombre_admi == usuario && C.contrasena_admi == contrasena);

                if (lista.Count() == 1)
                {
                    foreach (var Datos in lista.ToList())
                    {
                        if (Datos.nombre_admi == "admin")
                        {
                            MessageBox.Show("Bienvenido " + Datos.nombre_admi);
                            textBox1.Text = "";

                            //Form Control = new Admin();
                            //Control.Show();

                            this.Hide();
                        }
                    }
                }
            }

        }

        private void Form9_Load(object sender, EventArgs e)
        {

        }
    }
}
