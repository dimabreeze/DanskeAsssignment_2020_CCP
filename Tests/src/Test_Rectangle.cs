using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assignment_DmitrijKosmakov_Danske;

namespace Assignment_DmitrijKosmakov_Danske_Test
{
    [TestClass]
    public class Test_Rectangle
    {
        private void test_Create_internal(double x, double y, double width, double height, bool expectThrow = false)
        {
            Action createRect = () => new Rectangle(x, y, width, height);
            if (expectThrow)
            {
                Assert.ThrowsException<ArgumentOutOfRangeException>(createRect);
            }
            else // happy path
            {
                createRect();
            }
        }

        [TestMethod]
        public void test_Create()
        {
            // Happy path: valid rectangle
            test_Create_internal(0, 0, 0, 0);
            test_Create_internal(0, 0, 1, 1);
            test_Create_internal(0, 0, 2, 2);
            test_Create_internal(0, 0, 2, 2);

            //                              expectThrow
            //                                  |
            test_Create_internal(0, 0, 0, -1, true);
            test_Create_internal(0, 0, -1, 0, true);
        }

        [TestMethod]
        public void test_Area()
        {
            Assert.AreEqual(0,  (new Rectangle(0, 0, 0, 0) as AbstractShape).Area);
            Assert.AreEqual(1,  (new Rectangle(0, 0, 1, 1) as AbstractShape).Area);
            Assert.AreEqual(2,  (new Rectangle(0, 0, 1, 2) as AbstractShape).Area);
            Assert.AreEqual(2,  (new Rectangle(0, 0, 2, 1) as AbstractShape).Area);
            Assert.AreEqual(25, (new Rectangle(0, 0, 5, 5) as AbstractShape).Area);
        }
    }
}
