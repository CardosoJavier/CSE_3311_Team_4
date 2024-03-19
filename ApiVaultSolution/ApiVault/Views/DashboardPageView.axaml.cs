using ApiVault.ViewModels;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Metadata;
using System;
using System.Diagnostics;

namespace ApiVault.Views
{
    public partial class DashboardPageView : UserControl
    {
        public DashboardPageView()
        {
            InitializeComponent();

            // Bind view with corresponding ViewModel 
            DataContext = new DashboardPageViewModel();
        }
    }
}
