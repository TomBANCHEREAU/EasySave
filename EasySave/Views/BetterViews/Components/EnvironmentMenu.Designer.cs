﻿
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
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.EnvironmentMenuLabel = new System.Windows.Forms.Label();
            this.RestoreButton = new System.Windows.Forms.Button();
            this.FullBackupButton = new System.Windows.Forms.Button();
            this.DifferentialBackupButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.Controls.Add(this.EnvironmentMenuLabel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.FullBackupButton, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.DifferentialBackupButton, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.RestoreButton, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.DeleteButton, 2, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1084, 772);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // EnvironmentMenuLabel
            // 
            this.EnvironmentMenuLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EnvironmentMenuLabel.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.EnvironmentMenuLabel, 2);
            this.EnvironmentMenuLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EnvironmentMenuLabel.Location = new System.Drawing.Point(372, 69);
            this.EnvironmentMenuLabel.Name = "EnvironmentMenuLabel";
            this.EnvironmentMenuLabel.Size = new System.Drawing.Size(337, 54);
            this.EnvironmentMenuLabel.TabIndex = 0;
            this.EnvironmentMenuLabel.Text = "Choose an option";
            // 
            // RestoreButton
            // 
            this.RestoreButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RestoreButton.Enabled = false;
            this.RestoreButton.Location = new System.Drawing.Point(655, 470);
            this.RestoreButton.Name = "RestoreButton";
            this.RestoreButton.Size = new System.Drawing.Size(150, 60);
            this.RestoreButton.TabIndex = 3;
            this.RestoreButton.Text = "Restore a backup";
            this.RestoreButton.UseVisualStyleBackColor = true;
            // 
            // FullBackupButton
            // 
            this.FullBackupButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FullBackupButton.Location = new System.Drawing.Point(276, 278);
            this.FullBackupButton.Name = "FullBackupButton";
            this.FullBackupButton.Size = new System.Drawing.Size(150, 60);
            this.FullBackupButton.TabIndex = 1;
            this.FullBackupButton.Text = "Run a full backup";
            this.FullBackupButton.UseVisualStyleBackColor = true;
            // 
            // DifferentialBackupButton
            // 
            this.DifferentialBackupButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DifferentialBackupButton.Enabled = false;
            this.DifferentialBackupButton.Location = new System.Drawing.Point(276, 470);
            this.DifferentialBackupButton.Name = "DifferentialBackupButton";
            this.DifferentialBackupButton.Size = new System.Drawing.Size(150, 60);
            this.DifferentialBackupButton.TabIndex = 2;
            this.DifferentialBackupButton.Text = "Run a differential backup";
            this.DifferentialBackupButton.UseVisualStyleBackColor = true;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DeleteButton.Location = new System.Drawing.Point(655, 278);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(150, 60);
            this.DeleteButton.TabIndex = 4;
            this.DeleteButton.Text = "Delete the environment";
            this.DeleteButton.UseVisualStyleBackColor = true;
            // 
            // EnvironmentMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "EnvironmentMenu";
            this.Size = new System.Drawing.Size(1084, 772);
            this.Load += new System.EventHandler(this.EnvironmentMenu_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label EnvironmentMenuLabel;
        private System.Windows.Forms.Button FullBackupButton;
        private System.Windows.Forms.Button DifferentialBackupButton;
        private System.Windows.Forms.Button RestoreButton;
        private System.Windows.Forms.Button DeleteButton;
    }
}
