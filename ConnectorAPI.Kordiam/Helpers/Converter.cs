namespace Skyline.DataMiner.ConnectorAPI.Kordiam.Helpers
{
    using System;
    using Skyline.DataMiner.ConnectorAPI.Kordiam.Data;

    public static class Converter
    {
        public static StoryPlan ConvertRowToStoryPlan(object[] storyPlanRow)
        {
            if (storyPlanRow == null)
            {
                throw new ArgumentNullException(nameof(storyPlanRow));
            }

            // TODO Implement

            return new StoryPlan();
        }

        public static ProductionJob ConvertRowToProductionJob(object[] productionJobRow)
        {
            if (productionJobRow is null)
            {
                throw new ArgumentNullException(nameof(productionJobRow));
            }

            // TODO Implement

            return new ProductionJob();
        }
    }
}
