
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
            this.input = new System.Windows.Forms.TextBox();
            this.add = new System.Windows.Forms.Button();
            this.remove = new System.Windows.Forms.Button();
            this.processesList = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // titleBusinessSoftwares
            // 
            this.titleBusinessSoftwares.AutoSize = true;
            this.titleBusinessSoftwares.Location = new System.Drawing.Point(35, 30);
            this.titleBusinessSoftwares.Name = "titleBusinessSoftwares";
            this.titleBusinessSoftwares.Size = new System.Drawing.Size(179, 20);
            this.titleBusinessSoftwares.TabIndex = 0;
            this.titleBusinessSoftwares.Text = "Define business softwares";
            // 
            // subtitleBusinessSoftwares1
            // 
            this.subtitleBusinessSoftwares1.AutoSize = true;
            this.subtitleBusinessSoftwares1.Location = new System.Drawing.Point(35, 63);
            this.subtitleBusinessSoftwares1.Name = "subtitleBusinessSoftwares1";
            this.subtitleBusinessSoftwares1.Size = new System.Drawing.Size(141, 20);
            this.subtitleBusinessSoftwares1.TabIndex = 1;
            this.subtitleBusinessSoftwares1.Text = "If they are detected,";
            // 
            // subtitleBusinessSoftwares2
            // 
            this.subtitleBusinessSoftwares2.AutoSize = true;
            this.subtitleBusinessSoftwares2.Location = new System.Drawing.Point(35, 83);
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
            // input
            // 
            this.input.Location = new System.Drawing.Point(35, 112);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(114, 27);
            this.input.TabIndex = 4;
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(157, 112);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(86, 31);
            this.add.TabIndex = 5;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // remove
            // 
            this.remove.Location = new System.Drawing.Point(249, 112);
            this.remove.Name = "remove";
            this.remove.Size = new System.Drawing.Size(86, 31);
            this.remove.TabIndex = 6;
            this.remove.Text = "Remove";
            this.remove.UseVisualStyleBackColor = true;
            this.remove.Click += new System.EventHandler(this.remove_Click);
            // 
            // processesList
            // 
            this.processesList.HideSelection = false;
            this.processesList.Location = new System.Drawing.Point(35, 151);
            this.processesList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.processesList.Name = "processesList";
            this.processesList.Size = new System.Drawing.Size(299, 212);
            this.processesList.TabIndex = 7;
            this.processesList.UseCompatibleStateImageBehavior = false;
            this.processesList.View = System.Windows.Forms.View.List;
            // 
            // BusinessSoftwaresSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.processesList);
            this.Controls.Add(this.remove);
            this.Controls.Add(this.add);
            this.Controls.Add(this.input);
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
        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button remove;
        private System.Windows.Forms.ListView processesList;
    }
}
