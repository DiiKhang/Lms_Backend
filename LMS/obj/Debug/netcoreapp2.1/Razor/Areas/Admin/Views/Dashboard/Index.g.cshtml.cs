#pragma checksum "D:\Documents\.Net Core Projects\ISE\LMS\BKP CODE\LMS\LMS\Areas\Admin\Views\Dashboard\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6abf84fe8116976eba189c8da0004f3845147bd3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Dashboard_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Dashboard/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Dashboard/Index.cshtml", typeof(AspNetCore.Areas_Admin_Views_Dashboard_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6abf84fe8116976eba189c8da0004f3845147bd3", @"/Areas/Admin/Views/Dashboard/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Dashboard_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "D:\Documents\.Net Core Projects\ISE\LMS\BKP CODE\LMS\LMS\Areas\Admin\Views\Dashboard\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Areas/Admin/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
            BeginContext(107, 1118, true);
            WriteLiteral(@"
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
            <a class=""navbar-brand"" href=""#pablo"">Dashboard</a>
        </div>
        <button class=""navbar-toggler"" type=""button"" data-toggle=""collapse"" data-target=""#navigation"" aria-controls=""navigation-index"" aria-expanded=""false"" aria-label=""Toggle navigation"">
            <span class=""navbar-toggler-bar navbar-kebab""></span>
            <span class=""navbar-toggler-bar navbar-kebab""></span>
            <span class=""navbar-toggler-bar navbar-kebab""></span>
        </button>
  ");
            WriteLiteral("      <div class=\"collapse navbar-collapse justify-content-end\" id=\"navigation\">\r\n            ");
            EndContext();
            BeginContext(1225, 442, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dc21f972ccf9428aaeb7242533fb596d", async() => {
                BeginContext(1231, 429, true);
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
            BeginContext(1667, 16559, true);
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
                        <a class=""dropdown-item"" href=""#"">Action</a>
              ");
            WriteLiteral(@"          <a class=""dropdown-item"" href=""#"">Another action</a>
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
<div class=""panel-header panel-header-lg"">
    <canvas id=""bigDashboardChart""></canvas>
</div>
<div class=""content"">
    <div class=""row"">
        <div class=""col-lg-4"">
            <div class=""card card-chart"">
                <div class=""card-header"">
                    <h5 class=""card-category"">Global Sales</h5>
                    <h4 class=""card-title"">Shipped Products</h4>
     ");
            WriteLiteral(@"               <div class=""dropdown"">
                        <button type=""button"" class=""btn btn-round btn-outline-default dropdown-toggle btn-simple btn-icon no-caret"" data-toggle=""dropdown"">
                            <i class=""now-ui-icons loader_gear""></i>
                        </button>
                        <div class=""dropdown-menu dropdown-menu-right"">
                            <a class=""dropdown-item"" href=""#"">Action</a>
                            <a class=""dropdown-item"" href=""#"">Another action</a>
                            <a class=""dropdown-item"" href=""#"">Something else here</a>
                            <a class=""dropdown-item text-danger"" href=""#"">Remove Data</a>
                        </div>
                    </div>
                </div>
                <div class=""card-body"">
                    <div class=""chart-area"">
                        <canvas id=""lineChartExample""></canvas>
                    </div>
                </div>
                <div class=");
            WriteLiteral(@"""card-footer"">
                    <div class=""stats"">
                        <i class=""now-ui-icons arrows-1_refresh-69""></i> Just Updated
                    </div>
                </div>
            </div>
        </div>
        <div class=""col-lg-4 col-md-6"">
            <div class=""card card-chart"">
                <div class=""card-header"">
                    <h5 class=""card-category"">2018 Sales</h5>
                    <h4 class=""card-title"">All products</h4>
                    <div class=""dropdown"">
                        <button type=""button"" class=""btn btn-round btn-outline-default dropdown-toggle btn-simple btn-icon no-caret"" data-toggle=""dropdown"">
                            <i class=""now-ui-icons loader_gear""></i>
                        </button>
                        <div class=""dropdown-menu dropdown-menu-right"">
                            <a class=""dropdown-item"" href=""#"">Action</a>
                            <a class=""dropdown-item"" href=""#"">Another action</a>
    ");
            WriteLiteral(@"                        <a class=""dropdown-item"" href=""#"">Something else here</a>
                            <a class=""dropdown-item text-danger"" href=""#"">Remove Data</a>
                        </div>
                    </div>
                </div>
                <div class=""card-body"">
                    <div class=""chart-area"">
                        <canvas id=""lineChartExampleWithNumbersAndGrid""></canvas>
                    </div>
                </div>
                <div class=""card-footer"">
                    <div class=""stats"">
                        <i class=""now-ui-icons arrows-1_refresh-69""></i> Just Updated
                    </div>
                </div>
            </div>
        </div>
        <div class=""col-lg-4 col-md-6"">
            <div class=""card card-chart"">
                <div class=""card-header"">
                    <h5 class=""card-category"">Email Statistics</h5>
                    <h4 class=""card-title"">24 Hours Performance</h4>
                </d");
            WriteLiteral(@"iv>
                <div class=""card-body"">
                    <div class=""chart-area"">
                        <canvas id=""barChartSimpleGradientsNumbers""></canvas>
                    </div>
                </div>
                <div class=""card-footer"">
                    <div class=""stats"">
                        <i class=""now-ui-icons ui-2_time-alarm""></i> Last 7 days
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class=""row"">
        <div class=""col-md-6"">
            <div class=""card  card-tasks"">
                <div class=""card-header "">
                    <h5 class=""card-category"">Backend development</h5>
                    <h4 class=""card-title"">Tasks</h4>
                </div>
                <div class=""card-body "">
                    <div class=""table-full-width table-responsive"">
                        <table class=""table"">
                            <tbody>
                                <tr>
        ");
            WriteLiteral(@"                            <td>
                                        <div class=""form-check"">
                                            <label class=""form-check-label"">
                                                <input class=""form-check-input"" type=""checkbox"" checked>
                                                <span class=""form-check-sign""></span>
                                            </label>
                                        </div>
                                    </td>
                                    <td class=""text-left"">Sign contract for ""What are conference organizers afraid of?""</td>
                                    <td class=""td-actions text-right"">
                                        <button type=""button"" rel=""tooltip"" title="""" class=""btn btn-info btn-round btn-icon btn-icon-mini btn-neutral"" data-original-title=""Edit Task"">
                                            <i class=""now-ui-icons ui-2_settings-90""></i>
                                  ");
            WriteLiteral(@"      </button>
                                        <button type=""button"" rel=""tooltip"" title="""" class=""btn btn-danger btn-round btn-icon btn-icon-mini btn-neutral"" data-original-title=""Remove"">
                                            <i class=""now-ui-icons ui-1_simple-remove""></i>
                                        </button>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <div class=""form-check"">
                                            <label class=""form-check-label"">
                                                <input class=""form-check-input"" type=""checkbox"">
                                                <span class=""form-check-sign""></span>
                                            </label>
                                        </div>
                                    </td>
                                    <td cla");
            WriteLiteral(@"ss=""text-left"">Lines From Great Russian Literature? Or E-mails From My Boss?</td>
                                    <td class=""td-actions text-right"">
                                        <button type=""button"" rel=""tooltip"" title="""" class=""btn btn-info btn-round btn-icon btn-icon-mini btn-neutral"" data-original-title=""Edit Task"">
                                            <i class=""now-ui-icons ui-2_settings-90""></i>
                                        </button>
                                        <button type=""button"" rel=""tooltip"" title="""" class=""btn btn-danger btn-round btn-icon btn-icon-mini btn-neutral"" data-original-title=""Remove"">
                                            <i class=""now-ui-icons ui-1_simple-remove""></i>
                                        </button>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <div class=""");
            WriteLiteral(@"form-check"">
                                            <label class=""form-check-label"">
                                                <input class=""form-check-input"" type=""checkbox"" checked>
                                                <span class=""form-check-sign""></span>
                                            </label>
                                        </div>
                                    </td>
                                    <td class=""text-left"">
                                        Flooded: One year later, assessing what was lost and what was found when a ravaging rain swept through metro Detroit
                                    </td>
                                    <td class=""td-actions text-right"">
                                        <button type=""button"" rel=""tooltip"" title="""" class=""btn btn-info btn-round btn-icon btn-icon-mini btn-neutral"" data-original-title=""Edit Task"">
                                            <i class=""now-ui-icons ui-2_sett");
            WriteLiteral(@"ings-90""></i>
                                        </button>
                                        <button type=""button"" rel=""tooltip"" title="""" class=""btn btn-danger btn-round btn-icon btn-icon-mini btn-neutral"" data-original-title=""Remove"">
                                            <i class=""now-ui-icons ui-1_simple-remove""></i>
                                        </button>
                                    </td>
                                </tr>
                            </tbody>
                        </table>
                    </div>
                </div>
                <div class=""card-footer "">
                    <hr>
                    <div class=""stats"">
                        <i class=""now-ui-icons loader_refresh spin""></i> Updated 3 minutes ago
                    </div>
                </div>
            </div>
        </div>
        <div class=""col-md-6"">
            <div class=""card"">
                <div class=""card-header"">
                    <h");
            WriteLiteral(@"5 class=""card-category"">All Persons List</h5>
                    <h4 class=""card-title""> Employees Stats</h4>
                </div>
                <div class=""card-body"">
                    <div class=""table-responsive"">
                        <table class=""table"">
                            <thead class="" text-primary"">
                            <th>
                                Name
                            </th>
                            <th>
                                Country
                            </th>
                            <th>
                                City
                            </th>
                            <th class=""text-right"">
                                Salary
                            </th>
                            </thead>
                            <tbody>
                                <tr>
                                    <td>
                                        Dakota Rice
                            ");
            WriteLiteral(@"        </td>
                                    <td>
                                        Niger
                                    </td>
                                    <td>
                                        Oud-Turnhout
                                    </td>
                                    <td class=""text-right"">
                                        $36,738
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        Minerva Hooper
                                    </td>
                                    <td>
                                        Curaçao
                                    </td>
                                    <td>
                                        Sinaai-Waas
                                    </td>
                                    <td class=""text-right"">
                                  ");
            WriteLiteral(@"      $23,789
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        Sage Rodriguez
                                    </td>
                                    <td>
                                        Netherlands
                                    </td>
                                    <td>
                                        Baileux
                                    </td>
                                    <td class=""text-right"">
                                        $56,142
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        Doris Greene
                                    </td>
                                    <td>
                                        Malawi
                 ");
            WriteLiteral(@"                   </td>
                                    <td>
                                        Feldkirchen in Kärnten
                                    </td>
                                    <td class=""text-right"">
                                        $63,542
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        Mason Porter
                                    </td>
                                    <td>
                                        Chile
                                    </td>
                                    <td>
                                        Gloucester
                                    </td>
                                    <td class=""text-right"">
                                        $78,615
                                    </td>
                                </tr>
                   ");
            WriteLiteral(@"         </tbody>
                        </table>
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
                        Creative Tim
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
        <div class=""copyright"" id=""copyright"">
            &copy;
            <script>document.getElementById('copyright').appendChild(document.createTextNode(new Date().getFullYear()))</script>, Designed by <a href=""https://");
            WriteLiteral("www.invisionapp.com\" target=\"_blank\">Invision</a>. Coded by <a href=\"https://www.creative-tim.com\" target=\"_blank\">Creative Tim</a>.\r\n        </div>\r\n    </div>\r\n</footer>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
