using Skyline.DataMiner.ConnectorAPI.Kordiam.Data;

namespace Skyline.DataMiner.ConnectorAPI.Kordiam
{
    /// <summary>
    /// An API to interact with a Kordiam connector element.
    /// </summary>
    public interface IConnectorApi
    {
        /// <summary>
        /// Gets a production job by its ID.
        /// </summary>
        /// <param name="productionJobId">The ID of the production job to get.</param>
        /// <returns>The production job if it exists, otherwise null.</returns>
        ProductionJob GetProductionJob(string productionJobId);

        /// <summary>
        /// Gets a story plan by its ID.
        /// </summary>
        /// <param name="storyPlanId">The ID of the story plan to get.</param>
        /// <returns>The story plan if it exists, otherwise null.</returns>
        StoryPlan GetStoryPlan(string storyPlanId);

        /// <summary>
        /// Sends info about an order to the Kordiam element.
        /// </summary>
        /// <param name="orderInfo">Information about the order.</param>
        void ReportOrderInfo(OrderInfo orderInfo);
    }
}