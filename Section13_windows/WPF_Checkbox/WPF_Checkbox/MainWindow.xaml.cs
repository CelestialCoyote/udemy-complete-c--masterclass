﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF_Checkbox
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void cbAllToppingsCheckedChanged(object sender, RoutedEventArgs e)
        {
            bool newVal = cbAllToppings.IsChecked == true;
            cbSalami.IsChecked = newVal;
            cbMushrooms.IsChecked = newVal;
            cbMozzarella.IsChecked = newVal;
        }

        private void cbSingleCheckedChanged(object sender, RoutedEventArgs e)
        {
            cbAllToppings.IsChecked = null;

            if ((cbSalami.IsChecked == true) && (cbMushrooms.IsChecked == true) && (cbMozzarella.IsChecked == true))
                cbAllToppings.IsChecked = true;
            if ((cbSalami.IsChecked == false) && (cbMushrooms.IsChecked == false) && (cbMozzarella.IsChecked == false))
                cbAllToppings.IsChecked = false;
        }
    }
}