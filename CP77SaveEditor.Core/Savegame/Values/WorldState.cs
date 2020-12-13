using CP77SaveEditor.Core.Savegame.Attributes;

namespace CP77SaveEditor.Core.Savegame.Values
{
    [CName("worldState")]
    public class WorldState
    {
        [CName("entityStateChangeRequests")]
        public EntityStateChangeRequests EntityStateChangeRequests { get; set; }
    }
}