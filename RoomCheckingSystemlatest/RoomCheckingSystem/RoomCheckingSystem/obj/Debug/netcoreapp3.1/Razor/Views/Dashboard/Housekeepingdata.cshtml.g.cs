<<<<<<< HEAD
#pragma checksum "D:\Home\workspace\RoomCheckingSystemlatest\RoomCheckingSystem\RoomCheckingSystem\Views\Dashboard\Housekeepingdata.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "68621e7d132c52fb0c9a87a27719c56a1353b823"
=======
#pragma checksum "E:\gitrepos\RoomCheckingSystemlatest\RoomCheckingSystem\RoomCheckingSystem\Views\Dashboard\Housekeepingdata.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "68cae25c97c4c9abafda6757c1d077849c44ee9b"
>>>>>>> e0e6cc607651e60de56d0e4701bf5ec2ceee3e07
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"68621e7d132c52fb0c9a87a27719c56a1353b823", @"/Views/Dashboard/Housekeepingdata.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8d45131c291c8e3ddfd71b7423b4d6c14b4ec6c8", @"/Views/_ViewImports.cshtml")]
    public class Views_Dashboard_Housekeepingdata : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<sploadbuildings>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<div class=\"row\" style=\"margin-top:15px;\">\r\n    <div class=\"col-sm-12\">\r\n        <input type=\"hidden\" id=\"hbuildingid\">\r\n        <input type=\"hidden\" id=\"hroomid\">\r\n");
#nullable restore
#line 14 "E:\gitrepos\RoomCheckingSystemlatest\RoomCheckingSystem\RoomCheckingSystem\Views\Dashboard\Housekeepingdata.cshtml"
         foreach (sploadbuildings mbuilding in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <button class=\"accordion\">");
#nullable restore
#line 16 "E:\gitrepos\RoomCheckingSystemlatest\RoomCheckingSystem\RoomCheckingSystem\Views\Dashboard\Housekeepingdata.cshtml"
                                 Write(mbuilding.BuildingName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </button>\r\n            <div class=\"panel\">\r\n                <div class=\"subpanel\">\r\n");
#nullable restore
#line 19 "E:\gitrepos\RoomCheckingSystemlatest\RoomCheckingSystem\RoomCheckingSystem\Views\Dashboard\Housekeepingdata.cshtml"
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
                        var StID = 0;
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
                            StID = mrooms.listofRooms.ElementAt(mrooms.listofRooms.Count() - 1).stID;
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
            BeginWriteAttribute("onclick", " onclick=\"", 3017, "\"", 3220, 28);
            WriteAttributeValue("", 3027, "show_status_in_model(\'", 3027, 22, true);
#nullable restore
<<<<<<< HEAD
#line 67 "D:\Home\workspace\RoomCheckingSystemlatest\RoomCheckingSystem\RoomCheckingSystem\Views\Dashboard\Housekeepingdata.cshtml"
WriteAttributeValue("", 3049, mbuilding.BuildingName, 3049, 23, false);
=======
#line 65 "E:\gitrepos\RoomCheckingSystemlatest\RoomCheckingSystem\RoomCheckingSystem\Views\Dashboard\Housekeepingdata.cshtml"
WriteAttributeValue("", 2907, mbuilding.BuildingName, 2907, 23, false);
>>>>>>> e0e6cc607651e60de56d0e4701bf5ec2ceee3e07

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3072, "\',", 3072, 2, true);
            WriteAttributeValue(" ", 3074, "\'", 3075, 2, true);
#nullable restore
<<<<<<< HEAD
#line 67 "D:\Home\workspace\RoomCheckingSystemlatest\RoomCheckingSystem\RoomCheckingSystem\Views\Dashboard\Housekeepingdata.cshtml"
WriteAttributeValue("", 3076, mbuilding.BuildingID, 3076, 21, false);
=======
#line 65 "E:\gitrepos\RoomCheckingSystemlatest\RoomCheckingSystem\RoomCheckingSystem\Views\Dashboard\Housekeepingdata.cshtml"
WriteAttributeValue("", 2934, mbuilding.BuildingID, 2934, 21, false);
>>>>>>> e0e6cc607651e60de56d0e4701bf5ec2ceee3e07

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3097, "\',", 3097, 2, true);
            WriteAttributeValue(" ", 3099, "\'", 3100, 2, true);
