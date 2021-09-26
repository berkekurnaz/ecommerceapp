#pragma checksum "C:\Users\BKOyu\source\repos\ECommerce\ECommerce.WebUI\Views\Category\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a9216be4bb23eb7a312d7008c841ab2cc74839ca"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Category_Index), @"mvc.1.0.view", @"/Views/Category/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9216be4bb23eb7a312d7008c841ab2cc74839ca", @"/Views/Category/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    public class Views_Category_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ECommerce.Models.Concrete.Category>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\BKOyu\source\repos\ECommerce\ECommerce.WebUI\Views\Category\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br />\r\n<h3>Categories Page</h3>\r\n<hr />\r\n<a href=\"/Category/AddCategory\" class=\"btn btn-info\">Add New Category</a>\r\n<br />\r\n<br />\r\n\r\n");
#nullable restore
#line 14 "C:\Users\BKOyu\source\repos\ECommerce\ECommerce.WebUI\Views\Category\Index.cshtml"
 if (TempData["MsgSuccess"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-success\">");
#nullable restore
#line 16 "C:\Users\BKOyu\source\repos\ECommerce\ECommerce.WebUI\Views\Category\Index.cshtml"
                                Write(TempData["MsgSuccess"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n    <br />\r\n");
#nullable restore
#line 18 "C:\Users\BKOyu\source\repos\ECommerce\ECommerce.WebUI\Views\Category\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<table class=\"table table-bordered table-responsive\">\r\n    <thead>\r\n        <tr>\r\n            <th scope=\"col\">Category ID</th>\r\n            <th scope=\"col\">Operations</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 28 "C:\Users\BKOyu\source\repos\ECommerce\ECommerce.WebUI\Views\Category\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <th scope=\"row\">");
#nullable restore
#line 31 "C:\Users\BKOyu\source\repos\ECommerce\ECommerce.WebUI\Views\Category\Index.cshtml"
                           Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <td>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 783, "\"", 821, 2);
            WriteAttributeValue("", 790, "/Home/Index?categoryId=", 790, 23, true);
#nullable restore
#line 33 "C:\Users\BKOyu\source\repos\ECommerce\ECommerce.WebUI\Views\Category\Index.cshtml"
WriteAttributeValue("", 813, item.Id, 813, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-info btn-sm\">Show Products</a>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 892, "\"", 932, 2);
            WriteAttributeValue("", 899, "/Category/UpdateCategory/", 899, 25, true);
#nullable restore
#line 34 "C:\Users\BKOyu\source\repos\ECommerce\ECommerce.WebUI\Views\Category\Index.cshtml"
WriteAttributeValue("", 924, item.Id, 924, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success btn-sm\">Update Category</a>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 1008, "\"", 1048, 2);
            WriteAttributeValue("", 1015, "/Category/DeleteCategory/", 1015, 25, true);
#nullable restore
#line 35 "C:\Users\BKOyu\source\repos\ECommerce\ECommerce.WebUI\Views\Category\Index.cshtml"
WriteAttributeValue("", 1040, item.Id, 1040, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger btn-sm\">Delete Category</a>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 38 "C:\Users\BKOyu\source\repos\ECommerce\ECommerce.WebUI\Views\Category\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ECommerce.Models.Concrete.Category>> Html { get; private set; }
    }
}
#pragma warning restore 1591
