#pragma checksum "D:\Desktop\FINKI\job\project\Task2\DapperConsoleApp\DapperProducts\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a3d3a78f6c2dc89ea3295f2d3ba63ad6efa978b7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#nullable restore
#line 1 "D:\Desktop\FINKI\job\project\Task2\DapperConsoleApp\DapperProducts\Views\_ViewImports.cshtml"
using DapperProducts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Desktop\FINKI\job\project\Task2\DapperConsoleApp\DapperProducts\Views\_ViewImports.cshtml"
using DapperProducts.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a3d3a78f6c2dc89ea3295f2d3ba63ad6efa978b7", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e61eac0bf1e14c80c6ebed36a58a714478b41672", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<DapperConsoleApp.Models.Product>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"container\">\r\n   \r\n");
#nullable restore
#line 5 "D:\Desktop\FINKI\job\project\Task2\DapperConsoleApp\DapperProducts\Views\Home\Index.cshtml"
     for (int i = 0; i < Model.Count; i++)
    {
        var item = Model[i];

        if (i % 3 == 0)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            WriteLiteral("<div class=\"row\">\r\n");
#nullable restore
#line 12 "D:\Desktop\FINKI\job\project\Task2\DapperConsoleApp\DapperProducts\Views\Home\Index.cshtml"
            }


#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-md-3 m-4\">\r\n                <div class=\"card\" style=\"width: 18rem; height: 30rem;\">\r\n                    <img class=\"card-img-top\"");
            BeginWriteAttribute("src", " src=\"", 405, "\"", 433, 1);
#nullable restore
#line 16 "D:\Desktop\FINKI\job\project\Task2\DapperConsoleApp\DapperProducts\Views\Home\Index.cshtml"
WriteAttributeValue("", 411, item.category.Picture, 411, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"height: 50%;\" alt=\"Image for product!\">\r\n\r\n                    <div class=\"card-body\">\r\n                        <h3 class=\"card-title\">");
#nullable restore
#line 19 "D:\Desktop\FINKI\job\project\Task2\DapperConsoleApp\DapperProducts\Views\Home\Index.cshtml"
                                          Write(item.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                        <p class=\"card-text\">");
#nullable restore
#line 20 "D:\Desktop\FINKI\job\project\Task2\DapperConsoleApp\DapperProducts\Views\Home\Index.cshtml"
                                        Write(item.category.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n\r\n                        <h6>Price: $");
#nullable restore
#line 23 "D:\Desktop\FINKI\job\project\Task2\DapperConsoleApp\DapperProducts\Views\Home\Index.cshtml"
                               Write(item.UnitPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                    </div>\r\n                </div>\r\n            </div> ");
#nullable restore
#line 26 "D:\Desktop\FINKI\job\project\Task2\DapperConsoleApp\DapperProducts\Views\Home\Index.cshtml"
                   if (i % 3 == 2)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            WriteLiteral("</div>\r\n");
#nullable restore
#line 29 "D:\Desktop\FINKI\job\project\Task2\DapperConsoleApp\DapperProducts\Views\Home\Index.cshtml"
        }
    }

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<DapperConsoleApp.Models.Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
