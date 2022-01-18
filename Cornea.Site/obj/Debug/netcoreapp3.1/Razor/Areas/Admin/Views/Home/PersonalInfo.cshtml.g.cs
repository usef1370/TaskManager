#pragma checksum "D:\Cornea\Cornea.Site\Areas\Admin\Views\Home\PersonalInfo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bb270af72b3082059193c3f3effd3c2d17bcbab9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Home_PersonalInfo), @"mvc.1.0.view", @"/Areas/Admin/Views/Home/PersonalInfo.cshtml")]
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
#line 3 "D:\Cornea\Cornea.Site\Areas\Admin\Views\Home\PersonalInfo.cshtml"
using Cornea.Application.Services.Users.Queries.FindUsers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Cornea\Cornea.Site\Areas\Admin\Views\Home\PersonalInfo.cshtml"
using Cornea.Common.Dto;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bb270af72b3082059193c3f3effd3c2d17bcbab9", @"/Areas/Admin/Views/Home/PersonalInfo.cshtml")]
    public class Areas_Admin_Views_Home_PersonalInfo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ResultDto<ResultFindUsersService>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 6 "D:\Cornea\Cornea.Site\Areas\Admin\Views\Home\PersonalInfo.cshtml"
  
    ViewData["Title"] = "PersonalInfo";
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
                <h4><i class=""icon-arrow-left52 position-left""></i> <span class=""text-semibold"">Datatables</span> - Select</h4>
                <a class=""heading-elements-toggle""><i class=""icon-more""></i></a>
            </div>
            <div class=""heading-elements"">
                <div class=""heading-btn-group"">
                    <a href=""#"" class=""btn btn-link btn-float text-size-small has-text legitRipple""><i class=""icon-bars-alt text-primary""></i><span>Statistics</span></a>
                    <a href=""#"" class=""btn btn-link btn-float text-size-small has-text legitRipple""><i class=""icon-calculator text-primary""></i> <span>Invoices</span></a>
                    <a href=""#"" class=""btn btn-link btn-float text-size-small has-text legitRipple""><i class=""icon-calendar5 text-primary""></i> <span>Schedule</spa");
            WriteLiteral(@"n></a>
                </div>
            </div>
        </div>
        <div class=""breadcrumb-line breadcrumb-line-component"">
            <a class=""breadcrumb-elements-toggle""><i class=""icon-menu-open""></i></a>
            <ul class=""breadcrumb"">
                <li><a href=""index.html""><i class=""icon-home2 position-left""></i> Home</a></li>
                <li><a href=""datatable_extension_select.html"">Datatables</a></li>
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
                    <ul class=""dropdown-m");
            WriteLiteral(@"enu dropdown-menu-right"">
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
        <div class=""panel panel-white"">
            <div class=""panel-heading"">
                <h6 class=""panel-title"">Basic example</h6>
                <div class=""heading-elements"">
                    <ul class=""icons-list"">
                        <li><a data-action=""reload""></a></li>
                    </ul>
                </div>
            </div>
            

     ");
            WriteLiteral(@"       <form action=""PersonalInfo"" method=""post"" id=""ProfileForm"" enctype=""multipart/form-data"" class=""steps-basic"">
                <h6>Personal data</h6>
                <fieldset>
                    <div class=""row"">
                        <div class=""col-md-6"">
                            <div class=""form-group"">
                                <label>Full name:</label>
                                <input type=""text"" class=""form-control"" placeholder=""John"" id=""Fullname"" name=""Fullname""");
            BeginWriteAttribute("value", " value=\"", 3915, "\"", 3943, 1);
#nullable restore
#line 75 "D:\Cornea\Cornea.Site\Areas\Admin\Views\Home\PersonalInfo.cshtml"
WriteAttributeValue("", 3923, Model.Data.Fullname, 3923, 20, false);

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
                                <select name=""position"" data-placeholder=""Select position"" class=""select"">
                                    <option selected=""selected"">");
#nullable restore
#line 82 "D:\Cornea\Cornea.Site\Areas\Admin\Views\Home\PersonalInfo.cshtml"
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
                                    </optgroup>

                                    <optgroup label=""Marketing &amp; Communications"">
                                        <option value=""Media Outreach Manager"">Media Outreach Manager</option>
                                        <option value=""Research Manager"">Research Manager</option>
                                        <option value=""Marketing Intern"">Marketing Intern</option>
                                        <option value="">Business Intern"">Business Intern</option>
                                    </optgroup>

                                    <optgroup label=""Sales Operations"">
                                        <option value=""Sales Operations Analyst"">Sales Operations Analyst</option>
                                        <option value=""Technology Product Manager"">Technology Product Manager</option>
                            ");
            WriteLiteral(@"            <option value=""Product Expert"">Product Expert</option>
                                        <option value=""Sales Insights Analyst"">Sales Insights Analyst</option>
                                        <option value=""Customer Operations Analyst"">Customer Operations Analyst</option>
                                    </optgroup>
                                </select>
                            </div>
                        </div>
                    </div>

                    <div class=""row"">
                        <div class=""col-md-6"">
                            <div class=""form-group"">
                                <label>Phone #:</label>
                                <input type=""text"" name=""Phone"" id=""Phone"" class=""form-control"" placeholder=""+99-99-9999-9999"" data-mask=""+99-99-9999-9999""");
            BeginWriteAttribute("value", " value=\"", 7267, "\"", 7292, 1);
#nullable restore
#line 120 "D:\Cornea\Cornea.Site\Areas\Admin\Views\Home\PersonalInfo.cshtml"
WriteAttributeValue("", 7275, Model.Data.Phone, 7275, 17, false);

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
            BeginWriteAttribute("value", " value=\"", 7656, "\"", 7681, 1);
#nullable restore
#line 127 "D:\Cornea\Cornea.Site\Areas\Admin\Views\Home\PersonalInfo.cshtml"
WriteAttributeValue("", 7664, Model.Data.Email, 7664, 17, false);

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
            BeginWriteAttribute("src", " src=\"", 8020, "\"", 8046, 1);
#nullable restore
#line 136 "D:\Cornea\Cornea.Site\Areas\Admin\Views\Home\PersonalInfo.cshtml"
WriteAttributeValue("", 8026, Model.Data.Imagedir, 8026, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" id=""Preview"" name=""Preview"" class=""img-preview"">
                                </div>
                            </div>
                            <div class=""col-md-9"">
                                <div class=""form-group"">
                                    <label class=""display-block"">Profile photo:</label>
                                    <input name=""Imagedir"" id=""Imagedir"" type=""file"" class=""file-styled"">
                                    <span class=""help-block"">Accepted formats: pdf, doc. Max file size 2Mb</span>
                                </div>
                            </div>
                        </div>

                        <div class=""col-md-6"">
                            <div class=""form-group"">
                                <label>Date of birth:</label>
                                <div class=""input-group"">
                                    <input type=""text"" name=""Birthday"" id=""Birthday""");
            BeginWriteAttribute("value", " value=\"", 9013, "\"", 9041, 1);
#nullable restore
#line 152 "D:\Cornea\Cornea.Site\Areas\Admin\Views\Home\PersonalInfo.cshtml"
WriteAttributeValue("", 9021, Model.Data.Birthday, 9021, 20, false);

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
                </fieldset>
                <script>
                    $('#Imagedir').on('change', function () {
                        if (this.files && this.files[0]) {
                            var reader = new FileReader();

                            reader.onload = function (e) {
                                $('#Preview')
                                    .attr('src', e.target.result);
                            };

                            reader.readAsDataURL(this.files[0]);
                        }
                    });
                </script>
                <h6>Your education</h6>
                <fieldset>
                    <div class=""row"">
                        <div class=""c");
            WriteLiteral(@"ol-md-6"">
                            <div class=""form-group"">
                                <label>University:</label>
                                <input type=""text"" name=""university"" id=""university"" placeholder=""University name"" class=""form-control""");
            BeginWriteAttribute("value", " value=\"", 10326, "\"", 10356, 1);
#nullable restore
#line 179 "D:\Cornea\Cornea.Site\Areas\Admin\Views\Home\PersonalInfo.cshtml"
WriteAttributeValue("", 10334, Model.Data.University, 10334, 22, false);

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
                                        <input type=""text"" name=""StartEducationTime"" id=""StartEducationTime"" placeholder=""October, 2020."" class=""form-control""");
            BeginWriteAttribute("value", " value=\"", 10857, "\"", 10895, 1);
#nullable restore
#line 187 "D:\Cornea\Cornea.Site\Areas\Admin\Views\Home\PersonalInfo.cshtml"
WriteAttributeValue("", 10865, Model.Data.StartEducationTime, 10865, 30, false);

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
                                        <input type=""text"" name=""FinishEducationTime"" id=""FinishEducationTime"" placeholder=""October, 2020."" class=""form-control""");
            BeginWriteAttribute("value", " value=\"", 11319, "\"", 11358, 1);
#nullable restore
#line 194 "D:\Cornea\Cornea.Site\Areas\Admin\Views\Home\PersonalInfo.cshtml"
WriteAttributeValue("", 11327, Model.Data.FinishEducationTime, 11327, 31, false);

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
                                <input type=""text"" name=""DegreeLevel"" id=""DegreeLevel"" placeholder=""Bachelor, Master etc."" class=""form-control""");
            BeginWriteAttribute("value", " value=\"", 11892, "\"", 11923, 1);
#nullable restore
#line 206 "D:\Cornea\Cornea.Site\Areas\Admin\Views\Home\PersonalInfo.cshtml"
WriteAttributeValue("", 11900, Model.Data.DegreeLevel, 11900, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                            </div>

                            <div class=""form-group"">
                                <label>Specialization:</label>
                                <input type=""text"" name=""specialization"" id=""specialization"" placeholder=""Design, Development etc."" class=""form-control""");
            BeginWriteAttribute("value", " value=\"", 12235, "\"", 12269, 1);
