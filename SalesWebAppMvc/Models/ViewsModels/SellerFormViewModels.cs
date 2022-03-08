using System.Collections.Generic;

namespace SalesWebAppMvc.Models.ViewsModels
{
    public class SellerFormViewModels
    {
        public Seller Seller { get; set; }
        public ICollection<Department> Departments { get; set; }
    }
}
