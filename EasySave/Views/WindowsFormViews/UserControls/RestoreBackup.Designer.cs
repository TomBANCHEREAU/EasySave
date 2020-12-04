
namespace EasySave.Views.WindowsFormViews.UserControls
{
    partial class RestoreBackup
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
            this.listBackups = new System.Windows.Forms.ListBox();
            this.returnMenuButton = new System.Windows.Forms.Button();
            this.restore = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBackups.FormattingEnabled = true;
            this.listBackups.ItemHeight = 15;
            this.listBackups.Location = new System.Drawing.Point(11, 97);
            this.listBackups.Name = "listBox1";
            this.listBackups.Size = new System.Drawing.Size(170, 229);
            this.listBackups.TabIndex = 0;
            this.listBackups.SelectedIndexChanged += new System.EventHandler(this.listBackups_SelectedIndexChanged);
            // 
            // returnMenuButton
            // 
            this.returnMenuButton.Location = new System.Drawing.Point(212, 304);
            this.returnMenuButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.returnMenuButton.Name = "returnMenuButton";
            this.returnMenuButton.Size = new System.Drawing.Size(103, 22);
            this.returnMenuButton.TabIndex = 5;
            this.returnMenuButton.Text = "Main menu";
            this.returnMenuButton.UseVisualStyleBackColor = true;
            this.returnMenuButton.Click += new System.EventHandler(this.returnMenuButton_Click);
            // 
            // restore
            // 
            this.restore.Location = new System.Drawing.Point(212, 170);
            this.restore.Name = "restore";
            this.restore.Size = new System.Drawing.Size(109, 23);
            this.restore.TabIndex = 6;
            this.restore.Text = "Restore a backup";
            this.restore.UseVisualStyleBackColor = true;
            this.restore.Click += new System.EventHandler(this.restore_Click);
            // 
            // RestoreBackup
            // 
            this.Controls.Add(this.restore);
            this.Controls.Add(this.returnMenuButton);
            this.Controls.Add(this.listBackups);
            this.Name = "RestoreBackup";
            this.Size = new System.Drawing.Size(349, 356);
            this.Load += new System.EventHandler(this.RestoreBackup_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.ListBox listBackups;
        private System.Windows.Forms.Button returnMenuButton;
        private System.Windows.Forms.Button restore;
    }
}
