#pragma checksum "/Users/dannybellboy/Projects/Bookstore/Bookstore/Views/Shared/Components/CartSummary/Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "98fe3ebb1ccb7c1a7feef6a10dc22828303301f1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Bookstore.Views.Shared.Components.CartSummary.Views_Shared_Components_CartSummary_Default), @"mvc.1.0.view", @"/Views/Shared/Components/CartSummary/Default.cshtml")]
namespace Bookstore.Views.Shared.Components.CartSummary
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
#line 4 "/Users/dannybellboy/Projects/Bookstore/Bookstore/Views/_ViewImports.cshtml"
using Bookstore.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/dannybellboy/Projects/Bookstore/Bookstore/Views/_ViewImports.cshtml"
using Bookstore.Models.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/dannybellboy/Projects/Bookstore/Bookstore/Views/_ViewImports.cshtml"
using Bookstore.Infrastructure;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"98fe3ebb1ccb7c1a7feef6a10dc22828303301f1", @"/Views/Shared/Components/CartSummary/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f3c43d799806c717854cc61d2e81d836f163aba1", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_CartSummary_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Basket>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
            WriteLiteral("\n\n");
            WriteLiteral("<button type=\"button\" class=\"btn position-relative\" style=\"font-size:24px; color:black; margin-right:25px\">\n    <i class=\"fa fa-shopping-cart\"></i> ");
#nullable restore
#line 9 "/Users/dannybellboy/Projects/Bookstore/Bookstore/Views/Shared/Components/CartSummary/Default.cshtml"
                                   Write(Model.CalculateTotal().ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    <span class=\"position-absolute top-0 start-100 translate-middle badge rounded-pill bg-danger\">\n        ");
#nullable restore
#line 11 "/Users/dannybellboy/Projects/Bookstore/Bookstore/Views/Shared/Components/CartSummary/Default.cshtml"
   Write(Model.Items.Count());

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        <span class=\"visually-hidden\">unread messages</span>\n    </span>\n</button>\n\n\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Basket> Html { get; private set; }
    }
}
#pragma warning restore 1591
