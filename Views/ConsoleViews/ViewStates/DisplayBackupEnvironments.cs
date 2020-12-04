using EasySave.Controllers;
using EasySave.Languages;
using EasySave.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace EasySave.Views.ConsoleViews.ViewStates
{
    class DisplayBackupEnvironments : IViewState
    {
        public IViewState Execute(IReadOnlyModel model, IController controller)
        {
            Console.Clear();
            IReadOnlyList<BackupEnvironment> backupEnvironmentList = model.GetBackupEnvironments();

            // There is no backup environment available
            if (backupEnvironmentList.Count == 0)
            {
                Console.WriteLine(Language.GetText("DisplayBackupEnvironment-NoBackupAvailable"));
                Console.WriteLine("");
                return new MainMenu();
            }

            // Listing all backup environments
            Console.WriteLine(Language.GetText("DisplayBackupEnvironment-DisplayList"));
            for (int i = 1; backupEnvironmentList.Count >= i; i++)
            {
               Console.WriteLine(i + ". " + backupEnvironmentList[i - 1].Name);
            }

            // Exit
            Console.WriteLine("");
            Console.WriteLine(Language.GetText("DisplayBackupEnvironment-EnterContinue"));
            Console.ReadLine();
            Console.Clear();
            return new MainMenu();
        }
    }
}
