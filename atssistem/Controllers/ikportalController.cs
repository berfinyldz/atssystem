using Microsoft.AspNetCore.Mvc;

namespace atssistem.Controllers
{
    public class ikportalController : Controller
    {
        public IActionResult anasayfa()
        {
            return View();
        }
        public IActionResult login()
        {
            return View();
        }
    }
}
