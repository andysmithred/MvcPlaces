#pragma checksum "C:\Users\asmith\source\repos\MvcPlaces\MvcPlaces\Views\Shared\Partial\Common\PartialMapTerritoryCountry.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d4075c07386fceb43ba1cc8201cd66de73eae437"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Partial_Common_PartialMapTerritoryCountry), @"mvc.1.0.view", @"/Views/Shared/Partial/Common/PartialMapTerritoryCountry.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Partial/Common/PartialMapTerritoryCountry.cshtml", typeof(AspNetCore.Views_Shared_Partial_Common_PartialMapTerritoryCountry))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d4075c07386fceb43ba1cc8201cd66de73eae437", @"/Views/Shared/Partial/Common/PartialMapTerritoryCountry.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"90595804cebf81d08ded851669eb832eac5790a3", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Partial_Common_PartialMapTerritoryCountry : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MvcPlaces.ViewModels.Models.Main.TerritoryView>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(55, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\asmith\source\repos\MvcPlaces\MvcPlaces\Views\Shared\Partial\Common\PartialMapTerritoryCountry.cshtml"
  
    ViewBag.Title = Model.Name;

#line default
#line hidden
            BeginContext(97, 351, true);
            WriteLiteral(@"
<script type=""text/javascript"" src=""https://www.google.com/jsapi""></script>
<script type=""text/javascript"">
    google.load(""visualization"", ""1"", {packages:[""geochart""]});
    google.setOnLoadCallback(drawRegionsMap);

    function drawRegionsMap() {
        var data = google.visualization.arrayToDataTable([
        ['Country'],
        ['");
            EndContext();
            BeginContext(449, 10, false);
#line 15 "C:\Users\asmith\source\repos\MvcPlaces\MvcPlaces\Views\Shared\Partial\Common\PartialMapTerritoryCountry.cshtml"
     Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(459, 62, true);
            WriteLiteral("\'],\r\n    ]);\r\n\r\n        var options = {\r\n            region: \'");
            EndContext();
            BeginContext(522, 13, false);
#line 19 "C:\Users\asmith\source\repos\MvcPlaces\MvcPlaces\Views\Shared\Partial\Common\PartialMapTerritoryCountry.cshtml"
                Write(Model.Isocode);

#line default
#line hidden
            EndContext();
            BeginContext(535, 29, true);
            WriteLiteral("\',\r\n            resolution: \'");
            EndContext();
            BeginContext(565, 19, false);
#line 20 "C:\Users\asmith\source\repos\MvcPlaces\MvcPlaces\Views\Shared\Partial\Common\PartialMapTerritoryCountry.cshtml"
                    Write(Model.GeoChartLevel);

#line default
#line hidden
            EndContext();
            BeginContext(584, 224, true);
            WriteLiteral("\',\r\n            keepAspectRatio: false,\r\n            backgroundColor: \'lightblue\',\r\n            datalessRegionColor: \'lightgreen\'\r\n        };\r\n\r\n        var chart = new google.visualization.GeoChart(document.getElementById(\'");
            EndContext();
            BeginContext(809, 13, false);
#line 26 "C:\Users\asmith\source\repos\MvcPlaces\MvcPlaces\Views\Shared\Partial\Common\PartialMapTerritoryCountry.cshtml"
                                                                          Write(Model.Isocode);

#line default
#line hidden
            EndContext();
            BeginContext(822, 68, true);
            WriteLiteral("\'));\r\n\r\n        chart.draw(data, options);\r\n    }\r\n</script>\r\n\r\n<div");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 890, "\"", 909, 1);
#line 32 "C:\Users\asmith\source\repos\MvcPlaces\MvcPlaces\Views\Shared\Partial\Common\PartialMapTerritoryCountry.cshtml"
WriteAttributeValue("", 895, Model.Isocode, 895, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(910, 28, true);
            WriteLiteral(" style=\"width: 100%;\"></div>");
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
