#pragma checksum "C:\Users\lille\Desktop\skole repo\Mandatory2\MbmStore\Views\Catalogue\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "74e6f5aee5b3ddb667db1a85c7298f507f6488ab"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Catalogue_Index), @"mvc.1.0.view", @"/Views/Catalogue/Index.cshtml")]
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
#line 1 "C:\Users\lille\Desktop\skole repo\Mandatory2\MbmStore\Views\Catalogue\Index.cshtml"
using MbmStore.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\lille\Desktop\skole repo\Mandatory2\MbmStore\Views\Catalogue\Index.cshtml"
using MbmStore.Infrastructure;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"74e6f5aee5b3ddb667db1a85c7298f507f6488ab", @"/Views/Catalogue/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e14ff1bc687addf7bd4613bc821f60082fbc3ed4", @"/Views/_ViewImports.cshtml")]
    public class Views_Catalogue_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductsListViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("page-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("page-classes-enabled", new global::Microsoft.AspNetCore.Html.HtmlString("true"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("page-class", new global::Microsoft.AspNetCore.Html.HtmlString("btn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("page-class-normal", new global::Microsoft.AspNetCore.Html.HtmlString("btn-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("page-class-selected", new global::Microsoft.AspNetCore.Html.HtmlString("btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn-group pull-right m-1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::MbmStore.Infrastructure.PageLinkTagHelper __MbmStore_Infrastructure_PageLinkTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
            WriteLiteral("\n");
#nullable restore
#line 7 "C:\Users\lille\Desktop\skole repo\Mandatory2\MbmStore\Views\Catalogue\Index.cshtml"
   ViewData["Title"] = "Products"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n<!DOCTYPE html>\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "74e6f5aee5b3ddb667db1a85c7298f507f6488ab5957", async() => {
                WriteLiteral("\n    <title>MbmStore Catalogue</title>\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "74e6f5aee5b3ddb667db1a85c7298f507f6488ab6958", async() => {
                WriteLiteral("\n\n");
                WriteLiteral("\n    <div class=\"products\" style=\"clear:both\">\n\n");
#nullable restore
#line 24 "C:\Users\lille\Desktop\skole repo\Mandatory2\MbmStore\Views\Catalogue\Index.cshtml"
         if (Model.Products.OfType<Book>().ToList().Count > 0)
        {


#line default
#line hidden
#nullable disable
                WriteLiteral("<h2>The Books</h2>\n");
#nullable restore
#line 28 "C:\Users\lille\Desktop\skole repo\Mandatory2\MbmStore\Views\Catalogue\Index.cshtml"
                 foreach (Book book in Model.Products.OfType<Book>().ToList())
                {

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "C:\Users\lille\Desktop\skole repo\Mandatory2\MbmStore\Views\Catalogue\Index.cshtml"
Write(await Html.PartialAsync("_ProductSummaryBook", book));

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "C:\Users\lille\Desktop\skole repo\Mandatory2\MbmStore\Views\Catalogue\Index.cshtml"
                                                     ;
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "C:\Users\lille\Desktop\skole repo\Mandatory2\MbmStore\Views\Catalogue\Index.cshtml"
 }

#line default
#line hidden
#nullable disable
                WriteLiteral("\n\n");
#nullable restore
#line 34 "C:\Users\lille\Desktop\skole repo\Mandatory2\MbmStore\Views\Catalogue\Index.cshtml"
         if (Model.Products.OfType<MusicCD>().ToList().Count > 0)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("<h2>The CDs</h2>\n");
#nullable restore
#line 37 "C:\Users\lille\Desktop\skole repo\Mandatory2\MbmStore\Views\Catalogue\Index.cshtml"
                 foreach (MusicCD cd in Model.Products.OfType<MusicCD>().ToList())
                {

#line default
#line hidden
#nullable disable
#nullable restore
#line 39 "C:\Users\lille\Desktop\skole repo\Mandatory2\MbmStore\Views\Catalogue\Index.cshtml"
Write(await Html.PartialAsync("_ProductSummaryMusicCD", cd));

#line default
#line hidden
#nullable disable
#nullable restore
#line 39 "C:\Users\lille\Desktop\skole repo\Mandatory2\MbmStore\Views\Catalogue\Index.cshtml"
                                                      ;
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 40 "C:\Users\lille\Desktop\skole repo\Mandatory2\MbmStore\Views\Catalogue\Index.cshtml"
 }

#line default
#line hidden
#nullable disable
                WriteLiteral("\n\n\n");
#nullable restore
#line 44 "C:\Users\lille\Desktop\skole repo\Mandatory2\MbmStore\Views\Catalogue\Index.cshtml"
         if (Model.Products.OfType<Movie>().ToList().Count > 0)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("<h2>The Movies</h2>\n");
#nullable restore
#line 47 "C:\Users\lille\Desktop\skole repo\Mandatory2\MbmStore\Views\Catalogue\Index.cshtml"
                 foreach (Movie movie in Model.Products.OfType<Movie>().ToList())
                {

#line default
#line hidden
#nullable disable
#nullable restore
#line 49 "C:\Users\lille\Desktop\skole repo\Mandatory2\MbmStore\Views\Catalogue\Index.cshtml"
Write(await Html.PartialAsync("_ProductSummaryMovie", movie));

#line default
#line hidden
#nullable disable
#nullable restore
#line 49 "C:\Users\lille\Desktop\skole repo\Mandatory2\MbmStore\Views\Catalogue\Index.cshtml"
                                                       ;
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 50 "C:\Users\lille\Desktop\skole repo\Mandatory2\MbmStore\Views\Catalogue\Index.cshtml"
 }

#line default
#line hidden
#nullable disable
                WriteLiteral("\n    </div>\n\n\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "74e6f5aee5b3ddb667db1a85c7298f507f6488ab10964", async() => {
                    WriteLiteral("\n    ");
                }
                );
                __MbmStore_Infrastructure_PageLinkTagHelper = CreateTagHelper<global::MbmStore.Infrastructure.PageLinkTagHelper>();
                __tagHelperExecutionContext.Add(__MbmStore_Infrastructure_PageLinkTagHelper);
#nullable restore
#line 55 "C:\Users\lille\Desktop\skole repo\Mandatory2\MbmStore\Views\Catalogue\Index.cshtml"
__MbmStore_Infrastructure_PageLinkTagHelper.PageModel = Model.PagingInfo;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("page-model", __MbmStore_Infrastructure_PageLinkTagHelper.PageModel, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __MbmStore_Infrastructure_PageLinkTagHelper.PageAction = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                if (__MbmStore_Infrastructure_PageLinkTagHelper.PageUrlValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("page-url-category", "MbmStore.Infrastructure.PageLinkTagHelper", "PageUrlValues"));
                }
#nullable restore
#line 56 "C:\Users\lille\Desktop\skole repo\Mandatory2\MbmStore\Views\Catalogue\Index.cshtml"
__MbmStore_Infrastructure_PageLinkTagHelper.PageUrlValues["category"] = Model.CurrentCategory;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("page-url-category", __MbmStore_Infrastructure_PageLinkTagHelper.PageUrlValues["category"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n");
                WriteLiteral("\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
            WriteLiteral("\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductsListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
