
namespace Skyline.DataMiner.ConnectorAPI.Kordiam
{
    using System;

    public class OrderInfo
    {
        public string Label { get; set; }

        public string ExternalLink { get; set; }

        public string Status { get; set; }

        public string LiveUResource { get; set; }

        public DateTime? StartTime { get; set; }

        public DateTime? EndTime { get; set; }
    }
}
