#pragma checksum "G:\Lưu Trữ\File nộp (File responses)\Nhom27_WebsiteBanSach - Phương Lê Thị Trúc\Team27_BookshopWeb\Team27_BookshopWeb\Views\CouponGallery\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4af2ab260cc24b15bdc5cc985837953f680cbe36"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CouponGallery_Index), @"mvc.1.0.view", @"/Views/CouponGallery/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4af2ab260cc24b15bdc5cc985837953f680cbe36", @"/Views/CouponGallery/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b095e99e3dd484b538f8cd4863877373ad092328", @"/Views/_ViewImports.cshtml")]
    public class Views_CouponGallery_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Team27_BookshopWeb.Models.CouponGalleryViewModel>
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
            WriteLiteral("\r\n");
#nullable restore
#line 2 "G:\Lưu Trữ\File nộp (File responses)\Nhom27_WebsiteBanSach - Phương Lê Thị Trúc\Team27_BookshopWeb\Team27_BookshopWeb\Views\CouponGallery\Index.cshtml"
  
    ViewData["Title"] = "Mã khuyến mãi";
    Layout = "~/Views/Shared/_CouponLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <div class=\"blog-list-cards\">\r\n");
#nullable restore
#line 9 "G:\Lưu Trữ\File nộp (File responses)\Nhom27_WebsiteBanSach - Phương Lê Thị Trúc\Team27_BookshopWeb\Team27_BookshopWeb\Views\CouponGallery\Index.cshtml"
         if (Model.Coupons.Count() > 0)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "G:\Lưu Trữ\File nộp (File responses)\Nhom27_WebsiteBanSach - Phương Lê Thị Trúc\Team27_BookshopWeb\Team27_BookshopWeb\Views\CouponGallery\Index.cshtml"
             foreach (var coupon in Model.Coupons)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"blog-card card-style-list\">\r\n                    <div class=\"row\">\r\n                        <div class=\"col-md-5\">\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 491, "\"", 525, 2);
            WriteAttributeValue("", 498, "/ma-khuyen-mai/", 498, 15, true);
