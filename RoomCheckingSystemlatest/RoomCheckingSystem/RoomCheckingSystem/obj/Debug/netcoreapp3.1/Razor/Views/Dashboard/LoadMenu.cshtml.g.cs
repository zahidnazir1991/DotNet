#pragma checksum "D:\Home\RoomCheckingSystemlatest\RoomCheckingSystem\RoomCheckingSystem\Views\Dashboard\LoadMenu.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "99ec4e45a426b4cfd68b9d8be8378d851a3297ae"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Dashboard_LoadMenu), @"mvc.1.0.view", @"/Views/Dashboard/LoadMenu.cshtml")]
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
#line 1 "D:\Home\RoomCheckingSystemlatest\RoomCheckingSystem\RoomCheckingSystem\Views\Dashboard\LoadMenu.cshtml"
using RoomCheckingSystem.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"99ec4e45a426b4cfd68b9d8be8378d851a3297ae", @"/Views/Dashboard/LoadMenu.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8d45131c291c8e3ddfd71b7423b4d6c14b4ec6c8", @"/Views/_ViewImports.cshtml")]
    public class Views_Dashboard_LoadMenu : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<sploadmenu>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/gridstyleing.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/man.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("rounded-circle"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("User Image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "99ec4e45a426b4cfd68b9d8be8378d851a3297ae4981", async() => {
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
#nullable restore
#line 11 "D:\Home\RoomCheckingSystemlatest\RoomCheckingSystem\RoomCheckingSystem\Views\Dashboard\LoadMenu.cshtml"
  
    if (Model.Count() > 0)
    {
        sploadmenu obj = Model.ElementAt(0);


#line default
#line hidden
#nullable disable
            WriteLiteral("        <aside>\r\n            <div class=\"sidebar left fliph sidenav\">\r\n                <div class=\"user-panel\">\r\n                    <div class=\"pull-left image\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "99ec4e45a426b4cfd68b9d8be8378d851a3297ae6603", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    </div>
                    <div class=""pull-left info"">
                        <p>Zahid Nazir</p>
                        <a href=""#""><i class=""fa fa-circle text-success""></i> Online</a>
                    </div>
                </div>
                <ul class=""list-sidebar bg-defoult"">

");
#nullable restore
#line 29 "D:\Home\RoomCheckingSystemlatest\RoomCheckingSystem\RoomCheckingSystem\Views\Dashboard\LoadMenu.cshtml"
                       if (obj.isSupperAdmin == true)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            <li class=""nav-li"">
                                <a href=""#"" data-toggle=""collapse"" data-target=""#dashboard"" class=""collapsed active""> <span class=""nav-labelheading nav-bar-header""> Menu </span> </a>

                            </li>
");
            WriteLiteral(@"                            <li> <a href=""/Dashboard/Dashboard""><i class=""fa fa-female""></i> <span class=""nav-label"">House keeping</span></a> </li>
                            <li> <a href=""/Dashboard/Maintenance""><i class=""fa fa-wrench""></i> <span class=""nav-label"">Maintenance</span></a> </li>
");
            WriteLiteral(@"                            <li class=""nav-li"">
                                <a href=""#"" data-toggle=""collapse"" data-target=""#dashboard"" class=""collapsed active""> <span class=""nav-label nav-bar-header""> Users </span> </a>

                            </li>
                            <li> <a href=""/Users/UserGrouplist""><i class=""fa fa-users""></i> <span class=""nav-label"">User Groups</span></a> </li>
                            <li> <a href=""/Users/UserManagement""><i class=""fa fa-user""></i> <span class=""nav-label"">Users</span></a> </li>
                            <li> <a href=""/Shift/Shiftlist""><i class=""fa fa-shirtsinbulk""></i> <span class=""nav-label"">Shift</span></a> </li>
");
            WriteLiteral(@"                            <li class=""nav-li"">
                                <a href=""#"" data-toggle=""collapse"" data-target=""#dashboard"" class=""collapsed active""> <span class=""nav-label nav-bar-header""> Room Status </span> </a>

                            </li>
                            <li> <a href=""/Status/index/1""><i class=""fa fa-bicycle""></i> <span class=""nav-label"">Room Status - House Keeping</span> </a></li>
                            <li> <a href=""/Status/index/2""><i class=""fa fa-gavel""></i> <span class=""nav-label"">Room Status - Maintenance</span></a> </li>
                            <li class=""nav-li"">
                                <a href=""#"" data-toggle=""collapse"" data-target=""#dashboard"" class=""collapsed active""> <span class=""nav-label nav-bar-header""> Building Management </span> </a>

                            </li>
                            <li> <a href=""/Building/Index""><i class=""fa fa-building""></i> <span class=""nav-label"">Buildings</span></a> </li>
                    ");
            WriteLiteral(@"        <li> <a href=""/Rooms/Roomslist""><i class=""fa fa-building-o""></i> <span class=""nav-label"">Building rooms</span></a> </li>
                            <li class=""nav-li"">
                                <a href=""/Handovernotes/Handoverlist"" data-toggle=""collapse"" data-target=""#dashboard"" class=""collapsed active""> <span class=""nav-label nav-bar-header""> Handover Notes </span> </a>

                            </li>
                            <li> <a href=""/Handovernotes/Handoverlist""><i class=""fa fa-handshake-o""></i> <span class=""nav-label"">Handover Notes</span></a> </li>
                            <li class=""nav-li"">
                                <a href=""#"" data-toggle=""collapse"" data-target=""#dashboard"" class=""collapsed active""> <span class=""nav-label nav-bar-header""> Third party </span> </a>

                            </li>
                            <li> <a href=""/TimeStation/GetTimeStation""><i class=""fa fa-server""></i> <span class=""nav-label"">Timestation Management</span></a> </li>");
            WriteLiteral(@"
                            <li class=""nav-li"">
                                <a href=""#"" data-toggle=""collapse"" data-target=""#dashboard"" class=""collapsed active""> <span class=""nav-label nav-bar-header""> Reports </span> </a>

                            </li>
                            <li> <a href=""/LoginActivity/GetAtivitylist""><i class=""fa fa-clock-o""></i> <span class=""nav-label"">Login Activity Log</span></a> </li>
                            <li> <a href=""/LoginActivity/GetWhois""><i class=""fa fa-eye""></i> <span class=""nav-label"">Who is online</span></a> </li>
");
#nullable restore
#line 75 "D:\Home\RoomCheckingSystemlatest\RoomCheckingSystem\RoomCheckingSystem\Views\Dashboard\LoadMenu.cshtml"
                        }
                        else
                        {
                            if (obj.isUsers == true || obj.isUserGroup == true || obj.isShift == true)
                            {


#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                <li class=""nav-li"">
                                    <a href=""#"" data-toggle=""collapse"" data-target=""#dashboard"" class=""collapsed active""> <span class=""nav-labelheading nav-bar-header""> Menu </span> </a>

                                </li>
");
            WriteLiteral(@"                                <li> <a href=""/Dashboard/Dashboard""><i class=""fa fa-female""></i> <span class=""nav-label"">House keeping</span></a> </li>
                                <li> <a href=""/Dashboard/Maintenance""><i class=""fa fa-wrench""></i> <span class=""nav-label"">Maintenance</span></a> </li>
");
            WriteLiteral(@"                                <li class=""nav-li"">
                                    <a href=""https://go.microsoft.com/fwlink/?LinkID=397860"" data-toggle=""collapse"" data-target=""#dashboard"" class=""collapsed active""> <span class=""nav-label nav-bar-header""> Users </span> </a>
                                </li>
");
#nullable restore
#line 92 "D:\Home\RoomCheckingSystemlatest\RoomCheckingSystem\RoomCheckingSystem\Views\Dashboard\LoadMenu.cshtml"
                                if (obj.isUserGroup == true)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <li> <a href=\"/Users/UserGrouplist\"><i class=\"fa fa-users\"></i> <span class=\"nav-label\">User Groups</span></a> </li>\r\n");
#nullable restore
#line 95 "D:\Home\RoomCheckingSystemlatest\RoomCheckingSystem\RoomCheckingSystem\Views\Dashboard\LoadMenu.cshtml"
                                }
                                if (obj.isUsers == true)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <li> <a href=\"/Users/UserManagement\"><i class=\"fa fa-user\"></i> <span class=\"nav-label\">Users</span></a> </li>\r\n");
#nullable restore
#line 99 "D:\Home\RoomCheckingSystemlatest\RoomCheckingSystem\RoomCheckingSystem\Views\Dashboard\LoadMenu.cshtml"
                                }

                                if (obj.isShift == true)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <li> <a href=\"/Shift/Shiftlist\"><i class=\"fa fa-shirtsinbulk\"></i> <span class=\"nav-label\">Shift</span></a> </li>\r\n");
#nullable restore
#line 104 "D:\Home\RoomCheckingSystemlatest\RoomCheckingSystem\RoomCheckingSystem\Views\Dashboard\LoadMenu.cshtml"
                                }
                            }

                            if (obj.isRoomStatus == true)
                            {


#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                <li class=""nav-li"">
                                    <a href=""#"" data-toggle=""collapse"" data-target=""#dashboard"" class=""collapsed active""> <span class=""nav-label nav-bar-header""> Room Status </span> </a>

                                </li>
                                <li> <a href=""/Status/index/1""><i class=""fa fa-bicycle""></i> <span class=""nav-label"">Room Status - House Keeping</span> </a></li>
                                <li> <a href=""/Status/index/2""><i class=""fa fa-gavel""></i> <span class=""nav-label"">Room Status - Maintenance</span></a> </li>
");
#nullable restore
#line 116 "D:\Home\RoomCheckingSystemlatest\RoomCheckingSystem\RoomCheckingSystem\Views\Dashboard\LoadMenu.cshtml"
                            }

                            if (obj.isBuilding == true || obj.isBuildingRoom == true || obj.isBuildingRoomCsvSetup == true)
                            {




#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                <li class=""nav-li"">
                                    <a href=""#"" data-toggle=""collapse"" data-target=""#dashboard"" class=""collapsed active""> <span class=""nav-label nav-bar-header""> Building Management </span> </a>
                                </li>
");
#nullable restore
#line 126 "D:\Home\RoomCheckingSystemlatest\RoomCheckingSystem\RoomCheckingSystem\Views\Dashboard\LoadMenu.cshtml"
                                if (obj.isBuilding == true)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <li> <a href=\"/Building/Index\"><i class=\"fa fa-building\"></i> <span class=\"nav-label\">Buildings</span></a> </li>\r\n");
#nullable restore
#line 129 "D:\Home\RoomCheckingSystemlatest\RoomCheckingSystem\RoomCheckingSystem\Views\Dashboard\LoadMenu.cshtml"
                                }
                                if (obj.isBuildingRoom)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <li> <a href=\"/Rooms/Roomslist\"><i class=\"fa fa-building-o\"></i> <span class=\"nav-label\">Building rooms</span></a> </li>\r\n");
#nullable restore
#line 133 "D:\Home\RoomCheckingSystemlatest\RoomCheckingSystem\RoomCheckingSystem\Views\Dashboard\LoadMenu.cshtml"
                                }


                            }


                            if (obj.isActivityLog == true || obj.isWhoIsOnline == true)
                            {



#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li class=\"nav-li\">\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 8908, "\"", 8915, 0);
            EndWriteAttribute();
            WriteLiteral(" data-toggle=\"collapse\" data-target=\"#dashboard\" class=\"collapsed active\"> <span class=\"nav-label nav-bar-header\"> Reports </span> </a>\r\n                                </li>\r\n");
#nullable restore
#line 146 "D:\Home\RoomCheckingSystemlatest\RoomCheckingSystem\RoomCheckingSystem\Views\Dashboard\LoadMenu.cshtml"
                                if (obj.isBuilding == true)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <li> <a href=\"/LoginActivity/GetAtivitylist\"><i class=\"fa fa-clock-o\"></i> <span class=\"nav-label\">Login Activity Log</span></a> </li>\r\n");
#nullable restore
#line 149 "D:\Home\RoomCheckingSystemlatest\RoomCheckingSystem\RoomCheckingSystem\Views\Dashboard\LoadMenu.cshtml"
                                }
                                if (obj.isBuildingRoom)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <li> <a href=\"/LoginActivity/GetWhois\"><i class=\"fa fa-eye\"></i> <span class=\"nav-label\">Who is online</span></a> </li>\r\n");
#nullable restore
#line 153 "D:\Home\RoomCheckingSystemlatest\RoomCheckingSystem\RoomCheckingSystem\Views\Dashboard\LoadMenu.cshtml"
                                }


                            }
                        }


                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                </ul>\r\n            </div>\r\n\r\n\r\n        </aside>\r\n");
#nullable restore
#line 166 "D:\Home\RoomCheckingSystemlatest\RoomCheckingSystem\RoomCheckingSystem\Views\Dashboard\LoadMenu.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<sploadmenu>> Html { get; private set; }
    }
}
#pragma warning restore 1591