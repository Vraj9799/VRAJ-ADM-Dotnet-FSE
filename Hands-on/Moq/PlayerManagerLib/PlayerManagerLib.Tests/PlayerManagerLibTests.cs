using Moq;
using NUnit.Framework;
using System;

namespace PlayerManagerLib.Tests
{
    [TestFixture]
    public class PlayerManagerLibTests
    {
        private Mock<IPlayerMapper> _mockPlayerMapper;
        [OneTimeSetUp]
        public void Initialize()
        {
            _mockPlayerMapper = new Mock<IPlayerMapper>();
        }
        [Test]
        [TestCase("Vraj")]
        public void RegisterNewPlayer_Valid_NewPlayer(string name)
        {
            _mockPlayerMapper.Setup(p => p.IsPlayerNameExistsInDb(name)).Returns(false);
            Player player = Player.RegisterNewPlayer(name, _mockPlayerMapper.Object);
            Assert.AreEqual(name, player.Name);
        }
        [Test]
        [TestCase("Vraj")]
        public void RegisterNewPlayer_InValid_Exceptions(string name)
        {
            _mockPlayerMapper.Setup(p => p.IsPlayerNameExistsInDb(name)).Returns(true);
            var result = Assert.Throws<ArgumentException>(() => Player.RegisterNewPlayer(name, _mockPlayerMapper.Object));
            Assert.AreEqual("Player name already exists.", result.Message);
        }
    }
}
