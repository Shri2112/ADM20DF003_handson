using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using CalcLibrary;

namespace CalculateTest
{
    [TestFixture]
    public class CalculatorTester
    {
        SimpleCalculator sc = new SimpleCalculator();
        double result;
        [SetUp]
        public void SetUpMethod()
        {
            result = 0;
        }
        [Test]
        [TestCase(20, 25, 45)]
        public void TestAddAndClear(double x, double y, double z)
        {
             result =sc.Addition(x, y);
            Assert.AreEqual(z, result);
        }
        [Test]
        [TestCase(25, 20, 5)]
        [TestCase(10,2,8)]
        public void calculatorSubtractMethod(double x, double y, double z)
        {
            result = sc.Subtraction(x, y);
            Assert.AreEqual(z, result);
        }
        [Test]
        [TestCase(5, 2, 10)]
        public void calculatorMultiplyMethod(double x, double y, double z)
        {
            result = sc.Multiplication(x, y);
            Assert.AreEqual(z, result);
        }
        [Test]
        [TestCase(55, 5, 11)]
        [TestCase(2,0,0)]
        public void calculatorDivideMethod(double x, double y, double z)
        {
            try
            {
                result = sc.Division(x, y);
                Assert.AreEqual(z, result);
            }
            catch(Exception e)
            {
                Assert.Fail("Divide By Zero");
            }
        }
        [TearDown]
        public void AllClear()
        {
            result = 0;
        }
    }
}
