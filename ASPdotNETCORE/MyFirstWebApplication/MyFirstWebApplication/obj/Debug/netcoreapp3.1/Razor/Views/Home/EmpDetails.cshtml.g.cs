#pragma checksum "C:\Users\VikramRaghu\OneDrive - Syncfusion\InsideTeamTraining\Courses\ASPdotNETCORE\MyFirstWebApplication\MyFirstWebApplication\Views\Home\EmpDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "887ac7a35a5001360906e00681a9c045e0d53d35"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_EmpDetails), @"mvc.1.0.view", @"/Views/Home/EmpDetails.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"887ac7a35a5001360906e00681a9c045e0d53d35", @"/Views/Home/EmpDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1e9f2fa69a732abd2957df9b5a31fcfb7ee4a45b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_EmpDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MyFirstWebApplication.ViewModels.HomeEmpDetailsViewModels>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 4 "C:\Users\VikramRaghu\OneDrive - Syncfusion\InsideTeamTraining\Courses\ASPdotNETCORE\MyFirstWebApplication\MyFirstWebApplication\Views\Home\EmpDetails.cshtml"
  
    ViewBag.Title = "Employee Detail";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>");
#nullable restore
#line 8 "C:\Users\VikramRaghu\OneDrive - Syncfusion\InsideTeamTraining\Courses\ASPdotNETCORE\MyFirstWebApplication\MyFirstWebApplication\Views\Home\EmpDetails.cshtml"
Write(ViewBag.PageTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n<div>\r\n    ID : ");
#nullable restore
#line 11 "C:\Users\VikramRaghu\OneDrive - Syncfusion\InsideTeamTraining\Courses\ASPdotNETCORE\MyFirstWebApplication\MyFirstWebApplication\Views\Home\EmpDetails.cshtml"
    Write(Model.Employee.id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n<div>\r\n    Name : ");
#nullable restore
#line 14 "C:\Users\VikramRaghu\OneDrive - Syncfusion\InsideTeamTraining\Courses\ASPdotNETCORE\MyFirstWebApplication\MyFirstWebApplication\Views\Home\EmpDetails.cshtml"
      Write(Model.Employee.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MyFirstWebApplication.ViewModels.HomeEmpDetailsViewModels> Html { get; private set; }
    }
}
#pragma warning restore 1591