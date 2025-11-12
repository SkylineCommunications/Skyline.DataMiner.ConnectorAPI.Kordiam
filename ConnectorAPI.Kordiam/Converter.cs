namespace Skyline.DataMiner.ConnectorAPI.Kordiam
{
    using System;

    public static class Converter
    {
        public static StoryPlan ConvertRowToStoryPlan(object[] storyPlanRow)
        {
            if (storyPlanRow == null)
            {
                throw new ArgumentNullException(nameof(storyPlanRow));
            }

            return new StoryPlan();
        }

        public static ProductionJob ConvertRowToProductionJob(object[] productionJobRow)
        {
            if (productionJobRow is null)
            {
                throw new ArgumentNullException(nameof(productionJobRow));
            }

            return new ProductionJob();
        }
    }
}
