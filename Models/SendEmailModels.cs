using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Mail;

namespace MeusPedidos.Models
{
    public class SendEmailModels
    {
        public bool Email(string Name, string Email, string Subject, string Body)
        {
            //Define os dados do e-mail
            string nomeRemetente = "Meus Pedidos";
            string emailRemetente = "contato@meuspedidos.com.br";
            string senha = "senha123abc";

            //Host da porta SMTP
            string SMTP = "smtp.dominio.com.br";

            string emailDestinatario = Email;

            string assuntoMensagem = Subject;
            string conteudoMensagem = Body;

            //Cria objeto com dados do e-mail.
            MailMessage objEmail = new MailMessage();

            //Define o Campo From e ReplyTo do e-mail.
            objEmail.From = new System.Net.Mail.MailAddress(nomeRemetente + "<" + emailRemetente + ">");

            //Define os destinatários do e-mail.
            objEmail.To.Add(emailDestinatario);

            //Define a prioridade do e-mail.
            objEmail.Priority = System.Net.Mail.MailPriority.Normal;

            //Define o formato do e-mail HTML (caso não queira HTML alocar valor false)
            objEmail.IsBodyHtml = true;

            //Define título do e-mail.
            objEmail.Subject = assuntoMensagem;

            //Define o corpo do e-mail.
            objEmail.Body = conteudoMensagem;
            
            //Para evitar problemas de caracteres "estranhos", configuramos o charset para "ISO-8859-1"
            objEmail.SubjectEncoding = System.Text.Encoding.GetEncoding("ISO-8859-1");
            objEmail.BodyEncoding = System.Text.Encoding.GetEncoding("ISO-8859-1");

            //Cria objeto com os dados do SMTP
            System.Net.Mail.SmtpClient objSmtp = new System.Net.Mail.SmtpClient();

            //Alocamos o endereço do host para enviar os e-mails              
            objSmtp.Credentials = new System.Net.NetworkCredential(emailRemetente, senha);
            objSmtp.Host = SMTP;
            objSmtp.Port = 587;

            //Enviamos o e-mail através do método .send()
            try
            {
                objSmtp.Send(objEmail);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                //excluímos o objeto de e-mail da memória
                objEmail.Dispose();
            }
        }
    }
}