#nullable restore
<<<<<<< HEAD
#line 67 "D:\Home\workspace\RoomCheckingSystemlatest\RoomCheckingSystem\RoomCheckingSystem\Views\Dashboard\Housekeepingdata.cshtml"
WriteAttributeValue("", 3101, mrooms.RoomName, 3101, 16, false);
=======
#line 65 "E:\gitrepos\RoomCheckingSystemlatest\RoomCheckingSystem\RoomCheckingSystem\Views\Dashboard\Housekeepingdata.cshtml"
WriteAttributeValue("", 2959, mrooms.RoomName, 2959, 16, false);
>>>>>>> e0e6cc607651e60de56d0e4701bf5ec2ceee3e07

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3117, "\',", 3117, 2, true);
            WriteAttributeValue(" ", 3119, "\'", 3120, 2, true);
#nullable restore
<<<<<<< HEAD
#line 67 "D:\Home\workspace\RoomCheckingSystemlatest\RoomCheckingSystem\RoomCheckingSystem\Views\Dashboard\Housekeepingdata.cshtml"
WriteAttributeValue("", 3121, mrooms.RoomID, 3121, 14, false);
=======
#line 65 "E:\gitrepos\RoomCheckingSystemlatest\RoomCheckingSystem\RoomCheckingSystem\Views\Dashboard\Housekeepingdata.cshtml"
WriteAttributeValue("", 2979, mrooms.RoomID, 2979, 14, false);
>>>>>>> e0e6cc607651e60de56d0e4701bf5ec2ceee3e07

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3135, "\',", 3135, 2, true);
#nullable restore
<<<<<<< HEAD
#line 67 "D:\Home\workspace\RoomCheckingSystemlatest\RoomCheckingSystem\RoomCheckingSystem\Views\Dashboard\Housekeepingdata.cshtml"
WriteAttributeValue("", 3137, pStatus, 3137, 8, false);
=======
#line 65 "E:\gitrepos\RoomCheckingSystemlatest\RoomCheckingSystem\RoomCheckingSystem\Views\Dashboard\Housekeepingdata.cshtml"
WriteAttributeValue("", 2995, pStatus, 2995, 8, false);
>>>>>>> e0e6cc607651e60de56d0e4701bf5ec2ceee3e07

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3145, ",", 3145, 1, true);
#nullable restore
<<<<<<< HEAD
#line 67 "D:\Home\workspace\RoomCheckingSystemlatest\RoomCheckingSystem\RoomCheckingSystem\Views\Dashboard\Housekeepingdata.cshtml"
WriteAttributeValue("", 3146, cStatus, 3146, 8, false);
=======
#line 65 "E:\gitrepos\RoomCheckingSystemlatest\RoomCheckingSystem\RoomCheckingSystem\Views\Dashboard\Housekeepingdata.cshtml"
WriteAttributeValue("", 3004, cStatus, 3004, 8, false);
>>>>>>> e0e6cc607651e60de56d0e4701bf5ec2ceee3e07

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3154, ",", 3154, 1, true);
            WriteAttributeValue(" ", 3155, "\'", 3156, 2, true);
#nullable restore
<<<<<<< HEAD
#line 67 "D:\Home\workspace\RoomCheckingSystemlatest\RoomCheckingSystem\RoomCheckingSystem\Views\Dashboard\Housekeepingdata.cshtml"
WriteAttributeValue("", 3157, isprority, 3157, 10, false);
=======
#line 65 "E:\gitrepos\RoomCheckingSystemlatest\RoomCheckingSystem\RoomCheckingSystem\Views\Dashboard\Housekeepingdata.cshtml"
WriteAttributeValue("", 3014, isprority, 3014, 10, false);
>>>>>>> e0e6cc607651e60de56d0e4701bf5ec2ceee3e07

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3167, "\',", 3167, 2, true);
            WriteAttributeValue(" ", 3169, "\'", 3170, 2, true);
