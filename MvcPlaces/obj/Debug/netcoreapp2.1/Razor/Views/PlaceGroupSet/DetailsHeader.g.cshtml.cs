#pragma checksum "C:\Users\asmith\source\repos\MvcPlaces\MvcPlaces\Views\PlaceGroupSet\DetailsHeader.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dfb636af33a7f9992d02893ef6f8dbc478688990"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_PlaceGroupSet_DetailsHeader), @"mvc.1.0.view", @"/Views/PlaceGroupSet/DetailsHeader.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/PlaceGroupSet/DetailsHeader.cshtml", typeof(AspNetCore.Views_PlaceGroupSet_DetailsHeader))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dfb636af33a7f9992d02893ef6f8dbc478688990", @"/Views/PlaceGroupSet/DetailsHeader.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"90595804cebf81d08ded851669eb832eac5790a3", @"/Views/_ViewImports.cshtml")]
    public class Views_PlaceGroupSet_DetailsHeader : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MvcPlaces.ViewModels.Models.Main.PlaceGroupSetView>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(59, 242, true);
            WriteLiteral("\r\n\r\n<div class=\"card alert alert-dark rounded p-2 w-100\">\r\n    <div class=\"d-flex\">\r\n        <div>\r\n            <i class=\'fas fa-map-marker-alt p-2\' style=\'font-size:40px\'></i>\r\n        </div>\r\n        <div class=\"p-2 pl-3\">\r\n            <h3>");
            EndContext();
            BeginContext(302, 16, false);
#line 10 "C:\Users\asmith\source\repos\MvcPlaces\MvcPlaces\Views\PlaceGroupSet\DetailsHeader.cshtml"
           Write(Model.Place.Name);

#line default
#line hidden
            EndContext();
            BeginContext(318, 79, true);
            WriteLiteral("</h3>\r\n        </div>\r\n        <div class=\"p-2 pl-3 ml-auto\">\r\n            <h3>");
            EndContext();
            BeginContext(398, 16, false);
#line 13 "C:\Users\asmith\source\repos\MvcPlaces\MvcPlaces\Views\PlaceGroupSet\DetailsHeader.cshtml"
           Write(Model.Group.Name);

#line default
#line hidden
            EndContext();
            BeginContext(414, 52, true);
            WriteLiteral("</h3>\r\n        </div>\r\n        <div>\r\n            <i");
            EndContext();
            BeginWriteAttribute("class", " class=\'", 466, "\'", 495, 2);
#line 16 "C:\Users\asmith\source\repos\MvcPlaces\MvcPlaces\Views\PlaceGroupSet\DetailsHeader.cshtml"
WriteAttributeValue("", 474, Model.Group.Icon, 474, 17, false);

#line default
#line hidden
            WriteAttributeValue(" ", 491, "p-2", 492, 4, true);
            EndWriteAttribute();
            BeginContext(496, 64, true);
            WriteLiteral(" style=\'font-size:40px\'></i>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MvcPlaces.ViewModels.Models.Main.PlaceGroupSetView> Html { get; private set; }
    }
}
#pragma warning restore 1591
