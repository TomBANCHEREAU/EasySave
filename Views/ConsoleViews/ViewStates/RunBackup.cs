using EasySave.Controllers;
using EasySave.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace EasySave.Views.ConsoleViews.ViewStates
{
    class RunBackup : IViewState
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
                // Listing all backup environments
                Console.WriteLine("Select the backup environment you wish to use:");
                Console.WriteLine("0. Return to menu");
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

                    // Display all backup's types
                    if (choiceEnvironment > 0 && choiceEnvironment <= backupEnvironmentList.Count)
                    {
                        Console.WriteLine("Which type of backup would you like to run:");
                        Console.WriteLine("0. Return to menu");
                        Console.WriteLine("1. Run a full backup");
                        Console.WriteLine("2. Run a differential backup");

                        // User chooses a backup's type
                        Console.WriteLine("");
                        strChoice = Console.ReadLine();
                        int choiceBackup;

                        // Verification
                        if (int.TryParse(strChoice, out choiceBackup))
                        {
                            switch (choiceBackup)
                            {
                                // Exit
                                case 0: 
                                    Console.Clear();
                                    return new MainMenu();

                                // Run a full backup
                                case 1: 
                                    controller.RunBackup(new Backup(backupEnvironmentList[choiceBackup - 1], new FullBackupStrategy()));
                                    
                                    Console.Clear();
                                    Console.WriteLine("The full backup has been done");
                                    Console.WriteLine("");
                                    return new MainMenu();

                                // Run a differential backup
                                case 2:
                                    if (backupEnvironmentList[choiceEnvironment - 1].FullBackups.Count > 0)
                                    {
                                        controller.RunBackup(new Backup(backupEnvironmentList[choiceBackup - 1], new DifferentialBackupStrategy(backupEnvironmentList[choiceEnvironment - 1].FullBackups[backupEnvironmentList[choiceEnvironment - 1].FullBackups.Count - 1])));
                                        
                                        Console.Clear();
                                        Console.WriteLine("The differential backup has been done");
                                        Console.WriteLine("");
                                        return new MainMenu();
                                    }
                                    Console.Clear();
                                    Console.WriteLine("No full backup has been done");
                                    Console.WriteLine("");
                                    return new MainMenu();
                                default:
                                    break;
                            }
                        }
                        Console.Clear();
                    }
                }
            }
        }
    }
}
