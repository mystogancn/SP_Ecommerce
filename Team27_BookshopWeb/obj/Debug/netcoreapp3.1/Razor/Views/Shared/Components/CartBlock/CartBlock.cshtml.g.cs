#pragma checksum "G:\Lưu Trữ\File nộp (File responses)\Nhom27_WebsiteBanSach - Phương Lê Thị Trúc\Team27_BookshopWeb\Team27_BookshopWeb\Views\Shared\Components\CartBlock\CartBlock.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8b4b11ecc7f24d1f189d50ca8f4e723b8b9e17fe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_CartBlock_CartBlock), @"mvc.1.0.view", @"/Views/Shared/Components/CartBlock/CartBlock.cshtml")]
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
#line 1 "G:\Lưu Trữ\File nộp (File responses)\Nhom27_WebsiteBanSach - Phương Lê Thị Trúc\Team27_BookshopWeb\Team27_BookshopWeb\Views\_ViewImports.cshtml"
using Team27_BookshopWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "G:\Lưu Trữ\File nộp (File responses)\Nhom27_WebsiteBanSach - Phương Lê Thị Trúc\Team27_BookshopWeb\Team27_BookshopWeb\Views\_ViewImports.cshtml"
using Team27_BookshopWeb.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8b4b11ecc7f24d1f189d50ca8f4e723b8b9e17fe", @"/Views/Shared/Components/CartBlock/CartBlock.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b095e99e3dd484b538f8cd4863877373ad092328", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_CartBlock_CartBlock : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Team27_BookshopWeb.Models.CartViewModel>
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"cart-total\">\r\n    <span class=\"text-number\">");
#nullable restore
#line 7 "G:\Lưu Trữ\File nộp (File responses)\Nhom27_WebsiteBanSach - Phương Lê Thị Trúc\Team27_BookshopWeb\Team27_BookshopWeb\Views\Shared\Components\CartBlock\CartBlock.cshtml"
                         Write(Model.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n    <span class=\"text-item\">\r\n        Giỏ hàng\r\n    </span>\r\n    <span class=\"price\">\r\n        <span>");
#nullable restore
#line 12 "G:\Lưu Trữ\File nộp (File responses)\Nhom27_WebsiteBanSach - Phương Lê Thị Trúc\Team27_BookshopWeb\Team27_BookshopWeb\Views\Shared\Components\CartBlock\CartBlock.cshtml"
         Write(Model.DisplayTotal);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n        <i class=\"fas fa-chevron-down\"></i>\r\n    </span>\r\n</div>\r\n<div class=\"cart-dropdown-block\">\r\n    <div class=\"single-cart-block list\">\r\n");
#nullable restore
#line 18 "G:\Lưu Trữ\File nộp (File responses)\Nhom27_WebsiteBanSach - Phương Lê Thị Trúc\Team27_BookshopWeb\Team27_BookshopWeb\Views\Shared\Components\CartBlock\CartBlock.cshtml"
         if (Model.CartItems.Count() > 0)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "G:\Lưu Trữ\File nộp (File responses)\Nhom27_WebsiteBanSach - Phương Lê Thị Trúc\Team27_BookshopWeb\Team27_BookshopWeb\Views\Shared\Components\CartBlock\CartBlock.cshtml"
             foreach (var item in Model.CartItems)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"cart-product\" data-bookid=\"");
#nullable restore
#line 22 "G:\Lưu Trữ\File nộp (File responses)\Nhom27_WebsiteBanSach - Phương Lê Thị Trúc\Team27_BookshopWeb\Team27_BookshopWeb\Views\Shared\Components\CartBlock\CartBlock.cshtml"
                                                  Write(item.BookId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 739, "\"", 767, 2);
            WriteAttributeValue("", 746, "/sach/", 746, 6, true);
