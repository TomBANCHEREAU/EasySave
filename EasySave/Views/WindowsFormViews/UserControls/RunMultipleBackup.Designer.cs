
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
            this.chooseBackupLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // returnMenuButton
            // 
            this.returnMenuButton.Location = new System.Drawing.Point(263, 459);
            this.returnMenuButton.Name = "returnMenuButton";
            this.returnMenuButton.Size = new System.Drawing.Size(175, 29);
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
            this.listEnvironments.Location = new System.Drawing.Point(8, 67);
            this.listEnvironments.MultiSelect = false;
            this.listEnvironments.Name = "listEnvironments";
            this.listEnvironments.Size = new System.Drawing.Size(241, 425);
            this.listEnvironments.TabIndex = 1;
            this.listEnvironments.UseCompatibleStateImageBehavior = false;
            this.listEnvironments.View = System.Windows.Forms.View.Details;
            this.listEnvironments.SelectedIndexChanged += new System.EventHandler(this.listEnvironments_SelectedIndexChanged);
            // 
            // Environments
            // 
            this.Environments.Text = "Environments";
            this.Environments.Width = 125;
            // 
            // BackupType
            // 
            this.BackupType.Text = "Type";
            this.BackupType.Width = 100;
            // 
            // fullBackup
            // 
            this.fullBackup.AutoSize = true;
            this.fullBackup.Location = new System.Drawing.Point(275, 170);
            this.fullBackup.Name = "fullBackup";
            this.fullBackup.Size = new System.Drawing.Size(105, 24);
            this.fullBackup.TabIndex = 4;
            this.fullBackup.TabStop = true;
            this.fullBackup.Text = "Full backup";
            this.fullBackup.UseVisualStyleBackColor = true;
            this.fullBackup.CheckedChanged += new System.EventHandler(this.fullBackup_CheckedChanged);
            // 
            // differentialBackup
            // 
            this.differentialBackup.AutoSize = true;
            this.differentialBackup.Location = new System.Drawing.Point(275, 215);
            this.differentialBackup.Name = "differentialBackup";
            this.differentialBackup.Size = new System.Drawing.Size(157, 24);
            this.differentialBackup.TabIndex = 5;
            this.differentialBackup.TabStop = true;
            this.differentialBackup.Text = "Differential backup";
            this.differentialBackup.UseVisualStyleBackColor = true;
            this.differentialBackup.CheckedChanged += new System.EventHandler(this.differentialBackup_CheckedChanged);
            // 
            // none
            // 
            this.none.AutoSize = true;
            this.none.Location = new System.Drawing.Point(275, 125);
            this.none.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.none.Name = "none";
            this.none.Size = new System.Drawing.Size(102, 24);
            this.none.TabIndex = 6;
            this.none.TabStop = true;
            this.none.Text = "No backup";
            this.none.UseVisualStyleBackColor = true;
            this.none.CheckedChanged += new System.EventHandler(this.none_CheckedChanged);
            // 
            // runBackups
            // 
            this.runBackups.Location = new System.Drawing.Point(263, 391);
            this.runBackups.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.runBackups.Name = "runBackups";
            this.runBackups.Size = new System.Drawing.Size(175, 61);
            this.runBackups.TabIndex = 7;
            this.runBackups.Text = "Run backups";
            this.runBackups.UseVisualStyleBackColor = true;
            this.runBackups.Click += new System.EventHandler(this.runBackups_Click);
            // 
            // chooseBackupLabel
            // 
            this.chooseBackupLabel.AutoSize = true;
            this.chooseBackupLabel.Location = new System.Drawing.Point(263, 67);
            this.chooseBackupLabel.Name = "chooseBackupLabel";
            this.chooseBackupLabel.Size = new System.Drawing.Size(158, 20);
            this.chooseBackupLabel.TabIndex = 8;
            this.chooseBackupLabel.Text = "Choose a backup type:";
            // 
            // RunMultipleBackup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chooseBackupLabel);
            this.Controls.Add(this.runBackups);
            this.Controls.Add(this.none);
            this.Controls.Add(this.differentialBackup);
            this.Controls.Add(this.fullBackup);
            this.Controls.Add(this.listEnvironments);
            this.Controls.Add(this.returnMenuButton);
            this.Name = "RunMultipleBackup";
            this.Size = new System.Drawing.Size(450, 500);
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
        private System.Windows.Forms.Label chooseBackupLabel;
    }
}
