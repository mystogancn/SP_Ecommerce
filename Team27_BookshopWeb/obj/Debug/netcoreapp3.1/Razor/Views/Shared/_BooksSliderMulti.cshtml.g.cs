#pragma checksum "F:\Ecommerce\Project\SP_Ecommerce\Team27_BookshopWeb\Views\Shared\_BooksSliderMulti.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "98fe8f2cbbcab73de7b06dafc18fd6c44fdadab6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__BooksSliderMulti), @"mvc.1.0.view", @"/Views/Shared/_BooksSliderMulti.cshtml")]
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
#line 1 "F:\Ecommerce\Project\SP_Ecommerce\Team27_BookshopWeb\Views\_ViewImports.cshtml"
using Team27_BookshopWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\Ecommerce\Project\SP_Ecommerce\Team27_BookshopWeb\Views\_ViewImports.cshtml"
using Team27_BookshopWeb.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"98fe8f2cbbcab73de7b06dafc18fd6c44fdadab6", @"/Views/Shared/_BooksSliderMulti.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b095e99e3dd484b538f8cd4863877373ad092328", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__BooksSliderMulti : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:100px; height:120px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 5 "F:\Ecommerce\Project\SP_Ecommerce\Team27_BookshopWeb\Views\Shared\_BooksSliderMulti.cshtml"
   var books = Model;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""product-slider product-list-slider multiple-row slider-border-multiple-row  sb-slick-slider""
         data-slick-setting='{
                           	""autoplay"": true,
                            ""autoplaySpeed"": 8000,
                            ""slidesToShow"": 3,
                            ""rows"":3,
                            ""dots"":true
                        }' data-slick-responsive='[
                            {""breakpoint"":992, ""settings"": {""slidesToShow"": 2,""rows"": 3} },

                            {""breakpoint"":768, ""settings"": {""slidesToShow"": 1} }
                        ]'>


");
#nullable restore
#line 20 "F:\Ecommerce\Project\SP_Ecommerce\Team27_BookshopWeb\Views\Shared\_BooksSliderMulti.cshtml"
         foreach (var book in books)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"single-slide\">\r\n                <div class=\"product-card card-style-list\">\r\n                    <div class=\"card-image\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "98fe8f2cbbcab73de7b06dafc18fd6c44fdadab64853", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1009, "~/Team27StaticFiles/images/books/", 1009, 33, true);
#nullable restore
#line 25 "F:\Ecommerce\Project\SP_Ecommerce\Team27_BookshopWeb\Views\Shared\_BooksSliderMulti.cshtml"
AddHtmlAttributeValue("", 1042, book.PrimaryImage, 1042, 18, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 25 "F:\Ecommerce\Project\SP_Ecommerce\Team27_BookshopWeb\Views\Shared\_BooksSliderMulti.cshtml"
AddHtmlAttributeValue("", 1101, book.DisplayName, 1101, 17, false);

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
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"product-card--body\">\r\n                        <div class=\"product-header\">\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 1288, "\"", 1321, 2);
            WriteAttributeValue("", 1295, "/tac-gia/", 1295, 9, true);
#nullable restore
#line 29 "F:\Ecommerce\Project\SP_Ecommerce\Team27_BookshopWeb\Views\Shared\_BooksSliderMulti.cshtml"
WriteAttributeValue("", 1304, book.Author.Slug, 1304, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"author\">\r\n                                ");
#nullable restore
#line 30 "F:\Ecommerce\Project\SP_Ecommerce\Team27_BookshopWeb\Views\Shared\_BooksSliderMulti.cshtml"
                           Write(book.Author.DisplayName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </a>\r\n                            <h3><a");
            BeginWriteAttribute("href", " href=\"", 1466, "\"", 1489, 2);
            WriteAttributeValue("", 1473, "/sach/", 1473, 6, true);
#nullable restore
#line 32 "F:\Ecommerce\Project\SP_Ecommerce\Team27_BookshopWeb\Views\Shared\_BooksSliderMulti.cshtml"
WriteAttributeValue("", 1479, book.Slug, 1479, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 32 "F:\Ecommerce\Project\SP_Ecommerce\Team27_BookshopWeb\Views\Shared\_BooksSliderMulti.cshtml"
                                                      Write(book.DisplayName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h3>\r\n                        </div>\r\n                        <div class=\"price-block\">\r\n                            <span class=\"price\">");
#nullable restore
#line 35 "F:\Ecommerce\Project\SP_Ecommerce\Team27_BookshopWeb\Views\Shared\_BooksSliderMulti.cshtml"
                                           Write(book.DisplayPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 40 "F:\Ecommerce\Project\SP_Ecommerce\Team27_BookshopWeb\Views\Shared\_BooksSliderMulti.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
