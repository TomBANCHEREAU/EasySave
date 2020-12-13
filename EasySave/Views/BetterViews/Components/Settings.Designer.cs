
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.LanguagesLabel = new System.Windows.Forms.Label();
            this.FRButton = new System.Windows.Forms.Button();
            this.UKButton = new System.Windows.Forms.Button();
            this.HelpLabel = new System.Windows.Forms.Label();
            this.HelpButton = new System.Windows.Forms.Button();
            this.SettingsLabel = new System.Windows.Forms.Label();
            this.SettingsButton = new System.Windows.Forms.Button();
            this.RunMultipleBackupsLabel = new System.Windows.Forms.Label();
            this.RunMutipleBackupsButton = new System.Windows.Forms.Button();
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
            this.tableLayoutPanel1.Controls.Add(this.LanguagesLabel, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.FRButton, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.UKButton, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.HelpLabel, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.HelpButton, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.SettingsLabel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.SettingsButton, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.RunMultipleBackupsLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.RunMutipleBackupsButton, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1058, 126);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // LanguagesLabel
            // 
            this.LanguagesLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.LanguagesLabel.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.LanguagesLabel, 2);
            this.LanguagesLabel.Location = new System.Drawing.Point(805, 24);
            this.LanguagesLabel.Name = "LanguagesLabel";
            this.LanguagesLabel.Size = new System.Drawing.Size(80, 20);
            this.LanguagesLabel.TabIndex = 0;
            this.LanguagesLabel.Text = "Languages";
            // 
            // FRButton
            // 
            this.FRButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FRButton.Image = ((System.Drawing.Image)(resources.GetObject("FRButton.Image")));
            this.FRButton.Location = new System.Drawing.Point(902, 55);
            this.FRButton.Name = "FRButton";
            this.FRButton.Size = new System.Drawing.Size(98, 60);
            this.FRButton.TabIndex = 6;
            this.FRButton.UseVisualStyleBackColor = true;
            // 
            // UKButton
            // 
            this.UKButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UKButton.Image = ((System.Drawing.Image)(resources.GetObject("UKButton.Image")));
            this.UKButton.Location = new System.Drawing.Point(675, 55);
            this.UKButton.Name = "UKButton";
            this.UKButton.Size = new System.Drawing.Size(127, 60);
            this.UKButton.TabIndex = 5;
            this.UKButton.UseVisualStyleBackColor = true;
            // 
            // HelpLabel
            // 
            this.HelpLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.HelpLabel.AutoSize = true;
            this.HelpLabel.Location = new System.Drawing.Point(507, 24);
            this.HelpLabel.Name = "HelpLabel";
            this.HelpLabel.Size = new System.Drawing.Size(41, 20);
            this.HelpLabel.TabIndex = 2;
            this.HelpLabel.Text = "Help";
            // 
            // HelpButton
            // 
            this.HelpButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.HelpButton.Image = ((System.Drawing.Image)(resources.GetObject("HelpButton.Image")));
            this.HelpButton.Location = new System.Drawing.Point(495, 55);
            this.HelpButton.Name = "HelpButton";
            this.HelpButton.Size = new System.Drawing.Size(65, 60);
            this.HelpButton.TabIndex = 4;
            this.HelpButton.UseVisualStyleBackColor = true;
            // 
            // SettingsLabel
            // 
            this.SettingsLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.SettingsLabel.AutoSize = true;
            this.SettingsLabel.Location = new System.Drawing.Point(285, 24);
            this.SettingsLabel.Name = "SettingsLabel";
            this.SettingsLabel.Size = new System.Drawing.Size(62, 20);
            this.SettingsLabel.TabIndex = 1;
            this.SettingsLabel.Text = "Settings";
            // 
            // SettingsButton
            // 
            this.SettingsButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SettingsButton.Image = ((System.Drawing.Image)(resources.GetObject("SettingsButton.Image")));
            this.SettingsButton.Location = new System.Drawing.Point(284, 55);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(65, 60);
            this.SettingsButton.TabIndex = 3;
            this.SettingsButton.UseVisualStyleBackColor = true;
            // 
            // RunMultipleBackupsLabel
            // 
            this.RunMultipleBackupsLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.RunMultipleBackupsLabel.AutoSize = true;
            this.RunMultipleBackupsLabel.Location = new System.Drawing.Point(30, 24);
            this.RunMultipleBackupsLabel.Name = "RunMultipleBackupsLabel";
            this.RunMultipleBackupsLabel.Size = new System.Drawing.Size(151, 20);
            this.RunMultipleBackupsLabel.TabIndex = 7;
            this.RunMultipleBackupsLabel.Text = "Run multiple backups";
            // 
            // RunMutipleBackupsButton
            // 
            this.RunMutipleBackupsButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RunMutipleBackupsButton.Image = ((System.Drawing.Image)(resources.GetObject("RunMutipleBackupsButton.Image")));
            this.RunMutipleBackupsButton.Location = new System.Drawing.Point(65, 55);
            this.RunMutipleBackupsButton.Name = "RunMutipleBackupsButton";
            this.RunMutipleBackupsButton.Size = new System.Drawing.Size(80, 60);
            this.RunMutipleBackupsButton.TabIndex = 8;
            this.RunMutipleBackupsButton.UseVisualStyleBackColor = true;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Settings";
            this.Size = new System.Drawing.Size(1058, 126);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label LanguagesLabel;
        private System.Windows.Forms.Label SettingsLabel;
        private System.Windows.Forms.Label HelpLabel;
        private System.Windows.Forms.Button SettingsButton;
        private System.Windows.Forms.Button HelpButton;
        private System.Windows.Forms.Button UKButton;
        private System.Windows.Forms.Button FRButton;
        private System.Windows.Forms.Label RunMultipleBackupsLabel;
        private System.Windows.Forms.Button RunMutipleBackupsButton;
    }
}
