#pragma checksum "C:\Users\Eren\source\repos\ShopApp\ShopApp.WebUI\Views\Account\ConfirmEmail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9d2d258924dca53ef6520b418540bdb262b89c51"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_ConfirmEmail), @"mvc.1.0.view", @"/Views/Account/ConfirmEmail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Account/ConfirmEmail.cshtml", typeof(AspNetCore.Views_Account_ConfirmEmail))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9d2d258924dca53ef6520b418540bdb262b89c51", @"/Views/Account/ConfirmEmail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bba9d18e6cd03824774928bc0c6e7efed7781353", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_ConfirmEmail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\Eren\source\repos\ShopApp\ShopApp.WebUI\Views\Account\ConfirmEmail.cshtml"
  
    ViewData["Title"] = "ConfirmEmail";

#line default
#line hidden
            BeginContext(50, 68, true);
            WriteLiteral("\r\n<h1>Confirm Email</h1>\r\n<hr\r\n\r\n<div class=\"alert alert-warning\">\r\n");
            EndContext();
#line 10 "C:\Users\Eren\source\repos\ShopApp\ShopApp.WebUI\Views\Account\ConfirmEmail.cshtml"
     if (TempData["message"] != null)
    {
        

#line default
#line hidden
            BeginContext(173, 19, false);
#line 12 "C:\Users\Eren\source\repos\ShopApp\ShopApp.WebUI\Views\Account\ConfirmEmail.cshtml"
   Write(TempData["message"]);

#line default
#line hidden
            EndContext();
#line 12 "C:\Users\Eren\source\repos\ShopApp\ShopApp.WebUI\Views\Account\ConfirmEmail.cshtml"
                            
    }

#line default
#line hidden
            BeginContext(201, 10, true);
            WriteLiteral("</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
