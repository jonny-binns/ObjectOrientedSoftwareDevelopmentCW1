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
        MailingList store = new MailingList();
        //Customer c = new Customer();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void SaveCustomerBtn_Click(object sender, RoutedEventArgs e)
        {
      
            Customer c = new Customer();
            c.ID = int.Parse(IDTxt.Text);
            c.FirstName = FirstNameTxt.Text;
            c.Surname = SurnameTxt.Text;
            c.EmailAddress = EmailAddressTxt.Text;
            c.SkypeID = SkypeIDTxt.Text;
            c.Telephone = TelephoneTxt.Text;
            c.PreferredContact = PreferredContactTxt.Text;
            store.add(c);

            //MessageBox.Show(Customer1.FirstName);
            IDTxt.Text = "";
            FirstNameTxt.Text = "";
            SurnameTxt.Text = "";
            EmailAddressTxt.Text = "";
            SkypeIDTxt.Text = "";
            TelephoneTxt.Text = "";
            PreferredContactTxt.Text = "";

            //MessageBox.Show(c.getDetails());
        }

        private void DisplayCustomerBtn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(getDetails);
        }
    }
}
