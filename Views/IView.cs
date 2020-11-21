using EasySave.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace EasySave.Views
{
    interface IView
    {
        public void SetModel(IReadOnlyModel model);
        public void Start();
    }
}
