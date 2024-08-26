using Microsoft.AspNetCore.Mvc;
using MultRH_MVC.Models;
using MultRH_MVC.Models.ViewModels;
using System.Diagnostics;

namespace MultRH_MVC.Controllers
{
    public class PaymentController : Controller
    {
        private readonly ILogger<PaymentController> _logger;
        public PaymentController(ILogger<PaymentController> logger)
        {
            _logger = logger;
        }
        public IActionResult Payment()
        {
            return View();
        }
        
       

    }
}
