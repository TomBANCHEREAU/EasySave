using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace EasySave.Models
{
    class BackupEnvironment
    {
        #region Name
        private String name = "default";
        public String Name
        {
            get { return name; }
            set
            {
                if (value == null || value.Length == 0)
                    throw new ArgumentException("Name cannot be empty");
                name = value;
            }
        }
        #endregion
        #region SourceDirectory
        private String sourceDirectory = @"./files-to-save";
        public String SourceDirectory
        {
            get { return sourceDirectory; }
            set
            {
                if (value.Length == 0)
                    throw new ArgumentException("Source path cannot be empty");
                if (!Directory.Exists(value))
                    throw new ArgumentException("Source directory doesn't exist");
                sourceDirectory = value;
            }
        }
        #endregion
        #region DestinationDirectory
        private String destinationDirectory = @"./files-saved";
        public String DestinationDirectory
        {
            get { return destinationDirectory; }
            set
            {
                if (value.Length == 0)
                    throw new ArgumentException("Destination path cannot be empty");
                if (!Directory.Exists(value))
                    throw new ArgumentException("Destination directory doesn't exist");
                destinationDirectory = value;
            }
        }
        #endregion
        #region Backups
        private List<Backup> backups = new List<Backup>();

        public IReadOnlyList<Backup> Backups
        {
            get { return backups; }
        }
        #endregion
        public BackupEnvironment()
        {

        }
        public BackupEnvironment(String _name,String src,String dest)
        {
            Name = _name;
            SourceDirectory = src;
            DestinationDirectory = dest;
        }


    }
}
