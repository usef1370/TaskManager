#pragma checksum "F:\DuratInstruments\Cornea\Cornea.Site\Areas\Admin\Views\Customer\Customers.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "55c3322bad69c79c59e2456de99ac2b1ed25e8d2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Customer_Customers), @"mvc.1.0.view", @"/Areas/Admin/Views/Customer/Customers.cshtml")]
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
#line 1 "F:\DuratInstruments\Cornea\Cornea.Site\Areas\Admin\Views\Customer\Customers.cshtml"
using Cornea.Application.Services.Customer.Queries.GetCustomers;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"55c3322bad69c79c59e2456de99ac2b1ed25e8d2", @"/Areas/Admin/Views/Customer/Customers.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_Customer_Customers : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ResultGetCustomersDto>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "F:\DuratInstruments\Cornea\Cornea.Site\Areas\Admin\Views\Customer\Customers.cshtml"
  
    ViewData["Title"] = "Customers";
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
                    <h4><i class=""icon-arrow-left52 position-left""></i> <span class=""text-semibold"">Customers</span> - Customers List</h4>
                    <a class=""heading-elements-toggle""><i class=""icon-more""></i></a>
                </div>
                <div class=""heading-elements"">
                    <div class=""heading-btn-group"">
                        <a href=""#"" class=""btn btn-link btn-float text-size-small has-text legitRipple""><i class=""icon-bars-alt text-primary""></i><span>Statistics</span></a>
                        <a href=""#"" class=""btn btn-link btn-float text-size-small has-text legitRipple""><i class=""icon-calculator text-primary""></i> <span>Invoices</span></a>
                        <a href=""#"" class=""btn btn-link btn-float text-size-small has-text legitRipple""><");
            WriteLiteral(@"i class=""icon-calendar5 text-primary""></i> <span>Schedule</span></a>
                    </div>
                </div>
            </div>

            <div class=""breadcrumb-line breadcrumb-line-component"">
                <a class=""breadcrumb-elements-toggle""><i class=""icon-menu-open""></i></a>
                <ul class=""breadcrumb"">
                    <li><a href=""index.html""><i class=""icon-home2 position-left""></i> Home</a></li>
                    <li><a href=""datatable_extension_select.html"">Customers</a></li>
                    <li class=""active"">Customers List</li>
                </ul>
                <ul class=""breadcrumb-elements"">
                    <li><a href=""#"" class=""legitRipple""><i class=""icon-comment-discussion position-left""></i> Support</a></li>
                    <li class=""dropdown"">
                        <a href=""#"" class=""dropdown-toggle legitRipple"" data-toggle=""dropdown"">
                            <i class=""icon-gear position-left""></i>
                       ");
            WriteLiteral(@"     Settings
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
            <!-- Single row selection -->
            <div class=""panel panel-flat"">
                <div class=""panel-heading"">
                    <h5 class=""panel-title"">Customers Lis");
            WriteLiteral(@"t</h5>
                    <div class=""heading-elements"">
                        <ul class=""icons-list"">
                            <li><a data-action=""reload""></a></li>
                        </ul>
                    </div>
                </div>

                <table class=""table datatable-selection-single"">
                    <thead>
                        <tr>
                            <th>Customer name</th>
                            <th>City</th>
                            <th class=""col-md-2"">Address</th>
                            <th>Lab name</th>
                            <th>Phone number</th>
                            <th>Product name</th>
                            <th>Number</th>
                            <th>Sale date</th>
                            <th hidden=""hidden"">Id</th>
                            <th class=""text-center"">Actions</th>
                        </tr>
                    </thead>
                    <tbody>

");
#nullable restore
#line 85 "F:\DuratInstruments\Cornea\Cornea.Site\Areas\Admin\Views\Customer\Customers.cshtml"
                         foreach (var data in Model.customerslist)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td>");
#nullable restore
#line 88 "F:\DuratInstruments\Cornea\Cornea.Site\Areas\Admin\Views\Customer\Customers.cshtml"
                               Write(data.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 89 "F:\DuratInstruments\Cornea\Cornea.Site\Areas\Admin\Views\Customer\Customers.cshtml"
                               Write(data.City);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 90 "F:\DuratInstruments\Cornea\Cornea.Site\Areas\Admin\Views\Customer\Customers.cshtml"
                               Write(data.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 91 "F:\DuratInstruments\Cornea\Cornea.Site\Areas\Admin\Views\Customer\Customers.cshtml"
                               Write(data.LabName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 92 "F:\DuratInstruments\Cornea\Cornea.Site\Areas\Admin\Views\Customer\Customers.cshtml"
                               Write(data.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 93 "F:\DuratInstruments\Cornea\Cornea.Site\Areas\Admin\Views\Customer\Customers.cshtml"
                               Write(data.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 94 "F:\DuratInstruments\Cornea\Cornea.Site\Areas\Admin\Views\Customer\Customers.cshtml"
                               Write(data.Number);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 95 "F:\DuratInstruments\Cornea\Cornea.Site\Areas\Admin\Views\Customer\Customers.cshtml"
                               Write(data.SaleDate.ToString("yyyy-MM-dd"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td hidden=\"hidden\">");
#nullable restore
#line 96 "F:\DuratInstruments\Cornea\Cornea.Site\Areas\Admin\Views\Customer\Customers.cshtml"
                                               Write(data.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td class=\"text-center \">                                      \r\n                                    <ul class=\"icons-list\">\r\n                                        <li class=\"text-primary-600\"><a");
            BeginWriteAttribute("href", " href=\"", 5171, "\"", 5209, 2);
            WriteAttributeValue("", 5178, "EditCustomer?searchKey=", 5178, 23, true);
#nullable restore
#line 99 "F:\DuratInstruments\Cornea\Cornea.Site\Areas\Admin\Views\Customer\Customers.cshtml"
WriteAttributeValue("", 5201, data.Id, 5201, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"icon-pencil7\"></i></a></li>\r\n                                        <li class=\"text-danger-600\"><a data-id=");
#nullable restore
#line 100 "F:\DuratInstruments\Cornea\Cornea.Site\Areas\Admin\Views\Customer\Customers.cshtml"
                                                                          Write(data.Id);

#line default
#line hidden
#nullable disable
            BeginWriteAttribute("onclick", " onclick=\"", 5337, "\"", 5379, 3);
            WriteAttributeValue("", 5347, "deleteCustomer(String(", 5347, 22, true);
#nullable restore
#line 100 "F:\DuratInstruments\Cornea\Cornea.Site\Areas\Admin\Views\Customer\Customers.cshtml"
WriteAttributeValue("", 5369, data.Id, 5369, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5377, "))", 5377, 2, true);
            EndWriteAttribute();
            WriteLiteral(" href=\"#\"><i class=\"icon-trash\"></i></a></li>\r\n                                    </ul>\r\n                                </td>\r\n                            </tr>\r\n");
#nullable restore
#line 104 "F:\DuratInstruments\Cornea\Cornea.Site\Areas\Admin\Views\Customer\Customers.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </tbody>
                </table>
                <!-- /single row selection -->
            </div>
            <!-- /page container -->
        </div>
    </div>
<script>
    function deleteCustomer(searchKey) {
        // Advanced initialization
        swal({
            title: ""Are you sure?"",
            text: ""You will not be able to recover this imaginary file!"",
            type: ""warning"",
            showCancelButton: true,
            confirmButtonColor: ""#DD6B55"",
            confirmButtonText: ""Yes, delete it!"",
            closeOnConfirm: false,
            html: false
        }, function () {
            var postData = {
                'searchKey': searchKey,
            };
            $.ajax({
                contentType: 'application/x-www-form-urlencoded',
                dataType: 'json',
                type: ""POST"",
                url: ""deleteCustomer"",
                data: postData,
                success: function (data) {
          ");
            WriteLiteral(@"          if (data.isSuccess == true) {
                        swal({
                            title: ""Deleted!"",
                            text: ""Your imaginary file has been deleted."",
                            type: ""success""
                        }, function () { window.location.reload(); });

                    }
                }
            });

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ResultGetCustomersDto> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
