using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class Form10 : Form
    {
        const string usuario = "nata142004@gmail.com";
        const string password = "millos15";
        public Form10() 
        {
            InitializeComponent();
        }
        public static void EnviarCorreo(StringBuilder Mensaje, DateTime FechaEnvio, String De, String Para, String Asunto, out String Error) 
        {
            Error = "";
            try
            {
                Mensaje.Append(Environment.NewLine);
                Mensaje.Append(String.Format("Este Correo ha sido enviado el dia {0:dd/MM/yyyy} a las {0:HH:mm:ss} Hrs: /n/n", FechaEnvio));
                Mensaje.Append(Environment.NewLine);
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress(De);
                 
                mail.To.Add(Para);
                mail.Subject = Asunto;
                mail.Body = Mensaje.ToString();
                SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                smtp.Port = 587;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new System.Net.NetworkCredential(usuario, password);
                smtp.EnableSsl = true;
                smtp.Send(mail);
                Error = "Exito";
                MessageBox.Show(Error);

            }
            catch (Exception ex)
            {
                Error = "Error:  " + ex.Message;
                MessageBox.Show(Error);
                return;

             throw;
            }
        }
        private void Form10_Load(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Error = "";
            StringBuilder Mensajebuiler = new StringBuilder();
            Mensajebuiler.Append(txtmensaje.Text.Trim());
            EnviarCorreo(Mensajebuiler, DateTime.Now, txtDe.Text.Trim(), txtPara.Text.Trim(),txtAsunto.Text.Trim(),out  Error); 
        }
    }
}
 