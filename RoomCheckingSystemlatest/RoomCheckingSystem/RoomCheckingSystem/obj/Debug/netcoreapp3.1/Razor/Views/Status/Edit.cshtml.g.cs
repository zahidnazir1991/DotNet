#pragma checksum "D:\Home\RoomCheckingSystemlatest\RoomCheckingSystem\RoomCheckingSystem\Views\Status\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4bc6900fc8db01784e2c7bbfd565070e4980f642"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Status_Edit), @"mvc.1.0.view", @"/Views/Status/Edit.cshtml")]
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
#line 1 "D:\Home\RoomCheckingSystemlatest\RoomCheckingSystem\RoomCheckingSystem\Views\_ViewImports.cshtml"
using RoomCheckingSystem;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\Home\RoomCheckingSystemlatest\RoomCheckingSystem\RoomCheckingSystem\Views\Status\Edit.cshtml"
using RoomCheckingSystem.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4bc6900fc8db01784e2c7bbfd565070e4980f642", @"/Views/Status/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8d45131c291c8e3ddfd71b7423b4d6c14b4ec6c8", @"/Views/_ViewImports.cshtml")]
    public class Views_Status_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RoomStatus>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/dist/css/fontawesome-iconpicker.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/webthemes.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/gridstyleing.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/dist/js/fontawesome-iconpicker.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<link href=\"//netdna.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css\" rel=\"stylesheet\">\r\n<link href=\"https://use.fontawesome.com/releases/v5.0.7/css/all.css\" rel=\"stylesheet\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4bc6900fc8db01784e2c7bbfd565070e4980f6425570", async() => {
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
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4bc6900fc8db01784e2c7bbfd565070e4980f6426688", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4bc6900fc8db01784e2c7bbfd565070e4980f6427802", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
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

    .h1, h1 {
        font-size: 1.4rem;
        margin-left: 5px;
    }

    .h1, h1 {
        font-size: 2.5rem;
    }

    .h1, .h2, .h3, .h4, .h5, .h6, h1, h2, h3, h4, h5, h6 {
        margin-bottom: .5rem;
        font-family: inherit;
        font-weight: 500;
        line-height: 1.1;
        color: inherit;
    }

    h1, h2, h3, h4, h5, h6 {
        margin-top: 0px;
        margin-bottom: .5rem;
    }

    h1 {
        font-size: 1.4em;
        margin: .67em 0;
        margin: .67em 0;
        margin-top: 0.67em;
        margin-bottom: 0.67em;
        margin-left: 0px;
        margin-top: -0.33em;
        margin-bottom: 0.67em;
        margin-left: 0px;
    }

    label {
        display: inline-block;
        margin-bottom: 0px;
        font-weight: bold;
        font-size: 14px;
        display: inline-block;
        float: left;
        margin-left: 5px;
        margin-bottom: 5px;
    }

    select.form-control:not([size]):");
            WriteLiteral(@"not([multiple]) {
        height: calc(3.15rem + 0px);
    }

    .form-control {
        display: block;
        width: 100%;
        padding: .5rem .75rem;
        color: #464a4c;
        background-color: #fff;
        background-image: none;
        -webkit-background-clip: padding-box;
        background-clip: padding-box;
        border: 1px solid rgba(0,0,0,.15);
        border-radius: .25rem;
        font-size: 14px;
        -webkit-transition: border-color ease-in-out .15s,-webkit-box-shadow ease-in-out .15s;
        transition: border-color ease-in-out .15s,-webkit-box-shadow ease-in-out .15s;
        -o-transition: border-color ease-in-out .15s,box-shadow ease-in-out .15s;
        transition: border-color ease-in-out .15s,box-shadow ease-in-out .15s;
        transition: border-color ease-in-out .15s,box-shadow ease-in-out .15s,-webkit-box-shadow ease-in-out .15s;
    }
</style>
<div class=""container-fluid-custom"" style=""margin-left:20px;"">
    <div class=""box ml-sm-1 mr-sm-1");
            WriteLiteral(@""" style=""padding: 10px;"">

        <div class=""row"">
            <div class=""col-sm-4"">
                <h1>
                    Room Status ( HOUSE-KEEPING )
                    <small>Add</small>
                </h1>
            </div>
        </div>
");
#nullable restore
#line 96 "D:\Home\RoomCheckingSystemlatest\RoomCheckingSystem\RoomCheckingSystem\Views\Status\Edit.cshtml"
         using (Html.BeginForm())
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 98 "D:\Home\RoomCheckingSystemlatest\RoomCheckingSystem\RoomCheckingSystem\Views\Status\Edit.cshtml"
       Write(Html.HiddenFor(m => m.intSeqID));

#line default
#line hidden
#nullable disable
#nullable restore
#line 99 "D:\Home\RoomCheckingSystemlatest\RoomCheckingSystem\RoomCheckingSystem\Views\Status\Edit.cshtml"
       Write(Html.HiddenFor(m => m.intParentID));

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"row\" style=\"margin-top:20px;\">\r\n                <div class=\"col-sm-2\">\r\n                    <div class=\"form-group\">\r\n                        <label for=\"active\">\r\n\r\n                            ");
#nullable restore
#line 105 "D:\Home\RoomCheckingSystemlatest\RoomCheckingSystem\RoomCheckingSystem\Views\Status\Edit.cshtml"
                       Write(Html.CheckBoxFor(model => model.isActive, new { @id = "chkactive" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            Active
                        </label>
                    </div>
                </div>
                <div class=""col-sm-2"">
                    <div class=""form-group"">
                        <label for=""is_on_dashboard"">

                            ");
#nullable restore
#line 114 "D:\Home\RoomCheckingSystemlatest\RoomCheckingSystem\RoomCheckingSystem\Views\Status\Edit.cshtml"
                       Write(Html.CheckBoxFor(model => model.isShowCount, new { @id = "chkactive" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            Show count box in dashboard summary area
                        </label>
                    </div>
                </div>
                <div class=""col-sm-2"">
                    <div class=""form-group"">
                        <label for=""is_to_count_in_total"">

                            ");
#nullable restore
#line 123 "D:\Home\RoomCheckingSystemlatest\RoomCheckingSystem\RoomCheckingSystem\Views\Status\Edit.cshtml"
                       Write(Html.CheckBoxFor(model => model.isRunningCount, new { @id = "chkactive" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            Count in running and total boxes of dashboard
                        </label>
                    </div>
                </div>
                <div class=""col-sm-2"">
                    <div class=""form-group"">
                        <label for=""is_note_time_spent"">
                            ");
#nullable restore
#line 131 "D:\Home\RoomCheckingSystemlatest\RoomCheckingSystem\RoomCheckingSystem\Views\Status\Edit.cshtml"
                       Write(Html.CheckBoxFor(model => model.isTimeSpent, new { @id = "chkactive" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

                            Note time spent
                        </label>
                    </div>
                </div>
                <div class=""col-sm-2"">
                    <div class=""form-group"">
                        <label for=""is_to_note_priority"">

                            ");
#nullable restore
#line 141 "D:\Home\RoomCheckingSystemlatest\RoomCheckingSystem\RoomCheckingSystem\Views\Status\Edit.cshtml"
                       Write(Html.CheckBoxFor(model => model.isPriority, new { @id = "chkactive" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            Note priority in this status
                        </label>
                    </div>
                </div>
                <div class=""col-sm-2"">
                    <div class=""form-group"">
                        <label for=""is_to_note_checkout_time"">

                            ");
#nullable restore
#line 150 "D:\Home\RoomCheckingSystemlatest\RoomCheckingSystem\RoomCheckingSystem\Views\Status\Edit.cshtml"
                       Write(Html.CheckBoxFor(model => model.isCheckoutTime, new { @id = "chkactive" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            Note checkout time in this status\r\n                        </label>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
            WriteLiteral("            <div class=\"row\">\r\n                <div class=\"col-sm-4\">\r\n                    <div class=\"form-group\">\r\n                        <label for=\"status_label\">Status Label</label>\r\n                        ");
#nullable restore
#line 162 "D:\Home\RoomCheckingSystemlatest\RoomCheckingSystem\RoomCheckingSystem\Views\Status\Edit.cshtml"
                   Write(Html.TextBoxFor(m => m.StatusName, new { @class = "form-control removeshadow", autocomplete = "off", placeholder = "Status Name", }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral(@"                    </div>
                </div>
                <div class=""col-sm-5"">
                    <div class=""form-group"">
                        <label for=""parent_id"">Is Sequence Status? If yes, then what is its parent status</label>
                        ");
#nullable restore
#line 169 "D:\Home\RoomCheckingSystemlatest\RoomCheckingSystem\RoomCheckingSystem\Views\Status\Edit.cshtml"
                   Write(Html.DropDownListFor(model => model.intSeqID, ViewBag.statusList as SelectList, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                    </div>\r\n                </div>\r\n                <div class=\"col-sm-3\">\r\n                    <div class=\"form-group\">\r\n                        <label for=\"status_color\">Status Color</label>\r\n                        ");
#nullable restore
#line 176 "D:\Home\RoomCheckingSystemlatest\RoomCheckingSystem\RoomCheckingSystem\Views\Status\Edit.cshtml"
                   Write(Html.TextBoxFor(m => m.StatusColor, new { @class = "form-control removeshadow", autocomplete = "off", placeholder = "Status color", @type = "color" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
            WriteLiteral("            <div class=\"row\">\r\n                <div class=\"col-sm-4\">\r\n                    <div class=\"form-group\">\r\n                        <label for=\"status_icon_type\">Status Icon Type</label>\r\n                        ");
#nullable restore
#line 187 "D:\Home\RoomCheckingSystemlatest\RoomCheckingSystem\RoomCheckingSystem\Views\Status\Edit.cshtml"
                   Write(Html.DropDownListFor(model => model.intIconType, ViewBag.icontypelist as SelectList, new { @class = "form-control", onchange = "Showhideicondiv();", id = "drpicon" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

                    </div>
                </div>
                <div class=""col-sm-4"" id=""js-status_img_icon"" style=""display: none;"">
                    <label for=""status_icon_img"">Status Image Icon (Recommended size is 38 x 38)</label>
                    <div class=""input-group"">
                        <input type=""hidden"" name=""status_icon_img_data""");
            BeginWriteAttribute("value", " value=\"", 7549, "\"", 7557, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        <input name=""status_icon_img"" id=""status_icon_img"" class=""form-control"" type=""file"" accept="".jpg,.png,.jpeg"">
                    </div>
                </div>
                <div class=""col-sm-4"" id=""js-status_fa_icon"" style=""display:block"">
                    <label for=""status_color"">Select Icon</label>
                    <div class=""input-group"">
");
            WriteLiteral("                        ");
#nullable restore
#line 203 "D:\Home\RoomCheckingSystemlatest\RoomCheckingSystem\RoomCheckingSystem\Views\Status\Edit.cshtml"
                   Write(Html.TextBoxFor(m => m.icon, new { id = "txticon", @class = "form-control removeshadow icp icp-auto", autocomplete = "off", placeholder = "Status Name", @type = "text" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        <span class=""input-group-addon""></span>
                    </div>

                </div>
                <div class=""col-sm-4"">
                    <div class=""form-group"">
                        <label for=""task_score"">Task Score</label>
                        ");
#nullable restore
#line 211 "D:\Home\RoomCheckingSystemlatest\RoomCheckingSystem\RoomCheckingSystem\Views\Status\Edit.cshtml"
                   Write(Html.TextBoxFor(m => m.TaskScore, new { @class = "form-control removeshadow", autocomplete = "off", placeholder = "Task Score", id = "txticon" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("                    </div>\r\n                </div>\r\n            </div>\r\n");
            WriteLiteral(@"            <div class=""row"" name=""room_status_right"" style=""margin-top:20px;"">
                <div class=""col-sm-6"">
                    <div class=""form-group"">
                        <label for=""room_status_right"">Choose Who can change room status to this right</label>

                    </div>
                </div>
            </div>
            <div class=""row"" name=""room_status_right"" style=""margin-top:0px;"">
                <div class=""col-sm-6"">
                    <div class=""form-group"">
                        <label for=""room_status_right_2"">

                            ");
#nullable restore
#line 230 "D:\Home\RoomCheckingSystemlatest\RoomCheckingSystem\RoomCheckingSystem\Views\Status\Edit.cshtml"
                       Write(Html.CheckBoxFor(model => model.isReception, new { @id = "chkactive" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            Reception\r\n                        </label>\r\n                    </div>\r\n                </div>\r\n\r\n            </div>\r\n");
            WriteLiteral("            <div class=\"row\" name=\"room_status_right\" style=\"margin-top:0px;\">\r\n                <div class=\"col-sm-6\">\r\n                    <div class=\"form-group\">\r\n                        <label for=\"room_status_right_3\">\r\n\r\n                            ");
#nullable restore
#line 243 "D:\Home\RoomCheckingSystemlatest\RoomCheckingSystem\RoomCheckingSystem\Views\Status\Edit.cshtml"
                       Write(Html.CheckBoxFor(model => model.isHouseKeeping, new { @id = "chkactive" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            House Keeping
                        </label>
                    </div>
                </div>

            </div>
            <div class=""row"" name=""room_status_right"" style=""margin-top:0px;"">
                <div class=""col-sm-6"">
                    <div class=""form-group"">
                        <label for=""room_status_right_4"">

                            ");
#nullable restore
#line 255 "D:\Home\RoomCheckingSystemlatest\RoomCheckingSystem\RoomCheckingSystem\Views\Status\Edit.cshtml"
                       Write(Html.CheckBoxFor(model => model.isSupervisor, new { @id = "chkactive" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            Supervisor
                        </label>
                    </div>
                </div>

            </div>
            <div class=""row"" name=""room_status_right"" style=""margin-top:0px; "">
                <div class=""col-sm-6"">
                    <div class=""form-group"">
                        <label for=""room_status_right_5"">
                            ");
#nullable restore
#line 266 "D:\Home\RoomCheckingSystemlatest\RoomCheckingSystem\RoomCheckingSystem\Views\Status\Edit.cshtml"
                       Write(Html.CheckBoxFor(model => model.isMaintenance, new { @id = "chkactive" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

                            Maintenance
                        </label>
                    </div>
                </div>

            </div>
            <div class=""row"" style=""text-align: center"">
                <div class=""col-md-5 offset-md-3 mb-5"">
                    <button type=""button"" class=""btn btn-default cancelButton"">Back</button>
                    <button type=""submit"" id=""btnSave"" class=""btn btn-primary myButton"">Update</button>


                </div>
            </div>
");
#nullable restore
#line 282 "D:\Home\RoomCheckingSystemlatest\RoomCheckingSystem\RoomCheckingSystem\Views\Status\Edit.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    </div>

    <script type=""text/javascript"">
            function Showhideicondiv() {

                var x = document.getElementById(""drpicon"").value;

                if (x == ""1"") {
                    document.getElementById(""js-status_img_icon"").style.display = ""block"";
                    document.getElementById(""js-status_fa_icon"").style.display = ""none"";
                } else {
                    document.getElementById(""js-status_fa_icon"").style.display = ""block"";
                    document.getElementById(""js-status_img_icon"").style.display = ""none"";
                }

                //document.getElementById(""demo"").innerHTML = ""You selected: "" + x;

            }
            //$('.demo').iconpicker(


            //);

    </script>

    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4bc6900fc8db01784e2c7bbfd565070e4980f64225670", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4bc6900fc8db01784e2c7bbfd565070e4980f64226714", async() => {
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
            WriteLiteral(@"
    <script type=""text/javascript"">
            //document.getElementById(""txticon"").value = ""fas fa-archive"";
            $('.icp-auto').iconpicker();
                                                    // here social-icon is the input class name, you can change the class name, give same class name which class name have in your input box.
    </script>






</div>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RoomStatus> Html { get; private set; }
    }
}
#pragma warning restore 1591