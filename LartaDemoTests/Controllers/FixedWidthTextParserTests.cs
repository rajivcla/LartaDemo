using Microsoft.VisualStudio.TestTools.UnitTesting;
using LartaDemo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;

namespace LartaDemo.Tests
{
    [TestClass()]
    public class FixedWidthTextParserTests
    {
        [TestMethod()]
        public void ReadFileTest()
        {
            List<string[]> vals = FixedWidthTextParser.ReadFile(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"TestData\soccer.dat"));
            Assert.IsTrue(vals[0][0] == "Arsenal");
            Assert.IsTrue(vals[0][2] == "26");
            Assert.IsTrue(vals[19][2] == "5");
            Assert.IsTrue(vals[18][3] == "6");

            List<string[]> vals2 = FixedWidthTextParser.ReadFile(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"TestData\w_data.dat"));
            Assert.IsTrue(vals2[0][0] == "1");
            Assert.IsTrue(vals2[0][2] == "59");
            Assert.IsTrue(vals2[25][1] == "97*");
            Assert.IsTrue(vals2[0][15] == "23");
            Assert.IsTrue(vals2[18][16] == "1028.5");

        }
    }
}