using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using UnitTestProject;

namespace CalcLibrary
{
    [TestFixture]
    public class CalculatorTester
    {
        int result;
        [SetUp]
        public void SetUpMethod()
        {
            result = 0;
        }
        [Test]
    [TestCase(20,25,45)]
        public void calculatorAddMethod(int x,int y,int z)
        {
            calculator add = new calculator();
            result = add.Add(x, y);
            Assert.AreEqual(z, result);
        }
        [TearDown]
        public void CleanUpMethod()
        {
            result = 0;
        }
    }
}
