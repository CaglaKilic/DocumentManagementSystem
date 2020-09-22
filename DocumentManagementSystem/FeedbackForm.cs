using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DocumentManagementSystem
{
    public partial class FeedbackForm : Form
    {
        public FeedbackForm()
        {
            InitializeComponent();
        }

        //define public variable to switch between forms
        public string feedb { get; set; }

        private void FeedbackForm_Load(object sender, EventArgs e)
        {
            //transferring value from feedb to textbox
            rtextboxFeedback.Text = feedb;
        }
    }
}
