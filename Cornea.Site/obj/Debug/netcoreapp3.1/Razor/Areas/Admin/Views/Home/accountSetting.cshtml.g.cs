#pragma checksum "D:\Cornea\Cornea.Site\Areas\Admin\Views\Home\accountSetting.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3137cd322289acba31851f2f40a9251549145761"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Home_accountSetting), @"mvc.1.0.view", @"/Areas/Admin/Views/Home/accountSetting.cshtml")]
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
#line 1 "D:\Cornea\Cornea.Site\Areas\Admin\Views\Home\accountSetting.cshtml"
using Cornea.Application.Services.Users.Queries.FindUsers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Cornea\Cornea.Site\Areas\Admin\Views\Home\accountSetting.cshtml"
using Cornea.Common.Dto;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3137cd322289acba31851f2f40a9251549145761", @"/Areas/Admin/Views/Home/accountSetting.cshtml")]
    public class Areas_Admin_Views_Home_accountSetting : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ResultDto<ResultFindUsersService>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "D:\Cornea\Cornea.Site\Areas\Admin\Views\Home\accountSetting.cshtml"
  
    ViewData["Title"] = "AccountSetting";
    Layout = "~/Areas/Admin/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- Main content -->
<div class=""content-wrapper"">
    <!-- Page header -->
    <div class=""page-header"">
        <div class=""panel-heading"">
            <h5 class=""panel-title"">Editable inputs</h5>
            <div class=""heading-elements"">
                <form class=""heading-form"" action=""#"">
                    <div class=""form-group"">
                        <label class=""checkbox-inline checkbox-switchery checkbox-right switchery-xs"">
                            <input type=""checkbox"" class=""switchery"" checked=""checked"">
                            Enable editable:
                        </label>
                    </div>
                </form>
            </div>
        </div>
        <div class=""page-header-content"">
            <div class=""page-title"">
                <h4><i class=""icon-arrow-left52 position-left""></i> <span class=""text-semibold"">Datatables</span> - Select</h4>
                <a class=""heading-elements-toggle""><i class=""icon-more""></i></a>
            </di");
            WriteLiteral(@"v>
            <div class=""heading-elements"">
                <div class=""heading-btn-group"">
                    <a href=""#"" class=""btn btn-link btn-float text-size-small has-text legitRipple""><i class=""icon-bars-alt text-primary""></i><span>Statistics</span></a>
                    <a href=""#"" class=""btn btn-link btn-float text-size-small has-text legitRipple""><i class=""icon-calculator text-primary""></i> <span>Invoices</span></a>
                    <a href=""#"" class=""btn btn-link btn-float text-size-small has-text legitRipple""><i class=""icon-calendar5 text-primary""></i> <span>Schedule</span></a>
                </div>
            </div>
        </div>
        <div class=""breadcrumb-line breadcrumb-line-component"">
            <a class=""breadcrumb-elements-toggle""><i class=""icon-menu-open""></i></a>
            <ul class=""breadcrumb"">
                <li><a href=""index.html""><i class=""icon-home2 position-left""></i> Home</a></li>
                <li><a href=""datatable_extension_select.html"">Datata");
            WriteLiteral(@"bles</a></li>
                <li class=""active"">Select</li>
            </ul>
            <ul class=""breadcrumb-elements"">
                <li><a href=""#"" class=""legitRipple""><i class=""icon-comment-discussion position-left""></i> Support</a></li>
                <li class=""dropdown"">
                    <a href=""#"" class=""dropdown-toggle legitRipple"" data-toggle=""dropdown"">
                        <i class=""icon-gear position-left""></i>
                        Settings
                        <span class=""caret""></span>
                    </a>
                    <ul class=""dropdown-menu dropdown-menu-right"">
                        <li><a href=""#""><i class=""icon-user-lock""></i> Account security</a></li>
                        <li><a href=""#""><i class=""icon-statistics""></i> Analytics</a></li>
                        <li><a href=""#""><i class=""icon-accessibility""></i> Accessibility</a></li>
                        <li class=""divider""></li>
                        <li><a href=""#""><i class=""icon");
            WriteLiteral(@"-gear""></i> All settings</a></li>
                    </ul>
                </li>
            </ul>
        </div>
    </div>
    <!-- /page header -->
    <!-- Content area -->
    <div class=""content"">
        <!-- Basic setup -->
        <div class=""panel panel-white"">
            <div class=""panel-heading"">
                <h6 class=""panel-title"">Profile Information </h6>
                <div class=""heading-elements"">
                    <ul class=""icons-list"">
                        <li><a data-action=""collapse""></a></li>
                        <li><a data-action=""reload""></a></li>
                        <li><a data-action=""close""></a></li>
                    </ul>
                </div>
            </div>
            
            <form class=""form-basic"" method=""post"" enctype=""multipart/form-data"" asp-action=""AccountSetting"">
                <fieldset class=""step"" id=""step1"">
                    <h6 class=""form-wizard-title text-semibold alpha-blue text-center"">
            ");
            WriteLiteral(@"            <br />
                        Personal info
                        <small class=""display-block"">Tell us a bit about yourself</small>
                    </h6>

                    <div class=""row"">
                        <div class=""col-md-6"">
                            <div class=""form-group"">
                                <label>Full name:</label>
                                <input type=""text"" class=""form-control"" placeholder=""John"" id=""Fullname"" name=""Fullname""");
            BeginWriteAttribute("value", " value=\"", 4838, "\"", 4866, 1);
#nullable restore
#line 93 "D:\Cornea\Cornea.Site\Areas\Admin\Views\Home\accountSetting.cshtml"
WriteAttributeValue("", 4846, Model.Data.Fullname, 4846, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                            </div>
                        </div>
                        <div class=""col-md-6"">
                            <div class=""form-group"">
                                <label>Select position:</label>
                                <select name=""Position"" id=""Position"" data-placeholder=""Select position"" class=""select"">
                                    <option selected=""selected"">");
#nullable restore
#line 100 "D:\Cornea\Cornea.Site\Areas\Admin\Views\Home\accountSetting.cshtml"
                                                           Write(Model.Data.Position);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</option>
                                    <optgroup label=""Developer Relations"">
                                        <option value=""Sales Engineer"">Sales Engineer</option>
                                        <option value=""Ads Solutions Consultant"">Ads Solutions Consultant</option>
                                        <option value=""Technical Solutions Consultant"">Technical Solutions Consultant</option>
                                        <option value=""Business Intern"">Business Intern</option>
                                    </optgroup>

                                    <optgroup label=""Engineering &amp; Design"">
                                        <option value=""Interaction Designer"">Interaction Designer</option>
                                        <option value=""Technical Program Manager"">Technical Program Manager</option>
                                        <option value=""Software Engineer"">Software Engineer</option>
                                       ");
            WriteLiteral(@" <option value=""Information Security Engineer"">Information Security Engineer</option>
                                        <option value=""Security Engineer"">Security Engineer</option>
                                        <option value=""Usability Expert"">Usability Expert</option>
                                        <option value=""UI Designer"">UI Designer</option>
                                        <option value=""Illustrator"">Illustrator</option>
                                    </optgroup>
                                </select>
                            </div>
                        </div>
                    </div>
                    <div class=""row"">
                        <div class=""col-md-6"">
                            <div class=""form-group"">
                                <label>Phone:</label>
                                <input type=""text"" class=""form-control"" placeholder=""+99-99-9999-9999"" id=""Phone"" name=""Phone""");
            BeginWriteAttribute("value", " value=\"", 7314, "\"", 7339, 1);
#nullable restore
#line 126 "D:\Cornea\Cornea.Site\Areas\Admin\Views\Home\accountSetting.cshtml"
WriteAttributeValue("", 7322, Model.Data.Phone, 7322, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                            </div>
                        </div>

                        <div class=""col-md-6"">
                            <div class=""form-group"">
                                <label>Email address:</label>
                                <input type=""email"" class=""form-control"" placeholder=""your@email.com"" id=""Email"" name=""Email""");
            BeginWriteAttribute("value", " value=\"", 7703, "\"", 7728, 1);
#nullable restore
#line 133 "D:\Cornea\Cornea.Site\Areas\Admin\Views\Home\accountSetting.cshtml"
WriteAttributeValue("", 7711, Model.Data.Email, 7711, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                            </div>
                        </div>
                    </div>
                    <div class=""row"">
                        <div class=""col-md-6"">
                            <div class=""col-md-3"">
                                <div class=""form-group"">
                                    <img");
            BeginWriteAttribute("src", " src=\"", 8065, "\"", 8091, 1);
#nullable restore
#line 141 "D:\Cornea\Cornea.Site\Areas\Admin\Views\Home\accountSetting.cshtml"
WriteAttributeValue("", 8071, Model.Data.Imagedir, 8071, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" id=""Preview"" name=""Preview"" class=""img-preview"">
                                </div>
                            </div>
                            <div class=""col-md-9"">
                                <div class=""form-group"">
                                    <div id=""alpaca-file-styled""></div>
                                    <a href=""#alpaca-file-styled-source"" id=""Imagedir"" required=""required"" data-toggle=""collapse""></a>
                                </div>
                            </div>
                        </div>
                        <div class=""col-md-6"">
                            <div class=""form-group"">
                                <label>Date of birth:</label>
                                <div class=""input-group"">
                                    <input type=""text"" name=""Birthday"" id=""Birthday""");
            BeginWriteAttribute("value", " value=\"", 8954, "\"", 8982, 1);
#nullable restore
#line 155 "D:\Cornea\Cornea.Site\Areas\Admin\Views\Home\accountSetting.cshtml"
WriteAttributeValue("", 8962, Model.Data.Birthday, 8962, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""form-control daterange-single"">
                                    <span class=""input-group-addon""><i class=""icon-calendar22""></i></span>
                                </div>
                            </div>
                        </div>
                    </div>

                    <br />
                    <h6 class=""form-wizard-title text-semibold alpha-blue text-center"">
                        <br />
                        Your education
                        <small class=""display-block"">Let us know about your degree</small>
                    </h6>
                    <div class=""row"">
                        <div class=""col-md-6"">
                            <div class=""form-group"">
                                <label>University:</label>
                                <input type=""text"" placeholder=""University name"" class=""form-control"" id=""University"" name=""University""");
            BeginWriteAttribute("value", " value=\"", 9914, "\"", 9944, 1);
#nullable restore
#line 172 "D:\Cornea\Cornea.Site\Areas\Admin\Views\Home\accountSetting.cshtml"
WriteAttributeValue("", 9922, Model.Data.University, 9922, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                            </div>
                        </div>
                        <div class=""col-md-6"">
                            <div class=""row"">
                                <div class=""col-md-6"">
                                    <label>From:</label>
                                    <div class=""form-group"">
                                        <input type=""text"" name=""StartEducationTime"" placeholder=""October, 2020."" class=""form-control""");
            BeginWriteAttribute("value", " value=\"", 10421, "\"", 10459, 1);
#nullable restore
#line 180 "D:\Cornea\Cornea.Site\Areas\Admin\Views\Home\accountSetting.cshtml"
WriteAttributeValue("", 10429, Model.Data.StartEducationTime, 10429, 30, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                                    </div>
                                </div>

                                <div class=""col-md-6"">
                                    <label>To:</label>
                                    <div class=""form-group"">
                                        <input type=""text"" name=""FinishEducationTime"" placeholder=""October, 2020."" class=""form-control""");
            BeginWriteAttribute("value", " value=\"", 10858, "\"", 10897, 1);
#nullable restore
#line 187 "D:\Cornea\Cornea.Site\Areas\Admin\Views\Home\accountSetting.cshtml"
WriteAttributeValue("", 10866, Model.Data.FinishEducationTime, 10866, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class=""row"">
                        <div class=""col-md-6"">
                            <div class=""form-group"">
                                <label>Degree level:</label>
                                <input type=""text"" placeholder=""Bachelor, Master etc."" class=""form-control"" id=""DegreeLevel"" name=""DegreeLevel""");
            BeginWriteAttribute("value", " value=\"", 11427, "\"", 11458, 1);
#nullable restore
#line 197 "D:\Cornea\Cornea.Site\Areas\Admin\Views\Home\accountSetting.cshtml"
WriteAttributeValue("", 11435, Model.Data.DegreeLevel, 11435, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                            </div>

                            <div class=""form-group"">
                                <label>Specialization:</label>
                                <input type=""text"" placeholder=""Design, Development etc."" class=""form-control"" id=""Specialization"" name=""Specialization""");
            BeginWriteAttribute("value", " value=\"", 11770, "\"", 11804, 1);
#nullable restore
#line 202 "D:\Cornea\Cornea.Site\Areas\Admin\Views\Home\accountSetting.cshtml"
WriteAttributeValue("", 11778, Model.Data.Specialization, 11778, 26, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                            </div>
                        </div>

                        
                    </div>
                    <br />
                    <h6 class=""form-wizard-title text-semibold alpha-blue text-center"">
                        <br />
                        Work experience
                        <small class=""display-block"">Previous work places</small>
                    </h6>
                    <div class=""row"">
                        <div class=""col-md-6"">
                            <div class=""form-group"">
                                <label>Company:</label>
                                <input type=""text"" placeholder=""Company name"" class=""form-control"" id=""Company"" name=""Company""");
            BeginWriteAttribute("value", " value=\"", 12556, "\"", 12583, 1);
#nullable restore
#line 218 "D:\Cornea\Cornea.Site\Areas\Admin\Views\Home\accountSetting.cshtml"
WriteAttributeValue("", 12564, Model.Data.Company, 12564, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                            </div>

                            <div class=""form-group"">
                                <label>Position:</label>
                                <input type=""text"" placeholder=""Company name"" class=""form-control"" id=""Position"" name=""Position""");
            BeginWriteAttribute("value", " value=\"", 12865, "\"", 12893, 1);
#nullable restore
#line 223 "D:\Cornea\Cornea.Site\Areas\Admin\Views\Home\accountSetting.cshtml"
WriteAttributeValue("", 12873, Model.Data.Position, 12873, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                            </div>

                            <div class=""row"">
                                <div class=""col-md-6"">
                                    <label>From:</label>
                                    <div class=""form-group"">
                                        <input type=""text"" name=""StartLastjobTime"" placeholder=""October, 2020."" class=""form-control""");
            BeginWriteAttribute("value", " value=\"", 13290, "\"", 13326, 1);
#nullable restore
#line 230 "D:\Cornea\Cornea.Site\Areas\Admin\Views\Home\accountSetting.cshtml"
WriteAttributeValue("", 13298, Model.Data.StartLastjobTime, 13298, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                                    </div>
                                </div>

                                <div class=""col-md-6"">
                                    <label>To:</label>
                                    <div class=""form-group"">
                                        <input type=""text"" name=""FinishLastjobTime"" placeholder=""October, 2020."" class=""form-control""");
            BeginWriteAttribute("value", " value=\"", 13723, "\"", 13760, 1);
#nullable restore
#line 237 "D:\Cornea\Cornea.Site\Areas\Admin\Views\Home\accountSetting.cshtml"
WriteAttributeValue("", 13731, Model.Data.FinishLastjobTime, 13731, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class=""col-md-6"">
                            <div class=""form-group"">
                                <label>Brief description:</label>
                                <textarea name=""experience-description"" rows=""1"" cols=""4"" placeholder=""Tasks and responsibilities"" class=""form-control""></textarea>
                            </div>
                        </div>
                    </div>
                    <br />
                    <h6 class=""form-wizard-title text-semibold alpha-blue text-center"">
                        <br />
                        Additional info
                        <small class=""display-block"">We are almost done now</small>
                    </h6>
                    <div class=""row"">
                        <div class=""col-md-6"">
                            <div class=""form-group");
            WriteLiteral(@""">
                                <label class=""display-block"">Applicant resume:</label>
                                <input type=""file"" name=""resume"" class=""file-styled"">
                                <span class=""help-block"">Accepted formats: pdf, doc. Max file size 2Mb</span>
                            </div>
                        </div>

                        <div class=""col-md-6"">
                            <div class=""form-group"">
                                <label>Additional information:</label>
                                <textarea name=""additional-info"" rows=""5"" cols=""5"" placeholder=""If you want to add any info, do it here."" class=""form-control""></textarea>
                            </div>
                        </div>
                    </div>
                    <div class=""form-wizard-actions"">
                        <button class=""btn bg-blue"" id=""cancel-next"" type=""submit"">Update</button>
                    </div>
                </fieldset>
          ");
            WriteLiteral(@"  </form>
         
        </div>
        <!-- /basic setup -->
        <!-- Account settings -->
        <div class=""panel panel-flat"">
            <div class=""panel-heading"">
                <h6 class=""panel-title"">Account settings</h6>
                <div class=""heading-elements"">
                    <ul class=""icons-list"">
                        <li><a data-action=""reload""></a></li>
                    </ul>
                </div>
            </div>

            <div class=""panel-body"">
                <div class=""form-group"">
                    <div class=""row"">
                        <div class=""col-md-6"">
                            <label>Username</label>
                            <input type=""text"" readonly=""readonly"" class=""form-control"" id=""UserName"" name=""UserName""");
            BeginWriteAttribute("value", " value=\"", 16623, "\"", 16651, 1);
#nullable restore
#line 295 "D:\Cornea\Cornea.Site\Areas\Admin\Views\Home\accountSetting.cshtml"
WriteAttributeValue("", 16631, Model.Data.UserName, 16631, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                        </div>

                        <div class=""col-md-6"">
                            <label>Current password</label>
                            <input type=""password"" readonly=""readonly"" class=""form-control"" id=""Password"" name=""Password""");
            BeginWriteAttribute("value", " value=\"", 16919, "\"", 16947, 1);
#nullable restore
#line 300 "D:\Cornea\Cornea.Site\Areas\Admin\Views\Home\accountSetting.cshtml"
WriteAttributeValue("", 16927, Model.Data.Password, 16927, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                        </div>
                    </div>
                </div>

                <div class=""form-group"">
                    <div class=""row"">
                        <div class=""col-md-6"">
                            <label>New password</label>
                            <input type=""password"" placeholder=""Enter new password"" class=""form-control"" id=""NewPassword"">
                        </div>

                        <div class=""col-md-6"">
                            <label>Repeat password</label>
                            <input type=""password"" placeholder=""Repeat new password"" class=""form-control"" id=""ConfirmPassword"">
                        </div>
                    </div>
                </div>

                <div class=""text-right"">
                    <button onclick=""Save()"" class=""btn btn-primary"">Save <i class=""icon-arrow-right14 position-right""></i></button>
                </div>
            </div>
        </div>
        <!-- /account settings -");
            WriteLiteral(@"->
    </div>
    <!-- /content area -->

</div>
<!-- /main content -->
<script>
    function Save() {
        var NewPassword = $(""#NewPassword"").val();
        var ConfirmPassword = $(""#ConfirmPassword"").val();
        if (NewPassword != ConfirmPassword)
        {
            swal(
                ""Warning!"",
                ""New password and confirm password must be same."",
                ""warning""
            );
        }
        var postData = {
            'NewPassword': NewPassword,
            'ConfirmPassword': ConfirmPassword,

        };
        $.ajax({
            contentType: 'application/x-www-form-urlencoded',
            dataType: 'json',
            type: ""POST"",
            url: ""ChangePassword"",
            data: postData,
            success: function (data) {
                if (data.isSuccess == true) {
                    swal({
                        title: ""Updated!"",
                        text: data.message,
                        type: ""succes");
            WriteLiteral(@"s""
                    }, function () {
                            location.reload(true);
                            document.getElementById(""Password"").value = data.data.NewPassword;
                    });
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
<script>
    $(""#alpaca-file-styled"").alpaca({
        ""data"": """",

        ""options"": {
            ""type"": ""file"",
            ""label"": ""Profile Photo:"",
            ""helper"": ""Select yo");
            WriteLiteral(@"ur profile picture."",
            ""id"": ""file-styled"",
            ""name"": ""files""
        },
        ""schema"": {
            ""type"": ""string"",
            ""format"": ""uri""
        },
        ""postRender"": function (control) {
            $(""#file-styled"").uniform({
                fileButtonClass: 'action btn bg-blue'
            });
        }
    });
    $('#file-styled').on('change', function () {
        if (this.files && this.files[0]) {
            var reader = new FileReader();

            reader.onload = function (e) {
                $('#Preview')
                    .attr('src', e.target.result);
            };

            reader.readAsDataURL(this.files[0]);
        }
    });
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ResultDto<ResultFindUsersService>> Html { get; private set; }
    }
}
#pragma warning restore 1591
