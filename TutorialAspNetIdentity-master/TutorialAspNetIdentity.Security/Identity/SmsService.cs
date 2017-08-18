using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Twilio;

namespace TutorialAspNetIdentity.Security.Identity
{
    public class SmsService : IIdentityMessageService
    {
        public Task SendAsync(IdentityMessage message)
        {
            if (ConfigurationManager.AppSettings["Internet"] == "true")
            {
                // Utilizando TWILIO como SMS Provider.
                // https://www.twilio.com/docs/quickstart/csharp/sms/sending-via-rest

                const string accountSid = "AC3843157d6cc1db8219f0dfb11986749d";
                const string authToken = "1030dfe1ec95aa9fa29d027e59a389ec";

                var client = new TwilioRestClient(accountSid, authToken);

                client.SendMessage("+12018498559", message.Destination, message.Body);
            }

            return Task.FromResult(0);
        }
    }
}
