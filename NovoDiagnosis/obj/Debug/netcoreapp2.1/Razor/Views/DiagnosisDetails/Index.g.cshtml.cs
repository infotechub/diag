#pragma checksum "C:\Users\akinb\source\diag\NovoDiagnosis\Views\DiagnosisDetails\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8da6c964deb28aaf09415f092b228d159446e35e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DiagnosisDetails_Index), @"mvc.1.0.view", @"/Views/DiagnosisDetails/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/DiagnosisDetails/Index.cshtml", typeof(AspNetCore.Views_DiagnosisDetails_Index))]
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
#line 2 "C:\Users\akinb\source\diag\NovoDiagnosis\Views\DiagnosisDetails\Index.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8da6c964deb28aaf09415f092b228d159446e35e", @"/Views/DiagnosisDetails/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"22ba3f2932ac4e7dcc082159f12ac909dc9162a4", @"/Views/_ViewImports.cshtml")]
    public class Views_DiagnosisDetails_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<NovoDiagnosis.Models.DiagnosisDetails>>
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
#line 7 "C:\Users\akinb\source\diag\NovoDiagnosis\Views\DiagnosisDetails\Index.cshtml"
  

    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(261, 397, true);
            WriteLiteral(@"<link rel=""stylesheet"" type=""text/css"" href=""https://cdn.datatables.net/1.10.19/css/jquery.dataTables.min.css"">

<!--main content start-->
<section id=""main-content"">
    <section class=""wrapper"">
        <div class=""row mb"">
            <div class=""col-lg-12"">
                <!-- /form-panel -->
                <h3 align=""centre"" class=""text-center"">Annual Medical Examination</h3>

");
            EndContext();
#line 21 "C:\Users\akinb\source\diag\NovoDiagnosis\Views\DiagnosisDetails\Index.cshtml"
                  
                    var user = await UserManager.GetUserAsync(User);

                

#line default
#line hidden
            BeginContext(769, 316, true);
            WriteLiteral(@"
                <div class=""row mb"">

                    <div class=""col-md-12"">
                        <!-- page start-->
                        <div class=""content-panel border rounded"">
                            <div class=""adv-table"">
                                <br /><br /><br /><br /><br />
");
            EndContext();
#line 33 "C:\Users\akinb\source\diag\NovoDiagnosis\Views\DiagnosisDetails\Index.cshtml"
                                 if (SignInManager.IsSignedIn(User))
                                {

#line default
#line hidden
            BeginContext(1190, 76, true);
            WriteLiteral("                                    <h4 align=\"center\">Appointment List for ");
            EndContext();
            BeginContext(1267, 13, false);
#line 35 "C:\Users\akinb\source\diag\NovoDiagnosis\Views\DiagnosisDetails\Index.cshtml"
                                                                       Write(user.FullName);

#line default
#line hidden
            EndContext();
            BeginContext(1280, 7, true);
            WriteLiteral("</h4>\r\n");
            EndContext();
#line 36 "C:\Users\akinb\source\diag\NovoDiagnosis\Views\DiagnosisDetails\Index.cshtml"
                                }
                                else
                                {

#line default
#line hidden
            BeginContext(1395, 77, true);
            WriteLiteral("                                    <h4 align=\"center\">Kindly Sign In </h4>\r\n");
            EndContext();
#line 40 "C:\Users\akinb\source\diag\NovoDiagnosis\Views\DiagnosisDetails\Index.cshtml"
                                }

#line default
#line hidden
            BeginContext(1507, 340, true);
            WriteLiteral(@"

                                <table cellpadding=""0"" cellspacing=""0"" border=""0"" class=""display table table-bordered"" id=""claims"" width=""70%"">
                                    <thead>
                                        <tr>

                                            <th>
                                                ");
            EndContext();
            BeginContext(1848, 44, false);
#line 48 "C:\Users\akinb\source\diag\NovoDiagnosis\Views\DiagnosisDetails\Index.cshtml"
                                           Write(Html.DisplayNameFor(model => model.Provider));

#line default
#line hidden
            EndContext();
            BeginContext(1892, 151, true);
            WriteLiteral("\r\n                                            </th>\r\n                                            <th>\r\n                                                ");
            EndContext();
            BeginContext(2044, 41, false);
#line 51 "C:\Users\akinb\source\diag\NovoDiagnosis\Views\DiagnosisDetails\Index.cshtml"
                                           Write(Html.DisplayNameFor(model => model.State));

#line default
#line hidden
            EndContext();
            BeginContext(2085, 151, true);
            WriteLiteral("\r\n                                            </th>\r\n                                            <th>\r\n                                                ");
            EndContext();
            BeginContext(2237, 41, false);
#line 54 "C:\Users\akinb\source\diag\NovoDiagnosis\Views\DiagnosisDetails\Index.cshtml"
                                           Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(2278, 151, true);
            WriteLiteral("\r\n                                            </th>\r\n                                            <th>\r\n                                                ");
            EndContext();
            BeginContext(2430, 47, false);
#line 57 "C:\Users\akinb\source\diag\NovoDiagnosis\Views\DiagnosisDetails\Index.cshtml"
                                           Write(Html.DisplayNameFor(model => model.PhoneNumber));

#line default
#line hidden
            EndContext();
            BeginContext(2477, 151, true);
            WriteLiteral("\r\n                                            </th>\r\n                                            <th>\r\n                                                ");
            EndContext();
            BeginContext(2629, 51, false);
#line 60 "C:\Users\akinb\source\diag\NovoDiagnosis\Views\DiagnosisDetails\Index.cshtml"
                                           Write(Html.DisplayNameFor(model => model.AppointmentDate));

#line default
#line hidden
            EndContext();
            BeginContext(2680, 151, true);
            WriteLiteral("\r\n                                            </th>\r\n                                            <th>\r\n                                                ");
            EndContext();
            BeginContext(2832, 51, false);
#line 63 "C:\Users\akinb\source\diag\NovoDiagnosis\Views\DiagnosisDetails\Index.cshtml"
                                           Write(Html.DisplayNameFor(model => model.AppointmentTime));

#line default
#line hidden
            EndContext();
            BeginContext(2883, 151, true);
            WriteLiteral("\r\n                                            </th>\r\n                                            <th>\r\n                                                ");
            EndContext();
            BeginContext(3035, 43, false);
#line 66 "C:\Users\akinb\source\diag\NovoDiagnosis\Views\DiagnosisDetails\Index.cshtml"
                                           Write(Html.DisplayNameFor(model => model.Approve));

#line default
#line hidden
            EndContext();
            BeginContext(3078, 151, true);
            WriteLiteral("\r\n                                            </th>\r\n                                            <th>\r\n                                                ");
            EndContext();
            BeginContext(3230, 42, false);
#line 69 "C:\Users\akinb\source\diag\NovoDiagnosis\Views\DiagnosisDetails\Index.cshtml"
                                           Write(Html.DisplayNameFor(model => model.Reject));

#line default
#line hidden
            EndContext();
            BeginContext(3272, 151, true);
            WriteLiteral("\r\n                                            </th>\r\n                                            <th>\r\n                                                ");
            EndContext();
            BeginContext(3424, 50, false);
#line 72 "C:\Users\akinb\source\diag\NovoDiagnosis\Views\DiagnosisDetails\Index.cshtml"
                                           Write(Html.DisplayNameFor(model => model.Recommendation));

#line default
#line hidden
            EndContext();
            BeginContext(3474, 151, true);
            WriteLiteral("\r\n                                            </th>\r\n                                            <th>\r\n                                                ");
            EndContext();
            BeginContext(3626, 53, false);
#line 75 "C:\Users\akinb\source\diag\NovoDiagnosis\Views\DiagnosisDetails\Index.cshtml"
                                           Write(Html.DisplayNameFor(model => model.AuthorizationCode));

#line default
#line hidden
            EndContext();
            BeginContext(3679, 151, true);
            WriteLiteral("\r\n                                            </th>\r\n                                            <th>\r\n                                                ");
            EndContext();
            BeginContext(3831, 58, false);
#line 78 "C:\Users\akinb\source\diag\NovoDiagnosis\Views\DiagnosisDetails\Index.cshtml"
                                           Write(Html.DisplayNameFor(model => model.CompletedAnnualMedical));

#line default
#line hidden
            EndContext();
            BeginContext(3889, 153, true);
            WriteLiteral("\r\n                                            </th>\r\n\r\n                                            <th>\r\n                                                ");
            EndContext();
            BeginContext(4043, 45, false);
#line 82 "C:\Users\akinb\source\diag\NovoDiagnosis\Views\DiagnosisDetails\Index.cshtml"
                                           Write(Html.DisplayNameFor(model => model.Diagnosis));

#line default
#line hidden
            EndContext();
            BeginContext(4088, 256, true);
            WriteLiteral(@"
                                            </th>


                                            <th></th>


                                        </tr>
                                    </thead>

                                    <tbody>
");
            EndContext();
#line 93 "C:\Users\akinb\source\diag\NovoDiagnosis\Views\DiagnosisDetails\Index.cshtml"
                                         foreach (var item in Model)
                                        {

#line default
#line hidden
            BeginContext(4457, 146, true);
            WriteLiteral("                                        <tr>\r\n\r\n                                            <td>\r\n                                                ");
            EndContext();
            BeginContext(4604, 43, false);
#line 98 "C:\Users\akinb\source\diag\NovoDiagnosis\Views\DiagnosisDetails\Index.cshtml"
                                           Write(Html.DisplayFor(modelItem => item.Provider));

#line default
#line hidden
            EndContext();
            BeginContext(4647, 151, true);
            WriteLiteral("\r\n                                            </td>\r\n                                            <td>\r\n                                                ");
            EndContext();
            BeginContext(4799, 40, false);
#line 101 "C:\Users\akinb\source\diag\NovoDiagnosis\Views\DiagnosisDetails\Index.cshtml"
                                           Write(Html.DisplayFor(modelItem => item.State));

#line default
#line hidden
            EndContext();
            BeginContext(4839, 151, true);
            WriteLiteral("\r\n                                            </td>\r\n                                            <td>\r\n                                                ");
            EndContext();
            BeginContext(4991, 40, false);
#line 104 "C:\Users\akinb\source\diag\NovoDiagnosis\Views\DiagnosisDetails\Index.cshtml"
                                           Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
            EndContext();
            BeginContext(5031, 151, true);
            WriteLiteral("\r\n                                            </td>\r\n                                            <td>\r\n                                                ");
            EndContext();
            BeginContext(5183, 46, false);
#line 107 "C:\Users\akinb\source\diag\NovoDiagnosis\Views\DiagnosisDetails\Index.cshtml"
                                           Write(Html.DisplayFor(modelItem => item.PhoneNumber));

#line default
#line hidden
            EndContext();
            BeginContext(5229, 151, true);
            WriteLiteral("\r\n                                            </td>\r\n                                            <td>\r\n                                                ");
            EndContext();
            BeginContext(5381, 50, false);
#line 110 "C:\Users\akinb\source\diag\NovoDiagnosis\Views\DiagnosisDetails\Index.cshtml"
                                           Write(Html.DisplayFor(modelItem => item.AppointmentDate));

#line default
#line hidden
            EndContext();
            BeginContext(5431, 151, true);
            WriteLiteral("\r\n                                            </td>\r\n                                            <td>\r\n                                                ");
            EndContext();
            BeginContext(5583, 50, false);
#line 113 "C:\Users\akinb\source\diag\NovoDiagnosis\Views\DiagnosisDetails\Index.cshtml"
                                           Write(Html.DisplayFor(modelItem => item.AppointmentTime));

#line default
#line hidden
            EndContext();
            BeginContext(5633, 105, true);
            WriteLiteral("\r\n                                            </td>\r\n                                            <td>\r\n\r\n");
            EndContext();
#line 117 "C:\Users\akinb\source\diag\NovoDiagnosis\Views\DiagnosisDetails\Index.cshtml"
                                                  
                                                    if (item.Approve == false)
                                                    {

#line default
#line hidden
            BeginContext(5925, 82, true);
            WriteLiteral("                                                        <p align=\"center\">No</p>\r\n");
            EndContext();
#line 121 "C:\Users\akinb\source\diag\NovoDiagnosis\Views\DiagnosisDetails\Index.cshtml"
                                                    }
                                                    else
                                                    {

#line default
#line hidden
            BeginContext(6175, 83, true);
            WriteLiteral("                                                        <p align=\"center\">Yes</p>\r\n");
            EndContext();
#line 125 "C:\Users\akinb\source\diag\NovoDiagnosis\Views\DiagnosisDetails\Index.cshtml"
                                                    }
                                                

#line default
#line hidden
            BeginContext(6364, 103, true);
            WriteLiteral("                                            </td>\r\n                                            <td>\r\n\r\n");
            EndContext();
#line 130 "C:\Users\akinb\source\diag\NovoDiagnosis\Views\DiagnosisDetails\Index.cshtml"
                                                  
                                                    if (item.Reject == false)
                                                    {

#line default
#line hidden
            BeginContext(6653, 82, true);
            WriteLiteral("                                                        <p align=\"center\">No</p>\r\n");
            EndContext();
#line 134 "C:\Users\akinb\source\diag\NovoDiagnosis\Views\DiagnosisDetails\Index.cshtml"
                                                    }
                                                    else
                                                    {

#line default
#line hidden
            BeginContext(6903, 83, true);
            WriteLiteral("                                                        <p align=\"center\">Yes</p>\r\n");
            EndContext();
#line 138 "C:\Users\akinb\source\diag\NovoDiagnosis\Views\DiagnosisDetails\Index.cshtml"
                                                    }
                                                

#line default
#line hidden
            BeginContext(7092, 151, true);
            WriteLiteral("                                            </td>\r\n\r\n                                            <td>\r\n                                                ");
            EndContext();
            BeginContext(7244, 49, false);
#line 143 "C:\Users\akinb\source\diag\NovoDiagnosis\Views\DiagnosisDetails\Index.cshtml"
                                           Write(Html.DisplayFor(modelItem => item.Recommendation));

#line default
#line hidden
            EndContext();
            BeginContext(7293, 103, true);
            WriteLiteral("\r\n                                            </td>\r\n                                            <td>\r\n");
            EndContext();
#line 146 "C:\Users\akinb\source\diag\NovoDiagnosis\Views\DiagnosisDetails\Index.cshtml"
                                                  
                                                    if (item.AuthorizationCode == null)
                                                    {

#line default
#line hidden
            BeginContext(7592, 87, true);
            WriteLiteral("                                                        <p align=\"center\">No Code</p>\r\n");
            EndContext();
#line 150 "C:\Users\akinb\source\diag\NovoDiagnosis\Views\DiagnosisDetails\Index.cshtml"
                                                    }
                                                    else
                                                    {
                                                        

#line default
#line hidden
            BeginContext(7904, 52, false);
#line 153 "C:\Users\akinb\source\diag\NovoDiagnosis\Views\DiagnosisDetails\Index.cshtml"
                                                   Write(Html.DisplayFor(modelItem => item.AuthorizationCode));

#line default
#line hidden
            EndContext();
#line 153 "C:\Users\akinb\source\diag\NovoDiagnosis\Views\DiagnosisDetails\Index.cshtml"
                                                                                                             
                                                    }
                                                

#line default
#line hidden
            BeginContext(8064, 101, true);
            WriteLiteral("                                            </td>\r\n                                            <td>\r\n");
            EndContext();
#line 158 "C:\Users\akinb\source\diag\NovoDiagnosis\Views\DiagnosisDetails\Index.cshtml"
                                                  
                                                    if (item.CompletedAnnualMedical == false)
                                                    {

#line default
#line hidden
            BeginContext(8367, 82, true);
            WriteLiteral("                                                        <p align=\"center\">No</p>\r\n");
            EndContext();
#line 162 "C:\Users\akinb\source\diag\NovoDiagnosis\Views\DiagnosisDetails\Index.cshtml"
                                                    }
                                                    else
                                                    {

#line default
#line hidden
            BeginContext(8617, 83, true);
            WriteLiteral("                                                        <p align=\"center\">Yes</p>\r\n");
            EndContext();
#line 166 "C:\Users\akinb\source\diag\NovoDiagnosis\Views\DiagnosisDetails\Index.cshtml"
                                                    }
                                                

#line default
#line hidden
            BeginContext(8806, 196, true);
            WriteLiteral("\r\n                                            </td>\r\n                                           \r\n                                            <td>\r\n                                                ");
            EndContext();
            BeginContext(9003, 44, false);
#line 172 "C:\Users\akinb\source\diag\NovoDiagnosis\Views\DiagnosisDetails\Index.cshtml"
                                           Write(Html.DisplayFor(modelItem => item.Diagnosis));

#line default
#line hidden
            EndContext();
            BeginContext(9047, 161, true);
            WriteLiteral("\r\n                                            </td>\r\n\r\n\r\n\r\n\r\n\r\n                                            <td>\r\n                                                ");
            EndContext();
            BeginContext(9208, 154, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e7bae2474d53456ba7490d8c29cb76ff", async() => {
                BeginContext(9325, 33, true);
                WriteLiteral("<i class=\"fa fa-pencil\"></i> Edit");
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
#line 180 "C:\Users\akinb\source\diag\NovoDiagnosis\Views\DiagnosisDetails\Index.cshtml"
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
            BeginContext(9362, 102, true);
            WriteLiteral("\r\n                                            </td>\r\n\r\n                                        </tr>\r\n");
            EndContext();
#line 184 "C:\Users\akinb\source\diag\NovoDiagnosis\Views\DiagnosisDetails\Index.cshtml"

                                        }

#line default
#line hidden
            BeginContext(9509, 564, true);
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
                BeginContext(10090, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(10096, 37, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c36c54b762c24e64869cee040dd8a8cc", async() => {
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
                BeginContext(10133, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            BeginContext(10138, 459, true);
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
