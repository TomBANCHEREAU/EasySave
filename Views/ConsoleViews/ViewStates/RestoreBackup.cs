using EasySave.Controllers;
using EasySave.Languages;
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
                Console.WriteLine(Language.GetText("RestoreBackup-NoBackupAvailable"));
                Console.WriteLine("");
                return new MainMenu();
            }

            while (true)
            {
                // Listing all backup environments
                Console.WriteLine(Language.GetText("RestoreBackup-SelectBackupEnvironment"));
                Console.WriteLine(Language.GetText("RestoreBackup-ReturnMenu"));
                for (int i = 1; backupEnvironmentList.Count >= i; i++)
                {
                    Console.WriteLine(i + ". " + backupEnvironmentList[i - 1].Name);
                }

                // User chooses an environment
                Console.WriteLine("");
                string strChoice = Console.ReadLine();
                Console.Clear();
                int choiceEnvironment;

                // Verification
                if (int.TryParse(strChoice, out choiceEnvironment))
                {
                    // Exit
                    if (choiceEnvironment == 0)
                    {
                        Console.Clear();
                        return new MainMenu();
                    }

                    // An environment is selected
                    if (choiceEnvironment > 0 && choiceEnvironment <= backupEnvironmentList.Count)
                    {
                        // Display all backups
                        Console.WriteLine(Language.GetText("RestoreBackup-SelectBackup"));
                        Console.WriteLine(Language.GetText("RestoreBackup-ReturnMenu"));
                        for (int i = 1; backupEnvironmentList[choiceEnvironment - 1].Backups.Count >= i; i++)
                        {
                            Console.WriteLine(i + ". " + backupEnvironmentList[choiceEnvironment - 1].Backups[i - 1].ExecutionDate + "\t| " + backupEnvironmentList[choiceEnvironment - 1].Backups[i - 1].BackupStrategy.Name);
                        }

                        // User chooses a backup
                        Console.WriteLine("");
                        strChoice = Console.ReadLine();
                        int choiceBackup;

                        // Verification
                        if (int.TryParse(strChoice, out choiceBackup))
                        {
                            // Exit
                            if (choiceBackup == 0)
                            {
                                Console.Clear();
                                return new MainMenu();
                            }

                            // If there is no backup
                            if (backupEnvironmentList[choiceEnvironment - 1].Backups.Count == 0)
                            {
                                Console.WriteLine(Language.GetText("RestoreBackup-Error-NoBackupEnvironment"));
                                Console.WriteLine("");
                                Console.WriteLine(Language.GetText("RestoreBackup-EnterContinue"));
                                Console.ReadLine();
                                Console.Clear();
                                return new MainMenu();
                            }

                            // A backup is selected
                            if (choiceBackup > 0 && choiceBackup <= backupEnvironmentList[choiceEnvironment - 1].Backups.Count)
                            {
                                controller.RestoreBackup(backupEnvironmentList[choiceEnvironment - 1].Backups[choiceBackup - 1]);

                                Console.Clear();
                                Console.WriteLine(Language.GetText("RestoreBackup-RestoreDone"));
                                Console.WriteLine("");
                                return new MainMenu();
                            }
                        }
                        Console.Clear();
                    }
                }
            }
        }
    }
}
