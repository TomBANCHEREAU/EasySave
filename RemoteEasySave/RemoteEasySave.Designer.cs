
namespace RemoteEasySave
{
    partial class RemoteEasySave
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listView1 = new System.Windows.Forms.ListView();
            this.EnvName = new System.Windows.Forms.ColumnHeader();
            this.EnvStatus = new System.Windows.Forms.ColumnHeader();
            this.EnvProgress = new System.Windows.Forms.ColumnHeader();
            this.t = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.pauseButton = new System.Windows.Forms.Button();
            this.resumeButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.RunFullButton = new System.Windows.Forms.Button();
            this.RunDiffButton = new System.Windows.Forms.Button();
            this.FRButton = new System.Windows.Forms.Button();
            this.UKButton = new System.Windows.Forms.Button();
            this.t.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.EnvName,
            this.EnvStatus,
            this.EnvProgress});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(2, 160);
            this.listView1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.t.SetRowSpan(this.listView1, 2);
            this.listView1.Size = new System.Drawing.Size(396, 288);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // EnvName
            // 
            this.EnvName.Text = "Name";
            this.EnvName.Width = 150;
            // 
            // EnvStatus
            // 
            this.EnvStatus.Text = "Status";
            this.EnvStatus.Width = 100;
            // 
            // EnvProgress
            // 
            this.EnvProgress.Text = "Progress";
            this.EnvProgress.Width = 100;
            // 
            // t
            // 
            this.t.ColumnCount = 2;
            this.t.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.t.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.t.Controls.Add(this.listView1, 0, 1);
            this.t.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.t.Controls.Add(this.label1, 0, 0);
            this.t.Controls.Add(this.tableLayoutPanel3, 1, 1);
            this.t.Dock = System.Windows.Forms.DockStyle.Fill;
            this.t.Location = new System.Drawing.Point(0, 0);
            this.t.Name = "t";
            this.t.RowCount = 1;
            this.t.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.t.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.t.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 0F));
            this.t.Size = new System.Drawing.Size(800, 451);
            this.t.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.pauseButton, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.resumeButton, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.cancelButton, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.progressBar1, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(403, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(394, 151);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // pauseButton
            // 
            this.pauseButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pauseButton.Location = new System.Drawing.Point(10, 20);
            this.pauseButton.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.pauseButton.Name = "pauseButton";
            this.pauseButton.Size = new System.Drawing.Size(111, 50);
            this.pauseButton.TabIndex = 0;
            this.pauseButton.Text = "Pause";
            this.pauseButton.UseVisualStyleBackColor = true;
            this.pauseButton.Click += new System.EventHandler(this.pauseButton_Click);
            // 
            // resumeButton
            // 
            this.resumeButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resumeButton.Location = new System.Drawing.Point(141, 20);
            this.resumeButton.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.resumeButton.Name = "resumeButton";
            this.resumeButton.Size = new System.Drawing.Size(111, 50);
            this.resumeButton.TabIndex = 1;
            this.resumeButton.Text = "Resume";
            this.resumeButton.UseVisualStyleBackColor = true;
            this.resumeButton.Click += new System.EventHandler(this.resumeButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.Location = new System.Drawing.Point(272, 20);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(112, 50);
            this.cancelButton.TabIndex = 2;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.SetColumnSpan(this.progressBar1, 3);
            this.progressBar1.Location = new System.Drawing.Point(10, 80);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(374, 49);
            this.progressBar1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(61, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 46);
            this.label1.TabIndex = 2;
            this.label1.Text = "EasySave Remote";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.RunFullButton, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.RunDiffButton, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.FRButton, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.UKButton, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(403, 161);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(394, 285);
            this.tableLayoutPanel3.TabIndex = 4;
            // 
            // RunFullButton
            // 
            this.RunFullButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RunFullButton.Location = new System.Drawing.Point(10, 5);
            this.RunFullButton.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.RunFullButton.Name = "RunFullButton";
            this.RunFullButton.Size = new System.Drawing.Size(177, 50);
            this.RunFullButton.TabIndex = 3;
            this.RunFullButton.Text = "Full backup";
            this.RunFullButton.UseVisualStyleBackColor = true;
            this.RunFullButton.Click += new System.EventHandler(this.RunFullButton_Click);
            // 
            // RunDiffButton
            // 
            this.RunDiffButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RunDiffButton.Location = new System.Drawing.Point(207, 5);
            this.RunDiffButton.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.RunDiffButton.Name = "RunDiffButton";
            this.RunDiffButton.Size = new System.Drawing.Size(177, 50);
            this.RunDiffButton.TabIndex = 4;
            this.RunDiffButton.Text = "Differential backup";
            this.RunDiffButton.UseVisualStyleBackColor = true;
            this.RunDiffButton.Click += new System.EventHandler(this.RunDiffButton_Click);
            // 
            // FRButton
            // 
            this.FRButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FRButton.Location = new System.Drawing.Point(207, 230);
            this.FRButton.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.FRButton.Name = "FRButton";
            this.FRButton.Size = new System.Drawing.Size(177, 50);
            this.FRButton.TabIndex = 6;
            this.FRButton.Text = "French";
            this.FRButton.UseVisualStyleBackColor = true;
            this.FRButton.Click += new System.EventHandler(this.FRButton_Click);
            // 
            // UKButton
            // 
            this.UKButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UKButton.Location = new System.Drawing.Point(10, 230);
            this.UKButton.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.UKButton.Name = "UKButton";
            this.UKButton.Size = new System.Drawing.Size(177, 50);
            this.UKButton.TabIndex = 5;
            this.UKButton.Text = "English";
            this.UKButton.UseVisualStyleBackColor = true;
            this.UKButton.Click += new System.EventHandler(this.UKButton_Click);
            // 
            // RemoteEasySave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 451);
            this.Controls.Add(this.t);
            this.Name = "RemoteEasySave";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.t.ResumeLayout(false);
            this.t.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader EnvName;
        private System.Windows.Forms.ColumnHeader EnvStatus;
        private System.Windows.Forms.ColumnHeader EnvProgress;
        private System.Windows.Forms.TableLayoutPanel UKBu;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button pauseButton;
        private System.Windows.Forms.Button resumeButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button RunFullButton;
        private System.Windows.Forms.Button RunDiffButton;
        private System.Windows.Forms.TableLayoutPanel t;
        private System.Windows.Forms.Button UKB;
        private System.Windows.Forms.Button FRButton;
        private System.Windows.Forms.Button UKButton;
    }
}

