using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace MbmStore.Infrastructure
{
    public static class UrlExtensions
    {

        public static string PathAndQuery(this HttpRequest request) => request.QueryString.HasValue ? $"{request.Path}{request.QueryString}" : request.Path.ToString();


    }
}

//The PathAndQueryextension method operates on the HttpRequestclass, which ASP.NET uses to describe an HTTP request. 
//    The extension method generates an URL that the browser will return to after the cart has been updated, 
//    taking into account the query string if there is one. 




