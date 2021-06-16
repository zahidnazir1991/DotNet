#pragma checksum "E:\gitrepos\RoomCheckingSystemlatest\RoomCheckingSystem\RoomCheckingSystem\Views\Dashboard\Housekeepingdata.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "29d524b9b6ad6bddcd04197651d94e841259d93c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Dashboard_Housekeepingdata), @"mvc.1.0.view", @"/Views/Dashboard/Housekeepingdata.cshtml")]
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
#line 1 "E:\gitrepos\RoomCheckingSystemlatest\RoomCheckingSystem\RoomCheckingSystem\Views\Dashboard\Housekeepingdata.cshtml"
using RoomCheckingSystem.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"29d524b9b6ad6bddcd04197651d94e841259d93c", @"/Views/Dashboard/Housekeepingdata.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8d45131c291c8e3ddfd71b7423b4d6c14b4ec6c8", @"/Views/_ViewImports.cshtml")]
    public class Views_Dashboard_Housekeepingdata : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<sploadbuildings>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"row\" style=\"margin-top:15px;\">\r\n    <div class=\"col-sm-12\">\r\n        <input type=\"hidden\" id=\"hbuildingid\">\r\n        <input type=\"hidden\" id=\"hroomid\">\r\n");
#nullable restore
#line 12 "E:\gitrepos\RoomCheckingSystemlatest\RoomCheckingSystem\RoomCheckingSystem\Views\Dashboard\Housekeepingdata.cshtml"
         foreach (sploadbuildings mbuilding in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <button class=\"accordion\">");
#nullable restore
#line 14 "E:\gitrepos\RoomCheckingSystemlatest\RoomCheckingSystem\RoomCheckingSystem\Views\Dashboard\Housekeepingdata.cshtml"
                                 Write(mbuilding.BuildingName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </button>\r\n            <div class=\"panel\">\r\n                <div class=\"subpanel\">\r\n");
