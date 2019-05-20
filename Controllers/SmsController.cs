using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;
using Twilio.AspNet.Common;
using Twilio.AspNet.Mvc;
using Twilio.TwiML;
using System.Web.Mvc;

namespace WebApplication6.Controllers
{
    public class SmsController : TwilioController
    {
        // GET: Sms
        public ActionResult SendSMS()
        {
            const string accountSid = "ACf8330fcc3ede57b663dbede2858535d0";
            const string authToken = "5eb820b34245cef33060f9e34d0b61b9";
            TwilioClient.Init(accountSid, authToken);

            var message = MessageResource.Create(
                body: "Thank you for registering to Max's Tech and Math Site!",
                from: new PhoneNumber("+19376391990"),
                to: new PhoneNumber("+19376384972")
            );

            return View();
        }

        public ActionResult ReceiveSMS()
        {
            var response = new MessagingResponse();
            response.Message("You are very welcome for me registering to your site.");
            return TwiML(response);
        }
    }
}