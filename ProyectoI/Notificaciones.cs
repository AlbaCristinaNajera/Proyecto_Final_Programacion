using System;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ProyectoI
{
    public partial class Notificaciones : Form
    {
        public Notificaciones()
        {
            InitializeComponent();
        }

        public void EnviarCorreoNotificacion(string destinatario, string asunto, string mensaje)
        {
            var correo = new MailMessage("tu_email@example.com", destinatario, asunto, mensaje);
            var clienteSmtp = new SmtpClient("smtp.example.com")
            {
                Port = 587,
                Credentials = new NetworkCredential("tu_email@example.com", "tu_contraseña"),
                EnableSsl = true,
            };

            clienteSmtp.Send(correo);
        }
    }
}
