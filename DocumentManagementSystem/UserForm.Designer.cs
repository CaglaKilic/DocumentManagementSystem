namespace DocumentManagementSystem
{
    partial class UserForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxFileID = new System.Windows.Forms.TextBox();
            this.textBoxUserID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboboxFileName = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.textboxFeedback = new System.Windows.Forms.RichTextBox();
            this.textboxSubject = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelProfile = new System.Windows.Forms.Label();
            this.labelFilePath = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgv_Document = new System.Windows.Forms.DataGridView();
            this.fileIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fileNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filePathDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fileCreationDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableDOCUMENTBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dMSProjectDataSet9 = new DocumentManagementSystem.DMSProjectDataSet9();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.exit_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.dMSProjectDataSet5 = new DocumentManagementSystem.DMSProjectDataSet5();
            this.tableDOCUMENTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.table_DOCUMENTTableAdapter = new DocumentManagementSystem.DMSProjectDataSet5TableAdapters.Table_DOCUMENTTableAdapter();
            this.table_DOCUMENTTableAdapter1 = new DocumentManagementSystem.DMSProjectDataSet9TableAdapters.Table_DOCUMENTTableAdapter();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Document)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableDOCUMENTBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dMSProjectDataSet9)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dMSProjectDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableDOCUMENTBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.textBoxFileID);
            this.panel1.Controls.Add(this.textBoxUserID);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.comboboxFileName);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.buttonSave);
            this.panel1.Controls.Add(this.textboxFeedback);
            this.panel1.Controls.Add(this.textboxSubject);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.labelProfile);
            this.panel1.Controls.Add(this.labelFilePath);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.dgv_Document);
            this.panel1.Controls.Add(this.buttonSearch);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.shapeContainer1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1370, 726);
            this.panel1.TabIndex = 1;
            // 
            // textBoxFileID
            // 
            this.textBoxFileID.BackColor = System.Drawing.Color.Khaki;
            this.textBoxFileID.Font = new System.Drawing.Font("Consolas", 12F);
            this.textBoxFileID.ForeColor = System.Drawing.Color.Black;
            this.textBoxFileID.Location = new System.Drawing.Point(1169, 282);
            this.textBoxFileID.Multiline = true;
            this.textBoxFileID.Name = "textBoxFileID";
            this.textBoxFileID.ReadOnly = true;
            this.textBoxFileID.Size = new System.Drawing.Size(79, 30);
            this.textBoxFileID.TabIndex = 245;
            // 
            // textBoxUserID
            // 
            this.textBoxUserID.BackColor = System.Drawing.Color.Khaki;
            this.textBoxUserID.Font = new System.Drawing.Font("Consolas", 12F);
            this.textBoxUserID.ForeColor = System.Drawing.Color.Black;
            this.textBoxUserID.Location = new System.Drawing.Point(1080, 282);
            this.textBoxUserID.Multiline = true;
            this.textBoxUserID.Name = "textBoxUserID";
            this.textBoxUserID.ReadOnly = true;
            this.textBoxUserID.Size = new System.Drawing.Size(83, 30);
            this.textBoxUserID.TabIndex = 244;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(1165, 256);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 23);
            this.label7.TabIndex = 243;
            this.label7.Text = "FILE ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(1076, 256);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 23);
            this.label6.TabIndex = 241;
            this.label6.Text = "USER ID";
            // 
            // comboboxFileName
            // 
            this.comboboxFileName.Font = new System.Drawing.Font("Consolas", 12F);
            this.comboboxFileName.ForeColor = System.Drawing.Color.DimGray;
            this.comboboxFileName.FormattingEnabled = true;
            this.comboboxFileName.Location = new System.Drawing.Point(370, 282);
            this.comboboxFileName.Name = "comboboxFileName";
            this.comboboxFileName.Size = new System.Drawing.Size(168, 27);
            this.comboboxFileName.TabIndex = 239;
            this.comboboxFileName.Text = "filename.pdf";
            this.comboboxFileName.SelectedIndexChanged += new System.EventHandler(this.comboboxFileName_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(837, 321);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 23);
            this.label5.TabIndex = 238;
            this.label5.Text = "FEEDBACK";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(837, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 23);
            this.label3.TabIndex = 237;
            this.label3.Text = "SUBJECT";
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.Transparent;
            this.buttonSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonSave.BackgroundImage")));
            this.buttonSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonSave.FlatAppearance.BorderSize = 0;
            this.buttonSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Location = new System.Drawing.Point(1223, 601);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(68, 68);
            this.buttonSave.TabIndex = 236;
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // textboxFeedback
            // 
            this.textboxFeedback.Font = new System.Drawing.Font("Consolas", 12F);
            this.textboxFeedback.ForeColor = System.Drawing.Color.Black;
            this.textboxFeedback.Location = new System.Drawing.Point(841, 347);
            this.textboxFeedback.Name = "textboxFeedback";
            this.textboxFeedback.Size = new System.Drawing.Size(450, 248);
            this.textboxFeedback.TabIndex = 9;
            this.textboxFeedback.Text = "";
            // 
            // textboxSubject
            // 
            this.textboxSubject.Font = new System.Drawing.Font("Consolas", 12F);
            this.textboxSubject.ForeColor = System.Drawing.Color.Black;
            this.textboxSubject.Location = new System.Drawing.Point(841, 282);
            this.textboxSubject.Multiline = true;
            this.textboxSubject.Name = "textboxSubject";
            this.textboxSubject.Size = new System.Drawing.Size(233, 30);
            this.textboxSubject.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(807, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(517, 25);
            this.label2.TabIndex = 235;
            this.label2.Text = "~~~~~~~~~~~~~WRITE FEEDBACK~~~~~~~~~~~~~";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(7, 95);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(65, 65);
            this.pictureBox1.TabIndex = 234;
            this.pictureBox1.TabStop = false;
            // 
            // labelProfile
            // 
            this.labelProfile.AutoSize = true;
            this.labelProfile.BackColor = System.Drawing.Color.Transparent;
            this.labelProfile.Font = new System.Drawing.Font("Berlin Sans FB", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProfile.ForeColor = System.Drawing.Color.YellowGreen;
            this.labelProfile.Location = new System.Drawing.Point(75, 112);
            this.labelProfile.Name = "labelProfile";
            this.labelProfile.Size = new System.Drawing.Size(0, 32);
            this.labelProfile.TabIndex = 233;
            // 
            // labelFilePath
            // 
            this.labelFilePath.AutoSize = true;
            this.labelFilePath.Location = new System.Drawing.Point(367, 250);
            this.labelFilePath.Name = "labelFilePath";
            this.labelFilePath.Size = new System.Drawing.Size(0, 13);
            this.labelFilePath.TabIndex = 232;
            this.labelFilePath.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(50, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(554, 25);
            this.label4.TabIndex = 231;
            this.label4.Text = "~~~~~~~~~~~~~SEARCH DOCUMENT~~~~~~~~~~~~~";
            // 
            // dgv_Document
            // 
            this.dgv_Document.AutoGenerateColumns = false;
            this.dgv_Document.BackgroundColor = System.Drawing.Color.Wheat;
            this.dgv_Document.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_Document.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Document.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fileIDDataGridViewTextBoxColumn,
            this.fileNameDataGridViewTextBoxColumn,
            this.filePathDataGridViewTextBoxColumn,
            this.fileCreationDateDataGridViewTextBoxColumn,
            this.uIDDataGridViewTextBoxColumn});
            this.dgv_Document.DataSource = this.tableDOCUMENTBindingSource1;
            this.dgv_Document.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.dgv_Document.Location = new System.Drawing.Point(30, 324);
            this.dgv_Document.Name = "dgv_Document";
            this.dgv_Document.Size = new System.Drawing.Size(593, 271);
            this.dgv_Document.TabIndex = 230;
            this.dgv_Document.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Document_CellClick);
            // 
            // fileIDDataGridViewTextBoxColumn
            // 
            this.fileIDDataGridViewTextBoxColumn.DataPropertyName = "file_ID";
            this.fileIDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.fileIDDataGridViewTextBoxColumn.Name = "fileIDDataGridViewTextBoxColumn";
            this.fileIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.fileIDDataGridViewTextBoxColumn.Width = 50;
            // 
            // fileNameDataGridViewTextBoxColumn
            // 
            this.fileNameDataGridViewTextBoxColumn.DataPropertyName = "file_Name";
            this.fileNameDataGridViewTextBoxColumn.HeaderText = "FILE NAME";
            this.fileNameDataGridViewTextBoxColumn.Name = "fileNameDataGridViewTextBoxColumn";
            // 
            // filePathDataGridViewTextBoxColumn
            // 
            this.filePathDataGridViewTextBoxColumn.DataPropertyName = "file_Path";
            this.filePathDataGridViewTextBoxColumn.HeaderText = "FILE PATH";
            this.filePathDataGridViewTextBoxColumn.Name = "filePathDataGridViewTextBoxColumn";
            this.filePathDataGridViewTextBoxColumn.Width = 150;
            // 
            // fileCreationDateDataGridViewTextBoxColumn
            // 
            this.fileCreationDateDataGridViewTextBoxColumn.DataPropertyName = "file_CreationDate";
            this.fileCreationDateDataGridViewTextBoxColumn.HeaderText = "CREATION DATE";
            this.fileCreationDateDataGridViewTextBoxColumn.Name = "fileCreationDateDataGridViewTextBoxColumn";
            this.fileCreationDateDataGridViewTextBoxColumn.Width = 150;
            // 
            // uIDDataGridViewTextBoxColumn
            // 
            this.uIDDataGridViewTextBoxColumn.DataPropertyName = "u_ID";
            this.uIDDataGridViewTextBoxColumn.HeaderText = "USER ID";
            this.uIDDataGridViewTextBoxColumn.Name = "uIDDataGridViewTextBoxColumn";
            // 
            // tableDOCUMENTBindingSource1
            // 
            this.tableDOCUMENTBindingSource1.DataMember = "Table_DOCUMENT";
            this.tableDOCUMENTBindingSource1.DataSource = this.dMSProjectDataSet9;
            // 
            // dMSProjectDataSet9
            // 
            this.dMSProjectDataSet9.DataSetName = "DMSProjectDataSet9";
            this.dMSProjectDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.Transparent;
            this.buttonSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonSearch.BackgroundImage")));
            this.buttonSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonSearch.FlatAppearance.BorderSize = 0;
            this.buttonSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearch.Location = new System.Drawing.Point(555, 250);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(68, 68);
            this.buttonSearch.TabIndex = 229;
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearchSearch_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.buttonRefresh);
            this.panel2.Controls.Add(this.exit_btn);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1370, 83);
            this.panel2.TabIndex = 1;
            // 
            // exit_btn
            // 
            this.exit_btn.BackColor = System.Drawing.Color.Transparent;
            this.exit_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exit_btn.BackgroundImage")));
            this.exit_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.exit_btn.FlatAppearance.BorderSize = 0;
            this.exit_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.exit_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.exit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_btn.Location = new System.Drawing.Point(1294, 6);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(64, 74);
            this.exit_btn.TabIndex = 243;
            this.exit_btn.UseVisualStyleBackColor = false;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Berlin Sans FB Demi", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1370, 83);
            this.label1.TabIndex = 7;
            this.label1.Text = "DOCUMENT MANAGEMENT SYSTEM";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(1370, 726);
            this.shapeContainer1.TabIndex = 2;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lineShape1.BorderWidth = 5;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.SelectionColor = System.Drawing.SystemColors.MenuHighlight;
            this.lineShape1.X1 = -1;
            this.lineShape1.X2 = 1372;
            this.lineShape1.Y1 = 86;
            this.lineShape1.Y2 = 86;
            // 
            // dMSProjectDataSet5
            // 
            this.dMSProjectDataSet5.DataSetName = "DMSProjectDataSet5";
            this.dMSProjectDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableDOCUMENTBindingSource
            // 
            this.tableDOCUMENTBindingSource.DataMember = "Table_DOCUMENT";
            this.tableDOCUMENTBindingSource.DataSource = this.dMSProjectDataSet5;
            // 
            // table_DOCUMENTTableAdapter
            // 
            this.table_DOCUMENTTableAdapter.ClearBeforeFill = true;
            // 
            // table_DOCUMENTTableAdapter1
            // 
            this.table_DOCUMENTTableAdapter1.ClearBeforeFill = true;
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.BackColor = System.Drawing.Color.Transparent;
            this.buttonRefresh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonRefresh.BackgroundImage")));
            this.buttonRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonRefresh.FlatAppearance.BorderSize = 0;
            this.buttonRefresh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonRefresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.buttonRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRefresh.Location = new System.Drawing.Point(7, 6);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(44, 38);
            this.buttonRefresh.TabIndex = 246;
            this.buttonRefresh.UseVisualStyleBackColor = false;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1370, 726);
            this.Controls.Add(this.panel1);
            this.Name = "UserForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.UserForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Document)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableDOCUMENTBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dMSProjectDataSet9)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dMSProjectDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableDOCUMENTBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.DataGridView dgv_Document;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelFilePath;
        private System.Windows.Forms.Label labelProfile;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox textboxFeedback;
        private System.Windows.Forms.TextBox textboxSubject;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboboxFileName;
        private System.Windows.Forms.Button exit_btn;
        private DMSProjectDataSet5 dMSProjectDataSet5;
        private System.Windows.Forms.BindingSource tableDOCUMENTBindingSource;
        private DMSProjectDataSet5TableAdapters.Table_DOCUMENTTableAdapter table_DOCUMENTTableAdapter;
        private DMSProjectDataSet9 dMSProjectDataSet9;
        private System.Windows.Forms.BindingSource tableDOCUMENTBindingSource1;
        private DMSProjectDataSet9TableAdapters.Table_DOCUMENTTableAdapter table_DOCUMENTTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fileIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fileNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn filePathDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fileCreationDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox textBoxFileID;
        private System.Windows.Forms.TextBox textBoxUserID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonRefresh;
    }
}