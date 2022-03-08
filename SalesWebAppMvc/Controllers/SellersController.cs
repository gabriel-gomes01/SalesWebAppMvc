using Microsoft.AspNetCore.Mvc;
using SalesWebAppMvc.Services;
using SalesWebAppMvc.Models;
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

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Seller seller)
        {
            _sellerService.Insert(seller);
            return RedirectToAction(nameof(Index));
        }
    }
}
