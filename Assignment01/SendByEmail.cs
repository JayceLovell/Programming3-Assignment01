using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment01
{
    class SendByEmail
    {
        private String Email;
        public SendByEmail() { }
        public SendByEmail(String email)
        {
            Email = email;
        }
        public void setEmail(string email)
        {
            Email = email;
        }
        public String getEmail()
        {
            return Email;
        }
        private void sendMessage(string msg)
        {
            MessageBox.Show("You have subscribed to the Email Address : " + Email, "Subscribe Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void Subscribe(Publisher pub)
        {
            pub.publishmsg += sendMessage;
        }
    }
}
