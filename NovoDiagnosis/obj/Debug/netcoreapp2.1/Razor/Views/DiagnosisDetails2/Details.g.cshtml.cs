#pragma checksum "C:\Users\akinb\source\diag\NovoDiagnosis\Views\DiagnosisDetails2\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4e6475dbc624aa4b7d34bb2030ffe9bb96133e0f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DiagnosisDetails2_Details), @"mvc.1.0.view", @"/Views/DiagnosisDetails2/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/DiagnosisDetails2/Details.cshtml", typeof(AspNetCore.Views_DiagnosisDetails2_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4e6475dbc624aa4b7d34bb2030ffe9bb96133e0f", @"/Views/DiagnosisDetails2/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"22ba3f2932ac4e7dcc082159f12ac909dc9162a4", @"/Views/_ViewImports.cshtml")]
    public class Views_DiagnosisDetails2_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<NovoDiagnosis.Models.DiagnosisDetails>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(46, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\akinb\source\diag\NovoDiagnosis\Views\DiagnosisDetails2\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(91, 130, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>DiagnosisDetails</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(222, 44, false);
#line 14 "C:\Users\akinb\source\diag\NovoDiagnosis\Views\DiagnosisDetails2\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.FullName));

#line default
#line hidden
            EndContext();
            BeginContext(266, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(310, 40, false);
#line 17 "C:\Users\akinb\source\diag\NovoDiagnosis\Views\DiagnosisDetails2\Details.cshtml"
       Write(Html.DisplayFor(model => model.FullName));

#line default
#line hidden
            EndContext();
            BeginContext(350, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(394, 43, false);
#line 20 "C:\Users\akinb\source\diag\NovoDiagnosis\Views\DiagnosisDetails2\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.StaffId));

#line default
#line hidden
            EndContext();
            BeginContext(437, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(481, 39, false);
#line 23 "C:\Users\akinb\source\diag\NovoDiagnosis\Views\DiagnosisDetails2\Details.cshtml"
       Write(Html.DisplayFor(model => model.StaffId));

#line default
#line hidden
            EndContext();
            BeginContext(520, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(564, 44, false);
#line 26 "C:\Users\akinb\source\diag\NovoDiagnosis\Views\DiagnosisDetails2\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Provider));

#line default
#line hidden
            EndContext();
            BeginContext(608, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(652, 40, false);
#line 29 "C:\Users\akinb\source\diag\NovoDiagnosis\Views\DiagnosisDetails2\Details.cshtml"
       Write(Html.DisplayFor(model => model.Provider));

#line default
#line hidden
            EndContext();
            BeginContext(692, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(736, 41, false);
#line 32 "C:\Users\akinb\source\diag\NovoDiagnosis\Views\DiagnosisDetails2\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.State));

#line default
#line hidden
            EndContext();
            BeginContext(777, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(821, 37, false);
#line 35 "C:\Users\akinb\source\diag\NovoDiagnosis\Views\DiagnosisDetails2\Details.cshtml"
       Write(Html.DisplayFor(model => model.State));

#line default
#line hidden
            EndContext();
            BeginContext(858, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(902, 41, false);
#line 38 "C:\Users\akinb\source\diag\NovoDiagnosis\Views\DiagnosisDetails2\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(943, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(987, 37, false);
#line 41 "C:\Users\akinb\source\diag\NovoDiagnosis\Views\DiagnosisDetails2\Details.cshtml"
       Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(1024, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1068, 47, false);
#line 44 "C:\Users\akinb\source\diag\NovoDiagnosis\Views\DiagnosisDetails2\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.PhoneNumber));

#line default
#line hidden
            EndContext();
            BeginContext(1115, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1159, 43, false);
#line 47 "C:\Users\akinb\source\diag\NovoDiagnosis\Views\DiagnosisDetails2\Details.cshtml"
       Write(Html.DisplayFor(model => model.PhoneNumber));

#line default
#line hidden
            EndContext();
            BeginContext(1202, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1246, 51, false);
#line 50 "C:\Users\akinb\source\diag\NovoDiagnosis\Views\DiagnosisDetails2\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.AppointmentDate));

#line default
#line hidden
            EndContext();
            BeginContext(1297, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1341, 47, false);
#line 53 "C:\Users\akinb\source\diag\NovoDiagnosis\Views\DiagnosisDetails2\Details.cshtml"
       Write(Html.DisplayFor(model => model.AppointmentDate));

#line default
#line hidden
            EndContext();
            BeginContext(1388, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1432, 51, false);
#line 56 "C:\Users\akinb\source\diag\NovoDiagnosis\Views\DiagnosisDetails2\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.AppointmentTime));

#line default
#line hidden
            EndContext();
            BeginContext(1483, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1527, 47, false);
#line 59 "C:\Users\akinb\source\diag\NovoDiagnosis\Views\DiagnosisDetails2\Details.cshtml"
       Write(Html.DisplayFor(model => model.AppointmentTime));

#line default
#line hidden
            EndContext();
            BeginContext(1574, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1618, 58, false);
#line 62 "C:\Users\akinb\source\diag\NovoDiagnosis\Views\DiagnosisDetails2\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CompletedAnnualMedical));

#line default
#line hidden
            EndContext();
            BeginContext(1676, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1720, 54, false);
#line 65 "C:\Users\akinb\source\diag\NovoDiagnosis\Views\DiagnosisDetails2\Details.cshtml"
       Write(Html.DisplayFor(model => model.CompletedAnnualMedical));

#line default
#line hidden
            EndContext();
            BeginContext(1774, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1818, 43, false);
#line 68 "C:\Users\akinb\source\diag\NovoDiagnosis\Views\DiagnosisDetails2\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Approve));

#line default
#line hidden
            EndContext();
            BeginContext(1861, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1905, 39, false);
#line 71 "C:\Users\akinb\source\diag\NovoDiagnosis\Views\DiagnosisDetails2\Details.cshtml"
       Write(Html.DisplayFor(model => model.Approve));

#line default
#line hidden
            EndContext();
            BeginContext(1944, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1988, 42, false);
#line 74 "C:\Users\akinb\source\diag\NovoDiagnosis\Views\DiagnosisDetails2\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Reject));

#line default
#line hidden
            EndContext();
            BeginContext(2030, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2074, 38, false);
#line 77 "C:\Users\akinb\source\diag\NovoDiagnosis\Views\DiagnosisDetails2\Details.cshtml"
       Write(Html.DisplayFor(model => model.Reject));

#line default
#line hidden
            EndContext();
            BeginContext(2112, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2156, 45, false);
#line 80 "C:\Users\akinb\source\diag\NovoDiagnosis\Views\DiagnosisDetails2\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CreatedOn));

#line default
#line hidden
            EndContext();
            BeginContext(2201, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2245, 41, false);
#line 83 "C:\Users\akinb\source\diag\NovoDiagnosis\Views\DiagnosisDetails2\Details.cshtml"
       Write(Html.DisplayFor(model => model.CreatedOn));

#line default
#line hidden
            EndContext();
            BeginContext(2286, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2330, 45, false);
#line 86 "C:\Users\akinb\source\diag\NovoDiagnosis\Views\DiagnosisDetails2\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.UpdatedOn));

#line default
#line hidden
            EndContext();
            BeginContext(2375, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2419, 41, false);
#line 89 "C:\Users\akinb\source\diag\NovoDiagnosis\Views\DiagnosisDetails2\Details.cshtml"
       Write(Html.DisplayFor(model => model.UpdatedOn));

#line default
#line hidden
            EndContext();
            BeginContext(2460, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2504, 53, false);
#line 92 "C:\Users\akinb\source\diag\NovoDiagnosis\Views\DiagnosisDetails2\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.AuthorizationCode));

#line default
#line hidden
            EndContext();
            BeginContext(2557, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2601, 49, false);
#line 95 "C:\Users\akinb\source\diag\NovoDiagnosis\Views\DiagnosisDetails2\Details.cshtml"
       Write(Html.DisplayFor(model => model.AuthorizationCode));

#line default
#line hidden
            EndContext();
            BeginContext(2650, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2694, 50, false);
#line 98 "C:\Users\akinb\source\diag\NovoDiagnosis\Views\DiagnosisDetails2\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Recommendation));

#line default
#line hidden
            EndContext();
            BeginContext(2744, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2788, 46, false);
#line 101 "C:\Users\akinb\source\diag\NovoDiagnosis\Views\DiagnosisDetails2\Details.cshtml"
       Write(Html.DisplayFor(model => model.Recommendation));

#line default
#line hidden
            EndContext();
            BeginContext(2834, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2878, 44, false);
#line 104 "C:\Users\akinb\source\diag\NovoDiagnosis\Views\DiagnosisDetails2\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.UserName));

#line default
#line hidden
            EndContext();
            BeginContext(2922, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2966, 40, false);
#line 107 "C:\Users\akinb\source\diag\NovoDiagnosis\Views\DiagnosisDetails2\Details.cshtml"
       Write(Html.DisplayFor(model => model.UserName));

#line default
#line hidden
            EndContext();
            BeginContext(3006, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(3050, 42, false);
#line 110 "C:\Users\akinb\source\diag\NovoDiagnosis\Views\DiagnosisDetails2\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Status));

#line default
#line hidden
            EndContext();
            BeginContext(3092, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(3136, 38, false);
#line 113 "C:\Users\akinb\source\diag\NovoDiagnosis\Views\DiagnosisDetails2\Details.cshtml"
       Write(Html.DisplayFor(model => model.Status));

#line default
#line hidden
            EndContext();
            BeginContext(3174, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(3218, 43, false);
#line 116 "C:\Users\akinb\source\diag\NovoDiagnosis\Views\DiagnosisDetails2\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.History));

#line default
#line hidden
            EndContext();
            BeginContext(3261, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(3305, 39, false);
#line 119 "C:\Users\akinb\source\diag\NovoDiagnosis\Views\DiagnosisDetails2\Details.cshtml"
       Write(Html.DisplayFor(model => model.History));

#line default
#line hidden
            EndContext();
            BeginContext(3344, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(3388, 54, false);
#line 122 "C:\Users\akinb\source\diag\NovoDiagnosis\Views\DiagnosisDetails2\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.PresentingComplain));

#line default
#line hidden
            EndContext();
            BeginContext(3442, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(3486, 50, false);
#line 125 "C:\Users\akinb\source\diag\NovoDiagnosis\Views\DiagnosisDetails2\Details.cshtml"
       Write(Html.DisplayFor(model => model.PresentingComplain));

#line default
#line hidden
            EndContext();
            BeginContext(3536, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(3580, 45, false);
#line 128 "C:\Users\akinb\source\diag\NovoDiagnosis\Views\DiagnosisDetails2\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Diagnosis));

#line default
#line hidden
            EndContext();
            BeginContext(3625, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(3669, 41, false);
#line 131 "C:\Users\akinb\source\diag\NovoDiagnosis\Views\DiagnosisDetails2\Details.cshtml"
       Write(Html.DisplayFor(model => model.Diagnosis));

#line default
#line hidden
            EndContext();
            BeginContext(3710, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(3754, 44, false);
#line 134 "C:\Users\akinb\source\diag\NovoDiagnosis\Views\DiagnosisDetails2\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.PlanTest));

#line default
#line hidden
            EndContext();
            BeginContext(3798, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(3842, 40, false);
#line 137 "C:\Users\akinb\source\diag\NovoDiagnosis\Views\DiagnosisDetails2\Details.cshtml"
       Write(Html.DisplayFor(model => model.PlanTest));

#line default
#line hidden
            EndContext();
            BeginContext(3882, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(3929, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "982ab240b5244aa58c1225ba7379657a", async() => {
                BeginContext(3975, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 142 "C:\Users\akinb\source\diag\NovoDiagnosis\Views\DiagnosisDetails2\Details.cshtml"
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
            BeginContext(3983, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(3991, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c39c35376d2d4c0eab14a83fde0614a0", async() => {
                BeginContext(4013, 12, true);
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
            BeginContext(4029, 10, true);
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