using Windows.ApplicationModel.DataTransfer;

namespace TimeRecorder_Master.Models
{
    public class DragDropData
    {
        public DataPackageOperation AcceptedOperation { get; set; }

        public DataPackageView DataView { get; set; }
    }
}
