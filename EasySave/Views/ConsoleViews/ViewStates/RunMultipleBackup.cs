using EasySave.Controllers;
using EasySave.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace EasySave.Views.ConsoleViews.ViewStates
{
    class RunMultipleBackup : IViewState
    {
        public IViewState Execute(IReadOnlyModel model, IController controller)
        {
            IReadOnlyList<BackupEnvironment> backupEnvironments = model.GetBackupEnvironments();
            List<Backup> toExecute = new List<Backup>();

            if (backupEnvironments.Count == 0)
            {
                Console.Clear();
                Console.WriteLine("There is no backup environment available");
                Console.WriteLine("");
                return new MainMenu();
            }

            foreach (BackupEnvironment backupEnvironment in backupEnvironments)
            {
                Console.Clear();
                while (true)
                {
                    Console.WriteLine("Choose a backup type for the environment : " + backupEnvironment.Name);
                    Console.WriteLine("0. Do not run a backup on this environment");
                    Console.WriteLine("1. Run a full backup");
                    Console.WriteLine("2. Run a differential backup");
                    Console.WriteLine("");
                    int choice;
                    String strchoice = Console.ReadLine();
                    Console.Clear();
                    if (int.TryParse(strchoice, out choice) && choice >=0 && choice <=2)
                    {
                        if (choice == 1)
                        {
                            throw new Exception("");
                            //toExecute.Add(new Backup(backupEnvironment, new FullBackup())); 
                            //break;
                        }
                        else if (choice == 2)
                        {
                            if (backupEnvironment.FullBackups.Count > 0)
                            {
                                //toExecute.Add(new Backup(backupEnvironment, new DifferentialBackupStrategy(backupEnvironment.FullBackups[backupEnvironment.FullBackups.Count-1])));
                                break;
                            }
                            else
                                Console.WriteLine("You can't execute a differential backup because no full backup has been done before");
                        } 
                        else
                        {
                            break;
                        }
                    }
                }
            }

            foreach (Backup backup in toExecute)
            {
                throw new Exception();
                //controller.RunBackup(backup);
            }
            return new MainMenu();
        }
    }
}
