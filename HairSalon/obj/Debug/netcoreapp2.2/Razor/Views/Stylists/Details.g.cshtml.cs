#pragma checksum "C:\Users\p403s\Desktop\HairSalon\HairSalon\Views\Stylists\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cda4ea66eab0ea47c100b82641530ba265a77224"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Stylists_Details), @"mvc.1.0.view", @"/Views/Stylists/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Stylists/Details.cshtml", typeof(AspNetCore.Views_Stylists_Details))]
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
#line 5 "C:\Users\p403s\Desktop\HairSalon\HairSalon\Views\Stylists\Details.cshtml"
using HairSalon.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cda4ea66eab0ea47c100b82641530ba265a77224", @"/Views/Stylists/Details.cshtml")]
    public class Views_Stylists_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HairSalon.Models.Stylist>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\p403s\Desktop\HairSalon\HairSalon\Views\Stylists\Details.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(91, 41, true);
            WriteLiteral("\r\n<h2> Stylist details</h2>\r\n<hr/>\r\n<h3> ");
            EndContext();
            BeginContext(133, 40, false);
#line 10 "C:\Users\p403s\Desktop\HairSalon\HairSalon\Views\Stylists\Details.cshtml"
Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(173, 1, true);
            WriteLiteral(":");
            EndContext();
            BeginContext(175, 36, false);
#line 10 "C:\Users\p403s\Desktop\HairSalon\HairSalon\Views\Stylists\Details.cshtml"
                                          Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(211, 17, true);
            WriteLiteral("</h3>\r\n<li>\r\n    ");
            EndContext();
            BeginContext(229, 46, false);
#line 12 "C:\Users\p403s\Desktop\HairSalon\HairSalon\Views\Stylists\Details.cshtml"
Write(Html.DisplayNameFor(model => model.specialist));

#line default
#line hidden
            EndContext();
            BeginContext(275, 2, true);
            WriteLiteral(": ");
            EndContext();
            BeginContext(278, 42, false);
#line 12 "C:\Users\p403s\Desktop\HairSalon\HairSalon\Views\Stylists\Details.cshtml"
                                                Write(Html.DisplayFor(model => model.specialist));

#line default
#line hidden
            EndContext();
            BeginContext(320, 10, true);
            WriteLiteral("<br>\r\n    ");
            EndContext();
            BeginContext(331, 42, false);
#line 13 "C:\Users\p403s\Desktop\HairSalon\HairSalon\Views\Stylists\Details.cshtml"
Write(Html.DisplayNameFor(model => model.Salary));

#line default
#line hidden
            EndContext();
            BeginContext(373, 2, true);
            WriteLiteral(": ");
            EndContext();
            BeginContext(376, 38, false);
#line 13 "C:\Users\p403s\Desktop\HairSalon\HairSalon\Views\Stylists\Details.cshtml"
                                            Write(Html.DisplayFor(model => model.Salary));

#line default
#line hidden
            EndContext();
            BeginContext(414, 37, true);
            WriteLiteral("\r\n</li>\r\n\r\n<h4>There Clients</h4>\r\n\r\n");
            EndContext();
#line 18 "C:\Users\p403s\Desktop\HairSalon\HairSalon\Views\Stylists\Details.cshtml"
 if (@ViewBag.Clients.Count == 0)
{

#line default
#line hidden
            BeginContext(489, 45, true);
            WriteLiteral("    <p>This Stylists has no Clients yet</p>\r\n");
            EndContext();
#line 21 "C:\Users\p403s\Desktop\HairSalon\HairSalon\Views\Stylists\Details.cshtml"
} 

#line default
#line hidden
            BeginContext(538, 5, true);
            WriteLiteral("\r\n<p>");
            EndContext();
            BeginContext(544, 82, false);
#line 23 "C:\Users\p403s\Desktop\HairSalon\HairSalon\Views\Stylists\Details.cshtml"
Write(Html.ActionLink("Add a Client", "Create", "Clients", new { id = Model.StylistId }));

#line default
#line hidden
            EndContext();
            BeginContext(626, 8, true);
            WriteLiteral("</p>\r\n\r\n");
            EndContext();
