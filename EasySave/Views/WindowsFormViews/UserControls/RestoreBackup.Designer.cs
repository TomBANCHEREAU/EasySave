
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
            this.listBackups = new System.Windows.Forms.ListView();
            this.restoreButton = new System.Windows.Forms.Button();
            this.returnMenuButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBackups
            // 
            this.listBackups.HideSelection = false;
            this.listBackups.Location = new System.Drawing.Point(8, 67);
            this.listBackups.Name = "listBackups";
            this.listBackups.Size = new System.Drawing.Size(241, 425);
            this.listBackups.TabIndex = 0;
            this.listBackups.UseCompatibleStateImageBehavior = false;
            // 
            // restoreButton
            // 
            this.restoreButton.Location = new System.Drawing.Point(263, 67);
            this.restoreButton.Name = "restoreButton";
            this.restoreButton.Size = new System.Drawing.Size(175, 61);
            this.restoreButton.TabIndex = 1;
            this.restoreButton.Text = "Restore a backup";
            this.restoreButton.UseVisualStyleBackColor = true;
            // 
            // returnMenuButton
            // 
            this.returnMenuButton.Location = new System.Drawing.Point(263, 459);
            this.returnMenuButton.Name = "returnMenuButton";
            this.returnMenuButton.Size = new System.Drawing.Size(175, 29);
            this.returnMenuButton.TabIndex = 2;
            this.returnMenuButton.Text = "Main menu";
            this.returnMenuButton.UseVisualStyleBackColor = true;
            // 
            // RestoreBackup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.returnMenuButton);
            this.Controls.Add(this.restoreButton);
            this.Controls.Add(this.listBackups);
            this.Name = "RestoreBackup";
            this.Size = new System.Drawing.Size(450, 500);
            this.Load += new System.EventHandler(this.RestoreBackup_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listBackups;
        private System.Windows.Forms.Button restoreButton;
        private System.Windows.Forms.Button returnMenuButton;
    }
}
