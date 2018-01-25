using System;

using TimeRecorder_Master.ViewModels;

using Windows.UI.Xaml.Controls;

namespace TimeRecorder_Master.Views
{
    public sealed partial class TabbedPage : Page
    {
        public TabbedViewModel ViewModel { get; } = new TabbedViewModel();

        public TabbedPage()
        {
            InitializeComponent();
        }
    }
}
