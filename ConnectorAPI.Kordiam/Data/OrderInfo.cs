namespace Skyline.DataMiner.ConnectorAPI.Kordiam.Data
{
    using System;

    /// <summary>
    /// Represents information about an order.
    /// </summary>
    public class OrderInfo
    {
        /// <summary>
        /// Gets or sets the production job ID.
        /// </summary>
        public string ProductionJobId { get; set; }

        /// <summary>
        /// Gets or sets the label.
        /// </summary>
        public Label Label { get; set; }

        /// <summary>
        /// Gets or sets the URL of an external resource.
        /// </summary>
        public string ExternalLink { get; set; }

        /// <summary>
        /// Gets or sets the current status.
        /// </summary>
        public Status Status { get; set; }

        /// <summary>
        /// Gets or sets the resource.
        /// </summary>
        public string Resource { get; set; }

        /// <summary>
        /// Gets or sets the start time.
        /// </summary>
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// Gets or sets the end time.
        /// </summary>
        public DateTime? EndTime { get; set; }
    }
}