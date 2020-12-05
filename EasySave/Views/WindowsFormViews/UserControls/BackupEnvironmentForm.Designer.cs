
namespace EasySave.Views.WindowsFormViews.UserControls
{
    partial class BackupEnvironmentForm
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.confirmButton = new System.Windows.Forms.Button();
            this.returnMenuButton = new System.Windows.Forms.Button();
            this.sourceDirectoryLabel = new System.Windows.Forms.Label();
            this.destinationDirectoryLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.sourceDirectoryTextbox = new System.Windows.Forms.TextBox();
            this.destinationDirectoryTextbox = new System.Windows.Forms.TextBox();
            this.sourceDirectory = new System.Windows.Forms.Button();
            this.destinationDirectory = new System.Windows.Forms.Button();
            this.description = new System.Windows.Forms.RichTextBox();
            this.decriptionLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(100, 77);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(49, 20);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name";
            // 
            // confirmButton
            // 
            this.confirmButton.Location = new System.Drawing.Point(172, 393);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(100, 29);
            this.confirmButton.TabIndex = 1;
            this.confirmButton.Text = "Confirm";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // returnMenuButton
            // 
            this.returnMenuButton.Location = new System.Drawing.Point(263, 459);
            this.returnMenuButton.Name = "returnMenuButton";
            this.returnMenuButton.Size = new System.Drawing.Size(175, 29);
            this.returnMenuButton.TabIndex = 2;
            this.returnMenuButton.Text = "Main menu";
            this.returnMenuButton.UseVisualStyleBackColor = true;
            this.returnMenuButton.Click += new System.EventHandler(this.returnMenuButton_Click_1);
            // 
            // sourceDirectoryLabel
            // 
            this.sourceDirectoryLabel.AutoSize = true;
            this.sourceDirectoryLabel.Location = new System.Drawing.Point(100, 152);
            this.sourceDirectoryLabel.Name = "sourceDirectoryLabel";
            this.sourceDirectoryLabel.Size = new System.Drawing.Size(117, 20);
            this.sourceDirectoryLabel.TabIndex = 3;
            this.sourceDirectoryLabel.Text = "Source directory";
            // 
            // destinationDirectoryLabel
            // 
            this.destinationDirectoryLabel.AutoSize = true;
            this.destinationDirectoryLabel.Location = new System.Drawing.Point(100, 227);
            this.destinationDirectoryLabel.Name = "destinationDirectoryLabel";
            this.destinationDirectoryLabel.Size = new System.Drawing.Size(148, 20);
            this.destinationDirectoryLabel.TabIndex = 4;
            this.destinationDirectoryLabel.Text = "Destination directory";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(100, 100);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(250, 27);
            this.nameTextBox.TabIndex = 5;
            // 
            // sourceDirectoryTextbox
            // 
            this.sourceDirectoryTextbox.Location = new System.Drawing.Point(100, 175);
            this.sourceDirectoryTextbox.Name = "sourceDirectoryTextbox";
            this.sourceDirectoryTextbox.ReadOnly = true;
            this.sourceDirectoryTextbox.Size = new System.Drawing.Size(206, 27);
            this.sourceDirectoryTextbox.TabIndex = 6;
            // 
            // destinationDirectoryTextbox
            // 
            this.destinationDirectoryTextbox.Location = new System.Drawing.Point(100, 250);
            this.destinationDirectoryTextbox.Name = "destinationDirectoryTextbox";
            this.destinationDirectoryTextbox.ReadOnly = true;
            this.destinationDirectoryTextbox.Size = new System.Drawing.Size(206, 27);
            this.destinationDirectoryTextbox.TabIndex = 7;
            // 
            // sourceDirectory
            // 
            this.sourceDirectory.Location = new System.Drawing.Point(312, 175);
            this.sourceDirectory.Name = "sourceDirectory";
            this.sourceDirectory.Size = new System.Drawing.Size(38, 27);
            this.sourceDirectory.TabIndex = 8;
            this.sourceDirectory.Text = "...";
            this.sourceDirectory.UseVisualStyleBackColor = true;
            this.sourceDirectory.Click += new System.EventHandler(this.sourceDirectory_Click);
            // 
            // destinationDirectory
            // 
            this.destinationDirectory.Location = new System.Drawing.Point(312, 250);
            this.destinationDirectory.Name = "destinationDirectory";
            this.destinationDirectory.Size = new System.Drawing.Size(38, 27);
            this.destinationDirectory.TabIndex = 9;
            this.destinationDirectory.Text = "...";
            this.destinationDirectory.UseVisualStyleBackColor = true;
            this.destinationDirectory.Click += new System.EventHandler(this.destinationDirectory_Click);
            // 
            // description
            // 
            this.description.Location = new System.Drawing.Point(100, 316);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(261, 71);
            this.description.TabIndex = 12;
            this.description.Text = "";
            // 
            // decriptionLabel
            // 
            this.decriptionLabel.AutoSize = true;
            this.decriptionLabel.Location = new System.Drawing.Point(100, 293);
            this.decriptionLabel.Name = "decriptionLabel";
            this.decriptionLabel.Size = new System.Drawing.Size(149, 20);
            this.decriptionLabel.TabIndex = 13;
            this.decriptionLabel.Text = "Decription (optional)";
            // 
            // BackupEnvironmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.decriptionLabel);
            this.Controls.Add(this.description);
            this.Controls.Add(this.destinationDirectory);
            this.Controls.Add(this.sourceDirectory);
            this.Controls.Add(this.destinationDirectoryTextbox);
            this.Controls.Add(this.sourceDirectoryTextbox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.destinationDirectoryLabel);
            this.Controls.Add(this.sourceDirectoryLabel);
            this.Controls.Add(this.returnMenuButton);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.nameLabel);
            this.Name = "BackupEnvironmentForm";
            this.Size = new System.Drawing.Size(450, 500);
            this.Load += new System.EventHandler(this.BackupEnvironmentForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.Button returnMenuButton;
        private System.Windows.Forms.Label sourceDirectoryLabel;
        private System.Windows.Forms.Label destinationDirectoryLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox sourceDirectoryTextbox;
        private System.Windows.Forms.TextBox destinationDirectoryTextbox;
        private System.Windows.Forms.Button sourceDirectory;
        private System.Windows.Forms.Button destinationDirectory;
        private System.Windows.Forms.RichTextBox description;
        private System.Windows.Forms.Label decriptionLabel;
    }
}
