#pragma checksum "C:\Users\Eren\source\repos\ShopApp\ShopApp.WebUI\Views\Admin\ProductList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "32dcb4f39c38a7f31c137ef0d073a596645faa95"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_ProductList), @"mvc.1.0.view", @"/Views/Admin/ProductList.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/ProductList.cshtml", typeof(AspNetCore.Views_Admin_ProductList))]
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
#line 1 "C:\Users\Eren\source\repos\ShopApp\ShopApp.WebUI\Views\_ViewImports.cshtml"
using ShopApp.Entities;

#line default
#line hidden
#line 2 "C:\Users\Eren\source\repos\ShopApp\ShopApp.WebUI\Views\_ViewImports.cshtml"
using ShopApp.WebUI.Extensions;

#line default
#line hidden
#line 3 "C:\Users\Eren\source\repos\ShopApp\ShopApp.WebUI\Views\_ViewImports.cshtml"
using ShopApp.WebUI.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"32dcb4f39c38a7f31c137ef0d073a596645faa95", @"/Views/Admin/ProductList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bba9d18e6cd03824774928bc0c6e7efed7781353", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_ProductList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductListModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("80"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/admin/deleteproduct"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("display:inline;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Eren\source\repos\ShopApp\ShopApp.WebUI\Views\Admin\ProductList.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(62, 33, true);
            WriteLiteral("\n<h1>Admin Products</h1>\n<hr />\n\n");
            EndContext();
#line 9 "C:\Users\Eren\source\repos\ShopApp\ShopApp.WebUI\Views\Admin\ProductList.cshtml"
 if (Model.Products.Count() > 0)
{


#line default
#line hidden
            BeginContext(131, 353, true);
            WriteLiteral(@"    <table class=""table table-bordered"">
        <thead>
            <tr>
                <td style=""width:30px;"">Id</td>
                <td style=""width:100px;"">Image</td>
                <td>Name</td>
                <td style=""width:12px;"">Price</td>
                <td style=""width:150px;""></td>
            </tr>
        </thead>
        <tbody>
");
            EndContext();
#line 23 "C:\Users\Eren\source\repos\ShopApp\ShopApp.WebUI\Views\Admin\ProductList.cshtml"
             foreach (var item in Model.Products)
            {

#line default
#line hidden
            BeginContext(548, 45, true);
            WriteLiteral("                <tr>\n                    <td>");
            EndContext();
            BeginContext(594, 7, false);
#line 26 "C:\Users\Eren\source\repos\ShopApp\ShopApp.WebUI\Views\Admin\ProductList.cshtml"
                   Write(item.Id);

#line default
#line hidden
            EndContext();
            BeginContext(601, 55, true);
            WriteLiteral("</td>\n                    <td>\n                        ");
            EndContext();
            BeginContext(656, 45, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "32dcb4f39c38a7f31c137ef0d073a596645faa956563", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 666, "~/img/", 666, 6, true);
#line 28 "C:\Users\Eren\source\repos\ShopApp\ShopApp.WebUI\Views\Admin\ProductList.cshtml"
AddHtmlAttributeValue("", 672, item.ImageUrl, 672, 14, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(701, 51, true);
            WriteLiteral("\n                    </td>\n                    <td>");
            EndContext();
            BeginContext(753, 9, false);
#line 30 "C:\Users\Eren\source\repos\ShopApp\ShopApp.WebUI\Views\Admin\ProductList.cshtml"
                   Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(762, 30, true);
            WriteLiteral("</td>\n                    <td>");
            EndContext();
            BeginContext(793, 10, false);
#line 31 "C:\Users\Eren\source\repos\ShopApp\ShopApp.WebUI\Views\Admin\ProductList.cshtml"
                   Write(item.Price);

#line default
#line hidden
            EndContext();
            BeginContext(803, 93, true);
            WriteLiteral("</td>\n                    <td>\n                        <a class=\"btn btn-primary btn-sm mr-2\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 896, "\"", 927, 2);
            WriteAttributeValue("", 903, "/admin/products/", 903, 16, true);
#line 33 "C:\Users\Eren\source\repos\ShopApp\ShopApp.WebUI\Views\Admin\ProductList.cshtml"
WriteAttributeValue("", 919, item.Id, 919, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(928, 34, true);
            WriteLiteral(">Edit</a>\n                        ");
            EndContext();
            BeginContext(962, 288, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "32dcb4f39c38a7f31c137ef0d073a596645faa959560", async() => {
                BeginContext(1036, 66, true);
                WriteLiteral("\n                            <input type=\"hidden\" name=\"productId\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1102, "\"", 1118, 1);
#line 35 "C:\Users\Eren\source\repos\ShopApp\ShopApp.WebUI\Views\Admin\ProductList.cshtml"
WriteAttributeValue("", 1110, item.Id, 1110, 8, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1119, 124, true);
                WriteLiteral(" />\n                            <button type=\"submit\" class=\"btn btn-danger btn-sm\">Delete</button>\n                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1250, 49, true);
            WriteLiteral("\n                    </td>\n                </tr>\n");
            EndContext();
#line 40 "C:\Users\Eren\source\repos\ShopApp\ShopApp.WebUI\Views\Admin\ProductList.cshtml"
            }

#line default
#line hidden
            BeginContext(1313, 32, true);
            WriteLiteral("\n        </tbody>\n\n    </table>\n");
            EndContext();
#line 45 "C:\Users\Eren\source\repos\ShopApp\ShopApp.WebUI\Views\Admin\ProductList.cshtml"
}
else
{

#line default
#line hidden
            BeginContext(1354, 78, true);
            WriteLiteral("    <div class=\"alert alert-warning\">\n        <h4>No Products</h4>\n    </div>\n");
            EndContext();
#line 51 "C:\Users\Eren\source\repos\ShopApp\ShopApp.WebUI\Views\Admin\ProductList.cshtml"
}

#line default
#line hidden
            BeginContext(1434, 2, true);
            WriteLiteral("\n\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductListModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
