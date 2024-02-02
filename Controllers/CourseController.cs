using Microsoft.AspNetCore.Mvc;

namespace UdAkademi.Controllers
{
 public class  CourseControllers : Controller
 {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Apply()
        {
            return View();
        }
 }

}