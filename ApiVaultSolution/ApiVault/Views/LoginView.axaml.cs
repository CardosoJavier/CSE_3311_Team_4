using Avalonia.Controls;
using Avalonia.Interactivity;

namespace ApiVault.Views
{
    public partial class LoginView : UserControl
    {
        // Constructor to initialize view component
        public LoginView()
        {
            InitializeComponent(); 
        }

        // Navigate to sign up view
        private void NavToSignUpView(object sender, RoutedEventArgs e)
        {
            if (this.Parent is Window mainWindow)
            {
                mainWindow.Content = new SignUpView();
            }
        }

        // Navigate to dashboard when login success
        private void NavToDashboard(object sender, RoutedEventArgs e)
        {
            if (this.Parent is Window mainWindow)
            {
                mainWindow.Content = new AppContentView();
            }
        }
    }
}