using System;
using System.Collections.Generic;
using System.Text;

namespace EasySave.Models
{
    public interface IBackupStrategy
    {
        public void Execute(Backup backup);
        public void Restore(Backup backup);
    }
}
