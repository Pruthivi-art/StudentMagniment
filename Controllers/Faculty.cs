using Microsoft.AspNetCore.Mvc;

namespace mvc_first_proj.Controllers
{
    public class Faculty : Controller
    {
        public IActionResult Faculty_Dashbord()
        {
            return View();
        }
    }
}
