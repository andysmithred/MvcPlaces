#pragma checksum "C:\Users\asmith\source\repos\MvcPlaces\MvcPlaces\Views\Shared\Partial\Lists\PartialListDetailsContinents.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d15145adf0fbbc1d2a42c699c36f8140a01caafa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Partial_Lists_PartialListDetailsContinents), @"mvc.1.0.view", @"/Views/Shared/Partial/Lists/PartialListDetailsContinents.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Partial/Lists/PartialListDetailsContinents.cshtml", typeof(AspNetCore.Views_Shared_Partial_Lists_PartialListDetailsContinents))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d15145adf0fbbc1d2a42c699c36f8140a01caafa", @"/Views/Shared/Partial/Lists/PartialListDetailsContinents.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"90595804cebf81d08ded851669eb832eac5790a3", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Partial_Lists_PartialListDetailsContinents : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MvcPlaces.ViewModels.Models.Main.ContinentView>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(68, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(72, 761, false);
#line 3 "C:\Users\asmith\source\repos\MvcPlaces\MvcPlaces\Views\Shared\Partial\Lists\PartialListDetailsContinents.cshtml"
Write(Html
    .Grid(Model)
    .Build(columns =>
    {
        columns.Add(model => model.Name).Titled("Name");
        columns.Add(model => model.Code).Titled("Code");
        columns.Add(model => model.ParentId.HasValue ? model.Parent.Name : "--").Titled("Parent");
        columns.Add(model => model.Territories.Count).Titled("Territories");
        columns.Add().Encoded(false).RenderedAs(model =>
            "<div class='btn-group float-right'>" +
                $"<a class='btn btn-secondary btn-sm' href='/Continent/Details/{model.Id}'>Details</a>" +
            "</div>"
        );
    })
    .Empty("No data found")
    .Filterable()
    .Sortable()
    .Pageable()
    .AppendCss("table-dark table-striped table-hover rounded-bottom")
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MvcPlaces.ViewModels.Models.Main.ContinentView>> Html { get; private set; }
    }
}
#pragma warning restore 1591
