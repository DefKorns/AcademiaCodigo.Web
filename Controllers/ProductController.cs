using System;
using AcademiaCodigo.Web.DataAccess;
using AcademiaCodigo.Web.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AcademiaCodigo.Web.Controllers {
        public class ProductController : Controller {
            public IActionResult Index () {

                return View ();
            }

            public IActionResult Search (IFormCollection valueCollection) {
                string code = valueCollection["i_code"];
                string name = valueCollection["i_name"];

                return Search (new ProductSearchQueryModel () {
                    Code = code,
                        Name = name,
                        Page = 0

                });

            }

            private IActionResult Search (ProductSearchQueryModel viewParams) {
                ProductManagement pm = new ProductManagement ();
                var productList = pm.Search (viewParams.Code, viewParams.Name,
                    null, null, null, viewParams.Page * 10, 10);

                ProductViewModel model = new ProductViewModel () {
                    Products = productList,
                    Filter = viewParams
                };

                return View ("Search", model);
            }
            public IActionResult Navigate (bool Next, int page, string code, string name) {
                int nextPage = page;
                if (Next == true) {
                    nextPage++;
                } else {
                    if (page > 0) {
                        nextPage--;
                    }
                    }
                    return Search (new ProductSearchQueryModel () {

                        Code = code,
                        Name = name,
                        Page = nextPage

                    });
                }

                public IActionResult Detail(string code)
                {
                    ProductManagement pm = new ProductManagement();
                    ProductModel product = pm.Get(code);

                    return View(product);
                }

                public IActionResult Edit(IFormCollection valueCollection){

                    string code = valueCollection["i_code"];
                    string name = valueCollection["i_name"];
                    string description = valueCollection["i_description"];
                    string priceStr = valueCollection["i_price"];
                    string idStr = valueCollection["i_id"];
                    string stock = valueCollection["i_stock"];
                    string versionStr = valueCollection["i_version"];

                    Decimal price = 0;
                    Decimal.TryParse(priceStr, out price);

                    long id = 0;
                    long.TryParse(idStr, out id);

                    Guid version = Guid.Empty;
                    Guid.TryParse(versionStr, out version);

                    ProductManagement pm = new ProductManagement();
                    UpdateProductModel model = new UpdateProductModel(){
                        Code = code,
                        Name = name,
                        Description = description,
                        Price = price,
                        Version = version

                    };

                    try{
                        UpdateProductResultModel result = pm.Update(id, model);
                    }
                    catch(Exception ex)
                    {
                        return new ContentResult(){
                            Content = "An error has occurred: " + Environment.NewLine + ex.Message
                        };
                    }

                   // pm.Update(id,model);


                    //FIX ME
                    return RedirectToAction ("Search", null);
                }

                public IActionResult Deactivate(string code){

                    return RedirectToAction ("Search", null);
                }

                public IActionResult Create(){
                    return View("Create", new CreateProductModel());
                }

                public IActionResult CreateProduct(IFormCollection valueCollection){
                    string code = valueCollection["i_code"];
                    string name = valueCollection["i_name"];
                    string description = valueCollection["i_description"];
                    string priceStr = valueCollection["i_price"];

                    try
                    {
                        decimal price = 0;
                        bool priceToDecimal = Decimal.TryParse(priceStr, out price);

                    ProductManagement pm = new ProductManagement();
                    CreateProductModel model = new CreateProductModel(){
                        Code = code,
                        Name = name,
                        Description = description,
                        Price = price
                    };
                         CreateProductResultModel result = pm.Create(model);
                    }
                    catch (Exception ex)
                    {
                        return new ContentResult(){
                            Content = "An error has occurred: " + Environment.NewLine + ex.Message
                        };

                    }

                    return RedirectToAction ("Search", null);

                }


            }
        }
