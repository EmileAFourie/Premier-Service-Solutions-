using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twilio;
using Twilio.Rest.Api.V2010.Account;

namespace Premier_Service_Solutions
{
    class Twilio
    {
        private string accountSid = "AC23b601fb4dbe7e1c1e5ead51dae7dba7"; //Emile Tokens
        private string authToken = "9790543c1792b1065cf53bdae165aef9";

        public void SendMessage(string toPhoneNumber, string message)
        {
            TwilioClient.Init(accountSid, authToken);

            var messageOptions = new CreateMessageOptions(
                new Twilio.Types.PhoneNumber(toPhoneNumber))
            {
                Body = message,
                From = new Twilio.Types.PhoneNumber("+13344893749") // Add your Twilio phone number here
            };



            var sentMessage = MessageResource.Create(messageOptions);
        }

        // Initialize the Twilio client
        TwilioClient.Init(accountSid, authToken);

 

        // New job details
        string TicketID = "12345";
        string Description = "Install new HVAC system";



        // Employee's phone numbers 
        string technician1PhoneNumber = "+27763237618";



        // Compose SMS message
        string smsMessage = $"New ticket available!\nJob ID: {TicketID}\nDescription: {Description}";



        // Send SMS notifications to technicians
        SendMessage(technician1PhoneNumber, smsMessage);

        Console.WriteLine("SMS notifications sent to Employee.");
    }
    static void SendMessage(string toPhoneNumber, string message)
    {
        var messageOptions = new CreateMessageOptions(
            new Twilio.Types.PhoneNumber(toPhoneNumber))
        {
            Body = message,
            From = new Twilio.Types.PhoneNumber("+13344893749") // Add your Twilio phone number here
        };



        var sentMessage = MessageResource.Create(messageOptions);
    }

}
}
