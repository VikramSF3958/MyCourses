#pragma checksum "C:\Users\VikramRaghu\OneDrive - Syncfusion\InsideTeamTraining\Courses\ASPdotNETCORE\MyFirstWebApplication\MyFirstWebApplication\Views\Home\ShowAllEmp.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eaa4965be2041a2b1163bdb8efc535ddaa4d2e49"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ShowAllEmp), @"mvc.1.0.view", @"/Views/Home/ShowAllEmp.cshtml")]
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
#line 1 "C:\Users\VikramRaghu\OneDrive - Syncfusion\InsideTeamTraining\Courses\ASPdotNETCORE\MyFirstWebApplication\MyFirstWebApplication\Views\_ViewImports.cshtml"
using MyFirstWebApplication.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\VikramRaghu\OneDrive - Syncfusion\InsideTeamTraining\Courses\ASPdotNETCORE\MyFirstWebApplication\MyFirstWebApplication\Views\_ViewImports.cshtml"
using MyFirstWebApplication.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eaa4965be2041a2b1163bdb8efc535ddaa4d2e49", @"/Views/Home/ShowAllEmp.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1e9f2fa69a732abd2957df9b5a31fcfb7ee4a45b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ShowAllEmp : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MyFirstWebApplication.Models.Employee>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\VikramRaghu\OneDrive - Syncfusion\InsideTeamTraining\Courses\ASPdotNETCORE\MyFirstWebApplication\MyFirstWebApplication\Views\Home\ShowAllEmp.cshtml"
  
    ViewBag.Title = "Showing All Employees";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<table>\r\n    <tr>\r\n        <th>ID</th>\r\n        <th>Name</th>\r\n    </tr>\r\n");
#nullable restore
#line 12 "C:\Users\VikramRaghu\OneDrive - Syncfusion\InsideTeamTraining\Courses\ASPdotNETCORE\MyFirstWebApplication\MyFirstWebApplication\Views\Home\ShowAllEmp.cshtml"
     foreach (var employee in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 15 "C:\Users\VikramRaghu\OneDrive - Syncfusion\InsideTeamTraining\Courses\ASPdotNETCORE\MyFirstWebApplication\MyFirstWebApplication\Views\Home\ShowAllEmp.cshtml"
           Write(employee.id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 16 "C:\Users\VikramRaghu\OneDrive - Syncfusion\InsideTeamTraining\Courses\ASPdotNETCORE\MyFirstWebApplication\MyFirstWebApplication\Views\Home\ShowAllEmp.cshtml"
           Write(employee.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n");
#nullable restore
#line 18 "C:\Users\VikramRaghu\OneDrive - Syncfusion\InsideTeamTraining\Courses\ASPdotNETCORE\MyFirstWebApplication\MyFirstWebApplication\Views\Home\ShowAllEmp.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MyFirstWebApplication.Models.Employee>> Html { get; private set; }
    }
}
#pragma warning restore 1591
