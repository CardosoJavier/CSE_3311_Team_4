using ApiVault.ViewModels;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Microsoft.Extensions.DependencyInjection;

namespace ApiVault.Views
{
    public partial class LoginView : UserControl
    {
        // Constructor to initialize view component
        public LoginView()
        {
            InitializeComponent();

            // Dependency injection
            DataContext = App.ServiceProvider.GetService<LoginViewModel>();

            if (DataContext is LoginViewModel viewModel)
            {
                viewModel.LoginSuccessful += (sender, e) => NavTo2FA();
            }
        }

        private void NavToDashboard()
        {
            if (this.Parent is Window mainWindow)
            {
                mainWindow.Content = new AppContentView(); // Ensure you have a DashboardView defined
            }
        }

        private void NavTo2FA()
        {
            if (this.Parent is Window mainWindow)
            {
                mainWindow.Content = new _2FAPageView();
            }
        }

        
        // Navigate to sign up view by reasingning main window content
        private void NavToSignUpView(object sender, RoutedEventArgs e)
        {
            if (this.Parent is Window mainWindow)
            {
                mainWindow.Content = new SignUpView();
            }
        }
    }
}
