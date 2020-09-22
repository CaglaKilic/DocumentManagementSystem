using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using iTextSharp.text;
using iTextSharp.text.pdf;



namespace DocumentManagementSystem
{
    public partial class SecretaryFrm : Form
    {
        public SecretaryFrm()
        {
            InitializeComponent();
        }

        //define public variable for pull user name according to the logged-in user
        public string uname { get; set; }

        //connecting to database
        DBConnection db = new DBConnection();

        //when the click this button;
        private void btn_browse_Click(object sender, EventArgs e)
        {
            //for open pdf files
            OpenFileDialog openPdf = new OpenFileDialog();
            openPdf.Title = "Open PDF";
            openPdf.Filter = "PDF Files (*.Pdf) | *.Pdf";
            if (openPdf.ShowDialog() == DialogResult.OK)
            {
                textboxFilePath.Text = openPdf.FileName;
                //contact PDFForm
                PDFForm newform = new PDFForm();
                //assigning the value in the textbox to a variable named filepathh in the PDFForm
                newform.filePathh = textboxFilePath.Text;
                //open the PDFForm
                newform.ShowDialog();
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            //open the connection
            db.openConnection();

            //query for add a new document
            SqlCommand query = new SqlCommand("INSERT INTO Table_DOCUMENT(file_Name,file_Path,file_CreationDate,u_ID) VALUES(@fn, @fp, @cd, @uid)", db.getConnection());

            //add the value in the textbox to @fn
            query.Parameters.AddWithValue("@fn", textboxFileName.Text);
            //add the value in the textbox to @fp
            query.Parameters.AddWithValue("@fp", textboxFilePath.Text);
            //add the value in the combobox to @uid
            query.Parameters.AddWithValue("@uid", comboboxUserID.Text);
            //add the value in the textbox to @cd
            query.Parameters.AddWithValue("@cd", textboxFileDate.Text);


            //check if these textboxes are empty
            if (textboxFileDate.Text == "" || textboxFilePath.Text == "" || textboxFileName.Text == "")
            {
                MessageBox.Show("PLEASE FILL IN ALL THE INFORMATION FIRST!", "Message Box", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
            //check if this filename already exists in the database
            else if (checkFileName())
            {
                MessageBox.Show("This File Name Already Exist, Select A Different One", "Message Box", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                textboxFileName.Text = "";
            }

            else
            {
                //execute the query
                if (query.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("DATA WERE RECORDED", "Message Box", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);

                    
                    //return the default values and colors
                    dateTimePicker1.ResetText();
                    textboxFileName.Text = "filename.pdf";
                    textboxFileName.ForeColor = Color.DimGray;
                    textboxFilePath.Text = "file path";
                    textboxFilePath.ForeColor = Color.DimGray;
                    textboxFileDate.Text = "DD.MM.YYYY";
                    textboxFileDate.ForeColor = Color.DimGray;
                    comboboxUserID.Text = "user id";
                    comboboxUserID.ForeColor = Color.DimGray;
                    
                }
                else
                {
                    MessageBox.Show("ERROR", "Message Box", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
            }

            //close the connection
            db.closeConnection();
        }
        //check file name
        public Boolean checkFileName()
        {
            //assigning the value in the textbox to a variable named filename
            String filename = textboxFileName.Text;
            //to keep the data we retrieve with queries from the database
            DataTable table = new DataTable();
            //for fill data in a DataTable
            SqlDataAdapter adapter = new SqlDataAdapter();
            //query for search the file according to the file name
            SqlCommand query = new SqlCommand("SELECT * FROM Table_DOCUMENT WHERE file_Name = @fn", db.getConnection());
            //add the value in the filename to @fs
            query.Parameters.AddWithValue("@fn", filename);
            //execute the query
            adapter.SelectCommand = query;
            //fill the table with the data assigned to the adapter variable.
            adapter.Fill(table);

            if (table.Rows.Count > 0)
                return true;
            else
                return false;
        }
        //design part
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            string date = dateTimePicker1.Value.ToShortDateString();
            textboxFileDate.Text = date;
            textboxFileDate.ForeColor = Color.Black;
        }

        private void btn_Archieve_Click(object sender, EventArgs e)
        {
            //query for pull the data in database
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Table_DOCUMENT", db.getConnection());
            //create a dataset
            DataSet ds = new DataSet();
            //fill the dataset with data from database
            da.Fill(ds);
            //show the dataset in dataGridView1
            dataGridView1.DataSource = ds.Tables[0];
        }
        //create a new pdf document
        private void btn_Prepare_Click(object sender, EventArgs e)
        {
            //if all of these null
            if ((textboxAuthor.Text == "" || textboxCreator.Text == "" || textboxSubject.Text == "" || textboxKeyword.Text == "" || rtextboxParagraph.Text == "") || checkTextboxValues())
            {
                MessageBox.Show("PLEASE FILL IN THE TEXTBOXES", "Message Box", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
            else
            {
                //the library for create a new pdf document
                iTextSharp.text.Document report = new iTextSharp.text.Document();
                //file path of newly created pdf file to save
                PdfWriter.GetInstance(report, new FileStream(@"C:\Users\Asus\Desktop\UPLOADFILES\" + textboxFileName.Text, FileMode.Create));
                //Author name, need for create a new pdf document
                report.AddAuthor(textboxAuthor.Text);
                //Creation Date, need for create a new pdf document
                report.AddCreationDate();
                //Creator, need for create a new pdf document
                report.AddCreator(textboxCreator.Text);
                //Subject, need for create a new pdf document
                report.AddSubject(textboxSubject.Text);
                //Keywords, need for create a new pdf document
                report.AddKeywords(textboxKeyword.Text);

                if (report.IsOpen() == false)
                {
                    //open report for create a new pdf document
                    report.Open();
                }
                //Paragraph, need for create a new pdf document
                report.Add(new Paragraph(rtextboxParagraph.Text));
                //open the connection
                db.openConnection();
                //a command line for add a new document
                SqlCommand query = new SqlCommand("INSERT INTO Table_DOCUMENT(file_Name,file_Path,file_CreationDate,u_ID) VALUES(@fn, @fp, @cd,@uid)", db.getConnection());
                //add the value in the textbox to @fn
                query.Parameters.AddWithValue("@fn", textboxFileName.Text);
                //add the value in the textbox to @fp
                query.Parameters.AddWithValue("@fp", textboxFilePath.Text + @"\" + textboxFileName.Text);
                //add the value in the combobox to @uid
                query.Parameters.AddWithValue("@uid", comboboxUserID.Text);
                //add the value in the textbox to @cd
                query.Parameters.AddWithValue("@cd", textboxFileDate.Text);

                if (textboxFileDate.Text == "" || textboxFileName.Text == "" || comboboxUserID.Text == "")
                {
                    MessageBox.Show("PLEASE ENTER THE NAME OF THE FILE: FILE NAME, CREATION DATE, OR USER ID", "Message Box", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
                else if (checkFileName())
                {
                    MessageBox.Show("This File Name Already Exist, Select A Different One", "Message Box", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    textboxFileName.Text = "";
                }
                else
                {
                    //execute the query
                    if (query.ExecuteNonQuery() == 1)
                    {
                        //the record is successfully
                        MessageBox.Show("DATA WERE RECORDED", "Message Box", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);

                        //return the default values and colors
                        dateTimePicker1.ResetText();
                        textboxFileID.Text = "file ID";
                        textboxFileID.ForeColor = Color.DimGray;
                        textboxFileName.Text = "filename.pdf";
                        textboxFileName.ForeColor = Color.DimGray;
                        comboboxUserID.Text = "user id";
                        comboboxUserID.ForeColor = Color.DimGray;
                        textboxFilePath.Text = "file path";
                        textboxFilePath.ForeColor = Color.DimGray;
                        dateTimePicker1.ResetText();
                        textboxFileDate.Text = "DD.MM.YYYY";
                        textboxFileDate.ForeColor = Color.DimGray;
                        textboxSubject.Text = "";
                        rtextboxParagraph.Text = "";
                        dateTimePicker1.Text = "";
                        textboxAuthor.Text = "";
                        textboxCreator.Text = "";
                        textboxKeyword.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("ERROR", "Message Box", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    }
                }
                //close the report
                report.Close();
                //close the connection
                db.closeConnection();
            }
            
        }
        public Boolean checkTextboxValues()
        {
            String fname = textboxFileName.Text;
            String uid = comboboxUserID.Text;
            String fpath = textboxFilePath.Text;
            String date = textboxFileDate.Text;

            if (fname.Equals("filename.pdf") || uid.Equals("user id") || fpath.Equals("file path") || date.Equals("DD.MM.YYYY"))
                return true;
            else
                return false;
        }
        private void btn_Delete_Click(object sender, EventArgs e)
        {
            //open the connection
            db.openConnection();

            //a command line for delete tha data from Document table
            SqlCommand query = new SqlCommand("DELETE FROM Table_DOCUMENT WHERE file_Name = @name", db.getConnection());
            //add the value in the  textbox to @name
            query.Parameters.AddWithValue("@name", textboxFileName.Text);

            query.ExecuteNonQuery();
            MessageBox.Show("THE RECORD WAS DELETED SUCCESSFULLY", "Message Box", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);

            //close the connection
            db.closeConnection();

            //return the default values and colors
            dateTimePicker1.ResetText();
            textboxFileID.Text = "file ID";
            textboxFileID.ForeColor = Color.DimGray;
            textboxFileName.Text = "filename.pdf";
            textboxFileName.ForeColor = Color.DimGray;
            textboxFilePath.Text = "file path";
            textboxFilePath.ForeColor = Color.DimGray;
            comboboxUserID.Text = "user id";
            comboboxUserID.ForeColor = Color.DimGray;
            textboxFileDate.Text = "DD.MM.YYYY";
            textboxFileDate.ForeColor = Color.DimGray;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //selected cell
            int chosen = dataGridView1.SelectedCells[0].RowIndex;
            //assign the data in the zeroth index to the id variable
            String id = dataGridView1.Rows[chosen].Cells[0].Value.ToString();
            //assign the data in the first index to the name variable
            String name = dataGridView1.Rows[chosen].Cells[1].Value.ToString();
            //assign the data in the second index to the path variable
            String path = dataGridView1.Rows[chosen].Cells[2].Value.ToString();
            //assign the data in the third index to the date variable
            String date = dataGridView1.Rows[chosen].Cells[3].Value.ToString();
            //assign the data in the fourth index to the uid variable
            String uid = dataGridView1.Rows[chosen].Cells[4].Value.ToString();

            //transferring value from id to textbox
            textboxFileID.Text = id;
            textboxFileID.ForeColor = Color.Black;
            //transferring value from name to textbox
            textboxFileName.Text = name;
            textboxFileName.ForeColor = Color.Black;
            //transferring value from path to textbox
            textboxFilePath.Text = path;
            textboxFilePath.ForeColor = Color.Black;
            //transferring value from uid to combobox
            comboboxUserID.Text = uid;
            comboboxUserID.ForeColor = Color.Black;
            //transferring value from date to textbox
            textboxFileDate.Text = date;
            textboxFileDate.ForeColor = Color.Black;

            //contact PDFForm
            PDFForm newForm = new PDFForm();
            //assigning the value in the textbox to a variable named filepathh in the PDFForm
            newForm.filePathh = textboxFilePath.Text;
            //open the PDFForm
            newForm.ShowDialog();
        }

        //----------------------------------- DESIGN PART -----------------------------------//
        private void textboxFileName_Enter(object sender, EventArgs e)
        {
            String fname = textboxFileName.Text;
            if (fname.ToLower().Trim().Equals("filename.pdf"))
            {
                textboxFileName.Text = "";
                textboxFileName.ForeColor = Color.Black;
            }
        }

        private void textboxFileName_Leave(object sender, EventArgs e)
        {
            String fname = textboxFileName.Text;
            if (fname.ToLower().Trim().Equals("filename.pdf") || fname.Trim().Equals(""))
            {
                textboxFileName.Text = "filename.pdf";
                textboxFileName.ForeColor = Color.DimGray;
            }
        }

        private void textboxFilePath_Enter(object sender, EventArgs e)
        {
            String fpath = textboxFilePath.Text;
            if (fpath.ToLower().Trim().Equals("file path"))
            {
                textboxFilePath.Text = @"C:\Users\Asus\Desktop\UPLOADFILES";
                textboxFilePath.ForeColor = Color.Black;
            }
        }


        private void textboxFileDate_Enter(object sender, EventArgs e)
        {
            String cd = textboxFileDate.Text;
            if (cd.ToLower().Trim().Equals("DD.MM.YYYY"))
            {
                textboxFileDate.Text = "";
                textboxFileDate.ForeColor = Color.Black;
            }
        }

        private void textboxFileDate_Leave(object sender, EventArgs e)
        {
            String cd = textboxFileDate.Text;
            if (cd.ToLower().Trim().Equals("DD.MM.YYYY") || cd.Trim().Equals(""))
            {
                textboxFileDate.Text = "";
                textboxFileDate.ForeColor = Color.DimGray;
            }
        }

        private void textboxFileID_Enter(object sender, EventArgs e)
        {
            String id = textboxFileID.Text;
            if (id.ToLower().Trim().Equals("file ID"))
            {
                textboxFileID.Text = "";
                textboxFileID.ForeColor = Color.Black;
            }
        }

        private void textboxFileID_Leave(object sender, EventArgs e)
        {
            String fid = textboxFileID.Text;
            if (fid.ToLower().Trim().Equals("file ID") || fid.Trim().Equals(""))
            {
                textboxFileID.Text = "file ID";
                textboxFileID.ForeColor = Color.DimGray;
            }
        }
        //----------------------------------- DESIGN PART -----------------------------------//

        //when the form load
        private void SecretaryFrm_Load(object sender, EventArgs e)
        {
            //print the username
            labelProfile.Text = uname;

            //a command line for pull the data in database
            SqlCommand query = new SqlCommand("(SELECT * FROM Table_USERINFO) EXCEPT (SELECT * FROM Table_USERINFO WHERE user_ID = ANY (SELECT user_ID FROM Table_USERINFO WHERE user_Position = 'Admin' OR user_Position = 'Secretary'))", db.getConnection());
            //define a variable to perform a line-by-line read operation
            SqlDataReader dr;
            //open the database connection
            db.openConnection();
            //return this code command from a table that contains one or more data
            dr = query.ExecuteReader();
            //read until the last line
            while (dr.Read())
            {
                //assign to combobox user id
                comboboxUserID.Items.Add(dr["user_ID"]);
                //assign to listbox user id, user first name, user last name
                listboxUsername.Items.Add(dr["user_ID"] + ", " + dr["user_FirstName"] + "  " + dr["user_LastName"]);
            }


            //close the connection
            db.closeConnection();
        }

        //return the textboxe's default values
        private void btn_Reset_Click(object sender, EventArgs e)
        {
            dateTimePicker1.ResetText();
            textboxFileID.Text = "file ID";
            textboxFileID.ForeColor = Color.DimGray;
            textboxFileName.Text = "filename.pdf";
            textboxFileName.ForeColor = Color.DimGray;
            comboboxUserID.Text = "user id";
            comboboxUserID.ForeColor = Color.DimGray;
            textboxFilePath.Text = "file path";
            textboxFilePath.ForeColor = Color.DimGray;
            textboxFileDate.Text = "DD.MM.YYYY";
            textboxFileDate.ForeColor = Color.DimGray;
        }

        //if click this button, then the user log-out. After that, open the LoginForm
        private void exit_btn_Click(object sender, EventArgs e)
        {
            LoginForm newForm = new LoginForm();
            this.Hide();
            newForm.ShowDialog();
        }
        //design part
        private void comboboxUserID_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboboxUserID.ForeColor = Color.Black;
        }


    }
}
