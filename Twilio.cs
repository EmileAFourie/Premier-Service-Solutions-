using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twilio;
using Twilio.Rest.Api.V2010.Account;

namespace Premier_Service_Solutions
{
    public class TwilioService
    {
       // private string accountSid = \

        public void SendMessage(string toPhoneNumber, string message)
        {
            // Initialize the Twilio client
           // TwilioClient.Init(accountSid, authToken);

            // Compose SMS message
            var messageOptions = new CreateMessageOptions(new Twilio.Types.PhoneNumber(toPhoneNumber))
            {
                Body = message,
                From = new Twilio.Types.PhoneNumber("+18156459747") // Add your Twilio phone number here
            };

            var sentMessage = MessageResource.Create(messageOptions);

            Console.WriteLine("SMS notification sent.");
        }

        public void SendTicketNotification(string technicianPhoneNumber, string ticketID, string description)
        {
            // Compose SMS message for ticket notification
            string smsMessage = $"New ticket available!\nJob ID: {ticketID}\nDescription: {description}";

            // Send SMS notification to technician
            SendMessage(technicianPhoneNumber, smsMessage);
        }
    }
}
