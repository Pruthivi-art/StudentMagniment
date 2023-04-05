using Microsoft.AspNetCore.Mvc;

namespace mvc_first_proj.Controllers
{
    public class student : Controller
    {
        public IActionResult Student_Login()
        {
            return View();
        }
        public IActionResult Student_Profile()
        {
            return View();
        }

        public IActionResult Student_Update()
        {
            return View();
        }
    }
}
