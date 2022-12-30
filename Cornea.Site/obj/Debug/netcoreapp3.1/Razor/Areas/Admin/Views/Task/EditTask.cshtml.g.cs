#pragma checksum "F:\DuratInstruments\Cornea\Cornea.Site\Areas\Admin\Views\Task\EditTask.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7f5ba7b6d45027ba30281e9eee3054498a3c425a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Task_EditTask), @"mvc.1.0.view", @"/Areas/Admin/Views/Task/EditTask.cshtml")]
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
#line 1 "F:\DuratInstruments\Cornea\Cornea.Site\Areas\Admin\Views\Task\EditTask.cshtml"
using Cornea.Application.Services.Task.Queries.FindTasks;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\DuratInstruments\Cornea\Cornea.Site\Areas\Admin\Views\Task\EditTask.cshtml"
using Cornea.Common.Dto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\DuratInstruments\Cornea\Cornea.Site\Areas\Admin\Views\Task\EditTask.cshtml"
using Cornea.Application.Services.Project.Queries.GetProjects;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "F:\DuratInstruments\Cornea\Cornea.Site\Areas\Admin\Views\Task\EditTask.cshtml"
using Cornea.Application.Services.Users.Queries.GetUsers;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7f5ba7b6d45027ba30281e9eee3054498a3c425a", @"/Areas/Admin/Views/Task/EditTask.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_Task_EditTask : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Tuple<ResultDto<ResultFindTasksService>, ResultGetProjecsDto, ResultGetUsersDto>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 6 "F:\DuratInstruments\Cornea\Cornea.Site\Areas\Admin\Views\Task\EditTask.cshtml"
  
    ViewData["Title"] = "EditTask";
    Layout = "~/Areas/Admin/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""content-wrapper"">
    <!-- Page header -->
    <div class=""page-header"">
        <div class=""page-header-content"">
            <div class=""page-title"">
                <h4><i class=""icon-arrow-left52 position-left""></i> <span class=""text-semibold"">Tasks</span> - Edit Task</h4>
                <a class=""heading-elements-toggle""><i class=""icon-more""></i></a>
            </div>
            <div class=""heading-elements"">
                <div class=""heading-btn-group"">
                    <a href=""#"" class=""btn btn-link btn-float text-size-small has-text legitRipple""><i class=""icon-bars-alt text-primary""></i><span>Statistics</span></a>
                    <a href=""#"" class=""btn btn-link btn-float text-size-small has-text legitRipple""><i class=""icon-calculator text-primary""></i> <span>Invoices</span></a>
                    <a href=""#"" class=""btn btn-link btn-float text-size-small has-text legitRipple""><i class=""icon-calendar5 text-primary""></i> <span>Schedule</span></a>
                <");
            WriteLiteral(@"/div>
            </div>
        </div>
        <div class=""breadcrumb-line breadcrumb-line-component"">
            <a class=""breadcrumb-elements-toggle""><i class=""icon-menu-open""></i></a>
            <ul class=""breadcrumb"">
                <li><a href=""index.html""><i class=""icon-home2 position-left""></i> Admin</a></li>
                <li><a href=""datatable_extension_select.html"">Tasks</a></li>
                <li class=""active"">Edit Task</li>
            </ul>
            <ul class=""breadcrumb-elements"">
                <li><a href=""#"" class=""legitRipple""><i class=""icon-comment-discussion position-left""></i> Support</a></li>
                <li class=""dropdown"">
                    <a href=""#"" class=""dropdown-toggle legitRipple"" data-toggle=""dropdown"">
                        <i class=""icon-gear position-left""></i>
                        Settings
                        <span class=""caret""></span>
                    </a>
                    <ul class=""dropdown-menu dropdown-menu-right"">");
            WriteLiteral(@"
                        <li><a href=""#""><i class=""icon-user-lock""></i> Account security</a></li>
                        <li><a href=""#""><i class=""icon-statistics""></i> Analytics</a></li>
                        <li><a href=""#""><i class=""icon-accessibility""></i> Accessibility</a></li>
                        <li class=""divider""></li>
                        <li><a href=""#""><i class=""icon-gear""></i> All settings</a></li>
                    </ul>
                </li>
            </ul>
        </div>
    </div>
    <!-- /page header -->
    <!-- Content area -->
    <div class=""content"">
        <!-- Daterange picker -->
        <div class=""panel panel-flat"">
            <div class=""panel-body"">
                <div class=""row"">
                    <fieldset>
                        <legend class=""text-semibold""><i class=""icon-reading position-left""></i> Task details</legend>
                        <div class=""col-md-6"">
                            <div class=""form-group"">
              ");
            WriteLiteral("                  <label class=\"display-block\">Project:</label>\r\n                                <select class=\"select\" id=\"ProjectName\">\r\n");
#nullable restore
#line 66 "F:\DuratInstruments\Cornea\Cornea.Site\Areas\Admin\Views\Task\EditTask.cshtml"
                                     foreach (var data in Model.Item2.projectslist)
                                    {                                      

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <option  ");
#nullable restore
#line 68 "F:\DuratInstruments\Cornea\Cornea.Site\Areas\Admin\Views\Task\EditTask.cshtml"
                                                  if (Model.Item1.Data.ProjectName == data.ProjectName) { 

#line default
#line hidden
#nullable disable
            WriteLiteral(" selected=\"selected\" ");
#nullable restore
#line 68 "F:\DuratInstruments\Cornea\Cornea.Site\Areas\Admin\Views\Task\EditTask.cshtml"
                                                                                                                                             }

#line default
#line hidden
#nullable disable
            WriteLiteral(">");
#nullable restore
#line 68 "F:\DuratInstruments\Cornea\Cornea.Site\Areas\Admin\Views\Task\EditTask.cshtml"
                                                                                                                                          Write(data.ProjectName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 69 "F:\DuratInstruments\Cornea\Cornea.Site\Areas\Admin\Views\Task\EditTask.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                </select>
                            </div>
                            <div class=""form-group"">
                                <label>Task Name:</label>
                                <input type=""text"" class=""form-control"" id=""TaskName""");
            BeginWriteAttribute("value", " value=\"", 4265, "\"", 4299, 1);
#nullable restore
#line 74 "F:\DuratInstruments\Cornea\Cornea.Site\Areas\Admin\Views\Task\EditTask.cshtml"
WriteAttributeValue("", 4273, Model.Item1.Data.TaskName, 4273, 26, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" placeholder=""Enter project name"">
                            </div>
                            <br />
                            <div class=""form-group"" hidden=""hidden"">
                                <input type=""text"" class=""form-control"" id=""TaskId""");
            BeginWriteAttribute("value", " value=\"", 4561, "\"", 4589, 1);
#nullable restore
#line 78 "F:\DuratInstruments\Cornea\Cornea.Site\Areas\Admin\Views\Task\EditTask.cshtml"
WriteAttributeValue("", 4569, Model.Item1.Data.Id, 4569, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" placeholder=\"Enter project name\">\r\n                            </div>\r\n");
            WriteLiteral(@"                            <br />
                            <div class=""form-group"">
                                <label class=""display-block"">Status:</label>
                                <select class=""select"" id=""Status"">
                                    <option value=""Not Started"" ");
#nullable restore
#line 89 "F:\DuratInstruments\Cornea\Cornea.Site\Areas\Admin\Views\Task\EditTask.cshtml"
                                                                 if (Model.Item1.Data.Status == "Not Started") { 

#line default
#line hidden
#nullable disable
            WriteLiteral(" selected=\"selected\" ");
#nullable restore
#line 89 "F:\DuratInstruments\Cornea\Cornea.Site\Areas\Admin\Views\Task\EditTask.cshtml"
                                                                                                                                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(">Not Started</option>\r\n                                    <option value=\"Is Working\" ");
#nullable restore
#line 90 "F:\DuratInstruments\Cornea\Cornea.Site\Areas\Admin\Views\Task\EditTask.cshtml"
                                                                if (Model.Item1.Data.Status == "Is Working") { 

#line default
#line hidden
#nullable disable
            WriteLiteral(" selected=\"selected\" ");
#nullable restore
#line 90 "F:\DuratInstruments\Cornea\Cornea.Site\Areas\Admin\Views\Task\EditTask.cshtml"
                                                                                                                                                  }

#line default
#line hidden
#nullable disable
            WriteLiteral(">Is Working</option>\r\n                                    <option value=\"Completed\" ");
#nullable restore
#line 91 "F:\DuratInstruments\Cornea\Cornea.Site\Areas\Admin\Views\Task\EditTask.cshtml"
                                                               if (Model.Item1.Data.Status == "Completed") { 

#line default
#line hidden
#nullable disable
            WriteLiteral(" selected=\"selected\" ");
#nullable restore
#line 91 "F:\DuratInstruments\Cornea\Cornea.Site\Areas\Admin\Views\Task\EditTask.cshtml"
                                                                                                                                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@">Completed</option>
                                </select>
                            </div>
                            <br />
                            <div class=""form-group"">
                                <label class=""display-block"">Priority:</label>
                                <select class=""select"" id=""Priority"">
                                    <option style=""background-color: blue!important"" value=""Low"" ");
#nullable restore
#line 98 "F:\DuratInstruments\Cornea\Cornea.Site\Areas\Admin\Views\Task\EditTask.cshtml"
                                                                                                  if (Model.Item1.Data.Priority == "Low") { 

#line default
#line hidden
#nullable disable
            WriteLiteral(" selected=\"selected\" ");
#nullable restore
#line 98 "F:\DuratInstruments\Cornea\Cornea.Site\Areas\Admin\Views\Task\EditTask.cshtml"
                                                                                                                                                                               }

#line default
#line hidden
#nullable disable
            WriteLiteral(">Low</option>\r\n                                    <option style=\"background-color: green!important\" value=\"Medium\" ");
#nullable restore
#line 99 "F:\DuratInstruments\Cornea\Cornea.Site\Areas\Admin\Views\Task\EditTask.cshtml"
                                                                                                      if (Model.Item1.Data.Priority == "Medium") { 

#line default
#line hidden
#nullable disable
            WriteLiteral(" selected=\"selected\" ");
#nullable restore
#line 99 "F:\DuratInstruments\Cornea\Cornea.Site\Areas\Admin\Views\Task\EditTask.cshtml"
                                                                                                                                                                                      }

#line default
#line hidden
#nullable disable
            WriteLiteral(">Medium</option>\r\n                                    <option style=\"background-color: red!important\" value=\"High\" ");
#nullable restore
#line 100 "F:\DuratInstruments\Cornea\Cornea.Site\Areas\Admin\Views\Task\EditTask.cshtml"
                                                                                                  if (Model.Item1.Data.Priority == "High") { 

#line default
#line hidden
#nullable disable
            WriteLiteral(" selected=\"selected\" ");
#nullable restore
#line 100 "F:\DuratInstruments\Cornea\Cornea.Site\Areas\Admin\Views\Task\EditTask.cshtml"
                                                                                                                                                                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@">High</option>
                                </select>
                            </div>
                            <br />
                            <div class=""form-group"">
                                <label>Your Description:</label>
                                <input rows=""4"" class=""form-control"" id=""Message""");
            BeginWriteAttribute("value", " value=\"", 6904, "\"", 6937, 1);
#nullable restore
#line 106 "F:\DuratInstruments\Cornea\Cornea.Site\Areas\Admin\Views\Task\EditTask.cshtml"
WriteAttributeValue("", 6912, Model.Item1.Data.Message, 6912, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" placeholder=""Enter your description here"" />
                            </div>
                        </div>
                        <div class=""col-md-6"">
                            <div class=""form-group"">
                                <label>Deadline: </label>
                                <div class=""input-group"">
                                    <input id=""DateRange"" type=""text"" class=""form-control daterange-datemenu""");
            BeginWriteAttribute("value", " value=\"", 7382, "\"", 7448, 3);
#nullable restore
#line 113 "F:\DuratInstruments\Cornea\Cornea.Site\Areas\Admin\Views\Task\EditTask.cshtml"
WriteAttributeValue("", 7390, Model.Item1.Data.StartTime, 7390, 27, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 7417, "-", 7418, 2, true);
#nullable restore
#line 113 "F:\DuratInstruments\Cornea\Cornea.Site\Areas\Admin\Views\Task\EditTask.cshtml"
WriteAttributeValue(" ", 7419, Model.Item1.Data.FinishTime, 7420, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                                    <span class=""input-group-addon""><i class=""icon-calendar22""></i></span>
                                </div>
                            </div>
                        </div>
                    </fieldset>
                </div>
                <div class=""text-right"">
                    <button type=""submit"" onclick=""Save()"" class=""btn btn-primary legitRipple"">Update<i class=""icon-arrow-right14 position-right""></i></button>
                </div>
            </div>
        </div>
        <!-- /daterange picker -->
    </div>
    <!-- /content area -->
</div>
<!-- /main content -->
<script>
    function Save() {

        var TaskId = $(""#TaskId"").val();
        var ProjectName = document.getElementById(""ProjectName"").value;
        var TaskName = $(""#TaskName"").val();
        var Status = document.getElementById(""Status"").value;
        var Priority = document.getElementById(""Priority"").value;
        var DateRange = $(""#DateRange"").val();
   ");
            WriteLiteral(@"     var Message = $(""#Message"").val();

        var postData = {
            'TaskId': TaskId,
            'ProjectName': ProjectName,
            'TaskName': TaskName,
            'Status': Status,
            'Priority': Priority,
            'DateRange': DateRange,
            'Message': Message
        };
        $.ajax({
            contentType: 'application/x-www-form-urlencoded',
            dataType: 'json',
            type: ""POST"",
            url: ""EditTask"",
            data: postData,
            success: function (data) {
                if (data.isSuccess == true) {
                    swal({
                        title: ""Updated!"",
                        text: data.message,
                        type: ""success""
                    }, function () { window.location.href = ""Tasks""; });
                }
                else {
                    swal({
                        title: ""Warning!"",
                        text: data.message,
                        ");
            WriteLiteral(@"type: ""warning""
                    }, function () { location.reload(true); });
                }
            },
            error: function (request, status, error) {
                swal({
                    title: ""Warning!"",
                    text: request.responseText,
                    type: ""warning""
                }, function () { location.reload(true); });
            }
        });
    }
</script>
");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Tuple<ResultDto<ResultFindTasksService>, ResultGetProjecsDto, ResultGetUsersDto>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
