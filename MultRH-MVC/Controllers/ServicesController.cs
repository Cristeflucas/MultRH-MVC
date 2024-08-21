using Microsoft.AspNetCore.Mvc;
using MultRH_MVC.Models;

namespace MultRH_MVC.Controllers
{
    public class ServicesController : Controller
    {
        public IActionResult Index()
        {
            var services = new List<ImageModel>
            {
                new ImageModel {ImageUrl = "/images/bck-curriculos.png"},
                new ImageModel {ImageUrl = "/images/bck-services1.png"},
                new ImageModel {ImageUrl = "/images/bck-services2.png"}
            };
            return View();
        }
    }
}
