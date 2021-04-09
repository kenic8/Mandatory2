using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering; 
using Microsoft.AspNetCore.Mvc.Routing; 
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers; 
using MbmStore.Models.ViewModels;
using System.Collections.Generic;

namespace MbmStore.Infrastructure
{

    [HtmlTargetElement("div", Attributes = "page-model")]
    public class PageLinkTagHelper : TagHelper
    {
        private IUrlHelperFactory urlHelperFactory;
        public PageLinkTagHelper(IUrlHelperFactory helperFactory)
        {
            urlHelperFactory = helperFactory;
        }
        [ViewContext]
        [HtmlAttributeNotBound]
        public ViewContext ViewContext { get; set; }
        public PagingInfo PageModel { get; set; }
        public string PageAction { get; set; }

        [HtmlAttributeName(DictionaryAttributePrefix = "page-url-")] public Dictionary<string, object> PageUrlValues { get; set; } = new Dictionary<string, object>();



        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            IUrlHelper urlHelper = urlHelperFactory.GetUrlHelper(ViewContext); TagBuilder result = new TagBuilder("div"); 
            for (int i = 1; i <= PageModel.TotalPages; i++)
            {
                TagBuilder tag = new TagBuilder("a");
                PageUrlValues["page"] = i;
                tag.Attributes["href"] = urlHelper.Action(PageAction, PageUrlValues);
                //tag.Attributes["href"] = urlHelper.Action(PageAction, new { page = i });
                tag.InnerHtml.Append(i.ToString()); result.InnerHtml.AppendHtml(tag);
            }
            output.Content.AppendHtml(result.InnerHtml);
        }
    }
}



//This tag helper populates a divelement with aelements that correspond to pages of products. 
//    I am not going to go into detail about tag helpers now; 
//it is enough to know that they are one of the most useful ways that you can introduce C# logic into your views.
//    The code for a tag helper can look tortured because C# and HTML don’t mix easily. 
//    But using tag helpers is preferable to including blocks of C# code in a view because a tag helper can be easily unit tested.