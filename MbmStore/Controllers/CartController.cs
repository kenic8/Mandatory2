using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks; 
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MbmStore.Models;
using MbmStore.Infrastructure;
using MbmStore.Models.ViewModels;

namespace MbmStore.Controllers
{
    public class CartController : Controller
    {
        private Cart cart;

        public CartController(Cart cartService)
        {
            cart = cartService;
        }

        ///i action for cart
        public ViewResult Index(string returnUrl)
        {
            return View(new CartIndexViewModel
            {
                Cart = GetCart(),
                ReturnUrl = returnUrl
            });
        }


        public RedirectToActionResult AddToCart(int productID, string returnUrl)
        {
            Product product = Repository.Products.FirstOrDefault(p => p.ProductID == productID);
            if (product != null)
            {
                cart.AddItem(product, 1);
            }
            return RedirectToAction("Index", new { returnUrl });
        }
        public RedirectToActionResult RemoveFromCart(int productID, string returnUrl)
        {
            Product product = Repository.Products.FirstOrDefault(p => p.ProductID == productID);
            if (product != null)
            {
                cart.RemoveLine(product);
            }
            return RedirectToAction("Index", new { returnUrl });
        }
        private Cart GetCart()
        {
            Cart cart = HttpContext.Session.GetJson<Cart>("Cart");
            if (cart == null)
            {
                cart = new Cart();
                HttpContext.Session.SetJson("Cart", cart);
            }
            return cart;
        }
        private void SaveCart(Cart cart)
        {
            HttpContext.Session.SetJson("Cart", cart);
        }
    }
}


//There are a few points to note about this controller.
//    The first is that weuse the ASP.NET session state feature to storeand retrieve Cartobjects,
//    which is the purpose of the GetCartmethod. The session middleware that weregistered in the previous section uses cookies 
//    or URL rewriting to associate multiple requests from a user together to form a single browsing session.
//    A related feature is session state, which associates data with a session. 
//    This is an ideal fit for the Cart class: Wewant each user to have their own cart, and wewant the cart to be persistent between requests
//    .Data associated with a session is deleted when a session expires (typically, because a user has not made a request for awhile),
//    which means that wedo not need to manage the storage or life cycle of the Cartobjects.For the Catalogueand RemoveFromCartaction methods,
//    we use parameter names that matchthe input elements in the HTML forms created in the Catalogue\Index.cshtmlview.
//    This allows MVC toassociate incoming form POST variables with those parameters, meaning we do not need to process the formourselves.
//    This is known as model bindingand is a powerful tool for simplifying controller classes.



//new way Refining the Cart Model with a Service 

//The CartControllerclass indicates that it needs a Cartobject by declaring a constructor argument,  
//    which has allowed us to remove the methods that read and write data from the session and the steps required to write updates. 
//    The result is a controller that is simpler.It remains focused on its role in the application
//    without having to worry about how Cartobjects are created or persisted.
//    And, since services are available throughout the application, any component can get hold of the user’s cart using the same technique.