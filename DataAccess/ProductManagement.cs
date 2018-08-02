using System;
using System.Collections.Generic;
using AcademiaCodigo.Web.Models;

namespace AcademiaCodigo.Web.DataAccess {
    public class ProductManagement {
        public ProductModel Get (string code) {
            BaseClient client = new BaseClient ();
            return client.Get<ProductModel> ("products", code);
        }

        public IReadOnlyCollection<ProductSearchItemModel> Search (
            string code, string name, decimal? minPrice, decimal? maxPrice, bool? isActive,
            int skip, int take
        ) {
            BaseClient client = new BaseClient ();
            Dictionary<string, string> dic = new Dictionary<string, string> ();
            dic.Add ("code", code);
            dic.Add ("name", name);
            dic.Add ("minPrice", minPrice?.ToString ());
            dic.Add ("maxPrice", maxPrice?.ToString ());
            dic.Add ("isActive", isActive?.ToString ());
            dic.Add ("skip", skip.ToString ());
            dic.Add ("take", take.ToString ());

            return client.Get<IReadOnlyCollection<ProductSearchItemModel>> ("products/search", dic);
        }

        public UpdateProductResultModel Update(long id, UpdateProductModel model){
            BaseClient client = new BaseClient();
            string url = "products/Update/" + id;
            return client.Post<UpdateProductResultModel,UpdateProductModel>(url, model);

        }

        public CreateProductResultModel Create(CreateProductModel model){
            BaseClient client = new BaseClient();
            string url = "products/Create";

            return client.Post<CreateProductResultModel,CreateProductModel>(url,model);
        }
    }
}