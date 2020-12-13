using CP77SaveEditor.Core.Savegame.Attributes;

namespace CP77SaveEditor.Core.Savegame.Values.Gwint
{
    public class GwintDecks
    {
        [CName("DeckCount")]
        public uint DeckCount { get; set; }

        public GwintDeck[] Decks { get; set; }
    }
}