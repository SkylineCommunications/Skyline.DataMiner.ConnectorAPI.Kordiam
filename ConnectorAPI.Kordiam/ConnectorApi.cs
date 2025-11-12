using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("ConnectorAPI.KordiamTests")]

namespace Skyline.DataMiner.ConnectorAPI.Kordiam
{
    using System;
    using Microsoft.Extensions.Logging;
    using Skyline.DataMiner.Core.DataMinerSystem.Common;
    using Skyline.DataMiner.Net;

    /// <inheritdoc/>
    public class ConnectorApi : IConnectorApi
    {
        private readonly ILogger logger;

        private readonly IDmsElement element;

        private static readonly int storyPlanTableId = 100;
        private static readonly int productionJobTableId = 200;

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

        internal ConnectorApi(IDmsElement element, ILogger logger)
        {
            this.element = element ?? throw new ArgumentNullException(nameof(element));
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

            return ConvertRowToStoryPlan(storyPlanRow);
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

            return ConvertRowToProductionJob(productionJobRow);
        }

        internal static StoryPlan ConvertRowToStoryPlan(object[] storyPlanRow)
        {
            if (storyPlanRow == null)
            {
                throw new ArgumentNullException(nameof(storyPlanRow));
            }

            return new StoryPlan();
        }

        internal static ProductionJob ConvertRowToProductionJob(object[] productionJobRow)
        {
            if (productionJobRow is null)
            {
                throw new ArgumentNullException(nameof(productionJobRow));
            }

            return new ProductionJob();
        }
    }
}
