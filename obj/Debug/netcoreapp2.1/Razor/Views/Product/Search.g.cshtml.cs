#pragma checksum "/Users/codecadet/Desktop/tutorial/AcademiaCodigo.Web/Views/Product/Search.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "406ed39eb83c5232ae767fabb984ea7cec7ff51f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Search), @"mvc.1.0.view", @"/Views/Product/Search.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Product/Search.cshtml", typeof(AspNetCore.Views_Product_Search))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "/Users/codecadet/Desktop/tutorial/AcademiaCodigo.Web/Views/Product/Search.cshtml"
using AcademiaCodigo.Web.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"406ed39eb83c5232ae767fabb984ea7cec7ff51f", @"/Views/Product/Search.cshtml")]
    public class Views_Product_Search : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(59, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 4 "/Users/codecadet/Desktop/tutorial/AcademiaCodigo.Web/Views/Product/Search.cshtml"
  
    ViewBag.Title = "Pesquisa de Produtos"; 
    ViewBag.Header = "Pesquisa de Produtos";

#line default
#line hidden
            BeginContext(155, 7, true);
            WriteLiteral("\n<div>\n");
            EndContext();
#line 10 "/Users/codecadet/Desktop/tutorial/AcademiaCodigo.Web/Views/Product/Search.cshtml"
      using (Html.BeginForm("Search", "Product")) {


#line default
#line hidden
            BeginContext(215, 855, true);
            WriteLiteral(@"<nav class=""navbar navbar-default fixed-top"">
    <div class=""container"">
      <div id=""navbar"" class=""navbar-collapse collapse"">
        <form class=""navbar-form navbar-right"">
        <div class=""form-group col-lg-2"">
            <label class=""sr-only"" for=""i_code"">Código</label>
            <input type=""text"" id=""i_code"" name=""i_code"" value="""" class=""form-control"" placeholder=""Código"" />
        </div>
        <div class=""form-group col-lg-2"">
            <label class=""sr-only"" for=""i_name"">Nome</label>
            <input type=""text"" id=""i_name"" name=""i_name"" value="""" class=""form-control"" placeholder=""Nome"" />
        </div>
        <button type=""submit"" name=""bt_search"" class=""btn btn-success""><i class=""fa fa-search"" aria-hidden=""true""></i>Pesquisar</button>
        </form>
      </div>
      <!--/.navbar-collapse -->
    </div>
  </nav>
");
            EndContext();
#line 30 "/Users/codecadet/Desktop/tutorial/AcademiaCodigo.Web/Views/Product/Search.cshtml"
  }

#line default
#line hidden
            BeginContext(1074, 434, true);
            WriteLiteral(@"
  <div class=""container"">
    <table class=""table table-striped table-hover"">
      <thead>
        <tr class=""active"">
          <th scope=""col"">Código</th>
          <th scope=""col"">Nome</th>
          <th scope=""col"">Preço</th>
          <th scope=""col"">Stock</th>
          <th scope=""col"">Actualizado em</th>
          <th scope=""col"">Por</th>
          <th scope=""col"">Detalhes</th>
        </tr>
      </thead>
      <tbody>

");
            EndContext();
#line 47 "/Users/codecadet/Desktop/tutorial/AcademiaCodigo.Web/Views/Product/Search.cshtml"
         foreach(var item in Model.Products) {

#line default
#line hidden
            BeginContext(1555, 39, true);
            WriteLiteral("        <tr>\n          <td scope=\"row\">");
            EndContext();
            BeginContext(1595, 9, false);
#line 49 "/Users/codecadet/Desktop/tutorial/AcademiaCodigo.Web/Views/Product/Search.cshtml"
                     Write(item.Code);

#line default
#line hidden
            EndContext();
            BeginContext(1604, 20, true);
            WriteLiteral("</td>\n          <td>");
            EndContext();
            BeginContext(1625, 9, false);
#line 50 "/Users/codecadet/Desktop/tutorial/AcademiaCodigo.Web/Views/Product/Search.cshtml"
         Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1634, 22, true);
            WriteLiteral("</td>\n          <td>€ ");
            EndContext();
            BeginContext(1657, 24, false);
#line 51 "/Users/codecadet/Desktop/tutorial/AcademiaCodigo.Web/Views/Product/Search.cshtml"
           Write(item.Price.ToString("C"));

#line default
#line hidden
            EndContext();
            BeginContext(1681, 20, true);
            WriteLiteral("</td>\n          <td>");
            EndContext();
            BeginContext(1702, 17, false);
#line 52 "/Users/codecadet/Desktop/tutorial/AcademiaCodigo.Web/Views/Product/Search.cshtml"
         Write(item.CurrentStock);

#line default
#line hidden
            EndContext();
            BeginContext(1719, 20, true);
            WriteLiteral("</td>\n          <td>");
            EndContext();
            BeginContext(1740, 14, false);
#line 53 "/Users/codecadet/Desktop/tutorial/AcademiaCodigo.Web/Views/Product/Search.cshtml"
         Write(item.UpdatedOn);

#line default
#line hidden
            EndContext();
            BeginContext(1754, 20, true);
            WriteLiteral("</td>\n          <td>");
            EndContext();
            BeginContext(1775, 14, false);
#line 54 "/Users/codecadet/Desktop/tutorial/AcademiaCodigo.Web/Views/Product/Search.cshtml"
         Write(item.UpdatedBy);

#line default
#line hidden
            EndContext();
            BeginContext(1789, 20, true);
            WriteLiteral("</td>\n          <td>");
            EndContext();
            BeginContext(1810, 100, false);
#line 55 "/Users/codecadet/Desktop/tutorial/AcademiaCodigo.Web/Views/Product/Search.cshtml"
         Write(Html.ActionLink("+ info","Detail","Product", new { code = @item.Code }, new {@class="btn btn-info"}));

#line default
#line hidden
            EndContext();
            BeginContext(1910, 20, true);
            WriteLiteral("</td>\n        </tr>\n");
            EndContext();
#line 57 "/Users/codecadet/Desktop/tutorial/AcademiaCodigo.Web/Views/Product/Search.cshtml"
        }

#line default
#line hidden
            BeginContext(1940, 121, true);
            WriteLiteral("      </tbody>\n    </table>\n  </div>\n  <nav aria-label=\"...\">\n    <ul class=\"pager\">\n      <li class=\"previous\">\n        ");
            EndContext();
            BeginContext(2062, 140, false);
#line 64 "/Users/codecadet/Desktop/tutorial/AcademiaCodigo.Web/Views/Product/Search.cshtml"
   Write(Html.ActionLink("Anterior","Navigate","Product", new { Next=false, page=Model.Filter.Page, code=Model.Filter.Code, name=Model.Filter.Name }));

#line default
#line hidden
            EndContext();
            BeginContext(2202, 37, true);
            WriteLiteral("\n      </li>\n      <li class=\"next\"> ");
            EndContext();
            BeginContext(2240, 139, false);
#line 66 "/Users/codecadet/Desktop/tutorial/AcademiaCodigo.Web/Views/Product/Search.cshtml"
                   Write(Html.ActionLink("Seguinte","Navigate","Product", new { Next=true, page=Model.Filter.Page, code=Model.Filter.Code, name=Model.Filter.Name }));

#line default
#line hidden
            EndContext();
            BeginContext(2379, 95, true);
            WriteLiteral("\n      </li>\n    </ul>\n  </nav>\n  <div class=\"container\">\n      <button class=\"btn btn-warning\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 2474, "\"", 2546, 4);
            WriteAttributeValue("", 2484, "location.href=\'", 2484, 15, true);
#line 71 "/Users/codecadet/Desktop/tutorial/AcademiaCodigo.Web/Views/Product/Search.cshtml"
WriteAttributeValue("", 2499, Url.Action("Create", "Product"), 2499, 32, false);

#line default
#line hidden
            WriteAttributeValue("", 2531, "\';return", 2531, 8, true);
            WriteAttributeValue(" ", 2539, "false;", 2540, 7, true);
            EndWriteAttribute();
            BeginContext(2547, 60, true);
            WriteLiteral("><i class=\"far fa-plus-square\"></i> Novo</button>\n     <!-- ");
            EndContext();
            BeginContext(2608, 101, false);
#line 72 "/Users/codecadet/Desktop/tutorial/AcademiaCodigo.Web/Views/Product/Search.cshtml"
     Write(Html.ActionLink("Novo","Create","Product", null , new { @class="fas fa-plus-square btn btn-warning"}));

#line default
#line hidden
            EndContext();
            BeginContext(2709, 21, true);
            WriteLiteral("-->\n    </div>\n</div>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
