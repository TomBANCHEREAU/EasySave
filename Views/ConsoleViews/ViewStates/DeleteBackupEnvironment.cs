using EasySave.Controllers;
using EasySave.Languages;
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
                Console.WriteLine(Language.GetText("DeleteBackup-Error-Available Environment"));
                Console.WriteLine("");
                return new MainMenu();
            }

            while (true)
            {
                // Listing all backup environments
                Console.WriteLine(Language.GetText("DeleteBackup-WishBackup"));
                Console.WriteLine(Language.GetText("DeleteBackup-ReturnMenu"));
                for (int i = 1; backupEnvironmentList.Count >= i; i++)
                {
                    Console.WriteLine(i + ". " + backupEnvironmentList[i - 1].Name);
                }

                // User chooses an environment
                Console.WriteLine("");
                string strChoice = Console.ReadLine();
                int choice;

                // Verification
                if (int.TryParse(strChoice, out choice))
                {
                    // Exit
                    if (choice == 0)
                    {
                        Console.Clear();
                        return new MainMenu();
                    }

                    // An environment is selected
                    if (choice > 0 && choice <= backupEnvironmentList.Count)
                    {
                        Console.WriteLine(Language.GetText("DeleteBackup-Question") +"\"" + backupEnvironmentList[choice - 1].Name + "\"");
                        Console.WriteLine(Language.GetText("DeleteBackup-Yes"));
                        Console.WriteLine(Language.GetText("DeleteBackup-No"));
                        int confirm;
                        if (int.TryParse(Console.ReadLine(),out confirm) && confirm==0)
                        {

                            controller.DeleteBackupEnvironment(backupEnvironmentList[choice - 1]);

                            Console.Clear();
                            Console.WriteLine(Language.GetText("DeleteBackup-DeleteBackup"));
                        }
                        Console.Clear();
                        Console.WriteLine(Language.GetText("DeleteBackup-CancelDeletion"));
                        Console.WriteLine("");
                        return new MainMenu();
                    }
                    Console.Clear();
                }
            }
        }
    }
}
