
namespace EasySave.Views.BetterViews.Components
{
    partial class CreateEnvironment
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
            this.CreateEnvironmentLabel = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.SourceDirectoryTextBox = new System.Windows.Forms.TextBox();
            this.DestinationDirectoryTextBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.CreateButton = new System.Windows.Forms.Button();
            this.DestinationDirectoryLabel = new System.Windows.Forms.Label();
            this.SourceDirectoryLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.DestinationDirectoryExplorer = new System.Windows.Forms.Button();
            this.SourceDirectoryExplorer = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CreateEnvironmentLabel
            // 
            this.CreateEnvironmentLabel.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.CreateEnvironmentLabel, 2);
            this.CreateEnvironmentLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CreateEnvironmentLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CreateEnvironmentLabel.Location = new System.Drawing.Point(357, 0);
            this.CreateEnvironmentLabel.Name = "CreateEnvironmentLabel";
            this.CreateEnvironmentLabel.Size = new System.Drawing.Size(466, 193);
            this.CreateEnvironmentLabel.TabIndex = 0;
            this.CreateEnvironmentLabel.Text = "Create a backup environment";
            this.CreateEnvironmentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NameTextBox
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.NameTextBox, 2);
            this.NameTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NameTextBox.Location = new System.Drawing.Point(357, 234);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(466, 27);
            this.NameTextBox.TabIndex = 4;
            // 
            // SourceDirectoryTextBox
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.SourceDirectoryTextBox, 2);
            this.SourceDirectoryTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SourceDirectoryTextBox.Location = new System.Drawing.Point(357, 349);
            this.SourceDirectoryTextBox.Name = "SourceDirectoryTextBox";
            this.SourceDirectoryTextBox.ReadOnly = true;
            this.SourceDirectoryTextBox.Size = new System.Drawing.Size(466, 27);
            this.SourceDirectoryTextBox.TabIndex = 5;
            // 
            // DestinationDirectoryTextBox
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.DestinationDirectoryTextBox, 2);
            this.DestinationDirectoryTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DestinationDirectoryTextBox.Location = new System.Drawing.Point(357, 464);
            this.DestinationDirectoryTextBox.Name = "DestinationDirectoryTextBox";
            this.DestinationDirectoryTextBox.ReadOnly = true;
            this.DestinationDirectoryTextBox.Size = new System.Drawing.Size(466, 27);
            this.DestinationDirectoryTextBox.TabIndex = 6;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.Controls.Add(this.SourceDirectoryTextBox, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.DestinationDirectoryTextBox, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.CreateButton, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.DestinationDirectoryLabel, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.SourceDirectoryLabel, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.NameLabel, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.NameTextBox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.DestinationDirectoryExplorer, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.SourceDirectoryExplorer, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.CreateEnvironmentLabel, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1182, 772);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // CreateButton
            // 
            this.CreateButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.SetColumnSpan(this.CreateButton, 2);
            this.CreateButton.Location = new System.Drawing.Point(515, 570);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(150, 51);
            this.CreateButton.TabIndex = 7;
            this.CreateButton.Text = "Create";
            this.CreateButton.UseVisualStyleBackColor = true;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // DestinationDirectoryLabel
            // 
            this.DestinationDirectoryLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DestinationDirectoryLabel.AutoSize = true;
            this.DestinationDirectoryLabel.Location = new System.Drawing.Point(357, 441);
            this.DestinationDirectoryLabel.Name = "DestinationDirectoryLabel";
            this.DestinationDirectoryLabel.Size = new System.Drawing.Size(148, 20);
            this.DestinationDirectoryLabel.TabIndex = 3;
            this.DestinationDirectoryLabel.Text = "Destination directory";
            // 
            // SourceDirectoryLabel
            // 
            this.SourceDirectoryLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SourceDirectoryLabel.AutoSize = true;
            this.SourceDirectoryLabel.Location = new System.Drawing.Point(357, 326);
            this.SourceDirectoryLabel.Name = "SourceDirectoryLabel";
            this.SourceDirectoryLabel.Size = new System.Drawing.Size(117, 20);
            this.SourceDirectoryLabel.TabIndex = 2;
            this.SourceDirectoryLabel.Text = "Source directory";
            // 
            // NameLabel
            // 
            this.NameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(357, 211);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(49, 20);
            this.NameLabel.TabIndex = 1;
            this.NameLabel.Text = "Name";
            // 
            // DestinationDirectoryExplorer
            // 
            this.DestinationDirectoryExplorer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DestinationDirectoryExplorer.Location = new System.Drawing.Point(751, 430);
            this.DestinationDirectoryExplorer.Name = "DestinationDirectoryExplorer";
            this.DestinationDirectoryExplorer.Size = new System.Drawing.Size(72, 28);
            this.DestinationDirectoryExplorer.TabIndex = 9;
            this.DestinationDirectoryExplorer.Text = "...";
            this.DestinationDirectoryExplorer.UseVisualStyleBackColor = true;
            this.DestinationDirectoryExplorer.Click += new System.EventHandler(this.DestinationDirectoryExplorer_Click);
            // 
            // SourceDirectoryExplorer
            // 
            this.SourceDirectoryExplorer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SourceDirectoryExplorer.Location = new System.Drawing.Point(751, 315);
            this.SourceDirectoryExplorer.Name = "SourceDirectoryExplorer";
            this.SourceDirectoryExplorer.Size = new System.Drawing.Size(72, 28);
            this.SourceDirectoryExplorer.TabIndex = 8;
            this.SourceDirectoryExplorer.Text = "...";
            this.SourceDirectoryExplorer.UseVisualStyleBackColor = true;
            this.SourceDirectoryExplorer.Click += new System.EventHandler(this.SourceDirectoryExplorer_Click);
            // 
            // CreateEnvironment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "CreateEnvironment";
            this.Size = new System.Drawing.Size(1182, 772);
            this.Load += new System.EventHandler(this.CreateEnvironment_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label CreateEnvironmentLabel;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox SourceDirectoryTextBox;
        private System.Windows.Forms.TextBox DestinationDirectoryTextBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button SourceDirectoryExplorer;
        private System.Windows.Forms.Button DestinationDirectoryExplorer;
        private System.Windows.Forms.Button CreateButton;
        private System.Windows.Forms.Label DestinationDirectoryLabel;
        private System.Windows.Forms.Label SourceDirectoryLabel;
        private System.Windows.Forms.Label NameLabel;
    }
}
