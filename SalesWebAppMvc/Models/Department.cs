using System.Collections.Generic;
using System;
using System.Linq;

namespace SalesWebAppMvc.Models
{
    public class Department
    {
        // DEPARTAMENTO NÉ
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Seller> Sellers { get; set; } = new List<Seller>(); //LISTA DE VENDEDORES DO DEPARTAMENTO

        public Department() { }

        public Department(int id, string name)
        {
            Id = id;
            Name = name;
        }

        // ADD VENDEDORES
        public void AddSeller(Seller seller)
        {
            Sellers.Add(seller);
        }

        //TOTAL DE VENDAS NO DEPARTAMENTO
        public double TotalSales(DateTime initial, DateTime final)
        {
            return Sellers.Sum(seller => seller.TotalSales(initial, final)); //SOMA A VENDA DOS VENDEDORES COM UM FILTRO DE TEMPO
        }
    }
}