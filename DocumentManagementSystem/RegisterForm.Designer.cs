namespace DocumentManagementSystem
{
    partial class RegisterForm
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
            this.OpenLoginForm = new System.Windows.Forms.Label();
            this.Confirm_PassTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.UsernameTextBox = new System.Windows.Forms.TextBox();
            this.PhoneTextBox = new System.Windows.Forms.TextBox();
            this.LastnameTextBox = new System.Windows.Forms.TextBox();
            this.RegisterButton = new System.Windows.Forms.Button();
            this.FirstnameTextBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Indigo;
            this.panel1.Controls.Add(this.OpenLoginForm);
            this.panel1.Controls.Add(this.Confirm_PassTextBox);
            this.panel1.Controls.Add(this.PasswordTextBox);
            this.panel1.Controls.Add(this.UsernameTextBox);
            this.panel1.Controls.Add(this.PhoneTextBox);
            this.panel1.Controls.Add(this.LastnameTextBox);
            this.panel1.Controls.Add(this.RegisterButton);
            this.panel1.Controls.Add(this.FirstnameTextBox);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(697, 545);
            this.panel1.TabIndex = 1;
            // 
            // OpenLoginForm
            // 
            this.OpenLoginForm.AutoSize = true;
            this.OpenLoginForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OpenLoginForm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.OpenLoginForm.Font = new System.Drawing.Font("Berlin Sans FB", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpenLoginForm.ForeColor = System.Drawing.Color.White;
            this.OpenLoginForm.Location = new System.Drawing.Point(307, 510);
            this.OpenLoginForm.Name = "OpenLoginForm";
            this.OpenLoginForm.Size = new System.Drawing.Size(108, 15);
            this.OpenLoginForm.TabIndex = 201;
            this.OpenLoginForm.Text = "I Have An Account!";
            this.OpenLoginForm.Click += new System.EventHandler(this.OpenLoginForm_Click);
            // 
            // Confirm_PassTextBox
            // 
            this.Confirm_PassTextBox.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Confirm_PassTextBox.ForeColor = System.Drawing.Color.LightGray;
            this.Confirm_PassTextBox.Location = new System.Drawing.Point(92, 362);
            this.Confirm_PassTextBox.Name = "Confirm_PassTextBox";
            this.Confirm_PassTextBox.Size = new System.Drawing.Size(526, 37);
            this.Confirm_PassTextBox.TabIndex = 200;
            this.Confirm_PassTextBox.Text = "confirm password";
            this.Confirm_PassTextBox.Enter += new System.EventHandler(this.Confirm_PassTextBox_Enter);
            this.Confirm_PassTextBox.Leave += new System.EventHandler(this.Confirm_PassTextBox_Leave);
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PasswordTextBox.ForeColor = System.Drawing.Color.LightGray;
            this.PasswordTextBox.Location = new System.Drawing.Point(92, 307);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(526, 37);
            this.PasswordTextBox.TabIndex = 10;
            this.PasswordTextBox.Text = "password";
            this.PasswordTextBox.Enter += new System.EventHandler(this.PasswordTextBox_Enter);
            this.PasswordTextBox.Leave += new System.EventHandler(this.PasswordTextBox_Leave);
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.UsernameTextBox.ForeColor = System.Drawing.Color.LightGray;
            this.UsernameTextBox.Location = new System.Drawing.Point(92, 252);
            this.UsernameTextBox.Multiline = true;
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.Size = new System.Drawing.Size(526, 40);
            this.UsernameTextBox.TabIndex = 9;
            this.UsernameTextBox.Text = "username";
            this.UsernameTextBox.Enter += new System.EventHandler(this.UsernameTextBox_Enter);
            this.UsernameTextBox.Leave += new System.EventHandler(this.UsernameTextBox_Leave);
            // 
            // PhoneTextBox
            // 
            this.PhoneTextBox.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PhoneTextBox.ForeColor = System.Drawing.Color.LightGray;
            this.PhoneTextBox.Location = new System.Drawing.Point(92, 197);
            this.PhoneTextBox.MaxLength = 11;
            this.PhoneTextBox.Multiline = true;
            this.PhoneTextBox.Name = "PhoneTextBox";
            this.PhoneTextBox.Size = new System.Drawing.Size(526, 40);
            this.PhoneTextBox.TabIndex = 8;
            this.PhoneTextBox.Text = "phone";
            this.PhoneTextBox.Enter += new System.EventHandler(this.PhoneTextBox_Enter);
            this.PhoneTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PhoneTextBox_KeyPress);
            this.PhoneTextBox.Leave += new System.EventHandler(this.PhoneTextBox_Leave);
            // 
            // LastnameTextBox
            // 
            this.LastnameTextBox.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LastnameTextBox.ForeColor = System.Drawing.Color.LightGray;
            this.LastnameTextBox.Location = new System.Drawing.Point(358, 142);
            this.LastnameTextBox.Multiline = true;
            this.LastnameTextBox.Name = "LastnameTextBox";
            this.LastnameTextBox.Size = new System.Drawing.Size(260, 40);
            this.LastnameTextBox.TabIndex = 7;
            this.LastnameTextBox.Text = "last name";
            this.LastnameTextBox.Enter += new System.EventHandler(this.LastnameTextBox_Enter);
            this.LastnameTextBox.Leave += new System.EventHandler(this.LastnameTextBox_Leave);
            // 
            // RegisterButton
            // 
            this.RegisterButton.BackColor = System.Drawing.Color.Gold;
            this.RegisterButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RegisterButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RegisterButton.Font = new System.Drawing.Font("Berlin Sans FB Demi", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterButton.ForeColor = System.Drawing.Color.Transparent;
            this.RegisterButton.Location = new System.Drawing.Point(216, 440);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(273, 52);
            this.RegisterButton.TabIndex = 6;
            this.RegisterButton.Text = "CREATE ACCOUNT";
            this.RegisterButton.UseVisualStyleBackColor = false;
            this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // FirstnameTextBox
            // 
            this.FirstnameTextBox.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FirstnameTextBox.ForeColor = System.Drawing.Color.LightGray;
            this.FirstnameTextBox.Location = new System.Drawing.Point(92, 142);
            this.FirstnameTextBox.Multiline = true;
            this.FirstnameTextBox.Name = "FirstnameTextBox";
            this.FirstnameTextBox.Size = new System.Drawing.Size(260, 40);
            this.FirstnameTextBox.TabIndex = 200;
            this.FirstnameTextBox.Text = "first name";
            this.FirstnameTextBox.Enter += new System.EventHandler(this.FirstnameTextBox_Enter);
            this.FirstnameTextBox.Leave += new System.EventHandler(this.FirstnameTextBox_Leave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gold;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(697, 88);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Berlin Sans FB Demi", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(697, 88);
            this.label1.TabIndex = 3;
            this.label1.Text = "CREATE YOUR ACCOUNT";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 544);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "RegisterForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button RegisterButton;
        private System.Windows.Forms.TextBox FirstnameTextBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox Confirm_PassTextBox;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.TextBox UsernameTextBox;
        private System.Windows.Forms.TextBox PhoneTextBox;
        private System.Windows.Forms.TextBox LastnameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label OpenLoginForm;

    }
}