#nullable restore
#line 17 "E:\gitrepos\RoomCheckingSystemlatest\RoomCheckingSystem\RoomCheckingSystem\Views\Dashboard\Housekeepingdata.cshtml"
                     foreach (sploadrooms mrooms in mbuilding.listofRooms)
                    {
                        var color = "";
                        var icon = "";
                        var statusname = "";
                        var clearningtime = "";
                        var pStatus = -1;
                        var cStatus = -1;
                        var isprority = false;
                        var statusid = -1;
                        if (mrooms.listofRooms.Count() > 0)
                        {
                            color = mrooms.listofRooms.ElementAt(mrooms.listofRooms.Count() - 1).StatusColor;
                            icon = mrooms.listofRooms.ElementAt(mrooms.listofRooms.Count() - 1).icon;
                            statusname = mrooms.listofRooms.ElementAt(mrooms.listofRooms.Count() - 1).StatusName;

                            if (mrooms.listofRooms.ElementAt(mrooms.listofRooms.Count() - 1).Cleaningtime != "-1")
                            {
                                clearningtime = Convert.ToDateTime(mrooms.listofRooms.ElementAt(mrooms.listofRooms.Count() - 1).Cleaningtime).ToString("hh:mm");
                            }


                            pStatus = mrooms.listofRooms.ElementAt(mrooms.listofRooms.Count() - 1).pStatus;
                            cStatus = mrooms.listofRooms.ElementAt(mrooms.listofRooms.Count() - 1).cStatus;
                            isprority = mrooms.listofRooms.ElementAt(mrooms.listofRooms.Count() - 1).prority;
                            statusid = mrooms.listofRooms.ElementAt(mrooms.listofRooms.Count() - 1).statusid;


                        }
                        else
                        {
                            color = "#bababa";
                            icon = "fa fa-home";
                            statusname = "";
                            clearningtime = "";
                            pStatus = -1;
                            cStatus = -1;
                            isprority = false;
                            statusid = -1;


                        }





#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"cxm-room js-room_div bg-green col-sm-12\" oncontextmenu=\"on_room_contextmenu(this,event);return false;\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2871, "\"", 3050, 22);
            WriteAttributeValue("", 2881, "show_status_in_model(\'", 2881, 22, true);
#nullable restore
#line 63 "E:\gitrepos\RoomCheckingSystemlatest\RoomCheckingSystem\RoomCheckingSystem\Views\Dashboard\Housekeepingdata.cshtml"
WriteAttributeValue("", 2903, mbuilding.BuildingName, 2903, 23, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2926, "\',", 2926, 2, true);
            WriteAttributeValue(" ", 2928, "\'", 2929, 2, true);
#nullable restore
#line 63 "E:\gitrepos\RoomCheckingSystemlatest\RoomCheckingSystem\RoomCheckingSystem\Views\Dashboard\Housekeepingdata.cshtml"
WriteAttributeValue("", 2930, mbuilding.BuildingID, 2930, 21, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2951, "\',", 2951, 2, true);
            WriteAttributeValue(" ", 2953, "\'", 2954, 2, true);
#nullable restore
#line 63 "E:\gitrepos\RoomCheckingSystemlatest\RoomCheckingSystem\RoomCheckingSystem\Views\Dashboard\Housekeepingdata.cshtml"
WriteAttributeValue("", 2955, mrooms.RoomName, 2955, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2971, "\',", 2971, 2, true);
            WriteAttributeValue(" ", 2973, "\'", 2974, 2, true);
#nullable restore
#line 63 "E:\gitrepos\RoomCheckingSystemlatest\RoomCheckingSystem\RoomCheckingSystem\Views\Dashboard\Housekeepingdata.cshtml"
WriteAttributeValue("", 2975, mrooms.RoomID, 2975, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2989, "\',", 2989, 2, true);
#nullable restore
#line 63 "E:\gitrepos\RoomCheckingSystemlatest\RoomCheckingSystem\RoomCheckingSystem\Views\Dashboard\Housekeepingdata.cshtml"
WriteAttributeValue("", 2991, pStatus, 2991, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2999, ",", 2999, 1, true);
#nullable restore
#line 63 "E:\gitrepos\RoomCheckingSystemlatest\RoomCheckingSystem\RoomCheckingSystem\Views\Dashboard\Housekeepingdata.cshtml"
WriteAttributeValue("", 3000, cStatus, 3000, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3008, ",\'", 3008, 2, true);
#nullable restore
#line 63 "E:\gitrepos\RoomCheckingSystemlatest\RoomCheckingSystem\RoomCheckingSystem\Views\Dashboard\Housekeepingdata.cshtml"
WriteAttributeValue("", 3010, isprority, 3010, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3020, "\',\'", 3020, 3, true);
#nullable restore
#line 63 "E:\gitrepos\RoomCheckingSystemlatest\RoomCheckingSystem\RoomCheckingSystem\Views\Dashboard\Housekeepingdata.cshtml"
WriteAttributeValue("", 3023, clearningtime, 3023, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3037, "\',", 3037, 2, true);
#nullable restore
#line 63 "E:\gitrepos\RoomCheckingSystemlatest\RoomCheckingSystem\RoomCheckingSystem\Views\Dashboard\Housekeepingdata.cshtml"
WriteAttributeValue("", 3039, statusid, 3039, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3048, ");", 3048, 2, true);
            EndWriteAttribute();
            WriteLiteral(@" js-data=""{&quot;model_title&quot;:&quot;81-83&amp;nbsp;&amp;nbsp;&amp;gt;&amp;gt;&amp;nbsp;&amp;nbsp;1A&quot;,&quot;room_id&quot;:&quot;c2f0e190b9bcb3c92d02f4968994d71c&quot;,&quot;building_id&quot;:&quot;96cfbc9de3f0ca3f93c8c13abc420ccd&quot;,&quot;current_status_id&quot;:null}"" title=""Change Status""");
            BeginWriteAttribute("style", " style=\"", 3354, "\"", 3415, 5);
            WriteAttributeValue("", 3362, "cursor:", 3362, 7, true);
            WriteAttributeValue(" ", 3369, "pointer;", 3370, 9, true);
            WriteAttributeValue(" ", 3378, "background-color:", 3379, 18, true);
#nullable restore
#line 63 "E:\gitrepos\RoomCheckingSystemlatest\RoomCheckingSystem\RoomCheckingSystem\Views\Dashboard\Housekeepingdata.cshtml"
WriteAttributeValue(" ", 3396, color, 3397, 6, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 3403, "!important;", 3404, 12, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n\r\n                            <div class=\"row cxm-no-gutters\">\r\n                                <div class=\"col-4  col-md-12 col-lg-12\">\r\n                                    <div class=\"cxm-room-count-1\">\r\n                                        ");
#nullable restore
#line 68 "E:\gitrepos\RoomCheckingSystemlatest\RoomCheckingSystem\RoomCheckingSystem\Views\Dashboard\Housekeepingdata.cshtml"
                                   Write(mrooms.RoomName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral(@"                                    </div>
                                </div>


                                <div class=""col-8 col-md-12 col-lg-12 cxm-text-align"">
                                    <div class=""cxm-room-icon hidden-md-down"" style=""padding-top: 0px;"">
                                        <span");
            BeginWriteAttribute("class", " class=\"", 4245, "\"", 4276, 2);
#nullable restore
#line 76 "E:\gitrepos\RoomCheckingSystemlatest\RoomCheckingSystem\RoomCheckingSystem\Views\Dashboard\Housekeepingdata.cshtml"
WriteAttributeValue("", 4253, icon, 4253, 5, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 4258, "dashboardiconsize", 4259, 18, true);
            EndWriteAttribute();
            WriteLiteral("></span>\r\n                                    </div>\r\n\r\n                                    <div class=\"hidden-sm cxm-room-label\">\r\n                                        ");
#nullable restore
#line 80 "E:\gitrepos\RoomCheckingSystemlatest\RoomCheckingSystem\RoomCheckingSystem\Views\Dashboard\Housekeepingdata.cshtml"
                                   Write(statusname);

#line default
#line hidden
#nullable disable
            WriteLiteral("&nbsp;&nbsp;\r\n                                        <span class=\"fa fa-home cxm-room-icon-2 hidden-md-up\"></span>\r\n\r\n                                    </div>\r\n\r\n");
#nullable restore
#line 90 "E:\gitrepos\RoomCheckingSystemlatest\RoomCheckingSystem\RoomCheckingSystem\Views\Dashboard\Housekeepingdata.cshtml"
                                      
                                        if (clearningtime.Length > 0)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <div class=\"row cxm-no-gutters hidden-sm-down\">\r\n                                                <div class=\"col-sm-6\" style=\"font-weight: bold; text-align: justify;\">");
#nullable restore
#line 94 "E:\gitrepos\RoomCheckingSystemlatest\RoomCheckingSystem\RoomCheckingSystem\Views\Dashboard\Housekeepingdata.cshtml"
                                                                                                                 Write(clearningtime);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                                                <div class=""col-sm-6 text-right"">
                                                    <img src=""https://www.hydeparkaparts.com/dev.roomchecking.hydeparkaparts.com/assets/admin/ssaq-data/media/cxm-icon-clock-4.png"" alt=""Clock"" width=""25"">
                                                </div>
                                            </div>
");
#nullable restore
#line 99 "E:\gitrepos\RoomCheckingSystemlatest\RoomCheckingSystem\RoomCheckingSystem\Views\Dashboard\Housekeepingdata.cshtml"
                                        }

                                    

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                                </div>\r\n                            </div>\r\n\r\n                        </div>\r\n");
#nullable restore
#line 108 "E:\gitrepos\RoomCheckingSystemlatest\RoomCheckingSystem\RoomCheckingSystem\Views\Dashboard\Housekeepingdata.cshtml"



                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n\r\n\r\n            </div>\r\n");
#nullable restore
#line 116 "E:\gitrepos\RoomCheckingSystemlatest\RoomCheckingSystem\RoomCheckingSystem\Views\Dashboard\Housekeepingdata.cshtml"

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

        $(window).resize(function () {
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