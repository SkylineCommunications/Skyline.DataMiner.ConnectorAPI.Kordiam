namespace Skyline.DataMiner.ConnectorAPI.Kordiam.Data
{
    using System;

    public class StoryPlan
    {
        public string Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string Kind { get; set; }

        public DateTime Timestamp { get; set; }
    }
}