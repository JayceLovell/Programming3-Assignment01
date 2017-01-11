using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Assignment01;

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

        private void Subscribe(object sender, EventArgs e)
        {
            Publisher publisher = new Publisher();

            string info;
            if (MessagePhoneChk.Checked)
            {
                foreach(var Subscriber in Subscribers.SubscribersList)
                {
                    if(Subscriber.PhoneNumber == txtPhoneNumber.Text)
                    {
                        MessageBox.Show("This number is already subscribed", "Already Listed",MessageBoxButtons.RetryCancel);
                    }
                }
                info = txtPhoneNumber.Text;
                SendByPhoneNumber send2phonenumber = new SendByPhoneNumber(info);
                send2phonenumber.Subscribe(publisher);
            }
            /*if(MessageEmailChk.Checked)
            {
                info = txtEmail.text;
                SendByEmail send2Email = new SendByEmail(info);
                send2Email.Subscribe();
            }*/
            publisher.PublishMessage("New Notifications will be sent to");
            Subscribers.SubscribersList.Add(new Subscribers(TxtEmail.Text, txtPhoneNumber.Text));
        }

        private void Unsubscribe(object sender, EventArgs e)
        {

        }
    }
}