#line 25 "C:\Users\p403s\Desktop\HairSalon\HairSalon\Views\Stylists\Details.cshtml"
 foreach (Client client in @ViewBag.Clients)
{

#line default
#line hidden
            BeginContext(683, 17, true);
            WriteLiteral("    <p>\r\n        ");
            EndContext();
            BeginContext(701, 11, false);
#line 28 "C:\Users\p403s\Desktop\HairSalon\HairSalon\Views\Stylists\Details.cshtml"
   Write(client.Name);

#line default
#line hidden
            EndContext();
            BeginContext(712, 14, true);
            WriteLiteral("<br>\r\n        ");
            EndContext();
            BeginContext(727, 10, false);
#line 29 "C:\Users\p403s\Desktop\HairSalon\HairSalon\Views\Stylists\Details.cshtml"
   Write(client.Age);

#line default
#line hidden
            EndContext();
            BeginContext(737, 14, true);
            WriteLiteral("<br>\r\n        ");
            EndContext();
            BeginContext(752, 13, false);
#line 30 "C:\Users\p403s\Desktop\HairSalon\HairSalon\Views\Stylists\Details.cshtml"
   Write(client.Gender);

#line default
#line hidden
            EndContext();
            BeginContext(765, 14, true);
            WriteLiteral("<br>\r\n        ");
            EndContext();
            BeginContext(780, 15, false);
#line 31 "C:\Users\p403s\Desktop\HairSalon\HairSalon\Views\Stylists\Details.cshtml"
   Write(client.LastVist);

#line default
#line hidden
            EndContext();
            BeginContext(795, 14, true);
            WriteLiteral("<br>\r\n        ");
            EndContext();
            BeginContext(810, 12, false);
#line 32 "C:\Users\p403s\Desktop\HairSalon\HairSalon\Views\Stylists\Details.cshtml"
   Write(client.Phone);

#line default
#line hidden
            EndContext();
            BeginContext(822, 12, true);
            WriteLiteral("\r\n    </p>\r\n");
            EndContext();
#line 34 "C:\Users\p403s\Desktop\HairSalon\HairSalon\Views\Stylists\Details.cshtml"
}

#line default
#line hidden
            BeginContext(837, 33, true);
            WriteLiteral("<hr>\r\n\r\n<h4>Appointments</h4>\r\n\r\n");
            EndContext();
#line 39 "C:\Users\p403s\Desktop\HairSalon\HairSalon\Views\Stylists\Details.cshtml"
 if (@ViewBag.Appointments.Count == 0)
{

#line default
#line hidden
            BeginContext(913, 37, true);
            WriteLiteral("    <p>No Upcoming Appointments</p>\r\n");
            EndContext();
#line 42 "C:\Users\p403s\Desktop\HairSalon\HairSalon\Views\Stylists\Details.cshtml"
} 

#line default
#line hidden
            BeginContext(954, 5, true);
            WriteLiteral("\r\n<p>");
            EndContext();
            BeginContext(960, 93, false);
#line 44 "C:\Users\p403s\Desktop\HairSalon\HairSalon\Views\Stylists\Details.cshtml"
Write(Html.ActionLink("Add an Appointment", "Create", "Appointments", new { id = Model.StylistId }));

#line default
#line hidden
            EndContext();
            BeginContext(1053, 8, true);
            WriteLiteral("</p>\r\n\r\n");
            EndContext();
#line 46 "C:\Users\p403s\Desktop\HairSalon\HairSalon\Views\Stylists\Details.cshtml"
 foreach (Appointment appointment in @ViewBag.Appointments)
{

#line default
#line hidden
            BeginContext(1125, 23, true);
            WriteLiteral("    <p>\r\n        Date: ");
            EndContext();
            BeginContext(1149, 16, false);
#line 49 "C:\Users\p403s\Desktop\HairSalon\HairSalon\Views\Stylists\Details.cshtml"
         Write(appointment.Date);

#line default
#line hidden
            EndContext();
            BeginContext(1165, 25, true);
            WriteLiteral("<br>\r\n        Client ID: ");
            EndContext();
            BeginContext(1191, 20, false);
#line 50 "C:\Users\p403s\Desktop\HairSalon\HairSalon\Views\Stylists\Details.cshtml"
              Write(appointment.ClientId);

#line default
#line hidden
            EndContext();
            BeginContext(1211, 26, true);
            WriteLiteral("<br>\r\n        \r\n    </p>\r\n");
            EndContext();
#line 53 "C:\Users\p403s\Desktop\HairSalon\HairSalon\Views\Stylists\Details.cshtml"
}

#line default
#line hidden
            BeginContext(1240, 11, true);
            WriteLiteral("<hr>\r\n\r\n<p>");
            EndContext();
            BeginContext(1252, 40, false);
#line 56 "C:\Users\p403s\Desktop\HairSalon\HairSalon\Views\Stylists\Details.cshtml"
Write(Html.ActionLink("Back to list", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(1292, 9, true);
            WriteLiteral("</p>\r\n<p>");
            EndContext();
            BeginContext(1302, 66, false);
#line 57 "C:\Users\p403s\Desktop\HairSalon\HairSalon\Views\Stylists\Details.cshtml"
Write(Html.ActionLink("Edit Stylist", "Edit", new {id= Model.StylistId}));

#line default
#line hidden
            EndContext();
            BeginContext(1368, 9, true);
            WriteLiteral("</p>\r\n<p>");
            EndContext();
            BeginContext(1378, 70, false);
#line 58 "C:\Users\p403s\Desktop\HairSalon\HairSalon\Views\Stylists\Details.cshtml"
Write(Html.ActionLink("Delete Stylist", "Delete", new {id= Model.StylistId}));

#line default
#line hidden
            EndContext();
            BeginContext(1448, 8, true);
            WriteLiteral("</p>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HairSalon.Models.Stylist> Html { get; private set; }
    }
}
#pragma warning restore 1591
