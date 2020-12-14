
namespace EasySave.Views.BetterViews.Components
{
    partial class RunMultipleBackups
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.RunMultipleBackupsLabel = new System.Windows.Forms.Label();
            this.EnvironmentList = new System.Windows.Forms.ListView();
            this.EnvironmentColumn = new System.Windows.Forms.ColumnHeader();
            this.TypeColumn = new System.Windows.Forms.ColumnHeader();
            this.RunMultipleBackupsButton = new System.Windows.Forms.Button();
            this.NoBackupRadio = new System.Windows.Forms.RadioButton();
            this.FullBackupRadio = new System.Windows.Forms.RadioButton();
            this.DifferentialBackupRadio = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.195572F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.67528F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.Controls.Add(this.RunMultipleBackupsLabel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.EnvironmentList, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.RunMultipleBackupsButton, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.NoBackupRadio, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.FullBackupRadio, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.DifferentialBackupRadio, 3, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1084, 772);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // RunMultipleBackupsLabel
            // 
            this.RunMultipleBackupsLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RunMultipleBackupsLabel.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.RunMultipleBackupsLabel, 3);
            this.RunMultipleBackupsLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RunMultipleBackupsLabel.Location = new System.Drawing.Point(337, 69);
            this.RunMultipleBackupsLabel.Name = "RunMultipleBackupsLabel";
            this.RunMultipleBackupsLabel.Size = new System.Drawing.Size(407, 54);
            this.RunMultipleBackupsLabel.TabIndex = 0;
            this.RunMultipleBackupsLabel.Text = "Run multiple backups";
            // 
            // EnvironmentList
            // 
            this.EnvironmentList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.EnvironmentColumn,
            this.TypeColumn});
            this.EnvironmentList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EnvironmentList.HideSelection = false;
            this.EnvironmentList.Location = new System.Drawing.Point(165, 196);
            this.EnvironmentList.Name = "EnvironmentList";
            this.tableLayoutPanel1.SetRowSpan(this.EnvironmentList, 4);
            this.EnvironmentList.Size = new System.Drawing.Size(373, 454);
            this.EnvironmentList.TabIndex = 1;
            this.EnvironmentList.UseCompatibleStateImageBehavior = false;
            this.EnvironmentList.View = System.Windows.Forms.View.Details;
            this.EnvironmentList.SelectedIndexChanged += new System.EventHandler(this.EnvironmentList_SelectedIndexChanged);
            // 
            // EnvironmentColumn
            // 
            this.EnvironmentColumn.Text = "Environment";
            this.EnvironmentColumn.Width = 200;
            // 
            // TypeColumn
            // 
            this.TypeColumn.Text = "Type";
            this.TypeColumn.Width = 150;
            // 
            // RunMultipleBackupsButton
            // 
            this.RunMultipleBackupsButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.SetColumnSpan(this.RunMultipleBackupsButton, 2);
            this.RunMultipleBackupsButton.Location = new System.Drawing.Point(655, 565);
            this.RunMultipleBackupsButton.Name = "RunMultipleBackupsButton";
            this.RunMultipleBackupsButton.Size = new System.Drawing.Size(150, 60);
            this.RunMultipleBackupsButton.TabIndex = 2;
            this.RunMultipleBackupsButton.Text = "Run all backups";
            this.RunMultipleBackupsButton.UseVisualStyleBackColor = true;
            this.RunMultipleBackupsButton.Click += new System.EventHandler(this.RunMultipleBackupsButton_Click);
            // 
            // NoBackupRadio
            // 
            this.NoBackupRadio.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.NoBackupRadio.AutoSize = true;
            this.NoBackupRadio.Location = new System.Drawing.Point(622, 238);
            this.NoBackupRadio.Name = "NoBackupRadio";
            this.NoBackupRadio.Size = new System.Drawing.Size(102, 24);
            this.NoBackupRadio.TabIndex = 3;
            this.NoBackupRadio.TabStop = true;
            this.NoBackupRadio.Text = "No backup";
            this.NoBackupRadio.UseVisualStyleBackColor = true;
            this.NoBackupRadio.CheckedChanged += new System.EventHandler(this.NoBackupRadio_CheckedChanged);
            // 
            // FullBackupRadio
            // 
            this.FullBackupRadio.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.FullBackupRadio.AutoSize = true;
            this.FullBackupRadio.Location = new System.Drawing.Point(622, 353);
            this.FullBackupRadio.Name = "FullBackupRadio";
            this.FullBackupRadio.Size = new System.Drawing.Size(105, 24);
            this.FullBackupRadio.TabIndex = 4;
            this.FullBackupRadio.TabStop = true;
            this.FullBackupRadio.Text = "Full backup";
            this.FullBackupRadio.UseVisualStyleBackColor = true;
            this.FullBackupRadio.CheckedChanged += new System.EventHandler(this.FullBackupRadio_CheckedChanged);
            // 
            // DifferentialBackupRadio
            // 
            this.DifferentialBackupRadio.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.DifferentialBackupRadio.AutoSize = true;
            this.DifferentialBackupRadio.Enabled = false;
            this.DifferentialBackupRadio.Location = new System.Drawing.Point(622, 468);
            this.DifferentialBackupRadio.Name = "DifferentialBackupRadio";
            this.DifferentialBackupRadio.Size = new System.Drawing.Size(157, 24);
            this.DifferentialBackupRadio.TabIndex = 5;
            this.DifferentialBackupRadio.TabStop = true;
            this.DifferentialBackupRadio.Text = "Differential backup";
            this.DifferentialBackupRadio.UseVisualStyleBackColor = true;
            this.DifferentialBackupRadio.CheckedChanged += new System.EventHandler(this.DifferentialBackupRadio_CheckedChanged);
            // 
            // RunMultipleBackups
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "RunMultipleBackups";
            this.Size = new System.Drawing.Size(1084, 772);
            this.Load += new System.EventHandler(this.RunMultipleBackups_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label RunMultipleBackupsLabel;
        private System.Windows.Forms.ListView EnvironmentList;
        private System.Windows.Forms.Button RunMultipleBackupsButton;
        private System.Windows.Forms.RadioButton NoBackupRadio;
        private System.Windows.Forms.RadioButton FullBackupRadio;
        private System.Windows.Forms.RadioButton DifferentialBackupRadio;
        private System.Windows.Forms.ColumnHeader EnvironmentColumn;
        private System.Windows.Forms.ColumnHeader TypeColumn;
    }
}
