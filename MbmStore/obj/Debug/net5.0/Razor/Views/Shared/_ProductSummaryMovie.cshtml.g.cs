#pragma checksum "C:\Users\lille\Desktop\skole repo\mandatory-6-8\Mandatory6-8\MbmStore\Views\Shared\_ProductSummaryMovie.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "46534aa266af6121cde6b25032edc166aef03724"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__ProductSummaryMovie), @"mvc.1.0.view", @"/Views/Shared/_ProductSummaryMovie.cshtml")]
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
#line 2 "C:\Users\lille\Desktop\skole repo\mandatory-6-8\Mandatory6-8\MbmStore\Views\_ViewImports.cshtml"
using MbmStore.Models.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\lille\Desktop\skole repo\mandatory-6-8\Mandatory6-8\MbmStore\Views\Shared\_ProductSummaryMovie.cshtml"
using MbmStore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"46534aa266af6121cde6b25032edc166aef03724", @"/Views/Shared/_ProductSummaryMovie.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e14ff1bc687addf7bd4613bc821f60082fbc3ed4", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__ProductSummaryMovie : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MbmStore.Models.Movie>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-md-2\">\r\n        <img");
            BeginWriteAttribute("src", " src=\"", 118, "\"", 147, 2);
            WriteAttributeValue("", 124, "/Images/", 124, 8, true);
#nullable restore
#line 7 "C:\Users\lille\Desktop\skole repo\mandatory-6-8\Mandatory6-8\MbmStore\Views\Shared\_ProductSummaryMovie.cshtml"
WriteAttributeValue("", 132, Model.ImageUrl, 132, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 148, "\"", 166, 1);
#nullable restore
#line 7 "C:\Users\lille\Desktop\skole repo\mandatory-6-8\Mandatory6-8\MbmStore\Views\Shared\_ProductSummaryMovie.cshtml"
WriteAttributeValue("", 154, Model.Title, 154, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"width:100px\" />\r\n    </div><div class=\"col-md-4\">\r\n        <strong>Title:</strong>");
#nullable restore
#line 9 "C:\Users\lille\Desktop\skole repo\mandatory-6-8\Mandatory6-8\MbmStore\Views\Shared\_ProductSummaryMovie.cshtml"
                          Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n        <strong>Director:</strong>");
#nullable restore
#line 10 "C:\Users\lille\Desktop\skole repo\mandatory-6-8\Mandatory6-8\MbmStore\Views\Shared\_ProductSummaryMovie.cshtml"
                             Write(Model.Director);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n        <strong>Price:</strong> ");
#nullable restore
#line 11 "C:\Users\lille\Desktop\skole repo\mandatory-6-8\Mandatory6-8\MbmStore\Views\Shared\_ProductSummaryMovie.cshtml"
                           Write(String.Format("{0:0.00}", Model.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\r\n    </div>\r\n\r\n    ");
#nullable restore
#line 14 "C:\Users\lille\Desktop\skole repo\mandatory-6-8\Mandatory6-8\MbmStore\Views\Shared\_ProductSummaryMovie.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MbmStore.Models.Movie> Html { get; private set; }
    }
}
#pragma warning restore 1591