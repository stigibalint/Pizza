using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;


namespace Pizza
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void SwitchToRegister_Click(object sender, RoutedEventArgs e)
        {
            loginPanel.Visibility = Visibility.Collapsed;
            registerPanel.Visibility = Visibility.Visible;
        }

        private void SwitchToLogin_Click(object sender, RoutedEventArgs e)
        {
            registerPanel.Visibility = Visibility.Collapsed;
            loginPanel.Visibility = Visibility.Visible;
        }

    }
}
