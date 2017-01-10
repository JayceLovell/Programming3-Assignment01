using Assignment01;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment01
{
    public partial class SubscribeForm : Form
    {
        public SubscribeForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Make sure the user wants to close form
        /// </summary>
        private void SubscribeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you Sure?","Closing",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if(result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
        /// <summary>
        /// Opens the main Form
        /// </summary>
        private void SubscribeForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Mainform mainform = new Mainform();
            mainform.Show();
        }
        /// <summary>
        /// THis method clears the text box when clicked
        /// </summary>
        private void TxtEmail_Click(object sender, EventArgs e)
        {
            TxtEmail.Text = "";
        }
        /// <summary>
        /// THis method clears the text box when clicked
        /// </summary>
        private void txtPhoneNumber_Click(object sender, EventArgs e)
        {
            txtPhoneNumber.Text = "";
        }
        /// <summary>
        /// This method closes the form from Cancel Button Click
        /// </summary>
        private void Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
