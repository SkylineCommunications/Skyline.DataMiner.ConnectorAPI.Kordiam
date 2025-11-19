namespace Skyline.DataMiner.ConnectorAPI.Kordiam
{
    using System;
    using Microsoft.Extensions.Logging;
    using Skyline.DataMiner.ConnectorAPI.Kordiam.Data;
    using Skyline.DataMiner.ConnectorAPI.Kordiam.Helpers;
    using Skyline.DataMiner.Core.DataMinerSystem.Common;
    using Skyline.DataMiner.Net;

    /// <inheritdoc/>
    public class ConnectorApi : IConnectorApi
    {
        private readonly ILogger logger;

        private readonly IDmsElement element;

        private static readonly int storyPlanTableId = 100; // TODO Verify table ID
        private static readonly int productionJobTableId = 200; // TODO Verify table ID

        /// <summary>
        /// Creates an instance of the Connector API.
        /// </summary>
        /// <param name="connection"></param>
        /// <param name="agentId"></param>
        /// <param name="elementId"></param>
        /// <param name="logger"></param>
        public ConnectorApi(IConnection connection, int agentId, int elementId, ILogger logger)
        {
            if (connection == null) throw new ArgumentNullException(nameof(connection));
            if (agentId < 0) throw new ArgumentOutOfRangeException(nameof(agentId), "Agent ID cannot be negative");
            if (elementId < 0) throw new ArgumentOutOfRangeException(nameof(elementId), "Element ID cannot be negative");

            var dms = connection.GetDms();
            this.element = dms.GetElement(new DmsElementId(agentId, elementId));
            if (element.State != ElementState.Active) throw new InvalidOperationException($"Element {element.Name} is not active");

            this.logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        /// <inheritdoc/>
        public StoryPlan GetStoryPlan(string storyPlanId)
        {
            if (String.IsNullOrWhiteSpace(storyPlanId))
            {
                throw new ArgumentNullException(nameof(storyPlanId));
            }

            var storyPlanTable = element.GetTable(storyPlanTableId);

            if (!storyPlanTable.RowExists(storyPlanId))
            {
                logger.LogInformation($"Story plan with ID {storyPlanId} does not exist.");
                return null;
            }

            var storyPlanRow = element.GetTable(storyPlanTableId).GetRow(storyPlanId);

            return Converter.ConvertRowToStoryPlan(storyPlanRow);
        }

        /// <inheritdoc/>
        public ProductionJob GetProductionJob(string productionJobId)
        {
            if (String.IsNullOrWhiteSpace(productionJobId))
            {
                throw new ArgumentNullException(nameof(productionJobId));
            }

            var productionJobTable = element.GetTable(productionJobTableId);

            if (!productionJobTable.RowExists(productionJobId))
            {
                logger.LogInformation($"Production job with ID {productionJobId} does not exist.");
                return null;
            }

            var productionJobRow = element.GetTable(productionJobTableId).GetRow(productionJobId);

            return Converter.ConvertRowToProductionJob(productionJobRow);
        }

        /// <inheritdoc/>
        public void ReportOrderInfo(OrderInfo orderInfo)
        {
            throw new NotImplementedException(); //TODO Will be implemented in DCP284156
        }
    }
}
