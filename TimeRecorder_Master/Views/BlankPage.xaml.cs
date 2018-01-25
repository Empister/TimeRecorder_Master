using System;

using TimeRecorder_Master.ViewModels;

using Windows.UI.Xaml.Controls;

namespace TimeRecorder_Master.Views
{
    public sealed partial class BlankPage : Page
    {
        public BlankViewModel ViewModel { get; } = new BlankViewModel();

        public BlankPage()
        {
            InitializeComponent();
        }
    }
}
