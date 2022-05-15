using CoffeeMaker;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace StarBucksTest
{
    [TestClass]
    public class StarBucksUnitTest
    {
        [TestMethod]
        public void OrderCoffeeFake_InStarBucks_ShouldReturnReceivesMessage()
        {
            StarBucksStore store = new StarBucksStore(new FakeStarBucks());//Arrange
            string actual = store.OrderCoffee(3, 5);//Act
            Assert.AreEqual(actual, "Your Order Is Received");//Assert
        }
        [TestMethod]
        public void OrderCoffeeMob_InStarBucks_ShouldReturnReceivesMessage()
        {
            var moqService = new Mock<IMakeACoffee>();
            moqService.Setup(x => x.CheckIngridientAvailability()).Returns(true);
            moqService.Setup(x => x.CoffeeMaking(3, 5)).Returns("Your Order Is Received");
            StarBucksStore result = new StarBucksStore(moqService.Object);
            string actual = result.OrderCoffee(3, 5);
            Assert.AreEqual(actual, "Your Order Is Received");
        }
        [TestMethod]
        public void OrderCoffeeStub_InStarBucks_ShouldReturnReceivesMessage()
        {
            StarBucksStore store = new StarBucksStore(new StubStarBucks());
            string actual = store.OrderCoffee(3, 5);
            Assert.AreEqual(actual, "Your Order Is Received");
        }
    }
}