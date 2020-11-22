using System;
using System.Collections.Generic;
using System.Text;

namespace EasySave.Models
{
    class FullBackupStrategy : IBackupStrategy
    {
        public void Execute(Backup backup)
        {
            throw new NotImplementedException();
        }

        public void Restore(Backup backup)
        {
            throw new NotImplementedException();
        }
    }
}
