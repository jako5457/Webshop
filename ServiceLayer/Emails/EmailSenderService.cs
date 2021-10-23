using ServiceLayer.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;

namespace ServiceLayer.Emails
{
    public class EmailSenderService : IEmailSenderService
    {

        private readonly MailAddress _From;
        private readonly SmtpClient _SmtpClient;

        public EmailSenderService(SmtpClient smtpClient,string emailfrom)
        {
            _SmtpClient = smtpClient;
            _From = new MailAddress(emailfrom);
        }

        public async Task SendRecieptAsync(OrderDto order, List<OrderProductDto> products)
        {
            MailMessage message = new MailMessage();

            message.To.Add(new MailAddress(order.Email));
            message.From = _From;
            message.Sender = _From;
            message.Subject = "Reciept";
            message.IsBodyHtml = true;

            string RecieptInfo = "<div>" +
                $"<p>Name: {order.FirstName} {order.LastName}</p>" +
                $"<p>Email: {order.Email}</p>" +
                "</div>";

            string OrderInfo = "<table style='Width:100%'>" +
                "<thead>" +
                "<tr>" +
                "<th style='border:solid black;margin:0'>Product</th>" +
                "<th style='border:solid black;margin:0'>Price</th>" +
                "<th style='border:solid black;margin:0'>Amount</th>" +
                "<th style='border:solid black;margin:0'>Total</th>" +
                "</tr>" +
                "</thead><tbody>";

            double Total = 0;

            foreach (var prod in products)
            {
                OrderInfo += "<tr>" +
                $"<td>{prod.Name}</td>" +
                $"<td>{prod.Price}kr.</td>" +
                $"<td>{prod.Amount}</td>" +
                $"<td>{prod.Price * prod.Amount}kr.</td>" +
                "</tr>";
                Total = Total + (prod.Price * prod.Amount);
            }

            OrderInfo += "</tbody></table>";

            message.Body = $"<h1>Reciept</h2>" + RecieptInfo + "<br><hr>" + OrderInfo + "<br><hr>" + $"<h3>Total: {Total}Kr.</h3>";

            await _SmtpClient.SendMailAsync(message);
        }
    }
}
