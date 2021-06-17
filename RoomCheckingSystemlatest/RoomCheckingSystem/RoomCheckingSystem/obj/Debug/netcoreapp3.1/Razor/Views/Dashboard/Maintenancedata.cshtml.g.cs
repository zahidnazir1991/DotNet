#pragma checksum "E:\gitrepos\RoomCheckingSystemlatest\RoomCheckingSystem\RoomCheckingSystem\Views\Dashboard\Maintenancedata.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "128c96a3cc980dd899851e4a2bedbe9a5be50d41"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Dashboard_Maintenancedata), @"mvc.1.0.view", @"/Views/Dashboard/Maintenancedata.cshtml")]
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
#line 1 "E:\gitrepos\RoomCheckingSystemlatest\RoomCheckingSystem\RoomCheckingSystem\Views\Dashboard\Maintenancedata.cshtml"
using RoomCheckingSystem.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"128c96a3cc980dd899851e4a2bedbe9a5be50d41", @"/Views/Dashboard/Maintenancedata.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8d45131c291c8e3ddfd71b7423b4d6c14b4ec6c8", @"/Views/_ViewImports.cshtml")]
    public class Views_Dashboard_Maintenancedata : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<sploadbuildings>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<style type=""text/css"">
    .cxm-badge-2 {
        background-color: #FFF;
        border: 1px #333 solid;
        color: #333;
    }

</style>
<div class=""row"" style=""margin-top:15px;"">
    <div class=""col-sm-12"">
        <input type=""hidden"" id=""hbuildingid"">
        <input type=""hidden"" id=""hroomid"">
");
#nullable restore
#line 20 "E:\gitrepos\RoomCheckingSystemlatest\RoomCheckingSystem\RoomCheckingSystem\Views\Dashboard\Maintenancedata.cshtml"
         foreach (sploadbuildings mbuilding in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <button class=\"accordion\">");
#nullable restore
#line 22 "E:\gitrepos\RoomCheckingSystemlatest\RoomCheckingSystem\RoomCheckingSystem\Views\Dashboard\Maintenancedata.cshtml"
                                 Write(mbuilding.BuildingName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </button>\r\n            <div class=\"panel\">\r\n                <div class=\"subpanel\">\r\n");
