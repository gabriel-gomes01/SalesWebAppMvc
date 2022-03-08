using System;
using SalesWebAppMvc.Data;
using SalesWebAppMvc.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebAppMvc.Services
{
    public class DepartmentService
    {
        private readonly SalesWebAppMvcContext _context;

        public DepartmentService(SalesWebAppMvcContext context)
        {
            // CONEXAO COM O BANCO
            _context = context;
        }

        public List<Department> FindAll()
        {
            // RETORNA OS VENDEDORES
            return _context.Department.OrderBy(x => x.Name).ToList();
        }

    }
}
