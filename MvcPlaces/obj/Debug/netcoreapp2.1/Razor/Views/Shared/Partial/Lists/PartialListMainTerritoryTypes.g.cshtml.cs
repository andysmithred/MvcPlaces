#pragma checksum "C:\Users\asmith\source\repos\MvcPlaces\MvcPlaces\Views\Shared\Partial\Lists\PartialListMainTerritoryTypes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4c4059a1cacbe3dca0eb88312860e95dbfebee9b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Partial_Lists_PartialListMainTerritoryTypes), @"mvc.1.0.view", @"/Views/Shared/Partial/Lists/PartialListMainTerritoryTypes.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Partial/Lists/PartialListMainTerritoryTypes.cshtml", typeof(AspNetCore.Views_Shared_Partial_Lists_PartialListMainTerritoryTypes))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4c4059a1cacbe3dca0eb88312860e95dbfebee9b", @"/Views/Shared/Partial/Lists/PartialListMainTerritoryTypes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"90595804cebf81d08ded851669eb832eac5790a3", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Partial_Lists_PartialListMainTerritoryTypes : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MvcPlaces.ViewModels.Models.Main.TerritoryTypeView>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(72, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(76, 825, false);
#line 3 "C:\Users\asmith\source\repos\MvcPlaces\MvcPlaces\Views\Shared\Partial\Lists\PartialListMainTerritoryTypes.cshtml"
Write(Html
    .Grid(Model)
    .Build(columns =>
    {
        columns.Add(model => model.Type).Titled("Type");
        columns.Add(model => model.TerritoryCount).Titled("Territories");
        columns.Add().Encoded(false).RenderedAs(model =>
            "<div class='btn-group float-right'>" +
                $"<a class='btn btn-dark btn-sm rounded-0' href='/TerritoryType/Edit/{model.Id}'>Edit</a>" +
                $"<a class='btn btn-dark btn-sm rounded-0' href='/TerritoryType/Details/{model.Id}'>Details</a>" +
                $"<a class='btn btn-dark btn-sm rounded-0' href='/TerritoryType/Delete/{model.Id}'>Delete</a>" +
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MvcPlaces.ViewModels.Models.Main.TerritoryTypeView>> Html { get; private set; }
    }
}
#pragma warning restore 1591
