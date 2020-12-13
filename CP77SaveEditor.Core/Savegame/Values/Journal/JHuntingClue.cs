using System;
using CP77SaveEditor.Core.Savegame.Attributes;

namespace CP77SaveEditor.Core.Savegame.Values.Journal
{
    public class JHuntingClue
    {
        [CName("JHuntingQuestGuid")]
        public Guid HuntingQuestGuid { get; set; }

        [CName("Size")]
        public uint Size { get; set; }
    }
}