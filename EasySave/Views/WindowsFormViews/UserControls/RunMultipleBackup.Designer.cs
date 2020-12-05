
namespace EasySave.Views.WindowsFormViews.UserControls
{
    partial class RunMultipleBackup
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
            this.button1 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.fullBackup = new System.Windows.Forms.RadioButton();
            this.differentialBackup = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(263, 459);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "Main menu";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(8, 67);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(241, 425);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(315, 67);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(81, 39);
            this.button2.TabIndex = 2;
            this.button2.Text = "Select";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 3;
            // 
            // fullBackup
            // 
            this.fullBackup.AutoSize = true;
            this.fullBackup.Location = new System.Drawing.Point(289, 152);
            this.fullBackup.Name = "fullBackup";
            this.fullBackup.Size = new System.Drawing.Size(105, 24);
            this.fullBackup.TabIndex = 4;
            this.fullBackup.TabStop = true;
            this.fullBackup.Text = "Full Backup";
            this.fullBackup.UseVisualStyleBackColor = true;
            // 
            // differentialBackup
            // 
            this.differentialBackup.AutoSize = true;
            this.differentialBackup.Location = new System.Drawing.Point(289, 210);
            this.differentialBackup.Name = "differentialBackup";
            this.differentialBackup.Size = new System.Drawing.Size(157, 24);
            this.differentialBackup.TabIndex = 5;
            this.differentialBackup.TabStop = true;
            this.differentialBackup.Text = "Differential Backup";
            this.differentialBackup.UseVisualStyleBackColor = true;
            // 
            // RunMultipleBackup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.differentialBackup);
            this.Controls.Add(this.fullBackup);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button1);
            this.Name = "RunMultipleBackup";
            this.Size = new System.Drawing.Size(450, 500);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton fullBackup;
        private System.Windows.Forms.RadioButton differentialBackup;
    }
}
