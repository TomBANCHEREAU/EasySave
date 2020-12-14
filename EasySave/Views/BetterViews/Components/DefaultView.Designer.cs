
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.DefaultViewLabel = new System.Windows.Forms.Label();
            this.DefaultViewImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.HomeImage)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DefaultViewImage)).BeginInit();
            this.SuspendLayout();
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.WelcomeLabel.AutoSize = true;
            this.WelcomeLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.WelcomeLabel.Location = new System.Drawing.Point(422, 69);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(185, 54);
            this.WelcomeLabel.TabIndex = 1;
            this.WelcomeLabel.Text = "Welcome";
            this.WelcomeLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // HomeImage
            // 
            this.HomeImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HomeImage.Location = new System.Drawing.Point(0, 0);
            this.HomeImage.Name = "HomeImage";
            this.HomeImage.Size = new System.Drawing.Size(1084, 772);
            this.HomeImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.HomeImage.TabIndex = 2;
            this.HomeImage.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.Controls.Add(this.WelcomeLabel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.DefaultViewLabel, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.DefaultViewImage, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1084, 772);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // DefaultViewLabel
            // 
            this.DefaultViewLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DefaultViewLabel.AutoSize = true;
            this.DefaultViewLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DefaultViewLabel.Location = new System.Drawing.Point(239, 719);
            this.DefaultViewLabel.Name = "DefaultViewLabel";
            this.DefaultViewLabel.Size = new System.Drawing.Size(551, 28);
            this.DefaultViewLabel.TabIndex = 3;
            this.DefaultViewLabel.Text = "To begin with, create an environment and select one in the list.";
            this.DefaultViewLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // DefaultViewImage
            // 
            this.DefaultViewImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DefaultViewImage.Image = ((System.Drawing.Image)(resources.GetObject("DefaultViewImage.Image")));
            this.DefaultViewImage.Location = new System.Drawing.Point(111, 196);
            this.DefaultViewImage.Name = "DefaultViewImage";
            this.DefaultViewImage.Size = new System.Drawing.Size(807, 495);
            this.DefaultViewImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.DefaultViewImage.TabIndex = 4;
            this.DefaultViewImage.TabStop = false;
            // 
            // DefaultView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.HomeImage);
            this.Name = "DefaultView";
            this.Size = new System.Drawing.Size(1084, 772);
            this.Load += new System.EventHandler(this.DefaultView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.HomeImage)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DefaultViewImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label WelcomeLabel;
        private System.Windows.Forms.PictureBox HomeImage;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label DefaultViewLabel;
        private System.Windows.Forms.PictureBox DefaultViewImage;
    }
}
