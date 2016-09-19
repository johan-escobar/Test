using System;
using System.Runtime.InteropServices;
using FluentAssertions;
using JohanEscobar;
using Moq;
using NUnit.Framework.Constraints;
using TechTalk.SpecFlow;

namespace UnitTestProject1.TestSteps
{
    [Binding]
    public class CalculateBasketTotalSteps : BaseTest
    {
        [Then(@"I check the total is '(.*)'")]
        public void ThenICheckTheTotalIs(decimal p0)
        {
            var total = Cart.CalculateTotal(Basket);
            total.Should().Be(p0);

        }

        [Given(@"I try to calculate an empty basket")]
        public void GivenITryToCalculateAnEmptyBasket()
        {
            
        }

        [Then(@"I check an error message is returned")]
        public void ThenICheckAnErrorMessageIsReturned()
        {
            var mock = new Mock<IShoppingCartFunctions>();
            var response = mock.Setup(foo => foo.CalculateTotal(null)).Throws(new Exception("shopping baket is empty"));
            response.Verifiable(null);
        }

    }
}
