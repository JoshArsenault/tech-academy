#pragma checksum "/Users/joshcummings/Documents/Github/TechAcademy/C-Sharp Coding Projects/StudentsMVC/StudentsMVC/Views/Home/Instructors.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9725ac22678f5c5fe6ba8135e329d43db922c37c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Instructors), @"mvc.1.0.view", @"/Views/Home/Instructors.cshtml")]
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
#line 1 "/Users/joshcummings/Documents/Github/TechAcademy/C-Sharp Coding Projects/StudentsMVC/StudentsMVC/Views/_ViewImports.cshtml"
using StudentsMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "/Users/joshcummings/Documents/Github/TechAcademy/C-Sharp Coding Projects/StudentsMVC/StudentsMVC/Views/Home/Instructors.cshtml"
using StudentsMVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9725ac22678f5c5fe6ba8135e329d43db922c37c", @"/Views/Home/Instructors.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"65b8ecdf4050fcb6ca0fd1598ac3e9d038bff81e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Instructors : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Instructor>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 4 "/Users/joshcummings/Documents/Github/TechAcademy/C-Sharp Coding Projects/StudentsMVC/StudentsMVC/Views/Home/Instructors.cshtml"
  
    ViewBag.Title = "Instructors";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h2>Instructors</h2>\n\n");
#nullable restore
#line 10 "/Users/joshcummings/Documents/Github/TechAcademy/C-Sharp Coding Projects/StudentsMVC/StudentsMVC/Views/Home/Instructors.cshtml"
  
    foreach(Instructor instructor in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h4>");
#nullable restore
#line 13 "/Users/joshcummings/Documents/Github/TechAcademy/C-Sharp Coding Projects/StudentsMVC/StudentsMVC/Views/Home/Instructors.cshtml"
       Write(instructor.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\n");
#nullable restore
#line 14 "/Users/joshcummings/Documents/Github/TechAcademy/C-Sharp Coding Projects/StudentsMVC/StudentsMVC/Views/Home/Instructors.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Instructor>> Html { get; private set; }
    }
}
#pragma warning restore 1591
