#pragma checksum "C:\Users\adils\OneDrive\Рабочий стол\AllupAdil\Allup\Views\Shared\Components\Product\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bd8826b0f77e613d7573bfa494c23193be9a69e4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Product_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Product/Default.cshtml")]
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
#line 2 "C:\Users\adils\OneDrive\Рабочий стол\AllupAdil\Allup\Views\_ViewImports.cshtml"
using Allup.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\adils\OneDrive\Рабочий стол\AllupAdil\Allup\Views\_ViewImports.cshtml"
using Allup.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\adils\OneDrive\Рабочий стол\AllupAdil\Allup\Views\_ViewImports.cshtml"
using Allup.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\adils\OneDrive\Рабочий стол\AllupAdil\Allup\Views\_ViewImports.cshtml"
using Allup.ViewModels.ShopVM;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\adils\OneDrive\Рабочий стол\AllupAdil\Allup\Views\_ViewImports.cshtml"
using Allup.ViewModels.Basket;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\adils\OneDrive\Рабочий стол\AllupAdil\Allup\Views\_ViewImports.cshtml"
using Allup.ComponentViewModels.Header;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\adils\OneDrive\Рабочий стол\AllupAdil\Allup\Views\_ViewImports.cshtml"
using Allup.ComponentViewModels.ProductVM;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\adils\OneDrive\Рабочий стол\AllupAdil\Allup\Views\_ViewImports.cshtml"
using Allup.ViewComponents;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bd8826b0f77e613d7573bfa494c23193be9a69e4", @"/Views/Shared/Components/Product/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1471b0262b4a1ab7ed622a38ea42a7d95717e32a", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Product_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductVM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<section class=""product-area pt-100 pb-100"">
    <div class=""container-fluid custom-container"">
        <div class=""row"">
            <div class=""col-lg-12"">
                <div class=""product-menu pb-30"">
                    <ul class=""nav justify-content-center"" id=""myTab"" role=""tablist"">
                        <li class=""nav-item"" role=""presentation"">
                            <a class=""active"" id=""new-tab"" data-toggle=""tab"" href=""#new"" role=""tab"" aria-controls=""new"" aria-selected=""true"">New Arrival</a>
                        </li>
                        <li class=""nav-item"" role=""presentation"">
                            <a id=""bestseller-tab"" data-toggle=""tab"" href=""#bestseller"" role=""tab"" aria-controls=""bestseller"" aria-selected=""false"">Bestseller</a>
                        </li>
                        <li class=""nav-item"" role=""presentation"">
                            <a id=""featured-tab"" data-toggle=""tab"" href=""#featured"" role=""tab"" aria-controls=""featured"" aria-selected=""false"">Featured</a");
            WriteLiteral(@">
                        </li>
                    </ul>
                </div> <!-- product menu -->
            </div>
        </div> <!-- row -->
        <div class=""tab-content"" id=""myTabContent"">
            <div class=""tab-pane fade show active"" id=""new"" role=""tabpanel"" aria-labelledby=""new-tab"">
                ");
#nullable restore
#line 23 "C:\Users\adils\OneDrive\Рабочий стол\AllupAdil\Allup\Views\Shared\Components\Product\Default.cshtml"
           Write(Html.Partial("_ProductsOnHomePartialView", Model.NewArrivals));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n            </div>\n            <div class=\"tab-pane fade\" id=\"bestseller\" role=\"tabpanel\" aria-labelledby=\"bestseller-tab\">\n                ");
#nullable restore
#line 27 "C:\Users\adils\OneDrive\Рабочий стол\AllupAdil\Allup\Views\Shared\Components\Product\Default.cshtml"
           Write(Html.Partial("_ProductsOnHomePartialView", Model.BestSellers));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </div>\n            <div class=\"tab-pane fade\" id=\"featured\" role=\"tabpanel\" aria-labelledby=\"featured-tab\">\n                ");
#nullable restore
#line 30 "C:\Users\adils\OneDrive\Рабочий стол\AllupAdil\Allup\Views\Shared\Components\Product\Default.cshtml"
           Write(Html.Partial("_ProductsOnHomePartialView", Model.Featured));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </div>\n        </div> <!-- tab content -->\n    </div> <!-- container -->\n</section>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
