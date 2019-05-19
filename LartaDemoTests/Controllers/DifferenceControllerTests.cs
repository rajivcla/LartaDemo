using Microsoft.VisualStudio.TestTools.UnitTesting;
using LartaDemo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LartaDemoTests.Tests;

namespace LartaDemo.Tests
{
    [TestClass()]
    public class DifferenceControllerTests
    {
       public DifferenceController<SoccerItem> dC;
       [TestMethod()]
        public void DifferenceControllerTest()
        {
            SetupTest();
            Assert.IsTrue(dC != null);
        }

        public void SetupTest()
        {

            DifferenceItemContextMock<SoccerItem> context = new DifferenceItemContextMock<SoccerItem>();
            context.Add(new SoccerItem() { Name = "team1", Difference = 1 });
            context.Add(new SoccerItem() { Name = "team2", Difference = 2 });
            context.Add(new SoccerItem() { Name = "team3", Difference = 3 });
            context.Add(new SoccerItem() { Name = "team4", Difference = 1 });
            dC = new DifferenceController<SoccerItem>(new SoccerView<SoccerItem>(), context);
        }

        [TestMethod()]
        public void FindMinTest()
        {
            SetupTest();
            List<SoccerItem> di = dC.getResult();
            Assert.IsTrue(di.Count == 2);
            Assert.IsTrue(di[0].Difference == 1);
        }

        [TestMethod()]
        public void FindLessThanTest()
        {
            SetupTest();
            dC.FindLessThan(2);
            List<SoccerItem> di = dC.getResult();
            Assert.IsTrue(di.Count == 3);
            Assert.IsTrue(di[0].Difference == 1);
        }

        
        [TestMethod()]
        public void getResultTest()
        {
            SetupTest();
            List<SoccerItem> di = dC.getResult();
            Assert.IsTrue(di.Count == 2);
        }
    }
}