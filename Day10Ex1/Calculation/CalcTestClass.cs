using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Calculation
{
    [TestFixture]
    public class CalcTestClass
    {
        Calc c = new Calc();
        [Test]
        public void AddTest()
        {
            Assert.AreEqual(12,c.Add(8, 4));
        }
        [Test]
        public void SubTest()
        {
            Assert.AreEqual(4, c.Subtract(8, 4));
        }
        [Test]
        public void MulTest()
        {
            Assert.AreEqual(32, c.Multiply(8, 4));
        }
        [Test]
        public void DivTest()
        {
            Assert.AreEqual(2, c.Divide(8, 4));
        }
        [Test]
        public void PrimeTest()
        {
            Assert.IsTrue(c.Prime(2));
        }



    }
}
