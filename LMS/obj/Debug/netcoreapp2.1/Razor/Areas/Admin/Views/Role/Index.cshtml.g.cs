#pragma checksum "U:\Freelance Work\ISM\Lms_Backend\LMS\Areas\Admin\Views\Role\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "74a5e97e73d22308c8ae2c1f3b42f7b5eb1aaa99"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Role_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Role/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Role/Index.cshtml", typeof(AspNetCore.Areas_Admin_Views_Role_Index))]
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
#line 2 "U:\Freelance Work\ISM\Lms_Backend\LMS\Areas\Admin\Views\Role\Index.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"74a5e97e73d22308c8ae2c1f3b42f7b5eb1aaa99", @"/Areas/Admin/Views/Role/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e003c7c229b1711abfdb2f5560af20c4ca0019b9", @"/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Role_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<IdentityRole>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "role", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "addRole", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "editRole", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "deleteRole", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "U:\Freelance Work\ISM\Lms_Backend\LMS\Areas\Admin\Views\Role\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Areas/Admin/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
            BeginContext(178, 1239, true);
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
                <a class=""navbar-brand"" href=""#pablo"">Roles Info</a>
            </div>
            <button class=""navbar-toggler"" type=""button"" data-toggle=""collapse"" data-target=""#navigation"" aria-controls=""navigation-index"" aria-expanded=""false"" aria-label=""Toggle navigation"">
                <span class=""navbar-toggler-bar navbar-kebab""></span>
                <span class=""navbar-toggler-bar navbar");
            WriteLiteral("-kebab\"></span>\r\n                <span class=\"navbar-toggler-bar navbar-kebab\"></span>\r\n            </button>\r\n            <div class=\"collapse navbar-collapse justify-content-end\" id=\"navigation\">\r\n                ");
            EndContext();
            BeginContext(1417, 478, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d07c2ba50cac4c2f9e5c276ec3c800e3", async() => {
                BeginContext(1423, 465, true);
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
            BeginContext(1895, 3513, true);
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
                                            <h2>Manage <b>Roles</b></h2>
                                        </div>
                                        <div class=""col-md-6 pull-right"">
                                            <a href=""#addRoleModal"" class=""btn btn-success"" data-toggle=""modal""><i class=""material-icons"">&#xE147;</i> <span>Add New Role</span></a>
                                            <a href=""#deleteRoleModal"" class=""btn btn-danger"" data-toggle=""modal""><i class=""material-icons"">&#xE15C;</i> <span>Delete</span></a>
                                        </div>
                                    </div>
                                </div>

                                <table id=""rolepage"" class=""");
            WriteLiteral(@"display"" style=""width:100%"">
                                    <thead>
                                        <tr>
                                            <th>ID</th>
                                            <th>Role Name</th>
                                            <th>Action</th>
                                        </tr>
                                    </thead>
                                    <tbody>
");
            EndContext();
#line 104 "U:\Freelance Work\ISM\Lms_Backend\LMS\Areas\Admin\Views\Role\Index.cshtml"
                                         foreach (var item in Model)
                                        {

#line default
#line hidden
            BeginContext(5521, 102, true);
            WriteLiteral("                                            <tr>\r\n                                                <td>");
            EndContext();
            BeginContext(5624, 7, false);
#line 107 "U:\Freelance Work\ISM\Lms_Backend\LMS\Areas\Admin\Views\Role\Index.cshtml"
                                               Write(item.Id);

#line default
#line hidden
            EndContext();
            BeginContext(5631, 59, true);
            WriteLiteral("</td>\r\n                                                <td>");
            EndContext();
            BeginContext(5691, 9, false);
#line 108 "U:\Freelance Work\ISM\Lms_Backend\LMS\Areas\Admin\Views\Role\Index.cshtml"
                                               Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(5700, 727, true);
            WriteLiteral(@"</td>
                                                <td>
                                                    <a href=""#editRoleModal"" class=""edit"" id=""edit"" data-toggle=""modal"">
                                                        <i class=""material-icons"" data-toggle=""tooltip"" title="""" data-original-title=""Edit""></i>
                                                    </a>

                                                    <a href=""#deleteRoleModal"" class=""delete"" id=""delete"" data-toggle=""modal"">
                                                        <i class=""material-icons"" data-toggle=""tooltip"" title="""" data-original-title=""Delete""></i>
                                                    </a>

");
            EndContext();
            BeginContext(6515, 88, true);
            WriteLiteral("                                                    <input type=\"hidden\" class=\"Role_Id\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 6603, "\"", 6619, 1);
#line 119 "U:\Freelance Work\ISM\Lms_Backend\LMS\Areas\Admin\Views\Role\Index.cshtml"
WriteAttributeValue("", 6611, item.Id, 6611, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(6620, 113, true);
            WriteLiteral(" />\r\n\r\n                                                </td>\r\n                                            </tr>\r\n");
            EndContext();
#line 123 "U:\Freelance Work\ISM\Lms_Backend\LMS\Areas\Admin\Views\Role\Index.cshtml"
                                        }

#line default
#line hidden
            BeginContext(6776, 524, true);
            WriteLiteral(@"                                    </tbody>
                                </table>
                                <div class=""clearfix"">

                                </div>
                            </div>
                        </div>
                        <!-- Add Modal HTML -->
                        <div id=""addRoleModal"" class=""modal fade"">
                            <div class=""modal-dialog"">
                                <div class=""modal-content"">
                                    ");
            EndContext();
            BeginContext(7300, 1537, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a8dd684eaa134426ba2ac8862dc46c87", async() => {
                BeginContext(7363, 399, true);
                WriteLiteral(@"
                                        <div class=""modal-header"">
                                            <h4 class=""modal-title"">Add Role</h4>
                                            <button type=""button"" class=""close"" data-dismiss=""modal"" aria-hidden=""true"">×</button>
                                        </div>
                                        <div class=""modal-body"">
");
                EndContext();
                BeginContext(8090, 740, true);
                WriteLiteral(@"                                            <div class=""form-group"">
                                                <label>Role Name</label>
                                                <input type=""text"" class=""form-control"" required="""" name=""name"">
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
            BeginContext(8837, 386, true);
            WriteLiteral(@"
                                </div>
                            </div>
                        </div>


                        <!-- Edit Modal HTML -->
                        <div id=""editRoleModal"" class=""modal fade"">
                            <div class=""modal-dialog"">
                                <div class=""modal-content"">
                                    ");
            EndContext();
            BeginContext(9223, 1714, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e064e95a211642118ab49791a95dace9", async() => {
                BeginContext(9287, 1398, true);
                WriteLiteral(@"
                                        <div class=""modal-header"">
                                            <h4 class=""modal-title"">Edit Role</h4>
                                            <button type=""button"" class=""close"" data-dismiss=""modal"" aria-hidden=""true"">×</button>
                                        </div>
                                        <div class=""modal-body"">
                                            <div class=""form-group"">
                                                <label>ID</label>
                                                <input type=""text"" class=""form-control"" required="""" id=""Role_Id"" disabled=""disabled"">
                                            </div>
                                            <div class=""form-group"">
                                                <label>Role Name</label>
                                                <input type=""text"" class=""form-control"" required="""" name=""Role_Name"" id=""Role_Name"">
                      ");
                WriteLiteral(@"                      </div>
                                        </div>
                                        <div class=""modal-footer"">
                                            <input type=""button"" class=""btn btn-default"" data-dismiss=""modal"" value=""Cancel"">
                                            <input type=""submit"" class=""btn btn-info"" value=""Save"">
");
                EndContext();
                BeginContext(10749, 181, true);
                WriteLiteral("                                            <input type=\"hidden\" name=\"Role_Id\" id=\"Role_Id\" />\r\n                                        </div>\r\n                                    ");
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
            BeginContext(10937, 390, true);
            WriteLiteral(@"
                                </div>
                            </div>
                        </div>


                        <!-- Delete Modal HTML -->
                        <div id=""deleteRoleModal"" class=""modal fade"">
                            <div class=""modal-dialog"">
                                <div class=""modal-content"">
                                    ");
            EndContext();
            BeginContext(11327, 1326, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e2504073a9e2412cbbe455fd7acd9581", async() => {
                BeginContext(11393, 969, true);
                WriteLiteral(@"
                                        <div class=""modal-header"">
                                            <h4 class=""modal-title"">Delete Role</h4>
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
                BeginContext(12463, 183, true);
                WriteLiteral("                                            <input type=\"hidden\" id=\"Role_Id\" name=\"Role_Id\" />\r\n\r\n                                        </div>\r\n                                    ");
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
            BeginContext(12653, 1568, true);
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
            BeginContext(14221, 72, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "568dcba5f7cf4cea87f1f36486f0b532", async() => {
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
            BeginContext(14293, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(14295, 79, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "87f62ced1a75488abeb96cee4a639c32", async() => {
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
            BeginContext(14374, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(14441, 1686, true);
            WriteLiteral(@"<script>
    $(document).ready(function () {

        $('#rolepage').DataTable();
        // Activate tooltip
        $('[data-toggle=""tooltip""]').tooltip();


        //Get Role_Id for Delete Added By Absar
        $('#rolepage #delete').on('click', function () {
            var Role_Id = $(this).parent().find('.Role_Id').val();
            $('#deleteRoleModal #Role_Id').val(Role_Id);
        });

        //Get Role_Id for Edit Added By Absar
        $('#rolepage #edit').on('click', function () {
            var id = $(this).parent().find('.Role_Id').val();
            $.ajax({

                type: 'GET',
                url: '/admin/role/editRole/' + id,
                success: function (objRole) {
                    //debugger;
                    // objClass = JSON.stringify(objClass);

                    //alert(objClass);
                    $('#editRoleModal #Role_Id').val(objRole.id);
                    $('#editRoleModal #Role_Name').val(objRole.name);

             ");
            WriteLiteral(@"   }
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<IdentityRole>> Html { get; private set; }
    }
}
#pragma warning restore 1591
