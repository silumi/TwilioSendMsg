using System;
using Twilio;
using Twilio.Rest.Api.V2010.Account;

namespace TwilioSend
{
    class Program
    {
        static void Main(string[] args)
        {
        const string accountSid = "AC24be2c58473a315664de0e7518fb8e47";
        const string authToken = "083dbb87783b4fb45633e8d33497048b";

        TwilioClient.Init(accountSid, authToken);

        var message = MessageResource.Create(
            body: "Love my self :) I do !",
            from: new Twilio.Types.PhoneNumber("+18642147841"),
            to: new Twilio.Types.PhoneNumber("+94714774883")
        );

        Console.WriteLine(message.Sid);

        }
    }
}
