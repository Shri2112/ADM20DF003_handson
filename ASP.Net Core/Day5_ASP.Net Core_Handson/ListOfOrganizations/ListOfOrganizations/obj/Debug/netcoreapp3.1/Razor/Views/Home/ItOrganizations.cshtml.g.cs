#pragma checksum "C:\Users\hp\source\repos\ListOfOrganizations\ListOfOrganizations\Views\Home\ItOrganizations.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "965e20f6ffaae15e4022d75ac651f36a7abe80ac"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ItOrganizations), @"mvc.1.0.view", @"/Views/Home/ItOrganizations.cshtml")]
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
#line 1 "C:\Users\hp\source\repos\ListOfOrganizations\ListOfOrganizations\Views\_ViewImports.cshtml"
using ListOfOrganizations;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\hp\source\repos\ListOfOrganizations\ListOfOrganizations\Views\_ViewImports.cshtml"
using ListOfOrganizations.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"965e20f6ffaae15e4022d75ac651f36a7abe80ac", @"/Views/Home/ItOrganizations.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"349543b31ccb5096891defcad4ec8ca7ed4436c8", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ItOrganizations : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<String>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 7 "C:\Users\hp\source\repos\ListOfOrganizations\ListOfOrganizations\Views\Home\ItOrganizations.cshtml"
 foreach (var s in Model)
{
    if (s == "Amazon")
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p><b>");
#nullable restore
#line 11 "C:\Users\hp\source\repos\ListOfOrganizations\ListOfOrganizations\Views\Home\ItOrganizations.cshtml"
         Write(Html.DisplayFor(m => s));

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></p>\r\n");
#nullable restore
#line 12 "C:\Users\hp\source\repos\ListOfOrganizations\ListOfOrganizations\Views\Home\ItOrganizations.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>");
#nullable restore
#line 15 "C:\Users\hp\source\repos\ListOfOrganizations\ListOfOrganizations\Views\Home\ItOrganizations.cshtml"
      Write(Html.DisplayFor(m => s));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 16 "C:\Users\hp\source\repos\ListOfOrganizations\ListOfOrganizations\Views\Home\ItOrganizations.cshtml"
    }
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<String>> Html { get; private set; }
    }
}
#pragma warning restore 1591