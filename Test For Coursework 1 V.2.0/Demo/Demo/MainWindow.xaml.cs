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
        private MailingList store = new MailingList();
        int autoID = 10001;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void SaveCustomerBtn_Click(object sender, RoutedEventArgs e)
        {
            Customer c = new Customer();
            //c.ID = int.Parse(IDTxt.Text);
            //int autoID = 10001;
            c.ID = autoID;
            autoID++;
            c.FirstName = FirstNameTxt.Text;
            c.Surname = SurnameTxt.Text;
            c.EmailAddress = EmailAddressTxt.Text;
            c.SkypeID = SkypeIDTxt.Text;
            c.Telephone = TelephoneTxt.Text;
            if (PreferredContactTxt.Text == "Skype" || PreferredContactTxt.Text == "Telephone" || PreferredContactTxt.Text == "Email")
            {
                c.PreferredContact = PreferredContactTxt.Text;
            }
            
            store.add(c);

            IDTxt.Text = "";
            FirstNameTxt.Text = "";
            SurnameTxt.Text = "";
            EmailAddressTxt.Text = "";
            SkypeIDTxt.Text = "";
            TelephoneTxt.Text = "";
            PreferredContactTxt.Text = "";
        }

        private void DisplayCustomerBtn_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show("Test2");
            //MessageBox.Show(c.FirstName);
            //string s = store.show();
            //MessageBox.Show(store.show());
            //MessageBox.Show(c.getDetails);

            try
            {
                int m = int.Parse(IDTxt.Text);
                var c = store.find(m);
                /*
                FirstNameTxt.Text = c.FirstName;
                SurnameTxt.Text = c.Surname;
                EmailAddressTxt.Text = c.EmailAddress;
                SkypeIDTxt.Text = c.SkypeID;
                TelephoneTxt.Text = c.Telephone;
                PreferredContactTxt.Text = c.PreferredContact;
                */
                PreferredContactTxt.Text = c.getPreferredContact();
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void FindCustomerBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int m = int.Parse(IDTxt.Text);
                var c = store.find(m);

                FirstNameTxt.Text = c.FirstName;
                SurnameTxt.Text = c.Surname;
                EmailAddressTxt.Text = c.EmailAddress;
                SkypeIDTxt.Text = c.SkypeID;
                TelephoneTxt.Text = c.Telephone;
                PreferredContactTxt.Text = c.PreferredContact;
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void DeleteCustomerBtn_Click(object sender, RoutedEventArgs e)
        {

            int d = int.Parse(IDTxt.Text);
            store.delete(d);

            IDTxt.Text = "";
            FirstNameTxt.Text = "";
            SurnameTxt.Text = "";
            EmailAddressTxt.Text = "";
            SkypeIDTxt.Text = "";
            TelephoneTxt.Text = "";
            PreferredContactTxt.Text = "";
        }

        
        private void EmailItm_Selected(object sender, RoutedEventArgs e)
        {
          
        }

    }
}
