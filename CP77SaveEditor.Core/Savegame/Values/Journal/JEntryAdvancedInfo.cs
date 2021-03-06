﻿using CP77SaveEditor.Core.Savegame.Attributes;

namespace CP77SaveEditor.Core.Savegame.Values.Journal
{
    public class JEntryAdvancedInfo
    {
        [CName("Size")]
        public uint Size { get; set; }

        [CName("JEntryAdvancedInfoGuid")]
        public JEntryAdvancedInfoGuid[] JEntryAdvancedInfoGuid { get; set; }
    }
}