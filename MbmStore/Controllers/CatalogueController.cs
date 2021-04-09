using MbmStore.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using MbmStore.Models.ViewModels;

namespace MbmStore.Controllers
{
    public class CatalogueController : Controller
    {
        public int PageSize = 4;
        // GET: Catalogue
        public IActionResult Index( string category, int page = 1)
        {
       
            ProductsListViewModel model = new ProductsListViewModel();
            model = new ProductsListViewModel
            {
                Products = Repository.Products.Where(p => category == null || p.Category == category).OrderBy(p => p.ProductID)
                .Skip((page - 1) * PageSize).
                Take(PageSize),

                PagingInfo = new PagingInfo
                {   CurrentPage = page, 
                    ItemsPerPage = PageSize,
                    TotalItems = category == null ? Repository.Products.Count() : Repository.Products.Where(e => e.Category == category).Count()
                },
                    CurrentCategory = category
            };



            //return View(Repository.Products.OrderBy(p => p.ProductID).Skip((page-1)*PageSize).Take(PageSize));
            return View(model);

        }
    }
}



//The PageSizefield specifies that wewant four products per pageI have added an optional parameter to the Indexmethod. This means that if we call the methodwithout a parameter (Index()), 
//    thecall is treated as though wehad supplied the value specified in the parameterdefinition (–the default value is 1). 
//    The effect is that the action method displays the first page of products when the MVCFramework invokes it without an argument. 
//    Within the body of the action method, weget the Productobjects, orderthem by the primary key, 
//    skip over the products that occur before the start of the current page, and take the number ofproducts specified by the PageSizefield.



/////the products list model These changes pass a ProductsListViewModelobject as the model data to the view.
///To display the ProductsListViewModelinside the View, 
///we need to change the Model of the View. We’ll do that in the next section.Wehave everything in place to add the page links to the List view.
///Wecreated the view model that contains the paging information,
///updated the controller so that it passes this information to the view, and changed the @modeldirective to match the new model view type.
///


//// Books list
//IList<Book> books = new List<Book>();
//books = Repository.Products.OfType<Book>().ToList();
//ViewBag.Books = books;

//// MusicCDs list
//IList<MusicCD> musicCDs = new List<MusicCD>();
//musicCDs = Repository.Products.OfType<MusicCD>().ToList();
//ViewBag.MusicCDs = musicCDs;


//// Movies list
//IList<Movie> movies = new List<Movie>();
//movies = Repository.Products.OfType<Movie>().ToList();
//ViewBag.Movies = movies;