#pragma checksum "F:\Code\SP_Ecommerce\Team27_BookshopWeb\Views\Checkout\PaymentError.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "28ea15bd572d84b348cddd51afdd4a3ba5b9cdad"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Checkout_PaymentError), @"mvc.1.0.view", @"/Views/Checkout/PaymentError.cshtml")]
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
#line 1 "F:\Code\SP_Ecommerce\Team27_BookshopWeb\Views\_ViewImports.cshtml"
using Team27_BookshopWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\Code\SP_Ecommerce\Team27_BookshopWeb\Views\_ViewImports.cshtml"
using Team27_BookshopWeb.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"28ea15bd572d84b348cddd51afdd4a3ba5b9cdad", @"/Views/Checkout/PaymentError.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b095e99e3dd484b538f8cd4863877373ad092328", @"/Views/_ViewImports.cshtml")]
    public class Views_Checkout_PaymentError : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Team27_BookshopWeb.Entities.Order>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "F:\Code\SP_Ecommerce\Team27_BookshopWeb\Views\Checkout\PaymentError.cshtml"
  
    ViewData["Title"] = "Hoàn tất thanh toán";
    Layout = "~/Views/Shared/_Master.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<section class=""breadcrumb-section"">
    <h2 class=""sr-only"">Site Breadcrumb</h2>
    <div class=""container"">
        <div class=""breadcrumb-contents"">
            <nav aria-label=""breadcrumb"">
                <ol class=""breadcrumb"">
                    <li class=""breadcrumb-item""><a href=""/"">Trang chủ</a></li>
                    <li class=""breadcrumb-item""><a href=""/thanh-toan"">Thanh toán</a></li>
                    <li class=""breadcrumb-item active"">Lỗi Thanh Toán</li>
                </ol>
            </nav>
        </div>
    </div>
</section>
<!-- order complete Page Start --><section class=""order-complete inner-page-sec-padding-bottom"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-12"">
                <div class=""order-complete-message text-center"">
                    <p>Thanh Toán Thất Bại.</p>
                </div>
            </div>
        </div>
        <div>
            <a class=""btn btn--primary"" id=""back"" href=""/"">Quay về trang chủ");
            WriteLiteral("</a>\r\n        </div>\r\n    </div>\r\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Team27_BookshopWeb.Entities.Order> Html { get; private set; }
    }
}
#pragma warning restore 1591
