using FluentAssertions;
using JohanEscobar;
using TechTalk.SpecFlow;

namespace UnitTestProject1.TestSteps
{
    [Binding]
    public class RemoveItemsFromTheBascketSteps : BaseTest
    {


        [Then(@"I remove '(.*)' from my basket")]
        public void ThenIRemoveFromMyBasket(string p0)
        {
            Products = new Products(p0);
            Cart.RemoveItem(Basket, Products.id);

        }
        
        [Then(@"check that the basket is empty")]
        public void ThenCheckThatTheBasketIsEmpty()
        {
            Basket.Should().BeEmpty();
        }




  








    }
}
