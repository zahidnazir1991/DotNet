#pragma checksum "D:\Home\workspace\RoomCheckingSystemlatest\RoomCheckingSystem\RoomCheckingSystem\Views\Rooms\Roomsadd.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cc90ea9a5b96b2992cc3a4cd29cee165270a1032"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Rooms_Roomsadd), @"mvc.1.0.view", @"/Views/Rooms/Roomsadd.cshtml")]
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
#line 1 "D:\Home\workspace\RoomCheckingSystemlatest\RoomCheckingSystem\RoomCheckingSystem\Views\Rooms\Roomsadd.cshtml"
using RoomCheckingSystem.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cc90ea9a5b96b2992cc3a4cd29cee165270a1032", @"/Views/Rooms/Roomsadd.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8d45131c291c8e3ddfd71b7423b4d6c14b4ec6c8", @"/Views/_ViewImports.cshtml")]
    public class Views_Rooms_Roomsadd : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Rooms>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/webthemes.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/gridstyleing.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "cc90ea9a5b96b2992cc3a4cd29cee165270a10324236", async() => {
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "cc90ea9a5b96b2992cc3a4cd29cee165270a10325350", async() => {
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
            WriteLiteral(@"

<div class=""container-fluid-custom"">
    <div class=""box ml-sm-1 mr-sm-1"">
        <div class=""row"">
            <div class=""col-sm-2"">
                <h1>
                    Building Room
                    <small>Add</small>
                </h1>
            </div>
        </div>
");
#nullable restore
#line 21 "D:\Home\workspace\RoomCheckingSystemlatest\RoomCheckingSystem\RoomCheckingSystem\Views\Rooms\Roomsadd.cshtml"
         using (Html.BeginForm())
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <div class=""row"" style=""text-align: center"">
                <div class=""col-md-5 offset-md-3"">

                    <div class=""form-group ml-1 mr-1"">
                        <label class=""customlabel"" for=""building_name"">Building</label>
                        ");
#nullable restore
#line 28 "D:\Home\workspace\RoomCheckingSystemlatest\RoomCheckingSystem\RoomCheckingSystem\Views\Rooms\Roomsadd.cshtml"
                   Write(Html.DropDownListFor(model => model.BuildingID, ViewBag.RoomsList as SelectList, "Select Building", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            WriteLiteral("                    </div>\r\n\r\n                </div>\r\n            </div>\r\n");
            WriteLiteral(@"            <div class=""row"" style=""text-align: center"">
                <div class=""col-md-5 offset-md-3"">

                    <div class=""form-group ml-1 mr-1"">
                        <label class=""customlabel"" for=""building_name"">Room Name</label>
                        ");
#nullable restore
#line 48 "D:\Home\workspace\RoomCheckingSystemlatest\RoomCheckingSystem\RoomCheckingSystem\Views\Rooms\Roomsadd.cshtml"
                   Write(Html.TextBoxFor(m => m.RoomName, new { @class = "form-control removeshadow", autocomplete = "off", placeholder = "Room Name", }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                    </div>\r\n\r\n                </div>\r\n            </div>\r\n");
            WriteLiteral(@"            <div class=""row"" style=""text-align: center"">
                <div class=""col-md-5 offset-md-3"">

                    <div class=""form-group ml-1 mr-1"">
                        <label class=""customlabel"" for=""building_name"">Room Floor</label>
                        ");
#nullable restore
#line 60 "D:\Home\workspace\RoomCheckingSystemlatest\RoomCheckingSystem\RoomCheckingSystem\Views\Rooms\Roomsadd.cshtml"
                   Write(Html.TextBoxFor(m => m.RoomFloor, new { @class = "form-control removeshadow", autocomplete = "off", placeholder = "Room Floor", }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

                    </div>

                </div>
                <div class=""col-md-3 m-auto"" style=""padding:10px; line-height: .9em;""><small style=""font-size:12px;text-align:left; margin-right: 10px;"">0 means Ground Floor, positive number means above ground floor, value in negative means basement floor and anything as string will be considered as floor name</small></div>
            </div>
");
            WriteLiteral(@"            <div class=""row"" style=""text-align: center"">
                <div class=""col-md-5 offset-md-3"">

                    <div class=""form-group ml-1 mr-1"">
                        <label class=""customlabel"" for=""building_name"">Room Type</label>
                        ");
#nullable restore
#line 73 "D:\Home\workspace\RoomCheckingSystemlatest\RoomCheckingSystem\RoomCheckingSystem\Views\Rooms\Roomsadd.cshtml"
                   Write(Html.TextBoxFor(m => m.RoomType, new { @class = "form-control removeshadow", autocomplete = "off", placeholder = "Room Type", }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                    </div>\r\n\r\n                </div>\r\n            </div>\r\n");
            WriteLiteral(@"            <div class=""row"" style=""text-align: center"">
                <div class=""col-md-5 offset-md-3"">

                    <div class=""form-group ml-1 mr-1"">
                        <label class=""customlabel"" for=""building_description"">Room Description</label>
                        ");
#nullable restore
#line 85 "D:\Home\workspace\RoomCheckingSystemlatest\RoomCheckingSystem\RoomCheckingSystem\Views\Rooms\Roomsadd.cshtml"
                   Write(Html.TextAreaFor(m => m.RoomDescription, new { @class = "form-control removeshadow", autocomplete = "off", placeholder = "Room Description", }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                    </div>\r\n\r\n                </div>\r\n            </div>\r\n");
            WriteLiteral("            <div class=\"row\" style=\" text-align: left;height: 30px;\">\r\n                <div class=\"col-md-2 offset-md-3 mb-5\">\r\n                    <div class=\"custom-control custom-checkbox mb-3 removeshadow\">\r\n\r\n                        ");
#nullable restore
#line 96 "D:\Home\workspace\RoomCheckingSystemlatest\RoomCheckingSystem\RoomCheckingSystem\Views\Rooms\Roomsadd.cshtml"
                   Write(Html.CheckBoxFor(model => model.isActive, new { @id = "chkactive", @class = "custom-control-input" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <label class=\"custom-control-label\" for=\"chkactive\">Active</label>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
            WriteLiteral(@"            <div class=""row"" style=""text-align: center"">
                <div class=""col-md-5 offset-md-3 mb-5"">
                    <button type=""button"" class=""btn btn-default cancelButton"">Back</button>
                    <button type=""submit"" id=""btnSave"" class=""btn btn-primary myButton"">Save</button>


                </div>
            </div>
");
#nullable restore
#line 110 "D:\Home\workspace\RoomCheckingSystemlatest\RoomCheckingSystem\RoomCheckingSystem\Views\Rooms\Roomsadd.cshtml"

        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Rooms> Html { get; private set; }
    }
}
#pragma warning restore 1591
