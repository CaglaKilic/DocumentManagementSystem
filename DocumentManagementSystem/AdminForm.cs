using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using org.apache.pdfbox.pdmodel;
using org.apache.pdfbox.util;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
using System.IO;

namespace DocumentManagementSystem
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        //define public variable for pull user name according to the logged-in user
        public string uname { get; set; }

        //connection to database
        DBConnection db = new DBConnection();


        //----------------------------------- DESIGN PART -----------------------------------//
        private void FirstnameTextBox_Enter(object sender, EventArgs e)
        {
            String fname = FirstnameTextBox.Text;
            if (fname.ToLower().Trim().Equals("first name"))
            {
                FirstnameTextBox.Text = "";
                FirstnameTextBox.ForeColor = Color.Black;
            }
        }

        private void FirstnameTextBox_Leave(object sender, EventArgs e)
        {
            String fname = FirstnameTextBox.Text;
            if (fname.ToLower().Trim().Equals("first name") || fname.Trim().Equals(""))
            {
                FirstnameTextBox.Text = "first name";
                FirstnameTextBox.ForeColor = Color.DimGray;
            }
        }

        private void LastnameTextBox_Enter(object sender, EventArgs e)
        {
            String lname = LastnameTextBox.Text;
            if (lname.ToLower().Trim().Equals("last name"))
            {
                LastnameTextBox.Text = "";
                LastnameTextBox.ForeColor = Color.Black;
            }
        }

        private void LastnameTextBox_Leave(object sender, EventArgs e)
        {
            String lname = LastnameTextBox.Text;
            if (lname.ToLower().Trim().Equals("last name") || lname.Trim().Equals(""))
            {
                LastnameTextBox.Text = "last name";
                LastnameTextBox.ForeColor = Color.DimGray;
            }
        }

        private void PhoneTextBox_Enter(object sender, EventArgs e)
        {
            String phone = PhoneTextBox.Text;
            if (phone.ToLower().Trim().Equals("phone"))
            {
                PhoneTextBox.Text = "";
                PhoneTextBox.ForeColor = Color.Black;
            }
        }

        private void PhoneTextBox_Leave(object sender, EventArgs e)
        {
            String phone = PhoneTextBox.Text;
            if (phone.ToLower().Trim().Equals("phone") || phone.Trim().Equals(""))
            {
                PhoneTextBox.Text = "phone";
                PhoneTextBox.ForeColor = Color.DimGray;
            }
        }

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
                UsernameTextBox.ForeColor = Color.DimGray;
            }
        }

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

        private void PasswordTextBox_Leave(object sender, EventArgs e)
        {
            String pass = PasswordTextBox.Text;
            if (pass.ToLower().Trim().Equals("password") || pass.Trim().Equals(""))
            {
                PasswordTextBox.Text = "password";
                PasswordTextBox.UseSystemPasswordChar = false;
                PasswordTextBox.ForeColor = Color.DimGray;
            }
        }
        //----------------------------------- DESIGN PART -----------------------------------//
        

        private void btn_Add_Click(object sender, EventArgs e)
        {
            //open the connection
            db.openConnection();

            //a command line for add a new user
            SqlCommand query = new SqlCommand("INSERT INTO Table_USERINFO(user_FirstName,user_LastName,user_Phone,user_Username,user_Password, user_Position) VALUES(@fn, @ln, @phone, @un, @pass, @uposition)", db.getConnection());

            //add the value in the textbox to @fn
            query.Parameters.AddWithValue("@fn", FirstnameTextBox.Text);
            //add the value in the textbox to @ln
            query.Parameters.AddWithValue("@ln", LastnameTextBox.Text);
            //add the value in the textbox to @phone
            query.Parameters.AddWithValue("@phone", PhoneTextBox.Text);
            //add the value in the textbox to @un
            query.Parameters.AddWithValue("@un", UsernameTextBox.Text);
            //add the value in the textbox to @pass
            query.Parameters.AddWithValue("@pass", PasswordTextBox.Text);
            //add the value in the combobox to @position
            query.Parameters.AddWithValue("@uposition", comboboxPosition.Text);

            //check if the tools default values
            if (!checkTextboxValues())
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

                        //the tools return to the default value after the command runs successfully
                        UserIDtextbox.Text = "ID";
                        FirstnameTextBox.Text = "first name";
                        LastnameTextBox.Text = "last name";
                        PhoneTextBox.Text = "phone";
                        UsernameTextBox.Text = "username";
                        PasswordTextBox.Text = "password";
                        comboboxPosition.Text = "position";
                        //the tools return to the default color after the command runs successfully
                        UserIDtextbox.ForeColor = Color.DimGray;
                        FirstnameTextBox.ForeColor = Color.DimGray;
                        LastnameTextBox.ForeColor = Color.DimGray;
                        PhoneTextBox.ForeColor = Color.DimGray;
                        UsernameTextBox.ForeColor = Color.DimGray;
                        PasswordTextBox.UseSystemPasswordChar = false;
                        PasswordTextBox.ForeColor = Color.DimGray;
                        comboboxPosition.ForeColor = Color.DimGray;
                    }
                    else
                    {
                        MessageBox.Show("ERROR", "Message Box", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    }
                }
            }
            else
                MessageBox.Show("ENTER YOUR INFORMATION FIRST", "Message Box", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

            //close the connection
            db.closeConnection();
        }

        //check if this username already exists in the database
        public Boolean checkUsername()
        {
            String username = UsernameTextBox.Text;
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand query = new SqlCommand("SELECT * FROM Table_USERINFO WHERE user_Username = @usn", db.getConnection());
            query.Parameters.AddWithValue("@usn", username);

            adapter.SelectCommand = query;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
                return true;
            else
                return false;
        }

        //check if the tools default values
        public Boolean checkTextboxValues()
        {
            String fname = FirstnameTextBox.Text;
            String lname = LastnameTextBox.Text;
            String phone = PhoneTextBox.Text;
            String uname = UsernameTextBox.Text;
            String pass = PasswordTextBox.Text;
            String position = comboboxPosition.Text;

            if (fname.Equals("first name") || lname.Equals("last name") || phone.Equals("phone") || uname.Equals("username") || pass.Equals("password") || position.Equals("position"))
                return true;
            else
                return false;
        }

        private void btn_ShowUsers_Click(object sender, EventArgs e)
        {
            //query for pull the data in database
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Table_USERINFO", db.getConnection());
            //create a dataset
            DataSet ds = new DataSet();
            //fill the dataset with data from database
            da.Fill(ds);
            //show the dataset in dgv_User
            dgv_User.DataSource = ds.Tables[0];
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            //open the connection
            db.openConnection();

            //control for the toolboxes are default value or not
            if (FirstnameTextBox.Text == "first name" || LastnameTextBox.Text == "last name" || PhoneTextBox.Text == "phone" || UsernameTextBox.Text == "username" || PasswordTextBox.Text == "password" || comboboxPosition.Text == "position")
            {
                MessageBox.Show("PLEASE SELECT DATA FROM THE TABLE FIRST", "Message Box", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
            }
            else
            {
                //query for delete the data from Userinfo table
                SqlCommand query = new SqlCommand("DELETE FROM Table_USERINFO WHERE user_ID = @id", db.getConnection());
                //add the value in the  textbox to @id
                query.Parameters.AddWithValue("@id", UserIDtextbox.Text);

                query.ExecuteNonQuery();
                MessageBox.Show("THE RECORD WAS DELETED SUCCESSFULLY", "Message Box", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);

                //the tools return to the default value and color after the command runs successfully
                UserIDtextbox.Text = "ID";
                UserIDtextbox.ForeColor = Color.DimGray;
                FirstnameTextBox.Text = "first name";
                FirstnameTextBox.ForeColor = Color.DimGray;
                LastnameTextBox.Text = "last name";
                LastnameTextBox.ForeColor = Color.DimGray;
                PhoneTextBox.Text = "phone";
                PhoneTextBox.ForeColor = Color.DimGray;
                UsernameTextBox.Text = "username";
                UsernameTextBox.ForeColor = Color.DimGray;
                PasswordTextBox.Text = "password";
                PasswordTextBox.ForeColor = Color.DimGray;
                comboboxPosition.Text = "position";
                comboboxPosition.ForeColor = Color.DimGray;
            }
            
            //close the connection
            db.closeConnection();
        }

        private void btn_View_Click(object sender, EventArgs e)
        {
            //query for select the data from Feedbacks table
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Table_FEEDBACKS", db.getConnection());
            //create a dataset
            DataSet ds = new DataSet();
            //fill the dataset with data from database
            da.Fill(ds);
            //show the dataset in dgv_Feedbacks
            dgv_Feedbacks.DataSource = ds.Tables[0];
        }

        private void btn_ShowDocuments_Click(object sender, EventArgs e)
        {
            //query for select the data from Document table
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Table_DOCUMENT", db.getConnection());
            //create a dataset
            DataSet ds = new DataSet();
            //fill the dataset with data from database
            da.Fill(ds);
            //show the dataset in dgv_Documents
            dgv_Documents.DataSource = ds.Tables[0];

            //query for select the data from Userinfo table
            SqlCommand query = new SqlCommand("(SELECT * FROM Table_USERINFO) EXCEPT (SELECT * FROM Table_USERINFO WHERE user_ID = ANY (SELECT user_ID FROM Table_USERINFO WHERE user_Position = 'Admin' OR user_Position = 'Secretary'))", db.getConnection());
            //define a variable to perform a line-by-line read operation
            SqlDataReader dr;
            //open the connection
            db.openConnection();
            //return this code command from a table that contains one or more data
            dr = query.ExecuteReader();
            //read until the last line
            while (dr.Read())
            {
                //assign to combobox user id 
                comboboxUserID.Items.Add(dr["user_ID"]);
            }
            
            //close the connection
            db.closeConnection();

        }

        private void dgv_Documents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //selected cell
            int chosen = dgv_Documents.SelectedCells[0].RowIndex;
            //assign the data in the zeroth index to the id variable
            String id = dgv_Documents.Rows[chosen].Cells[0].Value.ToString();
            //assign the data in the first index to the fname variable
            String fname = dgv_Documents.Rows[chosen].Cells[1].Value.ToString();
            //assign the data in the second index to the path variable
            String fpath = dgv_Documents.Rows[chosen].Cells[2].Value.ToString();
            //assign the data in the third index to the cd variable
            String cd = dgv_Documents.Rows[chosen].Cells[3].Value.ToString();
            //assign the data in the fourth index to the uname variable
            String uname = dgv_Documents.Rows[chosen].Cells[4].Value.ToString();

            //transferring value from id to label
            labelFileID.Text = id;
            //transferring value from fname to textbox
            textboxFileName.Text = fname;
            //transferring value from cd to label
            labelCreationDate.Text = cd;
            //transferring value from uname to combobox
            comboboxUserID.Text = uname;

            textboxFilePath.Text = @"" + fpath + "";

            labelFilePath.Text = @"C:\Users\Asus\Desktop\UPLOADFILES";

        }


        //private void button1_Click(object sender, EventArgs e)
        //{
        //    PDDocument doc = PDDocument.load(textboxFilePath.Text);
        //    PDFTextStripper st = new PDFTextStripper();
        //    rtxt_Paragraph.Text = (st.getText(doc));
        //}


        private void dgv_Feedbacks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //selected cell
            int chosen = dgv_Feedbacks.SelectedCells[0].RowIndex;
            //assign the data in the second index to the fb variable
            String fb = dgv_Feedbacks.Rows[chosen].Cells[2].Value.ToString();

            //contact FeedbackForm
            FeedbackForm newForm = new FeedbackForm();
            //assigning the value in the fb to a variable named feedb in the FeedbackForm
            newForm.feedb = fb;
            //open the newForm
            newForm.ShowDialog();
        }

        //lines of code required to convert a pdf file to text
        private void btn_Convert_Click(object sender, EventArgs e)
        {
            string filePath;
            filePath = textboxFilePath.Text.ToString();

            string strText = string.Empty;
            try 
            {
                PdfReader reader = new PdfReader(filePath);
                for(int page = 1; page <= reader.NumberOfPages; page++)
                {
                    ITextExtractionStrategy its = new iTextSharp.text.pdf.parser.LocationTextExtractionStrategy();
                    String s = PdfTextExtractor.GetTextFromPage(reader, page, its);

                    s = Encoding.UTF8.GetString(ASCIIEncoding.Convert(Encoding.Default, Encoding.UTF8, Encoding.Default.GetBytes(s)));
                    strText = strText + s;
                    rtxt_Paragraph.Text = strText;

                    labelFilePath.Text = labelFilePath.Text + @"\" + textboxFileName.Text;
                }
                reader.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btn_Update_Click(object sender, EventArgs e)
        {
            //the library for create a new pdf document
            iTextSharp.text.Document report = new iTextSharp.text.Document();
            //file path of newly created pdf file to save
            PdfWriter.GetInstance(report, new FileStream(@"C:\Users\Asus\Desktop\UPLOADFILES\" + textboxFileName.Text, FileMode.Create));
            //Author name, need for create a new pdf document
            report.AddAuthor(lbl_Author.Text);
            //Creation Date, need for create a new pdf document
            report.AddCreationDate();
            //Creator, need for create a new pdf document
            report.AddCreator(lbl_Creator.Text);
            //Subject, need for create a new pdf document
            report.AddSubject(lbl_Subject.Text);
            //Keywords, need for create a new pdf document
            report.AddKeywords(lbl_Keyword.Text);

            if (report.IsOpen() == false)
            {
                //open report for create a new pdf document
                report.Open();
            }
            //Paragraph, need for create a new pdf document
            report.Add(new Paragraph(rtxt_Paragraph.Text));
            
            //open the connection
            db.openConnection();
            //a command line for update the document
            SqlCommand query = new SqlCommand("UPDATE Table_DOCUMENT SET file_Path = @fp, u_ID = @uid WHERE file_ID = @fid", db.getConnection());

            //add the value in the label to @fp
            query.Parameters.AddWithValue("@fp", labelFilePath.Text);
            //add the value in the combobox to @uid
            query.Parameters.AddWithValue("@uid", comboboxUserID.Text);
            //add the value in the label to @fid
            query.Parameters.AddWithValue("@fid", labelFileID.Text);

            //ecevute the query
            if (query.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("DATA WERE UPDATED", "Message Box", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                //return the default values
                labelFilePath.Text = @"C:\Users\Asus\Desktop\UPLOADFILES";
                textboxFilePath.Text = "";
                labelFileID.Text = "";
                lbl_FileName.Text = "";
                labelCreationDate.Text = "";
                comboboxUserID.Text = " ";
                rtxt_Paragraph.Text = "";
            }
            else
            {
                MessageBox.Show("ERROR", "Message Box", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            //close the report
            report.Close();
            //close the connection
            db.closeConnection();
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            LoginForm newForm = new LoginForm();
            this.Hide();
            newForm.ShowDialog();
        }

        private void dgv_User_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //selected cell
            int chosen = dgv_User.SelectedCells[0].RowIndex;
            //assign the data in the zeroth index to the id variable
            String id = dgv_User.Rows[chosen].Cells[0].Value.ToString();
            //assign the data in the first index to the name variable
            String name = dgv_User.Rows[chosen].Cells[1].Value.ToString();
            //assign the data in the second index to the sname variable
            String sname = dgv_User.Rows[chosen].Cells[2].Value.ToString();
            //assign the data in the third index to the phone variable
            String phone = dgv_User.Rows[chosen].Cells[3].Value.ToString();
            //assign the data in the fourth index to the uname variable
            String uname = dgv_User.Rows[chosen].Cells[4].Value.ToString();
            //assign the data in the fifth index to the pass variable
            String pass = dgv_User.Rows[chosen].Cells[5].Value.ToString();
            //assign the data in the sixth index to the position variable
            String position = dgv_User.Rows[chosen].Cells[6].Value.ToString();

            //transferring value from id to textbox
            UserIDtextbox.Text = id;
            UserIDtextbox.ForeColor = Color.Black;
            //transferring value from name to textbox
            FirstnameTextBox.Text = name;
            FirstnameTextBox.ForeColor = Color.Black;
            //transferring value from sname to textbox
            LastnameTextBox.Text = sname;
            LastnameTextBox.ForeColor = Color.Black;
            //transferring value from phone to textbox
            PhoneTextBox.Text = phone;
            PhoneTextBox.ForeColor = Color.Black;
            //transferring value from uname to textbox
            UsernameTextBox.Text = uname;
            UsernameTextBox.ForeColor = Color.Black;
            //transferring value from pass to textbox
            PasswordTextBox.Text = pass;
            PasswordTextBox.ForeColor = Color.Black;
            //transferring value from position to textbox
            comboboxPosition.Text = position;
            comboboxPosition.ForeColor = Color.Black;

        }

        private void btn_UserUpdate_Click(object sender, EventArgs e)
        {
            //open the connection
            db.openConnection();
            //a query for update tha data from Userinfo table
            SqlCommand update = new SqlCommand("UPDATE Table_USERINFO SET user_FirstName = @fn, user_LastName = @ln, user_Phone = @no, user_Username = @un, user_Password = @up, user_Position = @position WHERE user_ID = @id", db.getConnection());

            //add the value in the  textbox to @id
            update.Parameters.AddWithValue("@id", UserIDtextbox.Text);
            //add the value in the  textbox to @fn
            update.Parameters.AddWithValue("@fn", FirstnameTextBox.Text);
            //add the value in the  textbox to @ln
            update.Parameters.AddWithValue("@ln", LastnameTextBox.Text);
            //add the value in the  textbox to @no
            update.Parameters.AddWithValue("@no", PhoneTextBox.Text);
            //add the value in the  textbox to @un
            update.Parameters.AddWithValue("@un", UsernameTextBox.Text);
            //add the value in the  textbox to @up
            update.Parameters.AddWithValue("@up", PasswordTextBox.Text);
            //add the value in the  textbox to @position
            update.Parameters.AddWithValue("@position", comboboxPosition.Text);

            //check if the tools are not default values
            if (!checkTextboxValues())
            {
                //execute query
                if (update.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("DATA WERE UPDATED", "Message Box", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);

                    //return the default values and colors
                    UserIDtextbox.Text = "ID";
                    UserIDtextbox.ForeColor = Color.DimGray;
                    FirstnameTextBox.Text = "first name";
                    FirstnameTextBox.ForeColor = Color.DimGray;
                    LastnameTextBox.Text = "last name";
                    LastnameTextBox.ForeColor = Color.DimGray;
                    PhoneTextBox.Text = "phone";
                    PhoneTextBox.ForeColor = Color.DimGray;
                    UsernameTextBox.Text = "username";
                    UsernameTextBox.ForeColor = Color.DimGray;
                    PasswordTextBox.Text = "password";
                    PasswordTextBox.ForeColor = Color.DimGray;
                    comboboxPosition.Text = "position";
                    comboboxPosition.ForeColor = Color.DimGray;
                }
                else
                {
                    MessageBox.Show("ERROR", "Message Box", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
            }

            else
                MessageBox.Show("ENTER YOUR INFORMATION FIRST", "Message Box", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

            //close the connection
            db.closeConnection();
        }

        //design part
        private void comboboxPosition_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboboxPosition.ForeColor = Color.Black;
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            //print the username
            labelProfile.Text = uname;
        }

    }
}
