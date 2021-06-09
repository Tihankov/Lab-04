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

namespace Lab04
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnChange_Click(object sender, RoutedEventArgs e)
        {
            if (txtBox1.Text == "" && txtBox2.Text == "")
            {
                MessageBox.Show("At least one text box should be with text!", "Error");
            }
            else
            {
                string text;
                text = txtBox1.Text;
                txtBox1.Text = txtBox2.Text;
                txtBox2.Text = text;
            }
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Are you sure?", "Closing...", MessageBoxButton.OKCancel);
            if (result == MessageBoxResult.OK)
            {
                Close();
            }
        }
    }
}
