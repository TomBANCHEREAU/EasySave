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
        [TestMethod]
        public new void FileEdited()
        {
            string text = "First Text";
            string text2 = "First Text 2";
            string file = Path.Join(SOURCE_DIRECTORY, "text.txt");
            File.WriteAllText(file, text);
            Backup fullBackup = new Backup(backupEnvironment, new FullBackupStrategy());
            model.RunBackup(fullBackup);
            File.WriteAllText(file, text2);
            Backup differentialBackup = new Backup(backupEnvironment, new DifferentialBackupStrategy(fullBackup));
            model.RunBackup(differentialBackup);
            Assert.IsTrue(File.Exists(Path.Join(differentialBackup.DestinationDirectory, "text.txt")));
            Assert.AreEqual(text2.Length, File.ReadAllText(Path.Join(differentialBackup.DestinationDirectory, "text.txt")).Length);
        }
        [TestMethod]
        public new void FileAdded()
        {
            Backup fullBackup = new Backup(backupEnvironment, new FullBackupStrategy());
            model.RunBackup(fullBackup);
            string text = "First Text";
            string file = Path.Join(SOURCE_DIRECTORY, "text.txt");
            File.WriteAllText(file, text);
            Backup differentialBackup = new Backup(backupEnvironment, new DifferentialBackupStrategy(fullBackup));
            model.RunBackup(differentialBackup);
            Assert.IsTrue(File.Exists(Path.Join(differentialBackup.DestinationDirectory, "text.txt")));
            Assert.AreEqual(text.Length, File.ReadAllText(Path.Join(differentialBackup.DestinationDirectory, "text.txt")).Length);
        }

        [TestCleanup]
        public new void Cleanup()
        {
            base.Cleanup();
        }
    }
}
