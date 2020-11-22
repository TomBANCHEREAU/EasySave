using EasySave.Controllers;
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
                Console.WriteLine("There is no backup environment available");
                Console.WriteLine("");
                return new MainMenu();
            }

            // Listing all backup environments
            Console.WriteLine("Actual backup environment(s) list:");
            for (int i = 1; backupEnvironmentList.Count >= i; i++)
            {
               Console.WriteLine(i + ". " + backupEnvironmentList[i - 1].Name);
            }

            // Exit
            Console.WriteLine("");
            Console.WriteLine("Press enter to continue...");
            Console.ReadLine();
            Console.Clear();
            return new MainMenu();
        }
    }
}
