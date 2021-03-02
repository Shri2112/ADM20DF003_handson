using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using NUnit.Framework;
using MagicFilesLib;

namespace DirectoryExplorer.Tests
{
    [TestFixture]
    public class DirectoryExplorerTest
    {
        private readonly string _file1 = "file.txt";

        private readonly string _file2 = "file2.txt";
        private Mock<IDirectoryExplorer> _mockDirectoryExplorer;
        [OneTimeSetUp]
        public void Initial()
        {
            _mockDirectoryExplorer = new Mock<IDirectoryExplorer>();
        }
        [Test]
        [TestCase("/Home/890806")]

        public void GetFiles_ValidPath_ReturnFiles(string path)
        {
            List<string> files = new List<string>() { _file1, _file2 };
            _mockDirectoryExplorer.Setup(p => p.GetFiles(path)).Returns(files);
            var result = _mockDirectoryExplorer.Object.GetFiles(path);
            Assert.IsNotNull(result);
            Assert.AreEqual(2,result.Count);
            Assert.IsTrue(result.Contains(_file1));
        }
    }
}