#nullable restore
<<<<<<< HEAD
#line 67 "D:\Home\workspace\RoomCheckingSystemlatest\RoomCheckingSystem\RoomCheckingSystem\Views\Dashboard\Housekeepingdata.cshtml"
WriteAttributeValue("", 3171, clearningtime, 3171, 14, false);
=======
#line 65 "E:\gitrepos\RoomCheckingSystemlatest\RoomCheckingSystem\RoomCheckingSystem\Views\Dashboard\Housekeepingdata.cshtml"
WriteAttributeValue("", 3027, clearningtime, 3027, 14, false);
>>>>>>> e0e6cc607651e60de56d0e4701bf5ec2ceee3e07

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3185, "\',", 3185, 2, true);
#nullable restore
<<<<<<< HEAD
#line 67 "D:\Home\workspace\RoomCheckingSystemlatest\RoomCheckingSystem\RoomCheckingSystem\Views\Dashboard\Housekeepingdata.cshtml"
WriteAttributeValue("", 3187, statusid, 3187, 9, false);
=======
#line 65 "E:\gitrepos\RoomCheckingSystemlatest\RoomCheckingSystem\RoomCheckingSystem\Views\Dashboard\Housekeepingdata.cshtml"
WriteAttributeValue("", 3043, statusid, 3043, 9, false);
>>>>>>> e0e6cc607651e60de56d0e4701bf5ec2ceee3e07

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3196, ",", 3196, 1, true);
#nullable restore
<<<<<<< HEAD
#line 67 "D:\Home\workspace\RoomCheckingSystemlatest\RoomCheckingSystem\RoomCheckingSystem\Views\Dashboard\Housekeepingdata.cshtml"
WriteAttributeValue("", 3197, ViewBag.dialog, 3197, 15, false);
=======
#line 65 "E:\gitrepos\RoomCheckingSystemlatest\RoomCheckingSystem\RoomCheckingSystem\Views\Dashboard\Housekeepingdata.cshtml"
WriteAttributeValue("", 3053, ViewBag.dialog, 3053, 15, false);
>>>>>>> e0e6cc607651e60de56d0e4701bf5ec2ceee3e07

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3212, ",", 3212, 1, true);
#nullable restore
#line 67 "D:\Home\workspace\RoomCheckingSystemlatest\RoomCheckingSystem\RoomCheckingSystem\Views\Dashboard\Housekeepingdata.cshtml"
WriteAttributeValue("", 3213, StID, 3213, 5, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3218, ");", 3218, 2, true);
            EndWriteAttribute();
            WriteLiteral(@" js-data=""{&quot;model_title&quot;:&quot;81-83&amp;nbsp;&amp;nbsp;&amp;gt;&amp;gt;&amp;nbsp;&amp;nbsp;1A&quot;,&quot;room_id&quot;:&quot;c2f0e190b9bcb3c92d02f4968994d71c&quot;,&quot;building_id&quot;:&quot;96cfbc9de3f0ca3f93c8c13abc420ccd&quot;,&quot;current_status_id&quot;:null}"" title=""Change Status""");
            BeginWriteAttribute("style", " style=\"", 3524, "\"", 3585, 5);
            WriteAttributeValue("", 3532, "cursor:", 3532, 7, true);
            WriteAttributeValue(" ", 3539, "pointer;", 3540, 9, true);
            WriteAttributeValue(" ", 3548, "background-color:", 3549, 18, true);
#nullable restore
<<<<<<< HEAD
#line 67 "D:\Home\workspace\RoomCheckingSystemlatest\RoomCheckingSystem\RoomCheckingSystem\Views\Dashboard\Housekeepingdata.cshtml"
WriteAttributeValue(" ", 3566, color, 3567, 6, false);
=======
#line 65 "E:\gitrepos\RoomCheckingSystemlatest\RoomCheckingSystem\RoomCheckingSystem\Views\Dashboard\Housekeepingdata.cshtml"
WriteAttributeValue(" ", 3416, color, 3417, 6, false);
>>>>>>> e0e6cc607651e60de56d0e4701bf5ec2ceee3e07

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 3573, "!important;", 3574, 12, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n\r\n                            <div class=\"row cxm-no-gutters\">\r\n                                <div class=\"col-4  col-md-12 col-lg-12\">\r\n                                    <div class=\"cxm-room-count-1\">\r\n                                        ");
#nullable restore
<<<<<<< HEAD
#line 72 "D:\Home\workspace\RoomCheckingSystemlatest\RoomCheckingSystem\RoomCheckingSystem\Views\Dashboard\Housekeepingdata.cshtml"
=======
#line 70 "E:\gitrepos\RoomCheckingSystemlatest\RoomCheckingSystem\RoomCheckingSystem\Views\Dashboard\Housekeepingdata.cshtml"
>>>>>>> e0e6cc607651e60de56d0e4701bf5ec2ceee3e07
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
            BeginWriteAttribute("class", " class=\"", 4415, "\"", 4446, 2);
