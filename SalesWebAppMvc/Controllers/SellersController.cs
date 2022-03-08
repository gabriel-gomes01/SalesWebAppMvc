using Microsoft.AspNetCore.Mvc;
using SalesWebAppMvc.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebAppMvc.Controllers
{
    public class SellersController : Controller
    {
        // PAGINA RESPONSAVEL POR ENVIAR DADOS DA PAGINA PRINCIPAL
        private readonly SellerService _sellerService;

        public SellersController(SellerService sellerService)
        {
            // LIGAÇÃO DA AREA DE SERVIÇOS DE SELLERS
            _sellerService = sellerService;
        }
        public IActionResult Index()
        {
            var list = _sellerService.FindAll(); // LISTA QUE PEGA TODOS OS DADOS DE SELLERS

            return View(list); // MOSTRA NA PAGINA
        }
    }
}
