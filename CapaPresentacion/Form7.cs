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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void loguearse(String usuario, String password)
        {


            using (CapaDatos.veterinariaEntities datos = new CapaDatos.veterinariaEntities())
            {
                byte[] tmpSource = ASCIIEncoding.ASCII.GetBytes(password);
                byte[] tmpHash = new MD5CryptoServiceProvider().ComputeHash(tmpSource);
                String contrasena = Convert.ToBase64String(tmpHash);
                var lista = datos.veterinarios.Where(C => C.nombre_usuv == usuario && C.contrasena_vet == contrasena);

                if (lista.Count() == 1)
                {
                    foreach (var Datos in lista.ToList())
                    {

                        MessageBox.Show("Bienvenido " + Datos.nombre_vet);
                        textBox1.Text = "";

                        //Form Control = new Admin();
                        //Control.Show();

                        this.Hide();

                    }
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña son incorrectos ", "alert");
                }
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            String Usuario = textBox1.Text;
            String password = textBox2.Text;
            loguearse(Usuario, password);
        
        Form2 vet = new Form2();
            vet.ShowDialog();
            this.Close();
        }
    }
}
