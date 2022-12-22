using RentACar.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace RentACar.Helpers
{
    public class EmailHelper
    {

        public static void SendMailToValidate(string code,string email)
        {
            using (MailMessage mail = new MailMessage())
            {

                mail.From = new MailAddress("ahmadovali31@gmail.com");
                mail.To.Add(email);
                mail.Subject = "Validation";
                mail.Body = $@"Dear Client,

Don't share this code with others. Please enter the code below for validation.
{code}

Best Regards,
A.A";
                mail.IsBodyHtml = false;

                using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
                {
                    smtp.Credentials = new NetworkCredential("ahmadovali31@gmail.com", "hdepgeopyuiucrky");
                    smtp.EnableSsl = true;
                    try
                    {
                        smtp.Send(mail);
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("Error");
                    }
                }
            }
        }




        public static void SendMailToInform( Rent rent, string email,decimal totalPrice)
        {
            using (MailMessage mail = new MailMessage())
            {

                mail.From = new MailAddress("ahmadovali31@gmail.com");
                mail.To.Add(email);
                mail.Subject = "Car Detailed Info";
                mail.Body = $@"Dear Client,

You have successfully rented {rent.Car.Brand}({rent.Car.Year}).

Rent Start Date: {rent.RentStartDate}
Rent End Date: {rent.RentEndDate}
Rent Price: {totalPrice}


You can also check your rent status with rent key below:
{rent.RentKey}

Best Regards,
A.A";
                mail.IsBodyHtml = false;

                using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
                {
                    smtp.Credentials = new NetworkCredential("ahmadovali31@gmail.com", "hdepgeopyuiucrky");
                    smtp.EnableSsl = true;
                    try
                    {
                        smtp.Send(mail);
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("Error");
                    }
                }
            }
        }

    }
}

