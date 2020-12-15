
namespace EasySave.Views.BetterViews.Components
{
    partial class SettingsMenu
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
            this.CryptLabel = new System.Windows.Forms.Label();
            this.PriorityLabel = new System.Windows.Forms.Label();
            this.BusinessSoftwareLabel = new System.Windows.Forms.Label();
            this.LimitSizeLabel = new System.Windows.Forms.Label();
            this.CryptInput = new System.Windows.Forms.TextBox();
            this.PriorityInput = new System.Windows.Forms.TextBox();
            this.BusinessSoftwareInput = new System.Windows.Forms.TextBox();
            this.CryptAdd = new System.Windows.Forms.Button();
            this.CryptRemove = new System.Windows.Forms.Button();
            this.PriorityAdd = new System.Windows.Forms.Button();
            this.PriorityRemove = new System.Windows.Forms.Button();
            this.BusinessSoftwareAdd = new System.Windows.Forms.Button();
            this.BusinessSoftwareRemove = new System.Windows.Forms.Button();
            this.LimitSizeConfirm = new System.Windows.Forms.Button();
            this.CryptListView = new System.Windows.Forms.ListView();
            this.PriorityListView = new System.Windows.Forms.ListView();
            this.BusinessSoftwareListView = new System.Windows.Forms.ListView();
            this.Ko100 = new System.Windows.Forms.RadioButton();
            this.Ko500 = new System.Windows.Forms.RadioButton();
            this.Ko1000 = new System.Windows.Forms.RadioButton();
            this.Ko10000 = new System.Windows.Forms.RadioButton();
            this.KoMax = new System.Windows.Forms.RadioButton();
            this.KoInput = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KoInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 13;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.5F));
            this.tableLayoutPanel1.Controls.Add(this.CryptLabel, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.PriorityLabel, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.BusinessSoftwareLabel, 7, 1);
            this.tableLayoutPanel1.Controls.Add(this.LimitSizeLabel, 10, 1);
            this.tableLayoutPanel1.Controls.Add(this.CryptInput, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.PriorityInput, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.BusinessSoftwareInput, 7, 2);
            this.tableLayoutPanel1.Controls.Add(this.CryptAdd, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.CryptRemove, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.PriorityAdd, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.PriorityRemove, 5, 3);
            this.tableLayoutPanel1.Controls.Add(this.BusinessSoftwareAdd, 7, 3);
            this.tableLayoutPanel1.Controls.Add(this.BusinessSoftwareRemove, 8, 3);
            this.tableLayoutPanel1.Controls.Add(this.LimitSizeConfirm, 10, 3);
            this.tableLayoutPanel1.Controls.Add(this.CryptListView, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.PriorityListView, 4, 4);
            this.tableLayoutPanel1.Controls.Add(this.BusinessSoftwareListView, 7, 4);
            this.tableLayoutPanel1.Controls.Add(this.Ko100, 10, 4);
            this.tableLayoutPanel1.Controls.Add(this.Ko500, 10, 5);
            this.tableLayoutPanel1.Controls.Add(this.Ko1000, 10, 6);
            this.tableLayoutPanel1.Controls.Add(this.Ko10000, 10, 7);
            this.tableLayoutPanel1.Controls.Add(this.KoMax, 10, 8);
            this.tableLayoutPanel1.Controls.Add(this.KoInput, 10, 9);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 12;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1182, 772);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // CryptLabel
            // 
            this.CryptLabel.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.CryptLabel, 2);
            this.CryptLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CryptLabel.Location = new System.Drawing.Point(32, 38);
            this.CryptLabel.Name = "CryptLabel";
            this.CryptLabel.Size = new System.Drawing.Size(229, 84);
            this.CryptLabel.TabIndex = 0;
            this.CryptLabel.Text = "Choose the extensions of the files that will be encrypted.";
            this.CryptLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PriorityLabel
            // 
            this.PriorityLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PriorityLabel.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.PriorityLabel, 2);
            this.PriorityLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PriorityLabel.Location = new System.Drawing.Point(327, 38);
            this.PriorityLabel.Name = "PriorityLabel";
            this.PriorityLabel.Size = new System.Drawing.Size(229, 84);
            this.PriorityLabel.TabIndex = 1;
            this.PriorityLabel.Text = "Choose the extensions of the files that will have an high priority.";
            this.PriorityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BusinessSoftwareLabel
            // 
            this.BusinessSoftwareLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BusinessSoftwareLabel.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.BusinessSoftwareLabel, 2);
            this.BusinessSoftwareLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BusinessSoftwareLabel.Location = new System.Drawing.Point(623, 38);
            this.BusinessSoftwareLabel.Name = "BusinessSoftwareLabel";
            this.BusinessSoftwareLabel.Size = new System.Drawing.Size(227, 112);
            this.BusinessSoftwareLabel.TabIndex = 2;
            this.BusinessSoftwareLabel.Text = "Choose the business software that will disable the backup execution if they are d" +
    "etected";
            this.BusinessSoftwareLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LimitSizeLabel
            // 
            this.LimitSizeLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LimitSizeLabel.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.LimitSizeLabel, 2);
            this.LimitSizeLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LimitSizeLabel.Location = new System.Drawing.Point(925, 38);
            this.LimitSizeLabel.Name = "LimitSizeLabel";
            this.LimitSizeLabel.Size = new System.Drawing.Size(214, 84);
            this.LimitSizeLabel.TabIndex = 3;
            this.LimitSizeLabel.Text = "Choose the limit size of files for simultaneous transfert.";
            this.LimitSizeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CryptInput
            // 
            this.CryptInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.CryptInput, 2);
            this.CryptInput.Location = new System.Drawing.Point(39, 198);
            this.CryptInput.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.CryptInput.Name = "CryptInput";
            this.CryptInput.Size = new System.Drawing.Size(216, 27);
            this.CryptInput.TabIndex = 4;
            // 
            // PriorityInput
            // 
            this.PriorityInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.PriorityInput, 2);
            this.PriorityInput.Location = new System.Drawing.Point(334, 198);
            this.PriorityInput.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.PriorityInput.Name = "PriorityInput";
            this.PriorityInput.Size = new System.Drawing.Size(216, 27);
            this.PriorityInput.TabIndex = 5;
            // 
            // BusinessSoftwareInput
            // 
            this.BusinessSoftwareInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.BusinessSoftwareInput, 2);
            this.BusinessSoftwareInput.Location = new System.Drawing.Point(629, 198);
            this.BusinessSoftwareInput.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.BusinessSoftwareInput.Name = "BusinessSoftwareInput";
            this.BusinessSoftwareInput.Size = new System.Drawing.Size(216, 27);
            this.BusinessSoftwareInput.TabIndex = 6;
            // 
            // CryptAdd
            // 
            this.CryptAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CryptAdd.Location = new System.Drawing.Point(39, 235);
            this.CryptAdd.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.CryptAdd.Name = "CryptAdd";
            this.CryptAdd.Size = new System.Drawing.Size(98, 28);
            this.CryptAdd.TabIndex = 7;
            this.CryptAdd.Text = "Add";
            this.CryptAdd.UseVisualStyleBackColor = true;
            this.CryptAdd.Click += new System.EventHandler(this.CryptAdd_Click);
            // 
            // CryptRemove
            // 
            this.CryptRemove.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CryptRemove.Location = new System.Drawing.Point(157, 235);
            this.CryptRemove.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.CryptRemove.Name = "CryptRemove";
            this.CryptRemove.Size = new System.Drawing.Size(98, 28);
            this.CryptRemove.TabIndex = 8;
            this.CryptRemove.Text = "Remove";
            this.CryptRemove.UseVisualStyleBackColor = true;
            this.CryptRemove.Click += new System.EventHandler(this.CryptRemove_Click);
            // 
            // PriorityAdd
            // 
            this.PriorityAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PriorityAdd.Location = new System.Drawing.Point(334, 235);
            this.PriorityAdd.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.PriorityAdd.Name = "PriorityAdd";
            this.PriorityAdd.Size = new System.Drawing.Size(98, 28);
            this.PriorityAdd.TabIndex = 9;
            this.PriorityAdd.Text = "Add";
            this.PriorityAdd.UseVisualStyleBackColor = true;
            this.PriorityAdd.Click += new System.EventHandler(this.PriorityAdd_Click);
            // 
            // PriorityRemove
            // 
            this.PriorityRemove.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PriorityRemove.Location = new System.Drawing.Point(452, 235);
            this.PriorityRemove.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.PriorityRemove.Name = "PriorityRemove";
            this.PriorityRemove.Size = new System.Drawing.Size(98, 28);
            this.PriorityRemove.TabIndex = 10;
            this.PriorityRemove.Text = "Remove";
            this.PriorityRemove.UseVisualStyleBackColor = true;
            this.PriorityRemove.Click += new System.EventHandler(this.PriorityRemove_Click);
            // 
            // BusinessSoftwareAdd
            // 
            this.BusinessSoftwareAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BusinessSoftwareAdd.Location = new System.Drawing.Point(629, 235);
            this.BusinessSoftwareAdd.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.BusinessSoftwareAdd.Name = "BusinessSoftwareAdd";
            this.BusinessSoftwareAdd.Size = new System.Drawing.Size(98, 28);
            this.BusinessSoftwareAdd.TabIndex = 11;
            this.BusinessSoftwareAdd.Text = "Add";
            this.BusinessSoftwareAdd.UseVisualStyleBackColor = true;
            this.BusinessSoftwareAdd.Click += new System.EventHandler(this.BusinessSoftwareAdd_Click);
            // 
            // BusinessSoftwareRemove
            // 
            this.BusinessSoftwareRemove.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BusinessSoftwareRemove.Location = new System.Drawing.Point(747, 235);
            this.BusinessSoftwareRemove.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.BusinessSoftwareRemove.Name = "BusinessSoftwareRemove";
            this.BusinessSoftwareRemove.Size = new System.Drawing.Size(98, 28);
            this.BusinessSoftwareRemove.TabIndex = 12;
            this.BusinessSoftwareRemove.Text = "Remove";
            this.BusinessSoftwareRemove.UseVisualStyleBackColor = true;
            this.BusinessSoftwareRemove.Click += new System.EventHandler(this.BusinessSoftwareRemove_Click);
            // 
            // LimitSizeConfirm
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.LimitSizeConfirm, 2);
            this.LimitSizeConfirm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LimitSizeConfirm.Enabled = false;
            this.LimitSizeConfirm.Location = new System.Drawing.Point(924, 235);
            this.LimitSizeConfirm.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.LimitSizeConfirm.Name = "LimitSizeConfirm";
            this.LimitSizeConfirm.Size = new System.Drawing.Size(216, 28);
            this.LimitSizeConfirm.TabIndex = 13;
            this.LimitSizeConfirm.Text = "Confirm";
            this.LimitSizeConfirm.UseVisualStyleBackColor = true;
            this.LimitSizeConfirm.Click += new System.EventHandler(this.LimitSizeConfirm_Click);
            // 
            // CryptListView
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.CryptListView, 2);
            this.CryptListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CryptListView.HideSelection = false;
            this.CryptListView.Location = new System.Drawing.Point(39, 273);
            this.CryptListView.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.CryptListView.Name = "CryptListView";
            this.tableLayoutPanel1.SetRowSpan(this.CryptListView, 7);
            this.CryptListView.Size = new System.Drawing.Size(216, 295);
            this.CryptListView.TabIndex = 14;
            this.CryptListView.UseCompatibleStateImageBehavior = false;
            this.CryptListView.View = System.Windows.Forms.View.List;
            // 
            // PriorityListView
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.PriorityListView, 2);
            this.PriorityListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PriorityListView.HideSelection = false;
            this.PriorityListView.Location = new System.Drawing.Point(334, 273);
            this.PriorityListView.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.PriorityListView.Name = "PriorityListView";
            this.tableLayoutPanel1.SetRowSpan(this.PriorityListView, 7);
            this.PriorityListView.Size = new System.Drawing.Size(216, 295);
            this.PriorityListView.TabIndex = 15;
            this.PriorityListView.UseCompatibleStateImageBehavior = false;
            this.PriorityListView.View = System.Windows.Forms.View.List;
            // 
            // BusinessSoftwareListView
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.BusinessSoftwareListView, 2);
            this.BusinessSoftwareListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BusinessSoftwareListView.HideSelection = false;
            this.BusinessSoftwareListView.Location = new System.Drawing.Point(629, 273);
            this.BusinessSoftwareListView.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.BusinessSoftwareListView.Name = "BusinessSoftwareListView";
            this.tableLayoutPanel1.SetRowSpan(this.BusinessSoftwareListView, 7);
            this.BusinessSoftwareListView.Size = new System.Drawing.Size(216, 295);
            this.BusinessSoftwareListView.TabIndex = 16;
            this.BusinessSoftwareListView.UseCompatibleStateImageBehavior = false;
            this.BusinessSoftwareListView.View = System.Windows.Forms.View.List;
            // 
            // Ko100
            // 
            this.Ko100.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Ko100.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.Ko100, 2);
            this.Ko100.Location = new System.Drawing.Point(994, 275);
            this.Ko100.Name = "Ko100";
            this.Ko100.Size = new System.Drawing.Size(76, 24);
            this.Ko100.TabIndex = 17;
            this.Ko100.TabStop = true;
            this.Ko100.Text = "100 Ko";
            this.Ko100.UseVisualStyleBackColor = true;
            // 
            // Ko500
            // 
            this.Ko500.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Ko500.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.Ko500, 2);
            this.Ko500.Location = new System.Drawing.Point(994, 313);
            this.Ko500.Name = "Ko500";
            this.Ko500.Size = new System.Drawing.Size(76, 24);
            this.Ko500.TabIndex = 18;
            this.Ko500.TabStop = true;
            this.Ko500.Text = "500 Ko";
            this.Ko500.UseVisualStyleBackColor = true;
            // 
            // Ko1000
            // 
            this.Ko1000.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Ko1000.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.Ko1000, 2);
            this.Ko1000.Location = new System.Drawing.Point(988, 351);
            this.Ko1000.Name = "Ko1000";
            this.Ko1000.Size = new System.Drawing.Size(87, 24);
            this.Ko1000.TabIndex = 19;
            this.Ko1000.TabStop = true;
            this.Ko1000.Text = "1.000 Ko";
            this.Ko1000.UseVisualStyleBackColor = true;
            // 
            // Ko10000
            // 
            this.Ko10000.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Ko10000.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.Ko10000, 2);
            this.Ko10000.Location = new System.Drawing.Point(984, 389);
            this.Ko10000.Name = "Ko10000";
            this.Ko10000.Size = new System.Drawing.Size(95, 24);
            this.Ko10000.TabIndex = 20;
            this.Ko10000.TabStop = true;
            this.Ko10000.Text = "10.000 Ko";
            this.Ko10000.UseVisualStyleBackColor = true;
            // 
            // KoMax
            // 
            this.KoMax.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.KoMax.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.KoMax, 2);
            this.KoMax.Location = new System.Drawing.Point(957, 427);
            this.KoMax.Name = "KoMax";
            this.KoMax.Size = new System.Drawing.Size(149, 24);
            this.KoMax.TabIndex = 21;
            this.KoMax.TabStop = true;
            this.KoMax.Text = "Choose maximum";
            this.KoMax.UseVisualStyleBackColor = true;
            // 
            // KoInput
            // 
            this.KoInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.KoInput, 2);
            this.KoInput.Enabled = false;
            this.KoInput.Location = new System.Drawing.Point(924, 463);
            this.KoInput.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.KoInput.Maximum = new decimal(new int[] {
            -727379968,
            232,
            0,
            0});
            this.KoInput.Name = "KoInput";
            this.KoInput.Size = new System.Drawing.Size(216, 27);
            this.KoInput.TabIndex = 22;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(0, 0);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 27);
            this.numericUpDown1.TabIndex = 22;
            // 
            // SettingsMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "SettingsMenu";
            this.Size = new System.Drawing.Size(1182, 772);
            this.Load += new System.EventHandler(this.SettingsMenu_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KoInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label CryptLabel;
        private System.Windows.Forms.Label PriorityLabel;
        private System.Windows.Forms.Label BusinessSoftwareLabel;
        private System.Windows.Forms.Label LimitSizeLabel;
        private System.Windows.Forms.TextBox CryptInput;
        private System.Windows.Forms.TextBox PriorityInput;
        private System.Windows.Forms.TextBox BusinessSoftwareInput;
        private System.Windows.Forms.Button CryptAdd;
        private System.Windows.Forms.Button CryptRemove;
        private System.Windows.Forms.Button PriorityAdd;
        private System.Windows.Forms.Button PriorityRemove;
        private System.Windows.Forms.Button BusinessSoftwareAdd;
        private System.Windows.Forms.Button BusinessSoftwareRemove;
        private System.Windows.Forms.Button LimitSizeConfirm;
        private System.Windows.Forms.ListView CryptListView;
        private System.Windows.Forms.ListView PriorityListView;
        private System.Windows.Forms.ListView BusinessSoftwareListView;
        private System.Windows.Forms.RadioButton Ko100;
        private System.Windows.Forms.RadioButton Ko500;
        private System.Windows.Forms.RadioButton Ko1000;
        private System.Windows.Forms.RadioButton Ko10000;
        private System.Windows.Forms.RadioButton KoMax;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown KoInput;
    }
}
