using NUnit.Framework;
using Restaurant;
using System.IO;
using System.Drawing;

namespace TestProjectRest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Item item = new Item();
            int count =0;
            Assert.AreEqual(count, item.CountPriceByAmount(5));
        }
        [Test]
        public void Test2()
        {
            Item item = new Item();
            OrderItem order = new OrderItem(item, 5);
            int count = 4;
            order.DecAmount();
            Assert.AreEqual(count, order.Amount);
        }
        [Test]
        public void Test3()
        {
            Item item = new Item();
            OrderItem order = new OrderItem(item, 5);
            int count = 6;
            order.IncAmount();
            Assert.AreEqual(count, order.Amount);
        }
        [Test]
        public void Test4()
        {
            Item item = new Item();
            OrderItem order = new OrderItem(item, 5);
            int count =0 ;
            order.IncAmount();
            Assert.AreEqual(count, order.Price);
        }
    }
}