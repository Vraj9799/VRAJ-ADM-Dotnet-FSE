
using Moq;
using NUnit.Framework;

namespace CustomerCommLib.Tests
{
    [TestFixture]
    public class CustomerCommTests
    {
        private Mock<IMailSender> _mailSender;
        [SetUp]
        public void Initialize()
        {
            _mailSender = new Mock<IMailSender>();
        }
        [Test]
        [TestCase("abc@gmail.com", "Hello")]
        public void SendMailToCustomer_ValidInputs_ExpectedTrue(string toAddress, string msg)
        {
            _mailSender.Setup(p => p.SendMail(toAddress, msg)).Returns(true);
            CustomerComm customerComm = new CustomerComm(_mailSender.Object);
            var result = customerComm.SendMailToCustomer();
            Assert.IsTrue(result);
        }
    }
}
