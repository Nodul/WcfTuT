using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WcfTuT.Managers;
using WcfTuT.Managers.FakeManagers;
using WcfTuT.Interfaces;
using System.Collections.Generic;

namespace WcfTuTService.Tests
{
    [TestClass]
    public class NumbersTests
    {
        INumbersGenerator numgen;

        [TestInitialize]
        public void InitNumberTests()
        {
            numgen = new NumbersGenerator();           
        }

        [TestMethod]
        public void RunFakeNumberGenerator_Valid_True()
        {
            // Assign
            numgen = new FakeNumbersGenerator();
            List<int> fakeNumbers = new List<int>() { 1, 5, 9, 10, 4 };
            // Act
            DieTossResult dieTossResult = numgen.GenerateDieResults(5,5);
            // Assert

            Assert.IsNotNull(dieTossResult);
            for(int i = 0; i < dieTossResult.Results.Count; i++)
            {
                Assert.AreEqual(fakeNumbers[i], dieTossResult.Results[i]);
            }                   
        }
        [TestMethod]
        public void RunNumberGenerator_Valid_True()
        {
            int sides = 5;
            int throws = 5;
            DieTossResult dieTossResult = numgen.GenerateDieResults(sides, throws);
            Assert.IsNotNull(dieTossResult);
            Assert.AreEqual(dieTossResult.Results.Count, throws);
            foreach(var num in dieTossResult.Results)
            {
                Assert.IsTrue(num >= 1 && num <= sides);
            }
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void RunNumberGenerator_WrongSides_Exception()
        {
            DieTossResult dieTossResult = numgen.GenerateDieResults(0,4);
        }
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void RunNumberGenerator_WrongThrows_Exception()
        {
            DieTossResult dieTossResult = numgen.GenerateDieResults(4,0);
        }
    }
}
