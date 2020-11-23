using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace EasySave.Models
{
    class FullBackupStrategy : IBackupStrategy
    {
        public string Name => "Full";
        public void Execute(Backup backup)
        {
            Directory.CreateDirectory(backup.DestinationDirectory);
            copyContent(backup,backup.BackupEnvironment.SourceDirectory, backup.DestinationDirectory);
        }

        public void Restore(Backup backup)
        {
            copyContent(backup,backup.DestinationDirectory, backup.BackupEnvironment.SourceDirectory);
        }
        private void copyContent(Backup backup,String srcBasePath, String destBasePath,String pathFromBase = "")
        {
            String srcPath = Path.Join(srcBasePath,pathFromBase);
            String destPath = Path.Join(destBasePath, pathFromBase);
            
            foreach (String filePath in Directory.EnumerateFiles(srcPath))
            {
                String fileName = Path.GetFileName(filePath);
                long msbefore = DateTimeOffset.Now.ToUnixTimeMilliseconds();
                File.Copy(Path.Join(srcPath, fileName), Path.Join(destPath, fileName), true);
                Logger.Log(backup.BackupEnvironment.Name, Path.Join(srcPath, fileName), Path.Join(destPath, fileName), new FileInfo(Path.Join(srcPath, fileName)).Length, DateTimeOffset.Now.ToUnixTimeMilliseconds() - msbefore);

            }
            foreach (String dirPath in Directory.EnumerateDirectories(srcPath))
            {
                String dirName = Path.GetFileName(dirPath);
                Directory.CreateDirectory(Path.Join(destPath, dirName));
                copyContent(backup,srcBasePath, destBasePath, Path.Join(pathFromBase, dirName));
            }
        }
    }
}
