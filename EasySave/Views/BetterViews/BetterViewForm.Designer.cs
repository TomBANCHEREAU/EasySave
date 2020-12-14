
namespace EasySave.Views.BetterViews
{
    partial class BetterViewForm
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
            this.MainLayout = new System.Windows.Forms.TableLayoutPanel();
            this.Title = new System.Windows.Forms.Label();
            this.EnvironmentList = new EasySave.Views.BetterViews.Components.EnvironmentList();
            this.Settings = new EasySave.Views.BetterViews.Components.Settings();
            this.DynamicPanel = new EasySave.Views.BetterViews.Components.DefaultView();
            this.MainLayout.SuspendLayout();
            this.DynamicPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainLayout
            // 
            this.MainLayout.ColumnCount = 2;
            this.MainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.MainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.MainLayout.Controls.Add(this.Title, 0, 0);
            this.MainLayout.Controls.Add(this.EnvironmentList, 0, 1);
            this.MainLayout.Controls.Add(this.Settings, 1, 0);
            this.MainLayout.Controls.Add(this.DynamicPanel, 1, 1);
            this.MainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainLayout.Location = new System.Drawing.Point(0, 0);
            this.MainLayout.Margin = new System.Windows.Forms.Padding(5);
            this.MainLayout.Name = "MainLayout";
            this.MainLayout.RowCount = 2;
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.MainLayout.Size = new System.Drawing.Size(1445, 908);
            this.MainLayout.TabIndex = 0;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.BackColor = System.Drawing.SystemColors.Control;
            this.Title.Cursor = System.Windows.Forms.Cursors.Default;
            this.Title.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Title.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Title.Location = new System.Drawing.Point(0, 0);
            this.Title.Margin = new System.Windows.Forms.Padding(0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(361, 136);
            this.Title.TabIndex = 0;
            this.Title.Text = "EasySave";
            this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Title.Click += new System.EventHandler(this.Title_Click);
            // 
            // EnvironmentList
            // 
            this.EnvironmentList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EnvironmentList.Location = new System.Drawing.Point(5, 141);
            this.EnvironmentList.Margin = new System.Windows.Forms.Padding(5);
            this.EnvironmentList.Name = "EnvironmentList";
            this.EnvironmentList.Size = new System.Drawing.Size(351, 762);
            this.EnvironmentList.TabIndex = 1;
            // 
            // Settings
            // 
            this.Settings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Settings.Location = new System.Drawing.Point(366, 5);
            this.Settings.Margin = new System.Windows.Forms.Padding(5);
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(1074, 126);
            this.Settings.TabIndex = 2;
            // 
            // DynamicPanel
            // 
            this.DynamicPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DynamicPanel.Location = new System.Drawing.Point(361, 136);
            this.DynamicPanel.Margin = new System.Windows.Forms.Padding(0);
            this.DynamicPanel.Name = "DynamicPanel";
            this.DynamicPanel.Size = new System.Drawing.Size(1084, 772);
            this.DynamicPanel.TabIndex = 1;
            // 
            // BetterViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1445, 908);
            this.Controls.Add(this.MainLayout);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(1460, 944);
            this.Name = "BetterViewForm";
            this.Text = "BetterView";
            this.Load += new System.EventHandler(this.BetterViewForm_Load);
            this.MainLayout.ResumeLayout(false);
            this.MainLayout.PerformLayout();
            this.DynamicPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel MainLayout;
        private System.Windows.Forms.Label Title;
        private Components.EnvironmentList EnvironmentList;
        private Components.Settings Settings;
        private System.Windows.Forms.UserControl DynamicPanel;
    }
}