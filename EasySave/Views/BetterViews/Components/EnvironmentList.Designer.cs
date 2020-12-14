﻿
namespace EasySave.Views.BetterViews.Components
{
    partial class EnvironmentList
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
            this.EnvList = new System.Windows.Forms.ListView();
            this.EnvName = new System.Windows.Forms.ColumnHeader();
            this.AddButton = new System.Windows.Forms.Button();
            this.SearchLabel = new System.Windows.Forms.Label();
            this.SearchInput = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.Controls.Add(this.EnvList, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.AddButton, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.SearchLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.SearchInput, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(378, 724);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // EnvList
            // 
            this.EnvList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.EnvName});
            this.tableLayoutPanel1.SetColumnSpan(this.EnvList, 2);
            this.EnvList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EnvList.FullRowSelect = true;
            this.EnvList.HideSelection = false;
            this.EnvList.Location = new System.Drawing.Point(3, 60);
            this.EnvList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.EnvList.MultiSelect = false;
            this.EnvList.Name = "EnvList";
            this.EnvList.Size = new System.Drawing.Size(372, 660);
            this.EnvList.TabIndex = 1;
            this.EnvList.UseCompatibleStateImageBehavior = false;
            this.EnvList.View = System.Windows.Forms.View.Details;
            this.EnvList.SelectedIndexChanged += new System.EventHandler(this.EnvList_SelectedIndexChanged);
            // 
            // EnvName
            // 
            this.EnvName.Text = "Name";
            this.EnvName.Width = 147;
            // 
            // AddButton
            // 
            this.AddButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddButton.Location = new System.Drawing.Point(154, 24);
            this.AddButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AddButton.MinimumSize = new System.Drawing.Size(183, 0);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(221, 28);
            this.AddButton.TabIndex = 3;
            this.AddButton.Text = "Create a new environment";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // SearchLabel
            // 
            this.SearchLabel.AutoSize = true;
            this.SearchLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SearchLabel.Location = new System.Drawing.Point(3, 0);
            this.SearchLabel.Name = "SearchLabel";
            this.SearchLabel.Size = new System.Drawing.Size(145, 20);
            this.SearchLabel.TabIndex = 4;
            this.SearchLabel.Text = "Search";
            // 
            // SearchInput
            // 
            this.SearchInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SearchInput.Location = new System.Drawing.Point(3, 24);
            this.SearchInput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SearchInput.Name = "SearchInput";
            this.SearchInput.Size = new System.Drawing.Size(145, 27);
            this.SearchInput.TabIndex = 5;
            this.SearchInput.TextChanged += new System.EventHandler(this.SearchInput_TextChanged);
            // 
            // EnvironmentList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "EnvironmentList";
            this.Size = new System.Drawing.Size(378, 724);
            this.Load += new System.EventHandler(this.EnvironmentList_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        public System.Windows.Forms.ListView EnvList;
        private System.Windows.Forms.ColumnHeader EnvName;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label SearchLabel;
        private System.Windows.Forms.TextBox SearchInput;
    }
}