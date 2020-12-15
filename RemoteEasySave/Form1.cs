﻿using EasySave.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RemoteEasySave
{
    public partial class Form1 : Form
    {
        Client client;
        public Form1()
        {
            InitializeComponent();
        }
        public Form1(Client client) : this()
        {
            this.client = client;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.client.OnStateChange += Client_OnStateChange;
        }

        private void Client_OnStateChange(object sender, List<BackupEnvironment.BackupEnvironmentState> e)
        {
            this.Invoke(new MethodInvoker(()=> {
                listView1.Items.Clear();
                foreach (BackupEnvironment.BackupEnvironmentState item in e)
                {
                    ListViewItem listViewItem = new ListViewItem(new String[3] {
                        item.Name,
                        "-",
                        "-"
                    });
                    listViewItem.UseItemStyleForSubItems = false;
                    Debug.WriteLine(item.Running+" " + item.Status);
                    if (item.Running && item.Status!=null)
                    {
                        switch (item.Status.status)
                        {
                            case Backup.BackupStatus.IDLE:
                                listViewItem.SubItems[1].ForeColor = Color.Black;
                                listViewItem.SubItems[1].Text = "-";
                                break;
                            case Backup.BackupStatus.RUNNING:
                                listViewItem.SubItems[1].ForeColor = Color.Green;
                                listViewItem.SubItems[1].Text = "Running";
                                break;
                            case Backup.BackupStatus.PAUSED:
                                listViewItem.SubItems[1].ForeColor = Color.Orange;
                                listViewItem.SubItems[1].Text = "Paused";
                                break;
                            case Backup.BackupStatus.BLOCKED:
                                listViewItem.SubItems[1].ForeColor = Color.Orange;
                                listViewItem.SubItems[1].Text = "Blocked";
                                break;
                            default:
                                break;
                        }
                        listViewItem.SubItems[2].Text = item.Status.Progression + "%";
                    }
                    listView1.Items.Add(listViewItem);
                }
            }));
        }
    }
}