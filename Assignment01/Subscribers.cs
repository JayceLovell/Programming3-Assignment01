using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment01
{
    class Subscribers
    {
        private string _email;
        private string _phonenumber;

        public string Email
        {
            get
            {
                return this._email;
            }
            set
            {
                this._email = value;
            }
        }
        public string PhoneNumber
        {
            get
            {
                return this._phonenumber;
            }
            set
            {
                this._phonenumber = value;
            }
        }

        public Subscribers(string email,string phonenumber)
        {
            this.Email = email;
            this.PhoneNumber = phonenumber;
        }
        public static List<Subscribers> SubscribersList = new List<Subscribers>();

    }
}
