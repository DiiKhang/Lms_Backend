#pragma checksum "D:\Documents\.Net Core Projects\ISE\LMS\LMS\Lms_Backend\LMS\Areas\Admin\Views\Class\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fd5e46c13b622565a21edebd245b17f2189fbeee"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Class_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Class/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Class/Index.cshtml", typeof(AspNetCore.Areas_Admin_Views_Class_Index))]
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
#line 2 "D:\Documents\.Net Core Projects\ISE\LMS\LMS\Lms_Backend\LMS\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fd5e46c13b622565a21edebd245b17f2189fbeee", @"/Areas/Admin/Views/Class/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e003c7c229b1711abfdb2f5560af20c4ca0019b9", @"/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Class_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<LMS.Domain.Class>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "class", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "addClass", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "editClass", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "deleteClass", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Dashboard/assets/jqueryDataTable/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Dashboard/assets/jqueryDataTable/jquery.dataTables.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(38, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\Documents\.Net Core Projects\ISE\LMS\LMS\Lms_Backend\LMS\Areas\Admin\Views\Class\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Areas/Admin/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
            BeginContext(145, 1239, true);
            WriteLiteral(@"
<div class=""dashboard"" id=""dashboard"">
    <!-- Navbar -->
    <nav class=""navbar navbar-expand-lg navbar-transparent  bg-primary  navbar-absolute"">
        <div class=""container-fluid"">
            <div class=""navbar-wrapper"">
                <div class=""navbar-toggle"">
                    <button type=""button"" class=""navbar-toggler"">
                        <span class=""navbar-toggler-bar bar1""></span>
                        <span class=""navbar-toggler-bar bar2""></span>
                        <span class=""navbar-toggler-bar bar3""></span>
                    </button>
                </div>
                <a class=""navbar-brand"" href=""#pablo"">Class Info</a>
            </div>
            <button class=""navbar-toggler"" type=""button"" data-toggle=""collapse"" data-target=""#navigation"" aria-controls=""navigation-index"" aria-expanded=""false"" aria-label=""Toggle navigation"">
                <span class=""navbar-toggler-bar navbar-kebab""></span>
                <span class=""navbar-toggler-bar navbar");
            WriteLiteral("-kebab\"></span>\r\n                <span class=\"navbar-toggler-bar navbar-kebab\"></span>\r\n            </button>\r\n            <div class=\"collapse navbar-collapse justify-content-end\" id=\"navigation\">\r\n                ");
            EndContext();
            BeginContext(1384, 478, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "926f3502b46146a98468bef8ee5fdc7f", async() => {
                BeginContext(1390, 465, true);
                WriteLiteral(@"
                    <div class=""input-group no-border"">
                        <input type=""text"" value="""" class=""form-control"" placeholder=""Search..."">
                        <div class=""input-group-append"">
                            <div class=""input-group-text"">
                                <i class=""now-ui-icons ui-1_zoom-bold""></i>
                            </div>
                        </div>
                    </div>
                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1862, 3526, true);
            WriteLiteral(@"
                <ul class=""navbar-nav"">
                    <li class=""nav-item"">
                        <a class=""nav-link"" href=""#pablo"">
                            <i class=""now-ui-icons media-2_sound-wave""></i>
                            <p>
                                <span class=""d-lg-none d-md-block"">Stats</span>
                            </p>
                        </a>
                    </li>
                    <li class=""nav-item dropdown"">
                        <a class=""nav-link dropdown-toggle"" id=""navbarDropdownMenuLink"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                            <i class=""now-ui-icons location_world""></i>
                            <p>
                                <span class=""d-lg-none d-md-block"">Some Actions</span>
                            </p>
                        </a>
                        <div class=""dropdown-menu dropdown-menu-right"" aria-labelledby=""navbarDropdownMenuLink"">
                ");
            WriteLiteral(@"            <a class=""dropdown-item"" href=""#"">Action</a>
                            <a class=""dropdown-item"" href=""#"">Another action</a>
                            <a class=""dropdown-item"" href=""#"">Something else here</a>
                        </div>
                    </li>
                    <li class=""nav-item"">
                        <a class=""nav-link"" href=""#pablo"">
                            <i class=""now-ui-icons users_single-02""></i>
                            <p>
                                <span class=""d-lg-none d-md-block"">Account</span>
                            </p>
                        </a>
                    </li>
                </ul>
            </div>
        </div>
    </nav>
    <!-- End Navbar -->
    <div class=""panel-header panel-header-sm"">
    </div>
    <div class=""content"">
        <div class=""row"">
            <div class=""col-md-12"">
                <div class=""card"">

                    <div class=""container-fluid"">
                  ");
            WriteLiteral(@"      <div class=""table-responsive"">
                            <div class=""table-wrapper"">
                                <div class=""table-title"">
                                    <div class=""row"">
                                        <div class=""col-md-6"">
                                            <h2>Manage <b>Classes</b></h2>
                                        </div>
                                        <div class=""col-md-6 pull-right"">
                                            <a href=""#addClassModal"" class=""btn btn-success"" data-toggle=""modal""><i class=""material-icons"">&#xE147;</i> <span>Add New Class</span></a>
                                            <a href=""#deleteClassModal"" class=""btn btn-danger"" data-toggle=""modal""><i class=""material-icons"">&#xE15C;</i> <span>Delete</span></a>
                                        </div>
                                    </div>
                                </div>

                                <table id=""classpage"" c");
            WriteLiteral(@"lass=""display"" style=""width:100%"">
                                    <thead>
                                        <tr>
                                            <th>Class ID</th>
                                            <th>Class Name</th>
                                            <th>Action</th>
                                        </tr>
                                    </thead>
                                    <tbody>
");
            EndContext();
#line 104 "D:\Documents\.Net Core Projects\ISE\LMS\LMS\Lms_Backend\LMS\Areas\Admin\Views\Class\Index.cshtml"
                                         foreach (var item in Model)
                                        {

#line default
#line hidden
            BeginContext(5501, 102, true);
            WriteLiteral("                                            <tr>\r\n                                                <td>");
            EndContext();
            BeginContext(5604, 13, false);
#line 107 "D:\Documents\.Net Core Projects\ISE\LMS\LMS\Lms_Backend\LMS\Areas\Admin\Views\Class\Index.cshtml"
                                               Write(item.Class_Id);

#line default
#line hidden
            EndContext();
            BeginContext(5617, 59, true);
            WriteLiteral("</td>\r\n                                                <td>");
            EndContext();
            BeginContext(5677, 15, false);
#line 108 "D:\Documents\.Net Core Projects\ISE\LMS\LMS\Lms_Backend\LMS\Areas\Admin\Views\Class\Index.cshtml"
                                               Write(item.Class_Name);

#line default
#line hidden
            EndContext();
            BeginContext(5692, 729, true);
            WriteLiteral(@"</td>
                                                <td>
                                                    <a href=""#editClassModal"" class=""edit"" id=""edit"" data-toggle=""modal"">
                                                        <i class=""material-icons"" data-toggle=""tooltip"" title="""" data-original-title=""Edit""></i>
                                                    </a>

                                                    <a href=""#deleteClassModal"" class=""delete"" id=""delete"" data-toggle=""modal"">
                                                        <i class=""material-icons"" data-toggle=""tooltip"" title="""" data-original-title=""Delete""></i>
                                                    </a>

");
            EndContext();
            BeginContext(6509, 89, true);
            WriteLiteral("                                                    <input type=\"hidden\" class=\"Class_Id\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 6598, "\"", 6620, 1);
#line 119 "D:\Documents\.Net Core Projects\ISE\LMS\LMS\Lms_Backend\LMS\Areas\Admin\Views\Class\Index.cshtml"
WriteAttributeValue("", 6606, item.Class_Id, 6606, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(6621, 113, true);
            WriteLiteral(" />\r\n\r\n                                                </td>\r\n                                            </tr>\r\n");
            EndContext();
#line 123 "D:\Documents\.Net Core Projects\ISE\LMS\LMS\Lms_Backend\LMS\Areas\Admin\Views\Class\Index.cshtml"
                                        }

#line default
#line hidden
            BeginContext(6777, 525, true);
            WriteLiteral(@"                                    </tbody>
                                </table>
                                <div class=""clearfix"">

                                </div>
                            </div>
                        </div>
                        <!-- Add Modal HTML -->
                        <div id=""addClassModal"" class=""modal fade"">
                            <div class=""modal-dialog"">
                                <div class=""modal-content"">
                                    ");
            EndContext();
            BeginContext(7302, 1548, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6ae030ddebe74819b3f4f047ab08bf4f", async() => {
                BeginContext(7367, 400, true);
                WriteLiteral(@"
                                        <div class=""modal-header"">
                                            <h4 class=""modal-title"">Add Class</h4>
                                            <button type=""button"" class=""close"" data-dismiss=""modal"" aria-hidden=""true"">×</button>
                                        </div>
                                        <div class=""modal-body"">
");
                EndContext();
                BeginContext(8096, 747, true);
                WriteLiteral(@"                                            <div class=""form-group"">
                                                <label>Class Name</label>
                                                <input type=""text"" class=""form-control"" required="""" name=""Class_Name"">
                                            </div>
                                        </div>
                                        <div class=""modal-footer"">
                                            <input type=""button"" class=""btn btn-default"" data-dismiss=""modal"" value=""Cancel"">
                                            <input type=""submit"" class=""btn btn-success"" value=""Add"">
                                        </div>
                                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
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
            BeginContext(8850, 387, true);
            WriteLiteral(@"
                                </div>
                            </div>
                        </div>


                        <!-- Edit Modal HTML -->
                        <div id=""editClassModal"" class=""modal fade"">
                            <div class=""modal-dialog"">
                                <div class=""modal-content"">
                                    ");
            EndContext();
            BeginContext(9237, 1729, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bab8a75c59c6431e9a7ae8fde188c9a5", async() => {
                BeginContext(9303, 1409, true);
                WriteLiteral(@"
                                        <div class=""modal-header"">
                                            <h4 class=""modal-title"">Edit Class</h4>
                                            <button type=""button"" class=""close"" data-dismiss=""modal"" aria-hidden=""true"">×</button>
                                        </div>
                                        <div class=""modal-body"">
                                            <div class=""form-group"">
                                                <label>Class ID</label>
                                                <input type=""text"" class=""form-control"" required="""" id=""Class_Id"" disabled=""disabled"">
                                            </div>
                                            <div class=""form-group"">
                                                <label>Class Name</label>
                                                <input type=""text"" class=""form-control"" required="""" name=""Class_Name"" id=""Class_Name"">
           ");
                WriteLiteral(@"                                 </div>
                                        </div>
                                        <div class=""modal-footer"">
                                            <input type=""button"" class=""btn btn-default"" data-dismiss=""modal"" value=""Cancel"">
                                            <input type=""submit"" class=""btn btn-info"" value=""Save"">
");
                EndContext();
                BeginContext(10776, 183, true);
                WriteLiteral("                                            <input type=\"hidden\" name=\"Class_Id\" id=\"Class_Id\" />\r\n                                        </div>\r\n                                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(10966, 391, true);
            WriteLiteral(@"
                                </div>
                            </div>
                        </div>


                        <!-- Delete Modal HTML -->
                        <div id=""deleteClassModal"" class=""modal fade"">
                            <div class=""modal-dialog"">
                                <div class=""modal-content"">
                                    ");
            EndContext();
            BeginContext(11357, 1331, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e5aa2247436c40b2be297b542380a425", async() => {
                BeginContext(11425, 970, true);
                WriteLiteral(@"
                                        <div class=""modal-header"">
                                            <h4 class=""modal-title"">Delete Class</h4>
                                            <button type=""button"" class=""close"" data-dismiss=""modal"" aria-hidden=""true"">×</button>
                                        </div>
                                        <div class=""modal-body"">
                                            <p>Are you sure you want to delete these Records?</p>
                                            <p class=""text-warning""><small>This action cannot be undone.</small></p>
                                        </div>
                                        <div class=""modal-footer"">
                                            <input type=""button"" class=""btn btn-default"" data-dismiss=""modal"" value=""Cancel"">
                                            <input type=""submit"" class=""btn btn-danger"" value=""Delete"">

");
                EndContext();
                BeginContext(12496, 185, true);
                WriteLiteral("                                            <input type=\"hidden\" id=\"Class_Id\" name=\"Class_Id\" />\r\n\r\n                                        </div>\r\n                                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(12688, 1568, true);
            WriteLiteral(@"
                                </div>
                            </div>
                        </div>

                    </div>
                </div>
            </div>
        </div>




        <footer class=""footer"">
            <div class="" container-fluid "">
                <nav>
                    <ul>
                        <li>
                            <a href=""https://www.creative-tim.com"">
                                Karachi Grammar School
                            </a>
                        </li>
                        <li>
                            <a href=""http://presentation.creative-tim.com"">
                                About Us
                            </a>
                        </li>
                        <li>
                            <a href=""http://blog.creative-tim.com"">
                                Blog
                            </a>
                        </li>
                    </ul>
                </nav>
  ");
            WriteLiteral(@"              <div class=""copyright"" id=""copyright"">
                    &copy;
                    <script>
                        document.getElementById('copyright').appendChild(document.createTextNode(new Date().getFullYear()))
                    </script>, Designed by <a href=""https://www.invisionapp.com"" target=""_blank"">Invision</a>. Coded by <a href=""https://www.creative-tim.com"" target=""_blank"">Creative Tim</a>.
                </div>
            </div>
        </footer>
    </div>
</div>

<!--   Core JS Files   -->
");
            EndContext();
            BeginContext(14256, 72, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1228418044c547aab45726b9e2316980", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(14328, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(14330, 79, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f2b349e91cfc44c79d5e0e81d31660ab", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(14409, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(14476, 1718, true);
            WriteLiteral(@"<script>
    $(document).ready(function () {

        $('#classpage').DataTable();
        // Activate tooltip
        $('[data-toggle=""tooltip""]').tooltip();


        //Get Class_Id for Delete Added By Absar
        $('#classpage #delete').on('click', function () {
            var Class_Id = $(this).parent().find('.Class_Id').val();
            $('#deleteClassModal #Class_Id').val(Class_Id);
        });

        //Get Class_Id for Edit Added By Absar
        $('#classpage #edit').on('click', function () {
            var id = $(this).parent().find('.Class_Id').val();
            $.ajax({

                type: 'GET',
                url: '/admin/class/editClass/' + id,
                success: function (objClass) {
                    //debugger;
                    // objClass = JSON.stringify(objClass);

                    //alert(objClass);
                    $('#editClassModal #Class_Id').val(objClass.class_Id);
                    $('#editClassModal #Class_Name').val(objCla");
            WriteLiteral(@"ss.class_Name);

                }
            });
        });

        // Select/Deselect checkboxes
        var checkbox = $('table tbody input[type=""checkbox""]');
        $(""#selectAll"").click(function () {
            if (this.checked) {
                checkbox.each(function () {
                    this.checked = true;
                });
            } else {
                checkbox.each(function () {
                    this.checked = false;
                });
            }
        });
        checkbox.click(function () {
            if (!this.checked) {
                $(""#selectAll"").prop(""checked"", false);
            }
        });
    });
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<LMS.Domain.Class>> Html { get; private set; }
    }
}
#pragma warning restore 1591
