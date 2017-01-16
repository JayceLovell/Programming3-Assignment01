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
using System.Text.RegularExpressions;
using System.Net.Mail;

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
            DialogResult result = MessageBox.Show("Form is closing are you Sure?","Closing",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
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
        /// <summary>
        /// This method subscribes the users phone number or email(mainly just put in list for publishing)
        /// </summary>
        private void Subscribe(object sender, EventArgs e)
        {
            Publisher publisher = new Publisher();

            string info;

            if (MessagePhoneChk.Checked && ValidatePhoneNumber(txtPhoneNumber.Text))
            {
                foreach(var Subscriber in Subscribers.SubscribersList)
                {
                    if(Subscriber.PhoneNumber == txtPhoneNumber.Text)
                    {
                        DialogResult result = MessageBox.Show("This number is already subscribed", "Already Listed",MessageBoxButtons.RetryCancel);
                        if (result == DialogResult.Cancel)
                        {
                            Close();
                        }
                        else
                        {
                            return;
                        }
                    }
                }
                info = txtPhoneNumber.Text;
                //SendByPhoneNumber send2phonenumber = new SendByPhoneNumber(info);
                //send2phonenumber.Subscribe(publisher);
                MessageBox.Show("You have subscribed with your Phone Number", "Subscribed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if(!ValidatePhoneNumber(txtPhoneNumber.Text) && MessagePhoneChk.Checked)
            {
                DialogResult result = MessageBox.Show("Phone Number is invalid","Error",MessageBoxButtons.RetryCancel,MessageBoxIcon.Error);
                if(result==DialogResult.Cancel)
                {
                    Close();
                }
                else
                {
                    return;
                }
            }

            if(MessageEmailChk.Checked && ValidateEmail(TxtEmail.Text))
            {
                foreach(var Subscriber in Subscribers.SubscribersList)
                {

                    if (Subscriber.Email == TxtEmail.Text)
                    {
                        MessageBox.Show("This number is already subscribed", "Already Listed", MessageBoxButtons.RetryCancel);
                    }
                }
                info = TxtEmail.Text;
                //SendByEmail send2Email = new SendByEmail(info);
               // send2Email.Subscribe(publisher);
                MessageBox.Show("You have subscribed with your Email", "Subscribed",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else if(!ValidateEmail(TxtEmail.Text) && MessageEmailChk.Checked)
            {
                DialogResult result = MessageBox.Show("Email address is invalid", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                if (result == DialogResult.Cancel)
                {
                    Close();
                }
                else
                {
                    return;
                }
            }

            //Purposely added the empty field but corrected when displaying
            Subscribers.SubscribersList.Add(new Subscribers(TxtEmail.Text, txtPhoneNumber.Text));
            Close();
        }
        /// <summary>
        /// This method unsubscribes users
        /// </summary>
        private void Unsubscribe(object sender, EventArgs e)
        {
            if(MessageEmailChk.Checked)
            {
                var user = Subscribers.SubscribersList.Find(item => item.Email.Contains(TxtEmail.Text));
                if(user!=null)
                {
                    DialogResult result = MessageBox.Show("Email Found are you sure you want to Unsubscribe " + user.Email + "?", "Unsubscribing", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        Subscribers.SubscribersList.Remove(user);
                        MessageBox.Show("Email Succesfully Unsubscribed","Ubsubscribe",MessageBoxButtons.OK);
                    }
                }
                
            }
            else if(MessagePhoneChk.Checked)
           {
                var user = Subscribers.SubscribersList.Find(item => item.Email.Contains(txtPhoneNumber.Text));
                if (user != null)
                {
                    DialogResult result = MessageBox.Show("Email Found are you sure you want to Unsubscribe " + user.PhoneNumber + "?", "Unsubscribing", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        Subscribers.SubscribersList.Remove(user);
                        MessageBox.Show("Email Succesfully Unsubscribed", "Ubsubscribe", MessageBoxButtons.OK);
                    }
                }
            }
        }
        /// <summary>
        /// THis method validates email address
        /// </summary>
        /// <param name="emailaddress"></param>
        /// <returns></returns>
        private bool ValidateEmail(string emailaddress)
        {
            try
            {
                MailAddress m = new MailAddress(emailaddress);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }
        /// <summary>
        /// This method validates the phone number
        /// </summary>
        /// <param name="phonenumber"></param>
        /// <returns></returns>
        private bool ValidatePhoneNumber(string phonenumber)
        {
            return Regex.Match(phonenumber, @"\(?\d{3}\)?-? *\d{3}-? *-?\d{4}").Success;        
        }
    }
}
