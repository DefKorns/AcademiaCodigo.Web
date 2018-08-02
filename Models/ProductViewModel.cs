using System.Collections.Generic;

namespace AcademiaCodigo.Web.Models
{
    public class ProductViewModel
    {
        public IReadOnlyCollection<ProductSearchItemModel> Products {get; set;}

        public ProductSearchQueryModel Filter {get;set;}
    }
}