using System.Collections.Generic;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace JohanEscobar
{
    public class BaseTest
    {
        public static Dictionary<int, int> Basket { get; set; }

        public Products Products;

        public ShoppingCartFunction Cart
        {
            get { return new ShoppingCartFunction(); }
        }

        [Before()]
        public void SetUp()
        {
            if (Basket == null)
            {
                Basket = new Dictionary<int, int>();
            }
        }

        [After()]
        public void Teardown()
        {
            Basket.Clear();
        }




    }
}
