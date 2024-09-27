using Microsoft.AspNetCore.Mvc;

namespace Ly_Dat_Personal.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Professional()
        {
            return View();
        }

        public IActionResult Personal()
        {
            return View();
        }

        public FileResult Resume()
        {
            return File("~/Attachments/Dat_Ly_Resume.pdf", "application/pdf");
        }
    }
}