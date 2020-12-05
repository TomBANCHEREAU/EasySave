
using EasySave.Views.WindowsFormViews.UserControls;

namespace EasySave.Views.WindowsFormViews
{
    partial class MainView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainView));
            this.title = new System.Windows.Forms.Label();
            this.Main = new EasySave.Views.WindowsFormViews.UserControls.Home();
            this.backupEnvironmentForm = new EasySave.Views.WindowsFormViews.UserControls.BackupEnvironmentForm();
            this.runBackup = new EasySave.Views.WindowsFormViews.UserControls.RunBackup();
            this.frenchButton = new System.Windows.Forms.Button();
            this.englishButton = new System.Windows.Forms.Button();
            this.businessSoftwaresSettings = new EasySave.Views.WindowsFormViews.UserControls.BusinessSoftwaresSettings();
            this.extensionsSettings = new EasySave.Views.WindowsFormViews.UserControls.ExtensionsSettings();
            this.restoreBackup = new EasySave.Views.WindowsFormViews.UserControls.RestoreBackup();
            this.runMultipleBackup = new EasySave.Views.WindowsFormViews.UserControls.RunMultipleBackup();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Century", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.title.Location = new System.Drawing.Point(152, 10);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(147, 33);
            this.title.TabIndex = 0;
            this.title.Text = "EasySave";
            this.title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Main
            // 
            this.Main.Location = new System.Drawing.Point(2, 49);
            this.Main.Name = "Main";
            this.Main.Size = new System.Drawing.Size(446, 500);
            this.Main.TabIndex = 1;
            this.Main.Load += new System.EventHandler(this.Main_Load);
            // 
            // backupEnvironmentForm
            // 
            this.backupEnvironmentForm.Location = new System.Drawing.Point(2, 49);
            this.backupEnvironmentForm.Name = "backupEnvironmentForm";
            this.backupEnvironmentForm.Size = new System.Drawing.Size(446, 500);
            this.backupEnvironmentForm.TabIndex = 2;
            // 
            // runBackup
            // 
            this.runBackup.Location = new System.Drawing.Point(2, 49);
            this.runBackup.Name = "runBackup";
            this.runBackup.Size = new System.Drawing.Size(446, 500);
            this.runBackup.TabIndex = 3;
            // 
            // frenchButton
            // 
            this.frenchButton.Image = ((System.Drawing.Image)(resources.GetObject("frenchButton.Image")));
            this.frenchButton.Location = new System.Drawing.Point(396, 9);
            this.frenchButton.Name = "frenchButton";
            this.frenchButton.Size = new System.Drawing.Size(45, 34);
            this.frenchButton.TabIndex = 7;
            this.frenchButton.UseVisualStyleBackColor = true;
            this.frenchButton.Click += new System.EventHandler(this.frenchButton_Click);
            // 
            // englishButton
            // 
            this.englishButton.Image = ((System.Drawing.Image)(resources.GetObject("englishButton.Image")));
            this.englishButton.Location = new System.Drawing.Point(345, 9);
            this.englishButton.Name = "englishButton";
            this.englishButton.Size = new System.Drawing.Size(45, 34);
            this.englishButton.TabIndex = 8;
            this.englishButton.UseVisualStyleBackColor = true;
            this.englishButton.Click += new System.EventHandler(this.englishButton_Click);
            // 
            // businessSoftwaresSettings
            // 
            this.businessSoftwaresSettings.Location = new System.Drawing.Point(2, 49);
            this.businessSoftwaresSettings.Name = "businessSoftwaresSettings";
            this.businessSoftwaresSettings.Size = new System.Drawing.Size(446, 500);
            this.businessSoftwaresSettings.TabIndex = 9;
            // 
            // extensionsSettings
            // 
            this.extensionsSettings.Location = new System.Drawing.Point(2, 49);
            this.extensionsSettings.Name = "extensionsSettings";
            this.extensionsSettings.Size = new System.Drawing.Size(446, 500);
            this.extensionsSettings.TabIndex = 10;
            // 
            // restoreBackup
            // 
            this.restoreBackup.Location = new System.Drawing.Point(2, 49);
            this.restoreBackup.Name = "restoreBackup1";
            this.restoreBackup.Size = new System.Drawing.Size(446, 500);
            this.restoreBackup.TabIndex = 11;
            // 
            // runMultipleBackup
            // 
            this.runMultipleBackup.Location = new System.Drawing.Point(2, 49);
            this.runMultipleBackup.Name = "runMultipleBackup1";
            this.runMultipleBackup.Size = new System.Drawing.Size(446, 500);
            this.runMultipleBackup.TabIndex = 12;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 553);
            this.Controls.Add(this.runMultipleBackup);
            this.Controls.Add(this.englishButton);
            this.Controls.Add(this.frenchButton);
            this.Controls.Add(this.title);
            this.Controls.Add(this.extensionsSettings);
            this.Controls.Add(this.businessSoftwaresSettings);
            this.Controls.Add(this.Main);
            this.Controls.Add(this.backupEnvironmentForm);
            this.Controls.Add(this.runBackup);
            this.Controls.Add(this.restoreBackup);
            this.Name = "MainView";
            this.Text = "MainView";
            this.Load += new System.EventHandler(this.MainView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button frenchButton;
        private System.Windows.Forms.Button englishButton;
        internal Home Main;
        internal BackupEnvironmentForm backupEnvironmentForm;
        internal RunBackup runBackup;
        internal BusinessSoftwaresSettings businessSoftwaresSettings;
        internal ExtensionsSettings extensionsSettings;
        internal RestoreBackup restoreBackup;
        internal RunMultipleBackup runMultipleBackup;
    }
}