#pragma checksum "C:\Users\asmith\source\repos\MvcPlaces\MvcPlaces\Views\Territory\DetailsHeader.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "516633d792f140b26a078814ee0c26e97519ce6e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Territory_DetailsHeader), @"mvc.1.0.view", @"/Views/Territory/DetailsHeader.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Territory/DetailsHeader.cshtml", typeof(AspNetCore.Views_Territory_DetailsHeader))]
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
#line 1 "C:\Users\asmith\source\repos\MvcPlaces\MvcPlaces\Views\_ViewImports.cshtml"
using MvcPlaces;

#line default
#line hidden
#line 2 "C:\Users\asmith\source\repos\MvcPlaces\MvcPlaces\Views\_ViewImports.cshtml"
using MvcPlaces.Models;

#line default
#line hidden
#line 3 "C:\Users\asmith\source\repos\MvcPlaces\MvcPlaces\Views\_ViewImports.cshtml"
using NonFactors.Mvc.Grid;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"516633d792f140b26a078814ee0c26e97519ce6e", @"/Views/Territory/DetailsHeader.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"90595804cebf81d08ded851669eb832eac5790a3", @"/Views/_ViewImports.cshtml")]
    public class Views_Territory_DetailsHeader : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MvcPlaces.ViewModels.Models.Main.TerritoryView>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(55, 135, true);
            WriteLiteral("\r\n<div class=\"alert alert-dark rounded p-2\">\r\n    <div class=\"d-flex\">\r\n        <div>\r\n            <img class=\"card-img-top-50 rounded\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 190, "\"", 212, 1);
#line 6 "C:\Users\asmith\source\repos\MvcPlaces\MvcPlaces\Views\Territory\DetailsHeader.cshtml"
WriteAttributeValue("", 196, Model.FlagImage, 196, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(213, 151, true);
            WriteLiteral(" alt=\"Card image\" style=\"height:50px;object-fit: cover;overflow: hidden;opacity:0.3\">\r\n        </div>\r\n        <div class=\"p-2 pl-3\">\r\n            <h4>");
            EndContext();
            BeginContext(365, 10, false);
#line 9 "C:\Users\asmith\source\repos\MvcPlaces\MvcPlaces\Views\Territory\DetailsHeader.cshtml"
           Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(375, 74, true);
            WriteLiteral("</h4>\r\n        </div>\r\n        <div class=\"ml-auto p-2\">\r\n            <h4>");
            EndContext();
            BeginContext(450, 16, false);
#line 12 "C:\Users\asmith\source\repos\MvcPlaces\MvcPlaces\Views\Territory\DetailsHeader.cshtml"
           Write(Model.NativeName);

#line default
#line hidden
            EndContext();
            BeginContext(466, 41, true);
            WriteLiteral("</h4>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MvcPlaces.ViewModels.Models.Main.TerritoryView> Html { get; private set; }
    }
}
#pragma warning restore 1591
