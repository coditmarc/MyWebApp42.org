#pragma checksum "C:\Temp\src\Views\AzureException\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "69e222cd66ccb899cdccfa60fc90a5fe8ea77945"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AzureException_Index), @"mvc.1.0.view", @"/Views/AzureException/Index.cshtml")]
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
#line 1 "C:\Temp\src\Views\_ViewImports.cshtml"
using myWebApp42;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Temp\src\Views\_ViewImports.cshtml"
using myWebApp42.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"69e222cd66ccb899cdccfa60fc90a5fe8ea77945", @"/Views/AzureException/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ccfe17a7049c194dfd86d46619faa18a7e161a63", @"/Views/_ViewImports.cshtml")]
    public class Views_AzureException_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<myWebApp42.Models.AzureException>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Temp\src\Views\AzureException\Index.cshtml"
  
    ViewBag.Title = "List of AzureExceptions";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h2>List of To-Do Items</h2>\n\n<table class=\"table\">\n    <tr>\n        <th>\n            ");
#nullable restore
#line 13 "C:\Temp\src\Views\AzureException\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.Code));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </th>\n        <th>\n            ");
#nullable restore
#line 16 "C:\Temp\src\Views\AzureException\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.Result));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </th>\n        <th>\n            ");
#nullable restore
#line 19 "C:\Temp\src\Views\AzureException\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.Context));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </th>\n        <th></th>\n    </tr>\n\n");
#nullable restore
#line 24 "C:\Temp\src\Views\AzureException\Index.cshtml"
 foreach (var azureException in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <tr>\n        <td>\n            ");
#nullable restore
#line 27 "C:\Temp\src\Views\AzureException\Index.cshtml"
       Write(Html.DisplayFor(modelItem => azureException.Code));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </td>\n        <td>\n            ");
#nullable restore
#line 30 "C:\Temp\src\Views\AzureException\Index.cshtml"
       Write(Html.DisplayFor(modelItem => azureException.Result));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </td>\n        <td>\n            ");
#nullable restore
#line 33 "C:\Temp\src\Views\AzureException\Index.cshtml"
       Write(Html.DisplayFor(modelItem => azureException.Context));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </td>\n        <td>\n            ");
#nullable restore
#line 36 "C:\Temp\src\Views\AzureException\Index.cshtml"
       Write(Html.ActionLink("Edit", "Edit", new { id=azureException.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\n            ");
#nullable restore
#line 37 "C:\Temp\src\Views\AzureException\Index.cshtml"
       Write(Html.ActionLink("Details", "Details", new { id=azureException.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\n            ");
#nullable restore
#line 38 "C:\Temp\src\Views\AzureException\Index.cshtml"
       Write(Html.ActionLink("Delete", "Delete", new { id=azureException.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </td>\n    </tr>\n");
#nullable restore
#line 41 "C:\Temp\src\Views\AzureException\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\n</table>\n\n<p>\n    ");
#nullable restore
#line 46 "C:\Temp\src\Views\AzureException\Index.cshtml"
Write(Html.ActionLink("Create New", "Create"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n</p>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<myWebApp42.Models.AzureException>> Html { get; private set; }
    }
}
#pragma warning restore 1591
