/*
 * Author: Jonathan Binns
 * Purpose: A class to contain all the attributes and methods for the Mailing list
 * Date Last Modified: 01/11/18 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessObjects
{
    public class MailingList
    {
        //creates a private list of customers called _list
        private List<Customer> _list = new List<Customer>();

        //method to add a customer to the list
        public void add(Customer newCustomer)
        {
            _list.Add(newCustomer);
        }

        //method to find a customer in a list
        public Customer find(int matric)
        {
            //takes in an int, matric and checks it agaist every customers ID in the list
            foreach (Customer c in _list)
            {
                if (matric == c.ID)
                {
                    return c;
                }
            }

            return null;

        }

        //method to delete a customer from the list
        public void delete(int id)
        {
            //calls the find method to search for an ID and if it doesnt return null removes the customer
            Customer c = this.find(id);
            if (c != null)
            {
                _list.Remove(c);
            }

        }

        //creates a list of matrics
        public List<int> matrics
        {
            get
            {
               //takes the matrics of all of the customers and adds them to a list called res
               List<int> res = new List<int>();
               //adds a metric to every customer in _list
               foreach(Customer p in _list)
                   res.Add(p.Matric);
                return res;
            }
           
        }
    }
}
