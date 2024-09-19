using Microsoft.AspNetCore.Mvc;

namespace WeeBtpWebsite.Controllers
{
    public class IndustriesController : Controller
    {
        public IActionResult Finance()
        {
            return View();
        }
        public IActionResult Healthcare()
        {
            return View();
        }
        public IActionResult Retail()
        {
            return View();
        }
        public IActionResult Education()
        {
            return View();
        }
        public IActionResult RealEstate()
        {
            return View();
        }
        public IActionResult Travel()
        {
            return View();
        }
        public ActionResult Other()
        {
            return View();
        }

    }
}
