using Moq;
using NUnit.Framework;
using System.Collections.Generic;

namespace MagicFilesLib.Tests
{
    [TestFixture]
    public class MagicFilesLibTests
    {
        private readonly string _file1 = "file1.txt";
        private readonly string _file2 = "file2.txt";
        private Mock<IDirectoryExplorer> _mockDirectoryExplorer;
        [OneTimeSetUp]
        public void Initialize()
        {
            _mockDirectoryExplorer = new Mock<IDirectoryExplorer>();
        }
        [Test]
        [TestCase("/home")]
        public void GetFiles_ValidPath_ExpectedFiles(string path)
        {
            List<string> files = new List<string>()
            {
                _file1,_file2
            };
            _mockDirectoryExplorer.Setup(p => p.GetFiles(path)).Returns(files);
            var result = _mockDirectoryExplorer.Object.GetFiles(path);
            Assert.IsNotNull(result);
            Assert.AreEqual(2, result.Count);
            Assert.IsTrue(result.Contains(_file1));
        }
    }
}
