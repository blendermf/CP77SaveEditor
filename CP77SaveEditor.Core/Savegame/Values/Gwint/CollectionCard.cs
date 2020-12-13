using CP77SaveEditor.Core.Savegame.Attributes;

namespace CP77SaveEditor.Core.Savegame.Values.Gwint
{
    public class CollectionCard
    {
        [CName("cardIndex")]
        public uint CardIndex { get; set; }

        [CName("numCopies")]
        public uint NumCopies { get; set; }
    }
}