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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form4 registro = new Form4();
            registro.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 inicio = new Form3();
            inicio.ShowDialog();
            this.Close();
        }

        private void loguearse(String usuario, String password)
        {
            

                using (CapaDatos.veterinariaEntities datos = new CapaDatos.veterinariaEntities())
                {
                    byte[] tmpSource = ASCIIEncoding.ASCII.GetBytes(password);
                    byte[] tmpHash = new MD5CryptoServiceProvider().ComputeHash(tmpSource);
                    String contrasena = Convert.ToBase64String(tmpHash);
                    var lista = datos.clientes.Where(C => C.nombre_usuc == usuario && C.contrasena_cli == contrasena);

                    if (lista.Count() == 1)
                    {
                        foreach (var Datos in lista.ToList())
                        {
                            
                                MessageBox.Show("Bienvenido " + Datos.nombre_cli);
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
        }
    }
}
