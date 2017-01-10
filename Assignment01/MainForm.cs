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
    public partial class Mainform : Form
    {
        public Mainform()
        {
            InitializeComponent();
        }
        /// <summary>
        /// This method closes the application
        /// </summary>
        private void Exitbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// THis method opens the Manage Subscription Form
        /// </summary>
        private void ManageSubscriptionsbtn_Click(object sender, EventArgs e)
        {
            SubscribeForm frm = new SubscribeForm();
            frm.Show();
            Hide();
        }
        /// <summary>
        /// This method opens the Publish Notification Form
        /// </summary>
        private void PublishNotificationbtn_Click(object sender, EventArgs e)
        {
            PublishForm frm = new PublishForm();
            frm.Show();
            Hide();
        }
    }
}
