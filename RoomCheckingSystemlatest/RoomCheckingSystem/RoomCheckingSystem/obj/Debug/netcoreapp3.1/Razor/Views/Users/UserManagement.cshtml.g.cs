#pragma checksum "D:\Home\workspace\RoomCheckingSystemlatest\RoomCheckingSystem\RoomCheckingSystem\Views\Users\UserManagement.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c306269d47eb4c569c2618585d8cf7c2fc3ec23d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Users_UserManagement), @"mvc.1.0.view", @"/Views/Users/UserManagement.cshtml")]
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
#nullable restore
#line 1 "D:\Home\workspace\RoomCheckingSystemlatest\RoomCheckingSystem\RoomCheckingSystem\Views\_ViewImports.cshtml"
using RoomCheckingSystem;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\Home\workspace\RoomCheckingSystemlatest\RoomCheckingSystem\RoomCheckingSystem\Views\Users\UserManagement.cshtml"
using RoomCheckingSystem.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c306269d47eb4c569c2618585d8cf7c2fc3ec23d", @"/Views/Users/UserManagement.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8d45131c291c8e3ddfd71b7423b4d6c14b4ec6c8", @"/Views/_ViewImports.cshtml")]
    public class Views_Users_UserManagement : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<User>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/gridstyleing.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/t.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/cross.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("names", "Development", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/jquery.dataTables.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.EnvironmentTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<link href=\"https://cdn.datatables.net/1.10.24/css/jquery.dataTables.min.css\" rel=\"stylesheet\" />\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c306269d47eb4c569c2618585d8cf7c2fc3ec23d5580", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<style type=""text/css"">

    .dataTables_wrapper {
        background: #605ca8;
        border: 1px solid #ddd;
        padding-top: 5px;
    }

    .dataTables_length {
        padding-left: 10px;
    }

    .dataTables_filter {
        padding-right: 10px;
    }

    table.dataTable.no-footer {
        border-bottom: 1px solid #111;
        font-size: 14px;
    }

    .dataTables_wrapper .dataTables_length select {
        border: 1px solid #aaa;
        border-radius: 3px;
        padding: 5px;
        background-color: #fff;
        padding: 4px;
        font-weight: bold;
    }

    .dataTables_wrapper .dataTables_filter input {
        border: 1px solid #aaa;
        border-radius: 3px;
        padding: 5px;
        background-color: #fff;
        margin-left: 3px;
        font-weight: bold;
    }

    .dataTables_wrapper .dataTables_paginate .paginate_button.disabled, .dataTables_wrapper .dataTables_paginate .paginate_button.disabled:hover, .dataTables_wrapper .");
            WriteLiteral(@"dataTables_paginate .paginate_button.disabled:active {
        cursor: default;
        color: #fff !important;
        border: 1px solid transparent;
        background: transparent;
        box-shadow: none;
    }

    .dataTables_wrapper .dataTables_paginate .paginate_button {
        box-sizing: border-box;
        display: inline-block;
        min-width: 1.5em;
        margin-left: 2px;
        text-align: center;
        text-decoration: none !important;
        cursor: pointer;
        *cursor: hand;
        color: #fff !important;
        border: 1px solid transparent;
        border-radius: 2px;
        font-size: 12px;
    }

    .dataTables_wrapper .dataTables_paginate .paginate_button {
        box-sizing: border-box;
        display: inline-block;
        min-width: 1.5em;
        padding: .5em 1em;
        margin-left: 2px;
        text-align: center;
        text-decoration: none !important;
        cursor: pointer;
        *cursor: hand;
        color: #fff !i");
            WriteLiteral(@"mportant;
        border: 1px solid transparent;
        border-radius: 2px;
    }

    dataTables_wrapper .dataTables_length, .dataTables_wrapper .dataTables_filter, .dataTables_wrapper .dataTables_info, .dataTables_wrapper .dataTables_processing, .dataTables_wrapper .dataTables_paginate {
        color: #fff;
    }

        .dataTables_wrapper .dataTables_paginate .paginate_button {
            padding: 0px;
            margin-right: 10px;
        }

    .dataTables_wrapper .dataTables_info {
        clear: both;
        float: left;
        padding-top: -0.245em;
        padding: 5px;
        margin-left: 10px;
    }

    .dataTables_wrapper .dataTables_length, .dataTables_wrapper .dataTables_filter, .dataTables_wrapper .dataTables_info, .dataTables_wrapper .dataTables_processing, .dataTables_wrapper .dataTables_paginate {
        color: #fff;
    }

    .bg-green, .callout.callout-success, .alert-success, .label-success, .modal-success .modal-body {
        background-color: #00");
            WriteLiteral(@"a65a !important;
    }

    .bg-red, .bg-yellow, .bg-aqua, .bg-blue, .bg-light-blue, .bg-green, .bg-navy, .bg-teal, .bg-olive, .bg-lime, .bg-orange, .bg-fuchsia, .bg-purple, .bg-maroon, .bg-black, .bg-red-active, .bg-yellow-active, .bg-aqua-active, .bg-blue-active, .bg-light-blue-active, .bg-green-active, .bg-navy-active, .bg-teal-active, .bg-olive-active, .bg-lime-active, .bg-orange-active, .bg-fuchsia-active, .bg-purple-active, .bg-maroon-active, .bg-black-active, .callout.callout-danger, .callout.callout-warning, .callout.callout-info, .callout.callout-success, .alert-success, .alert-danger, .alert-error, .alert-warning, .alert-info, .label-danger, .label-info, .label-warning, .label-primary, .label-success, .modal-primary .modal-body, .modal-primary .modal-header, .modal-primary .modal-footer, .modal-warning .modal-body, .modal-warning .modal-header, .modal-warning .modal-footer, .modal-info .modal-body, .modal-info .modal-header, .modal-info .modal-footer, .modal-success .modal-body, .modal-success .m");
            WriteLiteral(@"odal-header, .modal-success .modal-footer, .modal-danger .modal-body, .modal-danger .modal-header, .modal-danger .modal-footer {
        color: #fff !important;
    }

    .bg-yellow, .callout.callout-warning, .alert-warning, .label-warning, .modal-warning .modal-body {
        background-color: #f39c12 !important;
    }
</style>
<div class=""container-fluid-custom"">
    <div class=""box"">
        <div style=""margin-top:10px;"" id=""dvgrid"">

            <div class=""row"">
                <div class=""col-sm-3"">
                    <h1>
                        User
                        <small>List</small>
                    </h1>
                </div>

            </div>

            <div class=""row"">



                <div class=""col-sm-6 text-center offset-6"">
                    <a");
            BeginWriteAttribute("href", " href=\"", 5263, "\"", 5270, 0);
            EndWriteAttribute();
            WriteLiteral(" onclick=\"$(\'#full_screen_loader\').show()\" class=\"btn btn-primary  margin-bottom\">Import only non-existing entries from timestation</a>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 5430, "\"", 5437, 0);
            EndWriteAttribute();
            WriteLiteral(@" onclick=""$('#full_screen_loader').show()"" class=""btn btn-primary  margin-bottom"">Import all entries from timestation</a>

                </div>

            </div>
            <div class=""row mt-1"" style=""margin-right: 1.2rem !important"">
                <div class=""col-sm-1 offset-11"">
                    <a href=""/Users/NewUser"" class=""btn btn-primary margin-bottom"">Add New</a>
                </div>

            </div>
        </div>

        <table id=""grid"" data-order='[[ 1, ""asc"" ]]' data-page-length='10' class=""display"" style=""width:100%;"">
            <thead style=""background-color:#fff"">
                <tr>
                    <th style=""width:60px;"">#</th>
                    <th>First Name</th>
                    <th>Last Name</th>
                    <th>Email</th>
                    <th>Phone</th>
                    <th>Active</th>
                    <th>Last login</th>
                    <th>Action</th>

                </tr>
            </thead>
            <t");
            WriteLiteral("body>\r\n");
#nullable restore
#line 168 "D:\Home\workspace\RoomCheckingSystemlatest\RoomCheckingSystem\RoomCheckingSystem\Views\Users\UserManagement.cshtml"
                 foreach (User muser in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 171 "D:\Home\workspace\RoomCheckingSystemlatest\RoomCheckingSystem\RoomCheckingSystem\Views\Users\UserManagement.cshtml"
                       Write(muser.ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 172 "D:\Home\workspace\RoomCheckingSystemlatest\RoomCheckingSystem\RoomCheckingSystem\Views\Users\UserManagement.cshtml"
                       Write(muser.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td> ");
#nullable restore
#line 173 "D:\Home\workspace\RoomCheckingSystemlatest\RoomCheckingSystem\RoomCheckingSystem\Views\Users\UserManagement.cshtml"
                        Write(muser.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 174 "D:\Home\workspace\RoomCheckingSystemlatest\RoomCheckingSystem\RoomCheckingSystem\Views\Users\UserManagement.cshtml"
                       Write(muser.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 175 "D:\Home\workspace\RoomCheckingSystemlatest\RoomCheckingSystem\RoomCheckingSystem\Views\Users\UserManagement.cshtml"
                       Write(muser.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>\r\n");
#nullable restore
#line 177 "D:\Home\workspace\RoomCheckingSystemlatest\RoomCheckingSystem\RoomCheckingSystem\Views\Users\UserManagement.cshtml"
                              
                                if (muser.isActive == true)
                                {
                                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <center>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "c306269d47eb4c569c2618585d8cf7c2fc3ec23d15637", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</center>\r\n");
#nullable restore
#line 182 "D:\Home\workspace\RoomCheckingSystemlatest\RoomCheckingSystem\RoomCheckingSystem\Views\Users\UserManagement.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <center>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "c306269d47eb4c569c2618585d8cf7c2fc3ec23d17058", async() => {
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
            WriteLiteral("</center>\r\n");
#nullable restore
#line 186 "D:\Home\workspace\RoomCheckingSystemlatest\RoomCheckingSystem\RoomCheckingSystem\Views\Users\UserManagement.cshtml"

                                }

                            

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td");
            BeginWriteAttribute("class", " class=\"", 7402, "\"", 7410, 0);
            EndWriteAttribute();
            WriteLiteral("><center>\r\n    ");
#nullable restore
#line 193 "D:\Home\workspace\RoomCheckingSystemlatest\RoomCheckingSystem\RoomCheckingSystem\Views\Users\UserManagement.cshtml"
Write(Html.ActionLink("Edit", "UserEdit", "Users", new { id = muser.ID }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" &nbsp;\r\n                        ");
#nullable restore
#line 194 "D:\Home\workspace\RoomCheckingSystemlatest\RoomCheckingSystem\RoomCheckingSystem\Views\Users\UserManagement.cshtml"
                   Write(Html.ActionLink("Delete", "Delete", "Users", new { id = muser.ID }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </center></td>\r\n                        <td");
            BeginWriteAttribute("class", " class=\"", 7660, "\"", 7668, 0);
            EndWriteAttribute();
            WriteLiteral("><center><a");
            BeginWriteAttribute("href", " href=\"", 7680, "\"", 7687, 0);
            EndWriteAttribute();
            WriteLiteral(">See full activity</a></center></td>\r\n\r\n                    </tr>\r\n");
#nullable restore
#line 199 "D:\Home\workspace\RoomCheckingSystemlatest\RoomCheckingSystem\RoomCheckingSystem\Views\Users\UserManagement.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                   \r\n\r\n\r\n\r\n\r\n                </tbody>\r\n\r\n        </table>\r\n\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("environment", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c306269d47eb4c569c2618585d8cf7c2fc3ec23d20076", async() => {
                WriteLiteral("\r\n            <script src=\"https://code.jquery.com/jquery-3.5.1.min.js\"></script>\r\n\r\n\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.EnvironmentTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper.Names = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        <script type=\"text/javascript\">\r\n            $(document).ready(function () {\r\n                $(\'#grid\').DataTable({\r\n                    \"pagingType\": \"full_numbers\"\r\n                });\r\n\r\n            });\r\n\r\n        </script>\r\n\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c306269d47eb4c569c2618585d8cf7c2fc3ec23d21635", async() => {
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
            WriteLiteral("\r\n\r\n    </div>\r\n</div>\r\n    </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<User>> Html { get; private set; }
    }
}
#pragma warning restore 1591
