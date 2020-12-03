
using EasySave.Views.WindowsFormViews.UserControlers;

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
            this.title = new System.Windows.Forms.Label();
            this.Main = new EasySave.Views.WindowsFormViews.UserControlers.Home();
            this.backupEnvironmentForm = new EasySave.Views.WindowsFormViews.UserControlers.BackupEnvironmentForm();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Century", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.title.Location = new System.Drawing.Point(156, 18);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(127, 28);
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
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 552);
            this.Controls.Add(this.title);
            this.Controls.Add(this.Main);
            this.Controls.Add(this.backupEnvironmentForm);
            this.Name = "MainView";
            this.Text = "MainView";
            this.Load += new System.EventHandler(this.MainView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private Home Main;
        private BackupEnvironmentForm backupEnvironmentForm;
    }
}