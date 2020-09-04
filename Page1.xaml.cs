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
    /// Lógica de interacción para Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (TtxUsername.Text == "Admin" && Password.Password == "1234")
            {
                MainWindow w = (MainWindow)Window.GetWindow(this);
                w.MainFrame.NavigationService.Navigate(new Page2());
            }
            else if (TtxUsername.Text == "Worker" && Password.Password == "4231")
            {
                MainWindow w = (MainWindow)Window.GetWindow(this);
                w.MainFrame.NavigationService.Navigate(new Page3());
            }
            else
            {
                MessageBox.Show("Invalid credentials");
            } 
        }   
    }
}