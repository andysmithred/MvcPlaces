#pragma checksum "C:\dev\MvcPlaces\MvcPlaces\Views\Shared\Partial\Common\BasicListLabel.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ec9f9525107e227c280c4fbabdd2034928d2ef8d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Partial_Common_BasicListLabel), @"mvc.1.0.view", @"/Views/Shared/Partial/Common/BasicListLabel.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Partial/Common/BasicListLabel.cshtml", typeof(AspNetCore.Views_Shared_Partial_Common_BasicListLabel))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ec9f9525107e227c280c4fbabdd2034928d2ef8d", @"/Views/Shared/Partial/Common/BasicListLabel.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"90595804cebf81d08ded851669eb832eac5790a3", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Partial_Common_BasicListLabel : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 107, true);
            WriteLiteral("<div class=\"d-flex\">\r\n    <div class=\"w-100 p-1 pl-2 pb-2 mb-1 alert alert-secondary text-dark border-0\">\r\n");
            EndContext();
#line 3 "C:\dev\MvcPlaces\MvcPlaces\Views\Shared\Partial\Common\BasicListLabel.cshtml"
         if (!String.IsNullOrEmpty(Model.Icon))
        {

#line default
#line hidden
            BeginContext(167, 14, true);
            WriteLiteral("            <i");
            EndContext();
            BeginWriteAttribute("class", " class=\'", 181, "\'", 200, 1);
#line 5 "C:\dev\MvcPlaces\MvcPlaces\Views\Shared\Partial\Common\BasicListLabel.cshtml"
WriteAttributeValue("", 189, Model.Icon, 189, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(201, 30, true);
            WriteLiteral(" style=\'font-size:16px\'></i>\r\n");
            EndContext();
#line 6 "C:\dev\MvcPlaces\MvcPlaces\Views\Shared\Partial\Common\BasicListLabel.cshtml"
        }

#line default
#line hidden
            BeginContext(242, 15, true);
            WriteLiteral("        <label>");
            EndContext();
            BeginContext(258, 11, false);
#line 7 "C:\dev\MvcPlaces\MvcPlaces\Views\Shared\Partial\Common\BasicListLabel.cshtml"
          Write(Model.Value);

#line default
#line hidden
            EndContext();
            BeginContext(269, 28, true);
            WriteLiteral("</label>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
