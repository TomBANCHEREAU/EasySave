
namespace EasySave.Views.BetterViews.Components
{
    partial class EnvironmentMenu
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
            selected.OnStateChange -= this.startAndStop1.Backup_OnStateChange;
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.RestoreButton = new System.Windows.Forms.Button();
            this.BackupList = new System.Windows.Forms.ListView();
            this.BackupColumn = new System.Windows.Forms.ColumnHeader();
            this.TypeColumn = new System.Windows.Forms.ColumnHeader();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.FullBackupButton = new System.Windows.Forms.Button();
            this.DifferentialBackupButton = new System.Windows.Forms.Button();
            this.startAndStop1 = new EasySave.Views.BetterViews.Components.StartAndStop();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.EnvNameLabel = new System.Windows.Forms.Label();
            this.SourceLabel = new System.Windows.Forms.Label();
            this.DestinationLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.DeleteButton, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 19);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(942, 557);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteButton.Location = new System.Drawing.Point(742, 10);
            this.DeleteButton.Margin = new System.Windows.Forms.Padding(10);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(190, 25);
            this.DeleteButton.TabIndex = 4;
            this.DeleteButton.Text = "Delete this environment";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.RestoreButton, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.BackupList, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(474, 114);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(465, 440);
            this.tableLayoutPanel3.TabIndex = 8;
            // 
            // RestoreButton
            // 
            this.RestoreButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RestoreButton.Enabled = false;
            this.RestoreButton.Location = new System.Drawing.Point(167, 402);
            this.RestoreButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RestoreButton.Name = "RestoreButton";
            this.RestoreButton.Size = new System.Drawing.Size(131, 25);
            this.RestoreButton.TabIndex = 3;
            this.RestoreButton.Text = "Restore a backup";
            this.RestoreButton.UseVisualStyleBackColor = true;
            this.RestoreButton.Click += new System.EventHandler(this.RestoreButton_Click);
            // 
            // BackupList
            // 
            this.BackupList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.BackupColumn,
            this.TypeColumn});
            this.BackupList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BackupList.FullRowSelect = true;
            this.BackupList.HideSelection = false;
            this.BackupList.Location = new System.Drawing.Point(3, 2);
            this.BackupList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BackupList.Name = "BackupList";
            this.BackupList.Size = new System.Drawing.Size(459, 386);
            this.BackupList.TabIndex = 5;
            this.BackupList.UseCompatibleStateImageBehavior = false;
            this.BackupList.View = System.Windows.Forms.View.Details;
            this.BackupList.SelectedIndexChanged += new System.EventHandler(this.BackupList_SelectedIndexChanged);
            // 
            // BackupColumn
            // 
            this.BackupColumn.Tag = "";
            this.BackupColumn.Text = "Backup";
            this.BackupColumn.Width = 200;
            // 
            // TypeColumn
            // 
            this.TypeColumn.Text = "Type";
            this.TypeColumn.Width = 150;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.FullBackupButton, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.DifferentialBackupButton, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.startAndStop1, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 114);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(465, 440);
            this.tableLayoutPanel2.TabIndex = 7;
            // 
            // FullBackupButton
            // 
            this.FullBackupButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FullBackupButton.Location = new System.Drawing.Point(10, 10);
            this.FullBackupButton.Margin = new System.Windows.Forms.Padding(10);
            this.FullBackupButton.Name = "FullBackupButton";
            this.FullBackupButton.Size = new System.Drawing.Size(212, 30);
            this.FullBackupButton.TabIndex = 1;
            this.FullBackupButton.Text = "Run a full backup";
            this.FullBackupButton.UseVisualStyleBackColor = true;
            this.FullBackupButton.Click += new System.EventHandler(this.FullBackupButton_Click);
            // 
            // DifferentialBackupButton
            // 
            this.DifferentialBackupButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DifferentialBackupButton.Enabled = false;
            this.DifferentialBackupButton.Location = new System.Drawing.Point(242, 10);
            this.DifferentialBackupButton.Margin = new System.Windows.Forms.Padding(10);
            this.DifferentialBackupButton.Name = "DifferentialBackupButton";
            this.DifferentialBackupButton.Size = new System.Drawing.Size(213, 30);
            this.DifferentialBackupButton.TabIndex = 2;
            this.DifferentialBackupButton.Text = "Run a differential backup";
            this.DifferentialBackupButton.UseVisualStyleBackColor = true;
            this.DifferentialBackupButton.Click += new System.EventHandler(this.DifferentialBackupButton_Click);
            // 
            // startAndStop1
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.startAndStop1, 2);
            this.startAndStop1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.startAndStop1.Enabled = false;
            this.startAndStop1.Location = new System.Drawing.Point(3, 53);
            this.startAndStop1.Name = "startAndStop1";
            this.startAndStop1.Size = new System.Drawing.Size(459, 384);
            this.startAndStop1.TabIndex = 3;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.EnvNameLabel, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.SourceLabel, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.DestinationLabel, 0, 2);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 4;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(465, 105);
            this.tableLayoutPanel4.TabIndex = 9;
            // 
            // EnvNameLabel
            // 
            this.EnvNameLabel.AutoSize = true;
            this.EnvNameLabel.Location = new System.Drawing.Point(3, 0);
            this.EnvNameLabel.Name = "EnvNameLabel";
            this.EnvNameLabel.Size = new System.Drawing.Size(48, 15);
            this.EnvNameLabel.TabIndex = 0;
            this.EnvNameLabel.Text = "Name : ";
            // 
            // SourceLabel
            // 
            this.SourceLabel.AutoSize = true;
            this.SourceLabel.Location = new System.Drawing.Point(3, 26);
            this.SourceLabel.Name = "SourceLabel";
            this.SourceLabel.Size = new System.Drawing.Size(103, 15);
            this.SourceLabel.TabIndex = 1;
            this.SourceLabel.Text = "Source Directory : ";
            // 
            // DestinationLabel
            // 
            this.DestinationLabel.AutoSize = true;
            this.DestinationLabel.Location = new System.Drawing.Point(3, 52);
            this.DestinationLabel.Name = "DestinationLabel";
            this.DestinationLabel.Size = new System.Drawing.Size(127, 15);
            this.DestinationLabel.TabIndex = 2;
            this.DestinationLabel.Text = "Destination Directory : ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(948, 579);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Environment DashBoard";
            // 
            // EnvironmentMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "EnvironmentMenu";
            this.Size = new System.Drawing.Size(948, 579);
            this.Load += new System.EventHandler(this.EnvironmentMenu_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button FullBackupButton;
        private System.Windows.Forms.Button DifferentialBackupButton;
        private System.Windows.Forms.Button RestoreButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.ListView BackupList;
        private System.Windows.Forms.ColumnHeader BackupColumn;
        private System.Windows.Forms.ColumnHeader TypeColumn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private StartAndStop startAndStop1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label EnvNameLabel;
        private System.Windows.Forms.Label SourceLabel;
        private System.Windows.Forms.Label DestinationLabel;
    }
}
