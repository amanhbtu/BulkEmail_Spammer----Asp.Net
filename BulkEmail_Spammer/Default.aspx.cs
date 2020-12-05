using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BulkEmail_Spammer
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAction_Click(object sender, EventArgs e)
        {
            if (txtemailid.Value.Trim() != "")
            {
                int n = Convert.ToInt32(txtnofemails.Value);
                int a = 0;
                while (++a<=n)
                {
                    sendmail(txtemailid.Value, otp() + " " + txtmsg.Value + " " + otp(), txtsub.Value + " " + otp());
                }
            }
        }

        public void sendmail(String to, String msg, String sub)
        {
            MailMessage mm = new MailMessage("noreply@gmail.com", to);
            mm.Subject = sub;
            mm.Body = msg;
            mm.IsBodyHtml = true;
            mm.ReplyTo = mm.Sender = new MailAddress("noreply@gmail.com");
            SmtpClient smtp = new SmtpClient("smtp.gmail.com,587");
            smtp.Host = "smtp.gmail.com";
            smtp.EnableSsl = true;
            NetworkCredential NetworkCred = new NetworkCredential("tansharma8787@gmail.com", "Qwerty@123");
            smtp.UseDefaultCredentials = true;
            smtp.Credentials = NetworkCred;
            smtp.Port = 587;
            smtp.Send(mm);
            //for alert
            //ClientScript.RegisterStartupScript(GetType(), "alert", "alert('Email sent.');", true);
        }
        public String otp()
        {
            string alphabets = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            //string small_alphabets = "abcdefghijklmnopqrstuvwxyz";
            string numbers = "1234567890";
            string characters = numbers + alphabets;
            int length = 6;
            string otp = string.Empty;
            for (int i = 0; i < length; i++)
            {
                string character = string.Empty;
                do
                {
                    int index = new Random().Next(0, characters.Length);
                    character = characters.ToCharArray()[index].ToString();
                } while (otp.IndexOf(character) != -1);
                otp += character;
            }
            return otp;
        }
    }
}