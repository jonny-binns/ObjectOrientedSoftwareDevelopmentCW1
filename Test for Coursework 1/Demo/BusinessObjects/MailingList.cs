using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessObjects
{
    public class MailingList
    {
        private List<Customer> _list = new List<Customer>();
        public string details;

        public void add(Customer newCustomer)
        {
            _list.Add(newCustomer);
        }

        public Customer find(int matric)
        {
            foreach (Customer c in _list)
            {
                if (matric == c.ID)
                {
                    return c;
                }
            }

            return null;

        }

        public void delete(int id)
        {
            Customer c = this.find(id);
            if (c != null)
            {
                _list.Remove(c);
            }

        }

        public List<int> matrics
        {
            get
            {
               List<int> res = new List<int>();
               foreach(Customer p in _list)
                   res.Add(p.Matric);
                return res;
            }
           
        }

        
        public void show()
        {
            foreach(Customer c in _list)
            {
                details = c.getDetails();
            }
        }
        
    }
}
