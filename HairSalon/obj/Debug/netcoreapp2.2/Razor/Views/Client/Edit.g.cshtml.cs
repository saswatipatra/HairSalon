#pragma checksum "C:\Users\p403s\Desktop\HairSalon\HairSalon\Views\Client\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "25228af7a81a7db79c92d737461dff6c77596d97"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Client_Edit), @"mvc.1.0.view", @"/Views/Client/Edit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Client/Edit.cshtml", typeof(AspNetCore.Views_Client_Edit))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"25228af7a81a7db79c92d737461dff6c77596d97", @"/Views/Client/Edit.cshtml")]
    public class Views_Client_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HairSalon.Models.Client>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\p403s\Desktop\HairSalon\HairSalon\Views\Client\Edit.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(32, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(66, 21, true);
            WriteLiteral("\r\n<h3>edit the list: ");
            EndContext();
            BeginContext(88, 36, false);
#line 8 "C:\Users\p403s\Desktop\HairSalon\HairSalon\Views\Client\Edit.cshtml"
              Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(124, 9, true);
            WriteLiteral("</h3>\r\n\r\n");
            EndContext();
#line 10 "C:\Users\p403s\Desktop\HairSalon\HairSalon\Views\Client\Edit.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
            BeginContext(168, 39, false);
#line 12 "C:\Users\p403s\Desktop\HairSalon\HairSalon\Views\Client\Edit.cshtml"
Write(Html.HiddenFor(model => model.ClientId));

#line default
#line hidden
            EndContext();
            BeginContext(216, 34, false);
#line 14 "C:\Users\p403s\Desktop\HairSalon\HairSalon\Views\Client\Edit.cshtml"
Write(Html.LabelFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(258, 35, false);
#line 15 "C:\Users\p403s\Desktop\HairSalon\HairSalon\Views\Client\Edit.cshtml"
Write(Html.EditorFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(303, 33, false);
#line 17 "C:\Users\p403s\Desktop\HairSalon\HairSalon\Views\Client\Edit.cshtml"
Write(Html.LabelFor(model => model.Age));

#line default
#line hidden
            EndContext();
            BeginContext(344, 34, false);
#line 18 "C:\Users\p403s\Desktop\HairSalon\HairSalon\Views\Client\Edit.cshtml"
Write(Html.EditorFor(model => model.Age));

#line default
#line hidden
            EndContext();
            BeginContext(388, 36, false);
#line 20 "C:\Users\p403s\Desktop\HairSalon\HairSalon\Views\Client\Edit.cshtml"
Write(Html.LabelFor(model => model.Gender));

#line default
#line hidden
            EndContext();
            BeginContext(432, 37, false);
#line 21 "C:\Users\p403s\Desktop\HairSalon\HairSalon\Views\Client\Edit.cshtml"
Write(Html.EditorFor(model => model.Gender));

#line default
#line hidden
            EndContext();
            BeginContext(479, 38, false);
#line 23 "C:\Users\p403s\Desktop\HairSalon\HairSalon\Views\Client\Edit.cshtml"
Write(Html.LabelFor(model => model.LastVist));

#line default
#line hidden
            EndContext();
            BeginContext(525, 39, false);
#line 24 "C:\Users\p403s\Desktop\HairSalon\HairSalon\Views\Client\Edit.cshtml"
Write(Html.EditorFor(model => model.LastVist));

#line default
#line hidden
            EndContext();
            BeginContext(568, 45, true);
            WriteLiteral("     <input type =\"submit\" value =\"Save\" />\r\n");
            EndContext();
#line 27 "C:\Users\p403s\Desktop\HairSalon\HairSalon\Views\Client\Edit.cshtml"

}

#line default
#line hidden
            BeginContext(618, 6, true);
            WriteLiteral("\r\n<p> ");
            EndContext();
            BeginContext(625, 40, false);
#line 30 "C:\Users\p403s\Desktop\HairSalon\HairSalon\Views\Client\Edit.cshtml"
Write(Html.ActionLink("Back to List", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(665, 4, true);
            WriteLiteral("</p>");
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