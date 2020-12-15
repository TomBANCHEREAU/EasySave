using EasySave.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace UnitTest 
{
    [TestClass]
    public class TestFullBackup
    {
        private const string SOURCE_DIRECTORY = @".\src-test";
        private const string DESTINATION_DIRECTORY = @".\dest-test";
        private Model model;
        private BackupEnvironment backupEnvironment;

        [TestInitialize]
        public void Initialize()
        {
            model = new Model();
            Directory.CreateDirectory(SOURCE_DIRECTORY);
            Directory.CreateDirectory(DESTINATION_DIRECTORY);
            model.Start();
            backupEnvironment = new BackupEnvironment("test", SOURCE_DIRECTORY, DESTINATION_DIRECTORY);
            model.AddBackupEnvironment(backupEnvironment);
        }
        [TestMethod]
        public void FullBackup()
        {
            string text = "First Text";
            string file = Path.Join(SOURCE_DIRECTORY, "text.txt");
            File.WriteAllText(file, text);
            Backup fullBackup =  model.RunBackup(backupEnvironment,BackupType.FULL).Result;
            File.Delete(file);
            Assert.IsTrue(File.Exists(Path.Join(fullBackup.DestinationDirectory,"text.txt")));
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

