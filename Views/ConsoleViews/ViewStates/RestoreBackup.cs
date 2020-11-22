using EasySave.Controllers;
using EasySave.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace EasySave.Views.ConsoleViews.ViewStates
{
    class RestoreBackup : IViewState
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
                Console.WriteLine("Select the backup environment you wish to use:");
                Console.WriteLine("0. Return to menu");
                for (int i = 1; backupEnvironmentList.Count >= i; i++)
                {
                    Console.WriteLine(i + ". " + backupEnvironmentList[i - 1].Name);
                }

                Console.WriteLine("");
                string strChoice = Console.ReadLine();
                Console.Clear();
                int choiceEnvironment;

                if (int.TryParse(strChoice, out choiceEnvironment))
                {
                    if (choiceEnvironment == 0)
                    {
                        Console.Clear();
                        return new MainMenu();
                    }

                    if (choiceEnvironment > 0 && choiceEnvironment <= backupEnvironmentList.Count)
                    {
                        Console.WriteLine("Which backup would you like to run:");
                        Console.WriteLine("");
                        for (int i = 1; backupEnvironmentList[choiceEnvironment - 1].Backups.Count >= i; i++)
                        {
                            // Console.WriteLine(i + ". " + backupEnvironmentList[choiceEnvironment - 1].Backups[i - 1].ExecutionDate);
                            // Add Backup's type
                        }

                        Console.WriteLine("");
                        strChoice = Console.ReadLine();
                        int choiceBackup;

                        if (int.TryParse(strChoice, out choiceBackup))
                        {
                            if (choiceBackup == 0)
                            {
                                Console.Clear();
                                return new MainMenu();
                            }

                            if (backupEnvironmentList[choiceEnvironment - 1].Backups.Count == 0)
                            {
                                Console.WriteLine("There is no backup available in this environment");
                                Console.WriteLine("");
                                Console.WriteLine("Press enter to continue...");
                                Console.ReadLine();
                                Console.Clear();
                                return new MainMenu();
                            }

                            if (choiceBackup > 0 && choiceBackup <= backupEnvironmentList[choiceEnvironment - 1].Backups.Count)
                            {
                                controller.RestoreBackup(backupEnvironmentList[choiceEnvironment - 1].Backups[choiceBackup - 1]);
                            }
                        }
                        Console.Clear();
                    }
                }
            }
        }
    }
}
