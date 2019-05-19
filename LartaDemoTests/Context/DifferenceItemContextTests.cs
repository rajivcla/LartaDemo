using Microsoft.VisualStudio.TestTools.UnitTesting;
using LartaDemo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LartaDemo.Tests
{
    [TestClass()]
    public class DifferenceItemContextTests
    {
        [TestMethod()]
        public void DifferenceItemContextTest()
        {
            DifferenceItemContext<SoccerItem> context = new DifferenceItemContext<SoccerItem>("soccer");
            Assert.IsTrue(context.DifferenceItems.Count == 20);
        }

        [TestMethod()]
        public void AddTest()
        {
            DifferenceItemContext<SoccerItem> context = new DifferenceItemContext<SoccerItem>("soccer");
            context.Add(new SoccerItem() { Name = "test", Difference = 1 });
            Assert.IsTrue(context.DifferenceItems.Count == 21);
        }

        [TestMethod()]
        public void RemoveTest()
        {
            DifferenceItemContext<SoccerItem> context = new DifferenceItemContext<SoccerItem>("soccer");
            context.Remove(context.DifferenceItems[0]);
            Assert.IsTrue(context.DifferenceItems.Count == 19);
        }
    }
}