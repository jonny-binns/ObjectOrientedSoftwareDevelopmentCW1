/*
 * v.2.2.3
 * Author: Jonathan Binns
 * Purpose: to display the list of all customers data
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
using System.Windows.Shapes;

namespace Demo
{
    /// <summary>
    /// Interaction logic for ListAllWindow.xaml
    /// </summary>
    public partial class ListAllWindow : Window
    {
        public ListAllWindow()
        {
            InitializeComponent();
            //displays the all customers list in the customer list label
            CustomerListLbl.Content = MainWindow.AllCustomers;
        }
    }
}
