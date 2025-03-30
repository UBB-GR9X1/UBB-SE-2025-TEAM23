using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using StockNewsPage.Services;

namespace StockNewsPage
{
    public partial class App : Application
    {
        // to access the current window
        public static Window CurrentWindow { get; set; }

        public App()
        {
            this.InitializeComponent();
        }

        protected override void OnLaunched(Microsoft.UI.Xaml.LaunchActivatedEventArgs args)
        {
            // create and activate the main window
            CurrentWindow = new MainWindow();
            CurrentWindow.Activate();
        }
    }
}