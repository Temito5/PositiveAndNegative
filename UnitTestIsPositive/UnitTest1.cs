using Microsoft.VisualStudio.TestTools.UnitTesting;
using PositiveAndNegative;
using System;

namespace UnitTestIsPositive
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void UnitTestIfIsPositive()
        {
            Number number = new Number();
            int num = 5;

            bool result=number.IsPositive(num);

            Assert.IsTrue(true);
        }


        [TestMethod]
        public void UnitTestIfIsNegativetive()
        {
            Number number = new Number();
            int num =-4;

            bool result = number.IsPositive(num);

            Assert.IsFalse(false);
        }

        [TestMethod]
        public void UnitTestIfIs0()
        {
            Number number = new Number();
            int num = 0;

            Assert.ThrowsException<ArgumentException>(() => number.IsPositive(num));
        }
    }
}
