#pragma checksum "C:\Users\asmith\source\repos\MvcPlaces\MvcPlaces\Views\Shared\MvcGrid\_Pager.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b97cb3c3d8b9dcd192a876743baa5c99e6b5025b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_MvcGrid__Pager), @"mvc.1.0.view", @"/Views/Shared/MvcGrid/_Pager.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/MvcGrid/_Pager.cshtml", typeof(AspNetCore.Views_Shared_MvcGrid__Pager))]
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
#line 1 "C:\Users\asmith\source\repos\MvcPlaces\MvcPlaces\Views\Shared\MvcGrid\_Pager.cshtml"
using NonFactors.Mvc.Grid;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b97cb3c3d8b9dcd192a876743baa5c99e6b5025b", @"/Views/Shared/MvcGrid/_Pager.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"90595804cebf81d08ded851669eb832eac5790a3", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_MvcGrid__Pager : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IGridPager>
    {
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(29, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\asmith\source\repos\MvcPlaces\MvcPlaces\Views\Shared\MvcGrid\_Pager.cshtml"
  
    Int32 totalPages = Model.TotalPages;
    Int32 currentPage = Model.CurrentPage;
    Int32 firstDisplayPage = Model.FirstDisplayPage;

#line default
#line hidden
            BeginContext(197, 6, true);
            WriteLiteral("\r\n<div");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 203, "\"", 243, 2);
            WriteAttributeValue("", 211, "mvc-grid-pager", 211, 14, true);
#line 10 "C:\Users\asmith\source\repos\MvcPlaces\MvcPlaces\Views\Shared\MvcGrid\_Pager.cshtml"
WriteAttributeValue(" ", 225, Model.CssClasses, 226, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(244, 23, true);
            WriteLiteral(" data-show-page-sizes=\"");
            EndContext();
            BeginContext(268, 19, false);
#line 10 "C:\Users\asmith\source\repos\MvcPlaces\MvcPlaces\Views\Shared\MvcGrid\_Pager.cshtml"
                                                               Write(Model.ShowPageSizes);

#line default
#line hidden
            EndContext();
            BeginContext(287, 4, true);
            WriteLiteral("\">\r\n");
            EndContext();
#line 11 "C:\Users\asmith\source\repos\MvcPlaces\MvcPlaces\Views\Shared\MvcGrid\_Pager.cshtml"
     if (totalPages > 0)
    {

#line default
#line hidden
            BeginContext(324, 14, true);
            WriteLiteral("        <ul>\r\n");
            EndContext();
#line 14 "C:\Users\asmith\source\repos\MvcPlaces\MvcPlaces\Views\Shared\MvcGrid\_Pager.cshtml"
             if (currentPage > 1)
            {

#line default
#line hidden
            BeginContext(388, 107, true);
            WriteLiteral("                <li><a href=\"#\" data-page=\"1\">&laquo;</a></li>\r\n                <li><a href=\"#\" data-page=\"");
            EndContext();
            BeginContext(497, 15, false);
#line 17 "C:\Users\asmith\source\repos\MvcPlaces\MvcPlaces\Views\Shared\MvcGrid\_Pager.cshtml"
                                       Write(currentPage - 1);

#line default
#line hidden
            EndContext();
            BeginContext(513, 21, true);
            WriteLiteral("\">&lsaquo;</a></li>\r\n");
            EndContext();
#line 18 "C:\Users\asmith\source\repos\MvcPlaces\MvcPlaces\Views\Shared\MvcGrid\_Pager.cshtml"
            }
            else
            {

#line default
#line hidden
            BeginContext(582, 145, true);
            WriteLiteral("                <li class=\"disabled\"><a tabindex=\"-1\">&laquo;</a></li>\r\n                <li class=\"disabled\"><a tabindex=\"-1\">&lsaquo;</a></li>\r\n");
            EndContext();
#line 23 "C:\Users\asmith\source\repos\MvcPlaces\MvcPlaces\Views\Shared\MvcGrid\_Pager.cshtml"
            }

#line default
#line hidden
            BeginContext(742, 12, true);
            WriteLiteral("            ");
            EndContext();
#line 24 "C:\Users\asmith\source\repos\MvcPlaces\MvcPlaces\Views\Shared\MvcGrid\_Pager.cshtml"
             for (Int32 page = firstDisplayPage; page <= totalPages && page < firstDisplayPage + Model.PagesToDisplay; page++)
            {
                if (page == currentPage)
                {

#line default
#line hidden
            BeginContext(946, 62, true);
            WriteLiteral("                    <li class=\"active\"><a href=\"#\" data-page=\"");
            EndContext();
            BeginContext(1010, 4, false);
#line 28 "C:\Users\asmith\source\repos\MvcPlaces\MvcPlaces\Views\Shared\MvcGrid\_Pager.cshtml"
                                                          Write(page);

#line default
#line hidden
            EndContext();
            BeginContext(1015, 2, true);
            WriteLiteral("\">");
            EndContext();
            BeginContext(1019, 4, false);
#line 28 "C:\Users\asmith\source\repos\MvcPlaces\MvcPlaces\Views\Shared\MvcGrid\_Pager.cshtml"
                                                                   Write(page);

#line default
#line hidden
            EndContext();
            BeginContext(1024, 11, true);
            WriteLiteral("</a></li>\r\n");
            EndContext();
#line 29 "C:\Users\asmith\source\repos\MvcPlaces\MvcPlaces\Views\Shared\MvcGrid\_Pager.cshtml"
                }
                else
                {

#line default
#line hidden
            BeginContext(1095, 47, true);
            WriteLiteral("                    <li><a href=\"#\" data-page=\"");
            EndContext();
            BeginContext(1144, 4, false);
#line 32 "C:\Users\asmith\source\repos\MvcPlaces\MvcPlaces\Views\Shared\MvcGrid\_Pager.cshtml"
                                           Write(page);

#line default
#line hidden
            EndContext();
            BeginContext(1149, 2, true);
            WriteLiteral("\">");
            EndContext();
            BeginContext(1153, 4, false);
#line 32 "C:\Users\asmith\source\repos\MvcPlaces\MvcPlaces\Views\Shared\MvcGrid\_Pager.cshtml"
                                                    Write(page);

#line default
#line hidden
            EndContext();
            BeginContext(1158, 11, true);
            WriteLiteral("</a></li>\r\n");
            EndContext();
#line 33 "C:\Users\asmith\source\repos\MvcPlaces\MvcPlaces\Views\Shared\MvcGrid\_Pager.cshtml"
                }
            }

#line default
#line hidden
            BeginContext(1203, 12, true);
            WriteLiteral("            ");
            EndContext();
#line 35 "C:\Users\asmith\source\repos\MvcPlaces\MvcPlaces\Views\Shared\MvcGrid\_Pager.cshtml"
             if (currentPage < totalPages)
            {

#line default
#line hidden
            BeginContext(1262, 43, true);
            WriteLiteral("                <li><a href=\"#\" data-page=\"");
            EndContext();
            BeginContext(1307, 15, false);
#line 37 "C:\Users\asmith\source\repos\MvcPlaces\MvcPlaces\Views\Shared\MvcGrid\_Pager.cshtml"
                                       Write(currentPage + 1);

#line default
#line hidden
            EndContext();
            BeginContext(1323, 64, true);
            WriteLiteral("\">&rsaquo;</a></li>\r\n                <li><a href=\"#\" data-page=\"");
            EndContext();
            BeginContext(1388, 10, false);
#line 38 "C:\Users\asmith\source\repos\MvcPlaces\MvcPlaces\Views\Shared\MvcGrid\_Pager.cshtml"
                                      Write(totalPages);

#line default
#line hidden
            EndContext();
            BeginContext(1398, 20, true);
            WriteLiteral("\">&raquo;</a></li>\r\n");
            EndContext();
#line 39 "C:\Users\asmith\source\repos\MvcPlaces\MvcPlaces\Views\Shared\MvcGrid\_Pager.cshtml"
            }
            else
            {

#line default
#line hidden
            BeginContext(1466, 145, true);
            WriteLiteral("                <li class=\"disabled\"><a tabindex=\"-1\">&rsaquo;</a></li>\r\n                <li class=\"disabled\"><a tabindex=\"-1\">&raquo;</a></li>\r\n");
            EndContext();
#line 44 "C:\Users\asmith\source\repos\MvcPlaces\MvcPlaces\Views\Shared\MvcGrid\_Pager.cshtml"
            }

#line default
#line hidden
            BeginContext(1626, 15, true);
            WriteLiteral("        </ul>\r\n");
            EndContext();
#line 46 "C:\Users\asmith\source\repos\MvcPlaces\MvcPlaces\Views\Shared\MvcGrid\_Pager.cshtml"
        if (Model.ShowPageSizes)
        {

#line default
#line hidden
            BeginContext(1686, 47, true);
            WriteLiteral("            <div class=\"mvc-grid-page-sizes\">\r\n");
            EndContext();
#line 49 "C:\Users\asmith\source\repos\MvcPlaces\MvcPlaces\Views\Shared\MvcGrid\_Pager.cshtml"
                 if (Model.PageSizes.Count > 0)
                {

#line default
#line hidden
            BeginContext(1801, 58, true);
            WriteLiteral("                    <select class=\"mvc-grid-pager-rows\">\r\n");
            EndContext();
#line 52 "C:\Users\asmith\source\repos\MvcPlaces\MvcPlaces\Views\Shared\MvcGrid\_Pager.cshtml"
                         foreach (KeyValuePair<Int32, String> size in Model.PageSizes)
                        {
                            if (Model.RowsPerPage == size.Key)
                            {

#line default
#line hidden
            BeginContext(2069, 32, true);
            WriteLiteral("                                ");
            EndContext();
            BeginContext(2101, 55, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "02d96ffc7da94d8482de881233d9e446", async() => {
                BeginContext(2137, 10, false);
#line 56 "C:\Users\asmith\source\repos\MvcPlaces\MvcPlaces\Views\Shared\MvcGrid\_Pager.cshtml"
                                                              Write(size.Value);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#line 56 "C:\Users\asmith\source\repos\MvcPlaces\MvcPlaces\Views\Shared\MvcGrid\_Pager.cshtml"
                                   WriteLiteral(size.Key);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2156, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 57 "C:\Users\asmith\source\repos\MvcPlaces\MvcPlaces\Views\Shared\MvcGrid\_Pager.cshtml"
                            }
                            else
                            {

#line default
#line hidden
            BeginContext(2254, 32, true);
            WriteLiteral("                                ");
            EndContext();
            BeginContext(2286, 46, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f7f57029dcdd4ad997f2833927d41e4c", async() => {
                BeginContext(2313, 10, false);
#line 60 "C:\Users\asmith\source\repos\MvcPlaces\MvcPlaces\Views\Shared\MvcGrid\_Pager.cshtml"
                                                     Write(size.Value);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#line 60 "C:\Users\asmith\source\repos\MvcPlaces\MvcPlaces\Views\Shared\MvcGrid\_Pager.cshtml"
                                   WriteLiteral(size.Key);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2332, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 61 "C:\Users\asmith\source\repos\MvcPlaces\MvcPlaces\Views\Shared\MvcGrid\_Pager.cshtml"
                            }
                        }

#line default
#line hidden
            BeginContext(2392, 31, true);
            WriteLiteral("                    </select>\r\n");
            EndContext();
#line 64 "C:\Users\asmith\source\repos\MvcPlaces\MvcPlaces\Views\Shared\MvcGrid\_Pager.cshtml"
                }
                else
                {

#line default
#line hidden
            BeginContext(2483, 54, true);
            WriteLiteral("                    <input class=\"mvc-grid-pager-rows\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2537, "\"", 2563, 1);
#line 67 "C:\Users\asmith\source\repos\MvcPlaces\MvcPlaces\Views\Shared\MvcGrid\_Pager.cshtml"
WriteAttributeValue("", 2545, Model.RowsPerPage, 2545, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2564, 5, true);
            WriteLiteral(" />\r\n");
            EndContext();
#line 68 "C:\Users\asmith\source\repos\MvcPlaces\MvcPlaces\Views\Shared\MvcGrid\_Pager.cshtml"
                }

#line default
#line hidden
            BeginContext(2588, 20, true);
            WriteLiteral("            </div>\r\n");
            EndContext();
#line 70 "C:\Users\asmith\source\repos\MvcPlaces\MvcPlaces\Views\Shared\MvcGrid\_Pager.cshtml"
        }
        else
        {

#line default
#line hidden
            BeginContext(2644, 60, true);
            WriteLiteral("            <input class=\"mvc-grid-pager-rows\" type=\"hidden\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2704, "\"", 2730, 1);
#line 73 "C:\Users\asmith\source\repos\MvcPlaces\MvcPlaces\Views\Shared\MvcGrid\_Pager.cshtml"
WriteAttributeValue("", 2712, Model.RowsPerPage, 2712, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2731, 5, true);
            WriteLiteral(" />\r\n");
            EndContext();
#line 74 "C:\Users\asmith\source\repos\MvcPlaces\MvcPlaces\Views\Shared\MvcGrid\_Pager.cshtml"
        }
    }
    else
    {

#line default
#line hidden
            BeginContext(2771, 56, true);
            WriteLiteral("        <input class=\"mvc-grid-pager-rows\" type=\"hidden\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2827, "\"", 2853, 1);
#line 78 "C:\Users\asmith\source\repos\MvcPlaces\MvcPlaces\Views\Shared\MvcGrid\_Pager.cshtml"
WriteAttributeValue("", 2835, Model.RowsPerPage, 2835, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2854, 5, true);
            WriteLiteral(" />\r\n");
            EndContext();
#line 79 "C:\Users\asmith\source\repos\MvcPlaces\MvcPlaces\Views\Shared\MvcGrid\_Pager.cshtml"
    }

#line default
#line hidden
            BeginContext(2866, 8, true);
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IGridPager> Html { get; private set; }
    }
}
#pragma warning restore 1591
