#pragma checksum "D:\Home\RoomCheckingSystemlatest\RoomCheckingSystem\RoomCheckingSystem\Views\Shift\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "78f3bac3569b0baa5f2fa50b13ee8838426cb494"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shift_Edit), @"mvc.1.0.view", @"/Views/Shift/Edit.cshtml")]
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
#line 1 "D:\Home\RoomCheckingSystemlatest\RoomCheckingSystem\RoomCheckingSystem\Views\Shift\Edit.cshtml"
using RoomCheckingSystem.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"78f3bac3569b0baa5f2fa50b13ee8838426cb494", @"/Views/Shift/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8d45131c291c8e3ddfd71b7423b4d6c14b4ec6c8", @"/Views/_ViewImports.cshtml")]
    public class Views_Shift_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Shift>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/gridstyleing.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"<style type=""text/css"">
    .form-group {
        margin-bottom: 15px;
    }

    label {
        display: inline-block;
        float: left;
    }

    /*.myButton {
        box-shadow: inset 0px 1px 3px 0px #91b8b3;
        background-color: #0062cc;
        border-radius: 5px;
        border: 1px solid #0062cc;
        display: inline-block;
        cursor: pointer;
        color: #ffffff;
        font-family: Arial;
        font-size: 15px;
        font-weight: bold;
        padding: 11px 23px;
        text-decoration: none;
        text-shadow: 0px -1px 0px #2b665e;
    }

        .myButton:hover {
            background-color: #367fa9;
        }

        .myButton:active {
            position: relative;
            top: 1px;
        }*/

    .myButton {
        box-shadow: inset 0px 1px 0px 0px #0062cc;
        background: linear-gradient(to bottom, #0062cc 5%, #0062cc 100%);
        background-color: #0062cc;
        border-radius: 6px;
        border: 1px solid");
            WriteLiteral(@" #0062cc;
        display: inline-block;
        cursor: pointer;
        font-family: Arial;
        font-size: 15px;
        font-weight: bold;
        padding: 6px 24px;
        text-decoration: none;
        color: #fff;
        text-shadow: 0px 1px 0px #0062cc;
    }

        .myButton:hover {
            background: linear-gradient(to bottom, #367fa9 5%, #0062cc 100%);
            background-color: #367fa9;
            color: #fff;
        }

        .myButton:active {
            position: relative;
            top: 1px;
            color: #fff;
            text-decoration: none;
            box-shadow: none !important;
        }

    .cancelButton {
        box-shadow: inset 0px 1px 0px 0px #ffffff;
        background: linear-gradient(to bottom, #ffffff 5%, #f6f6f6 100%);
        background-color: #ffffff;
        border-radius: 6px;
        border: 1px solid #dcdcdc;
        display: inline-block;
        cursor: pointer;
        color: #666666;
        font-family:");
            WriteLiteral(@" Arial;
        font-size: 15px;
        font-weight: bold;
        padding: 6px 24px;
        text-decoration: none;
        text-shadow: 0px 1px 0px #ffffff;
    }

        .cancelButton:hover {
            background: linear-gradient(to bottom, #f6f6f6 5%, #ffffff 100%);
            background-color: #f6f6f6;
        }

        .cancelButton:active {
            position: relative;
            top: 1px;
            text-decoration: none;
            box-shadow: none !important;
        }

    .removeshadow {
        text-decoration: none;
        box-shadow: none !important;
        font-size: 14px;
    }
</style>
");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "78f3bac3569b0baa5f2fa50b13ee8838426cb4946621", async() => {
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
<div class=""container-fluid-custom"">
    <div class=""box ml-sm-1 mr-sm-1"">
        <div class=""row"">
            <div class=""col-sm-2"">
                <h1>
                    Shift
                    <small>Add</small>
                </h1>
            </div>
        </div>
");
#nullable restore
#line 120 "D:\Home\RoomCheckingSystemlatest\RoomCheckingSystem\RoomCheckingSystem\Views\Shift\Edit.cshtml"
         using (Html.BeginForm())
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 122 "D:\Home\RoomCheckingSystemlatest\RoomCheckingSystem\RoomCheckingSystem\Views\Shift\Edit.cshtml"
       Write(Html.HiddenFor(m=> m.intSeqID));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <div class=""row"" style=""text-align: center"">
                <div class=""col-md-5 offset-md-3"">

                    <div class=""form-group ml-1 mr-1"">
                        <label class=""customlabel"" for=""building_name"">Shift Title</label>
                        ");
#nullable restore
#line 128 "D:\Home\RoomCheckingSystemlatest\RoomCheckingSystem\RoomCheckingSystem\Views\Shift\Edit.cshtml"
                   Write(Html.TextBoxFor(m => m.ShiftTitle, new { @class = "form-control removeshadow", autocomplete = "off", placeholder = "Shift Title", }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

                    </div>

                </div>
            </div>
            <div class=""row"" style=""text-align: center"">
                <div class=""col-md-5 offset-md-3"">

                    <div class=""form-group ml-1 mr-1"">
                        <label class=""customlabel"" for=""building_name"">Shift Timein</label>
");
#nullable restore
#line 139 "D:\Home\RoomCheckingSystemlatest\RoomCheckingSystem\RoomCheckingSystem\Views\Shift\Edit.cshtml"
                          
                            string deliveryDate = Model.ShiftTimeIn.ToString("HH:mm tt");
                        

#line default
#line hidden
#nullable disable
            WriteLiteral("                        ");
#nullable restore
#line 142 "D:\Home\RoomCheckingSystemlatest\RoomCheckingSystem\RoomCheckingSystem\Views\Shift\Edit.cshtml"
                   Write(Html.EditorFor(m => m.ShiftTimeIn, new { htmlAttributes = new { @class = "form-control removeshadow", autocomplete = "off", placeholder = "Shift Timein" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

                    </div>

                </div>
            </div>
            <div class=""row"" style=""text-align: center"">
                <div class=""col-md-5 offset-md-3"">

                    <div class=""form-group ml-1 mr-1"">
                        <label class=""customlabel"" for=""building_name"">Shift Timeout</label>

                        ");
#nullable restore
#line 154 "D:\Home\RoomCheckingSystemlatest\RoomCheckingSystem\RoomCheckingSystem\Views\Shift\Edit.cshtml"
                   Write(Html.EditorFor(m => m.ShiftTimeOut, new { htmlAttributes = new { @class = "form-control removeshadow", autocomplete = "off", placeholder = "Shift Timeout"} }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n\r\n                </div>\r\n            </div>\r\n");
            WriteLiteral("            <div class=\"row\" style=\"text-align: left\">\r\n                <div class=\"col-md-2 offset-md-3 mb-5\">\r\n                    <div class=\"custom-control custom-checkbox mb-3 removeshadow\">\r\n\r\n                        ");
#nullable restore
#line 165 "D:\Home\RoomCheckingSystemlatest\RoomCheckingSystem\RoomCheckingSystem\Views\Shift\Edit.cshtml"
                   Write(Html.CheckBoxFor(model => model.isActive, new { @id = "chkactive", @class = "custom-control-input" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <label class=\"custom-control-label\" for=\"chkactive\">Active</label>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
            WriteLiteral(@"            <div class=""row"" style=""text-align: center"">
                <div class=""col-md-5 offset-md-3 mb-5"">
                    <button type=""button"" class=""btn btn-default cancelButton"">Cancel</button>
                    <button type=""submit"" id=""btnSave"" class=""btn btn-primary myButton"">Update</button>


                </div>
            </div>
");
#nullable restore
#line 179 "D:\Home\RoomCheckingSystemlatest\RoomCheckingSystem\RoomCheckingSystem\Views\Shift\Edit.cshtml"

        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Shift> Html { get; private set; }
    }
}
#pragma warning restore 1591
