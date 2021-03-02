using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using NUnit.Framework;
using CustomerCommLib;

namespace CustomerComm.Tests
{
    public class Class1
    {
        Mock<IMailSender> mock;
        CustomeComm customer;
        [Test]
        [TestCase("This is address", "This is message", true)]
        [TestCase("This is address of user", "This is message for user", true)]
        [TestCase("This is address of customer", "This is message for customer", true)]
        public void TestModule(string toAddress, string message, bool c)
        {
            mock = new Mock<IMailSender>(MockBehavior.Loose);
            customer = new CustomeComm(mock.Object);
            mock.Setup(p => p.SendMail(toAddress, message)).Returns(c);
            bool res = customer.SendMailToCustomer();
            Assert.AreEqual(c, res);
        }

    }
}
