namespace Skyline.DataMiner.ConnectorAPI.Kordiam.InterApp
{
    using System;
    using System.Collections.Generic;
    using Skyline.DataMiner.Core.InterAppCalls.Common.CallBulk;

    public static class InterAppKnownTypes
    {
        public static IReadOnlyCollection<Type> KnownTypes { get; } = new List<Type>
        {
            typeof(IInterAppCall),
            typeof(OrderInfoMessage),
        };
    }
}
