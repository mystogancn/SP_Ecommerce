#pragma checksum "G:\Lưu Trữ\File nộp (File responses)\Nhom27_WebsiteBanSach - Phương Lê Thị Trúc\Team27_BookshopWeb\Team27_BookshopWeb\Views\Shared\Components\PublisherSlider\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5b54de7716ea7f8fac5316e45d8719ebc8f5b6dc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_PublisherSlider_Default), @"mvc.1.0.view", @"/Views/Shared/Components/PublisherSlider/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5b54de7716ea7f8fac5316e45d8719ebc8f5b6dc", @"/Views/Shared/Components/PublisherSlider/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b095e99e3dd484b538f8cd4863877373ad092328", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_PublisherSlider_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Team27_BookshopWeb.Entities.Publisher>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:50px; height:40px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 5 "G:\Lưu Trữ\File nộp (File responses)\Nhom27_WebsiteBanSach - Phương Lê Thị Trúc\Team27_BookshopWeb\Team27_BookshopWeb\Views\Shared\Components\PublisherSlider\Default.cshtml"
 if (Model.Count() > 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <section class=""section-margin brand-slider"">
        <h2 class=""sr-only"">Publishers Slider</h2>
        <div class=""container"">
            <div class=""brand-slider sb-slick-slider border-top border-bottom"" data-slick-setting='{
                                            ""autoplay"": true,
                                            ""autoplaySpeed"": 2000,
                                            ""slidesToShow"": 6
                                            }' data-slick-responsive='[
                {""breakpoint"":992, ""settings"": {""slidesToShow"": 4} },
                {""breakpoint"":768, ""settings"": {""slidesToShow"": 3} },
                {""breakpoint"":575, ""settings"": {""slidesToShow"": 3} },
                {""breakpoint"":480, ""settings"": {""slidesToShow"": 2} },
                {""breakpoint"":320, ""settings"": {""slidesToShow"": 1} }
            ]'>
");
#nullable restore
#line 21 "G:\Lưu Trữ\File nộp (File responses)\Nhom27_WebsiteBanSach - Phương Lê Thị Trúc\Team27_BookshopWeb\Team27_BookshopWeb\Views\Shared\Components\PublisherSlider\Default.cshtml"
                 foreach (var publisher in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"single-slide\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "5b54de7716ea7f8fac5316e45d8719ebc8f5b6dc5485", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1238, "~/Team27StaticFiles/images/publishers/", 1238, 38, true);
#nullable restore
#line 24 "G:\Lưu Trữ\File nộp (File responses)\Nhom27_WebsiteBanSach - Phương Lê Thị Trúc\Team27_BookshopWeb\Team27_BookshopWeb\Views\Shared\Components\PublisherSlider\Default.cshtml"
AddHtmlAttributeValue("", 1276, publisher.Image, 1276, 16, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 24 "G:\Lưu Trữ\File nộp (File responses)\Nhom27_WebsiteBanSach - Phương Lê Thị Trúc\Team27_BookshopWeb\Team27_BookshopWeb\Views\Shared\Components\PublisherSlider\Default.cshtml"
AddHtmlAttributeValue("", 1331, publisher.DisplayName, 1331, 22, false);

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
            WriteLiteral("\r\n                    </div>\r\n");
#nullable restore
#line 26 "G:\Lưu Trữ\File nộp (File responses)\Nhom27_WebsiteBanSach - Phương Lê Thị Trúc\Team27_BookshopWeb\Team27_BookshopWeb\Views\Shared\Components\PublisherSlider\Default.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n    </section>\r\n");
#nullable restore
#line 30 "G:\Lưu Trữ\File nộp (File responses)\Nhom27_WebsiteBanSach - Phương Lê Thị Trúc\Team27_BookshopWeb\Team27_BookshopWeb\Views\Shared\Components\PublisherSlider\Default.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Team27_BookshopWeb.Entities.Publisher>> Html { get; private set; }
    }
}
#pragma warning restore 1591
