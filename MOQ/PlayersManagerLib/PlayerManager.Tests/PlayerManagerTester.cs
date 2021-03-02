using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using NUnit.Framework;
using PlayersManagerLib;

namespace PlayerManager.Tests
{
    [TestFixture]
    public class PlayerManagerTester
    {
        Mock<IPlayerMapper> mock;
        [OneTimeSetUp]
        public void init()
        {
            mock = new Mock<IPlayerMapper>();
        }
        [Test]
        [ExpectedException(typeof(ArgumentException))]
        [TestCase("")]
        public void EmptyName(string name)
        {
            Player player = Player.RegisterNewPlayer(name, mock.Object);
        }
        [Test]
        [ExpectedException(typeof(ArgumentException))]
        [TestCase("Shri")]
        public void AlreadyInDb(string name)
        {
            mock.Setup(x => x.IsPlayerNameExistsInDb(name)).Returns(true);
            Player player = Player.RegisterNewPlayer(name, mock.Object);
        }
        [Test]
        [TestCase("Test","India")]
        public void NotInDb(string name,string country)
        {
            mock.Setup(x => x.IsPlayerNameExistsInDb(name)).Returns(false);
            Player player = Player.RegisterNewPlayer(name, mock.Object);
            Assert.AreEqual(name,player.Name);
            Assert.AreEqual(23,player.Age);
            Assert.AreEqual(country,player.Country);
            Assert.AreEqual(30,player.NoOfMatches);
        }

    }
}
