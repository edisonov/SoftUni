#pragma checksum "C:\Emo\SoftUni\SoftUni\Entity Framework Core\Auto-Mapping\FastFood.Core\Views\Employees\All.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "80ee89d3d6abdb9076044f4bf62999b569a6c51b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employees_All), @"mvc.1.0.view", @"/Views/Employees/All.cshtml")]
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
#line 1 "C:\Emo\SoftUni\SoftUni\Entity Framework Core\Auto-Mapping\FastFood.Core\Views\_ViewImports.cshtml"
using FastFood.Core;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"80ee89d3d6abdb9076044f4bf62999b569a6c51b", @"/Views/Employees/All.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4ed879bff0478396c899ea94a6589fe8b9c42e19", @"/Views/_ViewImports.cshtml")]
    public class Views_Employees_All : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IList<FastFood.Core.ViewModels.Employees.EmployeesAllViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Emo\SoftUni\SoftUni\Entity Framework Core\Auto-Mapping\FastFood.Core\Views\Employees\All.cshtml"
  
    ViewData["Title"] = "All Employees";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<h1 class=""text-center"">All Employees</h1>
<hr class=""hr-2"" />
<table class=""table mx-auto"">
    <thead>
        <tr class=""row"">
            <th class=""col-md-1"">#</th>
            <th class=""col-md-2"">Name</th>
            <th class=""col-md-2"">Age</th>
            <th class=""col-md-2"">Address</th>
            <th class=""col-md-2"">Position</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 19 "C:\Emo\SoftUni\SoftUni\Entity Framework Core\Auto-Mapping\FastFood.Core\Views\Employees\All.cshtml"
         for(var i = 0; i < Model.Count(); i++)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr class=\"row\">\r\n            <th class=\"col-md-1\">");
#nullable restore
#line 22 "C:\Emo\SoftUni\SoftUni\Entity Framework Core\Auto-Mapping\FastFood.Core\Views\Employees\All.cshtml"
                            Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <td class=\"col-md-2\">");
#nullable restore
#line 23 "C:\Emo\SoftUni\SoftUni\Entity Framework Core\Auto-Mapping\FastFood.Core\Views\Employees\All.cshtml"
                            Write(Model[i].Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td class=\"col-md-2\">");
#nullable restore
#line 24 "C:\Emo\SoftUni\SoftUni\Entity Framework Core\Auto-Mapping\FastFood.Core\Views\Employees\All.cshtml"
                            Write(Model[i].Age);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td class=\"col-md-2\">");
#nullable restore
#line 25 "C:\Emo\SoftUni\SoftUni\Entity Framework Core\Auto-Mapping\FastFood.Core\Views\Employees\All.cshtml"
                            Write(Model[i].Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td class=\"col-md-2\">");
#nullable restore
#line 26 "C:\Emo\SoftUni\SoftUni\Entity Framework Core\Auto-Mapping\FastFood.Core\Views\Employees\All.cshtml"
                            Write(Model[i].Position);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n");
#nullable restore
#line 28 "C:\Emo\SoftUni\SoftUni\Entity Framework Core\Auto-Mapping\FastFood.Core\Views\Employees\All.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IList<FastFood.Core.ViewModels.Employees.EmployeesAllViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
