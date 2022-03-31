﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions;

namespace UnitTesting_Tests
{
    [TestClass]
    public class UnitTestA
    {
        [TestMethod]
        public void TestMethodA()
        {
            var a = new UnitTesting_Code.ClassA();
            Assert.AreEqual("Hola!", a.DeciHola());
        }

        [TestMethod]
        public void TestMethodB()
        {
            var a = new UnitTesting_Code.ClassA();
            a.DeciHola().Should().Be("Hola!");
        }
    }
}
