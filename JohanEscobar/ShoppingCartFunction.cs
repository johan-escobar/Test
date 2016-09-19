using System;
using System.Collections.Generic;
using System.Linq;


namespace JohanEscobar
{
    public class ShoppingCartFunction : IShoppingCartFunctions
    {
        //public Dictionary<int, int> FruitList;
        Products product;


        public Dictionary<int, int> AddItem(Dictionary<int, int> basket,  int productId)
        {
             product = new Products(productId);
            
             try
             {
                 if (!basket.Keys.Contains(productId) && product.Stock > 0)
                 {

                     basket.Add(productId, 1);
                 }
                 else
                 {
                     basket[productId]++;
                 }
             }
             catch (KeyNotFoundException e)
             {
                 Console.WriteLine("");
                 return basket;
             }

             return basket; 
        }

        public void RemoveItem(Dictionary<int, int> basket, int id)
        {
            basket.Remove(id);

        }


        public decimal CalculateTotal(Dictionary<int, int> basket)
        {
            List<int> subtotal = new List<int>();
            int total = 0 ;
            foreach (var item in basket)
            {
                product = new Products(item.Key);
                subtotal.Add(product.Price * item.Value);
            }

            foreach (var UnitTotal in subtotal)
            {
                total = UnitTotal + total;
            }
            return total;
        }
    }
}
