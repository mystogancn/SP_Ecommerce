#pragma checksum "F:\Ecommerce\Project\SP_Ecommerce\Team27_BookshopWeb\Views\Shared\_AuTransView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e96d7dc50cab83295ae499adfb4bb1745df4adbe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__AuTransView), @"mvc.1.0.view", @"/Views/Shared/_AuTransView.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e96d7dc50cab83295ae499adfb4bb1745df4adbe", @"/Views/Shared/_AuTransView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b095e99e3dd484b538f8cd4863877373ad092328", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__AuTransView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Team27_BookshopWeb.Areas.admin.Models.AuthorTranslatorViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 6 "F:\Ecommerce\Project\SP_Ecommerce\Team27_BookshopWeb\Views\Shared\_AuTransView.cshtml"
 if (Model.AuthorTranslators.Count() > 0)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "F:\Ecommerce\Project\SP_Ecommerce\Team27_BookshopWeb\Views\Shared\_AuTransView.cshtml"
     foreach (var auTrans in Model.AuthorTranslators)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                <div class=\"table-data__info ID\">\r\n                    <h6>");
#nullable restore
#line 13 "F:\Ecommerce\Project\SP_Ecommerce\Team27_BookshopWeb\Views\Shared\_AuTransView.cshtml"
                   Write(auTrans.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                </div>\r\n            </td>\r\n            <td>\r\n                <div class=\"table-data__info\">\r\n                    <input type=\"text\" name=\"Name\" placeholder=\"Họ tên\" class=\"form-control Name\"");
            BeginWriteAttribute("value", " value=\"", 636, "\"", 664, 1);
#nullable restore
#line 18 "F:\Ecommerce\Project\SP_Ecommerce\Team27_BookshopWeb\Views\Shared\_AuTransView.cshtml"
WriteAttributeValue("", 644, auTrans.DisplayName, 644, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" readonly required>\r\n                    <input type=\"text\" name=\"Slug\" placeholder=\"Slug\" class=\"form-control Slug\"");
            BeginWriteAttribute("value", " value=\"", 781, "\"", 802, 1);
#nullable restore
#line 19 "F:\Ecommerce\Project\SP_Ecommerce\Team27_BookshopWeb\Views\Shared\_AuTransView.cshtml"
WriteAttributeValue("", 789, auTrans.Slug, 789, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" readonly required>\r\n                </div>\r\n            </td>\r\n            <td>\r\n                <label class=\"checkbox\">\r\n                    <input type=\"checkbox\" class=\"ckb_au Tacgia\" name=\"Author\" ");
#nullable restore
#line 24 "F:\Ecommerce\Project\SP_Ecommerce\Team27_BookshopWeb\Views\Shared\_AuTransView.cshtml"
                                                                           Write(auTrans.Author == 1 ? "checked" : "");

#line default
#line hidden
#nullable disable
            WriteLiteral(">\r\n                </label>\r\n            </td>\r\n            <td>\r\n                <label class=\"checkbox\">\r\n                    <input type=\"checkbox\" class=\"ckb_trans Dichgia\" name=\"Translator\" ");
#nullable restore
#line 29 "F:\Ecommerce\Project\SP_Ecommerce\Team27_BookshopWeb\Views\Shared\_AuTransView.cshtml"
                                                                                   Write(auTrans.Translator == 1 ? "checked" : "");

#line default
#line hidden
#nullable disable
            WriteLiteral(">\r\n                </label>\r\n            </td>\r\n            <td>\r\n                <div class=\"table-data-feature\">\r\n");
#nullable restore
#line 34 "F:\Ecommerce\Project\SP_Ecommerce\Team27_BookshopWeb\Views\Shared\_AuTransView.cshtml"
                     if (Model.Filter == "Deleted")
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <button class=""item btnRestore"" data-toggle=""tooltip"" data-placement=""top"" title=""Khôi phục"">
                            <i class=""fa fa-undo""></i>
                        </button>
                        <button class=""item btnDeleteForever"" data-toggle=""tooltip"" data-placement=""top"" title=""Xóa vĩnh viễn"">
                            <i style=""color:red;"" class=""fa fa-trash""></i>
                        </button>
");
#nullable restore
#line 42 "F:\Ecommerce\Project\SP_Ecommerce\Team27_BookshopWeb\Views\Shared\_AuTransView.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <button class=""item btnHuy"" data-toggle=""tooltip"" data-placement=""top"" title=""Thoát chỉnh sửa"" style=""display: none;"">
                            <i class=""fa fa-times""></i>
                        </button>
                        <button class=""item btnLuu"" data-toggle=""tooltip"" data-placement=""top"" title=""Lưu"" style=""display: none;"">
                            <i class=""fa fa-save""></i>
                        </button>
                        <button class=""item btnSua"" data-toggle=""tooltip"" data-placement=""top"" title=""Sửa"">
                            <i class=""fa fa-pencil-square""></i>
                        </button>
                        <button class=""item btnXoa"" data-toggle=""tooltip"" data-placement=""top"" title=""Xóa"">
                            <i class=""zmdi zmdi-delete""></i>
                        </button>
");
#nullable restore
#line 57 "F:\Ecommerce\Project\SP_Ecommerce\Team27_BookshopWeb\Views\Shared\_AuTransView.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 61 "F:\Ecommerce\Project\SP_Ecommerce\Team27_BookshopWeb\Views\Shared\_AuTransView.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 61 "F:\Ecommerce\Project\SP_Ecommerce\Team27_BookshopWeb\Views\Shared\_AuTransView.cshtml"
     
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <tr>\r\n        <td colspan=\"5\" style=\"text-align:center;\">\r\n            Không có tác giả hoặc dịch giả để hiển thị\r\n        </td>\r\n    </tr>\r\n");
#nullable restore
#line 70 "F:\Ecommerce\Project\SP_Ecommerce\Team27_BookshopWeb\Views\Shared\_AuTransView.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<tr>\r\n    <td colspan=\"5\">\r\n        <div id=\"pagination-place\" style=\"text-align: center;\">\r\n            <!-- PHÂN TRANG -->\r\n");
#nullable restore
#line 75 "F:\Ecommerce\Project\SP_Ecommerce\Team27_BookshopWeb\Views\Shared\_AuTransView.cshtml"
             if (Model.AllPages > 1 && Model.CurrentPage != Model.AllPages && Model.CurrentPage != 0)
            {
                int nextPage = Model.CurrentPage + 1;

#line default
#line hidden
#nullable disable
            WriteLiteral("                <button class=\"au-btn au-btn-load js-load-btn\" data-page=\"");
#nullable restore
#line 78 "F:\Ecommerce\Project\SP_Ecommerce\Team27_BookshopWeb\Views\Shared\_AuTransView.cshtml"
                                                                      Write(nextPage <= Model.AllPages ? nextPage : Model.CurrentPage);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">Xem thêm</button>\r\n");
#nullable restore
#line 79 "F:\Ecommerce\Project\SP_Ecommerce\Team27_BookshopWeb\Views\Shared\_AuTransView.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </td>\r\n    \r\n</tr>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Team27_BookshopWeb.Areas.admin.Models.AuthorTranslatorViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
