using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MultRH_MVC.Controllers
{
    public class ClientController : Controller
    {
        public IActionResult Create()
        {
            return View();
        }
    }
}
