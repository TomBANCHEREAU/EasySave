using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace EasySave.Models
{
    class FullBackupStrategy : IBackupStrategy
    {
        public void Execute(Backup backup)
        {
            copyContent(backup.BackupEnvironment.SourceDirectory, backup.BackupEnvironment.DestinationDirectory);
        }

        public void Restore(Backup backup)
        {
            copyContent(backup.BackupEnvironment.DestinationDirectory, backup.BackupEnvironment.SourceDirectory);
        }
        private void copyContent(String srcBasePath, String destBasePath,String pathFromBase = "")
        {
            String srcPath = Path.Join(srcBasePath,pathFromBase);
            String destPath = Path.Join(destBasePath, pathFromBase);
            
            foreach (String filePath in Directory.EnumerateFiles(srcPath))
            {
                String fileName = Path.GetFileName(filePath);
                File.Copy(Path.Join(srcPath, fileName), Path.Join(destPath, fileName),true);
            }
            foreach (String dirPath in Directory.EnumerateDirectories(srcPath))
            {
                String dirName = Path.GetFileName(dirPath);
                Directory.CreateDirectory(Path.Join(destPath, dirName));
                copyContent(srcBasePath, destBasePath, Path.Join(pathFromBase, dirName));
            }
        }
    }
}
