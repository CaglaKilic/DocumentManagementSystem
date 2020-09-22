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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        //connecting to database
        DBConnection db = new DBConnection();

        //when click on the login button;
        private void LoginButton_Click(object sender, EventArgs e)
        {
            //open the connection
            db.openConnection();

            //assigning the value entered in the textbox to the username variable
            String username = UsernameTextBox.Text;
            //assigning the value entered in the textbox to the pass variable
            String pass = PasswordTextBox.Text;
            //assigning the value entered in the textbox to the position variable
            String position = LabelPosition.Text;

            //DataTable is used to populate datas
            DataTable table = new DataTable();
            //the filling process is performed by the Fill Method of the SqlDataAdapter.
            SqlDataAdapter adapter = new SqlDataAdapter();
            //pulls username,password, and position from database
            SqlCommand query = new SqlCommand("EXEC spUserinfoWithCriteria @usn,@pass,@position", db.getConnection());


            //comparison of values ​​assigned to variables with values ​​extracted from database
            query.Parameters.AddWithValue("@usn", username);
            query.Parameters.AddWithValue("@pass", pass);
            query.Parameters.AddWithValue("@position", position);

            adapter.SelectCommand = query;
            adapter.Fill(table);

            //if no value is entered in the textboxes;
            if (username.Equals("") || pass.Equals("") || position.Equals(""))
            {
                MessageBox.Show("ENTER YOUR INFORMATION FIRST", "Message Box", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            //checking entered values
            else
            {
                
                //check if the user exists or not
                if (table.Rows.Count > 0)
                {
                    //open the admin form if position is admin
                    if (position.Equals("Admin"))
                    {
                        AdminForm newForm = new AdminForm();
                        //assigning the value in the textbox to a variable named uname in the userForm
                        newForm.uname = UsernameTextBox.Text;
                        this.Hide();
                        newForm.ShowDialog();
                    }
                    //open the secretary form if position is secretary
                    else if (position.Equals("Secretary"))
                    {
                        SecretaryFrm newForm = new SecretaryFrm();
                        //assigning the value in the textbox to a variable named uname in the userForm
                        newForm.uname = UsernameTextBox.Text;
                        this.Hide();
                        newForm.ShowDialog();
                    }
                    //open the user form if position is user
                    else if (position.Equals("User"))
                    {
                        UserForm newForm = new UserForm();
                        //assigning the value in the textbox to a variable named uname in the userForm
                        newForm.uname = UsernameTextBox.Text;
                        this.Hide();
                        newForm.ShowDialog();
                    }
                    //if position is not selected
                    else
                    {
                        MessageBox.Show("PLEASE SELECT YOUR POSITION", "Message Box", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    }
                }
                //program gives this message to ensure that all values ​​are entered correctly
                else
                {
                    MessageBox.Show("1. INVALID USERNAME, PASSWORD, OR POSITION \n\n2. MAYBE YOUR POSITION WAS NOT DETERMINED BY ADMIN!", "Message Box", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
            }
            //close the connection
            db.closeConnection();
        }

        ////when click "Create a New Account", open the Register Form
        private void OpenRegisterForm_Click(object sender, EventArgs e)
        {
            RegisterForm newform = new RegisterForm();
            this.Hide();
            newform.ShowDialog();
        }

        //visible password
        private void btn_Appearence_MouseDown(object sender, MouseEventArgs e)
        {
            PasswordTextBox.PasswordChar = char.Parse("\0");
        }
        //unvisible password
        private void btn_Appearence_MouseUp(object sender, MouseEventArgs e)
        {
            PasswordTextBox.PasswordChar = char.Parse("✪");
        }

        //"Admin" print commands to label if admin radio button is selected
        private void radiobuttonAdmin_CheckedChanged(object sender, EventArgs e)
        {
            LabelPosition.Text = radiobuttonAdmin.Text;
        }

        //"Secretary" print commands to label if secretary radio button is selected
        private void radiobuttonSecretary_CheckedChanged(object sender, EventArgs e)
        {
            LabelPosition.Text = radiobuttonSecretary.Text;
        }

        //"User" print commands to label if user radio button is selected
        private void radiobuttonUser_CheckedChanged(object sender, EventArgs e)
        {
            LabelPosition.Text = radiobuttonUser.Text;
        }

        //----------------------------------- DESIGN PART -----------------------------------//
        private void UsernameTextBox_Enter(object sender, EventArgs e)
        {
            String uname = UsernameTextBox.Text;
            if (uname.ToLower().Trim().Equals("username"))
            {
                UsernameTextBox.Text = "";
                UsernameTextBox.ForeColor = Color.Black;
            }
        }

        private void UsernameTextBox_Leave(object sender, EventArgs e)
        {
            String uname = UsernameTextBox.Text;
            if (uname.ToLower().Trim().Equals("username") || uname.Trim().Equals(""))
            {
                UsernameTextBox.Text = "username";
                UsernameTextBox.ForeColor = Color.LightGray;
            }
        }

        private void PasswordTextBox_Enter(object sender, EventArgs e)
        {
            String pass = PasswordTextBox.Text;
            if (pass.ToLower().Trim().Equals("password"))
            {
                PasswordTextBox.Text = "";
                PasswordTextBox.PasswordChar = char.Parse("✪");
                PasswordTextBox.ForeColor = Color.Black;
            }
        }

        private void PasswordTextBox_Leave(object sender, EventArgs e)
        {
            String pass = PasswordTextBox.Text;
            if (pass.ToLower().Trim().Equals("password") || pass.Trim().Equals(""))
            {
                PasswordTextBox.Text = "password";
                PasswordTextBox.PasswordChar = char.Parse("\0");
                PasswordTextBox.ForeColor = Color.LightGray;
            }
        }
        //----------------------------------- DESIGN PART -----------------------------------//
    }
}
