using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace DocumentManagementSystem
{
    public partial class PDFForm : Form
    {
        public PDFForm()
        {
            InitializeComponent();
        }

        //define public variable to switch between forms
        public string filePathh { get; set; }

        private void PDFForm_Load(object sender, EventArgs e)
        {
            //transferring value from filepathh to textbox
            textboxFilePath.Text = filePathh;
            //upload the pdf file to acroPDF tool
            acroPDF.LoadFile(@"" + textboxFilePath.Text);
        }
    }
}
