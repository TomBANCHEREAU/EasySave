﻿
namespace EasySave.Views.WindowsFormViews.UserControls
{
    partial class RunBackup
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
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.chooseBackupLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.executeBackup = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(124, 167);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(53, 24);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.Text = "Full";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(124, 213);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(105, 24);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.Text = "Differential";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // chooseBackupLabel
            // 
            this.chooseBackupLabel.AutoSize = true;
            this.chooseBackupLabel.Location = new System.Drawing.Point(56, 132);
            this.chooseBackupLabel.Name = "chooseBackupLabel";
            this.chooseBackupLabel.Size = new System.Drawing.Size(117, 20);
            this.chooseBackupLabel.TabIndex = 3;
            this.chooseBackupLabel.Text = "Choose backup :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(247, 417);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 29);
            this.button1.TabIndex = 4;
            this.button1.Text = "Main menu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // executeBackup
            // 
            this.executeBackup.Enabled = false;
            this.executeBackup.Location = new System.Drawing.Point(105, 277);
            this.executeBackup.Name = "executeBackup";
            this.executeBackup.Size = new System.Drawing.Size(195, 33);
            this.executeBackup.TabIndex = 5;
            this.executeBackup.Text = "Run backup";
            this.executeBackup.UseVisualStyleBackColor = true;
            this.executeBackup.Click += new System.EventHandler(this.executeBackup_Click);
            // 
            // RunBackup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.executeBackup);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chooseBackupLabel);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Name = "RunBackup";
            this.Size = new System.Drawing.Size(399, 475);
            this.Load += new System.EventHandler(this.runBackup_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label chooseBackupLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button executeBackup;
    }
}
