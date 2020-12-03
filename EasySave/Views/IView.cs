using EasySave.Controllers;
using EasySave.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace EasySave.Views
{
    public interface IView
    {
        public void Start(IReadOnlyModel model,IController controller);
    }
}
