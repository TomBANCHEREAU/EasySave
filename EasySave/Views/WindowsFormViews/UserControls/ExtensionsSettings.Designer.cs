
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
            this.extensionsList = new System.Windows.Forms.ListView();
            this.input = new System.Windows.Forms.TextBox();
            this.add = new System.Windows.Forms.Button();
            this.remove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleExtensions
            // 
            this.titleExtensions.AutoSize = true;
            this.titleExtensions.Location = new System.Drawing.Point(35, 30);
            this.titleExtensions.Name = "titleExtensions";
            this.titleExtensions.Size = new System.Drawing.Size(126, 20);
            this.titleExtensions.TabIndex = 0;
            this.titleExtensions.Text = "Define extensions";
            // 
            // subtitleExtentions
            // 
            this.subtitleExtentions.AutoSize = true;
            this.subtitleExtentions.Location = new System.Drawing.Point(35, 75);
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
            // extensionsList
            // 
            this.extensionsList.HideSelection = false;
            this.extensionsList.Location = new System.Drawing.Point(70, 180);
            this.extensionsList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.extensionsList.Name = "extensionsList";
            this.extensionsList.Size = new System.Drawing.Size(300, 220);
            this.extensionsList.TabIndex = 3;
            this.extensionsList.UseCompatibleStateImageBehavior = false;
            this.extensionsList.View = System.Windows.Forms.View.List;
            // 
            // input
            // 
            this.input.Location = new System.Drawing.Point(70, 145);
            this.input.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(114, 27);
            this.input.TabIndex = 4;
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(192, 145);
            this.add.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(86, 31);
            this.add.TabIndex = 5;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // remove
            // 
            this.remove.Location = new System.Drawing.Point(284, 145);
            this.remove.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.remove.Name = "remove";
            this.remove.Size = new System.Drawing.Size(86, 31);
            this.remove.TabIndex = 6;
            this.remove.Text = "Remove";
            this.remove.UseVisualStyleBackColor = true;
            this.remove.Click += new System.EventHandler(this.remove_Click);
            // 
            // ExtensionsSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.remove);
            this.Controls.Add(this.add);
            this.Controls.Add(this.input);
            this.Controls.Add(this.extensionsList);
            this.Controls.Add(this.returnMenuButton);
            this.Controls.Add(this.subtitleExtentions);
            this.Controls.Add(this.titleExtensions);
            this.Location = new System.Drawing.Point(192, 145);
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
        private System.Windows.Forms.ListView extensionsList;
        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button remove;
    }
}
