#pragma checksum "C:\Users\asmith\source\repos\MvcPlaces\MvcPlaces\Views\TerritoryPlace\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "99c982e305a4dad094aa8547b1560f96ac7f5d4d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TerritoryPlace_Details), @"mvc.1.0.view", @"/Views/TerritoryPlace/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/TerritoryPlace/Details.cshtml", typeof(AspNetCore.Views_TerritoryPlace_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"99c982e305a4dad094aa8547b1560f96ac7f5d4d", @"/Views/TerritoryPlace/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"90595804cebf81d08ded851669eb832eac5790a3", @"/Views/_ViewImports.cshtml")]
    public class Views_TerritoryPlace_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MvcPlaces.ViewModels.Models.Main.TerritoryPlaceView>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "DetailsMenu", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "DetailsHeader", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Place", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Territory", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(60, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\asmith\source\repos\MvcPlaces\MvcPlaces\Views\TerritoryPlace\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(105, 10, true);
            WriteLiteral("\r\n<br />\r\n");
            EndContext();
            BeginContext(115, 30, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4849d6133dd6469e8ecd30a6838972d3", async() => {
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
            BeginContext(145, 10, true);
            WriteLiteral("\r\n<br />\r\n");
            EndContext();
            BeginContext(155, 32, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "847d9439b16b4d718e6445b074456659", async() => {
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
            BeginContext(187, 352, true);
            WriteLiteral(@"

<div class=""card-deck"">
    <div class=""card rounded-0"">
        <div class=""card-header bg-dark text-white rounded-0"">Place</div>
        <div class=""card-body bg-light"" style=""height:250px;max-height:250px;overflow-y:auto;"">
            <div class=""d-flex"">
                <div class=""w-25 p-1 pr-4 mb-1 bg-secondary text-white text-right"">");
            EndContext();
            BeginContext(539, 33, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9c6f15beb8c949e6bc2a403a76a04664", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#line 17 "C:\Users\asmith\source\repos\MvcPlaces\MvcPlaces\Views\TerritoryPlace\Details.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.PlaceId);

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
            BeginContext(572, 65, true);
            WriteLiteral("</div>\r\n                <div class=\"w-75 p-1 pl-4 mb-1 bg-white\">");
            EndContext();
            BeginContext(638, 13, false);
#line 18 "C:\Users\asmith\source\repos\MvcPlaces\MvcPlaces\Views\TerritoryPlace\Details.cshtml"
                                                    Write(Model.PlaceId);

#line default
#line hidden
            EndContext();
            BeginContext(651, 145, true);
            WriteLiteral("</div>\r\n            </div>\r\n            <div class=\"d-flex\">\r\n                <div class=\"w-25 p-1 pr-4 mb-1 bg-secondary text-white text-right\">");
            EndContext();
            BeginContext(796, 36, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "93564f81caaa448bb8e9b35343fd6a21", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#line 21 "C:\Users\asmith\source\repos\MvcPlaces\MvcPlaces\Views\TerritoryPlace\Details.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Place.Name);

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
            BeginContext(832, 65, true);
            WriteLiteral("</div>\r\n                <div class=\"w-75 p-1 pl-4 mb-1 bg-white\">");
            EndContext();
            BeginContext(897, 98, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "145437077f7c43d79aeefd9d669da670", async() => {
                BeginContext(975, 16, false);
#line 22 "C:\Users\asmith\source\repos\MvcPlaces\MvcPlaces\Views\TerritoryPlace\Details.cshtml"
                                                                                                                                 Write(Model.Place.Name);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 22 "C:\Users\asmith\source\repos\MvcPlaces\MvcPlaces\Views\TerritoryPlace\Details.cshtml"
                                                                                                          WriteLiteral(Model.PlaceId);

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
            BeginContext(995, 145, true);
            WriteLiteral("</div>\r\n            </div>\r\n            <div class=\"d-flex\">\r\n                <div class=\"w-25 p-1 pr-4 mb-1 bg-secondary text-white text-right\">");
            EndContext();
            BeginContext(1140, 41, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6b85a14c3bc34f4caf0a84e4ecf0d8de", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#line 25 "C:\Users\asmith\source\repos\MvcPlaces\MvcPlaces\Views\TerritoryPlace\Details.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Place.LocalName);

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
            BeginContext(1181, 72, true);
            WriteLiteral("</div>\r\n                <div class=\"w-75 p-1 pl-4 mb-1 bg-white\"><small>");
            EndContext();
            BeginContext(1254, 21, false);
#line 26 "C:\Users\asmith\source\repos\MvcPlaces\MvcPlaces\Views\TerritoryPlace\Details.cshtml"
                                                           Write(Model.Place.LocalName);

#line default
#line hidden
            EndContext();
            BeginContext(1275, 153, true);
            WriteLiteral("</small></div>\r\n            </div>\r\n            <div class=\"d-flex\">\r\n                <div class=\"w-25 p-1 pr-4 mb-1 bg-secondary text-white text-right\">");
            EndContext();
            BeginContext(1428, 40, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4dda3c11e594467fa1a65d34cdd6ceea", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#line 29 "C:\Users\asmith\source\repos\MvcPlaces\MvcPlaces\Views\TerritoryPlace\Details.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Place.Latitude);

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
            BeginContext(1468, 65, true);
            WriteLiteral("</div>\r\n                <div class=\"w-75 p-1 pl-4 mb-1 bg-white\">");
            EndContext();
            BeginContext(1534, 27, false);
#line 30 "C:\Users\asmith\source\repos\MvcPlaces\MvcPlaces\Views\TerritoryPlace\Details.cshtml"
                                                    Write(Model.Place.LatitudeDegrees);

#line default
#line hidden
            EndContext();
            BeginContext(1561, 145, true);
            WriteLiteral("</div>\r\n            </div>\r\n            <div class=\"d-flex\">\r\n                <div class=\"w-25 p-1 pr-4 mb-1 bg-secondary text-white text-right\">");
            EndContext();
            BeginContext(1706, 41, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d466389e71d743bfa8f4521f0b38d551", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#line 33 "C:\Users\asmith\source\repos\MvcPlaces\MvcPlaces\Views\TerritoryPlace\Details.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Place.Longitude);

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
            BeginContext(1747, 65, true);
            WriteLiteral("</div>\r\n                <div class=\"w-75 p-1 pl-4 mb-1 bg-white\">");
            EndContext();
            BeginContext(1813, 28, false);
#line 34 "C:\Users\asmith\source\repos\MvcPlaces\MvcPlaces\Views\TerritoryPlace\Details.cshtml"
                                                    Write(Model.Place.LongitudeDegrees);

#line default
#line hidden
            EndContext();
            BeginContext(1841, 383, true);
            WriteLiteral(@"</div>
            </div>
        </div>
    </div>
    <div class=""card rounded-0"">
        <div class=""card-header bg-dark text-white rounded-0"">Territory</div>
        <div class=""card-body bg-light"" style=""height:250px;max-height:250px;overflow-y:auto;"">
            <div class=""d-flex"">
                <div class=""w-25 p-1 pr-4 mb-1 bg-secondary text-white text-right"">");
            EndContext();
            BeginContext(2224, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1b736c1419284ab4a8db6b1b6de2242f", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#line 42 "C:\Users\asmith\source\repos\MvcPlaces\MvcPlaces\Views\TerritoryPlace\Details.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.TerritoryId);

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
            BeginContext(2261, 65, true);
            WriteLiteral("</div>\r\n                <div class=\"w-75 p-1 pl-4 mb-1 bg-white\">");
            EndContext();
            BeginContext(2327, 17, false);
#line 43 "C:\Users\asmith\source\repos\MvcPlaces\MvcPlaces\Views\TerritoryPlace\Details.cshtml"
                                                    Write(Model.TerritoryId);

#line default
#line hidden
            EndContext();
            BeginContext(2344, 145, true);
            WriteLiteral("</div>\r\n            </div>\r\n            <div class=\"d-flex\">\r\n                <div class=\"w-25 p-1 pr-4 mb-1 bg-secondary text-white text-right\">");
            EndContext();
            BeginContext(2489, 40, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "24c0f5d7dd1e4fdd84c93b88ae774e0d", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#line 46 "C:\Users\asmith\source\repos\MvcPlaces\MvcPlaces\Views\TerritoryPlace\Details.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Territory.Name);

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
            BeginContext(2529, 65, true);
            WriteLiteral("</div>\r\n                <div class=\"w-75 p-1 pl-4 mb-1 bg-white\">");
            EndContext();
            BeginContext(2594, 110, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "27046f8728c9431fb81bb30fd543f537", async() => {
                BeginContext(2680, 20, false);
#line 47 "C:\Users\asmith\source\repos\MvcPlaces\MvcPlaces\Views\TerritoryPlace\Details.cshtml"
                                                                                                                                         Write(Model.Territory.Name);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 47 "C:\Users\asmith\source\repos\MvcPlaces\MvcPlaces\Views\TerritoryPlace\Details.cshtml"
                                                                                                              WriteLiteral(Model.TerritoryId);

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
            BeginContext(2704, 145, true);
            WriteLiteral("</div>\r\n            </div>\r\n            <div class=\"d-flex\">\r\n                <div class=\"w-25 p-1 pr-4 mb-1 bg-secondary text-white text-right\">");
            EndContext();
            BeginContext(2849, 46, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "393c9846da044f12b9645a7d57a90af7", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#line 50 "C:\Users\asmith\source\repos\MvcPlaces\MvcPlaces\Views\TerritoryPlace\Details.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Territory.NativeName);

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
            BeginContext(2895, 65, true);
            WriteLiteral("</div>\r\n                <div class=\"w-75 p-1 pl-4 mb-1 bg-white\">");
            EndContext();
            BeginContext(2961, 26, false);
#line 51 "C:\Users\asmith\source\repos\MvcPlaces\MvcPlaces\Views\TerritoryPlace\Details.cshtml"
                                                    Write(Model.Territory.NativeName);

#line default
#line hidden
            EndContext();
            BeginContext(2987, 145, true);
            WriteLiteral("</div>\r\n            </div>\r\n            <div class=\"d-flex\">\r\n                <div class=\"w-25 p-1 pr-4 mb-1 bg-secondary text-white text-right\">");
            EndContext();
            BeginContext(3132, 46, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "da27956f9a2c4e68bae3857740233229", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#line 54 "C:\Users\asmith\source\repos\MvcPlaces\MvcPlaces\Views\TerritoryPlace\Details.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Territory.Population);

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
            BeginContext(3178, 65, true);
            WriteLiteral("</div>\r\n                <div class=\"w-75 p-1 pl-4 mb-1 bg-white\">");
            EndContext();
            BeginContext(3244, 51, false);
#line 55 "C:\Users\asmith\source\repos\MvcPlaces\MvcPlaces\Views\TerritoryPlace\Details.cshtml"
                                                    Write(String.Format("{0:N0}", Model.Territory.Population));

#line default
#line hidden
            EndContext();
            BeginContext(3295, 145, true);
            WriteLiteral("</div>\r\n            </div>\r\n            <div class=\"d-flex\">\r\n                <div class=\"w-25 p-1 pr-4 mb-1 bg-secondary text-white text-right\">");
            EndContext();
            BeginContext(3440, 40, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "08fb586e5f324e0fbdc0598eb4596f35", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#line 58 "C:\Users\asmith\source\repos\MvcPlaces\MvcPlaces\Views\TerritoryPlace\Details.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Territory.Area);

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
            BeginContext(3480, 65, true);
            WriteLiteral("</div>\r\n                <div class=\"w-75 p-1 pl-4 mb-1 bg-white\">");
            EndContext();
            BeginContext(3546, 88, false);
#line 59 "C:\Users\asmith\source\repos\MvcPlaces\MvcPlaces\Views\TerritoryPlace\Details.cshtml"
                                                    Write(String.Format(Model.Territory.Area % 1 == 0 ? "{0:N0}" : "{0:N2}", Model.Territory.Area));

#line default
#line hidden
            EndContext();
            BeginContext(3634, 77, true);
            WriteLiteral(" km<sup>2</sup></div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MvcPlaces.ViewModels.Models.Main.TerritoryPlaceView> Html { get; private set; }
    }
}
#pragma warning restore 1591
