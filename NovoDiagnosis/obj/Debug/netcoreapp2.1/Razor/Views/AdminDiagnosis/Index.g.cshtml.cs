#pragma checksum "C:\Users\akinb\source\diag\NovoDiagnosis\Views\AdminDiagnosis\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "639cbdee1e95fba53538235323fefdcb02b65d97"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AdminDiagnosis_Index), @"mvc.1.0.view", @"/Views/AdminDiagnosis/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/AdminDiagnosis/Index.cshtml", typeof(AspNetCore.Views_AdminDiagnosis_Index))]
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
#line 2 "C:\Users\akinb\source\diag\NovoDiagnosis\Views\AdminDiagnosis\Index.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"639cbdee1e95fba53538235323fefdcb02b65d97", @"/Views/AdminDiagnosis/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"22ba3f2932ac4e7dcc082159f12ac909dc9162a4", @"/Views/_ViewImports.cshtml")]
    public class Views_AdminDiagnosis_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<NovoDiagnosis.Models.DiagnosisDetails>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-facebook text-white"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("cursor:pointer; width:auto;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/claim.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(97, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(203, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 7 "C:\Users\akinb\source\diag\NovoDiagnosis\Views\AdminDiagnosis\Index.cshtml"
  

    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(261, 399, true);
            WriteLiteral(@"<link rel=""stylesheet"" type=""text/css"" href=""https://cdn.datatables.net/1.10.19/css/jquery.dataTables.min.css"">

<!--main content start-->
<section id=""main-content"">
    <section class=""wrapper"">
        <div class=""row mb"">
            <div class=""col-lg-12"">
                <!-- /form-panel -->
                <h3 align=""centre"" class=""text-center"">Annual Diagonsis Appointment</h3>

");
            EndContext();
#line 21 "C:\Users\akinb\source\diag\NovoDiagnosis\Views\AdminDiagnosis\Index.cshtml"
                  
                    var user = await UserManager.GetUserAsync(User);

                

#line default
#line hidden
            BeginContext(771, 950, true);
            WriteLiteral(@"
                <div class=""row mb"">

                    <div class=""col-md-12"">
                        <!-- page start-->
                        <div class=""content-panel border rounded"">
                            <div class=""adv-table"">
                                <br /><br /><br />
                                <h4 align=""center"">Appointment List for Union Bank Staff</h4>
                                <h5 align=""center"">Kindly select the 'Approve Request' button in the Action column to update or change the status of the appointment.</h5>

                                <br/>

                                <table cellpadding=""0"" cellspacing=""0"" border=""0"" class=""display table table-bordered"" id=""claims"" width=""70%"">
                                    <thead>
                                        <tr>

                                            <th>
                                                ");
            EndContext();
            BeginContext(1722, 44, false);
#line 43 "C:\Users\akinb\source\diag\NovoDiagnosis\Views\AdminDiagnosis\Index.cshtml"
                                           Write(Html.DisplayNameFor(model => model.Provider));

#line default
#line hidden
            EndContext();
            BeginContext(1766, 196, true);
            WriteLiteral("\r\n                                            </th>\r\n                                           \r\n                                            <th>\r\n                                                ");
            EndContext();
            BeginContext(1963, 41, false);
#line 47 "C:\Users\akinb\source\diag\NovoDiagnosis\Views\AdminDiagnosis\Index.cshtml"
                                           Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(2004, 151, true);
            WriteLiteral("\r\n                                            </th>\r\n                                            <th>\r\n                                                ");
            EndContext();
            BeginContext(2156, 47, false);
#line 50 "C:\Users\akinb\source\diag\NovoDiagnosis\Views\AdminDiagnosis\Index.cshtml"
                                           Write(Html.DisplayNameFor(model => model.PhoneNumber));

#line default
#line hidden
            EndContext();
            BeginContext(2203, 151, true);
            WriteLiteral("\r\n                                            </th>\r\n                                            <th>\r\n                                                ");
            EndContext();
            BeginContext(2355, 51, false);
#line 53 "C:\Users\akinb\source\diag\NovoDiagnosis\Views\AdminDiagnosis\Index.cshtml"
                                           Write(Html.DisplayNameFor(model => model.AppointmentDate));

#line default
#line hidden
            EndContext();
            BeginContext(2406, 151, true);
            WriteLiteral("\r\n                                            </th>\r\n                                            <th>\r\n                                                ");
            EndContext();
            BeginContext(2558, 51, false);
#line 56 "C:\Users\akinb\source\diag\NovoDiagnosis\Views\AdminDiagnosis\Index.cshtml"
                                           Write(Html.DisplayNameFor(model => model.AppointmentTime));

#line default
#line hidden
            EndContext();
            BeginContext(2609, 151, true);
            WriteLiteral("\r\n                                            </th>\r\n                                            <th>\r\n                                                ");
            EndContext();
            BeginContext(2761, 43, false);
#line 59 "C:\Users\akinb\source\diag\NovoDiagnosis\Views\AdminDiagnosis\Index.cshtml"
                                           Write(Html.DisplayNameFor(model => model.Approve));

#line default
#line hidden
            EndContext();
            BeginContext(2804, 151, true);
            WriteLiteral("\r\n                                            </th>\r\n                                            <th>\r\n                                                ");
            EndContext();
            BeginContext(2956, 42, false);
#line 62 "C:\Users\akinb\source\diag\NovoDiagnosis\Views\AdminDiagnosis\Index.cshtml"
                                           Write(Html.DisplayNameFor(model => model.Reject));

#line default
#line hidden
            EndContext();
            BeginContext(2998, 151, true);
            WriteLiteral("\r\n                                            </th>\r\n                                            <th>\r\n                                                ");
            EndContext();
            BeginContext(3150, 50, false);
#line 65 "C:\Users\akinb\source\diag\NovoDiagnosis\Views\AdminDiagnosis\Index.cshtml"
                                           Write(Html.DisplayNameFor(model => model.Recommendation));

#line default
#line hidden
            EndContext();
            BeginContext(3200, 151, true);
            WriteLiteral("\r\n                                            </th>\r\n                                            <th>\r\n                                                ");
            EndContext();
            BeginContext(3352, 53, false);
#line 68 "C:\Users\akinb\source\diag\NovoDiagnosis\Views\AdminDiagnosis\Index.cshtml"
                                           Write(Html.DisplayNameFor(model => model.AuthorizationCode));

#line default
#line hidden
            EndContext();
            BeginContext(3405, 151, true);
            WriteLiteral("\r\n                                            </th>\r\n                                            <th>\r\n                                                ");
            EndContext();
            BeginContext(3557, 58, false);
#line 71 "C:\Users\akinb\source\diag\NovoDiagnosis\Views\AdminDiagnosis\Index.cshtml"
                                           Write(Html.DisplayNameFor(model => model.CompletedAnnualMedical));

#line default
#line hidden
            EndContext();
            BeginContext(3615, 151, true);
            WriteLiteral("\r\n                                            </th>\r\n                                            <th>\r\n                                                ");
            EndContext();
            BeginContext(3767, 45, false);
#line 74 "C:\Users\akinb\source\diag\NovoDiagnosis\Views\AdminDiagnosis\Index.cshtml"
                                           Write(Html.DisplayNameFor(model => model.Diagnosis));

#line default
#line hidden
            EndContext();
            BeginContext(3812, 254, true);
            WriteLiteral("\r\n                                            </th>\r\n\r\n                                            <th></th>\r\n\r\n\r\n                                        </tr>\r\n                                    </thead>\r\n\r\n                                    <tbody>\r\n");
            EndContext();
#line 84 "C:\Users\akinb\source\diag\NovoDiagnosis\Views\AdminDiagnosis\Index.cshtml"
                                         foreach (var item in Model)
                                        {

#line default
#line hidden
            BeginContext(4179, 146, true);
            WriteLiteral("                                        <tr>\r\n\r\n                                            <td>\r\n                                                ");
            EndContext();
            BeginContext(4326, 43, false);
#line 89 "C:\Users\akinb\source\diag\NovoDiagnosis\Views\AdminDiagnosis\Index.cshtml"
                                           Write(Html.DisplayFor(modelItem => item.Provider));

#line default
#line hidden
            EndContext();
            BeginContext(4369, 195, true);
            WriteLiteral("\r\n                                            </td>\r\n                                          \r\n                                            <td>\r\n                                                ");
            EndContext();
            BeginContext(4565, 40, false);
#line 93 "C:\Users\akinb\source\diag\NovoDiagnosis\Views\AdminDiagnosis\Index.cshtml"
                                           Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
            EndContext();
            BeginContext(4605, 151, true);
            WriteLiteral("\r\n                                            </td>\r\n                                            <td>\r\n                                                ");
            EndContext();
            BeginContext(4757, 46, false);
#line 96 "C:\Users\akinb\source\diag\NovoDiagnosis\Views\AdminDiagnosis\Index.cshtml"
                                           Write(Html.DisplayFor(modelItem => item.PhoneNumber));

#line default
#line hidden
            EndContext();
            BeginContext(4803, 151, true);
            WriteLiteral("\r\n                                            </td>\r\n                                            <td>\r\n                                                ");
            EndContext();
            BeginContext(4955, 50, false);
#line 99 "C:\Users\akinb\source\diag\NovoDiagnosis\Views\AdminDiagnosis\Index.cshtml"
                                           Write(Html.DisplayFor(modelItem => item.AppointmentDate));

#line default
#line hidden
            EndContext();
            BeginContext(5005, 151, true);
            WriteLiteral("\r\n                                            </td>\r\n                                            <td>\r\n                                                ");
            EndContext();
            BeginContext(5157, 50, false);
#line 102 "C:\Users\akinb\source\diag\NovoDiagnosis\Views\AdminDiagnosis\Index.cshtml"
                                           Write(Html.DisplayFor(modelItem => item.AppointmentTime));

#line default
#line hidden
            EndContext();
            BeginContext(5207, 152, true);
            WriteLiteral("\r\n                                            </td>\r\n                                            <td>\r\n                                               \r\n");
            EndContext();
#line 106 "C:\Users\akinb\source\diag\NovoDiagnosis\Views\AdminDiagnosis\Index.cshtml"
                                                  
                                                    if (item.Approve== false)
                                                    {

#line default
#line hidden
            BeginContext(5545, 82, true);
            WriteLiteral("                                                        <p align=\"center\">No</p>\r\n");
            EndContext();
#line 110 "C:\Users\akinb\source\diag\NovoDiagnosis\Views\AdminDiagnosis\Index.cshtml"
                                                    }
                                                    else
                                                    {

#line default
#line hidden
            BeginContext(5795, 83, true);
            WriteLiteral("                                                        <p align=\"center\">Yes</p>\r\n");
            EndContext();
#line 114 "C:\Users\akinb\source\diag\NovoDiagnosis\Views\AdminDiagnosis\Index.cshtml"
                                                    }
                                                

#line default
#line hidden
            BeginContext(5984, 150, true);
            WriteLiteral("                                            </td>\r\n                                            <td>\r\n                                               \r\n");
            EndContext();
#line 119 "C:\Users\akinb\source\diag\NovoDiagnosis\Views\AdminDiagnosis\Index.cshtml"
                                                  
                                                    if (item.Reject == false)
                                                    {

#line default
#line hidden
            BeginContext(6320, 82, true);
            WriteLiteral("                                                        <p align=\"center\">No</p>\r\n");
            EndContext();
#line 123 "C:\Users\akinb\source\diag\NovoDiagnosis\Views\AdminDiagnosis\Index.cshtml"
                                                    }
                                                    else
                                                    {

#line default
#line hidden
            BeginContext(6570, 83, true);
            WriteLiteral("                                                        <p align=\"center\">Yes</p>\r\n");
            EndContext();
#line 127 "C:\Users\akinb\source\diag\NovoDiagnosis\Views\AdminDiagnosis\Index.cshtml"
                                                    }
                                                

#line default
#line hidden
            BeginContext(6759, 151, true);
            WriteLiteral("                                            </td>\r\n\r\n                                            <td>\r\n                                                ");
            EndContext();
            BeginContext(6911, 49, false);
#line 132 "C:\Users\akinb\source\diag\NovoDiagnosis\Views\AdminDiagnosis\Index.cshtml"
                                           Write(Html.DisplayFor(modelItem => item.Recommendation));

#line default
#line hidden
            EndContext();
            BeginContext(6960, 103, true);
            WriteLiteral("\r\n                                            </td>\r\n                                            <td>\r\n");
            EndContext();
#line 135 "C:\Users\akinb\source\diag\NovoDiagnosis\Views\AdminDiagnosis\Index.cshtml"
                                                  
                                                    if (item.AuthorizationCode == null)
                                                    {

#line default
#line hidden
            BeginContext(7259, 87, true);
            WriteLiteral("                                                        <p align=\"center\">No Code</p>\r\n");
            EndContext();
#line 139 "C:\Users\akinb\source\diag\NovoDiagnosis\Views\AdminDiagnosis\Index.cshtml"
                                                    }
                                                    else
                                                    {
                                                        

#line default
#line hidden
            BeginContext(7571, 52, false);
#line 142 "C:\Users\akinb\source\diag\NovoDiagnosis\Views\AdminDiagnosis\Index.cshtml"
                                                   Write(Html.DisplayFor(modelItem => item.AuthorizationCode));

#line default
#line hidden
            EndContext();
#line 142 "C:\Users\akinb\source\diag\NovoDiagnosis\Views\AdminDiagnosis\Index.cshtml"
                                                                                                             
                                                    }
                                                

#line default
#line hidden
            BeginContext(7731, 101, true);
            WriteLiteral("                                            </td>\r\n                                            <td>\r\n");
            EndContext();
#line 147 "C:\Users\akinb\source\diag\NovoDiagnosis\Views\AdminDiagnosis\Index.cshtml"
                                                  
                                                    if (item.CompletedAnnualMedical == false)
                                                    {

#line default
#line hidden
            BeginContext(8034, 82, true);
            WriteLiteral("                                                        <p align=\"center\">No</p>\r\n");
            EndContext();
#line 151 "C:\Users\akinb\source\diag\NovoDiagnosis\Views\AdminDiagnosis\Index.cshtml"
                                                    }
                                                    else
                                                    {

#line default
#line hidden
            BeginContext(8284, 83, true);
            WriteLiteral("                                                        <p align=\"center\">Yes</p>\r\n");
            EndContext();
#line 155 "C:\Users\akinb\source\diag\NovoDiagnosis\Views\AdminDiagnosis\Index.cshtml"
                                                    }
                                                

#line default
#line hidden
            BeginContext(8473, 196, true);
            WriteLiteral("\r\n                                            </td>\r\n                                           \r\n                                            <td>\r\n                                                ");
            EndContext();
            BeginContext(8670, 44, false);
#line 161 "C:\Users\akinb\source\diag\NovoDiagnosis\Views\AdminDiagnosis\Index.cshtml"
                                           Write(Html.DisplayFor(modelItem => item.Diagnosis));

#line default
#line hidden
            EndContext();
            BeginContext(8714, 153, true);
            WriteLiteral("\r\n                                            </td>\r\n\r\n                                            <td>\r\n                                                ");
            EndContext();
            BeginContext(8867, 172, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c5a876707c184825a6c12777ef4843fd", async() => {
                BeginContext(8984, 51, true);
                WriteLiteral("<i class=\"fa fa-pencil-square\"></i> Approve Request");
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
#line 165 "C:\Users\akinb\source\diag\NovoDiagnosis\Views\AdminDiagnosis\Index.cshtml"
                                                                       WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(9039, 102, true);
            WriteLiteral("\r\n                                            </td>\r\n\r\n                                        </tr>\r\n");
            EndContext();
#line 169 "C:\Users\akinb\source\diag\NovoDiagnosis\Views\AdminDiagnosis\Index.cshtml"

                                        }

#line default
#line hidden
            BeginContext(9186, 564, true);
            WriteLiteral(@"
                                    </tbody>
                                </table>
                                <br /><br /><br /><br /><br />
                                <br /><br /><br /><br /><br />
                                <br /><br /><br /><br /><br />
                                <br /><br /><br /><br /><br />
                            </div>


                        </div>
                    </div>
                </div>

            </div>

        </div>


        </div>

    </section>
</section>


");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(9767, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(9773, 37, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e6717027f23f4a30a08de2ba27e59c4f", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(9810, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            BeginContext(9815, 461, true);
            WriteLiteral(@"
<script type=""text/javascript"" src=""https://code.jquery.com/jquery-3.3.1.js""></script>
<script type=""text/javascript"" src=""https://cdn.datatables.net/1.10.19/js/jquery.dataTables.min.js""></script>
<script type=""text/javascript"">
    var dataTable;
    $(document).ready(function () {
        loadDataTable();
    });
    (function ($) {
        $(""#claims"").DataTable({
            ajax: {


            });
    })(jQuery);


</script>



");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<ApplicationUser> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<ApplicationUser> SignInManager { get; private set; }
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
