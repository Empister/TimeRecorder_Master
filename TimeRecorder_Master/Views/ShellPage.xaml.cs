﻿using System;

using TimeRecorder_Master.ViewModels;

using Windows.UI.Xaml.Controls;

namespace TimeRecorder_Master.Views
{
    public sealed partial class ShellPage : Page
    {
        public ShellViewModel ViewModel { get; } = new ShellViewModel();

        public ShellPage()
        {
            InitializeComponent();
            DataContext = ViewModel;
            ViewModel.Initialize(shellFrame);
        }
    }
}
