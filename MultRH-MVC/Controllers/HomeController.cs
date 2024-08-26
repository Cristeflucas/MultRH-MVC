using Microsoft.AspNetCore.Mvc;
using MultRH_MVC.Models;
using MultRH_MVC.Models.ViewModels;
using System.Diagnostics;

namespace MultRH_MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var images = new List<ImageModel>
            {
                new ImageModel { ImageUrl = "/images/carousel1.png", Caption = "NÃO PERCA SEU TEMPO", Description = "Faça o cadastro de seu currículo hoje mesmo em nosso banco de dados e vá direto para entrevista na empresa contratante."},
                new ImageModel { ImageUrl = "/images/carousel2.png", Caption = "CURSO DE INFORMÁTICA", Description = "O curso de informática presencial de 80h da MRH CURSOS tem como objetivo, preparar o profissional para o mercado de trabalho, usando de forma correta e eficiente o Windows, word, excel, internet, power point e digitação."},
                new ImageModel { ImageUrl = "/images/carousel3.png", Caption = "CURSO DE AGENTE DE PORTARIA", Description = "Curso online de 40h para Porteiro, Agente de portaria, Recepcionista, Fiscal, Operador de estacionamento."},
               
            };
            return View(images);
        }
     
        public IActionResult Privacy()
        {
            return View();
        }
         public IActionResult Mult()
        {
            ViewData["link"] = "www.multrh.com.br";
            return View();
        }

        
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}