#nullable restore
#line 25 "E:\gitrepos\RoomCheckingSystemlatest\RoomCheckingSystem\RoomCheckingSystem\Views\Dashboard\Maintenancedata.cshtml"
                     foreach (sploadrooms mrooms in mbuilding.listofRooms)
                    {
                        var color = "";
                        var icon = "";
                        var statusname = "";
                        var clearningtime = "";
                        var pStatus = -1;
                        var cStatus = -1;
                        var statusid = -1;
                        var count = 0;
                        var Groupid = -1;
                        DateTime? dtdate;
                        string json = "";

                        if (mrooms.listofRooms.Count() > 0)
                        {
                            color = mrooms.listofRooms.ElementAt(mrooms.listofRooms.Count() - 1).StatusColor;
                            dtdate = mrooms.listofRooms.ElementAt(mrooms.listofRooms.Count() - 1).dtDate;
                            Groupid = mrooms.listofRooms.ElementAt(mrooms.listofRooms.Count() - 1).isGroupID;
                            count = mrooms.listofRooms.Count();
                            icon = mrooms.listofRooms.ElementAt(mrooms.listofRooms.Count() - 1).icon;
                            statusname = mrooms.listofRooms.ElementAt(mrooms.listofRooms.Count() - 1).StatusName;
                            statusid = mrooms.listofRooms.ElementAt(mrooms.listofRooms.Count() - 1).statusid;
                            json = Newtonsoft.Json.JsonConvert.SerializeObject(mrooms.listofRooms);


                            if (mrooms.listofRooms.ElementAt(mrooms.listofRooms.Count() - 1).Cleaningtime != "-1")
                            {
                                clearningtime = Convert.ToDateTime(mrooms.listofRooms.ElementAt(mrooms.listofRooms.Count() - 1).Cleaningtime).ToString("hh:mm");
                            }


                            pStatus = mrooms.listofRooms.ElementAt(mrooms.listofRooms.Count() - 1).pStatus;
                            cStatus = mrooms.listofRooms.ElementAt(mrooms.listofRooms.Count() - 1).cStatus;


                        }
                        else
                        {
                            color = "#bababa";
                            icon = "fa fa-home";
                            statusname = "";
                            clearningtime = "";
                            pStatus = -1;
                            cStatus = -1;
                            statusid = -1;
                            count = 0;
                            Groupid = -1;
                            dtdate = null;


                        }








#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"cxm-room-bx-square js-room_div bg-green hidden-lg-down\" oncontextmenu=\"on_room_contextmenu(this,event);return false;\"");
            BeginWriteAttribute("onclick", " onclick=\"", 3521, "\"", 3697, 25);
            WriteAttributeValue("", 3531, "show_status_in_model(\'", 3531, 22, true);
#nullable restore
#line 84 "E:\gitrepos\RoomCheckingSystemlatest\RoomCheckingSystem\RoomCheckingSystem\Views\Dashboard\Maintenancedata.cshtml"
WriteAttributeValue("", 3553, mbuilding.BuildingName, 3553, 23, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3576, "\',", 3576, 2, true);
            WriteAttributeValue(" ", 3578, "\'", 3579, 2, true);
#nullable restore
#line 84 "E:\gitrepos\RoomCheckingSystemlatest\RoomCheckingSystem\RoomCheckingSystem\Views\Dashboard\Maintenancedata.cshtml"
WriteAttributeValue("", 3580, mbuilding.BuildingID, 3580, 21, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3601, "\',", 3601, 2, true);
            WriteAttributeValue(" ", 3603, "\'", 3604, 2, true);
#nullable restore
#line 84 "E:\gitrepos\RoomCheckingSystemlatest\RoomCheckingSystem\RoomCheckingSystem\Views\Dashboard\Maintenancedata.cshtml"
WriteAttributeValue("", 3605, mrooms.RoomName, 3605, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3621, "\',", 3621, 2, true);
            WriteAttributeValue(" ", 3623, "\'", 3624, 2, true);
#nullable restore
#line 84 "E:\gitrepos\RoomCheckingSystemlatest\RoomCheckingSystem\RoomCheckingSystem\Views\Dashboard\Maintenancedata.cshtml"
WriteAttributeValue("", 3625, mrooms.RoomID, 3625, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3639, "\',", 3639, 2, true);
#nullable restore
#line 84 "E:\gitrepos\RoomCheckingSystemlatest\RoomCheckingSystem\RoomCheckingSystem\Views\Dashboard\Maintenancedata.cshtml"
WriteAttributeValue("", 3641, pStatus, 3641, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3649, ",", 3649, 1, true);
#nullable restore
#line 84 "E:\gitrepos\RoomCheckingSystemlatest\RoomCheckingSystem\RoomCheckingSystem\Views\Dashboard\Maintenancedata.cshtml"
WriteAttributeValue("", 3650, cStatus, 3650, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3658, ",", 3658, 1, true);
#nullable restore
#line 84 "E:\gitrepos\RoomCheckingSystemlatest\RoomCheckingSystem\RoomCheckingSystem\Views\Dashboard\Maintenancedata.cshtml"
WriteAttributeValue("", 3659, statusid, 3659, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3668, ",", 3668, 1, true);
#nullable restore
#line 84 "E:\gitrepos\RoomCheckingSystemlatest\RoomCheckingSystem\RoomCheckingSystem\Views\Dashboard\Maintenancedata.cshtml"
WriteAttributeValue("", 3669, Groupid, 3669, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3677, ",", 3677, 1, true);
            WriteAttributeValue(" ", 3678, "\'", 3679, 2, true);
#nullable restore
#line 84 "E:\gitrepos\RoomCheckingSystemlatest\RoomCheckingSystem\RoomCheckingSystem\Views\Dashboard\Maintenancedata.cshtml"
WriteAttributeValue("", 3680, dtdate, 3680, 7, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3687, "\',", 3687, 2, true);
#nullable restore
#line 84 "E:\gitrepos\RoomCheckingSystemlatest\RoomCheckingSystem\RoomCheckingSystem\Views\Dashboard\Maintenancedata.cshtml"
WriteAttributeValue("", 3689, count, 3689, 6, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3695, ");", 3695, 2, true);
            EndWriteAttribute();
            WriteLiteral(@" js-data=""{&quot;model_title&quot;:&quot;81-83&amp;nbsp;&amp;nbsp;&amp;gt;&amp;gt;&amp;nbsp;&amp;nbsp;1A&quot;,&quot;room_id&quot;:&quot;c2f0e190b9bcb3c92d02f4968994d71c&quot;,&quot;building_id&quot;:&quot;96cfbc9de3f0ca3f93c8c13abc420ccd&quot;,&quot;current_status_id&quot;:null}"" title=""Change Status""");
            BeginWriteAttribute("style", " style=\"", 4001, "\"", 4062, 5);
            WriteAttributeValue("", 4009, "cursor:", 4009, 7, true);
            WriteAttributeValue(" ", 4016, "pointer;", 4017, 9, true);
            WriteAttributeValue(" ", 4025, "background-color:", 4026, 18, true);
#nullable restore
#line 84 "E:\gitrepos\RoomCheckingSystemlatest\RoomCheckingSystem\RoomCheckingSystem\Views\Dashboard\Maintenancedata.cshtml"
WriteAttributeValue(" ", 4043, color, 4044, 6, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 4050, "!important;", 4051, 12, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n\r\n                            <input type=\"hidden\"");
            BeginWriteAttribute("id", " id=\"", 4116, "\"", 4139, 2);
            WriteAttributeValue("", 4121, "hiv_", 4121, 4, true);
#nullable restore
#line 86 "E:\gitrepos\RoomCheckingSystemlatest\RoomCheckingSystem\RoomCheckingSystem\Views\Dashboard\Maintenancedata.cshtml"
WriteAttributeValue("", 4125, mrooms.RoomID, 4125, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=\"", 4140, "\"", 4153, 1);
#nullable restore
#line 86 "E:\gitrepos\RoomCheckingSystemlatest\RoomCheckingSystem\RoomCheckingSystem\Views\Dashboard\Maintenancedata.cshtml"
WriteAttributeValue("", 4148, json, 4148, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                            <div class=\"row cxm-no-gutters\">\r\n                                <div class=\"col-sm-4 col-md-12 col-lg-12\">\r\n                                    <div class=\"cxm-room-count-1\">\r\n                                        ");
#nullable restore
#line 90 "E:\gitrepos\RoomCheckingSystemlatest\RoomCheckingSystem\RoomCheckingSystem\Views\Dashboard\Maintenancedata.cshtml"
                                   Write(mrooms.RoomName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                    </div>
                                </div>


                                <div class=""col-sm-8 col-md-12 col-lg-12 cxm-text-align"">
                                    <div class=""cxm-room-icon hidden-sm hidden-sm text-center"" style=""padding-top: 13px;"">
                                        <span");
            BeginWriteAttribute("class", " class=\"", 4771, "\"", 4802, 2);
#nullable restore
#line 97 "E:\gitrepos\RoomCheckingSystemlatest\RoomCheckingSystem\RoomCheckingSystem\Views\Dashboard\Maintenancedata.cshtml"
WriteAttributeValue("", 4779, icon, 4779, 5, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 4784, "dashboardiconsize", 4785, 18, true);
            EndWriteAttribute();
            WriteLiteral("></span>\r\n                                    </div>\r\n                                    <div class=\"hidden-sm cxm-room-label text-center\" style=\"line-height: 16px;\">\r\n                                        ");
#nullable restore
#line 100 "E:\gitrepos\RoomCheckingSystemlatest\RoomCheckingSystem\RoomCheckingSystem\Views\Dashboard\Maintenancedata.cshtml"
                                   Write(statusname);

#line default
#line hidden
#nullable disable
            WriteLiteral("&nbsp;&nbsp;\r\n                                        <span class=\"fa fa-refresh cxm-room-icon-2 hidden-md-up\"></span>\r\n                                    </div>\r\n\r\n");
#nullable restore
#line 104 "E:\gitrepos\RoomCheckingSystemlatest\RoomCheckingSystem\RoomCheckingSystem\Views\Dashboard\Maintenancedata.cshtml"
                                      
                                        if (clearningtime.Length > 0)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <div class=\"row cxm-no-gutters d-none\">\r\n                                                <div class=\"col-sm-6\" style=\"font-weight: bold;\">");
#nullable restore
#line 108 "E:\gitrepos\RoomCheckingSystemlatest\RoomCheckingSystem\RoomCheckingSystem\Views\Dashboard\Maintenancedata.cshtml"
                                                                                            Write(clearningtime);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                                                <div class=""col-sm-6 text-right"">
                                                    <img src=""https://www.hydeparkaparts.com/dev.roomchecking.hydeparkaparts.com/assets/admin/ssaq-data/media/cxm-icon-clock-4.png"" alt=""Clock"" width=""22"">
                                                </div>
                                            </div>
");
#nullable restore
#line 113 "E:\gitrepos\RoomCheckingSystemlatest\RoomCheckingSystem\RoomCheckingSystem\Views\Dashboard\Maintenancedata.cshtml"
                                        }

                                    

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                                </div>\r\n");
#nullable restore
#line 119 "E:\gitrepos\RoomCheckingSystemlatest\RoomCheckingSystem\RoomCheckingSystem\Views\Dashboard\Maintenancedata.cshtml"
                                  
                                    if (count > 1)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <div class=\"row cxm-no-gutters text-left\">\r\n                                            <span class=\"badge cxm-badge-2\">2</span>\r\n\r\n                                        </div>\r\n");
