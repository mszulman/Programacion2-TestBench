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
        [DataRow(3, 4, 12)]
        [DataTestMethod]
        public void TestMethod1(int b, int h, int sup)
        {
            var rec = new Cuadrado();
            rec.Base = b;
            rec.Altura = h;
            Assert.AreEqual(sup, rec.GetSuperficie());
        }

    }
}
