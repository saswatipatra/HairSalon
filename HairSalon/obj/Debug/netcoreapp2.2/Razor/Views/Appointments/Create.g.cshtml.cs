#pragma checksum "C:\Users\p403s\Desktop\HairSalon\HairSalon\Views\Appointments\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6a352be3d213b25808851bf2ac3a8f8ed04afc78"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Appointments_Create), @"mvc.1.0.view", @"/Views/Appointments/Create.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Appointments/Create.cshtml", typeof(AspNetCore.Views_Appointments_Create))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6a352be3d213b25808851bf2ac3a8f8ed04afc78", @"/Views/Appointments/Create.cshtml")]
    public class Views_Appointments_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HairSalon.Models.Appointment>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\p403s\Desktop\HairSalon\HairSalon\Views\Appointments\Create.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
            BeginContext(32, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(71, 24, true);
            WriteLiteral("<h4>New Appointment for ");
            EndContext();
            BeginContext(96, 20, false);
#line 6 "C:\Users\p403s\Desktop\HairSalon\HairSalon\Views\Appointments\Create.cshtml"
                   Write(ViewBag.Stylist.Name);

#line default
#line hidden
            EndContext();
            BeginContext(116, 9, true);
            WriteLiteral("</h4>\r\n\r\n");
            EndContext();
#line 8 "C:\Users\p403s\Desktop\HairSalon\HairSalon\Views\Appointments\Create.cshtml"
 using (Html.BeginForm())
{

#line default
#line hidden
            BeginContext(155, 125, true);
            WriteLiteral("    <input data-val=\"true\" data-val-required=\"The StylistId field is required.\" id=\"StylistId\" name=\"StylistId\" type=\"hidden\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 280, "\"", 314, 1);
#line 10 "C:\Users\p403s\Desktop\HairSalon\HairSalon\Views\Appointments\Create.cshtml"
WriteAttributeValue("", 288, ViewBag.Stylist.StylistId, 288, 26, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(315, 3, true);
            WriteLiteral(">\r\n");
            EndContext();
            BeginContext(325, 36, false);
#line 12 "C:\Users\p403s\Desktop\HairSalon\HairSalon\Views\Appointments\Create.cshtml"
Write(Html.LabelFor(model => model.Client));

#line default
#line hidden
            EndContext();
            BeginContext(368, 29, false);
#line 13 "C:\Users\p403s\Desktop\HairSalon\HairSalon\Views\Appointments\Create.cshtml"
Write(Html.DropDownList("ClientId"));

#line default
#line hidden
            EndContext();
            BeginContext(397, 6, true);
            WriteLiteral("<br>\r\n");
            EndContext();
            BeginContext(414, 34, false);
#line 15 "C:\Users\p403s\Desktop\HairSalon\HairSalon\Views\Appointments\Create.cshtml"
Write(Html.LabelFor(model => model.Date));

#line default
#line hidden
            EndContext();
            BeginContext(450, 41, true);
            WriteLiteral("    <input name=\"Date\" type=\"date\"><br>\r\n");
            EndContext();
            BeginContext(493, 77, true);
            WriteLiteral("    <input type=\"submit\" value=\"Add Appointment\" class=\"btn btn-default\"/> \r\n");
            EndContext();
#line 19 "C:\Users\p403s\Desktop\HairSalon\HairSalon\Views\Appointments\Create.cshtml"
}

#line default
#line hidden
            BeginContext(573, 5, true);
            WriteLiteral("\r\n<p>");
            EndContext();
            BeginContext(579, 87, false);
#line 21 "C:\Users\p403s\Desktop\HairSalon\HairSalon\Views\Appointments\Create.cshtml"
Write(Html.ActionLink("Back", "Details", "Stylists", new { id = @ViewBag.Stylist.StylistId }));

#line default
#line hidden
            EndContext();
            BeginContext(666, 4, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HairSalon.Models.Appointment> Html { get; private set; }
    }
}
#pragma warning restore 1591
