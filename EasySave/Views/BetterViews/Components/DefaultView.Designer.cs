
namespace EasySave.Views.BetterViews.Components
{
    partial class DefaultView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DefaultView));
            this.WelcomeLabel = new System.Windows.Forms.Label();
            this.HomeImage = new System.Windows.Forms.PictureBox();
            this.DefaultViewLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.HomeImage)).BeginInit();
            this.SuspendLayout();
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.WelcomeLabel.AutoSize = true;
            this.WelcomeLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.WelcomeLabel.Location = new System.Drawing.Point(465, 100);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(185, 54);
            this.WelcomeLabel.TabIndex = 1;
            this.WelcomeLabel.Text = "Welcome";
            this.WelcomeLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // HomeImage
            // 
            this.HomeImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HomeImage.Image = ((System.Drawing.Image)(resources.GetObject("HomeImage.Image")));
            this.HomeImage.Location = new System.Drawing.Point(0, 0);
            this.HomeImage.Name = "HomeImage";
            this.HomeImage.Size = new System.Drawing.Size(1084, 772);
            this.HomeImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.HomeImage.TabIndex = 2;
            this.HomeImage.TabStop = false;
            // 
            // DefaultViewLabel
            // 
            this.DefaultViewLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DefaultViewLabel.AutoSize = true;
            this.DefaultViewLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DefaultViewLabel.Location = new System.Drawing.Point(305, 624);
            this.DefaultViewLabel.Name = "DefaultViewLabel";
            this.DefaultViewLabel.Size = new System.Drawing.Size(551, 28);
            this.DefaultViewLabel.TabIndex = 3;
            this.DefaultViewLabel.Text = "To begin with, create an environment and select one in the list.";
            this.DefaultViewLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // DefaultView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.WelcomeLabel);
            this.Controls.Add(this.DefaultViewLabel);
            this.Controls.Add(this.HomeImage);
            this.Name = "DefaultView";
            this.Size = new System.Drawing.Size(1084, 772);
            this.Load += new System.EventHandler(this.DefaultView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.HomeImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label WelcomeLabel;
        private System.Windows.Forms.PictureBox HomeImage;
        private System.Windows.Forms.Label DefaultViewLabel;
    }
}
