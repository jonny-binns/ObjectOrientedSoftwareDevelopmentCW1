using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessObjects
{
    public class Customer
    {
        private int _customerID;
        private string _FirstName;
        private string _Surname;
        private string _EmailAddress;
        private string _SkypeID;
        private string _Telephone;
        private string _PreferredContact;

        public int ID
        {
            get
            {
                return _customerID;
            }
            set
            {
                _customerID = value;
            }
        }

        public string FirstName
        {
            get
            {
                return _FirstName;
            }
            set
            {
                _FirstName = value;
            }
        }

        public string Surname
        {
            get
            {
                return _Surname;
            }
            set
            {
                _Surname = value;
            }
        }

        public string EmailAddress
        {
            get
            {
                return _EmailAddress;
            }
            set
            {
                _EmailAddress = value;
            }
        }

        public string SkypeID
        {
            get
            {
                return _SkypeID;
            }
            set
            {
                _SkypeID = value;
            }
        }

        public string Telephone
        {
            get
            {
                return _Telephone;
            }
            set
            {
                _Telephone = value;
            }
        }

        public string PreferredContact
        {
            get
            {
                return _PreferredContact;
            }
            set
            {
                _PreferredContact = value;
            }
        }
    }
}
