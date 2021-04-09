using System;
using Microsoft.AspNetCore.Mvc;
using System.Linq; 
using MbmStore.Infrastructure;

namespace MbmStore.Components
{
    public class NavigationMenuViewComponent: ViewComponent
    {

        public IViewComponentResult Invoke()
        {
            return View(Repository.Products.Select(x => x.Category).Distinct().OrderBy(x => x));
        }
    }
}
    