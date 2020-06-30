using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assignment_DmitrijKosmakov_Danske;

namespace Assignment_DmitrijKosmakov_Danske_Test
{
    [TestClass]
    public class Test_Rectangle_Extensions
    {
        [TestMethod]
        public void test_TallOrFlat()
        {
            Assert.AreEqual("square", new Rectangle(0, 0, 0, 0).TallOrFlat());
            Assert.AreEqual("square", new Rectangle(0, 0, 1, 1).TallOrFlat());
            Assert.AreEqual("square", new Rectangle(0, 0, 7, 7).TallOrFlat());

            Assert.AreEqual("tall", new Rectangle(0, 0, 0, 1).TallOrFlat());
            Assert.AreEqual("tall", new Rectangle(0, 0, 1, 2).TallOrFlat());
            Assert.AreEqual("tall", new Rectangle(0, 0, 8, 9).TallOrFlat());

            Assert.AreEqual("flat", new Rectangle(0, 0, 1, 0).TallOrFlat());
            Assert.AreEqual("flat", new Rectangle(0, 0, 2, 1).TallOrFlat());
            Assert.AreEqual("flat", new Rectangle(0, 0, 9, 8).TallOrFlat());
        }
    }
}
