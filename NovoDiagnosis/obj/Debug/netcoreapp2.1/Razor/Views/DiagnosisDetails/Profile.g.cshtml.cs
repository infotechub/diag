#pragma checksum "C:\Users\akinb\source\repos\NovoDiagnosis\NovoDiagnosis\Views\DiagnosisDetails\Profile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "afb08ae34ece31450d5148cfb0461cc171d84589"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DiagnosisDetails_Profile), @"mvc.1.0.view", @"/Views/DiagnosisDetails/Profile.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/DiagnosisDetails/Profile.cshtml", typeof(AspNetCore.Views_DiagnosisDetails_Profile))]
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
#line 1 "C:\Users\akinb\source\repos\NovoDiagnosis\NovoDiagnosis\Views\DiagnosisDetails\Profile.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"afb08ae34ece31450d5148cfb0461cc171d84589", @"/Views/DiagnosisDetails/Profile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"22ba3f2932ac4e7dcc082159f12ac909dc9162a4", @"/Views/_ViewImports.cshtml")]
    public class Views_DiagnosisDetails_Profile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/claim.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(38, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(144, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 6 "C:\Users\akinb\source\repos\NovoDiagnosis\NovoDiagnosis\Views\DiagnosisDetails\Profile.cshtml"
  

    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(202, 385, true);
            WriteLiteral(@"<link rel=""stylesheet"" type=""text/css"" href=""https://cdn.datatables.net/1.10.19/css/jquery.dataTables.min.css"">

<!--main content start-->
<section id=""main-content"">
    <section class=""wrapper"">
        <div class=""row mb"">
            <div class=""col-lg-12"">
                <!-- /form-panel -->
                <h3 align=""centre"" class=""text-center"">User's Profile</h3>

");
            EndContext();
#line 20 "C:\Users\akinb\source\repos\NovoDiagnosis\NovoDiagnosis\Views\DiagnosisDetails\Profile.cshtml"
                  
                    var user = await UserManager.GetUserAsync(User);

                

#line default
#line hidden
            BeginContext(698, 748, true);
            WriteLiteral(@"
                <div class=""row mb"">

                    <div class=""col-md-12"">
                        <!-- page start-->
                        <div class=""content-panel border rounded"">
                            <br />
                            <br />
                            <br />
                            <br />
                            <div class=""adv-table"">
                                <table cellpadding=""0"" cellspacing=""0"" border=""0"" class=""display table table-bordered"" id=""claims"" width=""70%"">
                                    <thead>
                                        <tr>

                                            <td>Full Name: </td>
                                            <td>");
            EndContext();
            BeginContext(1447, 13, false);
#line 40 "C:\Users\akinb\source\repos\NovoDiagnosis\NovoDiagnosis\Views\DiagnosisDetails\Profile.cshtml"
                                           Write(user.FullName);

#line default
#line hidden
            EndContext();
            BeginContext(1460, 129, true);
            WriteLiteral("</td>\r\n                                        </tr>\r\n                                        <tr>  <td>Email Address: </td><td> ");
            EndContext();
            BeginContext(1590, 10, false);
#line 42 "C:\Users\akinb\source\repos\NovoDiagnosis\NovoDiagnosis\Views\DiagnosisDetails\Profile.cshtml"
                                                                      Write(user.Email);

#line default
#line hidden
            EndContext();
            BeginContext(1600, 80, true);
            WriteLiteral("</td></tr>\r\n                                        <tr><td>Staff Id:</td><td>  ");
            EndContext();
            BeginContext(1681, 12, false);
#line 43 "C:\Users\akinb\source\repos\NovoDiagnosis\NovoDiagnosis\Views\DiagnosisDetails\Profile.cshtml"
                                                               Write(user.StaffId);

#line default
#line hidden
            EndContext();
            BeginContext(1693, 84, true);
            WriteLiteral("</td></tr>\r\n                                        <tr><td>Phone Number: </td><td> ");
            EndContext();
            BeginContext(1778, 16, false);
#line 44 "C:\Users\akinb\source\repos\NovoDiagnosis\NovoDiagnosis\Views\DiagnosisDetails\Profile.cshtml"
                                                                   Write(user.PhoneNumber);

#line default
#line hidden
            EndContext();
            BeginContext(1794, 204, true);
            WriteLiteral("</td></tr>\r\n                                        <tr><td>Password: </td>\r\n                                    <td>************</td> </tr>\r\n                                    <tr>  <td>City: </td><td> ");
            EndContext();
            BeginContext(1999, 9, false);
#line 47 "C:\Users\akinb\source\repos\NovoDiagnosis\NovoDiagnosis\Views\DiagnosisDetails\Profile.cshtml"
                                                         Write(user.City);

#line default
#line hidden
            EndContext();
            BeginContext(2008, 73, true);
            WriteLiteral("</td></tr>\r\n                                    <tr><td>State:</td><td>  ");
            EndContext();
            BeginContext(2082, 10, false);
#line 48 "C:\Users\akinb\source\repos\NovoDiagnosis\NovoDiagnosis\Views\DiagnosisDetails\Profile.cshtml"
                                                        Write(user.State);

#line default
#line hidden
            EndContext();
            BeginContext(2092, 75, true);
            WriteLiteral("</td></tr>\r\n                                    <tr><td>Country: </td><td> ");
            EndContext();
            BeginContext(2168, 12, false);
#line 49 "C:\Users\akinb\source\repos\NovoDiagnosis\NovoDiagnosis\Views\DiagnosisDetails\Profile.cshtml"
                                                          Write(user.Country);

#line default
#line hidden
            EndContext();
            BeginContext(2180, 2852, true);
            WriteLiteral(@"</td></tr>



                                    </h4>

                                    </tr>
                                    </thead>
                                </table>


                                            <br />
                                            <br />
                                            <br />
                                            <br />
                                            <br />
                                            <br />
                                            <br />
                                            <br />
                                            <br />
                                            <br />
                                            <br />
                                            <br />
                                            <br />
                                            <br />
                                            <br />
                                            <b");
            WriteLiteral(@"r />
                                            <br />
                                            <br />
                                            <br />
                                            <br />
                                            <br />
                                            <br />
                                            <br />
                                            <br />
                                            <br />
                                </table>
                            </div>

                            <div class=""col-md-5"">

                                <br />
                                <br />
                                <br />
                                <br />
                                <br />
                                <br />
                                <br />
                                <br />
                                <br />
                                <br />
                ");
            WriteLiteral(@"                <br />
                                <br />
                                <br />
                                <br />
                                <br />
                                <br />
                                <br />
                                <br />
                                <br />
                                <br />
                                <br />
                                <br />
                                <br />
                                <br />
                                <br />

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
                BeginContext(5049, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(5055, 37, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6badd93f0e93448aaeb5be614ed7fa6a", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(5092, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            BeginContext(5097, 459, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591