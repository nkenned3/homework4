using System;
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
using System.Text.RegularExpressions;


namespace Homework4
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


        private void Button_Loaded(object sender, RoutedEventArgs e)
        {            
            if (!isZipCode(uxTexBox.Text))
            {
                uxTexBox.Text = "";
            }
            MessageBox.Show("Ok!");
        }

        private void uxTexBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            uxButton.IsEnabled = (isZipCode(uxTexBox.Text));
            
        }
        private bool isZipCode(string text)
        {
            var usZipRegEx = @"^\d{5}(?:[-\s]\d{4})?$";
            var caZipRegEx = @"^([A-Z]\d[A-Z])\ {0,1}(\d[A-Z]\d)$";

            Regex regex = new Regex(usZipRegEx);
            Regex regex1 = new Regex(caZipRegEx);
            bool match = regex.IsMatch(text) || regex1.IsMatch(text);
            return match;
        }
    }
}
