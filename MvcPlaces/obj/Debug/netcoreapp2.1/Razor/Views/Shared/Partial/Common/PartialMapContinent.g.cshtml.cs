#pragma checksum "C:\dev\MvcPlaces\MvcPlaces\Views\Shared\Partial\Common\PartialMapContinent.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ed6aa8a330bf1190c9d58d550cd34f2bbcd57b10"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Partial_Common_PartialMapContinent), @"mvc.1.0.view", @"/Views/Shared/Partial/Common/PartialMapContinent.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Partial/Common/PartialMapContinent.cshtml", typeof(AspNetCore.Views_Shared_Partial_Common_PartialMapContinent))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ed6aa8a330bf1190c9d58d550cd34f2bbcd57b10", @"/Views/Shared/Partial/Common/PartialMapContinent.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"90595804cebf81d08ded851669eb832eac5790a3", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Partial_Common_PartialMapContinent : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MvcPlaces.ViewModels.Models.Main.ContinentView>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(55, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\dev\MvcPlaces\MvcPlaces\Views\Shared\Partial\Common\PartialMapContinent.cshtml"
  
    var countries = Model.CountryIsoCodesForGeochart;

#line default
#line hidden
            BeginContext(119, 317, true);
            WriteLiteral(@"
<script type=""text/javascript"" src=""https://www.google.com/jsapi""></script>
<script type=""text/javascript"">
    google.load(""visualization"", ""1"", {packages:[""geochart""]});
    google.setOnLoadCallback(drawRegionsMap);

    function drawRegionsMap() {
        var data = google.visualization.arrayToDataTable([");
            EndContext();
            BeginContext(437, 19, false);
#line 13 "C:\dev\MvcPlaces\MvcPlaces\Views\Shared\Partial\Common\PartialMapContinent.cshtml"
                                                     Write(Html.Raw(countries));

#line default
#line hidden
            EndContext();
            BeginContext(456, 53, true);
            WriteLiteral("]);\r\n\r\n        var options = {\r\n            region: \'");
            EndContext();
            BeginContext(510, 10, false);
#line 16 "C:\dev\MvcPlaces\MvcPlaces\Views\Shared\Partial\Common\PartialMapContinent.cshtml"
                Write(Model.Code);

#line default
#line hidden
            EndContext();
            BeginContext(520, 331, true);
            WriteLiteral(@"',
            resolution: 'countries',
            keepAspectRatio: false,
            backgroundColor: { stroke: 'white', fill: 'gainsboro' },
            datalessRegionColor: 'darkgray',
            defaultColor: 'darkslategray'
        };

        var chart = new google.visualization.GeoChart(document.getElementById('");
            EndContext();
            BeginContext(852, 10, false);
#line 24 "C:\dev\MvcPlaces\MvcPlaces\Views\Shared\Partial\Common\PartialMapContinent.cshtml"
                                                                          Write(Model.Code);

#line default
#line hidden
            EndContext();
            BeginContext(862, 66, true);
            WriteLiteral("\'));\r\n\r\n        chart.draw(data, options);\r\n    }\r\n\r\n</script>\r\n\r\n");
            EndContext();
            BeginContext(1117, 4, true);
            WriteLiteral("<div");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 1121, "\"", 1137, 1);
#line 33 "C:\dev\MvcPlaces\MvcPlaces\Views\Shared\Partial\Common\PartialMapContinent.cshtml"
WriteAttributeValue("", 1126, Model.Code, 1126, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1138, 30, true);
            WriteLiteral(" class=\"rounded-bottom\"></div>");
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
