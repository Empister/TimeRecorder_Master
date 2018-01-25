using System;
using System.Collections.ObjectModel;

using TimeRecorder_Master.Helpers;
using TimeRecorder_Master.Models;
using TimeRecorder_Master.Services;

namespace TimeRecorder_Master.ViewModels
{
    public class ChartViewModel : Observable
    {
        public ChartViewModel()
        {
        }

        public ObservableCollection<DataPoint> Source
        {
            get
            {
                // TODO WTS: Replace this with your actual data
                return SampleDataService.GetChartSampleData();
            }
        }
    }
}
