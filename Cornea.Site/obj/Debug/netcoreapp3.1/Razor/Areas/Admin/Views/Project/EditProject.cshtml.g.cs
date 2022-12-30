#pragma checksum "F:\DuratInstruments\Cornea\Cornea.Site\Areas\Admin\Views\Project\EditProject.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d119ec93d8eafe0a2c5eda1b5e46160ea9652932"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Project_EditProject), @"mvc.1.0.view", @"/Areas/Admin/Views/Project/EditProject.cshtml")]
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
#line 1 "F:\DuratInstruments\Cornea\Cornea.Site\Areas\Admin\Views\Project\EditProject.cshtml"
using Cornea.Application.Services.Project.Queries.FindProjects;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\DuratInstruments\Cornea\Cornea.Site\Areas\Admin\Views\Project\EditProject.cshtml"
using Cornea.Common.Dto;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d119ec93d8eafe0a2c5eda1b5e46160ea9652932", @"/Areas/Admin/Views/Project/EditProject.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_Project_EditProject : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ResultDto<ResultFindProjectsService>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "F:\DuratInstruments\Cornea\Cornea.Site\Areas\Admin\Views\Project\EditProject.cshtml"
  
    ViewData["Title"] = "EditProject";
    Layout = "~/Areas/Admin/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- Main content -->
    <div class=""content-wrapper"">
        <!-- Page header -->
        <div class=""page-header"">
            <div class=""page-header-content"">
                <div class=""page-title"">
                    <h4><i class=""icon-arrow-left52 position-left""></i> <span class=""text-semibold"">Projects</span> - Edit Project</h4>
                    <a class=""heading-elements-toggle""><i class=""icon-more""></i></a>
                </div>
                <div class=""heading-elements"">
                    <div class=""heading-btn-group"">
                        <a href=""#"" class=""btn btn-link btn-float text-size-small has-text legitRipple""><i class=""icon-bars-alt text-primary""></i><span>Statistics</span></a>
                        <a href=""#"" class=""btn btn-link btn-float text-size-small has-text legitRipple""><i class=""icon-calculator text-primary""></i> <span>Invoices</span></a>
                        <a href=""#"" class=""btn btn-link btn-float text-size-small has-text legitRipple""><i clas");
            WriteLiteral(@"s=""icon-calendar5 text-primary""></i> <span>Schedule</span></a>
                    </div>
                </div>
            </div>
            <div class=""breadcrumb-line breadcrumb-line-component"">
                <a class=""breadcrumb-elements-toggle""><i class=""icon-menu-open""></i></a>
                <ul class=""breadcrumb"">
                    <li><a href=""index.html""><i class=""icon-home2 position-left""></i> Home</a></li>
                    <li><a href=""datatable_extension_select.html"">Projects</a></li>
                    <li class=""active"">Edit Project</li>
                </ul>
                <ul class=""breadcrumb-elements"">
                    <li><a href=""#"" class=""legitRipple""><i class=""icon-comment-discussion position-left""></i> Support</a></li>
                    <li class=""dropdown"">
                        <a href=""#"" class=""dropdown-toggle legitRipple"" data-toggle=""dropdown"">
                            <i class=""icon-gear position-left""></i>
                            Settin");
            WriteLiteral(@"gs
                            <span class=""caret""></span>
                        </a>
                        <ul class=""dropdown-menu dropdown-menu-right"">
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
");
            WriteLiteral(@"                            <legend class=""text-semibold""><i class=""icon-reading position-left""></i> Edit Project</legend>
                            <div class=""col-md-6"">
                                <div class=""form-group"">
                                    <label>Project Name:<span class=""text-danger"">*</span></label>
                                    <input type=""text"" required=""required"" class=""form-control"" id=""ProjectName""");
            BeginWriteAttribute("value", " value=\"", 3766, "\"", 3797, 1);
#nullable restore
#line 65 "F:\DuratInstruments\Cornea\Cornea.Site\Areas\Admin\Views\Project\EditProject.cshtml"
WriteAttributeValue("", 3774, Model.Data.ProjectName, 3774, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" placeholder=""Enter project name"">
                                </div>
                                <br />
                                <div class=""form-group"" hidden=""hidden"">
                                    <input class=""form-control"" id=""ProjectId""");
            BeginWriteAttribute("value", " value=\"", 4066, "\"", 4088, 1);
#nullable restore
#line 69 "F:\DuratInstruments\Cornea\Cornea.Site\Areas\Admin\Views\Project\EditProject.cshtml"
WriteAttributeValue("", 4074, Model.Data.Id, 4074, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />
                                </div>
                                <div class=""form-group"">
                                    <label class=""display-block"">Status:<span class=""text-danger"">*</span></label>
                                    <select class=""select"" id=""Status"" required=""required"">
                                        <option value=""Not Started"" ");
#nullable restore
#line 74 "F:\DuratInstruments\Cornea\Cornea.Site\Areas\Admin\Views\Project\EditProject.cshtml"
                                                                     if (Model.Data.Status == "Not Started") { 

#line default
#line hidden
#nullable disable
            WriteLiteral(" selected=\"selected\" ");
#nullable restore
#line 74 "F:\DuratInstruments\Cornea\Cornea.Site\Areas\Admin\Views\Project\EditProject.cshtml"
                                                                                                                                                  }

#line default
#line hidden
#nullable disable
            WriteLiteral(">Not Started</option>\r\n                                        <option value=\"Is Working\" ");
#nullable restore
#line 75 "F:\DuratInstruments\Cornea\Cornea.Site\Areas\Admin\Views\Project\EditProject.cshtml"
                                                                    if (Model.Data.Status == "Is Working") { 

#line default
#line hidden
#nullable disable
            WriteLiteral(" selected=\"selected\" ");
#nullable restore
#line 75 "F:\DuratInstruments\Cornea\Cornea.Site\Areas\Admin\Views\Project\EditProject.cshtml"
                                                                                                                                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(">Is Working</option>\r\n                                        <option value=\"Completed\" ");
#nullable restore
#line 76 "F:\DuratInstruments\Cornea\Cornea.Site\Areas\Admin\Views\Project\EditProject.cshtml"
                                                                   if (Model.Data.Status == "Completed") { 

#line default
#line hidden
#nullable disable
            WriteLiteral(" selected=\"selected\" ");
#nullable restore
#line 76 "F:\DuratInstruments\Cornea\Cornea.Site\Areas\Admin\Views\Project\EditProject.cshtml"
                                                                                                                                              }

#line default
#line hidden
#nullable disable
            WriteLiteral(@">Completed</option>
                                    </select>
                                </div>
                                <br />
                                <div class=""form-group"">
                                    <label class=""display-block"">Priority:<span class=""text-danger"">*</span></label>
                                    <select class=""select"" id=""Priority"" required=""required"">
                                        <option style=""background-color: blue!important"" value=""Low"" ");
#nullable restore
#line 83 "F:\DuratInstruments\Cornea\Cornea.Site\Areas\Admin\Views\Project\EditProject.cshtml"
                                                                                                      if (Model.Data.Priority == "Low") { 

#line default
#line hidden
#nullable disable
            WriteLiteral(" selected=\"selected\" ");
#nullable restore
#line 83 "F:\DuratInstruments\Cornea\Cornea.Site\Areas\Admin\Views\Project\EditProject.cshtml"
                                                                                                                                                                             }

#line default
#line hidden
#nullable disable
            WriteLiteral(">Low</option>\r\n                                        <option style=\"background-color: green!important\" value=\"Medium\" ");
#nullable restore
#line 84 "F:\DuratInstruments\Cornea\Cornea.Site\Areas\Admin\Views\Project\EditProject.cshtml"
                                                                                                          if (Model.Data.Priority == "Medium") { 

#line default
#line hidden
#nullable disable
            WriteLiteral(" selected=\"selected\" ");
#nullable restore
#line 84 "F:\DuratInstruments\Cornea\Cornea.Site\Areas\Admin\Views\Project\EditProject.cshtml"
                                                                                                                                                                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(">Medium</option>\r\n                                        <option style=\"background-color: red!important\" value=\"High\" ");
#nullable restore
#line 85 "F:\DuratInstruments\Cornea\Cornea.Site\Areas\Admin\Views\Project\EditProject.cshtml"
                                                                                                      if (Model.Data.Priority == "High") { 

#line default
#line hidden
#nullable disable
            WriteLiteral(" selected=\"selected\" ");
#nullable restore
#line 85 "F:\DuratInstruments\Cornea\Cornea.Site\Areas\Admin\Views\Project\EditProject.cshtml"
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
            BeginWriteAttribute("value", " value=\"", 6219, "\"", 6246, 1);
#nullable restore
#line 91 "F:\DuratInstruments\Cornea\Cornea.Site\Areas\Admin\Views\Project\EditProject.cshtml"
WriteAttributeValue("", 6227, Model.Data.Message, 6227, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" placeholder=""Enter your description here"" />
                                </div>
                            </div>
                            <div class=""col-md-6"">
                                <div class=""form-group"">
                                    <label>Deadline: <span class=""text-danger"">*</span></label>
                                    <div class=""input-group"">
                                        <input id=""DateRange"" required=""required"" type=""text"" class=""form-control daterange-datemenu""");
            BeginWriteAttribute("value", " value=\"", 6773, "\"", 6833, 4);
            WriteAttributeValue("", 6781, "value=", 6781, 6, true);
#nullable restore
#line 98 "F:\DuratInstruments\Cornea\Cornea.Site\Areas\Admin\Views\Project\EditProject.cshtml"
WriteAttributeValue("", 6787, Model.Data.StartTime, 6787, 21, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 6808, "-", 6809, 2, true);
#nullable restore
#line 98 "F:\DuratInstruments\Cornea\Cornea.Site\Areas\Admin\Views\Project\EditProject.cshtml"
WriteAttributeValue(" ", 6810, Model.Data.FinishTime, 6811, 22, false);

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
        var ProjectId = $(""#ProjectId"").val();
        var ProjectName = $(""#ProjectName"").val();
        if (ProjectName.length == 0) {
            swal.fire(
                'Warning',
                'Please enter a project name',
                'warning'
            );");
            WriteLiteral(@"
            return;
        }
        var Status = document.getElementById(""Status"").value;
        var Priority = document.getElementById(""Priority"").value;
        var DateRange = $(""#DateRange"").val();
        var Message = $(""#Message"").val();

        var postData = {
            'ProjectId': ProjectId,
            'ProjectName': ProjectName,
            'Status': Status,
            'Priority': Priority,
            'DateRange': DateRange,
            'Message': Message
        };
        $.ajax({
            contentType: 'application/x-www-form-urlencoded',
            dataType: 'json',
            type: ""POST"",
            url: ""EditProject"",
            data: postData,
            success: function (data) {
                if (data.isSuccess == true) {
                    swal({
                        title: ""Updated!"",
                        text: data.message,
                        type: ""success""
                    }, function () { window.location.href = ""Projects""");
            WriteLiteral(@"; });
                }
                else {
                    swal({
                        title: ""Warning!"",
                        text: data.message,
                        type: ""warning""
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ResultDto<ResultFindProjectsService>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