#nullable restore
#line 16 "G:\Lưu Trữ\File nộp (File responses)\Nhom27_WebsiteBanSach - Phương Lê Thị Trúc\Team27_BookshopWeb\Team27_BookshopWeb\Views\CouponGallery\Index.cshtml"
WriteAttributeValue("", 513, coupon.Slug, 513, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"image d-block\">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "4af2ab260cc24b15bdc5cc985837953f680cbe365166", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 593, "~/Team27StaticFiles/images/coupon/", 593, 34, true);
#nullable restore
#line 17 "G:\Lưu Trữ\File nộp (File responses)\Nhom27_WebsiteBanSach - Phương Lê Thị Trúc\Team27_BookshopWeb\Team27_BookshopWeb\Views\CouponGallery\Index.cshtml"
AddHtmlAttributeValue("", 627, coupon.Image, 627, 13, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 17 "G:\Lưu Trữ\File nộp (File responses)\Nhom27_WebsiteBanSach - Phương Lê Thị Trúc\Team27_BookshopWeb\Team27_BookshopWeb\Views\CouponGallery\Index.cshtml"
AddHtmlAttributeValue("", 647, coupon.Name, 647, 12, false);

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
            WriteLiteral(@"
                            </a>
                        </div>
                        <div class=""col-md-6"">
                            <div class=""card-content"">
                                <h3 class=""title"">
                                    <a");
            BeginWriteAttribute("href", " href=\"", 923, "\"", 957, 2);
            WriteAttributeValue("", 930, "/ma-khuyen-mai/", 930, 15, true);
#nullable restore
#line 23 "G:\Lưu Trữ\File nộp (File responses)\Nhom27_WebsiteBanSach - Phương Lê Thị Trúc\Team27_BookshopWeb\Team27_BookshopWeb\Views\CouponGallery\Index.cshtml"
WriteAttributeValue("", 945, coupon.Slug, 945, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                        ");
#nullable restore
#line 24 "G:\Lưu Trữ\File nộp (File responses)\Nhom27_WebsiteBanSach - Phương Lê Thị Trúc\Team27_BookshopWeb\Team27_BookshopWeb\Views\CouponGallery\Index.cshtml"
                                   Write(coupon.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </a>\r\n                                </h3>\r\n                                <p class=\"post-meta\"><span>");
#nullable restore
#line 27 "G:\Lưu Trữ\File nộp (File responses)\Nhom27_WebsiteBanSach - Phương Lê Thị Trúc\Team27_BookshopWeb\Team27_BookshopWeb\Views\CouponGallery\Index.cshtml"
                                                      Write(coupon.CreatedAt.ToString("dd/MM/yyyy - HH:mm:ss"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </span></p>
                                <article>
                                    <h2 class=""sr-only"">
                                        Coupon description
                                    </h2>
                                    <p>
");
#nullable restore
#line 33 "G:\Lưu Trữ\File nộp (File responses)\Nhom27_WebsiteBanSach - Phương Lê Thị Trúc\Team27_BookshopWeb\Team27_BookshopWeb\Views\CouponGallery\Index.cshtml"
                                         if (coupon.Description.Length >= 200)
                                        {
                                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "G:\Lưu Trữ\File nộp (File responses)\Nhom27_WebsiteBanSach - Phương Lê Thị Trúc\Team27_BookshopWeb\Team27_BookshopWeb\Views\CouponGallery\Index.cshtml"
                                       Write(coupon.Description.Replace("<br>", Environment.NewLine).Substring(0, 200));

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "G:\Lưu Trữ\File nộp (File responses)\Nhom27_WebsiteBanSach - Phương Lê Thị Trúc\Team27_BookshopWeb\Team27_BookshopWeb\Views\CouponGallery\Index.cshtml"
                                                                                                                      ;
                                        }
                                        else
                                        {
                                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 39 "G:\Lưu Trữ\File nộp (File responses)\Nhom27_WebsiteBanSach - Phương Lê Thị Trúc\Team27_BookshopWeb\Team27_BookshopWeb\Views\CouponGallery\Index.cshtml"
                                       Write(coupon.Description.Replace("<br>", Environment.NewLine));

#line default
#line hidden
#nullable disable
#nullable restore
#line 39 "G:\Lưu Trữ\File nộp (File responses)\Nhom27_WebsiteBanSach - Phương Lê Thị Trúc\Team27_BookshopWeb\Team27_BookshopWeb\Views\CouponGallery\Index.cshtml"
                                                                                                    
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(" ...\r\n                                    </p>\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 2070, "\"", 2104, 2);
            WriteAttributeValue("", 2077, "/ma-khuyen-mai/", 2077, 15, true);
#nullable restore
#line 42 "G:\Lưu Trữ\File nộp (File responses)\Nhom27_WebsiteBanSach - Phương Lê Thị Trúc\Team27_BookshopWeb\Team27_BookshopWeb\Views\CouponGallery\Index.cshtml"
WriteAttributeValue("", 2092, coupon.Slug, 2092, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"blog-link\"> Xem thêm</a>\r\n                                </article>\r\n                            </div>\r\n                        </div>\r\n\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 49 "G:\Lưu Trữ\File nộp (File responses)\Nhom27_WebsiteBanSach - Phương Lê Thị Trúc\Team27_BookshopWeb\Team27_BookshopWeb\Views\CouponGallery\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-md-12\">\r\n                <div class=\"pagination-block\">\r\n                    <!-- Phân trang link -->\r\n                    <!--Gọi partial view hiển thị phân trang-->\r\n");
#nullable restore
#line 54 "G:\Lưu Trữ\File nộp (File responses)\Nhom27_WebsiteBanSach - Phương Lê Thị Trúc\Team27_BookshopWeb\Team27_BookshopWeb\Views\CouponGallery\Index.cshtml"
                      await Html.RenderPartialAsync("_Pagination", new PaginationViewModel(Model.AllPages, Model.CurrentPage));

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </div>\r\n");
#nullable restore
#line 57 "G:\Lưu Trữ\File nộp (File responses)\Nhom27_WebsiteBanSach - Phương Lê Thị Trúc\Team27_BookshopWeb\Team27_BookshopWeb\Views\CouponGallery\Index.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div>Không có mã khuyến mãi nào</div>\r\n");
#nullable restore
#line 61 "G:\Lưu Trữ\File nộp (File responses)\Nhom27_WebsiteBanSach - Phương Lê Thị Trúc\Team27_BookshopWeb\Team27_BookshopWeb\Views\CouponGallery\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Team27_BookshopWeb.Models.CouponGalleryViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
