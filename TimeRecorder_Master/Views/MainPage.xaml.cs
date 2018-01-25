using System;

using TimeRecorder_Master.ViewModels;

using Windows.UI.Xaml.Controls;

namespace TimeRecorder_Master.Views
{
    public sealed partial class MainPage : Page
    {
        public MainViewModel ViewModel { get; } = new MainViewModel();

        public MainPage()
        {
            InitializeComponent();
        }
    }
}
