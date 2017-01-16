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
    public partial class PublishForm : Form
    {
        public PublishForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Opens the main Form
        /// </summary>
        private void PublishForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Mainform mainform = new Mainform();
            mainform.Show();
        }
        /// <summary>
        /// Make sure the user wants to close form
        /// </summary>
        private void PublishForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Form is closing", "Closing", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
        /// <summary>
        /// Closes this form by button
        /// </summary>
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPublish_Click(object sender, EventArgs e)
        {
            Publisher publisher = new Publisher();
            if (Subscribers.SubscribersList.Count==0)
            {
                MessageBox.Show("They are currently no Subscribers to Notify", "Empty Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                foreach (var Subscriber in Subscribers.SubscribersList)
                {
                    SendByEmail sendbyemail = new SendByEmail(Subscriber.Email);
                    sendbyemail.Subscribe(publisher);
                    SendByPhoneNumber sendbyphonenumber = new SendByPhoneNumber(Subscriber.PhoneNumber);
                    sendbyphonenumber.Subscribe(publisher);
                    publisher.PublishMessage(txtContent.Text);
                }
            }
            Close();
        }
    }
}
