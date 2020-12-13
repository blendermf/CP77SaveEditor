using CP77SaveEditor.Core.Savegame.Attributes;

namespace CP77SaveEditor.Core.Savegame.Values.Gwint
{
    public class SelectedDeckIndex  
    {
        [CName("deckIndex")]
        [EnumName("eGwintFaction")]
        public W3Enum DeckIndex { get; set; }
    }
}