#pragma checksum "C:\Users\asmith\source\repos\MvcPlaces\MvcPlaces\Views\Shared\Partial\Lists\PartialListMainImportedCountries.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "da9d29cb91922c3394d1dc8cada8eac024a76e8b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Partial_Lists_PartialListMainImportedCountries), @"mvc.1.0.view", @"/Views/Shared/Partial/Lists/PartialListMainImportedCountries.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Partial/Lists/PartialListMainImportedCountries.cshtml", typeof(AspNetCore.Views_Shared_Partial_Lists_PartialListMainImportedCountries))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"da9d29cb91922c3394d1dc8cada8eac024a76e8b", @"/Views/Shared/Partial/Lists/PartialListMainImportedCountries.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"90595804cebf81d08ded851669eb832eac5790a3", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Partial_Lists_PartialListMainImportedCountries : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MvcPlaces.ViewModels.Models.Import.CountryView>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(68, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(72, 721, false);
#line 3 "C:\Users\asmith\source\repos\MvcPlaces\MvcPlaces\Views\Shared\Partial\Lists\PartialListMainImportedCountries.cshtml"
Write(Html
    .Grid(Model)
    .Build(columns =>
    {
        columns.Add(model => model.Name).Titled("Name");
        columns.Add(model => model.Isocode).Titled("ISO");
        columns.Add(model => model.ImportId.HasValue ? model.ImportId.Value.ToString() : "--").Titled("Import Id");
        columns.Add().Encoded(false).RenderedAs(model =>
             "<div class='btn-group float-right'>" +
                $"<a class='btn btn-dark btn-sm rounded-0' style='margin:1px' href='/ImportCountry/Delete/{model.Id}'>Delete</a>" +
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MvcPlaces.ViewModels.Models.Import.CountryView>> Html { get; private set; }
    }
}
#pragma warning restore 1591
