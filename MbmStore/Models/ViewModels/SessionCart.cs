using System;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using MbmStore.Infrastructure;

namespace MbmStore.Models.ViewModels
{
    public class SessionCart : Cart
    {
        public static Cart GetCart(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?
                .HttpContext.Session;
            SessionCart cart = session?.GetJson<SessionCart>("Cart") ?? new SessionCart();
            cart.Session = session;
            return cart;
        }
        [JsonIgnore] public ISession Session { get; set; }
        public override void AddItem(Product product, int quantity)
        {
            base.AddItem(product, quantity);
            Session.SetJson("Cart", this);
        }
        public override void RemoveLine(Product product)
        {
            base.RemoveLine(product); Session.SetJson("Cart", this);
        }

        public override void Clear()
        {
            base.Clear(); Session.Remove("Cart");
        }
    }
}

//he SessionCartclass is a subclassofthe Cartclass and overrides the AddItem, RemoveLine, 
//    and Clearmethods so they call the base implementations and then store the updated state in the session using 
//    theextension methods on the ISessioninterface I defined in exercise 4. The static GetCartmethod is a factoryfor creating SessionCartobjects and
//    providing them with an ISessionobject so they can store themselves.Extension methods enable you to "add" methods to existing types without creating a new derived typeor modifying the original type.
//    Extension methods are a special kind of static method, but they are called as if they were instance methods on the extended type. 
//    Knowing about extension methods in details is outside the scope of this course. 