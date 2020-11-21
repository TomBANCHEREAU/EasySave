using System;
using System.Collections.Generic;
using System.Text;

namespace EasySave.Models
{
    interface IReadOnlyModel
    {
        public IReadOnlyList<Object> GetBackupEnvironments();
    }
}
