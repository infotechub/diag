#pragma checksum "C:\Users\akinb\source\repos\NovoDiagnosis\NovoDiagnosis\Views\DiagnosisDetails1\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "01d1a8567b735c948635a70a0709b0faa12cca71"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DiagnosisDetails1_Delete), @"mvc.1.0.view", @"/Views/DiagnosisDetails1/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/DiagnosisDetails1/Delete.cshtml", typeof(AspNetCore.Views_DiagnosisDetails1_Delete))]
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
#line 1 "C:\Users\akinb\source\repos\NovoDiagnosis\NovoDiagnosis\Views\_ViewImports.cshtml"
using NovoDiagnosis;

#line default
#line hidden
#line 2 "C:\Users\akinb\source\repos\NovoDiagnosis\NovoDiagnosis\Views\_ViewImports.cshtml"
using NovoDiagnosis.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"01d1a8567b735c948635a70a0709b0faa12cca71", @"/Views/DiagnosisDetails1/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"22ba3f2932ac4e7dcc082159f12ac909dc9162a4", @"/Views/_ViewImports.cshtml")]
    public class Views_DiagnosisDetails1_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<NovoDiagnosis.Models.DiagnosisDetails>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(46, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\akinb\source\repos\NovoDiagnosis\NovoDiagnosis\Views\DiagnosisDetails1\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
            BeginContext(90, 177, true);
            WriteLiteral("\r\n<h2>Delete</h2>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>DiagnosisDetails</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(268, 44, false);
#line 15 "C:\Users\akinb\source\repos\NovoDiagnosis\NovoDiagnosis\Views\DiagnosisDetails1\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.FullName));

#line default
#line hidden
            EndContext();
            BeginContext(312, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(356, 40, false);
#line 18 "C:\Users\akinb\source\repos\NovoDiagnosis\NovoDiagnosis\Views\DiagnosisDetails1\Delete.cshtml"
       Write(Html.DisplayFor(model => model.FullName));

#line default
#line hidden
            EndContext();
            BeginContext(396, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(440, 43, false);
#line 21 "C:\Users\akinb\source\repos\NovoDiagnosis\NovoDiagnosis\Views\DiagnosisDetails1\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.StaffId));

#line default
#line hidden
            EndContext();
            BeginContext(483, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(527, 39, false);
#line 24 "C:\Users\akinb\source\repos\NovoDiagnosis\NovoDiagnosis\Views\DiagnosisDetails1\Delete.cshtml"
       Write(Html.DisplayFor(model => model.StaffId));

#line default
#line hidden
            EndContext();
            BeginContext(566, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(610, 44, false);
#line 27 "C:\Users\akinb\source\repos\NovoDiagnosis\NovoDiagnosis\Views\DiagnosisDetails1\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Provider));

#line default
#line hidden
            EndContext();
            BeginContext(654, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(698, 40, false);
#line 30 "C:\Users\akinb\source\repos\NovoDiagnosis\NovoDiagnosis\Views\DiagnosisDetails1\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Provider));

#line default
#line hidden
            EndContext();
            BeginContext(738, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(782, 41, false);
#line 33 "C:\Users\akinb\source\repos\NovoDiagnosis\NovoDiagnosis\Views\DiagnosisDetails1\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.State));

#line default
#line hidden
            EndContext();
            BeginContext(823, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(867, 37, false);
#line 36 "C:\Users\akinb\source\repos\NovoDiagnosis\NovoDiagnosis\Views\DiagnosisDetails1\Delete.cshtml"
       Write(Html.DisplayFor(model => model.State));

#line default
#line hidden
            EndContext();
            BeginContext(904, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(948, 41, false);
#line 39 "C:\Users\akinb\source\repos\NovoDiagnosis\NovoDiagnosis\Views\DiagnosisDetails1\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(989, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1033, 37, false);
#line 42 "C:\Users\akinb\source\repos\NovoDiagnosis\NovoDiagnosis\Views\DiagnosisDetails1\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(1070, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1114, 47, false);
#line 45 "C:\Users\akinb\source\repos\NovoDiagnosis\NovoDiagnosis\Views\DiagnosisDetails1\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.PhoneNumber));

#line default
#line hidden
            EndContext();
            BeginContext(1161, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1205, 43, false);
#line 48 "C:\Users\akinb\source\repos\NovoDiagnosis\NovoDiagnosis\Views\DiagnosisDetails1\Delete.cshtml"
       Write(Html.DisplayFor(model => model.PhoneNumber));

#line default
#line hidden
            EndContext();
            BeginContext(1248, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1292, 58, false);
#line 51 "C:\Users\akinb\source\repos\NovoDiagnosis\NovoDiagnosis\Views\DiagnosisDetails1\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.CompletedAnnualMedical));

#line default
#line hidden
            EndContext();
            BeginContext(1350, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1394, 54, false);
#line 54 "C:\Users\akinb\source\repos\NovoDiagnosis\NovoDiagnosis\Views\DiagnosisDetails1\Delete.cshtml"
       Write(Html.DisplayFor(model => model.CompletedAnnualMedical));

#line default
#line hidden
            EndContext();
            BeginContext(1448, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1492, 43, false);
#line 57 "C:\Users\akinb\source\repos\NovoDiagnosis\NovoDiagnosis\Views\DiagnosisDetails1\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Approve));

#line default
#line hidden
            EndContext();
            BeginContext(1535, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1579, 39, false);
#line 60 "C:\Users\akinb\source\repos\NovoDiagnosis\NovoDiagnosis\Views\DiagnosisDetails1\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Approve));

#line default
#line hidden
            EndContext();
            BeginContext(1618, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1662, 42, false);
#line 63 "C:\Users\akinb\source\repos\NovoDiagnosis\NovoDiagnosis\Views\DiagnosisDetails1\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Reject));

#line default
#line hidden
            EndContext();
            BeginContext(1704, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1748, 38, false);
#line 66 "C:\Users\akinb\source\repos\NovoDiagnosis\NovoDiagnosis\Views\DiagnosisDetails1\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Reject));

#line default
#line hidden
            EndContext();
            BeginContext(1786, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1830, 45, false);
#line 69 "C:\Users\akinb\source\repos\NovoDiagnosis\NovoDiagnosis\Views\DiagnosisDetails1\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.CreatedOn));

#line default
#line hidden
            EndContext();
            BeginContext(1875, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1919, 41, false);
#line 72 "C:\Users\akinb\source\repos\NovoDiagnosis\NovoDiagnosis\Views\DiagnosisDetails1\Delete.cshtml"
       Write(Html.DisplayFor(model => model.CreatedOn));

#line default
#line hidden
            EndContext();
            BeginContext(1960, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2004, 45, false);
#line 75 "C:\Users\akinb\source\repos\NovoDiagnosis\NovoDiagnosis\Views\DiagnosisDetails1\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.UpdatedOn));

#line default
#line hidden
            EndContext();
            BeginContext(2049, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2093, 41, false);
#line 78 "C:\Users\akinb\source\repos\NovoDiagnosis\NovoDiagnosis\Views\DiagnosisDetails1\Delete.cshtml"
       Write(Html.DisplayFor(model => model.UpdatedOn));

#line default
#line hidden
            EndContext();
            BeginContext(2134, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2178, 53, false);
#line 81 "C:\Users\akinb\source\repos\NovoDiagnosis\NovoDiagnosis\Views\DiagnosisDetails1\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.AuthorizationCode));

#line default
#line hidden
            EndContext();
            BeginContext(2231, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2275, 49, false);
#line 84 "C:\Users\akinb\source\repos\NovoDiagnosis\NovoDiagnosis\Views\DiagnosisDetails1\Delete.cshtml"
       Write(Html.DisplayFor(model => model.AuthorizationCode));

#line default
#line hidden
            EndContext();
            BeginContext(2324, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2368, 50, false);
#line 87 "C:\Users\akinb\source\repos\NovoDiagnosis\NovoDiagnosis\Views\DiagnosisDetails1\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Recommendation));

#line default
#line hidden
            EndContext();
            BeginContext(2418, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2462, 46, false);
#line 90 "C:\Users\akinb\source\repos\NovoDiagnosis\NovoDiagnosis\Views\DiagnosisDetails1\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Recommendation));

#line default
#line hidden
            EndContext();
            BeginContext(2508, 38, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    ");
            EndContext();
            BeginContext(2546, 207, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c2ce33e4fbb0408aa814f05c1cfc9a8d", async() => {
                BeginContext(2572, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(2582, 36, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "083de46a2bee4c96bcee179edad4bfa6", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 95 "C:\Users\akinb\source\repos\NovoDiagnosis\NovoDiagnosis\Views\DiagnosisDetails1\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Id);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2618, 84, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-default\" /> |\r\n        ");
                EndContext();
                BeginContext(2702, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4007bfa952b945eab66361bc5946f7cb", async() => {
                    BeginContext(2724, 12, true);
                    WriteLiteral("Back to List");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2740, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2753, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NovoDiagnosis.Models.DiagnosisDetails> Html { get; private set; }
    }
}
#pragma warning restore 1591
