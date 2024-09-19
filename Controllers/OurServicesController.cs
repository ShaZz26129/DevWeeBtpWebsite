using Microsoft.AspNetCore.Mvc;
using System.Reflection;
using WeeBtpWebsite.Models;
using WeeBtpWebsite.Services;

namespace WeeBtpWebsite.Controllers
{
    public class OurServicesController : Controller
    {
        private BrevoMailService _mailService;
        public OurServicesController()
        {
            _mailService = new BrevoMailService();
        }
        public IActionResult Index()
        {
            return View();
        }
        public ActionResult WeeCodeIGNITE()
        {
            return View();
        }
        [HttpPost]
        public ActionResult WeeCodeIGNITE(ContactUsModel model)
        {
            string Name = model.firstName;
            string Email = model.email;
            string PhoneNumber = model.phoneNumber;
            string Subject = model.Subject;
            string Message = model.Message;
            _mailService.SendEmail(Name, Email, Subject, PhoneNumber, Message);
            return View("ThanksPage");
        }
        public ActionResult WeeSecurity360()
        {
            return View();
        }
        [HttpPost]
        public ActionResult WeeSecurity360(ContactUsModel model)
        {
            string Name = model.firstName;
            string Email = model.email;
            string PhoneNumber = model.phoneNumber;
            string Subject = model.Subject;
            string Message = model.Message;
            _mailService.SendEmail(Name, Email, Subject, PhoneNumber, Message);
            return View("ThanksPage");
        }
        public ActionResult WeeCloudSPHERE()
        {
            return View();
        }
        [HttpPost]
        public ActionResult WeeCloudSPHERE(ContactUsModel model)
        {
            string Name = model.firstName;
            string Email = model.email;
            string PhoneNumber = model.phoneNumber;
            string Subject = model.Subject;
            string Message = model.Message;
            _mailService.SendEmail(Name, Email, Subject, PhoneNumber, Message);
            return View("ThanksPage");
        }
        public ActionResult WeeNextgenFLOW()
        {
            return View();
        }
        [HttpPost]
        public ActionResult WeeNextgenFLOW(ContactUsModel model)
        {
            string Name = model.firstName;
            string Email = model.email;
            string PhoneNumber = model.phoneNumber;
            string Subject = model.Subject;
            string Message = model.Message;
            _mailService.SendEmail(Name, Email, Subject, PhoneNumber, Message);
            return View("ThanksPage");
        }
        public ActionResult WeeBlockCENTRAL()
        {
            return View();
        }
        [HttpPost]
        public ActionResult WeeBlockCENTRAL(ContactUsModel model)
        {
            string Name = model.firstName;
            string Email = model.email;
            string PhoneNumber = model.phoneNumber;
            string Subject = model.Subject;
            string Message = model.Message;
            _mailService.SendEmail(Name, Email, Subject, PhoneNumber, Message);
            return View("ThanksPage");
        }
        public ActionResult WeeDatastAIsis()
        {
            return View();
        }
        [HttpPost]
        public ActionResult WeeDatastAIsis(ContactUsModel model)
        {
            string Name = model.firstName;
            string Email = model.email;
            string PhoneNumber = model.phoneNumber;
            string Subject = model.Subject;
            string Message = model.Message;
            _mailService.SendEmail(Name, Email, Subject, PhoneNumber, Message);
            return View("ThanksPage");
        }
        public ActionResult WeePraaS()
        {
            return View();
        }
        [HttpPost]
        public ActionResult WeePraaS(ContactUsModel model)
        {
            string Name = model.firstName;
            string Email = model.email;
            string PhoneNumber = model.phoneNumber;
            string Subject = model.Subject;
            string Message = model.Message;
            _mailService.SendEmail(Name, Email, Subject, PhoneNumber, Message);
            return View("ThanksPage");
        }

    }
}