#nullable restore
#line 23 "G:\Lưu Trữ\File nộp (File responses)\Nhom27_WebsiteBanSach - Phương Lê Thị Trúc\Team27_BookshopWeb\Team27_BookshopWeb\Views\Shared\Components\CartBlock\CartBlock.cshtml"
WriteAttributeValue("", 752, item.Book.Slug, 752, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"image\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "8b4b11ecc7f24d1f189d50ca8f4e723b8b9e17fe6133", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 819, "~/Team27StaticFiles/images/books/", 819, 33, true);
#nullable restore
#line 24 "G:\Lưu Trữ\File nộp (File responses)\Nhom27_WebsiteBanSach - Phương Lê Thị Trúc\Team27_BookshopWeb\Team27_BookshopWeb\Views\Shared\Components\CartBlock\CartBlock.cshtml"
AddHtmlAttributeValue("", 852, item.Book.PrimaryImage, 852, 23, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 24 "G:\Lưu Trữ\File nộp (File responses)\Nhom27_WebsiteBanSach - Phương Lê Thị Trúc\Team27_BookshopWeb\Team27_BookshopWeb\Views\Shared\Components\CartBlock\CartBlock.cshtml"
AddHtmlAttributeValue("", 882, item.Book.DisplayName, 882, 22, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </a>\r\n                    <div class=\"content\">\r\n                        <h3 class=\"title\"><a");
            BeginWriteAttribute("href", " href=\"", 1021, "\"", 1049, 2);
            WriteAttributeValue("", 1028, "/sach/", 1028, 6, true);
#nullable restore
#line 27 "G:\Lưu Trữ\File nộp (File responses)\Nhom27_WebsiteBanSach - Phương Lê Thị Trúc\Team27_BookshopWeb\Team27_BookshopWeb\Views\Shared\Components\CartBlock\CartBlock.cshtml"
WriteAttributeValue("", 1034, item.Book.Slug, 1034, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 27 "G:\Lưu Trữ\File nộp (File responses)\Nhom27_WebsiteBanSach - Phương Lê Thị Trúc\Team27_BookshopWeb\Team27_BookshopWeb\Views\Shared\Components\CartBlock\CartBlock.cshtml"
                                                                     Write(item.Book.DisplayName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h3>\r\n                        <p class=\"price\"><span class=\"qty\">");
#nullable restore
#line 28 "G:\Lưu Trữ\File nộp (File responses)\Nhom27_WebsiteBanSach - Phương Lê Thị Trúc\Team27_BookshopWeb\Team27_BookshopWeb\Views\Shared\Components\CartBlock\CartBlock.cshtml"
                                                      Write(item.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> × <span class=\"price\">");
#nullable restore
#line 28 "G:\Lưu Trữ\File nộp (File responses)\Nhom27_WebsiteBanSach - Phương Lê Thị Trúc\Team27_BookshopWeb\Team27_BookshopWeb\Views\Shared\Components\CartBlock\CartBlock.cshtml"
                                                                                                  Write(item.Book.DisplayPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></p>\r\n                        <button class=\"cross-btn remove-cart-item\" data-bookid=\"");
#nullable restore
#line 29 "G:\Lưu Trữ\File nộp (File responses)\Nhom27_WebsiteBanSach - Phương Lê Thị Trúc\Team27_BookshopWeb\Team27_BookshopWeb\Views\Shared\Components\CartBlock\CartBlock.cshtml"
                                                                           Write(item.BookId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"><i class=\"fas fa-times\"></i></button>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 32 "G:\Lưu Trữ\File nộp (File responses)\Nhom27_WebsiteBanSach - Phương Lê Thị Trúc\Team27_BookshopWeb\Team27_BookshopWeb\Views\Shared\Components\CartBlock\CartBlock.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "G:\Lưu Trữ\File nộp (File responses)\Nhom27_WebsiteBanSach - Phương Lê Thị Trúc\Team27_BookshopWeb\Team27_BookshopWeb\Views\Shared\Components\CartBlock\CartBlock.cshtml"
             

        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"cart-product\">\r\n                <p class=\"empty-cart\">Giỏ hàng trống</p>\r\n            </div>\r\n");
#nullable restore
#line 40 "G:\Lưu Trữ\File nộp (File responses)\Nhom27_WebsiteBanSach - Phương Lê Thị Trúc\Team27_BookshopWeb\Team27_BookshopWeb\Views\Shared\Components\CartBlock\CartBlock.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </div>
    <div class="" single-cart-block "">
        <div class=""btn-block"">
            <a href=""/cart"" class=""btn"">
                Xem giỏ hàng <i class=""fas fa-chevron-right""></i>
            </a>
            <a href=""/thanh-toan"" class=""btn btn--primary"">
                Thanh toán <i class=""fas fa-chevron-right""></i>
            </a>
        </div>
    </div>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Team27_BookshopWeb.Models.CartViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
