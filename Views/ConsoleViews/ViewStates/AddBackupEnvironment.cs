﻿using EasySave.Controllers;
using EasySave.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace EasySave.Views.ConsoleViews.ViewStates
{
    class AddBackupEnvironment : IViewState
    {
        public IViewState Execute(IReadOnlyModel model, IController controller)
        {
            Console.Clear();
            BackupEnvironment backupEnvironment = new BackupEnvironment();
            while (true) // Name
            {
                try
                {
                    Console.Write("Name :");
                    backupEnvironment.Name = Console.ReadLine();
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
            while (true) // Source Directory
            {
                try
                {
                    Console.Write("Source directory :");
                    backupEnvironment.SourceDirectory = Console.ReadLine();
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
            while (true) // Destination Directory
            {
                try
                {
                    Console.Write("Destination directory :");
                    backupEnvironment.DestinationDirectory = Console.ReadLine();
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
            controller.AddBackupEnvironment(backupEnvironment);
            return new MainMenu();
        }
    }
}

