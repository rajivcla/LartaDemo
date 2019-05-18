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
    public class DifferenceControllerTests
    {
        [TestMethod()]
        public void DifferenceControllerTest()
        {
            DifferenceController<SoccerItem> dC = new DifferenceController<SoccerItem>("soccer");
            List<DifferenceItem> di = dC.GetResult();
            Assert.IsTrue(di.Count > 0);
            Assert.IsTrue(di[0].Difference == 1);
        }

        [TestMethod()]
        public void getMinTest()
        {
            DifferenceControllerTest();
        }

        [TestMethod()]
        public void FindLessThanTest()
        {
            DifferenceController<SoccerItem> dC = new DifferenceController<SoccerItem>("soccer");
            dC.FindLessThan(8);
            List<DifferenceItem> di = dC.GetResult();
            Assert.IsTrue(di.Count > 0);
            Assert.IsTrue(di[4].Difference == 8);

        }
    }
}