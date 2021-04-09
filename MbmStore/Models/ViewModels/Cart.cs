using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MbmStore.Models.ViewModels
{
    public class Cart
    {
        private List<CartLine> lineCollection = new List<CartLine>();

        public virtual void AddItem(Product product, int quantity)
        {

            CartLine item = lineCollection.Where(p => p.Product.ProductID == product.ProductID).FirstOrDefault();
            if (item == null)
            {
                lineCollection.Add(new CartLine { Product = product, Quantity = quantity });
            }
            else
            {
                item.Quantity += quantity;
            }
        }

        public virtual void RemoveLine(Product product) => lineCollection.RemoveAll(i => i.Product.ProductID == product.ProductID);
        public decimal ComputeTotalValue() => lineCollection.Sum(e => e.Product.Price * e.Quantity);
        public virtual void Clear() => lineCollection.Clear();
        public List<CartLine> Lines => lineCollection;
    }


    public class CartLine{
    public Product Product { get; set; }
    public int Quantity { get; set; }}
}

//The Cartclass uses the CartLineclass, defined in the same file, to represent a product and the quantity selected by the customer.
//    Wedefined methods to add an item to the cart, remove a previously added itemfrom the cart, calculate the total cost of the items in the cart,
//    and reset the cart by removing allitems.Wealso provided a property Linesthat gives access to the contents of the cart using aList<CartLine>. 
//The codeuse“Expression Bodied Members”for methods and properties. 
//    Expression Bodied Membersare syntactic sugarthat removes the braces from simple methods and properties and makes them one-liners.