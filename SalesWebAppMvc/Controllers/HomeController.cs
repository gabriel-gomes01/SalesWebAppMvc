using Microsoft.AspNetCore.Mvc;
using SalesWebAppMvc.Models;
using SalesWebAppMvc.Models.ViewsModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebAppMvc.Controllers
{
    // PAGINA RESPONSAVEL POR ENVIAR DADOS DA PAGINA PRINCIPAL
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //ENVIO DA VIEW, MOSTRA A VIEW
            return View();
        }

        public IActionResult About()
        {
            //ENVIO DA PAGINA ABOUT

            //DICIONARIOS RESPONSAVEIS POR TEXTOS DE MENSSAGEM E DEV
            ViewData["Message"] = "This site will be to manege Sales";
            ViewData["Dev"] = "Gabriel Gomes";

            return View(); // ENVIA A PAGINA
        }

        public IActionResult Contact()
        {
            //ENVIO DA PAGINA CONTACT

            //DICIONARIOS RESPONSAVEIS POR TEXTO DE MENSSAGEM
            ViewData["Message"] = "Your contact page.";

            return View(); // MOSTRA NA TELA
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}