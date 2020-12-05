
namespace EasySave.Views.WindowsFormViews.UserControls
{
    partial class ExtensionsSettings
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
            this.titleExtensions = new System.Windows.Forms.Label();
            this.subtitleExtentions = new System.Windows.Forms.Label();
            this.returnMenuButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleExtensions
            // 
            this.titleExtensions.AutoSize = true;
            this.titleExtensions.Location = new System.Drawing.Point(35, 42);
            this.titleExtensions.Name = "titleExtensions";
            this.titleExtensions.Size = new System.Drawing.Size(126, 20);
            this.titleExtensions.TabIndex = 0;
            this.titleExtensions.Text = "Define extensions";
            // 
            // subtitleExtentions
            // 
            this.subtitleExtentions.AutoSize = true;
            this.subtitleExtentions.Location = new System.Drawing.Point(35, 78);
            this.subtitleExtentions.Name = "subtitleExtentions";
            this.subtitleExtentions.Size = new System.Drawing.Size(335, 20);
            this.subtitleExtentions.TabIndex = 1;
            this.subtitleExtentions.Text = "All files within these extensions will be encrypted.";
            // 
            // returnMenuButton
            // 
            this.returnMenuButton.Location = new System.Drawing.Point(263, 459);
            this.returnMenuButton.Name = "returnMenuButton";
            this.returnMenuButton.Size = new System.Drawing.Size(175, 29);
            this.returnMenuButton.TabIndex = 2;
            this.returnMenuButton.Text = "Main menu";
            this.returnMenuButton.UseVisualStyleBackColor = true;
            this.returnMenuButton.Click += new System.EventHandler(this.returnMenuButton_Click);
            // 
            // ExtensionsSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.returnMenuButton);
            this.Controls.Add(this.subtitleExtentions);
            this.Controls.Add(this.titleExtensions);
            this.Name = "ExtensionsSettings";
            this.Size = new System.Drawing.Size(450, 500);
            this.Load += new System.EventHandler(this.ExtensionsSettings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleExtensions;
        private System.Windows.Forms.Label subtitleExtentions;
        private System.Windows.Forms.Button returnMenuButton;
    }
}
