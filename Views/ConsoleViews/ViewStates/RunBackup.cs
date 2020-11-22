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
                        Console.WriteLine("Which type of backup would you like to run:");
                        Console.WriteLine("");
                        Console.WriteLine("0. Return to menu");
                        Console.WriteLine("1. Run a full backup");
                        Console.WriteLine("2. Run a differential backup");

                        Console.WriteLine("");
                        strChoice = Console.ReadLine();
                        int choiceBackup;

                        if (int.TryParse(strChoice, out choiceBackup))
                        {
                            switch (choiceBackup)
                            {
                                case 0:
                                    Console.Clear();
                                    return new MainMenu();
                                case 1:
                                    controller.RunBackup(new Backup(backupEnvironmentList[choiceBackup - 1], new FullBackupStrategy()));
                                    Console.Clear();
                                    Console.WriteLine("The full backup has been effectued");
                                    Console.WriteLine("");
                                    return new MainMenu();
                                case 2:
                                    if (backupEnvironmentList[choiceEnvironment - 1].FullBackups.Count > 0)
                                    {
                                        /*
                                        controller.RunBackup(new Backup(backupEnvironmentList[choiceBackup - 1], new DifferentialBackupStrategy()));
                                        Console.Clear();
                                        Console.WriteLine("The differential backup has been effectued");
                                        Console.WriteLine("");
                                        return new MainMenu();
                                        */ 
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
