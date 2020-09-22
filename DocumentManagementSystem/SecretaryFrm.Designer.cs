namespace DocumentManagementSystem
{
    partial class SecretaryFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SecretaryFrm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.listboxUsername = new System.Windows.Forms.ListBox();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.comboboxUserID = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rtextboxParagraph = new System.Windows.Forms.RichTextBox();
            this.textboxKeyword = new System.Windows.Forms.TextBox();
            this.textboxSubject = new System.Windows.Forms.TextBox();
            this.textboxCreator = new System.Windows.Forms.TextBox();
            this.textboxAuthor = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textboxFilePath = new System.Windows.Forms.TextBox();
            this.btn_Prepare = new System.Windows.Forms.Button();
            this.btn_Archieve = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textboxFileDate = new System.Windows.Forms.TextBox();
            this.textboxFileID = new System.Windows.Forms.TextBox();
            this.textboxFileName = new System.Windows.Forms.TextBox();
            this.btn_browse = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.fileIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fileNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filePathDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fileCreationDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableDOCUMENTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dMSProjectDataSet4 = new DocumentManagementSystem.DMSProjectDataSet4();
            this.panel2 = new System.Windows.Forms.Panel();
            this.exit_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.tableUSERINFOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dMSProjectDataSet6 = new DocumentManagementSystem.DMSProjectDataSet6();
            this.table_USERINFOTableAdapter = new DocumentManagementSystem.DMSProjectDataSet6TableAdapters.Table_USERINFOTableAdapter();
            this.table_DOCUMENTTableAdapter = new DocumentManagementSystem.DMSProjectDataSet4TableAdapters.Table_DOCUMENTTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelProfile = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableDOCUMENTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dMSProjectDataSet4)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableUSERINFOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dMSProjectDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.listboxUsername);
            this.panel1.Controls.Add(this.btn_Reset);
            this.panel1.Controls.Add(this.comboboxUserID);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.textboxFilePath);
            this.panel1.Controls.Add(this.btn_Prepare);
            this.panel1.Controls.Add(this.btn_Archieve);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.textboxFileDate);
            this.panel1.Controls.Add(this.textboxFileID);
            this.panel1.Controls.Add(this.textboxFileName);
            this.panel1.Controls.Add(this.btn_browse);
            this.panel1.Controls.Add(this.btn_Delete);
            this.panel1.Controls.Add(this.btn_Add);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.shapeContainer1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1370, 749);
            this.panel1.TabIndex = 1;
            // 
            // listboxUsername
            // 
            this.listboxUsername.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listboxUsername.FormattingEnabled = true;
            this.listboxUsername.ItemHeight = 18;
            this.listboxUsername.Location = new System.Drawing.Point(213, 150);
            this.listboxUsername.Name = "listboxUsername";
            this.listboxUsername.Size = new System.Drawing.Size(302, 40);
            this.listboxUsername.TabIndex = 25;
            // 
            // btn_Reset
            // 
            this.btn_Reset.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Reset.BackgroundImage")));
            this.btn_Reset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Reset.FlatAppearance.BorderSize = 0;
            this.btn_Reset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_Reset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btn_Reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Reset.Location = new System.Drawing.Point(643, 401);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(71, 68);
            this.btn_Reset.TabIndex = 23;
            this.btn_Reset.UseVisualStyleBackColor = true;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // comboboxUserID
            // 
            this.comboboxUserID.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboboxUserID.Font = new System.Drawing.Font("Consolas", 12F);
            this.comboboxUserID.ForeColor = System.Drawing.Color.DimGray;
            this.comboboxUserID.FormattingEnabled = true;
            this.comboboxUserID.Location = new System.Drawing.Point(685, 258);
            this.comboboxUserID.Name = "comboboxUserID";
            this.comboboxUserID.Size = new System.Drawing.Size(142, 27);
            this.comboboxUserID.TabIndex = 22;
            this.comboboxUserID.Text = "user id";
            this.comboboxUserID.SelectedIndexChanged += new System.EventHandler(this.comboboxUserID_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rtextboxParagraph);
            this.groupBox1.Controls.Add(this.textboxKeyword);
            this.groupBox1.Controls.Add(this.textboxSubject);
            this.groupBox1.Controls.Add(this.textboxCreator);
            this.groupBox1.Controls.Add(this.textboxAuthor);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(873, 200);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(488, 297);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PREPARE DOCUMENT";
            // 
            // rtextboxParagraph
            // 
            this.rtextboxParagraph.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rtextboxParagraph.Location = new System.Drawing.Point(225, 61);
            this.rtextboxParagraph.Name = "rtextboxParagraph";
            this.rtextboxParagraph.Size = new System.Drawing.Size(242, 203);
            this.rtextboxParagraph.TabIndex = 22;
            this.rtextboxParagraph.Text = "";
            // 
            // textboxKeyword
            // 
            this.textboxKeyword.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textboxKeyword.ForeColor = System.Drawing.Color.Black;
            this.textboxKeyword.Location = new System.Drawing.Point(17, 238);
            this.textboxKeyword.Name = "textboxKeyword";
            this.textboxKeyword.Size = new System.Drawing.Size(174, 26);
            this.textboxKeyword.TabIndex = 22;
            // 
            // textboxSubject
            // 
            this.textboxSubject.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textboxSubject.ForeColor = System.Drawing.Color.Black;
            this.textboxSubject.Location = new System.Drawing.Point(17, 179);
            this.textboxSubject.Name = "textboxSubject";
            this.textboxSubject.Size = new System.Drawing.Size(174, 26);
            this.textboxSubject.TabIndex = 21;
            // 
            // textboxCreator
            // 
            this.textboxCreator.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textboxCreator.ForeColor = System.Drawing.Color.Black;
            this.textboxCreator.Location = new System.Drawing.Point(17, 122);
            this.textboxCreator.Name = "textboxCreator";
            this.textboxCreator.Size = new System.Drawing.Size(174, 26);
            this.textboxCreator.TabIndex = 20;
            // 
            // textboxAuthor
            // 
            this.textboxAuthor.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textboxAuthor.ForeColor = System.Drawing.Color.Black;
            this.textboxAuthor.Location = new System.Drawing.Point(17, 61);
            this.textboxAuthor.Name = "textboxAuthor";
            this.textboxAuthor.Size = new System.Drawing.Size(174, 26);
            this.textboxAuthor.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(222, 36);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 18);
            this.label10.TabIndex = 18;
            this.label10.Text = "CONTENTS:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(14, 217);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 18);
            this.label9.TabIndex = 17;
            this.label9.Text = "KEYWORD:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(14, 158);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 18);
            this.label8.TabIndex = 16;
            this.label8.Text = "SUBJECT:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(14, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 18);
            this.label7.TabIndex = 15;
            this.label7.Text = "CREATOR:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(14, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 18);
            this.label4.TabIndex = 14;
            this.label4.Text = "AUTHOR:";
            // 
            // textboxFilePath
            // 
            this.textboxFilePath.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textboxFilePath.ForeColor = System.Drawing.Color.DimGray;
            this.textboxFilePath.Location = new System.Drawing.Point(535, 311);
            this.textboxFilePath.Multiline = true;
            this.textboxFilePath.Name = "textboxFilePath";
            this.textboxFilePath.Size = new System.Drawing.Size(291, 30);
            this.textboxFilePath.TabIndex = 19;
            this.textboxFilePath.Text = "file path";
            this.textboxFilePath.Enter += new System.EventHandler(this.textboxFilePath_Enter);
            // 
            // btn_Prepare
            // 
            this.btn_Prepare.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Prepare.BackgroundImage")));
            this.btn_Prepare.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Prepare.FlatAppearance.BorderSize = 0;
            this.btn_Prepare.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_Prepare.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btn_Prepare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Prepare.Location = new System.Drawing.Point(1047, 503);
            this.btn_Prepare.Name = "btn_Prepare";
            this.btn_Prepare.Size = new System.Drawing.Size(171, 134);
            this.btn_Prepare.TabIndex = 18;
            this.btn_Prepare.UseVisualStyleBackColor = true;
            this.btn_Prepare.Click += new System.EventHandler(this.btn_Prepare_Click);
            // 
            // btn_Archieve
            // 
            this.btn_Archieve.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Archieve.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Archieve.FlatAppearance.BorderSize = 2;
            this.btn_Archieve.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_Archieve.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_Archieve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Archieve.Font = new System.Drawing.Font("Berlin Sans FB Demi", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Archieve.ForeColor = System.Drawing.Color.White;
            this.btn_Archieve.Location = new System.Drawing.Point(27, 150);
            this.btn_Archieve.Name = "btn_Archieve";
            this.btn_Archieve.Size = new System.Drawing.Size(126, 42);
            this.btn_Archieve.TabIndex = 17;
            this.btn_Archieve.Text = "Archieve";
            this.btn_Archieve.UseVisualStyleBackColor = false;
            this.btn_Archieve.Click += new System.EventHandler(this.btn_Archieve_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(684, 369);
            this.dateTimePicker1.MinDate = new System.DateTime(2015, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(142, 26);
            this.dateTimePicker1.TabIndex = 15;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // textboxFileDate
            // 
            this.textboxFileDate.BackColor = System.Drawing.Color.LightCoral;
            this.textboxFileDate.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textboxFileDate.ForeColor = System.Drawing.Color.DimGray;
            this.textboxFileDate.Location = new System.Drawing.Point(536, 365);
            this.textboxFileDate.Multiline = true;
            this.textboxFileDate.Name = "textboxFileDate";
            this.textboxFileDate.ReadOnly = true;
            this.textboxFileDate.Size = new System.Drawing.Size(142, 30);
            this.textboxFileDate.TabIndex = 20;
            this.textboxFileDate.Text = "DD.MM.YYYY";
            this.textboxFileDate.Enter += new System.EventHandler(this.textboxFileDate_Enter);
            this.textboxFileDate.Leave += new System.EventHandler(this.textboxFileDate_Leave);
            // 
            // textboxFileID
            // 
            this.textboxFileID.BackColor = System.Drawing.Color.LightCoral;
            this.textboxFileID.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textboxFileID.ForeColor = System.Drawing.Color.DimGray;
            this.textboxFileID.Location = new System.Drawing.Point(536, 200);
            this.textboxFileID.Multiline = true;
            this.textboxFileID.Name = "textboxFileID";
            this.textboxFileID.ReadOnly = true;
            this.textboxFileID.Size = new System.Drawing.Size(142, 30);
            this.textboxFileID.TabIndex = 7;
            this.textboxFileID.Text = "file ID";
            this.textboxFileID.Enter += new System.EventHandler(this.textboxFileID_Enter);
            this.textboxFileID.Leave += new System.EventHandler(this.textboxFileID_Leave);
            // 
            // textboxFileName
            // 
            this.textboxFileName.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textboxFileName.ForeColor = System.Drawing.Color.DimGray;
            this.textboxFileName.Location = new System.Drawing.Point(536, 257);
            this.textboxFileName.Multiline = true;
            this.textboxFileName.Name = "textboxFileName";
            this.textboxFileName.Size = new System.Drawing.Size(143, 30);
            this.textboxFileName.TabIndex = 8;
            this.textboxFileName.Text = "filename.pdf";
            this.textboxFileName.Enter += new System.EventHandler(this.textboxFileName_Enter);
            this.textboxFileName.Leave += new System.EventHandler(this.textboxFileName_Leave);
            // 
            // btn_browse
            // 
            this.btn_browse.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_browse.BackgroundImage")));
            this.btn_browse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_browse.FlatAppearance.BorderSize = 0;
            this.btn_browse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_browse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_browse.Location = new System.Drawing.Point(832, 298);
            this.btn_browse.Name = "btn_browse";
            this.btn_browse.Size = new System.Drawing.Size(35, 52);
            this.btn_browse.TabIndex = 6;
            this.btn_browse.UseVisualStyleBackColor = true;
            this.btn_browse.Click += new System.EventHandler(this.btn_browse_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Delete.BackgroundImage")));
            this.btn_Delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Delete.FlatAppearance.BorderSize = 0;
            this.btn_Delete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_Delete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Delete.Location = new System.Drawing.Point(288, 536);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(71, 68);
            this.btn_Delete.TabIndex = 5;
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Add.BackgroundImage")));
            this.btn_Add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Add.FlatAppearance.BorderSize = 0;
            this.btn_Add.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_Add.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Add.Location = new System.Drawing.Point(158, 536);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(71, 68);
            this.btn_Add.TabIndex = 4;
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Maroon;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fileIDDataGridViewTextBoxColumn,
            this.fileNameDataGridViewTextBoxColumn,
            this.filePathDataGridViewTextBoxColumn,
            this.fileCreationDateDataGridViewTextBoxColumn,
            this.uIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tableDOCUMENTBindingSource;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dataGridView1.Location = new System.Drawing.Point(27, 198);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(488, 299);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // fileIDDataGridViewTextBoxColumn
            // 
            this.fileIDDataGridViewTextBoxColumn.DataPropertyName = "file_ID";
            this.fileIDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.fileIDDataGridViewTextBoxColumn.Name = "fileIDDataGridViewTextBoxColumn";
            this.fileIDDataGridViewTextBoxColumn.Width = 55;
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
            this.filePathDataGridViewTextBoxColumn.Width = 125;
            // 
            // fileCreationDateDataGridViewTextBoxColumn
            // 
            this.fileCreationDateDataGridViewTextBoxColumn.DataPropertyName = "file_CreationDate";
            this.fileCreationDateDataGridViewTextBoxColumn.HeaderText = "CREATION DATE";
            this.fileCreationDateDataGridViewTextBoxColumn.Name = "fileCreationDateDataGridViewTextBoxColumn";
            // 
            // uIDDataGridViewTextBoxColumn
            // 
            this.uIDDataGridViewTextBoxColumn.DataPropertyName = "u_ID";
            this.uIDDataGridViewTextBoxColumn.HeaderText = "USER ID";
            this.uIDDataGridViewTextBoxColumn.Name = "uIDDataGridViewTextBoxColumn";
            this.uIDDataGridViewTextBoxColumn.Width = 65;
            // 
            // tableDOCUMENTBindingSource
            // 
            this.tableDOCUMENTBindingSource.DataMember = "Table_DOCUMENT";
            this.tableDOCUMENTBindingSource.DataSource = this.dMSProjectDataSet4;
            // 
            // dMSProjectDataSet4
            // 
            this.dMSProjectDataSet4.DataSetName = "DMSProjectDataSet4";
            this.dMSProjectDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel2.Controls.Add(this.labelProfile);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.exit_btn);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1370, 83);
            this.panel2.TabIndex = 0;
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
            this.exit_btn.Location = new System.Drawing.Point(1297, 6);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(64, 74);
            this.exit_btn.TabIndex = 242;
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
            this.label1.TabIndex = 6;
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
            this.shapeContainer1.Size = new System.Drawing.Size(1370, 749);
            this.shapeContainer1.TabIndex = 1;
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
            this.lineShape1.Y1 = 85;
            this.lineShape1.Y2 = 85;
            // 
            // tableUSERINFOBindingSource
            // 
            this.tableUSERINFOBindingSource.DataMember = "Table_USERINFO";
            this.tableUSERINFOBindingSource.DataSource = this.dMSProjectDataSet6;
            // 
            // dMSProjectDataSet6
            // 
            this.dMSProjectDataSet6.DataSetName = "DMSProjectDataSet6";
            this.dMSProjectDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // table_USERINFOTableAdapter
            // 
            this.table_USERINFOTableAdapter.ClearBeforeFill = true;
            // 
            // table_DOCUMENTTableAdapter
            // 
            this.table_DOCUMENTTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(7, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 33);
            this.pictureBox1.TabIndex = 235;
            this.pictureBox1.TabStop = false;
            // 
            // labelProfile
            // 
            this.labelProfile.AutoSize = true;
            this.labelProfile.BackColor = System.Drawing.Color.Transparent;
            this.labelProfile.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProfile.ForeColor = System.Drawing.Color.Firebrick;
            this.labelProfile.Location = new System.Drawing.Point(45, 54);
            this.labelProfile.Name = "labelProfile";
            this.labelProfile.Size = new System.Drawing.Size(0, 21);
            this.labelProfile.TabIndex = 234;
            // 
            // SecretaryFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 709);
            this.Controls.Add(this.panel1);
            this.Name = "SecretaryFrm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.SecretaryFrm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableDOCUMENTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dMSProjectDataSet4)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableUSERINFOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dMSProjectDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textboxKeyword;
        private System.Windows.Forms.TextBox textboxSubject;
        private System.Windows.Forms.TextBox textboxCreator;
        private System.Windows.Forms.TextBox textboxAuthor;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textboxFilePath;
        private System.Windows.Forms.Button btn_Archieve;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textboxFileDate;
        private System.Windows.Forms.TextBox textboxFileID;
        private System.Windows.Forms.TextBox textboxFileName;
        private System.Windows.Forms.Button btn_browse;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.Button btn_Prepare;
        private System.Windows.Forms.RichTextBox rtextboxParagraph;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboboxUserID;
        private DMSProjectDataSet6 dMSProjectDataSet6;
        private System.Windows.Forms.BindingSource tableUSERINFOBindingSource;
        private DMSProjectDataSet6TableAdapters.Table_USERINFOTableAdapter table_USERINFOTableAdapter;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.Button exit_btn;
        private DMSProjectDataSet4 dMSProjectDataSet4;
        private System.Windows.Forms.BindingSource tableDOCUMENTBindingSource;
        private DMSProjectDataSet4TableAdapters.Table_DOCUMENTTableAdapter table_DOCUMENTTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn fileIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fileNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn filePathDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fileCreationDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.ListBox listboxUsername;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelProfile;

    }
}