using System;
using System.Collections.Generic;
using System.Text;
using EasySave.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace UnitTest
{

    [TestClass]
    public class TestDifferentialBackup
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
            model.SetBlockingProcesses(new string[0]);
            model.SetCryptedExtensions(new string[0]);
        }
        [TestMethod]
        public void NoChange()
        {
            string text = "First Text";
            string file = Path.Join(SOURCE_DIRECTORY, "text.txt");
            File.WriteAllText(file, text);
            Backup fullBackup = new Backup(backupEnvironment, new FullBackupStrategy());
            model.RunBackup(fullBackup);
            Backup differentialBackup = new Backup(backupEnvironment, new DifferentialBackupStrategy(fullBackup));
            model.RunBackup(differentialBackup);
            Assert.IsFalse(File.Exists(Path.Join(differentialBackup.DestinationDirectory, "text.txt")));
        }
        [TestMethod]
        public void FileEdited()
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
            Assert.AreEqual(text2, File.ReadAllText(Path.Join(differentialBackup.DestinationDirectory, "text.txt")));
        }
        [TestMethod]
        public void FileAdded()
        {
            Backup fullBackup = new Backup(backupEnvironment, new FullBackupStrategy());
            model.RunBackup(fullBackup);
            string text = "First Text";
            string file = Path.Join(SOURCE_DIRECTORY, "text.txt");
            File.WriteAllText(file, text);
            Backup differentialBackup = new Backup(backupEnvironment, new DifferentialBackupStrategy(fullBackup));
            model.RunBackup(differentialBackup);
            Assert.IsTrue(File.Exists(Path.Join(differentialBackup.DestinationDirectory, "text.txt")));
            Assert.AreEqual(text, File.ReadAllText(Path.Join(differentialBackup.DestinationDirectory, "text.txt")));
        }
        [TestMethod]
        public void FileDeleted()
        {
            string text = "First Text";
            string file = Path.Join(SOURCE_DIRECTORY, "text.txt");
            File.WriteAllText(file, text);
            Backup fullBackup = new Backup(backupEnvironment, new FullBackupStrategy());
            model.RunBackup(fullBackup);
            File.Delete(file);
            Backup differentialBackup = new Backup(backupEnvironment, new DifferentialBackupStrategy(fullBackup));
            model.RunBackup(differentialBackup);
            Assert.IsFalse(File.Exists(Path.Join(differentialBackup.DestinationDirectory, "text.txt")));
            Assert.IsTrue(File.ReadAllText(Path.Join(differentialBackup.DestinationDirectory, ".easysave")).Contains("text.txt"));
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
