namespace Skyline.DataMiner.ConnectorAPI.Kordiam.InterApp
{
    using Skyline.DataMiner.ConnectorAPI.Kordiam.Data;
    using Skyline.DataMiner.Core.InterAppCalls.Common.CallSingle;

    /// <summary>
    /// Represents a message containing order information.
    /// </summary>
    public class OrderInfoMessage : Message
    {
        /// <summary>
        /// Gets or sets the order information.
        /// </summary>
        public OrderInfo OrderInfo { get; set; }
    }
}
