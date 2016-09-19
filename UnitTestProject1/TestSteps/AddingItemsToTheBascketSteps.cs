using FluentAssertions;
using JohanEscobar;
using Moq;
using TechTalk.SpecFlow;

namespace UnitTestProject1.TestSteps
{
    [Binding]
    public class AddingItemsToTheBascketSteps : BaseTest
    {
       

       [Given(@"I select '(.*)' to be added to my shopping basket")]
        public void GivenISelectToBeAddedToMyShoppingBasket(string p0)
        {
            Products = new Products(p0);
            Basket = Cart.AddItem(Basket, Products.id);
            
        }

        [Given(@"I select '(.*)' twice to be added to my shopping cart")]
        public void GivenISelectTwiceToBeAddedToMyShoppingCart(string p0)
        {
            Products = new Products(p0);
            Basket = Cart.AddItem(Basket, Products.id);
            Basket = Cart.AddItem(Basket, Products.id);
        }

        [Given(@"I a request is made for a fruit that is not in stock")]
        public void GivenIARequestIsMadeForAFruitThatIsNotInStock()
        {
            var mock = new Mock<IProducts>();
            var product = mock.SetupProperty(f => f.ProductName, "g");
            product = mock.SetupProperty(f => f.id, 5);
            Cart.AddItem(Basket, product.Object.id);


        }

        [Then(@"I can see that the unavailable item was not added to the sopping cart")]
        public void ThenICanSeeThatTheUnavailableItemWasNotAddedToTheSoppingCart()
        {
            Basket.Should().BeEmpty();
        }



        [When(@"I am looking at the shopping basket")]
        public void WhenIAmLookingAtTheShoppingBasket()
        {
            
        }

        
        [Then(@"I can see that '(.*)' are added to my basket")]
        public void ThenICanSeeThatAreAddedToMyBasket(string p0)
        {
            Products.ProductName.Should().Be(p0);
            Basket.Count.Should().Be(1);
        }








    }
}
