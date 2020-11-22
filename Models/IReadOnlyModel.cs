using System;
using System.Collections.Generic;
using System.Text;

namespace EasySave.Models
{
    public interface IReadOnlyModel
    {
        public IReadOnlyList<Object> GetBackupEnvironments();
    }
}
