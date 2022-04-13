using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingExercise.Test
{
    [TestClass]
    public class FizzBizzLogicTest
    {
        [TestMethod]
        public void FizzTest()
        {
            FizzBizzLogic fizz = new FizzBizzLogic();
            Assert.IsTrue(fizz.FizzBizz(3) == 3);
        }
        [TestMethod]
        public void BuzzTest()
        {
            FizzBizzLogic fizz = new FizzBizzLogic();
            Assert.IsTrue(fizz.FizzBizz(5) == 5);
        }

        [TestMethod]
        public void FizzBuzzTest()
        {
            FizzBizzLogic fizz = new FizzBizzLogic();
            Assert.IsTrue(fizz.FizzBizz(15) == 15);
        }

        [TestMethod]
        public void DividTest()
        {
            FizzBizzLogic fizz = new FizzBizzLogic();
            Assert.IsTrue(fizz.FizzBizz(23) == -1);
        }
    }
}
