#pragma checksum "C:\Users\lille\Desktop\skole repo\Mandatory2\MbmStore\Views\Shared\_ProductSummaryBook.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d9750b8dfab4e35ccba8416712fbb3d37e6465a3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__ProductSummaryBook), @"mvc.1.0.view", @"/Views/Shared/_ProductSummaryBook.cshtml")]
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
#line 2 "C:\Users\lille\Desktop\skole repo\Mandatory2\MbmStore\Views\_ViewImports.cshtml"
using MbmStore.Models.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\lille\Desktop\skole repo\Mandatory2\MbmStore\Views\Shared\_ProductSummaryBook.cshtml"
using MbmStore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d9750b8dfab4e35ccba8416712fbb3d37e6465a3", @"/Views/Shared/_ProductSummaryBook.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e14ff1bc687addf7bd4613bc821f60082fbc3ed4", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__ProductSummaryBook : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MbmStore.Models.Book>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-md-2\">\r\n        <img");
            BeginWriteAttribute("src", " src=\"", 119, "\"", 148, 2);
            WriteAttributeValue("", 125, "/Images/", 125, 8, true);
#nullable restore
#line 8 "C:\Users\lille\Desktop\skole repo\Mandatory2\MbmStore\Views\Shared\_ProductSummaryBook.cshtml"
WriteAttributeValue("", 133, Model.ImageUrl, 133, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 149, "\"", 167, 1);
#nullable restore
#line 8 "C:\Users\lille\Desktop\skole repo\Mandatory2\MbmStore\Views\Shared\_ProductSummaryBook.cshtml"
WriteAttributeValue("", 155, Model.Title, 155, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"width:100px\" />\r\n    </div><div class=\"col-md-4\">\r\n        <strong>Title:</strong>");
#nullable restore
#line 10 "C:\Users\lille\Desktop\skole repo\Mandatory2\MbmStore\Views\Shared\_ProductSummaryBook.cshtml"
                          Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n        <strong>Author:</strong>");
#nullable restore
#line 11 "C:\Users\lille\Desktop\skole repo\Mandatory2\MbmStore\Views\Shared\_ProductSummaryBook.cshtml"
                           Write(Model.Author);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n        <strong>Price:</strong>");
#nullable restore
#line 12 "C:\Users\lille\Desktop\skole repo\Mandatory2\MbmStore\Views\Shared\_ProductSummaryBook.cshtml"
                          Write(Model.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n        <strong>Publisher:</strong>");
#nullable restore
#line 13 "C:\Users\lille\Desktop\skole repo\Mandatory2\MbmStore\Views\Shared\_ProductSummaryBook.cshtml"
                              Write(Model.Publisher);

#line default
#line hidden
#nullable disable
            WriteLiteral(" (");
#nullable restore
#line 13 "C:\Users\lille\Desktop\skole repo\Mandatory2\MbmStore\Views\Shared\_ProductSummaryBook.cshtml"
                                                Write(Model.Published);

#line default
#line hidden
#nullable disable
            WriteLiteral(")<br />\r\n        <strong>ISBN:</strong>");
#nullable restore
#line 14 "C:\Users\lille\Desktop\skole repo\Mandatory2\MbmStore\Views\Shared\_ProductSummaryBook.cshtml"
                         Write(Model.ISBN);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br /><br />\r\n    </div>\r\n\r\n    ");
#nullable restore
#line 17 "C:\Users\lille\Desktop\skole repo\Mandatory2\MbmStore\Views\Shared\_ProductSummaryBook.cshtml"
Write(await Html.PartialAsync("_AddToCartButton", (Product)Model));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MbmStore.Models.Book> Html { get; private set; }
    }
}
#pragma warning restore 1591
