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
    public partial class Form13 : Form
    {
        public int ide;
        public int? id;
        public Form13()
        {
            InitializeComponent();
        }

        private void maskedTextBox3_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox4_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox5_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (CapaDatos.veterinariaEntities datos = new CapaDatos.veterinariaEntities())
            {
                byte[] tmpSource;
                byte[] tmpHash;
                CapaDatos.veterinarios vet = new CapaDatos.veterinarios();
                vet.cedula_vet = int.Parse(maskedTextBox1.Text);
                vet.nombre_vet = maskedTextBox2.Text;
                vet.nombre_usuv = maskedTextBox3.Text;
                vet.edad_vet = int.Parse(maskedTextBox4.Text);
                vet.direccion_vet = maskedTextBox5.Text;
                vet.correo_vet = maskedTextBox6.Text;
                vet.telefono_vet = int.Parse(maskedTextBox7.Text);
                vet.eps = maskedTextBox8.Text;
                vet.contrasena_vet = maskedTextBox9.Text;


                tmpSource = ASCIIEncoding.ASCII.GetBytes(maskedTextBox9.Text);
                tmpHash = new MD5CryptoServiceProvider().ComputeHash(tmpSource);
                vet.contrasena_vet = Convert.ToBase64String(tmpHash);
                

                datos.veterinarios.Add(vet);
                datos.SaveChanges();
                this.Close();
                Form8 admi = new Form8(ide, id);
                admi.Show();
                this.Close();

            }
        }
    }
}
