/*
 * v.2.2.3
 * Author: Jonathan Binns
 * Purpose: to store, retreive and delete customer details from a list
 * Date Last Modified: 01/11/18 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using BusinessObjects;

namespace Demo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //creates a new instance of mailing list called store
        private MailingList store = new MailingList();
        //creates the autoID variable and sets it to the minimum value 10001
        //comment out the below line if you want to test the program without the automatically generating id
        int autoID = 10001;
        //creates a string to store all the customers data
        public static string AllCustomers;

        public MainWindow()
        {
            InitializeComponent();
            //displays the value of autoID in the ID text box
            //comment out the below line if you want to test the program without the automatically generating id
            IDTxt.Text = autoID.ToString();
        }

        private void SaveCustomerBtn_Click(object sender, RoutedEventArgs e)
        {
            //creates a new instance of customer
            Customer c = new Customer();

            //tries the enclosed code, if the code throws an exception it is caught in the below block
            try
            {
                //sets all of the properties of customer to the strings input into the text boxes
                //comment out the below line if you want to test the program without the automatically generating id
                c.ID = autoID;
                //remove the comment from the below line to test the program without the automatically generating id
                //c.ID = int.Parse(IDTxt.Text);
                c.FirstName = FirstNameTxt.Text;
                c.Surname = SurnameTxt.Text;
                c.EmailAddress = EmailAddressTxt.Text;
                c.SkypeID = SkypeIDTxt.Text;
                c.Telephone = TelephoneTxt.Text;
                c.PreferredContact = PreferredContactTxt.Text;
                //adds the customer to the list, store
                store.add(c);

                //adds all of the customers attributes to the string AllCustomers
                AllCustomers += c.Display();

                //adds the customers id to the list box as an item
                PreviousCustomersList.Items.Add(IDTxt.Text);

                //incriments autoID
                //comment out the below line if you want to test the program without the automatically generating id
                autoID++;

                //displays the value of autoID in the ID text box
                //comment out the below line if you want to test the program without the automatically generating id
                IDTxt.Text = autoID.ToString();
                //remove the comment from the below line to test the program without the automatically generating id
                //IDTxt.Text = "";

                //sets all of the other text boxes to blank
                FirstNameTxt.Text = "";
                SurnameTxt.Text = "";
                EmailAddressTxt.Text = "";
                SkypeIDTxt.Text = "";
                TelephoneTxt.Text = "";
                PreferredContactTxt.Text = "";     
            }
            //code is caught here if the above block throws an exception
            catch(Exception ex)
            {
                //displays the exception thrown
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void FindCustomerBtn_Click(object sender, RoutedEventArgs e)
        {
            //tries the enclosed code, if the code throws an exception it is caught in the below block
            try
            {
                //creates a temporary variable m to store the id to be searched. m is short for matric
                int m = int.Parse(IDTxt.Text);
                //calls the find method from store
                var c = store.find(m);

                //sets the text boxes to the relevent attributes from customer
                FirstNameTxt.Text = c.FirstName;
                SurnameTxt.Text = c.Surname;
                EmailAddressTxt.Text = c.EmailAddress;
                SkypeIDTxt.Text = c.SkypeID;
                TelephoneTxt.Text = c.Telephone;
                PreferredContactTxt.Text = c.PreferredContact;
            }
            //code is caught here if the above block throws an exception
            catch (Exception ex)
            {
                //displays the exception thrown
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void DeleteCustomerBtn_Click(object sender, RoutedEventArgs e)
        {
             //creates a temporary variable to store the id to be deleted
             int d = int.Parse(IDTxt.Text);
             //calls the delete method from store
             store.delete(d);
             
             //sets all of the text boxes to blank
             IDTxt.Text = "";
             FirstNameTxt.Text = "";
             SurnameTxt.Text = "";
             EmailAddressTxt.Text = "";
             SkypeIDTxt.Text = "";
             TelephoneTxt.Text = "";
             PreferredContactTxt.Text = "";
        }

        private void GetPreferredContactBtn_Click(object sender, RoutedEventArgs e)
        {
            //tries the enclosed code, if the code throws an exception it is caught in the below block
            try
            {
                //creates a temporary variable m to store the id to be searched. m is short for matric
                int m = int.Parse(IDTxt.Text);
                //calls the find method from store
                var c = store.find(m);
                //Sets the preferred contact text box to show the string returned from the getPreferredContact method
                PreferredContactTxt.Text = c.getPreferredContact();

                //sets all of the other text boxes to blank
                FirstNameTxt.Text = "";
                SurnameTxt.Text = "";
                EmailAddressTxt.Text = "";
                SkypeIDTxt.Text = "";
                TelephoneTxt.Text = "";
            }
            //code is caught here if the above block throws an exception
            catch (Exception ex)
            {
                //displays the exception thrown
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void ClearFormBtn_Click(object sender, RoutedEventArgs e)
        {
            
            //sets the ID text box to the value of autoID
            IDTxt.Text = autoID.ToString();
            //sets all the other text boxes to blank
            FirstNameTxt.Text = "";
            SurnameTxt.Text = "";
            EmailAddressTxt.Text = "";
            SkypeIDTxt.Text = "";
            TelephoneTxt.Text = "";
            PreferredContactTxt.Text = "";
            
        }

        private void ListAllBtn_Click(object sender, RoutedEventArgs e)
        {
            //creates a new instance of the window used to list all customers
            ListAllWindow newWin = new ListAllWindow();
            //displays the window to list all customers
            newWin.Show();
        }
    }
}
