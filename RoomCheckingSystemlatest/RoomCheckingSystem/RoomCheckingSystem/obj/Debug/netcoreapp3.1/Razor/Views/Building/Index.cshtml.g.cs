#pragma checksum "D:\Home\workspace\RoomCheckingSystemlatest\RoomCheckingSystem\RoomCheckingSystem\Views\Building\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "09cb34ed4da58214f7fe17139b4756671c3f1fa8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Building_Index), @"mvc.1.0.view", @"/Views/Building/Index.cshtml")]
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
#line 1 "D:\Home\workspace\RoomCheckingSystemlatest\RoomCheckingSystem\RoomCheckingSystem\Views\Building\Index.cshtml"
using RoomCheckingSystem.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"09cb34ed4da58214f7fe17139b4756671c3f1fa8", @"/Views/Building/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8d45131c291c8e3ddfd71b7423b4d6c14b4ec6c8", @"/Views/_ViewImports.cshtml")]
    public class Views_Building_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Building>>
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "09cb34ed4da58214f7fe17139b4756671c3f1fa85548", async() => {
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
</style>
<div class=""container-fluid-custom"">
    <div class=""box"">
        <div style=""margin-top:10px;"" id=""dvgrid"">
           ");
            WriteLiteral(@" <div class=""row"">
                <div class=""col-sm-2"">
                    <h1>
                        Building
                        <small>List</small>
                    </h1>
                </div>
                <div class=""col-sm-2 offset-sm-8 mb-1"">
                    <a href=""/Building/Buildingadd"" class=""btn btn-primary btn-block margin-bottom"">Add New</a>
                </div>

            </div>
            <table id=""grid"" data-order='[[ 1, ""asc"" ]]' data-page-length='10' class=""display"" style=""width:100%;"">
                <thead style=""background-color:#fff"">
                    <tr>
                        <th style=""width:60px;"">#</th>
                        <th>Building Name</th>
                        <th>Is Active</th>
                        <th>Created At</th>
                        <th>Action</th>

                    </tr>
                </thead>

                <tbody>

");
#nullable restore
#line 140 "D:\Home\workspace\RoomCheckingSystemlatest\RoomCheckingSystem\RoomCheckingSystem\Views\Building\Index.cshtml"
                     foreach (Building building in Model)
                    {


#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 144 "D:\Home\workspace\RoomCheckingSystemlatest\RoomCheckingSystem\RoomCheckingSystem\Views\Building\Index.cshtml"
                       Write(building.intSeqID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 145 "D:\Home\workspace\RoomCheckingSystemlatest\RoomCheckingSystem\RoomCheckingSystem\Views\Building\Index.cshtml"
                       Write(building.Buildingtitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 146 "D:\Home\workspace\RoomCheckingSystemlatest\RoomCheckingSystem\RoomCheckingSystem\Views\Building\Index.cshtml"
                          
                            if (building.isActive)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <td><center>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "09cb34ed4da58214f7fe17139b4756671c3f1fa812141", async() => {
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
            WriteLiteral("</center></td>\r\n");
#nullable restore
#line 150 "D:\Home\workspace\RoomCheckingSystemlatest\RoomCheckingSystem\RoomCheckingSystem\Views\Building\Index.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <td><center>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "09cb34ed4da58214f7fe17139b4756671c3f1fa813548", async() => {
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
            WriteLiteral("</center></td>\r\n");
#nullable restore
#line 154 "D:\Home\workspace\RoomCheckingSystemlatest\RoomCheckingSystem\RoomCheckingSystem\Views\Building\Index.cshtml"
                            }

                        

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <td>");
#nullable restore
#line 158 "D:\Home\workspace\RoomCheckingSystemlatest\RoomCheckingSystem\RoomCheckingSystem\Views\Building\Index.cshtml"
                       Write(building.dtCreationDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 160 "D:\Home\workspace\RoomCheckingSystemlatest\RoomCheckingSystem\RoomCheckingSystem\Views\Building\Index.cshtml"
                       Write(Html.ActionLink("Edit", "Edit", "Building", new { id = building.intSeqID }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" &nbsp;\r\n                            ");
#nullable restore
#line 161 "D:\Home\workspace\RoomCheckingSystemlatest\RoomCheckingSystem\RoomCheckingSystem\Views\Building\Index.cshtml"
                       Write(Html.ActionLink("Delete", "Delete", "Building", new { id = building.intSeqID }, new { onclick = "return confirm('Are sure wants to delete?');" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n\r\n                    </tr>\r\n");
#nullable restore
#line 165 "D:\Home\workspace\RoomCheckingSystemlatest\RoomCheckingSystem\RoomCheckingSystem\Views\Building\Index.cshtml"


                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                </tbody>\r\n\r\n            </table>\r\n\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("environment", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "09cb34ed4da58214f7fe17139b4756671c3f1fa816421", async() => {
                WriteLiteral("\r\n                <script src=\"https://code.jquery.com/jquery-3.5.1.min.js\"></script>\r\n\r\n\r\n            ");
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
            WriteLiteral(@"
            <script type=""text/javascript"">
                $(document).ready(function () {
                    $('#grid').DataTable({
                        ""pagingType"": ""full_numbers""
                    });

                });

            </script>

            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "09cb34ed4da58214f7fe17139b4756671c3f1fa817997", async() => {
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
            WriteLiteral("\r\n\r\n        </div>\r\n\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Building>> Html { get; private set; }
    }
}
#pragma warning restore 1591
