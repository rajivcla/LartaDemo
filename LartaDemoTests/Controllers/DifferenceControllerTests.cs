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
       DifferenceController<SoccerItem> dC;
       //[TestMethod()]
       // public void DifferenceControllerTest()
       // {
       //     SetupTest();
       //     List<DifferenceItem> di = dC.UpdateView();
       //     Assert.IsTrue(di.Count > 0);
       //     Assert.IsTrue(di[0].Difference == 1);
       // }

       // [TestMethod()]
       // public void getMinTest()
       // {
       //     SetupTest();
       //     List<DifferenceItem> di = dC.UpdateView();

       //     SoccerItem fakeMin = new SoccerItem();
       //     fakeMin.Name = "FakeTeam";
       //     fakeMin.Difference = di[0].Difference;
       //     dC.Add(fakeMin);

       //     dC.FindMin();
       //     di = dC.UpdateView();
       //     Assert.IsTrue(di.Count == 2);
       //     Assert.IsTrue(di[0].Difference == 1);
       // }

       // [TestMethod()]
       // public void FindLessThanTest()
       // {
       //     SetupTest();
       //     dC.FindLessThan(8);
       //     List<DifferenceItem> di = dC.UpdateView();
       //     Assert.IsTrue(di.Count > 0);
       //     Assert.IsTrue(di[4].Difference == 8);

       // }

       // public void SetupTest()
       // {
       //     dC = new DifferenceController<SoccerItem>(new DifferenceItemContext<SoccerItem>("soccer"));
       // }
    }
}