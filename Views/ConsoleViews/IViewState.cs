using System;
using System.Collections.Generic;
using System.Text;

namespace EasySave.Views.ConsoleViews
{
    interface IViewState
    {
        public IViewState Execute(ConsoleView consoleView);
    }
}
