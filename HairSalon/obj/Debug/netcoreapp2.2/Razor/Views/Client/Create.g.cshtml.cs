#pragma checksum "C:\Users\p403s\Desktop\HairSalon\HairSalon\Views\Client\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "97f3e07a8e6cc6b66c57173bb99c49f2e03dd274"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Client_Create), @"mvc.1.0.view", @"/Views/Client/Create.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Client/Create.cshtml", typeof(AspNetCore.Views_Client_Create))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"97f3e07a8e6cc6b66c57173bb99c49f2e03dd274", @"/Views/Client/Create.cshtml")]
    public class Views_Client_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HairSalon.Models.Client>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\p403s\Desktop\HairSalon\HairSalon\Views\Client\Create.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(32, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(66, 31, true);
            WriteLiteral("\r\n<h4>Add a new Client</h4>\r\n\r\n");
            EndContext();
#line 10 "C:\Users\p403s\Desktop\HairSalon\HairSalon\Views\Client\Create.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
            BeginContext(132, 34, false);
#line 12 "C:\Users\p403s\Desktop\HairSalon\HairSalon\Views\Client\Create.cshtml"
Write(Html.LabelFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(173, 36, false);
#line 13 "C:\Users\p403s\Desktop\HairSalon\HairSalon\Views\Client\Create.cshtml"
Write(Html.TextBoxFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(218, 33, false);
#line 15 "C:\Users\p403s\Desktop\HairSalon\HairSalon\Views\Client\Create.cshtml"
Write(Html.LabelFor(model => model.Age));

#line default
#line hidden
            EndContext();
            BeginContext(258, 35, false);
#line 16 "C:\Users\p403s\Desktop\HairSalon\HairSalon\Views\Client\Create.cshtml"
Write(Html.TextBoxFor(model => model.Age));

#line default
#line hidden
            EndContext();
            BeginContext(302, 36, false);
#line 18 "C:\Users\p403s\Desktop\HairSalon\HairSalon\Views\Client\Create.cshtml"
Write(Html.LabelFor(model => model.Gender));

#line default
#line hidden
            EndContext();
            BeginContext(345, 38, false);
#line 19 "C:\Users\p403s\Desktop\HairSalon\HairSalon\Views\Client\Create.cshtml"
Write(Html.TextBoxFor(model => model.Gender));

#line default
#line hidden
            EndContext();
            BeginContext(392, 38, false);
#line 21 "C:\Users\p403s\Desktop\HairSalon\HairSalon\Views\Client\Create.cshtml"
Write(Html.LabelFor(model => model.LastVist));

#line default
#line hidden
            EndContext();
            BeginContext(437, 40, false);
#line 22 "C:\Users\p403s\Desktop\HairSalon\HairSalon\Views\Client\Create.cshtml"
Write(Html.TextBoxFor(model => model.LastVist));

#line default
#line hidden
            EndContext();
            BeginContext(486, 37, false);
#line 24 "C:\Users\p403s\Desktop\HairSalon\HairSalon\Views\Client\Create.cshtml"
Write(Html.LabelFor(model => model.Stylist));

#line default
#line hidden
            EndContext();
            BeginContext(530, 30, false);
#line 25 "C:\Users\p403s\Desktop\HairSalon\HairSalon\Views\Client\Create.cshtml"
Write(Html.DropDownList("StylistId"));

#line default
#line hidden
            EndContext();
            BeginContext(564, 79, true);
            WriteLiteral("    <input type=\"submit\" value=\"add a new Client\" class =\"btn btn-default\" />\r\n");
            EndContext();
#line 28 "C:\Users\p403s\Desktop\HairSalon\HairSalon\Views\Client\Create.cshtml"

   
}

#line default
#line hidden
            BeginContext(653, 7, true);
            WriteLiteral("\r\n\r\n<p>");
            EndContext();
            BeginContext(661, 44, false);
#line 33 "C:\Users\p403s\Desktop\HairSalon\HairSalon\Views\Client\Create.cshtml"
Write(Html.ActionLink("Show all Clients", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(705, 6, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HairSalon.Models.Client> Html { get; private set; }
    }
}
#pragma warning restore 1591