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
        private string accountSid = "AC23b601fb4dbe7e1c1e5ead51dae7dba7"; // Emile Tokens
        private string authToken = "b53cdd8f3ae512c88606caf17c3e1ff7";

        public void SendMessage(string toPhoneNumber, string message)
        {
            // Initialize the Twilio client
            TwilioClient.Init(accountSid, authToken);

            // Compose SMS message
            var messageOptions = new CreateMessageOptions(new Twilio.Types.PhoneNumber(toPhoneNumber))
            {
                Body = message,
                From = new Twilio.Types.PhoneNumber("+13344893749") // Add your Twilio phone number here
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
