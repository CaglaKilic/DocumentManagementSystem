using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DocumentManagementSystem
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();

            //set size
            this.PasswordTextBox.AutoSize = false;
            this.PasswordTextBox.Size = new Size(this.PasswordTextBox.Size.Width, 40);

            //set size
            this.Confirm_PassTextBox.AutoSize = false;
            this.Confirm_PassTextBox.Size = new Size(this.PasswordTextBox.Size.Width, 40);
        }

        //design part
        private void FirstnameTextBox_Enter(object sender, EventArgs e)
        {
            /*By clicking on the textbox, the defined value will be deleted, 
            and the cursor will blink to allow the user to enter a value.*/
            String fname = FirstnameTextBox.Text;
            if (fname.ToLower().Trim().Equals("first name"))
            {
                FirstnameTextBox.Text = "";
                FirstnameTextBox.ForeColor = Color.Black;
            }
        }
        //design part
        private void FirstnameTextBox_Leave(object sender, EventArgs e)
        {
            /*if the user leaves the box without entering any value,
            the defined value will appear.*/
            String fname = FirstnameTextBox.Text;
            if (fname.ToLower().Trim().Equals("first name") || fname.Trim().Equals(""))
            {
                FirstnameTextBox.Text = "first name";
                FirstnameTextBox.ForeColor = Color.LightGray;       
            }
        }

        private void PhoneTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            { e.Handled = true; }
        }

        //design part
        private void LastnameTextBox_Enter(object sender, EventArgs e)
        {
            String lname = LastnameTextBox.Text;
            if (lname.ToLower().Trim().Equals("last name"))
            {
                LastnameTextBox.Text = "";
                LastnameTextBox.ForeColor = Color.Black;
            }
        }

        //design part
        private void LastnameTextBox_Leave(object sender, EventArgs e)
        {
            String lname = LastnameTextBox.Text;
            if (lname.ToLower().Trim().Equals("last name") || lname.Trim().Equals(""))
            {
                LastnameTextBox.Text = "last name";
                LastnameTextBox.ForeColor = Color.LightGray;
            }
        }

        //design part
        private void PhoneTextBox_Enter(object sender, EventArgs e)
        {
            String phone = PhoneTextBox.Text;
            if (phone.ToLower().Trim().Equals("phone"))
            {
                PhoneTextBox.Text = "";
                PhoneTextBox.ForeColor = Color.Black;

            }
        }

        //design part
        private void PhoneTextBox_Leave(object sender, EventArgs e)
        {
            String phone = PhoneTextBox.Text;
            if (phone.ToLower().Trim().Equals("phone") || phone.Trim().Equals(""))
            {
                PhoneTextBox.Text = "phone";
                PhoneTextBox.ForeColor = Color.LightGray;
            }
        }

        //design part
        private void UsernameTextBox_Enter(object sender, EventArgs e)
        {
            String uname = UsernameTextBox.Text;
            if (uname.ToLower().Trim().Equals("username"))
            {
                UsernameTextBox.Text = "";
                UsernameTextBox.ForeColor = Color.Black;
            }
        }

        //design part
        private void UsernameTextBox_Leave(object sender, EventArgs e)
        {
            String uname = UsernameTextBox.Text;
            if (uname.ToLower().Trim().Equals("username") || uname.Trim().Equals(""))
            {
                UsernameTextBox.Text = "username";
                UsernameTextBox.ForeColor = Color.LightGray;
            }
        }
        
        //design part
        private void PasswordTextBox_Enter(object sender, EventArgs e)
        {
            String pass = PasswordTextBox.Text;
            if (pass.ToLower().Trim().Equals("password"))
            {
                PasswordTextBox.Text = "";
                PasswordTextBox.UseSystemPasswordChar = true;
                PasswordTextBox.ForeColor = Color.Black;
            }
        }


        //design part
        private void PasswordTextBox_Leave(object sender, EventArgs e)
        {
            String pass = PasswordTextBox.Text;
            if (pass.ToLower().Trim().Equals("password") || pass.Trim().Equals(""))
            {
                PasswordTextBox.Text = "password";
                PasswordTextBox.UseSystemPasswordChar = false;
                PasswordTextBox.ForeColor = Color.LightGray;
            }
        }


        //design part
        private void Confirm_PassTextBox_Enter(object sender, EventArgs e)
        {
            String passw = Confirm_PassTextBox.Text;
            if (passw.ToLower().Trim().Equals("confirm password"))
            {
                Confirm_PassTextBox.Text = "";
                Confirm_PassTextBox.UseSystemPasswordChar = true;
                Confirm_PassTextBox.ForeColor = Color.Black;
            }
        }

        //design part
        private void Confirm_PassTextBox_Leave(object sender, EventArgs e)
        {
            String passw = Confirm_PassTextBox.Text;
            if (passw.ToLower().Trim().Equals("confirm password")
                || passw.ToLower().Trim().Equals("password")
                || passw.Trim().Equals(""))
            {
                Confirm_PassTextBox.Text = "confirm password";
                Confirm_PassTextBox.UseSystemPasswordChar = false;
                Confirm_PassTextBox.ForeColor = Color.LightGray;
            }
        }
        

        //when click on the create account button;
        private void RegisterButton_Click(object sender, EventArgs e)
        {
            //string fname = FirstnameTextBox.Text;
            //string lname = LastnameTextBox.Text;
            //string phone = PhoneTextBox.Text;
            //string uname = UsernameTextBox.Text;
            //string pass = PasswordTextBox.Text;

            //connecting to database
            DBConnection db = new DBConnection();
            //open the connection
            db.openConnection();

            //a command line for add a new user
            SqlCommand query = new SqlCommand("EXEC spRegisterForm @fn, @ln, @phone, @usn, @pass", db.getConnection());

            query.Parameters.AddWithValue("@fn", FirstnameTextBox.Text);
            query.Parameters.AddWithValue("@ln", LastnameTextBox.Text);
            query.Parameters.AddWithValue("@phone", PhoneTextBox.Text);
            query.Parameters.AddWithValue("@usn", UsernameTextBox.Text);
            query.Parameters.AddWithValue("@pass", PasswordTextBox.Text);

            //check if the textboxes contains default values 
            if(!checkTextboxValues())
            {
                //check if the password equals to confirm password
                if (PasswordTextBox.Text.Equals(Confirm_PassTextBox.Text))
                {
                    //check if this username already exists in the database
                    if (checkUsername())
                    {
                        MessageBox.Show("This Username Already Exist, Select A Different One", "Message Box", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

                    }
                    else
                    {
                        //execute the query
                        if (query.ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show("ACCOUNT CREATED", "Message Box", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                            //resetting textboxes to default values and default font colors if command worked correctly
                            FirstnameTextBox.Text = "first name";
                            LastnameTextBox.Text = "last name";
                            PhoneTextBox.Text = "phone";
                            UsernameTextBox.Text = "username";
                            PasswordTextBox.Text = "password";
                            Confirm_PassTextBox.Text = "confirm password";

                            FirstnameTextBox.ForeColor = Color.LightGray;
                            LastnameTextBox.ForeColor = Color.LightGray;
                            PhoneTextBox.ForeColor = Color.LightGray;
                            UsernameTextBox.ForeColor = Color.LightGray;
                            PasswordTextBox.UseSystemPasswordChar = false;
                            PasswordTextBox.ForeColor = Color.LightGray;
                            Confirm_PassTextBox.UseSystemPasswordChar = false;
                            Confirm_PassTextBox.ForeColor = Color.LightGray;

                            //open the Login Form after a successful registration
                            LoginForm newForm = new LoginForm();
                            this.Hide();
                            newForm.ShowDialog();
                        }
                        else
                        {
                            //give the below message when query does not run successfully
                            MessageBox.Show("ERROR", "Message Box", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                        }
                    }
                }
                //if passwords do not match, the following commands occur
                else
                {
                    MessageBox.Show("PASSWORDS DO NOT MATCH", "Message Box", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    PasswordTextBox.Text = "password";
                    Confirm_PassTextBox.Text = "confirm password";
                    PasswordTextBox.UseSystemPasswordChar = false;
                    PasswordTextBox.ForeColor = Color.LightGray;
                    Confirm_PassTextBox.UseSystemPasswordChar = false;
                    Confirm_PassTextBox.ForeColor = Color.LightGray;
                }
            }
            //command line that will run when textboxes are default values
            else
                MessageBox.Show("ENTER YOUR INFORMATION FIRST", "Message Box", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

            //close the connection
            db.closeConnection();
        }

        public Boolean checkUsername()
        {
            //connecting to database
            DBConnection db = new DBConnection();

            String username = UsernameTextBox.Text;
            //DataTable is used to populate datas
            DataTable table = new DataTable();
            //the filling process is performed by the Fill Method of the SqlDataAdapter.
            SqlDataAdapter adapter = new SqlDataAdapter();
            //pulls usernames from database
            SqlCommand query = new SqlCommand("SELECT * FROM Table_USERINFO WHERE user_Username = @usn", db.getConnection());
            query.Parameters.AddWithValue("@usn", username);

            adapter.SelectCommand = query;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
                //already this username is exist
                return true;
            else
                //you can registrated
                return false;
        }
        //check textboxes are default values or not
        public Boolean checkTextboxValues()
        {
            String fname = FirstnameTextBox.Text;
            String lname = LastnameTextBox.Text;
            String phone = PhoneTextBox.Text;
            String uname = UsernameTextBox.Text;
            String pass = PasswordTextBox.Text;

            if (fname.Equals("first name") || lname.Equals("last name") || phone.Equals("phone") || uname.Equals("username") || pass.Equals("password"))
                return true;
            else
                return false;
        }

        //when click "I have an Account!", open the Login Form
        private void OpenLoginForm_Click(object sender, EventArgs e)
        {
            LoginForm newform = new LoginForm();
            this.Hide();
            newform.ShowDialog();
        }
    }
}

