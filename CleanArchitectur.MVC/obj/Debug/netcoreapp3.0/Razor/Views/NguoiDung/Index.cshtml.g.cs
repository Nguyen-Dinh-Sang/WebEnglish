#pragma checksum "C:\Users\Admin\Desktop\WebEnglish\CleanArchitectur.MVC\Views\NguoiDung\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f000a2f321c167db3290e478c565e28551f61b7f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_NguoiDung_Index), @"mvc.1.0.view", @"/Views/NguoiDung/Index.cshtml")]
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
#line 1 "C:\Users\Admin\Desktop\WebEnglish\CleanArchitectur.MVC\Views\_ViewImports.cshtml"
using CleanArchitectur.MVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Admin\Desktop\WebEnglish\CleanArchitectur.MVC\Views\_ViewImports.cshtml"
using CleanArchitectur.MVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f000a2f321c167db3290e478c565e28551f61b7f", @"/Views/NguoiDung/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aa707c28424a141f68426f4662e83021ce0e24a9", @"/Views/_ViewImports.cshtml")]
    public class Views_NguoiDung_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CleanArchitecture.Application.ViewModels.SaveNguoiDung>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Admin\Desktop\WebEnglish\CleanArchitectur.MVC\Views\NguoiDung\Index.cshtml"
  
    ViewData["Title"] = "NguoiDung";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Người Dùng</h1>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 12 "C:\Users\Admin\Desktop\WebEnglish\CleanArchitectur.MVC\Views\NguoiDung\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.TenNguoiDung));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 15 "C:\Users\Admin\Desktop\WebEnglish\CleanArchitectur.MVC\Views\NguoiDung\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.TaiKhoan));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 18 "C:\Users\Admin\Desktop\WebEnglish\CleanArchitectur.MVC\Views\NguoiDung\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.MatKhau));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 21 "C:\Users\Admin\Desktop\WebEnglish\CleanArchitectur.MVC\Views\NguoiDung\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.NgayTao));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 24 "C:\Users\Admin\Desktop\WebEnglish\CleanArchitectur.MVC\Views\NguoiDung\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.SoDienThoai));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 27 "C:\Users\Admin\Desktop\WebEnglish\CleanArchitectur.MVC\Views\NguoiDung\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Gmail));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 30 "C:\Users\Admin\Desktop\WebEnglish\CleanArchitectur.MVC\Views\NguoiDung\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.VaiTro));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 36 "C:\Users\Admin\Desktop\WebEnglish\CleanArchitectur.MVC\Views\NguoiDung\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 39 "C:\Users\Admin\Desktop\WebEnglish\CleanArchitectur.MVC\Views\NguoiDung\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.TenNguoiDung));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 42 "C:\Users\Admin\Desktop\WebEnglish\CleanArchitectur.MVC\Views\NguoiDung\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.TaiKhoan));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 45 "C:\Users\Admin\Desktop\WebEnglish\CleanArchitectur.MVC\Views\NguoiDung\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.MatKhau));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 48 "C:\Users\Admin\Desktop\WebEnglish\CleanArchitectur.MVC\Views\NguoiDung\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.NgayTao));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 51 "C:\Users\Admin\Desktop\WebEnglish\CleanArchitectur.MVC\Views\NguoiDung\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.SoDienThoai));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 54 "C:\Users\Admin\Desktop\WebEnglish\CleanArchitectur.MVC\Views\NguoiDung\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Gmail));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 57 "C:\Users\Admin\Desktop\WebEnglish\CleanArchitectur.MVC\Views\NguoiDung\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.VaiTro));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f000a2f321c167db3290e478c565e28551f61b7f8644", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 60 "C:\Users\Admin\Desktop\WebEnglish\CleanArchitectur.MVC\Views\NguoiDung\Index.cshtml"
                                       WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 63 "C:\Users\Admin\Desktop\WebEnglish\CleanArchitectur.MVC\Views\NguoiDung\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CleanArchitecture.Application.ViewModels.SaveNguoiDung>> Html { get; private set; }
    }
}
#pragma warning restore 1591
