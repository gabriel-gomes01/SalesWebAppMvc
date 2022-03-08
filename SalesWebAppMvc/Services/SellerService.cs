using SalesWebAppMvc.Data;
using SalesWebAppMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebAppMvc.Services
{
    public class SellerService
    {
        private readonly SalesWebAppMvcContext _context;

        public SellerService(SalesWebAppMvcContext context)
        {
            // CONEXAO COM O BANCO
            _context = context;
        }

        public List<Seller> FindAll()
        {
            // RETORNA OS VENDEDORES
            return _context.Seller.ToList();
        }
    }
}