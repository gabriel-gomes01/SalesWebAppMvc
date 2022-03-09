using Microsoft.EntityFrameworkCore;
using SalesWebAppMvc.Data;
using SalesWebAppMvc.Models;
using SalesWebAppMvc.Services.Exceptions;
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

        public void Insert(Seller obj)
        {
            _context.Add(obj);
            _context.SaveChanges();

        }

        public Seller FindById(int id)
        {
            return _context.Seller.Include(obj => obj.Department).FirstOrDefault(obj => obj.Id == id);
        }

        public void Remove(int id)
        {
            var obj = _context.Seller.Find(id);
            _context.Seller.Remove(obj);
            _context.SaveChanges();
        }

        public void Update(Seller obj)
        {
            if (!_context.Seller.Any(x => x.Id == obj.Id))
            {
                throw new NotFoundException("Id not Found");
            }
            try
            {
                _context.Update(obj);
                _context.SaveChanges();
            }
            catch (DbUpdateConcurrencyException e)
            {
                throw new DbConcurrencyException(e.Message);
            }

        }
    }
}