using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Liskov;

namespace Liskov_Unit_Test
{
    [TestClass]
    public class UnitTest1
    {
        [DataRow(1, 1, 1)]
        [DataRow(2, 2, 4)]
        [DataRow(3, 6, 18)]
        [DataRow(8, 7, 56)]
        [DataTestMethod]
        public void TestMethod1(int b, int h, int sup)
        {
            var rec = new Cuadrado();
            rec.setBase(b);
            rec.setAltura(h);
            Assert.AreEqual(sup, rec.GetSuperficie());
        }
    }
}
