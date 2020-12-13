using CP77SaveEditor.Core.Savegame.Attributes;

namespace CP77SaveEditor.Core.Savegame.Values.Journal
{
    public class JHuntingClues
    {
        [CName("Size")]
        public uint Size { get; set; }

        public JHuntingClue[] Clues { get; set; }
    }
}