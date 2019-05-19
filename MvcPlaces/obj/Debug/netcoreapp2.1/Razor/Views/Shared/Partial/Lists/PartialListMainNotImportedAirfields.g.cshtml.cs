#pragma checksum "C:\Users\asmith\source\repos\MvcPlaces\MvcPlaces\Views\Shared\Partial\Lists\PartialListMainNotImportedAirfields.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fd7a36bf2a07372c9f250905d7aefaf2d9ddecbd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Partial_Lists_PartialListMainNotImportedAirfields), @"mvc.1.0.view", @"/Views/Shared/Partial/Lists/PartialListMainNotImportedAirfields.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Partial/Lists/PartialListMainNotImportedAirfields.cshtml", typeof(AspNetCore.Views_Shared_Partial_Lists_PartialListMainNotImportedAirfields))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fd7a36bf2a07372c9f250905d7aefaf2d9ddecbd", @"/Views/Shared/Partial/Lists/PartialListMainNotImportedAirfields.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"90595804cebf81d08ded851669eb832eac5790a3", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Partial_Lists_PartialListMainNotImportedAirfields : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MvcPlaces.ViewModels.Models.Import.AirfieldView>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(69, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(73, 962, false);
#line 3 "C:\Users\asmith\source\repos\MvcPlaces\MvcPlaces\Views\Shared\Partial\Lists\PartialListMainNotImportedAirfields.cshtml"
Write(Html
    .Grid(Model)
    .Build(columns =>
    {
        columns.Add(model => model.Name).Titled("Name");
        columns.Add(model => model.Region.Name).Titled("Region");
        columns.Add(model => model.Latitude).Titled("Latitude");
        columns.Add(model => model.Longitude).Titled("Longitude");
        columns.Add(model => model.ImportId.HasValue ? model.ImportId.Value.ToString() : "--").Titled("Import Id");
        columns.Add().Encoded(false).RenderedAs(model =>
            "<div class='btn-group float-right'>" +
                $"<a class='btn btn-dark btn-sm rounded-0' href='/ImportAirfield/Import/{model.Id}'>Import</a>" +
                $"<a class='btn btn-dark btn-sm rounded-0' href='/ImportAirfield/QuickImport/{model.Id}'>Quick</a>" +
            "</div>"
        );
    })
    .Empty("No data found")
    .Filterable()
    .Sortable()
    .Pageable()
    .AppendCss("table-light table-striped table-hover small")
);

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MvcPlaces.ViewModels.Models.Import.AirfieldView>> Html { get; private set; }
    }
}
#pragma warning restore 1591
