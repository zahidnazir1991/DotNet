#pragma checksum "E:\gitrepos\RoomCheckingSystemlatest\RoomCheckingSystem\RoomCheckingSystem\Views\Dashboard\Createdialog.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "56639b2c3391e8ce0ad159e407af226b5f6a64fb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Dashboard_Createdialog), @"mvc.1.0.view", @"/Views/Dashboard/Createdialog.cshtml")]
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
#line 1 "E:\gitrepos\RoomCheckingSystemlatest\RoomCheckingSystem\RoomCheckingSystem\Views\Dashboard\Createdialog.cshtml"
using RoomCheckingSystem.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"56639b2c3391e8ce0ad159e407af226b5f6a64fb", @"/Views/Dashboard/Createdialog.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8d45131c291c8e3ddfd71b7423b4d6c14b4ec6c8", @"/Views/_ViewImports.cshtml")]
    public class Views_Dashboard_Createdialog : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<StatusDetails>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "-1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "11:30:00", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "12:00:00", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "12:30:00", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "13:00:00", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "13:30:00", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "14:00:00", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 6 "E:\gitrepos\RoomCheckingSystemlatest\RoomCheckingSystem\RoomCheckingSystem\Views\Dashboard\Createdialog.cshtml"
  
    Layout = "";

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\gitrepos\RoomCheckingSystemlatest\RoomCheckingSystem\RoomCheckingSystem\Views\Dashboard\Createdialog.cshtml"
 using (Html.BeginForm())
{


#line default
#line hidden
#nullable disable
            WriteLiteral("    <div id=\"contentdiv_1\" class=\"layout\">\r\n        <div class=\"row\" style=\"margin-top:20px;\">\r\n            <div class=\"col-sm-5\">\r\n                <div class=\"form-group\">\r\n\r\n                    ");
#nullable restore
#line 17 "E:\gitrepos\RoomCheckingSystemlatest\RoomCheckingSystem\RoomCheckingSystem\Views\Dashboard\Createdialog.cshtml"
               Write(Html.DropDownListFor(model => model.intParentStatus, ViewBag.statusList as SelectList, new { @id = "ParendStatus", @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                </div>\r\n            </div>\r\n            <div class=\"col-sm-2 text-center\"><span class=\"fa fa-angle-double-right\"></span></div>\r\n            <div class=\"col-sm-5\">\r\n                <div class=\"form-group\">\r\n\r\n                    ");
#nullable restore
#line 25 "E:\gitrepos\RoomCheckingSystemlatest\RoomCheckingSystem\RoomCheckingSystem\Views\Dashboard\Createdialog.cshtml"
               Write(Html.DropDownListFor(model => model.intChildStatus, ViewBag.childstatusList as SelectList, new { @id = "ChildStatus", @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                </div>\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"row\" id=\"js-priority_div\">\r\n\r\n            <div class=\"col-sm-6 margin-bottom js-is_priority_div\" id=\"tvpro\" style=\"display:none\">\r\n                <div class=\"row\"");
            BeginWriteAttribute("style", " style=\"", 1217, "\"", 1225, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                    <div class=""col-sm-12"">
                        <label>
                            <input type=""checkbox"" id=""js-is_priority"" value=""1"" data-selected_status="""" data-selected="""" onclick=""show_save_btn ();""> Mark with priority
                        </label>
                    </div>
                </div>
            </div>

            <div class=""col-sm-6 margin-bottom js-priority_time_div"" id=""tvtime"" style=""display:none"">
                <div class=""row""");
            BeginWriteAttribute("style", " style=\"", 1722, "\"", 1730, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                    <div class=""col-sm-6""><label for=""cxmChkout"" class=""control-label"">Cleaning Time</label></div>
                    <div class=""col-sm-6"">

                        <select class=""form-control"" id=""js-priority_time"" data-selected_status="""" data-selected="""" onchange = ""cleaningtimedropdown()"" $('#js-is_priority').prop('checked',false);"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "56639b2c3391e8ce0ad159e407af226b5f6a64fb8493", async() => {
                WriteLiteral(" - Select - ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "56639b2c3391e8ce0ad159e407af226b5f6a64fb9690", async() => {
                WriteLiteral("11:30");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "56639b2c3391e8ce0ad159e407af226b5f6a64fb10876", async() => {
                WriteLiteral("12:00");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "56639b2c3391e8ce0ad159e407af226b5f6a64fb12063", async() => {
                WriteLiteral("12:30");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "56639b2c3391e8ce0ad159e407af226b5f6a64fb13250", async() => {
                WriteLiteral("13:00");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "56639b2c3391e8ce0ad159e407af226b5f6a64fb14437", async() => {
                WriteLiteral("13:30");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "56639b2c3391e8ce0ad159e407af226b5f6a64fb15624", async() => {
                WriteLiteral("14:00");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </select>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n        </div>\r\n");
#nullable restore
#line 63 "E:\gitrepos\RoomCheckingSystemlatest\RoomCheckingSystem\RoomCheckingSystem\Views\Dashboard\Createdialog.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        <script type=""text/javascript"">
            $(document).ready(function () {
                loadparentStatus();

           
                $('body').on('change', '#ParendStatus', function () {

                    var customerID = $(this).val();
                    var $option = $(this).find('option:selected');
                    var isprority = $option.attr('isprority')
                    showhideprority();
                    showhidecheckout();
                    /* var checkouttime = $option.attr('isCheckoutTime')*/


                    LoadCampaigns(customerID);


                });



           
            });

            $(""#js-is_priority"").change(function () {
                var ischecked = $(this).is(':checked');
                var def = ""-1"";
                if (ischecked) {
                    $(""#js-priority_time"").val(def).change();
                 
               //$('#js-priority_time').val(-1)
                }
                    
    ");
            WriteLiteral(@"        });

            function cleaningtimedropdown() {
                if ($('#js-priority_time').val() != -1) {
                    $('#js-is_priority').prop('checked', false);
                }
            }

            function showhideprority() {
                var $option = $('#ParendStatus').find('option:selected');
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
");
            WriteLiteral(@"
                    document.getElementById(""tvtime"").style.display = ""none"";

                }
            }
            //function LoadCampaigns(customerID) {
            //    var $campaign = $('#intSeqID');
            //    alert($campaign);

            //    $.ajax({
            //        url: '/Dashboard/GetList',
            //        type: 'GET',
            //        data: { 'customerID': customerID },
            //        dataType: 'json',
            //        success: function (d) {
            //            $campaign.empty();
            //            $campaign.append($('<option></option>').val('').html(""-- Select --""));
            //            $.each(d, function (i, val) {

            //                $state.append($('<option></option>').val(val.intSeqID).html(val.StatusName));
            //            });
            //        }
            //    });
            //}

            function loadparentStatus() {

                var $parent = $('#ParendStatus').");
            WriteLiteral(@"val();

                var id = $parent;
                Parentstatus;
                //ChildStatus


                //var task = {
                //    Title: $(""#intParentID"").val(),
                //    Description: ""zahid"",
                //    Owner: ""Tax Asaan""
                //};
                ////alert(JSON.stringify(task));

                $.ajax({
                    url: '/Dashboard/GetparentList',
                    type: 'GET',
                    data: { 'id': id },
                    dataType: 'json',
                    success: function (d) {
                        var s = '<option value=""-1"">--Select main status--</option>';

                        for (var i = 0; i < d.length; i++) {

                            if (d[i].intSeqID == Parentstatus) {
                                var selected = ""selected"";
                                s += '<option ' + selected + ' style=""color:' + d[i].color + '"" value=""' + d[i].intSeqID + '"" isprority=""' + d[i].i");
            WriteLiteral(@"sPriority + '"" isCheckoutTime=""' + d[i].isCheckoutTime + '"">' + d[i].text + '</option>';
                            }
                            else {
                                s += '<option style=""color:' + d[i].color + '"" value=""' + d[i].intSeqID + '"" isprority=""' + d[i].isPriority + '"" isCheckoutTime=""' + d[i].isCheckoutTime + '"">' + d[i].text + '</option>';
                            }

                        }
                        $(""#ParendStatus"").html(s);

                        if ($(""#ParendStatus"").val() > 0) {
                            LoadCampaigns($(""#ParendStatus"").val())
                        }
                        showhideprority();
                        showhidecheckout()

                    },
                    error: function (r) {

                        alert(r);
                    }
                });
            }

            function LoadCampaigns(customerID) {


                $.ajax({
                    url: '/Dashboard/Get");
            WriteLiteral(@"List',
                    type: 'GET',
                    data: { 'customerID': customerID },
                    dataType: 'json',
                    success: function (d) {
                        var s = '<option value=""-1"">--Select sub status--</option>';

                        for (var i = 0; i < d.length; i++) {

                            if (d[i].intSeqID == ChildStatus) {

                                var selected = ""selected"";
                                s += '<option ' + selected + ' style=""color:' + d[i].color + '"" value=""' + d[i].intSeqID + '"" isprority=""' + d[i].isPriority + '"" isCheckoutTime=""' + d[i].isCheckoutTime + '"">' + d[i].text + '</option>';
                            }
                            else {

                                s += '<option style=""color:' + d[i].color + '"" value=""' + d[i].intSeqID + '"" isprority=""' + d[i].isPriority + '"" isCheckoutTime=""' + d[i].isCheckoutTime + '"">' + d[i].text + '</option>';

                            }
   ");
            WriteLiteral(@"                     }
                        $(""#ChildStatus"").html(s);
                        showhideprority();
                        showhidecheckout()

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
