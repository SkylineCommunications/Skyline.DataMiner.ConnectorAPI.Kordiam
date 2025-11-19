namespace Skyline.DataMiner.ConnectorAPI.Kordiam.Data
{
    using System;

    public class ProductionJob
    {
        public string Id { get; set; }

        public string Kind { get; set; }

        public string Status { get; set; }

        //TODO: verify if DateTime or DateTime?
        public DateTime OriginalStartTime { get; set; }

        //TODO: verify if DateTime or DateTime?
        public DateTime OriginalEndTime { get; set; }

        //TODO: verify if DateTime or DateTime?
        public DateTime PlannedStartTime { get; set; }

        //TODO: verify if DateTime or DateTime?
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
