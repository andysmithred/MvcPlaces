#pragma checksum "C:\dev\MvcPlaces\MvcPlaces\Views\Continent\DetailsHeader.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6e37ac6bed255bf6e84c79a3398ce37d9bca503d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Continent_DetailsHeader), @"mvc.1.0.view", @"/Views/Continent/DetailsHeader.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Continent/DetailsHeader.cshtml", typeof(AspNetCore.Views_Continent_DetailsHeader))]
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
#line 1 "C:\dev\MvcPlaces\MvcPlaces\Views\_ViewImports.cshtml"
using MvcPlaces;

#line default
#line hidden
#line 2 "C:\dev\MvcPlaces\MvcPlaces\Views\_ViewImports.cshtml"
using MvcPlaces.Models;

#line default
#line hidden
#line 3 "C:\dev\MvcPlaces\MvcPlaces\Views\_ViewImports.cshtml"
using NonFactors.Mvc.Grid;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6e37ac6bed255bf6e84c79a3398ce37d9bca503d", @"/Views/Continent/DetailsHeader.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"90595804cebf81d08ded851669eb832eac5790a3", @"/Views/_ViewImports.cshtml")]
    public class Views_Continent_DetailsHeader : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MvcPlaces.ViewModels.Models.Main.ContinentView>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(55, 241, true);
            WriteLiteral("\r\n<div class=\"alert alert-dark rounded p-2\">\r\n    <div class=\"d-flex\">\r\n        <div class=\"p-2 pl-3\">\r\n            <i class=\'fas fa-globe-africa\' style=\'font-size:36px;\'></i>\r\n        </div>\r\n        <div class=\"p-2 pl-3\">\r\n            <h3>");
            EndContext();
            BeginContext(297, 10, false);
#line 9 "C:\dev\MvcPlaces\MvcPlaces\Views\Continent\DetailsHeader.cshtml"
           Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(307, 41, true);
            WriteLiteral("</h3>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MvcPlaces.ViewModels.Models.Main.ContinentView> Html { get; private set; }
    }
}
#pragma warning restore 1591
