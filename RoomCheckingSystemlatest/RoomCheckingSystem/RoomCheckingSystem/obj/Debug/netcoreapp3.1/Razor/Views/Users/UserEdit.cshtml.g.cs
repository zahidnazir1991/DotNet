#pragma checksum "E:\gitrepos\RoomCheckingSystemlatest\RoomCheckingSystem\RoomCheckingSystem\Views\Users\UserEdit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6d1c854f48465a7cea9d151456e2937798544545"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Users_UserEdit), @"mvc.1.0.view", @"/Views/Users/UserEdit.cshtml")]
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
#line 1 "E:\gitrepos\RoomCheckingSystemlatest\RoomCheckingSystem\RoomCheckingSystem\Views\_ViewImports.cshtml"
using RoomCheckingSystem;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "E:\gitrepos\RoomCheckingSystemlatest\RoomCheckingSystem\RoomCheckingSystem\Views\Users\UserEdit.cshtml"
using RoomCheckingSystem.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6d1c854f48465a7cea9d151456e2937798544545", @"/Views/Users/UserEdit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8d45131c291c8e3ddfd71b7423b4d6c14b4ec6c8", @"/Views/_ViewImports.cshtml")]
    public class Views_Users_UserEdit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<User>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/webthemes.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/gridstyleing.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("<style type=\"text/css\">\r\n    .btn-default {\r\n        background-color: #f4f4f4;\r\n        color: #444;\r\n        border-color: #ddd;\r\n    }\r\n</style>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6d1c854f48465a7cea9d151456e29377985445454782", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6d1c854f48465a7cea9d151456e29377985445455896", async() => {
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
                    User
                    <small>Add</small>
                </h1>
            </div>
        </div>

");
#nullable restore
#line 30 "E:\gitrepos\RoomCheckingSystemlatest\RoomCheckingSystem\RoomCheckingSystem\Views\Users\UserEdit.cshtml"
         using (Html.BeginForm())
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <div class=""row"" style=""text-align: center"">
                <div class=""col-md-5 offset-md-3"">

                    <div class=""form-group ml-1 mr-1"">
                        <label class=""customlabel"" for=""building_name"">First Name</label>
                        ");
#nullable restore
#line 37 "E:\gitrepos\RoomCheckingSystemlatest\RoomCheckingSystem\RoomCheckingSystem\Views\Users\UserEdit.cshtml"
                   Write(Html.TextBoxFor(m => m.FirstName, new { @class = "form-control removeshadow", autocomplete = "off", required = "required", placeholder = "First Name", }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral(@"                    </div>
                </div>
            </div>
            <div class=""row"" style=""text-align: center"">
                <div class=""col-md-5 offset-md-3"">
                    <div class=""form-group ml-1 mr-1"">
                        <label class=""customlabel"" for=""building_name"">Last Name</label>
                        ");
#nullable restore
#line 46 "E:\gitrepos\RoomCheckingSystemlatest\RoomCheckingSystem\RoomCheckingSystem\Views\Users\UserEdit.cshtml"
                   Write(Html.TextBoxFor(m => m.LastName, new { @class = "form-control removeshadow", autocomplete = "off", required = "required", placeholder = "Last Name", }));

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
                        <label class=""customlabel"" for=""building_name"">Email</label>
                        ");
#nullable restore
#line 56 "E:\gitrepos\RoomCheckingSystemlatest\RoomCheckingSystem\RoomCheckingSystem\Views\Users\UserEdit.cshtml"
                   Write(Html.TextBoxFor(m => m.Email, new { @class = "form-control removeshadow", autocomplete = "off", required = "required", placeholder = "Email", }));

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
                        <label class=""customlabel"" for=""building_name"">Phone</label>
                        ");
#nullable restore
#line 65 "E:\gitrepos\RoomCheckingSystemlatest\RoomCheckingSystem\RoomCheckingSystem\Views\Users\UserEdit.cshtml"
                   Write(Html.TextBoxFor(m => m.Phone, new { @class = "form-control removeshadow", autocomplete = "off", required = "required", placeholder = "Phone", }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

                    </div>
                </div>
            </div>
            <div class=""row"" style=""text-align: left; height:40px;"">
                <div class=""col-md-2 offset-md-3 mb-5"">
                    <div class=""custom-control custom-checkbox mb-3 removeshadow"">
                        ");
#nullable restore
#line 73 "E:\gitrepos\RoomCheckingSystemlatest\RoomCheckingSystem\RoomCheckingSystem\Views\Users\UserEdit.cshtml"
                   Write(Html.CheckBoxFor(model => model.isAllowpin, new { @id = "chkallowpin", @class = "custom-control-input" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <label class=\"custom-control-label\" for=\"chkallowpin\">Allow PIN Login </label>\r\n                    </div>\r\n                </div>\r\n\r\n            </div>\r\n");
            WriteLiteral("            <div id=\"divpincode\" class=\"row\" style=\"text-align: center\">\r\n                <div class=\"col-md-5 offset-md-3\">\r\n                    <div class=\"input-group ml-1 mr-1\">\r\n                        ");
#nullable restore
#line 83 "E:\gitrepos\RoomCheckingSystemlatest\RoomCheckingSystem\RoomCheckingSystem\Views\Users\UserEdit.cshtml"
                   Write(Html.TextBoxFor(m => m.PinCode, new { @id = "txtpin", @class = "form-control removeshadow", autocomplete = "off", required = "required", placeholder = "PIN", }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

                        <span class=""input-group-btn"">
                            <button onclick=""showhidepassword()"" class=""btn btn-default reveal"" style=""z-index: 2; margin-left: -1px"" type=""button""><i id=""lieye"" class=""fa fa-eye"" aria-hidden=""true""></i></button>
                        </span>
                    </div>

                </div>
            </div>
");
            WriteLiteral(@"            <div class=""row"" style=""text-align: center"">
                <div class=""col-md-5 offset-md-3"">
                    <div class=""form-group ml-1 mr-1"">
                        <label class=""customlabel"" for=""building_name"">Password</label>
                        ");
#nullable restore
#line 97 "E:\gitrepos\RoomCheckingSystemlatest\RoomCheckingSystem\RoomCheckingSystem\Views\Users\UserEdit.cshtml"
                   Write(Html.PasswordFor(m => m.UserPassword, new { @class = "form-control removeshadow", autocomplete = "off", required = "required", placeholder = "Password", }));

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
                        <label class=""customlabel"" for=""building_name"">Confirm Password</label>
                        ");
#nullable restore
#line 106 "E:\gitrepos\RoomCheckingSystemlatest\RoomCheckingSystem\RoomCheckingSystem\Views\Users\UserEdit.cshtml"
                   Write(Html.PasswordFor(m => m.ConfirmPassword, new { @class = "form-control removeshadow", autocomplete = "off", required = "required", placeholder = "Confirm Password", }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
            WriteLiteral(@"            <div class=""row"" style=""text-align: center"">
                <div class=""col-md-5 offset-md-3"">

                    <div class=""form-group ml-1 mr-1"">
                        <label for=""user_group_id"">User Group</label>
                        ");
#nullable restore
#line 117 "E:\gitrepos\RoomCheckingSystemlatest\RoomCheckingSystem\RoomCheckingSystem\Views\Users\UserEdit.cshtml"
                   Write(Html.DropDownListFor(model => model.UserGroup, ViewBag.CityList as SelectList, "Select Group", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n");
            WriteLiteral(@"
                    </div>

                </div>
            </div>
            <div class=""row"" style=""text-align: left"">
                <div class=""col-md-2 offset-md-3 mb-5"">
                    <div class=""custom-control custom-checkbox mb-3 removeshadow"">


                        ");
#nullable restore
#line 138 "E:\gitrepos\RoomCheckingSystemlatest\RoomCheckingSystem\RoomCheckingSystem\Views\Users\UserEdit.cshtml"
                   Write(Html.CheckBoxFor(model => model.isActive, new { @id = "chkactive", @class = "custom-control-input" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <label class=\"custom-control-label\" for=\"chkactive\">Active</label>\r\n                    </div>\r\n                </div>\r\n\r\n            </div>\r\n");
            WriteLiteral(@"            <div class=""row"" style=""text-align: center"">
                <div class=""col-md-5 offset-md-3 mb-5"">
                    <button type=""button"" class=""btn btn-default cancelButton"">Cancel</button>
                    <button type=""submit"" id=""btnSave"" class=""btn btn-primary myButton"">Update</button>


                </div>
            </div>
");
#nullable restore
#line 153 "E:\gitrepos\RoomCheckingSystemlatest\RoomCheckingSystem\RoomCheckingSystem\Views\Users\UserEdit.cshtml"

        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6d1c854f48465a7cea9d151456e293779854454516310", async() => {
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
            WriteLiteral(@"
<script type=""text/javascript"">
    $(document).ready(function () {
        showhidepassword();
        $(""#divpincode"").hide();
        if ($('#chkallowpin').is("":checked"")) {

            $(""#divpincode"").show();
        }
        $('#chkallowpin').click(function () {

            if ($(this).is("":checked"")) {

                $(""#divpincode"").show();
            }
            else if ($(this).is("":not(:checked)"")) {
                $(""#divpincode"").hide();
            }
        });
    });

    function showhidepassword() {
        var x = document.getElementById(""txtpin"");
        var li = document.getElementById(""lieye"");
        if (x.type === ""password"") {
            x.type = ""text"";
            $('#lieye').removeClass('fa fa-eye');
            $(""#lieye"").addClass(""fa fa-eye-slash"");

        } else {
            x.type = ""password"";
            $('#lieye').removeClass('fa fa-eye-slash');
            $(""#lieye"").addClass(""fa fa-eye"");

        }
    }

</script>");
            WriteLiteral("\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<User> Html { get; private set; }
    }
}
#pragma warning restore 1591
