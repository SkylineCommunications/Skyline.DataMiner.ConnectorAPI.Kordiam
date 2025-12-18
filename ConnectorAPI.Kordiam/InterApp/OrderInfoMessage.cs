namespace Skyline.DataMiner.ConnectorAPI.Kordiam.InterApp
{
    using Skyline.DataMiner.ConnectorAPI.Kordiam.Data;
    using Skyline.DataMiner.Core.InterAppCalls.Common.CallSingle;

    public class OrderInfoMessage : Message
    {
        public OrderInfo OrderInfo { get; set; }
    }
}