#nullable restore
#line 211 "D:\Cornea\Cornea.Site\Areas\Admin\Views\Home\PersonalInfo.cshtml"
WriteAttributeValue("", 12243, Model.Data.Specialization, 12243, 26, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                            </div>
                        </div>
                    </div>
                </fieldset>

                <h6>Your experience</h6>
                <fieldset>
                    <div class=""row"">
                        <div class=""col-md-6"">
                            <div class=""form-group"">
                                <label>Company:</label>
                                <input type=""text"" name=""Company"" id=""Company"" placeholder=""Company name"" class=""form-control""");
            BeginWriteAttribute("value", " value=\"", 12794, "\"", 12821, 1);
#nullable restore
#line 223 "D:\Cornea\Cornea.Site\Areas\Admin\Views\Home\PersonalInfo.cshtml"
WriteAttributeValue("", 12802, Model.Data.Company, 12802, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                            </div>\r\n\r\n                            <div class=\"form-group\">\r\n                                <label>Position:</label>\r\n                                <input type=\"text\" name=\"experience-position\" id=\"experience-position\"");
            BeginWriteAttribute("placeholder", " placeholder=\"", 13077, "\"", 13091, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"form-control\"");
            BeginWriteAttribute("value", " value=\"", 13113, "\"", 13141, 1);
#nullable restore
#line 228 "D:\Cornea\Cornea.Site\Areas\Admin\Views\Home\PersonalInfo.cshtml"
WriteAttributeValue("", 13121, Model.Data.Position, 13121, 20, false);

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
                                        <input type=""text"" name=""StartLastjobTime"" id=""StartLastjobTime"" placeholder=""October, 2020."" class=""form-control""");
            BeginWriteAttribute("value", " value=\"", 13560, "\"", 13596, 1);
