using Microsoft.AspNetCore.Mvc;
using SalesWebAppMvc.Services;
using SalesWebAppMvc.Models;
using SalesWebAppMvc.Models.ViewsModels;
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
        private readonly DepartmentService _departmentrService;

        public SellersController(SellerService sellerService, DepartmentService departmentrService)
        {
            // LIGAÇÃO DA AREA DE SERVIÇOS DE SELLERS
            _sellerService = sellerService;
            _departmentrService = departmentrService;
        }
        public IActionResult Index()
        {
            var list = _sellerService.FindAll(); // LISTA QUE PEGA TODOS OS DADOS DE SELLERS

            return View(list); // MOSTRA NA PAGINA
        }

        public IActionResult Create()
        {
            var departments = _departmentrService.FindAll();
            var viewModel = new SellerFormViewModels { Departments = departments };
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Seller seller)
        {
            _sellerService.Insert(seller);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var obj = _sellerService.FindById(id.Value);

            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id)
        {
            _sellerService.Remove(id);
            return RedirectToAction("Index");
        }
    }
}
