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
            model.SetBlockingProcesses(new string[0]);
            model.SetCryptedExtensions(new string[0]);
        }
        [TestMethod]
        public void NoChange()
        {
            string text = "First Text";
            string file = Path.Join(SOURCE_DIRECTORY, "text.txt");
            File.WriteAllText(file, text);
            model.RunBackup(backupEnvironment,BackupType.FULL).Wait();
            Backup differentialBackup = model.RunBackup(backupEnvironment, BackupType.DIFFERENTIAL).Result;
            Assert.IsFalse(File.Exists(Path.Join(differentialBackup.DestinationDirectory, "text.txt")));

            File.Delete(file);
            model.RestoreBackup(differentialBackup).Wait();
            Assert.AreEqual(text, File.ReadAllText(file));


        }
        [TestMethod]
        public void FileEdited()
        {
            string text = "First Text";
            string text2 = "First Text 2";
            string file = Path.Join(SOURCE_DIRECTORY, "text.txt");
            File.WriteAllText(file, text);
            model.RunBackup(backupEnvironment,BackupType.FULL).Wait();
            File.WriteAllText(file, text2);
            Backup differentialBackup = model.RunBackup(backupEnvironment,BackupType.DIFFERENTIAL).Result;
            Assert.IsTrue(File.Exists(Path.Join(differentialBackup.DestinationDirectory, "text.txt")));

            File.Delete(file);
            model.RestoreBackup(differentialBackup).Wait();
            Assert.AreEqual(text2, File.ReadAllText(file));
        }
        [TestMethod]
        public void FileAdded()
        {
            model.RunBackup(backupEnvironment,BackupType.FULL).Wait();
            string text = "First Text";
            string file = Path.Join(SOURCE_DIRECTORY, "text.txt");
            File.WriteAllText(file, text);
            Backup differentialBackup = model.RunBackup(backupEnvironment,BackupType.DIFFERENTIAL).Result;
            Assert.IsTrue(File.Exists(Path.Join(differentialBackup.DestinationDirectory, "text.txt")));

            File.Delete(file);
            model.RestoreBackup(differentialBackup).Wait();
            Assert.AreEqual(text, File.ReadAllText(file));
        }
        [TestMethod]
        public void FileDeleted()
        {
            string text = "First Text";
            string file = Path.Join(SOURCE_DIRECTORY, "text.txt");
            File.WriteAllText(file, text);
            model.RunBackup(backupEnvironment,BackupType.FULL).Wait();
            File.Delete(file);
            Backup differentialBackup = model.RunBackup(backupEnvironment,BackupType.DIFFERENTIAL).Result;
            Assert.IsFalse(File.Exists(Path.Join(differentialBackup.DestinationDirectory, "text.txt")));
            Assert.IsTrue(File.ReadAllText(Path.Join(differentialBackup.DestinationDirectory, ".easysave")).Contains("text.txt"));


            File.Delete(file);
            model.RestoreBackup(differentialBackup).Wait();
            Assert.IsFalse(File.Exists(file));
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
