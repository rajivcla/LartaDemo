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
    public class SoccerViewTests
    {
        [TestMethod()]
        public void DisplayTextTest()
        {
            SoccerView<SoccerItem> sv = new SoccerView<SoccerItem>();
            string s = sv.DisplayText("team", 10);
            Assert.IsTrue(s == "The team soccer club had the smallest difference of 10 goals scored for vs against");
        }
    }
}