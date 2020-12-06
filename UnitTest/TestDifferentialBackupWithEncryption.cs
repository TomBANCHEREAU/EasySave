using EasySave.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace UnitTest
{
    [TestClass]
    public class TestDifferentialBackupWithEncryption : TestDifferentialBackup
    {
        [TestInitialize]
        public new void Initialize()
        {
            base.Initialize();
            model.SetCryptedExtensions(new string[1] { ".txt" });
            File.WriteAllText("key.txt", "azertyuiop");
        }
    }
}
