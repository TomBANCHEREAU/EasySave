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
                Console.WriteLine("There is no backup environment available");
                Console.WriteLine("");
                return new MainMenu();
            }

            while (true)
            {
                // Listing all the backup environments
                Console.WriteLine("Select the backup environment you wish to delete:");
                Console.WriteLine("0. Return to menu");
                for (int i = 1; backupEnvironmentList.Count >= i; i++)
                {
                    Console.WriteLine(i + ". " + backupEnvironmentList[i - 1].Name);
                }

                Console.WriteLine("");
                string strChoice = Console.ReadLine();
                int choice;

                if (int.TryParse(strChoice, out choice))
                {
                    if (choice == 0)
                    {
                        Console.Clear();
                        return new MainMenu();
                    }

                    if (choice > 0 && choice <= backupEnvironmentList.Count)
                    {
                        controller.DeleteBackupEnvironment(backupEnvironmentList[choice - 1]);

                        Console.Clear();
                        Console.WriteLine("The backup environment selected has been deleted");
                        Console.WriteLine("");
                        return new MainMenu();
                    }
                    Console.Clear();
                }
            }
        }
    }
}
