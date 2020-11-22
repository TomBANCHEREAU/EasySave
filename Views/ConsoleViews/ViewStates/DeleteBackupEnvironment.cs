using EasySave.Controllers;
using EasySave.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace EasySave.Views.ConsoleViews.ViewStates
{
    class DeleteBackupEnvironment : IViewState
    {
        public IViewState Execute(IReadOnlyModel model, IController controller)
        {
            Console.Clear();
            IReadOnlyList<BackupEnvironment> backupEnvironmentList = model.GetBackupEnvironments();

            // There is no backup environment available
            if (backupEnvironmentList.Count == 0)
            {
                Console.Write("There is no backup environment available");
                Console.WriteLine("");
                return new MainMenu();
            }

            Console.Write("Select the backup environment you wish to delete:");
            Console.WriteLine("");

            for (int i = 1; backupEnvironmentList.Count >= i; i++)
            {
                Console.WriteLine(i + ". " + backupEnvironmentList[i - 1].Name);
            }

            string strChoice = Console.ReadLine();
            int choice;
            int.TryParse(strChoice, out choice);

            controller.DeleteBackupEnvironment(backupEnvironmentList[choice - 1]);
            return new MainMenu();
        }
    }
}
