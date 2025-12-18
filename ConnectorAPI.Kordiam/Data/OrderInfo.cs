namespace Skyline.DataMiner.ConnectorAPI.Kordiam.Data
{
    using System;

    public class OrderInfo
    {
        public Label Label { get; set; }

        public string ExternalLink { get; set; }

        public Status Status { get; set; }

        public string Resource { get; set; }

        public DateTime? StartTime { get; set; }

        public DateTime? EndTime { get; set; }
    }

    public enum Status
    {
        None,
        Error,
        Completed,
    }

    public enum Label
    {
        None,
        Failed,
        Preliminary,
        Planned,
        Confirmed,
        Running,
        Completed,
        Cancelled,
    }
}
