using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment01
{
    class SendByPhoneNumber
    {
        private String PhoneNumber;
        public SendByPhoneNumber() { }
        public SendByPhoneNumber(String phone)
        {
            PhoneNumber = phone;
        }
        public void setPhoneNumber(string phone)
        {
            PhoneNumber = phone;
        }
        public String getPhoneNumber()
        {
            return PhoneNumber;
        }
        private void sendMessage(string msg)
        {
            MessageBox.Show("You have subscribed to the number  #" + PhoneNumber,"Subscribe Successful",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
        public void Subscribe(Publisher pub)
        {
            pub.publishmsg += sendMessage;
        }
    }
}
