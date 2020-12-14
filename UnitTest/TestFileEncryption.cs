using EasySave.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace UnitTest
{
    [TestClass]
    public class TestFileEncryption
    {
        public const string SOURCE_DIRECTORY = @".\src-test";
        public const string DESTINATION_DIRECTORY = @".\dest-test";
        public Model model;
        public BackupEnvironment backupEnvironment;

        [TestInitialize]
        public void Initialize()
        {
            model = new Model();
            Directory.CreateDirectory(SOURCE_DIRECTORY);
            Directory.CreateDirectory(DESTINATION_DIRECTORY);
            model.Start();
            backupEnvironment = new BackupEnvironment("test", SOURCE_DIRECTORY, DESTINATION_DIRECTORY);
            model.AddBackupEnvironment(backupEnvironment);
            model.SetCryptedExtensions(new string[1] { ".txt" });
            File.WriteAllText("key.txt","azertyuiop");
        }
        [TestMethod]
        public void Encryption()
        {
            string text = "First Text";
            string file = Path.Join(SOURCE_DIRECTORY, "text.txt");
            File.WriteAllText(file, text);
            Backup fullBackup = model.RunBackup(backupEnvironment,BackupType.FULL);
            File.Delete(file);
            Assert.AreNotEqual(text,File.ReadAllText(Path.Join(fullBackup.DestinationDirectory, "text.txt")));
            Assert.AreEqual(text.Length,File.ReadAllText(Path.Join(fullBackup.DestinationDirectory, "text.txt")).Length);
            model.RestoreBackup(fullBackup);
            Assert.AreEqual(text, File.ReadAllText(file));
        }
        [TestCleanup]
        public void Cleanup()
        {
            Directory.Delete(SOURCE_DIRECTORY, true);
            Directory.Delete(DESTINATION_DIRECTORY, true);
            File.Delete(@"settings.json");
        }
    }
}
