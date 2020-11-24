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
        private void copyContent(Backup backup,String srcBasePath, String destBasePath)
        {
            String[] sourceFiles = Directory.GetFiles(srcBasePath, "*", new EnumerationOptions() { RecurseSubdirectories = true });
            long size = 0;
            foreach (String srcFile in sourceFiles)
            {
                size += new FileInfo(srcFile).Length;
            }
            long currentSize = 0;
            for (int i = 0; i < sourceFiles.Length; i++)
            {
                String srcFile = sourceFiles[i];

                currentSize += new FileInfo(srcFile).Length;
                String filePathFromBase = Path.GetRelativePath(srcBasePath, srcFile);


                State.SetState(new State.StateStatus()
                {
                    Name = backup.BackupEnvironment.Name,
                    Running = true,
                    Status = new State.Status()
                    {
                        FileNumber = sourceFiles.Length,
                        FileSize = size,
                        Progression = (float)((float)i / sourceFiles.Length * 100.0),
                        FileLeft = sourceFiles.Length - i,
                        SizeLeft = size - currentSize,
                        CurrentSourceFile = srcFile,
                        DestinationFile = Path.Join(destBasePath, filePathFromBase)
                    }
                });

                long msbefore = DateTimeOffset.Now.ToUnixTimeMilliseconds();
                try
                {
                    Directory.CreateDirectory(Path.GetDirectoryName(Path.Join(destBasePath, filePathFromBase)));
                    File.Copy(Path.Join(srcBasePath, filePathFromBase), Path.Join(destBasePath, filePathFromBase), true);
                }
                catch (Exception ex)
                {
                    msbefore = -1;
                }
                Logger.Log(backup.BackupEnvironment.Name, Path.Join(srcBasePath, filePathFromBase), Path.Join(destBasePath, filePathFromBase), new FileInfo(Path.Join(srcBasePath, filePathFromBase)).Length, 
                    msbefore==-1?-1:DateTimeOffset.Now.ToUnixTimeMilliseconds() - msbefore);

            }
        }
    }
}
