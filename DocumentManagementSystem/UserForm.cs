using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace DocumentManagementSystem
{
    public partial class UserForm : Form
    {
        
        public UserForm()
        {
            InitializeComponent();
        }

        //define public variable for pull user name according to the logged-in user
        public string uname { get; set; }

        //connect to database
        DBConnection db = new DBConnection();

        //when the user form load, will be;
        private void UserForm_Load(object sender, EventArgs e)
        {
            //print the username
            labelProfile.Text = uname;

            //pull the data in database according to the user ID
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Table_DOCUMENT WHERE u_ID = (SELECT user_ID FROM Table_USERINFO WHERE user_Username = '" + labelProfile.Text + "')", db.getConnection());
            //create a dataset
            DataSet ds = new DataSet();
            //fill the dataset with data from database
            da.Fill(ds);
            //show the dataset in DataGridView
            dgv_Document.DataSource = ds.Tables[0];

            //pull the data in database according to the user ID
            SqlCommand query = new SqlCommand("SELECT * FROM Table_DOCUMENT WHERE u_ID = (SELECT user_ID FROM Table_USERINFO WHERE user_Username = '" + labelProfile.Text + "')", db.getConnection());

            //define a variable to perform a line-by-line read operation
            SqlDataReader dr;
            //open the connection
            db.openConnection();
            //return this code command from a table that contains one or more data
            dr = query.ExecuteReader();
            //read until the last line
            while (dr.Read())
            {
                //assign to combobox file names 
                comboboxFileName.Items.Add(dr["file_Name"]);
            }
            //close the connection
            db.closeConnection();
        }

        private void buttonSearchSearch_Click(object sender, EventArgs e)
        {
            //pull the data in database according to the filename
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Table_DOCUMENT WHERE file_Name = '" + comboboxFileName.Text + "'", db.getConnection());
            //create a dataset
            DataSet ds = new DataSet();
            //fill the dataset with data from database
            da.Fill(ds);
            //show the dataset in DataGridView
            dgv_Document.DataSource = ds.Tables[0];

            //change the text color
            comboboxFileName.ForeColor = Color.Black;
        }

        //check default value of the textbox 
        public Boolean checkTextboxValue()
        {
            //assign the value written in the combobox to a variable
            String filename = comboboxFileName.Text;

            //if appear default value of the textbox
            if (filename.Equals("filename.pdf"))
                return true;
            else
                return false;
        }
        //will be when click the table's tuple
        private void dgv_Document_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //selected cell
            int chosen = dgv_Document.SelectedCells[0].RowIndex;
            //assign the data in the zeroth index to the fileID variable
            String fileID = dgv_Document.Rows[chosen].Cells[0].Value.ToString();
            //assign the data in the first index to the name variable
            String name = dgv_Document.Rows[chosen].Cells[1].Value.ToString();
            //assign the data in the second index to the path variable
            String path = dgv_Document.Rows[chosen].Cells[2].Value.ToString();
            //assign the data in the fourth index to the userID variable
            String userID = dgv_Document.Rows[chosen].Cells[4].Value.ToString();

            //transferring value from path to label
            labelFilePath.Text = path;
            //transferring value from name to combobox
            comboboxFileName.Text = name;
            //change font color
            comboboxFileName.ForeColor = Color.Black;
            //transferring value from userID to textbox
            textBoxUserID.Text = userID;
            //transferring value from fileID to textbox
            textBoxFileID.Text = fileID;

            //contact PDFForm
            PDFForm form = new PDFForm();
            //assigning the value in the label to a variable named filepathh in the PDFForm
            form.filePathh = labelFilePath.Text;
            //open the PDFForm
            form.ShowDialog();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            //open the connection
            db.openConnection();

            //query for add a new user
            SqlCommand query = new SqlCommand("INSERT INTO Table_FEEDBACKS(feedback_Subject,feedback_Text,u_ID,f_ID) VALUES(@fs, @ft, @uid, @fid)", db.getConnection());

            //add the value in the textbox to @fs
            query.Parameters.AddWithValue("@fs", textboxSubject.Text);
            //add the value in the textbox to @ft
            query.Parameters.AddWithValue("@ft", textboxFeedback.Text);
            //add the value in the textbox to @uid
            query.Parameters.AddWithValue("@uid", textBoxUserID.Text);
            //add the value in the textbox to @fid
            query.Parameters.AddWithValue("@fid", textBoxFileID.Text);

            //will be the message if textboxes are empty
            if (textboxSubject.Text == "" || textboxFeedback.Text == "" || textBoxUserID.Text == "" || textBoxFileID.Text == "")
            {
                MessageBox.Show("ENTER SUBJECT or FEEDBACK or FILE ID or USER ID", "Message Box", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            //if not
            else
            {
                if (query.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("YOUR FEEDBACK WAS SAVED!", "Message Box", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                    textboxSubject.Text = "";
                    textboxFeedback.Text = "";
                    textBoxUserID.Text = "";
                    textBoxFileID.Text = "";
                    comboboxFileName.Text = "filename.pdf";

                    comboboxFileName.ForeColor = Color.DimGray;

                }
                else
                {
                    MessageBox.Show("ERROR", "Message Box", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
            }
                
            //close the connection
            db.closeConnection();
        }

        //when a value in the combobox is selected;
        private void comboboxFileName_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboboxFileName.ForeColor = Color.Black;
        }

        //if click this button, then the user log-out. After that, open the LoginForm
        private void exit_btn_Click(object sender, EventArgs e)
        {
            LoginForm newForm = new LoginForm();
            this.Hide();
            newForm.ShowDialog();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            comboboxFileName.Text = "filename.pdf";
            comboboxFileName.ForeColor = Color.DimGray;
            //pull the data in database according to the user ID
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Table_DOCUMENT WHERE u_ID = (SELECT user_ID FROM Table_USERINFO WHERE user_Username = '" + labelProfile.Text + "')", db.getConnection());
            //create a dataset
            DataSet ds = new DataSet();
            //fill the dataset with data from database
            da.Fill(ds);
            //show the dataset in DataGridView
            dgv_Document.DataSource = ds.Tables[0];
        }
    }
}
