using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Threading;

namespace EasySave.Models
{
    public class FileTransferEvent
    {
        private static Mutex bigFile = new Mutex();
        private Boolean done = false;
        private long transferTime;
        private long encryptionTime;
        private DateTime transferDate;


        public readonly Backup Backup;
        public readonly FileInfo SourceFileInfo;
        public readonly FileInfo DestinationFileInfo;
        public DateTime TransferDate { get => transferDate; }
        public Model Model { get => Backup.BackupEnvironment.Model; }
        public long TransferTime { get => transferTime; }
        public long EncryptionTime { get => encryptionTime; }
        public BackupEnvironment BackupEnvironment { get => Backup.BackupEnvironment; }
        public String SourceFile { get => SourceFileInfo.FullName; }
        public String DestinationFile { get => DestinationFileInfo.FullName; }
        public long FileSize { get => SourceFileInfo.Length; }
        public String EnvironmentName { get => BackupEnvironment.Name; }
        public Boolean Encrypted { get => new List<String>(Model.CryptedExtensions).Contains(SourceFileInfo.Extension); }
        public Boolean BigFile { get => FileSize > Model.KoLimit*1000; }
        public Boolean HighPriority { get => new List<String>(Model.CryptedExtensions).Contains(SourceFileInfo.Extension); }

        internal FileTransferEvent(Backup Backup, FileInfo SourceFileInfo, FileInfo DestinationFileInfo)
        {
            this.Backup = Backup;
            this.SourceFileInfo = SourceFileInfo;
            this.DestinationFileInfo = DestinationFileInfo;
        }

        internal void ExecuteTransfer()
        {
            lock(this){
                if (done) throw new Exception();
                transferDate = DateTime.Now;
                done = true;
            }

            if (BigFile)
                bigFile.WaitOne();

            if (Encrypted)
                encryptionTime = encryptFile();
            else
                transferTime = copyFile();

            if (BigFile)
                bigFile.ReleaseMutex();
        }

        private long copyFile()
        {
            try
            {
                long msbefore = DateTimeOffset.Now.ToUnixTimeMilliseconds();
                Directory.CreateDirectory(Path.GetDirectoryName(DestinationFile));
                File.Copy(SourceFile, DestinationFile, true);
                return DateTimeOffset.Now.ToUnixTimeMilliseconds() - msbefore;
            }
            catch { return -1; }
        }

        private long encryptFile()
        {

            Directory.CreateDirectory(Path.GetDirectoryName(DestinationFile));

            // Setting up the CryptoSoft process
            ProcessStartInfo cryptoSoftInfo = new ProcessStartInfo("CryptoSoft.exe");
            cryptoSoftInfo.UseShellExecute = true;
            cryptoSoftInfo.ArgumentList.Add(SourceFileInfo.FullName);
            cryptoSoftInfo.ArgumentList.Add(DestinationFileInfo.FullName);

            // Starting up the CryptoSoft process
            Process cryptoSoft = Process.Start(cryptoSoftInfo);
            cryptoSoft.WaitForExit();

            return cryptoSoft.ExitCode > 0 ? cryptoSoft.ExitCode : -1;
        }
    }
}
