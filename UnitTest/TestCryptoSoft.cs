using EasySave.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;
using System.IO;

namespace UnitTest
{
    [TestClass]
    public class TestCryptoSoft
    {
        [TestInitialize]
        public void Initialize()
        {
            File.WriteAllText(@"key.txt", "azertyuiop");
        }
        [TestMethod]
        public void FileEncryptionExe()
        {
            File.WriteAllText(@"src.txt","Lorem ipsum");
            ProcessStartInfo cryptoSoftInfo = new ProcessStartInfo("CryptoSoft.exe");
            cryptoSoftInfo.UseShellExecute = true;
            cryptoSoftInfo.ArgumentList.Add(new FileInfo(@"src.txt").FullName);
            cryptoSoftInfo.ArgumentList.Add(new FileInfo(@"dst.txt").FullName);
            Process cryptoSoft = Process.Start(cryptoSoftInfo);
            cryptoSoft.WaitForExit();
            Assert.IsTrue(cryptoSoft.ExitCode>=0);
            //Process  = Process.Start();
        }
        [TestMethod]
        public void FileEncryptionMain()
        {
            File.WriteAllText(@"src.txt", "Lorem ipsum");
            int exitCode = CryptoSoft.Program.Main(new string[2] { @"src.txt", @"dst.txt" });
            Assert.IsTrue(exitCode >= 0);
        }
        [TestCleanup]
        public void Cleanup()
        {
            File.Delete(@"key.txt");
        }
    }
}
