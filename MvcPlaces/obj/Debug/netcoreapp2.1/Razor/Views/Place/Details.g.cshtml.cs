#pragma checksum "C:\Users\asmith\source\repos\MvcPlaces\MvcPlaces\Views\Place\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1e1e958b5788829f9a020cd8235872f5b143ddcf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Place_Details), @"mvc.1.0.view", @"/Views/Place/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Place/Details.cshtml", typeof(AspNetCore.Views_Place_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1e1e958b5788829f9a020cd8235872f5b143ddcf", @"/Views/Place/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"90595804cebf81d08ded851669eb832eac5790a3", @"/Views/_ViewImports.cshtml")]
    public class Views_Place_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MvcPlaces.ViewModels.Models.Main.PlaceView>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "DetailsMenu", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "DetailsHeader", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "TerritoriesList", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Territory", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "PartialMap", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(51, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\asmith\source\repos\MvcPlaces\MvcPlaces\Views\Place\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(96, 10, true);
            WriteLiteral("\r\n<br />\r\n");
            EndContext();
            BeginContext(106, 30, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c859e16783e04d3e829bf5e886333a40", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(136, 10, true);
            WriteLiteral("\r\n<br />\r\n");
            EndContext();
            BeginContext(146, 32, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "aca63a21942642acb8b11ab34c931721", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(178, 29, true);
            WriteLiteral("\r\n\r\n<div class=\"card-deck\">\r\n");
            EndContext();
#line 13 "C:\Users\asmith\source\repos\MvcPlaces\MvcPlaces\Views\Place\Details.cshtml"
     if (Model.Territories.Count > 0)
    {

#line default
#line hidden
            BeginContext(253, 384, true);
            WriteLiteral(@"        <div class=""card border-0"" style=""height:70px"">
            <div class=""card-body bg-warning text-black-50 rounded"">
                <div class=""d-flex"">
                    <div><i class=""fas fa-map-marked"" style=""font-size:30px""></i></div>
                    <div class=""pl-3""><b>Regions</b></div>
                    <div class=""ml-auto"">
                        <b>");
            EndContext();
            BeginContext(638, 23, false);
#line 21 "C:\Users\asmith\source\repos\MvcPlaces\MvcPlaces\Views\Place\Details.cshtml"
                      Write(Model.Territories.Count);

#line default
#line hidden
            EndContext();
            BeginContext(661, 30, true);
            WriteLiteral("</b>\r\n                        ");
            EndContext();
            BeginContext(691, 109, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "724ccf9097994003bcb64bddc91a633e", async() => {
                BeginContext(748, 48, true);
                WriteLiteral("<i class=\'fas fa-angle-right text-black-50\'></i>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 22 "C:\Users\asmith\source\repos\MvcPlaces\MvcPlaces\Views\Place\Details.cshtml"
                                                          WriteLiteral(Model.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(800, 90, true);
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
            EndContext();
#line 27 "C:\Users\asmith\source\repos\MvcPlaces\MvcPlaces\Views\Place\Details.cshtml"
    }

#line default
#line hidden
            BeginContext(897, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 29 "C:\Users\asmith\source\repos\MvcPlaces\MvcPlaces\Views\Place\Details.cshtml"
     foreach (var item in Model.Territories.OrderBy(x => x.Name))
    {

#line default
#line hidden
            BeginContext(973, 236, true);
            WriteLiteral("        <div class=\"card border-0\" style=\"height:70px\">\r\n            <div class=\"card-body bg-success text-black-50 rounded\">\r\n                <div class=\"d-flex\">\r\n                    <div>\r\n                        <img class=\"rounded\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1209, "\"", 1230, 1);
#line 35 "C:\Users\asmith\source\repos\MvcPlaces\MvcPlaces\Views\Place\Details.cshtml"
WriteAttributeValue("", 1215, item.FlagImage, 1215, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1231, 115, true);
            WriteLiteral(" alt=\"Card image\" style=\"height:25px;object-fit: cover;overflow: hidden;opacity:0.3\">\r\n                    </div>\r\n");
            EndContext();
#line 37 "C:\Users\asmith\source\repos\MvcPlaces\MvcPlaces\Views\Place\Details.cshtml"
                     if (item.Name.Length > 20)
                    {

#line default
#line hidden
            BeginContext(1418, 52, true);
            WriteLiteral("                        <div class=\"pl-3\"><small><b>");
            EndContext();
            BeginContext(1471, 9, false);
#line 39 "C:\Users\asmith\source\repos\MvcPlaces\MvcPlaces\Views\Place\Details.cshtml"
                                               Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1480, 20, true);
            WriteLiteral("</b></small></div>\r\n");
            EndContext();
#line 40 "C:\Users\asmith\source\repos\MvcPlaces\MvcPlaces\Views\Place\Details.cshtml"
                    }
                    else
                    {

#line default
#line hidden
            BeginContext(1572, 45, true);
            WriteLiteral("                        <div class=\"pl-3\"><b>");
            EndContext();
            BeginContext(1618, 9, false);
#line 43 "C:\Users\asmith\source\repos\MvcPlaces\MvcPlaces\Views\Place\Details.cshtml"
                                        Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1627, 12, true);
            WriteLiteral("</b></div>\r\n");
            EndContext();
#line 44 "C:\Users\asmith\source\repos\MvcPlaces\MvcPlaces\Views\Place\Details.cshtml"
                    }

#line default
#line hidden
            BeginContext(1662, 67, true);
            WriteLiteral("                    <div class=\"ml-auto\">\r\n                        ");
            EndContext();
            BeginContext(1729, 127, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d86b7c897431443fafd72a7d12618144", async() => {
                BeginContext(1804, 48, true);
                WriteLiteral("<i class=\'fas fa-angle-right text-black-50\'></i>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 46 "C:\Users\asmith\source\repos\MvcPlaces\MvcPlaces\Views\Place\Details.cshtml"
                                                                             WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1856, 90, true);
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
            EndContext();
#line 51 "C:\Users\asmith\source\repos\MvcPlaces\MvcPlaces\Views\Place\Details.cshtml"
    }

#line default
#line hidden
            BeginContext(1953, 348, true);
            WriteLiteral(@"</div>
<br />
<div class=""card-deck"">
    <div class=""card border-0"">
        <div class=""card-header bg-dark text-white shadow"">Main</div>
        <div class=""card-body bg-light"" style=""height:300px;max-height:300px;overflow-y:auto;"">
            <div class=""d-flex"">
                <div class=""w-25 p-1 pl-3 mb-1 bg-secondary text-white"">");
            EndContext();
            BeginContext(2301, 28, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "71c3ad49561742fda1d7e81ecd94bf04", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#line 59 "C:\Users\asmith\source\repos\MvcPlaces\MvcPlaces\Views\Place\Details.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Id);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2329, 65, true);
            WriteLiteral("</div>\r\n                <div class=\"w-75 p-1 pl-3 mb-1 bg-white\">");
            EndContext();
            BeginContext(2395, 8, false);
#line 60 "C:\Users\asmith\source\repos\MvcPlaces\MvcPlaces\Views\Place\Details.cshtml"
                                                    Write(Model.Id);

#line default
#line hidden
            EndContext();
            BeginContext(2403, 134, true);
            WriteLiteral("</div>\r\n            </div>\r\n            <div class=\"d-flex\">\r\n                <div class=\"w-25 p-1 pl-3 mb-1 bg-secondary text-white\">");
            EndContext();
            BeginContext(2537, 35, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "51634dcd3a3f48aa81ff6859793905e0", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#line 63 "C:\Users\asmith\source\repos\MvcPlaces\MvcPlaces\Views\Place\Details.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.LocalName);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2572, 67, true);
            WriteLiteral("</div>\r\n                <div class=\"w-75 p-1 pl-3 mb-1 bg-white\">\r\n");
            EndContext();
#line 65 "C:\Users\asmith\source\repos\MvcPlaces\MvcPlaces\Views\Place\Details.cshtml"
                     if (String.IsNullOrEmpty(Model.LocalName))
                    {

#line default
#line hidden
            BeginContext(2727, 41, true);
            WriteLiteral("                        <span>--</span>\r\n");
            EndContext();
#line 68 "C:\Users\asmith\source\repos\MvcPlaces\MvcPlaces\Views\Place\Details.cshtml"
                    }
                    else
                    {

#line default
#line hidden
            BeginContext(2840, 31, true);
            WriteLiteral("                        <small>");
            EndContext();
            BeginContext(2872, 15, false);
#line 71 "C:\Users\asmith\source\repos\MvcPlaces\MvcPlaces\Views\Place\Details.cshtml"
                          Write(Model.LocalName);

#line default
#line hidden
            EndContext();
            BeginContext(2887, 10, true);
            WriteLiteral("</small>\r\n");
            EndContext();
#line 72 "C:\Users\asmith\source\repos\MvcPlaces\MvcPlaces\Views\Place\Details.cshtml"
                    }

#line default
#line hidden
            BeginContext(2920, 150, true);
            WriteLiteral("                </div>\r\n            </div>\r\n            <div class=\"d-flex\">\r\n                <div class=\"w-25 p-1 pl-3 mb-1 bg-secondary text-white\">");
            EndContext();
            BeginContext(3070, 34, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1d07ea9952484e62a1ed7a6c581a37bc", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#line 76 "C:\Users\asmith\source\repos\MvcPlaces\MvcPlaces\Views\Place\Details.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Latitude);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3104, 65, true);
            WriteLiteral("</div>\r\n                <div class=\"w-75 p-1 pl-3 mb-1 bg-white\">");
            EndContext();
            BeginContext(3170, 21, false);
#line 77 "C:\Users\asmith\source\repos\MvcPlaces\MvcPlaces\Views\Place\Details.cshtml"
                                                    Write(Model.LatitudeDegrees);

#line default
#line hidden
            EndContext();
            BeginContext(3191, 134, true);
            WriteLiteral("</div>\r\n            </div>\r\n            <div class=\"d-flex\">\r\n                <div class=\"w-25 p-1 pl-3 mb-1 bg-secondary text-white\">");
            EndContext();
            BeginContext(3325, 35, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5064fcbac7f647b6b0fe54081c71d91c", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#line 80 "C:\Users\asmith\source\repos\MvcPlaces\MvcPlaces\Views\Place\Details.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Longitude);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3360, 65, true);
            WriteLiteral("</div>\r\n                <div class=\"w-75 p-1 pl-3 mb-1 bg-white\">");
            EndContext();
            BeginContext(3426, 22, false);
#line 81 "C:\Users\asmith\source\repos\MvcPlaces\MvcPlaces\Views\Place\Details.cshtml"
                                                    Write(Model.LongitudeDegrees);

#line default
#line hidden
            EndContext();
            BeginContext(3448, 134, true);
            WriteLiteral("</div>\r\n            </div>\r\n            <div class=\"d-flex\">\r\n                <div class=\"w-25 p-1 pl-3 mb-1 bg-secondary text-white\">");
            EndContext();
            BeginContext(3582, 30, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "29fb4449982949c98b75fda9a9183af0", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#line 84 "C:\Users\asmith\source\repos\MvcPlaces\MvcPlaces\Views\Place\Details.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Zoom);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3612, 65, true);
            WriteLiteral("</div>\r\n                <div class=\"w-75 p-1 pl-3 mb-1 bg-white\">");
            EndContext();
            BeginContext(3678, 16, false);
#line 85 "C:\Users\asmith\source\repos\MvcPlaces\MvcPlaces\Views\Place\Details.cshtml"
                                                    Write(Model.ZoomString);

#line default
#line hidden
            EndContext();
            BeginContext(3694, 265, true);
            WriteLiteral(@"</div>
            </div>
        </div>
    </div>
    <div class=""card border-0"">
        <div class=""card-header bg-dark text-white"">Map</div>
        <div class=""card-body bg-light p-0"" style=""height:300px;max-height:300px;overflow-y:auto;"">
            ");
            EndContext();
            BeginContext(3959, 153, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ed24dff9a7594b55a237a094cd175b37", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
#line 92 "C:\Users\asmith\source\repos\MvcPlaces\MvcPlaces\Views\Place\Details.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = new { Name = Model.Name, Latitude = Model.LatitudeValue, Longitude = Model.LongitudeValue, Zoom = Model.ZoomValue };

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4112, 36, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MvcPlaces.ViewModels.Models.Main.PlaceView> Html { get; private set; }
    }
}
#pragma warning restore 1591
