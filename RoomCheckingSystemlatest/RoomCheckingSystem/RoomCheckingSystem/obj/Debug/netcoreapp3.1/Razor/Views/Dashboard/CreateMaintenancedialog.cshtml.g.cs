#pragma checksum "D:\Home\workspace\RoomCheckingSystemlatest\RoomCheckingSystem\RoomCheckingSystem\Views\Dashboard\CreateMaintenancedialog.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "541f94a6669a90af32a221af9207e0757ce37ebe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Dashboard_CreateMaintenancedialog), @"mvc.1.0.view", @"/Views/Dashboard/CreateMaintenancedialog.cshtml")]
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
#line 1 "D:\Home\workspace\RoomCheckingSystemlatest\RoomCheckingSystem\RoomCheckingSystem\Views\Dashboard\CreateMaintenancedialog.cshtml"
using RoomCheckingSystem.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"541f94a6669a90af32a221af9207e0757ce37ebe", @"/Views/Dashboard/CreateMaintenancedialog.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8d45131c291c8e3ddfd71b7423b4d6c14b4ec6c8", @"/Views/_ViewImports.cshtml")]
    public class Views_Dashboard_CreateMaintenancedialog : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<StatusDetails>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 6 "D:\Home\workspace\RoomCheckingSystemlatest\RoomCheckingSystem\RoomCheckingSystem\Views\Dashboard\CreateMaintenancedialog.cshtml"
  
    Layout = "";

#line default
#line hidden
#nullable disable
            WriteLiteral("<style type=\"text/css\">\r\n    .removeshadow {\r\n        text-decoration: none;\r\n        box-shadow: none !important;\r\n        font-size: 14px;\r\n    }\r\n    .comments {\r\n    \r\n    }\r\n\r\n</style>\r\n");
