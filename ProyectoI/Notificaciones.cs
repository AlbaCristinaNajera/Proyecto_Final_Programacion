using System;
using System.Net;
using System.Net.Mail;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoI
{
    public partial class Notificaciones : Form
    {
        const string Usuario = "aluciasandovalp@gmail.com";
        const string Password = "hitw qayo ozyi qlnm";

        public Notificaciones()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            string Error = "";
            StringBuilder MensajeBuilder = new StringBuilder();
            MensajeBuilder.Append(txtMensaje.Text.Trim());
            EnviarCorreo(MensajeBuilder, DateTime.Now, txtDe.Text.Trim(), txtPara.Text.Trim(), txtAsunto.Text.Trim(), out Error);
        }
        public static void EnviarCorreo(StringBuilder Mensaje, DateTime FechaEnvio, string De, string Para, string Asunto, out string Error)
        {
            Error = " ";
            try
            {
                Mensaje.Append(Environment.NewLine);
                Mensaje.Append(string.Format("Este correo ha sido enviado el dia {0:dd/MM/yyyy} a las {0:HH;mm:ss}Hrs: \n\n", FechaEnvio));
                Mensaje.Append(Environment.NewLine);
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress(De);
                mail.To.Add(Para);
                mail.Subject = Asunto;  
                mail.Body = Mensaje.ToString();
                SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                smtp.Port = 587;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential(Usuario, Password);    
                smtp.EnableSsl = true;
                smtp.Send(mail);
                Error = "Tu correo ha sido enviado";
                MessageBox.Show(Error);

            }
            catch (Exception ex) 
            {
                Error = "Error: " + ex.Message;
                MessageBox.Show(Error);
                return;
            }






        }   
    }
}