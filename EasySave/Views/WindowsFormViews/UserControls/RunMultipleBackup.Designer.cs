
namespace EasySave.Views.WindowsFormViews.UserControls
{
    partial class RunMultipleBackup
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.returnMenuButton = new System.Windows.Forms.Button();
            this.listEnvironments = new System.Windows.Forms.ListView();
            this.Environments = new System.Windows.Forms.ColumnHeader();
            this.BackupType = new System.Windows.Forms.ColumnHeader();
            this.fullBackup = new System.Windows.Forms.RadioButton();
            this.differentialBackup = new System.Windows.Forms.RadioButton();
            this.none = new System.Windows.Forms.RadioButton();
            this.runBackups = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // returnMenuButton
            // 
            this.returnMenuButton.Location = new System.Drawing.Point(230, 344);
            this.returnMenuButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.returnMenuButton.Name = "returnMenuButton";
            this.returnMenuButton.Size = new System.Drawing.Size(153, 22);
            this.returnMenuButton.TabIndex = 0;
            this.returnMenuButton.Text = "Main menu";
            this.returnMenuButton.UseVisualStyleBackColor = true;
            this.returnMenuButton.Click += new System.EventHandler(this.returnMenuButton_Click);
            // 
            // listEnvironments
            // 
            this.listEnvironments.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Environments,
            this.BackupType});
            this.listEnvironments.FullRowSelect = true;
            this.listEnvironments.HideSelection = false;
            this.listEnvironments.Location = new System.Drawing.Point(7, 50);
            this.listEnvironments.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listEnvironments.MultiSelect = false;
            this.listEnvironments.Name = "listEnvironments";
            this.listEnvironments.Size = new System.Drawing.Size(211, 320);
            this.listEnvironments.TabIndex = 1;
            this.listEnvironments.UseCompatibleStateImageBehavior = false;
            this.listEnvironments.View = System.Windows.Forms.View.Details;
            this.listEnvironments.SelectedIndexChanged += new System.EventHandler(this.listEnvironments_SelectedIndexChanged);
            // 
            // Environments
            // 
            this.Environments.Text = "Environments";
            this.Environments.Width = 100;
            // 
            // BackupType
            // 
            this.BackupType.Text = "Backup type";
            this.BackupType.Width = 100;
            // 
            // fullBackup
            // 
            this.fullBackup.AutoSize = true;
            this.fullBackup.Location = new System.Drawing.Point(253, 144);
            this.fullBackup.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fullBackup.Name = "fullBackup";
            this.fullBackup.Size = new System.Drawing.Size(86, 19);
            this.fullBackup.TabIndex = 4;
            this.fullBackup.TabStop = true;
            this.fullBackup.Text = "Full backup";
            this.fullBackup.UseVisualStyleBackColor = true;
            this.fullBackup.CheckedChanged += new System.EventHandler(this.fullBackup_CheckedChanged);
            // 
            // differentialBackup
            // 
            this.differentialBackup.AutoSize = true;
            this.differentialBackup.Location = new System.Drawing.Point(253, 188);
            this.differentialBackup.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.differentialBackup.Name = "differentialBackup";
            this.differentialBackup.Size = new System.Drawing.Size(125, 19);
            this.differentialBackup.TabIndex = 5;
            this.differentialBackup.TabStop = true;
            this.differentialBackup.Text = "Differential backup";
            this.differentialBackup.UseVisualStyleBackColor = true;
            this.differentialBackup.CheckedChanged += new System.EventHandler(this.differentialBackup_CheckedChanged);
            // 
            // none
            // 
            this.none.AutoSize = true;
            this.none.Location = new System.Drawing.Point(253, 99);
            this.none.Name = "none";
            this.none.Size = new System.Drawing.Size(83, 19);
            this.none.TabIndex = 6;
            this.none.TabStop = true;
            this.none.Text = "No backup";
            this.none.UseVisualStyleBackColor = true;
            this.none.CheckedChanged += new System.EventHandler(this.none_CheckedChanged);
            // 
            // runBackups
            // 
            this.runBackups.Location = new System.Drawing.Point(230, 298);
            this.runBackups.Name = "runBackups";
            this.runBackups.Size = new System.Drawing.Size(153, 41);
            this.runBackups.TabIndex = 7;
            this.runBackups.Text = "Run backups";
            this.runBackups.UseVisualStyleBackColor = true;
            this.runBackups.Click += new System.EventHandler(this.runBackups_Click);
            // 
            // RunMultipleBackup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.runBackups);
            this.Controls.Add(this.none);
            this.Controls.Add(this.differentialBackup);
            this.Controls.Add(this.fullBackup);
            this.Controls.Add(this.listEnvironments);
            this.Controls.Add(this.returnMenuButton);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "RunMultipleBackup";
            this.Size = new System.Drawing.Size(394, 375);
            this.Load += new System.EventHandler(this.RunMultipleBackup_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button returnMenuButton;
        private System.Windows.Forms.ListView listEnvironments;
        private System.Windows.Forms.RadioButton fullBackup;
        private System.Windows.Forms.RadioButton differentialBackup;
        private System.Windows.Forms.ColumnHeader Environments;
        private System.Windows.Forms.ColumnHeader BackupType;
        private System.Windows.Forms.RadioButton none;
        private System.Windows.Forms.Button runBackups;
    }
}