#nullable restore
#line 20 "D:\Home\workspace\RoomCheckingSystemlatest\RoomCheckingSystem\RoomCheckingSystem\Views\Dashboard\CreateMaintenancedialog.cshtml"
 using (Html.BeginForm())
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<div id=\"divdynamic\">\r\n    <div id=\"contentdiv_1\" class=\"layout\">\r\n        <div class=\"row\" style=\"margin-top:20px;\">\r\n            <div class=\"col-sm-5\">\r\n                <div class=\"form-group\">\r\n\r\n                    ");
#nullable restore
#line 28 "D:\Home\workspace\RoomCheckingSystemlatest\RoomCheckingSystem\RoomCheckingSystem\Views\Dashboard\CreateMaintenancedialog.cshtml"
               Write(Html.DropDownListFor(model => model.intParentStatus, ViewBag.statusmainList as SelectList, new { @id = "ParendStatus_1", @class = "form-control", @onchange = "changedropdown(this.value,this.id)" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n                </div>\r\n            </div>\r\n            <div class=\"col-sm-2 text-center\"><span class=\"fa fa-angle-double-right\"></span></div>\r\n            <div class=\"col-sm-4\">\r\n                <div class=\"form-group\">\r\n\r\n                    ");
#nullable restore
#line 37 "D:\Home\workspace\RoomCheckingSystemlatest\RoomCheckingSystem\RoomCheckingSystem\Views\Dashboard\CreateMaintenancedialog.cshtml"
               Write(Html.DropDownListFor(model => model.intChildStatus, ViewBag.proritylist as SelectList, new { @id = "ChildStatus_1", @class = "form-control", @disabled = "disabled" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

                </div>
            </div>

            <span id=""btndelete_1"" onclick=""deleterow(this.id)"" class=""col-sm-1 col-lg-1 text-center mb-2 js-maintenance_combo_remove_task"">
                <a href=""#""><span class=""fa fa-times-circle text-red"" style=""font-size:20px; margin:6px 0;""></span></a>
            </span>

        </div>
        <div class=""form-group"">
            ");
#nullable restore
#line 48 "D:\Home\workspace\RoomCheckingSystemlatest\RoomCheckingSystem\RoomCheckingSystem\Views\Dashboard\CreateMaintenancedialog.cshtml"
       Write(Html.TextAreaFor(m => m.Description, new { @Value = "12", @id = "texdes_1", required = "required", disabled = "disabled", @class = "form-control removeshadow comments", autocomplete = "off", placeholder = "Type job description..." }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div style=\"height:4px; background-color:#555;\"></div>\r\n    </div>\r\n\r\n</div>\r\n");
#nullable restore
#line 54 "D:\Home\workspace\RoomCheckingSystemlatest\RoomCheckingSystem\RoomCheckingSystem\Views\Dashboard\CreateMaintenancedialog.cshtml"


}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<script type=""text/javascript"">
    $(document).ready(function () {
        if ($("".js-maintenance_combo_remove_task"").length > 1) {
            $("".js-maintenance_combo_remove_task"").show();
        } else {
            $("".js-maintenance_combo_remove_task"").hide();
        }

        loadparentStatus();

        $('body').on('change', '#ParendStatus', function () {
            
            //if ($(this).val() == ""-1"") {
                
            //    $(""#texdes"").attr(""disabled"", ""disabled"");
            //}
            //else {
                
            //    $(""#texdes"").removeAttr(""disabled"");
            //}
            

            //var customerID = $(this).val();
            //var $option = $(this).find('option:selected');
            //var isprority = $option.attr('isprority')
            //showhideprority();
            //showhidecheckout();
            /* var checkouttime = $option.attr('isCheckoutTime')*/


            //LoadCampaigns(customerID);


    ");
            WriteLiteral(@"    })


       
    });

    function deleterow(id) {
        var sp = id.split(""_"");
        var myobj = document.getElementById(""contentdiv_"" + sp[1]);
        if (confirm('Are you sure you want to Delete?')) {
            myobj.remove();
            if ($("".js-maintenance_combo_remove_task"").length == 1) {
                $("".js-maintenance_combo_remove_task"").hide();
            }
        }
        

    }
    function changedropdown(value,id) {

        var splitedvalue = id.split(""_"");

        if ($(""#ParendStatus_"" + splitedvalue[1]).val() == ""-1"") {
           
             $(""#texdes_"" + splitedvalue[1]).attr(""disabled"", ""disabled"");
            $(""#ChildStatus_"" + splitedvalue[1]).attr(""disabled"", ""disabled"");
            }
        else {
            
             $(""#texdes_"" + splitedvalue[1]).removeAttr(""disabled"");
            $(""#ChildStatus_"" + splitedvalue[1]).removeAttr(""disabled"");
            }
        
    }

    function showhideprority() {
        v");
            WriteLiteral(@"ar $option = $('#ParendStatus').find('option:selected');
        var isprority = $option.attr('isprority')
        if (isprority) {


            document.getElementById(""tvpro"").style.display = ""block"";

        }
        else {

            document.getElementById(""tvpro"").style.display = ""none"";

        }
    }

    function showhidecheckout() {
        var $option = $('#ParendStatus').find('option:selected');
        var isprority = $option.attr('isCheckoutTime')
        if (isprority) {


            document.getElementById(""tvtime"").style.display = ""block"";

        }
        else {

            document.getElementById(""tvtime"").style.display = ""none"";

        }
    }


    function loadparentStatus() {
        var $parent = $('#ParendStatus').val();

        var id = $parent;
        Parentstatus;
        //ChildStatus


        //var task = {
        //    Title: $(""#intParentID"").val(),
        //    Description: ""zahid"",
        //    Owner: ""Tax Asaan""
");
            WriteLiteral(@"        //};
        ////alert(JSON.stringify(task));

        $.ajax({
            url: '/Dashboard/GetmainparentList',
            type: 'GET',
            data: { 'id': id },
            dataType: 'json',
            success: function (d) {
                var s = '<option value=""-1"">--Select main status--</option>';

                for (var i = 0; i < d.length; i++) {

                    if (d[i].intSeqID == Parentstatus) {
                        var selected = ""selected"";
                        s += '<option ' + selected + ' style=""color:' + d[i].color + '"" value=""' + d[i].intSeqID + '"" isprority=""' + d[i].isPriority + '"" isCheckoutTime=""' + d[i].isCheckoutTime + '"">' + d[i].text + '</option>';
                    }
                    else {
                        s += '<option style=""color:' + d[i].color + '"" value=""' + d[i].intSeqID + '"" isprority=""' + d[i].isPriority + '"" isCheckoutTime=""' + d[i].isCheckoutTime + '"">' + d[i].text + '</option>';
                    }

       ");
            WriteLiteral(@"         }
                $(""#ParendStatus"").html(s);

                if ($(""#ParendStatus"").val() > 0) {
                    // LoadCampaigns($(""#ParendStatus"").val())
                }
                //showhideprority();
                //showhidecheckout()

            },
            error: function (r) {

                alert(r);
            }
        });
    }

    function LoadCampaigns(customerID) {


        $.ajax({
            url: '/Dashboard/GetList',
            type: 'GET',
            data: { 'customerID': customerID },
            dataType: 'json',
            success: function (d) {
                var s = '<option value=""-1"">--Select sub status--</option>';

                for (var i = 0; i < d.length; i++) {

                    if (d[i].intSeqID == ChildStatus) {

                        var selected = ""selected"";
                        s += '<option ' + selected + ' style=""color:' + d[i].color + '"" value=""' + d[i].intSeqID + '"" isprority=""' + d[i].is");
            WriteLiteral(@"Priority + '"" isCheckoutTime=""' + d[i].isCheckoutTime + '"">' + d[i].text + '</option>';
                    }
                    else {

                        s += '<option style=""color:' + d[i].color + '"" value=""' + d[i].intSeqID + '"" isprority=""' + d[i].isPriority + '"" isCheckoutTime=""' + d[i].isCheckoutTime + '"">' + d[i].text + '</option>';

                    }
                }
                $(""#ChildStatus"").html(s);
                //showhideprority();
                //showhidecheckout()

            },
            error: function (r) {

                alert(r);
            }
        });
    }

</script>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<StatusDetails> Html { get; private set; }
    }
}
#pragma warning restore 1591
