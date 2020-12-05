
namespace EasySave.Views.WindowsFormViews.UserControls
{
    partial class Home
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
            this.searchBarLabel = new System.Windows.Forms.Label();
            this.seachBar = new System.Windows.Forms.TextBox();
            this.listBackupEnvironments = new System.Windows.Forms.ListView();
            this.EnvironmentName = new System.Windows.Forms.ColumnHeader();
            this.deleteBackupEnvironment = new System.Windows.Forms.Button();
            this.addBackupEnvironment = new System.Windows.Forms.Button();
            this.runBackup = new System.Windows.Forms.Button();
            this.businessSoftwaresButton = new System.Windows.Forms.Button();
            this.filesToEncryptButton = new System.Windows.Forms.Button();
            this.settingsLabel = new System.Windows.Forms.Label();
            this.runMultipleBackup = new System.Windows.Forms.Button();
            this.restoreBackup = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // searchBarLabel
            // 
            this.searchBarLabel.AutoSize = true;
            this.searchBarLabel.Location = new System.Drawing.Point(8, 11);
            this.searchBarLabel.Name = "searchBarLabel";
            this.searchBarLabel.Size = new System.Drawing.Size(62, 20);
            this.searchBarLabel.TabIndex = 0;
            this.searchBarLabel.Text = "Search...";
            // 
            // seachBar
            // 
            this.seachBar.Location = new System.Drawing.Point(8, 35);
            this.seachBar.Name = "seachBar";
            this.seachBar.Size = new System.Drawing.Size(241, 27);
            this.seachBar.TabIndex = 2;
            this.seachBar.TextChanged += new System.EventHandler(this.seachBar_TextChanged);
            // 
            // listBackupEnvironments
            // 
            this.listBackupEnvironments.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.EnvironmentName});
            this.listBackupEnvironments.FullRowSelect = true;
            this.listBackupEnvironments.HideSelection = false;
            this.listBackupEnvironments.Location = new System.Drawing.Point(8, 67);
            this.listBackupEnvironments.MultiSelect = false;
            this.listBackupEnvironments.Name = "listBackupEnvironments";
            this.listBackupEnvironments.Size = new System.Drawing.Size(241, 425);
            this.listBackupEnvironments.TabIndex = 1;
            this.listBackupEnvironments.TileSize = new System.Drawing.Size(220, 50);
            this.listBackupEnvironments.UseCompatibleStateImageBehavior = false;
            this.listBackupEnvironments.View = System.Windows.Forms.View.Details;
            this.listBackupEnvironments.SelectedIndexChanged += new System.EventHandler(this.listBackupEnvironments_SelectedIndexChanged);
            // 
            // EnvironmentName
            // 
            this.EnvironmentName.Text = "Environments";
            this.EnvironmentName.Width = 125;
            // 
            // deleteBackupEnvironment
            // 
            this.deleteBackupEnvironment.Enabled = false;
            this.deleteBackupEnvironment.Location = new System.Drawing.Point(261, 133);
            this.deleteBackupEnvironment.Name = "deleteBackupEnvironment";
            this.deleteBackupEnvironment.Size = new System.Drawing.Size(179, 61);
            this.deleteBackupEnvironment.TabIndex = 5;
            this.deleteBackupEnvironment.Text = "Delete this environment";
            this.deleteBackupEnvironment.UseVisualStyleBackColor = true;
            this.deleteBackupEnvironment.Click += new System.EventHandler(this.deleteBackupEnvironment_Click);
            // 
            // addBackupEnvironment
            // 
            this.addBackupEnvironment.Location = new System.Drawing.Point(261, 67);
            this.addBackupEnvironment.Name = "addBackupEnvironment";
            this.addBackupEnvironment.Size = new System.Drawing.Size(179, 61);
            this.addBackupEnvironment.TabIndex = 6;
            this.addBackupEnvironment.Text = "Add an environment";
            this.addBackupEnvironment.UseVisualStyleBackColor = true;
            this.addBackupEnvironment.Click += new System.EventHandler(this.addBackupEnvironment_Click);
            // 
            // runBackup
            // 
            this.runBackup.Enabled = false;
            this.runBackup.Location = new System.Drawing.Point(261, 201);
            this.runBackup.Name = "runBackup";
            this.runBackup.Size = new System.Drawing.Size(179, 61);
            this.runBackup.TabIndex = 7;
            this.runBackup.Text = "Run a Backup";
            this.runBackup.UseVisualStyleBackColor = true;
            this.runBackup.Click += new System.EventHandler(this.runBackup_Click);
            // 
            // businessSoftwaresButton
            // 
            this.businessSoftwaresButton.Location = new System.Drawing.Point(261, 431);
            this.businessSoftwaresButton.Name = "businessSoftwaresButton";
            this.businessSoftwaresButton.Size = new System.Drawing.Size(87, 61);
            this.businessSoftwaresButton.TabIndex = 8;
            this.businessSoftwaresButton.Text = "Business softwares";
            this.businessSoftwaresButton.UseVisualStyleBackColor = true;
            this.businessSoftwaresButton.Click += new System.EventHandler(this.businessSoftwaresButton_Click);
            // 
            // filesToEncryptButton
            // 
            this.filesToEncryptButton.Location = new System.Drawing.Point(352, 431);
            this.filesToEncryptButton.Name = "filesToEncryptButton";
            this.filesToEncryptButton.Size = new System.Drawing.Size(87, 61);
            this.filesToEncryptButton.TabIndex = 9;
            this.filesToEncryptButton.Text = "Files to encrypt";
            this.filesToEncryptButton.UseVisualStyleBackColor = true;
            this.filesToEncryptButton.Click += new System.EventHandler(this.filesToEncryptButton_Click);
            // 
            // settingsLabel
            // 
            this.settingsLabel.AutoSize = true;
            this.settingsLabel.Location = new System.Drawing.Point(261, 408);
            this.settingsLabel.Name = "settingsLabel";
            this.settingsLabel.Size = new System.Drawing.Size(62, 20);
            this.settingsLabel.TabIndex = 10;
            this.settingsLabel.Text = "Settings";
            // 
            // runMultipleBackup
            // 
            this.runMultipleBackup.Location = new System.Drawing.Point(261, 268);
            this.runMultipleBackup.Name = "runMultipleBackup";
            this.runMultipleBackup.Size = new System.Drawing.Size(179, 61);
            this.runMultipleBackup.TabIndex = 11;
            this.runMultipleBackup.Text = "Run multiple backups";
            this.runMultipleBackup.UseVisualStyleBackColor = true;
            this.runMultipleBackup.Click += new System.EventHandler(this.runMultipleBackup_Click);
            // 
            // restoreBackup
            // 
            this.restoreBackup.Location = new System.Drawing.Point(261, 335);
            this.restoreBackup.Name = "restoreBackup";
            this.restoreBackup.Size = new System.Drawing.Size(179, 61);
            this.restoreBackup.TabIndex = 12;
            this.restoreBackup.Text = "Restore a backup";
            this.restoreBackup.UseVisualStyleBackColor = true;
            this.restoreBackup.Click += new System.EventHandler(this.restoreBackup_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.restoreBackup);
            this.Controls.Add(this.runMultipleBackup);
            this.Controls.Add(this.settingsLabel);
            this.Controls.Add(this.filesToEncryptButton);
            this.Controls.Add(this.businessSoftwaresButton);
            this.Controls.Add(this.runBackup);
            this.Controls.Add(this.addBackupEnvironment);
            this.Controls.Add(this.deleteBackupEnvironment);
            this.Controls.Add(this.seachBar);
            this.Controls.Add(this.listBackupEnvironments);
            this.Controls.Add(this.searchBarLabel);
            this.Name = "Home";
            this.Size = new System.Drawing.Size(450, 500);
            this.Load += new System.EventHandler(this.Home_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label searchBarLabel;
        private System.Windows.Forms.ListView listBackupEnvironments;
        private System.Windows.Forms.TextBox seachBar;
        private System.Windows.Forms.Button deleteBackupEnvironment;
        private System.Windows.Forms.Button addBackupEnvironment;
        private System.Windows.Forms.Button runBackup;
        private System.Windows.Forms.Button businessSoftwaresButton;
        private System.Windows.Forms.Button filesToEncryptButton;
        private System.Windows.Forms.Label settingsLabel;
        private System.Windows.Forms.Button runMultipleBackup;
        private System.Windows.Forms.Button restoreBackup;
        private System.Windows.Forms.ColumnHeader EnvironmentName;
    }
}
