using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
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

namespace Onlypans_Parcial
{
    /// <summary>
    /// Lógica de interacción para Page3.xaml
    /// </summary>
    public partial class Page3 : Page
    {
        public Page3()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow p = (MainWindow)Window.GetWindow(this);
            p.MainFrame.NavigationService.Navigate(new Page1());
        }

        private void Client_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            DateTime savenow = DateAndTime.Now;
            string name = Client.Text;
            string Ced = Cd.Text;
            string Canti = Cant.Text;
            string type = lbltype.Content.ToString();
            string cost = lblprice.Text;

            txtresult.Text += "\n" + name + "\n" + Ced + "\n" + type + "\n" + Canti + "\n" + cost + "\n" + savenow;
        }

        private void Cant_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb.IsChecked.Value)
            {
                lbltype.Content = rb.Content.ToString();
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MainWindow w = (MainWindow)Window.GetWindow(this);
            w.MainFrame.NavigationService.Navigate(new Page1());
        }
    }   
}
