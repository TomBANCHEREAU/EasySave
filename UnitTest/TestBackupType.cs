using EasySave.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace UnitTest 
{
    [TestClass]
    public class TestBackupType
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
            Backup fullBackup = new Backup(backupEnvironment, new FullBackupStrategy());
            model.RunBackup(fullBackup);
            File.Delete(file);
            Assert.IsTrue(File.Exists(Path.Join(fullBackup.DestinationDirectory,"text.txt")));
            model.RestoreBackup(fullBackup);
            Assert.AreEqual(text, File.ReadAllText(file));
        }
        [TestMethod]
        public void DifferentialBackup()
        {
            string text = "First Text";
            string file = Path.Join(SOURCE_DIRECTORY, "text.txt");
            File.WriteAllText(file, text);
            Backup fullBackup = new Backup(backupEnvironment, new FullBackupStrategy());
            model.RunBackup(fullBackup);
            string text2 = "second Text";
            string file2 = Path.Join(SOURCE_DIRECTORY, "text2.txt");
            File.WriteAllText(file2, text2);
            Backup differentialBackup = new Backup(backupEnvironment, new DifferentialBackupStrategy(fullBackup));
            model.RunBackup(differentialBackup);
            File.Delete(file);
            File.Delete(file2);
            model.RestoreBackup(differentialBackup);
            Assert.AreEqual(text, File.ReadAllText(file));
            Assert.AreEqual(text2, File.ReadAllText(file2));
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