#nullable restore
<<<<<<< HEAD
#line 80 "D:\Home\workspace\RoomCheckingSystemlatest\RoomCheckingSystem\RoomCheckingSystem\Views\Dashboard\Housekeepingdata.cshtml"
WriteAttributeValue("", 4423, icon, 4423, 5, false);
=======
#line 78 "E:\gitrepos\RoomCheckingSystemlatest\RoomCheckingSystem\RoomCheckingSystem\Views\Dashboard\Housekeepingdata.cshtml"
WriteAttributeValue("", 4273, icon, 4273, 5, false);
>>>>>>> e0e6cc607651e60de56d0e4701bf5ec2ceee3e07

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 4428, "dashboardiconsize", 4429, 18, true);
            EndWriteAttribute();
            WriteLiteral("></span>\r\n                                    </div>\r\n\r\n                                    <div class=\"hidden-sm cxm-room-label\">\r\n                                        ");
#nullable restore
<<<<<<< HEAD
#line 84 "D:\Home\workspace\RoomCheckingSystemlatest\RoomCheckingSystem\RoomCheckingSystem\Views\Dashboard\Housekeepingdata.cshtml"
=======
#line 82 "E:\gitrepos\RoomCheckingSystemlatest\RoomCheckingSystem\RoomCheckingSystem\Views\Dashboard\Housekeepingdata.cshtml"
>>>>>>> e0e6cc607651e60de56d0e4701bf5ec2ceee3e07
                                   Write(statusname);

#line default
#line hidden
#nullable disable
            WriteLiteral("&nbsp;&nbsp;\r\n                                        <span");
            BeginWriteAttribute("class", " class=\"", 4689, "\"", 4731, 3);
#nullable restore
#line 85 "D:\Home\workspace\RoomCheckingSystemlatest\RoomCheckingSystem\RoomCheckingSystem\Views\Dashboard\Housekeepingdata.cshtml"
WriteAttributeValue("", 4697, icon, 4697, 5, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 4702, "cxm-room-icon-2", 4703, 16, true);
            WriteAttributeValue(" ", 4718, "hidden-md-up", 4719, 13, true);
            EndWriteAttribute();
            WriteLiteral(" style=\"margin-right:5px;\"></span>\r\n");
#nullable restore
#line 86 "D:\Home\workspace\RoomCheckingSystemlatest\RoomCheckingSystem\RoomCheckingSystem\Views\Dashboard\Housekeepingdata.cshtml"
                                          
                                            if (isprority == true)
                                            {


#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <img class=\"hidden-md-up\" src=\"https://www.hydeparkaparts.com/dev.roomchecking.hydeparkaparts.com/assets/admin/ssaq-data/media/cxm-icon-clock-2.png\" alt=\"Clock\" width=\"34\">\r\n");
#nullable restore
#line 91 "D:\Home\workspace\RoomCheckingSystemlatest\RoomCheckingSystem\RoomCheckingSystem\Views\Dashboard\Housekeepingdata.cshtml"
                                                
                                            }
                                            else if (clearningtime != "-1" && clearningtime != null && clearningtime != "")
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                                <img class=""hidden-md-up"" src=""https://www.hydeparkaparts.com/dev.roomchecking.hydeparkaparts.com/assets/admin/ssaq-data/media/cxm-icon-clock-2.png"" alt=""Clock"" width=""34"">
                                                <span class=""cxm-clock1 hidden-md-up""><img src=""https://www.hydeparkaparts.com/dev.roomchecking.hydeparkaparts.com/assets/admin/ssaq-data/media/cxm-icon-clock-3.png"" alt=""Clock"" width=""30""><br>");
