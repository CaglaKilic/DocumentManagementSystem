namespace DocumentManagementSystem
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.LabelPosition = new System.Windows.Forms.Label();
            this.radiobuttonUser = new System.Windows.Forms.RadioButton();
            this.radiobuttonSecretary = new System.Windows.Forms.RadioButton();
            this.radiobuttonAdmin = new System.Windows.Forms.RadioButton();
            this.btn_Appearence = new System.Windows.Forms.Button();
            this.OpenRegisterForm = new System.Windows.Forms.Label();
            this.LoginButton = new System.Windows.Forms.Button();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.UsernameTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Indigo;
            this.panel1.Controls.Add(this.LabelPosition);
            this.panel1.Controls.Add(this.radiobuttonUser);
            this.panel1.Controls.Add(this.radiobuttonSecretary);
            this.panel1.Controls.Add(this.radiobuttonAdmin);
            this.panel1.Controls.Add(this.btn_Appearence);
            this.panel1.Controls.Add(this.OpenRegisterForm);
            this.panel1.Controls.Add(this.LoginButton);
            this.panel1.Controls.Add(this.PasswordTextBox);
            this.panel1.Controls.Add(this.UsernameTextBox);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(583, 473);
            this.panel1.TabIndex = 0;
            // 
            // LabelPosition
            // 
            this.LabelPosition.AutoSize = true;
            this.LabelPosition.Location = new System.Drawing.Point(12, 91);
            this.LabelPosition.Name = "LabelPosition";
            this.LabelPosition.Size = new System.Drawing.Size(0, 13);
            this.LabelPosition.TabIndex = 212;
            this.LabelPosition.Visible = false;
            // 
            // radiobuttonUser
            // 
            this.radiobuttonUser.AutoSize = true;
            this.radiobuttonUser.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radiobuttonUser.ForeColor = System.Drawing.Color.White;
            this.radiobuttonUser.Location = new System.Drawing.Point(435, 151);
            this.radiobuttonUser.Name = "radiobuttonUser";
            this.radiobuttonUser.Size = new System.Drawing.Size(69, 28);
            this.radiobuttonUser.TabIndex = 211;
            this.radiobuttonUser.TabStop = true;
            this.radiobuttonUser.Text = "User";
            this.radiobuttonUser.UseVisualStyleBackColor = true;
            this.radiobuttonUser.CheckedChanged += new System.EventHandler(this.radiobuttonUser_CheckedChanged);
            // 
            // radiobuttonSecretary
            // 
            this.radiobuttonSecretary.AutoSize = true;
            this.radiobuttonSecretary.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radiobuttonSecretary.ForeColor = System.Drawing.Color.White;
            this.radiobuttonSecretary.Location = new System.Drawing.Point(278, 151);
            this.radiobuttonSecretary.Name = "radiobuttonSecretary";
            this.radiobuttonSecretary.Size = new System.Drawing.Size(124, 28);
            this.radiobuttonSecretary.TabIndex = 210;
            this.radiobuttonSecretary.TabStop = true;
            this.radiobuttonSecretary.Text = "Secretary";
            this.radiobuttonSecretary.UseVisualStyleBackColor = true;
            this.radiobuttonSecretary.CheckedChanged += new System.EventHandler(this.radiobuttonSecretary_CheckedChanged);
            // 
            // radiobuttonAdmin
            // 
            this.radiobuttonAdmin.AutoSize = true;
            this.radiobuttonAdmin.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radiobuttonAdmin.ForeColor = System.Drawing.Color.White;
            this.radiobuttonAdmin.Location = new System.Drawing.Point(156, 151);
            this.radiobuttonAdmin.Name = "radiobuttonAdmin";
            this.radiobuttonAdmin.Size = new System.Drawing.Size(94, 28);
            this.radiobuttonAdmin.TabIndex = 209;
            this.radiobuttonAdmin.TabStop = true;
            this.radiobuttonAdmin.Text = "Admin";
            this.radiobuttonAdmin.UseVisualStyleBackColor = true;
            this.radiobuttonAdmin.CheckedChanged += new System.EventHandler(this.radiobuttonAdmin_CheckedChanged);
            // 
            // btn_Appearence
            // 
            this.btn_Appearence.BackColor = System.Drawing.Color.White;
            this.btn_Appearence.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Appearence.BackgroundImage")));
            this.btn_Appearence.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Appearence.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Appearence.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_Appearence.FlatAppearance.BorderSize = 0;
            this.btn_Appearence.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_Appearence.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_Appearence.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Appearence.Location = new System.Drawing.Point(493, 276);
            this.btn_Appearence.Name = "btn_Appearence";
            this.btn_Appearence.Size = new System.Drawing.Size(32, 26);
            this.btn_Appearence.TabIndex = 208;
            this.btn_Appearence.UseVisualStyleBackColor = false;
            this.btn_Appearence.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_Appearence_MouseDown);
            this.btn_Appearence.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_Appearence_MouseUp);
            // 
            // OpenRegisterForm
            // 
            this.OpenRegisterForm.AutoSize = true;
            this.OpenRegisterForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OpenRegisterForm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.OpenRegisterForm.Font = new System.Drawing.Font("Berlin Sans FB", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpenRegisterForm.ForeColor = System.Drawing.Color.White;
            this.OpenRegisterForm.Location = new System.Drawing.Point(236, 424);
            this.OpenRegisterForm.Name = "OpenRegisterForm";
            this.OpenRegisterForm.Size = new System.Drawing.Size(129, 15);
            this.OpenRegisterForm.TabIndex = 202;
            this.OpenRegisterForm.Text = "Create A New Account";
            this.OpenRegisterForm.Click += new System.EventHandler(this.OpenRegisterForm_Click);
            // 
            // LoginButton
            // 
            this.LoginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.LoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LoginButton.Font = new System.Drawing.Font("Berlin Sans FB Demi", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginButton.ForeColor = System.Drawing.Color.Transparent;
            this.LoginButton.Location = new System.Drawing.Point(209, 359);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(177, 52);
            this.LoginButton.TabIndex = 6;
            this.LoginButton.Text = "LOGIN";
            this.LoginButton.UseVisualStyleBackColor = false;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PasswordTextBox.ForeColor = System.Drawing.Color.LightGray;
            this.PasswordTextBox.Location = new System.Drawing.Point(135, 266);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(392, 47);
            this.PasswordTextBox.TabIndex = 201;
            this.PasswordTextBox.Text = "password";
            this.PasswordTextBox.Enter += new System.EventHandler(this.PasswordTextBox_Enter);
            this.PasswordTextBox.Leave += new System.EventHandler(this.PasswordTextBox_Leave);
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.UsernameTextBox.ForeColor = System.Drawing.Color.LightGray;
            this.UsernameTextBox.Location = new System.Drawing.Point(135, 195);
            this.UsernameTextBox.Multiline = true;
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.Size = new System.Drawing.Size(392, 45);
            this.UsernameTextBox.TabIndex = 200;
            this.UsernameTextBox.Text = "username";
            this.UsernameTextBox.Enter += new System.EventHandler(this.UsernameTextBox_Enter);
            this.UsernameTextBox.Leave += new System.EventHandler(this.UsernameTextBox_Leave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(64, 185);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(65, 65);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(64, 255);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(65, 65);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gold;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(583, 88);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Berlin Sans FB Demi", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(583, 88);
            this.label1.TabIndex = 2;
            this.label1.Text = "USER LOGIN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 473);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.TextBox UsernameTextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label OpenRegisterForm;
        private System.Windows.Forms.Button btn_Appearence;
        private System.Windows.Forms.RadioButton radiobuttonUser;
        private System.Windows.Forms.RadioButton radiobuttonSecretary;
        private System.Windows.Forms.RadioButton radiobuttonAdmin;
        private System.Windows.Forms.Label LabelPosition;
    }
}