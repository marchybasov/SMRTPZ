using System;
using Xunit;
using Lab3;

namespace Lab3.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Can_CountCard()
        {

            CardRegister register = new CardRegister();
            CountCard card = register.CreateCountCard(3);

            bool result = card.TryPass();
            result = card.TryPass();

            Assert.True(result);
            Assert.Equal(1, card.GetTripsCount());
        }

        [Fact]
        public void GateRegisterTest()
        {
            CardRegister register = new CardRegister();

            CountCard card = register.CreateCountCard(5);
            Assert.Equal(5, card.GetTripsCount());
        }
    }
}
