#pragma checksum "C:\Users\maria\OneDrive\Escritorio\MvcMejorado-master\Views\Merchan\Tienda.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "242a0cda127286773a18f1e5420411bdff254bc9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Merchan_Tienda), @"mvc.1.0.view", @"/Views/Merchan/Tienda.cshtml")]
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
#line 1 "C:\Users\maria\OneDrive\Escritorio\MvcMejorado-master\Views\_ViewImports.cshtml"
using MVCMerchandising;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\maria\OneDrive\Escritorio\MvcMejorado-master\Views\_ViewImports.cshtml"
using MVCMerchandising.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"242a0cda127286773a18f1e5420411bdff254bc9", @"/Views/Merchan/Tienda.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"10c452a2aff352f5ef9c50bfb112f16dd3a2f61f", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Merchan_Tienda : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\maria\OneDrive\Escritorio\MvcMejorado-master\Views\Merchan\Tienda.cshtml"
  

    ViewData["Title"] = "Tienda";


#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n<h2>Welcome</h2>\n\n\n<ul>\n\n");
#nullable restore
#line 13 "C:\Users\maria\OneDrive\Escritorio\MvcMejorado-master\Views\Merchan\Tienda.cshtml"
     for (int i = 0; i < (int)ViewData["NumTimes"]; i++)

    {


#line default
#line hidden
#nullable disable
            WriteLiteral("        <li>");
#nullable restore
#line 17 "C:\Users\maria\OneDrive\Escritorio\MvcMejorado-master\Views\Merchan\Tienda.cshtml"
       Write(ViewData["Message"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n");
#nullable restore
#line 18 "C:\Users\maria\OneDrive\Escritorio\MvcMejorado-master\Views\Merchan\Tienda.cshtml"

    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n</ul>\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
