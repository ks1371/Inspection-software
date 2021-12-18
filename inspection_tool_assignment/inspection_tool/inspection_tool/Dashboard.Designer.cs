namespace inspection_tool
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnInspections = new System.Windows.Forms.Button();
            this.btnSafetyForm = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.GeneralInfoForm = new System.Windows.Forms.Label();
            this.WorkingStandardsForm = new System.Windows.Forms.Label();
            this.QualityForm = new System.Windows.Forms.Label();
            this.SiteRulesForm = new System.Windows.Forms.Label();
            this.EnvironmentalForm = new System.Windows.Forms.Label();
            this.ProtectionForm = new System.Windows.Forms.Label();
            this.ToolsForm = new System.Windows.Forms.Label();
            this.MiscellaneousForm = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ImagePanel = new System.Windows.Forms.FlowLayoutPanel();
            this.AddPicture = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.ImageDialog = new System.Windows.Forms.OpenFileDialog();
            this.LogoBox = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.ImagePanel.SuspendLayout();
            this.AddPicture.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(151)))), ((int)(((byte)(221)))));
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.LogoBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1579, 113);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnLogout
            // 
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft YaHei", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(1446, 0);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(133, 113);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(104)))), ((int)(((byte)(105)))));
            this.panel2.Controls.Add(this.btnInspections);
            this.panel2.Controls.Add(this.btnSafetyForm);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(0, 113);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(240, 793);
            this.panel2.TabIndex = 2;
            // 
            // btnInspections
            // 
            this.btnInspections.FlatAppearance.BorderSize = 0;
            this.btnInspections.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInspections.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInspections.ForeColor = System.Drawing.Color.White;
            this.btnInspections.Location = new System.Drawing.Point(29, 165);
            this.btnInspections.Margin = new System.Windows.Forms.Padding(4);
            this.btnInspections.Name = "btnInspections";
            this.btnInspections.Size = new System.Drawing.Size(189, 37);
            this.btnInspections.TabIndex = 4;
            this.btnInspections.Text = "List of Inspections";
            this.btnInspections.UseVisualStyleBackColor = true;
            // 
            // btnSafetyForm
            // 
            this.btnSafetyForm.FlatAppearance.BorderSize = 0;
            this.btnSafetyForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSafetyForm.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSafetyForm.ForeColor = System.Drawing.Color.White;
            this.btnSafetyForm.Location = new System.Drawing.Point(29, 69);
            this.btnSafetyForm.Margin = new System.Windows.Forms.Padding(4);
            this.btnSafetyForm.Name = "btnSafetyForm";
            this.btnSafetyForm.Size = new System.Drawing.Size(140, 37);
            this.btnSafetyForm.TabIndex = 3;
            this.btnSafetyForm.Text = "Safety Audit";
            this.btnSafetyForm.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(16, 123);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 39);
            this.label2.TabIndex = 2;
            this.label2.Text = "Reports";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(16, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Forms";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Left;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.label3.Location = new System.Drawing.Point(111, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(0, 12, 0, 0);
            this.label3.Size = new System.Drawing.Size(1097, 78);
            this.label3.TabIndex = 3;
            this.label3.Text = "Health, Safety, Quality and Environmental  Site Inspection";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 107F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 1265F));
            this.tableLayoutPanel1.Controls.Add(this.label3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.GeneralInfoForm, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.WorkingStandardsForm, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.QualityForm, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.SiteRulesForm, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.EnvironmentalForm, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.ProtectionForm, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.ToolsForm, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.MiscellaneousForm, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.label4, 1, 10);
            this.tableLayoutPanel1.Controls.Add(this.ImagePanel, 1, 11);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(240, 113);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 12;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 78F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 155F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1339, 793);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // GeneralInfoForm
            // 
            this.GeneralInfoForm.AutoSize = true;
            this.GeneralInfoForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GeneralInfoForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(152)))), ((int)(((byte)(221)))));
            this.GeneralInfoForm.Location = new System.Drawing.Point(111, 78);
            this.GeneralInfoForm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GeneralInfoForm.Name = "GeneralInfoForm";
            this.GeneralInfoForm.Size = new System.Drawing.Size(1257, 57);
            this.GeneralInfoForm.TabIndex = 4;
            this.GeneralInfoForm.Text = "A. General Information";
            this.GeneralInfoForm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.GeneralInfoForm.Click += new System.EventHandler(this.GeneralInfoForm_Click);
            // 
            // WorkingStandardsForm
            // 
            this.WorkingStandardsForm.AutoSize = true;
            this.WorkingStandardsForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WorkingStandardsForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(152)))), ((int)(((byte)(221)))));
            this.WorkingStandardsForm.Location = new System.Drawing.Point(111, 135);
            this.WorkingStandardsForm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.WorkingStandardsForm.Name = "WorkingStandardsForm";
            this.WorkingStandardsForm.Size = new System.Drawing.Size(1257, 57);
            this.WorkingStandardsForm.TabIndex = 5;
            this.WorkingStandardsForm.Text = "B. Working Standards";
            this.WorkingStandardsForm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.WorkingStandardsForm.MouseClick += new System.Windows.Forms.MouseEventHandler(this.WorkingStandardsForm_MouseClick);
            // 
            // QualityForm
            // 
            this.QualityForm.AutoSize = true;
            this.QualityForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.QualityForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(152)))), ((int)(((byte)(221)))));
            this.QualityForm.Location = new System.Drawing.Point(111, 192);
            this.QualityForm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.QualityForm.Name = "QualityForm";
            this.QualityForm.Size = new System.Drawing.Size(1257, 57);
            this.QualityForm.TabIndex = 6;
            this.QualityForm.Text = "C. Quality";
            this.QualityForm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.QualityForm.MouseClick += new System.Windows.Forms.MouseEventHandler(this.QualityForm_Click);
            // 
            // SiteRulesForm
            // 
            this.SiteRulesForm.AutoSize = true;
            this.SiteRulesForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SiteRulesForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(152)))), ((int)(((byte)(221)))));
            this.SiteRulesForm.Location = new System.Drawing.Point(111, 249);
            this.SiteRulesForm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SiteRulesForm.Name = "SiteRulesForm";
            this.SiteRulesForm.Size = new System.Drawing.Size(1257, 57);
            this.SiteRulesForm.TabIndex = 7;
            this.SiteRulesForm.Text = "D. Site Rules";
            this.SiteRulesForm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SiteRulesForm.MouseClick += new System.Windows.Forms.MouseEventHandler(this.SiteRulesForm_MouseClick);
            // 
            // EnvironmentalForm
            // 
            this.EnvironmentalForm.AutoSize = true;
            this.EnvironmentalForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EnvironmentalForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(152)))), ((int)(((byte)(221)))));
            this.EnvironmentalForm.Location = new System.Drawing.Point(111, 306);
            this.EnvironmentalForm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EnvironmentalForm.Name = "EnvironmentalForm";
            this.EnvironmentalForm.Size = new System.Drawing.Size(1257, 57);
            this.EnvironmentalForm.TabIndex = 8;
            this.EnvironmentalForm.Text = "E. Environmental";
            this.EnvironmentalForm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ProtectionForm
            // 
            this.ProtectionForm.AutoSize = true;
            this.ProtectionForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProtectionForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(152)))), ((int)(((byte)(221)))));
            this.ProtectionForm.Location = new System.Drawing.Point(111, 363);
            this.ProtectionForm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ProtectionForm.Name = "ProtectionForm";
            this.ProtectionForm.Size = new System.Drawing.Size(1257, 57);
            this.ProtectionForm.TabIndex = 9;
            this.ProtectionForm.Text = "F. Protection of Individuals";
            this.ProtectionForm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ToolsForm
            // 
            this.ToolsForm.AutoSize = true;
            this.ToolsForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ToolsForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(152)))), ((int)(((byte)(221)))));
            this.ToolsForm.Location = new System.Drawing.Point(111, 420);
            this.ToolsForm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ToolsForm.Name = "ToolsForm";
            this.ToolsForm.Size = new System.Drawing.Size(1257, 57);
            this.ToolsForm.TabIndex = 10;
            this.ToolsForm.Text = "G. Tools, Cables and Other Equipment";
            this.ToolsForm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ToolsForm.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ToolsForm_MouseClick);
            // 
            // MiscellaneousForm
            // 
            this.MiscellaneousForm.AutoSize = true;
            this.MiscellaneousForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MiscellaneousForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(152)))), ((int)(((byte)(221)))));
            this.MiscellaneousForm.Location = new System.Drawing.Point(111, 477);
            this.MiscellaneousForm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MiscellaneousForm.Name = "MiscellaneousForm";
            this.MiscellaneousForm.Size = new System.Drawing.Size(1257, 57);
            this.MiscellaneousForm.TabIndex = 11;
            this.MiscellaneousForm.Text = "H. Miscellaneous";
            this.MiscellaneousForm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Left;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.label4.Location = new System.Drawing.Point(111, 578);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(0, 12, 0, 0);
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(102, 47);
            this.label4.TabIndex = 12;
            this.label4.Text = "Images";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ImagePanel
            // 
            this.ImagePanel.Controls.Add(this.AddPicture);
            this.ImagePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ImagePanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImagePanel.Location = new System.Drawing.Point(111, 629);
            this.ImagePanel.Margin = new System.Windows.Forms.Padding(4, 4, 7, 4);
            this.ImagePanel.Name = "ImagePanel";
            this.ImagePanel.Size = new System.Drawing.Size(1254, 160);
            this.ImagePanel.TabIndex = 13;
            // 
            // AddPicture
            // 
            this.AddPicture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.AddPicture.Controls.Add(this.label5);
            this.AddPicture.Location = new System.Drawing.Point(4, 4);
            this.AddPicture.Margin = new System.Windows.Forms.Padding(4, 4, 7, 4);
            this.AddPicture.Name = "AddPicture";
            this.AddPicture.Size = new System.Drawing.Size(167, 132);
            this.AddPicture.TabIndex = 0;
            this.AddPicture.Click += new System.EventHandler(this.AddPicture_Paint);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Enabled = false;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 44F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.label5.Location = new System.Drawing.Point(40, 23);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 85);
            this.label5.TabIndex = 0;
            this.label5.Text = "+";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ImageDialog
            // 
            this.ImageDialog.FileName = "ImageDialog";
            // 
            // LogoBox
            // 
            this.LogoBox.Image = global::inspection_tool.Properties.Resources.musk_white_logo;
            this.LogoBox.Location = new System.Drawing.Point(16, 15);
            this.LogoBox.Margin = new System.Windows.Forms.Padding(4);
            this.LogoBox.Name = "LogoBox";
            this.LogoBox.Size = new System.Drawing.Size(241, 81);
            this.LogoBox.TabIndex = 1;
            this.LogoBox.TabStop = false;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1579, 906);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboardcs";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ImagePanel.ResumeLayout(false);
            this.AddPicture.ResumeLayout(false);
            this.AddPicture.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.PictureBox LogoBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnInspections;
        private System.Windows.Forms.Button btnSafetyForm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label WorkingStandardsForm;
        private System.Windows.Forms.Label GeneralInfoForm;
        private System.Windows.Forms.Label QualityForm;
        private System.Windows.Forms.Label SiteRulesForm;
        private System.Windows.Forms.Label EnvironmentalForm;
        private System.Windows.Forms.Label ProtectionForm;
        private System.Windows.Forms.Label ToolsForm;
        private System.Windows.Forms.Label MiscellaneousForm;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.FlowLayoutPanel ImagePanel;
        private System.Windows.Forms.Panel AddPicture;
        private System.Windows.Forms.OpenFileDialog ImageDialog;
        private System.Windows.Forms.Label label5;
    }
}