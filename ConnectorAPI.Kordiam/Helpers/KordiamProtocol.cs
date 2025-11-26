namespace Skyline.DataMiner.ConnectorAPI.Kordiam.Helpers
{
    internal static class KordiamProtocol
    {
        public static class StoryPlanTable
        {
            public const int TableId = 2000;

            public const int IdColumnIndex = 0;
            public const int KindColumnIndex = 1;
            public const int TitleColumnIndex = 2;
            public const int DescriptionColumnIndex = 3;
            public const int TimestampColumnIndex = 4;
        }

        public static class ProductionJobTable
        {
            public const int TableId = 2100;

            public const int IdColumnIndex = 0;
            public const int StoryPlanIdColumnIndex = 1;
            public const int KindColumnIndex = 2;
            public const int OriginalStartTimeColumnIndex = 3;
            public const int OriginalEndTimeColumnIndex = 4;
            public const int PlannedStartTimeColumnIndex = 5;
            public const int PlannedEndTimeColumnIndex = 6;
            public const int EditorialTeamColumnIndex = 7;
            public const int AssignedToColumnIndex = 8;
            public const int InstructionSourceColumnIndex = 9;
            public const int InstructionSourceUnitColumnIndex = 10;
            public const int ExternalLinkColumnIndex = 11;
            public const int ExternalLinkLabelColumnIndex = 12;
            public const int StatusColumnIndex = 13;
        }
    }
}