#nullable restore
#line 96 "D:\Home\workspace\RoomCheckingSystemlatest\RoomCheckingSystem\RoomCheckingSystem\Views\Dashboard\Housekeepingdata.cshtml"
                                                                                                                                                                                                                                            Write(clearningtime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 97 "D:\Home\workspace\RoomCheckingSystemlatest\RoomCheckingSystem\RoomCheckingSystem\Views\Dashboard\Housekeepingdata.cshtml"

                                            }
                                        

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                                    </div>\r\n\r\n\r\n");
#nullable restore
<<<<<<< HEAD
#line 105 "D:\Home\workspace\RoomCheckingSystemlatest\RoomCheckingSystem\RoomCheckingSystem\Views\Dashboard\Housekeepingdata.cshtml"
=======
#line 92 "E:\gitrepos\RoomCheckingSystemlatest\RoomCheckingSystem\RoomCheckingSystem\Views\Dashboard\Housekeepingdata.cshtml"
>>>>>>> e0e6cc607651e60de56d0e4701bf5ec2ceee3e07
                                      
                                        if (isprority == true)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                            <div class=""row cxm-no-gutters hidden-sm-down"">
                                                <div class=""col-sm-6"" style=""font-weight: bold; text-align: justify;""></div>
                                                <div class=""col-sm-6 text-right"">
                                                    <img src=""https://www.hydeparkaparts.com/dev.roomchecking.hydeparkaparts.com/assets/admin/ssaq-data/media/cxm-icon-clock-2.png"" alt=""Clock"" width=""34"">
                                                </div>
                                            </div>
");
#nullable restore
#line 114 "D:\Home\workspace\RoomCheckingSystemlatest\RoomCheckingSystem\RoomCheckingSystem\Views\Dashboard\Housekeepingdata.cshtml"
                                        }
                                        else if (clearningtime.Length > 0)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <div class=\"row cxm-no-gutters hidden-sm-down\">\r\n                                                <div class=\"col-sm-6\" style=\"font-weight: bold; text-align: justify;\">");
#nullable restore
<<<<<<< HEAD
#line 118 "D:\Home\workspace\RoomCheckingSystemlatest\RoomCheckingSystem\RoomCheckingSystem\Views\Dashboard\Housekeepingdata.cshtml"
=======
#line 96 "E:\gitrepos\RoomCheckingSystemlatest\RoomCheckingSystem\RoomCheckingSystem\Views\Dashboard\Housekeepingdata.cshtml"
>>>>>>> e0e6cc607651e60de56d0e4701bf5ec2ceee3e07
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
<<<<<<< HEAD
#line 123 "D:\Home\workspace\RoomCheckingSystemlatest\RoomCheckingSystem\RoomCheckingSystem\Views\Dashboard\Housekeepingdata.cshtml"
=======
#line 101 "E:\gitrepos\RoomCheckingSystemlatest\RoomCheckingSystem\RoomCheckingSystem\Views\Dashboard\Housekeepingdata.cshtml"
>>>>>>> e0e6cc607651e60de56d0e4701bf5ec2ceee3e07
                                        }

                                    

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                                </div>\r\n                                \r\n                            </div>\r\n\r\n                        </div>\r\n");
#nullable restore
<<<<<<< HEAD
#line 133 "D:\Home\workspace\RoomCheckingSystemlatest\RoomCheckingSystem\RoomCheckingSystem\Views\Dashboard\Housekeepingdata.cshtml"
=======
#line 110 "E:\gitrepos\RoomCheckingSystemlatest\RoomCheckingSystem\RoomCheckingSystem\Views\Dashboard\Housekeepingdata.cshtml"
>>>>>>> e0e6cc607651e60de56d0e4701bf5ec2ceee3e07



                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n\r\n\r\n            </div>\r\n");
#nullable restore
<<<<<<< HEAD
#line 141 "D:\Home\workspace\RoomCheckingSystemlatest\RoomCheckingSystem\RoomCheckingSystem\Views\Dashboard\Housekeepingdata.cshtml"
=======
#line 118 "E:\gitrepos\RoomCheckingSystemlatest\RoomCheckingSystem\RoomCheckingSystem\Views\Dashboard\Housekeepingdata.cshtml"
>>>>>>> e0e6cc607651e60de56d0e4701bf5ec2ceee3e07

        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

    </div>

    <script type=""text/javascript"">
        var acc = document.getElementsByClassName(""accordion"");
        var i;
        for (i = 0; i < acc.length; i++) {
            acc[i].addEventListener(""click"", function () {
                this.classList.toggle(""active"");
                var panel = this.nextElementSibling;

                if (panel.style.maxHeight) {
                    panel.style.maxHeight = null;
                    panel.classList.add(""panelhide"");


                } else {

                    panel.classList.add(""panel"");
                    panel.style.maxHeight = panel.scrollHeight + ""px"";


                }
            });



        }

        $(document).ready(function () {
            openalltabs();
          
        });

        $(window).resize(function () {
            openalltabs();
        });

        function openalltabs() {

            var acc = document.getElementsByClassName(""accordion"");

            var i;
      ");
            WriteLiteral(@"      for (i = 0; i < acc.length; i++) {
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
