#pragma checksum "C:\Users\p403s\Desktop\HairSalon\HairSalon\Views\Client\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fb0f7a11e9948bb7b2bc8b13660dbdaea1bf42a0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Client_Index), @"mvc.1.0.view", @"/Views/Client/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Client/Index.cshtml", typeof(AspNetCore.Views_Client_Index))]
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
#line 6 "C:\Users\p403s\Desktop\HairSalon\HairSalon\Views\Client\Index.cshtml"
using HairSalon.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb0f7a11e9948bb7b2bc8b13660dbdaea1bf42a0", @"/Views/Client/Index.cshtml")]
    public class Views_Client_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<HairSalon.Models.Client>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\p403s\Desktop\HairSalon\HairSalon\Views\Client\Index.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(32, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(99, 26, true);
            WriteLiteral("\r\n    <h1>Clients</h1>\r\n\r\n");
            EndContext();
#line 11 "C:\Users\p403s\Desktop\HairSalon\HairSalon\Views\Client\Index.cshtml"
     if (@Model.Count == 0)
    {

#line default
#line hidden
            BeginContext(161, 49, true);
            WriteLiteral("        <h3>No Clients have been added yet</h3>\r\n");
            EndContext();
#line 14 "C:\Users\p403s\Desktop\HairSalon\HairSalon\Views\Client\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(217, 10, true);
            WriteLiteral("\r\n    <ul>");
            EndContext();
#line 16 "C:\Users\p403s\Desktop\HairSalon\HairSalon\Views\Client\Index.cshtml"
         foreach(Client client in Model)
        {

#line default
#line hidden
            BeginContext(272, 17, true);
            WriteLiteral("            <li> ");
            EndContext();
            BeginContext(290, 72, false);
#line 18 "C:\Users\p403s\Desktop\HairSalon\HairSalon\Views\Client\Index.cshtml"
            Write(Html.ActionLink($"{client.Name}", "Details", new {id = client.ClientId}));

#line default
#line hidden
            EndContext();
            BeginContext(362, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 19 "C:\Users\p403s\Desktop\HairSalon\HairSalon\Views\Client\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(380, 17, true);
            WriteLiteral("    </ul>\r\n\r\n<p> ");
            EndContext();
            BeginContext(398, 43, false);
#line 22 "C:\Users\p403s\Desktop\HairSalon\HairSalon\Views\Client\Index.cshtml"
Write(Html.ActionLink("Add new Client", "Create"));

#line default
#line hidden
            EndContext();
            BeginContext(441, 9, true);
            WriteLiteral("</p>\r\n<p>");
            EndContext();
            BeginContext(451, 40, false);
#line 23 "C:\Users\p403s\Desktop\HairSalon\HairSalon\Views\Client\Index.cshtml"
Write(Html.ActionLink("Home", "Index", "Home"));

#line default
#line hidden
            EndContext();
            BeginContext(491, 6, true);
            WriteLiteral("</p>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<HairSalon.Models.Client>> Html { get; private set; }
    }
}
#pragma warning restore 1591
