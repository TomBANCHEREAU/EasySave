
namespace EasySave.Views.BetterViews.Components
{
    partial class Settings
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
            this.FRButton = new System.Windows.Forms.Button();
            this.UKButton = new System.Windows.Forms.Button();
            this.RunMutipleBackupsButton = new System.Windows.Forms.Button();
            this.SettingsButton = new System.Windows.Forms.Button();
            this.HelpButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.FRButton, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.UKButton, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.RunMutipleBackupsButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.SettingsButton, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.HelpButton, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(926, 94);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // FRButton
            // 
            this.FRButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.FRButton.Location = new System.Drawing.Point(758, 24);
            this.FRButton.Margin = new System.Windows.Forms.Padding(18, 2, 3, 2);
            this.FRButton.Name = "FRButton";
            this.FRButton.Size = new System.Drawing.Size(105, 45);
            this.FRButton.TabIndex = 6;
            this.FRButton.Text = "French";
            this.FRButton.UseVisualStyleBackColor = true;
            // 
            // UKButton
            // 
            this.UKButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.UKButton.Location = new System.Drawing.Point(617, 24);
            this.UKButton.Margin = new System.Windows.Forms.Padding(3, 2, 18, 2);
            this.UKButton.Name = "UKButton";
            this.UKButton.Size = new System.Drawing.Size(105, 45);
            this.UKButton.TabIndex = 5;
            this.UKButton.Text = "English";
            this.UKButton.UseVisualStyleBackColor = true;
            // 
            // RunMutipleBackupsButton
            // 
            this.RunMutipleBackupsButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RunMutipleBackupsButton.Location = new System.Drawing.Point(40, 24);
            this.RunMutipleBackupsButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RunMutipleBackupsButton.Name = "RunMutipleBackupsButton";
            this.RunMutipleBackupsButton.Size = new System.Drawing.Size(105, 45);
            this.RunMutipleBackupsButton.TabIndex = 8;
            this.RunMutipleBackupsButton.Text = "Run multiple backups";
            this.RunMutipleBackupsButton.UseVisualStyleBackColor = true;
            this.RunMutipleBackupsButton.Click += new System.EventHandler(this.RunMutipleBackupsButton_Click);
            // 
            // SettingsButton
            // 
            this.SettingsButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SettingsButton.Location = new System.Drawing.Point(225, 24);
            this.SettingsButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(105, 45);
            this.SettingsButton.TabIndex = 3;
            this.SettingsButton.Text = "Settings";
            this.SettingsButton.UseVisualStyleBackColor = true;
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // HelpButton
            // 
            this.HelpButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.HelpButton.Location = new System.Drawing.Point(410, 24);
            this.HelpButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HelpButton.Name = "HelpButton";
            this.HelpButton.Size = new System.Drawing.Size(105, 45);
            this.HelpButton.TabIndex = 4;
            this.HelpButton.Text = "Help";
            this.HelpButton.UseVisualStyleBackColor = true;
            this.HelpButton.Click += new System.EventHandler(this.HelpButton_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Settings";
            this.Size = new System.Drawing.Size(926, 94);
            this.Load += new System.EventHandler(this.Settings_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button SettingsButton;
        private System.Windows.Forms.Button HelpButton;
        private System.Windows.Forms.Button UKButton;
        private System.Windows.Forms.Button FRButton;
        private System.Windows.Forms.Button RunMutipleBackupsButton;
    }
}
