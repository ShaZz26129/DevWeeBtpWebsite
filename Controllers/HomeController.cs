using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WeeBtpWebsite.Models;
using WeeBtpWebsite.Services;

namespace WeeBtpWebsite.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private BrevoMailService _mailService;
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            _mailService = new BrevoMailService();
        }
        public IActionResult Home()
        {
            return View();
        }
        public IActionResult Index()
        {
            return View();
        }
        public ActionResult Blog()
        {
            return View();
        }
        public ActionResult OurServices()
        {
            return View();
        }
        [HttpPost]
        public ActionResult OurServices(ContactUsModel model)
        {
            string Name = model.firstName;
            string Email = model.email;
            string PhoneNumber = model.phoneNumber;
            string Subject = model.Subject;
            string Message = model.Message;
            _mailService.SendEmail(Name, Email, Subject, PhoneNumber, Message);
            return View("ThanksPage");
        }
        public ActionResult ContactUs()
        {

            return View();
        }
        [HttpPost]
        public ActionResult ContactUs(ContactUsModel model)
        {
            string Name = model.firstName;
            string Email = model.email;
            string PhoneNumber = model.phoneNumber;
            string Subject = model.Subject;
            string Message = model.Message;
            _mailService.SendEmail(Name, Email, Subject, PhoneNumber, Message);
            return View("ThanksPage");
        }
        public ActionResult FreeQuote()
        {

            return View();
        }
        [HttpPost]
        public ActionResult FreeQuote(ContactUsModel model)
        {
            string Name = model.firstName;
            string Email = model.email;
            string PhoneNumber = model.phoneNumber;
            string Subject = model.Subject;
            string Message = model.Message;
            _mailService.SendEmail(Name, Email, PhoneNumber, Subject, Message);
            return View("ThanksPage");
        }
        public IActionResult Privacy()
        {
            return View();
        }
        public ActionResult AboutUs()
        {
            return View();
        }
        public ActionResult TermOfUse()
        {
            return View();
        }
        public ActionResult PrivacyPolicy()
        {
            return View();
        }
        public ActionResult ReadMore()
        {
            return View();
        }
        public ActionResult ThanksPage()
        {
            return View();
        }
        public ActionResult Contact()
        {
            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
