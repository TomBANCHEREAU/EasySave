
namespace EasySave.Views.WindowsFormViews.UserControls
{
    partial class BusinessSoftwaresSettings
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
            this.titleBusinessSoftwares = new System.Windows.Forms.Label();
            this.subtitleBusinessSoftwares1 = new System.Windows.Forms.Label();
            this.subtitleBusinessSoftwares2 = new System.Windows.Forms.Label();
            this.returnMenuButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleBusinessSoftwares
            // 
            this.titleBusinessSoftwares.AutoSize = true;
            this.titleBusinessSoftwares.Location = new System.Drawing.Point(35, 43);
            this.titleBusinessSoftwares.Name = "titleBusinessSoftwares";
            this.titleBusinessSoftwares.Size = new System.Drawing.Size(179, 20);
            this.titleBusinessSoftwares.TabIndex = 0;
            this.titleBusinessSoftwares.Text = "Define business softwares";
            // 
            // subtitleBusinessSoftwares1
            // 
            this.subtitleBusinessSoftwares1.AutoSize = true;
            this.subtitleBusinessSoftwares1.Location = new System.Drawing.Point(35, 78);
            this.subtitleBusinessSoftwares1.Name = "subtitleBusinessSoftwares1";
            this.subtitleBusinessSoftwares1.Size = new System.Drawing.Size(141, 20);
            this.subtitleBusinessSoftwares1.TabIndex = 1;
            this.subtitleBusinessSoftwares1.Text = "If they are detected,";
            // 
            // subtitleBusinessSoftwares2
            // 
            this.subtitleBusinessSoftwares2.AutoSize = true;
            this.subtitleBusinessSoftwares2.Location = new System.Drawing.Point(35, 98);
            this.subtitleBusinessSoftwares2.Name = "subtitleBusinessSoftwares2";
            this.subtitleBusinessSoftwares2.Size = new System.Drawing.Size(250, 20);
            this.subtitleBusinessSoftwares2.TabIndex = 2;
            this.subtitleBusinessSoftwares2.Text = "you will not be able to run a backup.";
            // 
            // returnMenuButton
            // 
            this.returnMenuButton.Location = new System.Drawing.Point(263, 459);
            this.returnMenuButton.Name = "returnMenuButton";
            this.returnMenuButton.Size = new System.Drawing.Size(175, 29);
            this.returnMenuButton.TabIndex = 3;
            this.returnMenuButton.Text = "Main menu";
            this.returnMenuButton.UseVisualStyleBackColor = true;
            this.returnMenuButton.Click += new System.EventHandler(this.returnMenuButton_Click);
            // 
            // BusinessSoftwaresSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.returnMenuButton);
            this.Controls.Add(this.subtitleBusinessSoftwares2);
            this.Controls.Add(this.subtitleBusinessSoftwares1);
            this.Controls.Add(this.titleBusinessSoftwares);
            this.Name = "BusinessSoftwaresSettings";
            this.Size = new System.Drawing.Size(450, 500);
            this.Load += new System.EventHandler(this.BusinessSoftwaresSettings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleBusinessSoftwares;
        private System.Windows.Forms.Label subtitleBusinessSoftwares1;
        private System.Windows.Forms.Label subtitleBusinessSoftwares2;
        private System.Windows.Forms.Button returnMenuButton;
    }
}
