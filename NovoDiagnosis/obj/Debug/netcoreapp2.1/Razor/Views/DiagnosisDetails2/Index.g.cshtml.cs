#pragma checksum "C:\Users\akinb\source\diag\NovoDiagnosis\Views\DiagnosisDetails2\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "54e543567b8f47c664c68463a0c1fc2587a683fd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DiagnosisDetails2_Index), @"mvc.1.0.view", @"/Views/DiagnosisDetails2/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/DiagnosisDetails2/Index.cshtml", typeof(AspNetCore.Views_DiagnosisDetails2_Index))]
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
#line 1 "C:\Users\akinb\source\diag\NovoDiagnosis\Views\_ViewImports.cshtml"
using NovoDiagnosis;

#line default
#line hidden
#line 2 "C:\Users\akinb\source\diag\NovoDiagnosis\Views\_ViewImports.cshtml"
using NovoDiagnosis.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"54e543567b8f47c664c68463a0c1fc2587a683fd", @"/Views/DiagnosisDetails2/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"22ba3f2932ac4e7dcc082159f12ac909dc9162a4", @"/Views/_ViewImports.cshtml")]
    public class Views_DiagnosisDetails2_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<NovoDiagnosis.Models.DiagnosisDetails>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(59, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\akinb\source\diag\NovoDiagnosis\Views\DiagnosisDetails2\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(102, 29, true);
            WriteLiteral("\r\n<h2>Index</h2>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(131, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "076c382c9e924b6295535a654333b365", async() => {
                BeginContext(154, 10, true);
                WriteLiteral("Create New");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(168, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(261, 44, false);
#line 16 "C:\Users\akinb\source\diag\NovoDiagnosis\Views\DiagnosisDetails2\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.FullName));

#line default
#line hidden
            EndContext();
            BeginContext(305, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(361, 43, false);
#line 19 "C:\Users\akinb\source\diag\NovoDiagnosis\Views\DiagnosisDetails2\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.StaffId));

#line default
#line hidden
            EndContext();
            BeginContext(404, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(460, 44, false);
#line 22 "C:\Users\akinb\source\diag\NovoDiagnosis\Views\DiagnosisDetails2\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Provider));

#line default
#line hidden
            EndContext();
            BeginContext(504, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(560, 41, false);
#line 25 "C:\Users\akinb\source\diag\NovoDiagnosis\Views\DiagnosisDetails2\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.State));

#line default
#line hidden
            EndContext();
            BeginContext(601, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(657, 41, false);
#line 28 "C:\Users\akinb\source\diag\NovoDiagnosis\Views\DiagnosisDetails2\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(698, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(754, 47, false);
#line 31 "C:\Users\akinb\source\diag\NovoDiagnosis\Views\DiagnosisDetails2\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.PhoneNumber));

#line default
#line hidden
            EndContext();
            BeginContext(801, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(857, 51, false);
#line 34 "C:\Users\akinb\source\diag\NovoDiagnosis\Views\DiagnosisDetails2\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.AppointmentDate));

#line default
#line hidden
            EndContext();
            BeginContext(908, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(964, 51, false);
#line 37 "C:\Users\akinb\source\diag\NovoDiagnosis\Views\DiagnosisDetails2\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.AppointmentTime));

#line default
#line hidden
            EndContext();
            BeginContext(1015, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1071, 58, false);
#line 40 "C:\Users\akinb\source\diag\NovoDiagnosis\Views\DiagnosisDetails2\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CompletedAnnualMedical));

#line default
#line hidden
            EndContext();
            BeginContext(1129, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1185, 43, false);
#line 43 "C:\Users\akinb\source\diag\NovoDiagnosis\Views\DiagnosisDetails2\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Approve));

#line default
#line hidden
            EndContext();
            BeginContext(1228, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1284, 42, false);
#line 46 "C:\Users\akinb\source\diag\NovoDiagnosis\Views\DiagnosisDetails2\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Reject));

#line default
#line hidden
            EndContext();
            BeginContext(1326, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1382, 45, false);
#line 49 "C:\Users\akinb\source\diag\NovoDiagnosis\Views\DiagnosisDetails2\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CreatedOn));

#line default
#line hidden
            EndContext();
            BeginContext(1427, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1483, 45, false);
#line 52 "C:\Users\akinb\source\diag\NovoDiagnosis\Views\DiagnosisDetails2\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.UpdatedOn));

#line default
#line hidden
            EndContext();
            BeginContext(1528, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1584, 53, false);
#line 55 "C:\Users\akinb\source\diag\NovoDiagnosis\Views\DiagnosisDetails2\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.AuthorizationCode));

#line default
#line hidden
            EndContext();
            BeginContext(1637, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1693, 50, false);
#line 58 "C:\Users\akinb\source\diag\NovoDiagnosis\Views\DiagnosisDetails2\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Recommendation));

#line default
#line hidden
            EndContext();
            BeginContext(1743, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1799, 44, false);
#line 61 "C:\Users\akinb\source\diag\NovoDiagnosis\Views\DiagnosisDetails2\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.UserName));

#line default
#line hidden
            EndContext();
            BeginContext(1843, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1899, 42, false);
#line 64 "C:\Users\akinb\source\diag\NovoDiagnosis\Views\DiagnosisDetails2\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Status));

#line default
#line hidden
            EndContext();
            BeginContext(1941, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1997, 43, false);
#line 67 "C:\Users\akinb\source\diag\NovoDiagnosis\Views\DiagnosisDetails2\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.History));

#line default
#line hidden
            EndContext();
            BeginContext(2040, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(2096, 54, false);
#line 70 "C:\Users\akinb\source\diag\NovoDiagnosis\Views\DiagnosisDetails2\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.PresentingComplain));

#line default
#line hidden
            EndContext();
            BeginContext(2150, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(2206, 45, false);
#line 73 "C:\Users\akinb\source\diag\NovoDiagnosis\Views\DiagnosisDetails2\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Diagnosis));

#line default
#line hidden
            EndContext();
            BeginContext(2251, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(2307, 44, false);
#line 76 "C:\Users\akinb\source\diag\NovoDiagnosis\Views\DiagnosisDetails2\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.PlanTest));

#line default
#line hidden
            EndContext();
            BeginContext(2351, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 82 "C:\Users\akinb\source\diag\NovoDiagnosis\Views\DiagnosisDetails2\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(2469, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2518, 43, false);
#line 85 "C:\Users\akinb\source\diag\NovoDiagnosis\Views\DiagnosisDetails2\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.FullName));

#line default
#line hidden
            EndContext();
            BeginContext(2561, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2617, 42, false);
#line 88 "C:\Users\akinb\source\diag\NovoDiagnosis\Views\DiagnosisDetails2\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.StaffId));

#line default
#line hidden
            EndContext();
            BeginContext(2659, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2715, 43, false);
#line 91 "C:\Users\akinb\source\diag\NovoDiagnosis\Views\DiagnosisDetails2\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Provider));

#line default
#line hidden
            EndContext();
            BeginContext(2758, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2814, 40, false);
#line 94 "C:\Users\akinb\source\diag\NovoDiagnosis\Views\DiagnosisDetails2\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.State));

#line default
#line hidden
            EndContext();
            BeginContext(2854, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2910, 40, false);
#line 97 "C:\Users\akinb\source\diag\NovoDiagnosis\Views\DiagnosisDetails2\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
            EndContext();
            BeginContext(2950, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3006, 46, false);
#line 100 "C:\Users\akinb\source\diag\NovoDiagnosis\Views\DiagnosisDetails2\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.PhoneNumber));

#line default
#line hidden
            EndContext();
            BeginContext(3052, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3108, 50, false);
#line 103 "C:\Users\akinb\source\diag\NovoDiagnosis\Views\DiagnosisDetails2\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.AppointmentDate));

#line default
#line hidden
            EndContext();
            BeginContext(3158, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3214, 50, false);
#line 106 "C:\Users\akinb\source\diag\NovoDiagnosis\Views\DiagnosisDetails2\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.AppointmentTime));

#line default
#line hidden
            EndContext();
            BeginContext(3264, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3320, 57, false);
#line 109 "C:\Users\akinb\source\diag\NovoDiagnosis\Views\DiagnosisDetails2\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.CompletedAnnualMedical));

#line default
#line hidden
            EndContext();
            BeginContext(3377, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3433, 42, false);
#line 112 "C:\Users\akinb\source\diag\NovoDiagnosis\Views\DiagnosisDetails2\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Approve));

#line default
#line hidden
            EndContext();
            BeginContext(3475, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3531, 41, false);
#line 115 "C:\Users\akinb\source\diag\NovoDiagnosis\Views\DiagnosisDetails2\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Reject));

#line default
#line hidden
            EndContext();
            BeginContext(3572, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3628, 44, false);
#line 118 "C:\Users\akinb\source\diag\NovoDiagnosis\Views\DiagnosisDetails2\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.CreatedOn));

#line default
#line hidden
            EndContext();
            BeginContext(3672, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3728, 44, false);
#line 121 "C:\Users\akinb\source\diag\NovoDiagnosis\Views\DiagnosisDetails2\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.UpdatedOn));

#line default
#line hidden
            EndContext();
            BeginContext(3772, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3828, 52, false);
#line 124 "C:\Users\akinb\source\diag\NovoDiagnosis\Views\DiagnosisDetails2\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.AuthorizationCode));

#line default
#line hidden
            EndContext();
            BeginContext(3880, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3936, 49, false);
#line 127 "C:\Users\akinb\source\diag\NovoDiagnosis\Views\DiagnosisDetails2\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Recommendation));

#line default
#line hidden
            EndContext();
            BeginContext(3985, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(4041, 43, false);
#line 130 "C:\Users\akinb\source\diag\NovoDiagnosis\Views\DiagnosisDetails2\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.UserName));

#line default
#line hidden
            EndContext();
            BeginContext(4084, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(4140, 41, false);
#line 133 "C:\Users\akinb\source\diag\NovoDiagnosis\Views\DiagnosisDetails2\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Status));

#line default
#line hidden
            EndContext();
            BeginContext(4181, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(4237, 42, false);
#line 136 "C:\Users\akinb\source\diag\NovoDiagnosis\Views\DiagnosisDetails2\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.History));

#line default
#line hidden
            EndContext();
            BeginContext(4279, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(4335, 53, false);
#line 139 "C:\Users\akinb\source\diag\NovoDiagnosis\Views\DiagnosisDetails2\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.PresentingComplain));

#line default
#line hidden
            EndContext();
            BeginContext(4388, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(4444, 44, false);
#line 142 "C:\Users\akinb\source\diag\NovoDiagnosis\Views\DiagnosisDetails2\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Diagnosis));

#line default
#line hidden
            EndContext();
            BeginContext(4488, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(4544, 43, false);
#line 145 "C:\Users\akinb\source\diag\NovoDiagnosis\Views\DiagnosisDetails2\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.PlanTest));

#line default
#line hidden
            EndContext();
            BeginContext(4587, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(4642, 53, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "05a6a78d10704439be5d1c2e6194368e", async() => {
                BeginContext(4687, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 148 "C:\Users\akinb\source\diag\NovoDiagnosis\Views\DiagnosisDetails2\Index.cshtml"
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
            BeginContext(4695, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(4715, 59, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "094649dce0ab4f2f80006ae6f991ffea", async() => {
                BeginContext(4763, 7, true);
                WriteLiteral("Details");
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
#line 149 "C:\Users\akinb\source\diag\NovoDiagnosis\Views\DiagnosisDetails2\Index.cshtml"
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
            BeginContext(4774, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(4794, 57, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1662f359f90247b0916c6b5a420c08f4", async() => {
                BeginContext(4841, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 150 "C:\Users\akinb\source\diag\NovoDiagnosis\Views\DiagnosisDetails2\Index.cshtml"
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
            BeginContext(4851, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 153 "C:\Users\akinb\source\diag\NovoDiagnosis\Views\DiagnosisDetails2\Index.cshtml"
}

#line default
#line hidden
            BeginContext(4890, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<NovoDiagnosis.Models.DiagnosisDetails>> Html { get; private set; }
    }
}
#pragma warning restore 1591
