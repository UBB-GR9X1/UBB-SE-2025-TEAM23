using Microsoft.UI.Xaml;
using StockNewsPage.Services;
using StockNewsPage.Views;

namespace StockNewsPage
{
    public sealed partial class MainWindow : Window
    {
        public MainWindow()
        {
            this.InitializeComponent();

            Title = "Stock News Page";

            App.CurrentWindow = this;

            NavigationService.Instance.Initialize(ContentFrame);

            NavigationService.Instance.Navigate(typeof(NewsListView));
        }
    }
}