using System;

namespace Skyline.DataMiner.ConnectorAPI.Kordiam
{
    public class ProductionJob
    {
        public string Id { get; set; }

        public string Kind { get; set; }

        public string Status { get; set; }

        public DateTime OriginalStartTime { get; set; }

        public DateTime OriginalEndTime { get; set; }

        public DateTime PlannedStartTime { get; set; }

        public DateTime PlannedEndTime { get; set; }

        public string EditorialTeam { get; set; }

        public string Assignee { get; set; }

        public string InstructionSource { get; set; }

        public string InstructionSourceUnit { get; set; }

        public string ExternalLink { get; set; }

        public string ExternalLinkLabel { get; set; }

        public string PlanningInfo { get; set; }

        public string StoryPlanId { get; set; }
    }
}