#nullable restore
#line 126 "E:\gitrepos\RoomCheckingSystemlatest\RoomCheckingSystem\RoomCheckingSystem\Views\Dashboard\Maintenancedata.cshtml"
                                    }

                                

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </div>\r\n\r\n                        </div>\r\n");
            WriteLiteral(@"                        <div class=""cxm-room-bx cxm-bg-teal js-div_foucs_main fc1 hidden-md-up d-md-block"" onclick=""show_status_in_model(this, true);"" js-data=""{&quot;model_title&quot;:&quot;81-83&amp;nbsp;&amp;nbsp;&amp;gt;&amp;gt;&amp;nbsp;&amp;nbsp;1A&quot;,&quot;room_id&quot;:&quot;c2f0e190b9bcb3c92d02f4968994d71c&quot;,&quot;building_id&quot;:&quot;96cfbc9de3f0ca3f93c8c13abc420ccd&quot;,&quot;current_status_id&quot;:null}"" title=""Change Status"" style=""cursor:pointer;background-color:#bababa !important;"">

                            <div class=""row cxm-no-gutters"">
                                <div class=""col-3"">
                                    <div class=""cxm-p-1 text-bold cxm-mob_roomname"" style=""border-left:2px #FFF solid;"">


                                        1A
                                    </div>
                                </div>
                                <div class=""col-6"">
                                    <div class=""cxm-p-1 text-bold js-div_foucs_label");
            WriteLiteral(@""">&nbsp;</div>
                                </div>
                                <div class=""col-3"">
                                    <div class=""text-right cxm-p-1 cxm-mob_icon_change"">

                                        <span class=""js-div_foucs_icon_mob"">
                                            <img class=""js-maintenance_icon"" src=""https://www.hydeparkaparts.com/dev.roomchecking.hydeparkaparts.com/assets/admin/ssaq-data/media/cxm-icon-tool.png"" alt=""Tool"" width=""25"">
                                        </span>

                                        <span class=""js-div_foucs_priority_mob"">
                                        </span>

                                    </div>
                                </div>
                            </div>


                        </div>
");
#nullable restore
#line 163 "E:\gitrepos\RoomCheckingSystemlatest\RoomCheckingSystem\RoomCheckingSystem\Views\Dashboard\Maintenancedata.cshtml"

                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n\r\n\r\n            </div>\r\n");
#nullable restore
#line 169 "E:\gitrepos\RoomCheckingSystemlatest\RoomCheckingSystem\RoomCheckingSystem\Views\Dashboard\Maintenancedata.cshtml"

        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

    </div>
    <script type=""text/javascript"">
        $(document).ready(function () {
            
            openalltabs();
        });

        function openalltabs() {

            var acc = document.getElementsByClassName(""accordion"");

            var i;
            for (i = 0; i < acc.length; i++) {
                acc[i].classList.toggle(""active"");
                var panel = acc[i].nextElementSibling;
                panel.classList.add(""panel"");
                panel.style.maxHeight = panel.scrollHeight + ""px"";
            }

        }
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<sploadbuildings>> Html { get; private set; }
    }
}
#pragma warning restore 1591
