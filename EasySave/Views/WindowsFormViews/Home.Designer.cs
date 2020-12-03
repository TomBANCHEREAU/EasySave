
namespace EasySave.Views.WindowsFormViews
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
            this.deleteBackupEnvironment = new System.Windows.Forms.Button();
            this.addBackupEnvironment = new System.Windows.Forms.Button();
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
            this.seachBar.Location = new System.Drawing.Point(8, 34);
            this.seachBar.Name = "seachBar";
            this.seachBar.Size = new System.Drawing.Size(241, 27);
            this.seachBar.TabIndex = 2;
            this.seachBar.TextChanged += new System.EventHandler(this.seachBar_TextChanged);
            // 
            // listBackupEnvironments
            // 
            this.listBackupEnvironments.HideSelection = false;
            this.listBackupEnvironments.Location = new System.Drawing.Point(8, 67);
            this.listBackupEnvironments.MultiSelect = false;
            this.listBackupEnvironments.Name = "listBackupEnvironments";
            this.listBackupEnvironments.Size = new System.Drawing.Size(241, 425);
            this.listBackupEnvironments.TabIndex = 1;
            this.listBackupEnvironments.TileSize = new System.Drawing.Size(220, 50);
            this.listBackupEnvironments.UseCompatibleStateImageBehavior = false;
            this.listBackupEnvironments.View = System.Windows.Forms.View.Tile;
            this.listBackupEnvironments.SelectedIndexChanged += new System.EventHandler(this.listBackupEnvironments_SelectedIndexChanged);
            // 
            // deleteBackupEnvironment
            // 
            this.deleteBackupEnvironment.Location = new System.Drawing.Point(260, 67);
            this.deleteBackupEnvironment.Name = "deleteBackupEnvironment";
            this.deleteBackupEnvironment.Size = new System.Drawing.Size(179, 29);
            this.deleteBackupEnvironment.TabIndex = 5;
            this.deleteBackupEnvironment.Text = "Delete this environment";
            this.deleteBackupEnvironment.UseVisualStyleBackColor = true;
            this.deleteBackupEnvironment.Click += new System.EventHandler(this.deleteBackupEnvironment_Click);
            // 
            // addBackupEnvironment
            // 
            this.addBackupEnvironment.Location = new System.Drawing.Point(260, 136);
            this.addBackupEnvironment.Name = "addBackupEnvironment";
            this.addBackupEnvironment.Size = new System.Drawing.Size(179, 29);
            this.addBackupEnvironment.TabIndex = 6;
            this.addBackupEnvironment.Text = "Add an environment";
            this.addBackupEnvironment.UseVisualStyleBackColor = true;
            this.addBackupEnvironment.Click += new System.EventHandler(this.addBackupEnvironment_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
    }
}
