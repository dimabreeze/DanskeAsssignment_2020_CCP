using System;
using System.IO;
using System.Security.Cryptography;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assignment_DmitrijKosmakov_Danske;

namespace Assignment_DmitrijKosmakov_Danske_Test
{
    [TestClass]
    public class Test_App
    {
        private static string CalculateMD5(string filename)
        {
            using (var md5 = MD5.Create())
            {
                using (var stream = File.OpenRead(filename))
                {
                    var hash = md5.ComputeHash(stream);
                    return BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();
                }
            }
        }
        [TestMethod]
        public void test_RunWithDumpToFile()
        {
            var input = Path.GetFullPath("TestData/input.txt");
            var output = Path.GetFullPath("TestData/output.txt");
            Assert.AreEqual(0, new App(input, output).run());

            var expected = Path.GetFullPath("TestData/output_expected.txt");
            Assert.AreEqual(CalculateMD5(expected), CalculateMD5(output));
        }
    }
}
