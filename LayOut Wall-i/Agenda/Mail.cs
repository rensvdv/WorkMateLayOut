using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;


namespace LayOut_Wall_i.Agenda
{
    public class Mail
    {
        public SmtpClient Client { get; set; }
        private MailMessage Message;
        public string Email { get; set; }

        public Mail(string email)
        {
            this.Email = email;
            this.Message = new MailMessage();
            this.Client = new SmtpClient($"smtp.gmail.com");
        }

        public void MailVersturen(string titel, string beschrijving, int tijd)
        {
            if (ValideMail())
            {
                StelBerichtOp(titel, beschrijving, tijd);
                StelSmtpGegevensIn();
            }
        }

        public bool ValideMail()
        {
            try
            {
                MailAddress mail = new MailAddress(this.Email);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public void StelBerichtOp(string titel, string beschrijving, int tijd)
        {
            this.Message.To.Add(this.Email);
            this.Message.From = new MailAddress("quicksmash123@gmail.com");
            this.Message.Body = $"{beschrijving} \n {tijd}";
            this.Message.Subject = titel;
            this.Message.BodyEncoding = Encoding.UTF8;
        }
        public void StelSmtpGegevensIn()
        {
            this.Client.EnableSsl = true;
            this.Client.Port = 587;
            this.Client.DeliveryMethod = SmtpDeliveryMethod.Network;
            this.Client.Credentials = new NetworkCredential("quicksmash123@gmail.com", "QuickSmash321!");
            try
            {
                this.Client.SendAsync(this.Message, "Verzenden...");
            }
            catch { return; }
        }
    }
}
