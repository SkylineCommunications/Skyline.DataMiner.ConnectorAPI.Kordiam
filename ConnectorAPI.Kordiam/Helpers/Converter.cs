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

            if (storyPlanRow.Length < 5)
            {
                throw new ArgumentException($"Expected story plan row to have at least 5 items, got {storyPlanRow.Length} instead", nameof(storyPlanRow));
            }

            return new StoryPlan
            {
                Id = Convert.ToString(storyPlanRow[KordiamProtocol.StoryPlanTable.IdColumnIndex]),
                Title = Convert.ToString(storyPlanRow[KordiamProtocol.StoryPlanTable.TitleColumnIndex]),
                Description = Convert.ToString(storyPlanRow[KordiamProtocol.StoryPlanTable.DescriptionColumnIndex]),
                Kind = Convert.ToString(storyPlanRow[KordiamProtocol.StoryPlanTable.KindColumnIndex]),
                Timestamp = DateTime.FromOADate(Convert.ToDouble(storyPlanRow[KordiamProtocol.StoryPlanTable.TimestampColumnIndex]))
            };
        }

        public static ProductionJob ConvertRowToProductionJob(object[] productionJobRow)
        {
            if (productionJobRow is null)
            {
                throw new ArgumentNullException(nameof(productionJobRow));
            }

            if (productionJobRow.Length < 15)
            {
                throw new ArgumentException($"Expected production job row to have at least 15 items, got {productionJobRow.Length} instead", nameof(productionJobRow));
            }

            return new ProductionJob
            {
                Id = Convert.ToString(productionJobRow[KordiamProtocol.ProductionJobTable.IdColumnIndex]),
                StoryPlanId = Convert.ToString(productionJobRow[KordiamProtocol.ProductionJobTable.StoryPlanIdColumnIndex]),
                Kind = Convert.ToString(productionJobRow[KordiamProtocol.ProductionJobTable.KindColumnIndex]),
                OriginalStartTime = DateTime.FromOADate(Convert.ToDouble(productionJobRow[KordiamProtocol.ProductionJobTable.OriginalStartTimeColumnIndex])),
                OriginalEndTime = DateTime.FromOADate(Convert.ToDouble(productionJobRow[KordiamProtocol.ProductionJobTable.OriginalEndTimeColumnIndex])),
                PlannedStartTime = DateTime.FromOADate(Convert.ToDouble(productionJobRow[KordiamProtocol.ProductionJobTable.PlannedStartTimeColumnIndex])),
                PlannedEndTime = DateTime.FromOADate(Convert.ToDouble(productionJobRow[KordiamProtocol.ProductionJobTable.PlannedEndTimeColumnIndex])),
                EditorialTeam = Convert.ToString(productionJobRow[KordiamProtocol.ProductionJobTable.EditorialTeamColumnIndex]),
                Assignee = Convert.ToString(productionJobRow[KordiamProtocol.ProductionJobTable.AssignedToColumnIndex]),
                InstructionSource = Convert.ToString(productionJobRow[KordiamProtocol.ProductionJobTable.InstructionSourceColumnIndex]),
                InstructionSourceUnit = Convert.ToString(productionJobRow[KordiamProtocol.ProductionJobTable.InstructionSourceUnitColumnIndex]),
                ExternalLink = Convert.ToString(productionJobRow[KordiamProtocol.ProductionJobTable.ExternalLinkColumnIndex]),
                ExternalLinkLabel = Convert.ToString(productionJobRow[KordiamProtocol.ProductionJobTable.ExternalLinkLabelColumnIndex]),
                Status = Convert.ToString(productionJobRow[KordiamProtocol.ProductionJobTable.StatusColumnIndex]),
                AdditionalInfo = Convert.ToString(productionJobRow[KordiamProtocol.ProductionJobTable.AdditionalInfoColumnIndex]),
            };
        }
    }
}