#nullable restore
#line 235 "D:\Cornea\Cornea.Site\Areas\Admin\Views\Home\PersonalInfo.cshtml"
WriteAttributeValue("", 13568, Model.Data.StartLastjobTime, 13568, 28, false);

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
                                        <input type=""text"" name=""FinishLastjobTime"" id=""FinishLastjobTime"" placeholder=""October, 2020."" class=""form-control""");
            BeginWriteAttribute("value", " value=\"", 14016, "\"", 14053, 1);
#nullable restore
#line 242 "D:\Cornea\Cornea.Site\Areas\Admin\Views\Home\PersonalInfo.cshtml"
WriteAttributeValue("", 14024, Model.Data.FinishLastjobTime, 14024, 29, false);

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
                                <textarea name=""LastjobDescription"" id=""LastjobDescription"" rows=""5"" cols=""4"" placeholder=""Tasks and responsibilities"" class=""form-control""");
            BeginWriteAttribute("value", " value=\"", 14551, "\"", 14589, 1);
#nullable restore
#line 251 "D:\Cornea\Cornea.Site\Areas\Admin\Views\Home\PersonalInfo.cshtml"
WriteAttributeValue("", 14559, Model.Data.LastjobDescription, 14559, 30, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"></textarea>
                            </div>
                        </div>
                    </div>
                </fieldset>

                <h6>Additional info</h6>
                <fieldset>
                    <div class=""row"">
                        <div class=""col-md-6"">
                            <div class=""form-group"">
                                <label class=""display-block"">Applicant resume:</label>
                                <input type=""file"" name=""Resumedir"" id=""Resumedir"" class=""file-styled"">
                                <span class=""help-block"">Accepted formats: pdf, doc. Max file size 2Mb</span>
                            </div>
                        </div>

                        <div class=""col-md-6"">
                            <div class=""form-group"">
                                <label>Additional information:</label>
                                <textarea name=""additional-info"" rows=""4"" cols=""5"" placeholder=""If you want to add any info,");
            WriteLiteral(" do it here.\" class=\"form-control\"");
            BeginWriteAttribute("value", " value=\"", 15648, "\"", 15682, 1);
#nullable restore
#line 271 "D:\Cornea\Cornea.Site\Areas\Admin\Views\Home\PersonalInfo.cshtml"
WriteAttributeValue("", 15656, Model.Data.AdditionalInfo, 15656, 26, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"></textarea>
                            </div>
                        </div>
                    </div>
                </fieldset>

            </form>
        </div>

    </div>
    <!-- /content area -->
</div>
<!-- /main content -->

<script>
    $("".steps-basic"").steps({
        headerTag: ""h6"",
        bodyTag: ""fieldset"",
        transitionEffect: ""fade"",
        titleTemplate: '<span class=""number"">#index#</span> #title#',
        labels: {
            finish: 'Submit'
        },
        onFinished: function (event, currentIndex) {
            $(""#ProfileForm"").submit();
        }
    });

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ResultDto<ResultFindUsersService>> Html { get; private set; }
    }
}
#pragma warning restore 1591
