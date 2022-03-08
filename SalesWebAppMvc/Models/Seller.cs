using System;
using System.Linq;
using System.Collections.Generic ;

namespace SalesWebAppMvc.Models
{
    // VENDEDORES
    public class Seller
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public string BaseSalary { get; set; } //MUDAR O TIPO DO BASESALARY PARA DOUBLE, ELE ESTÁ COMO STRING
        public Department Department { get; set; }
        public ICollection<SalesRecord> Sales { get; set; } = new List<SalesRecord>(); // LISTA DE RESGISTRO VENDAS

        public Seller() { }

        public Seller(int id, string name, string email, DateTime birthDate, string baseSalary, Department department)
        {
            Id = id;
            Name = name;
            Email = email;
            BirthDate = birthDate;
            BaseSalary = baseSalary;
            Department = department;
        }

        // ADD VENDAS FEITAS
        public void AddSales(SalesRecord sr)
        {
            Sales.Add(sr);
        }

        // REMOVE AS VENDAS DE UM VENDEDOR
        public void RemoveSales(SalesRecord sr)
        {
            Sales.Remove(sr);
        }

        public double TotalSales(DateTime initial, DateTime final)
        {
            //SOMA DO VALOR DE VENDAS COM UM FILTRO DE TEMPO
            return Sales.Where(sr => sr.Date >= initial && sr.Date <= final).Sum(sr => sr.Amount);
        }
    }
}
