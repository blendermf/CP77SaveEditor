using CP77SaveEditor.Core.Savegame.Attributes;

namespace CP77SaveEditor.Core.Savegame.Values
{
    public class EntityStateChangeRequests
    {
        [CName("requestsCount")]
        public uint RequestsCount { get; set; }
    }
}