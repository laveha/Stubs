using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Stubs.Tests
{
    [TestClass]
    public class FileManagerTests
    {
        [TestMethod]
        public void FindLogFile_FileSize_FileName()
        {
            FileManager fileManager = new FileManager();
            long fileSize = 184;
            string actual = fileManager.FindLogFile(fileSize);
            Assert.IsNotNull(actual, "Файл с заданным размером не найден.");
        }
    }
}
