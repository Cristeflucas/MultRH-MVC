using Microsoft.AspNetCore.Mvc;
using MultRH_MVC.Models;
using MultRH_MVC.Models.ViewModels;
using System.Diagnostics;

namespace MultRH_MVC.Controllers
{
    public class PaymentController : Controller
    {
        
        public IActionResult Payment()
        {
            return View();
        }
        
       

    }
}
