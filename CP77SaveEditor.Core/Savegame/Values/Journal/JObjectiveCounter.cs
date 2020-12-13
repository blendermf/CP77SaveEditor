using System;
using CP77SaveEditor.Core.Savegame.Attributes;

namespace CP77SaveEditor.Core.Savegame.Values.Journal
{
    public class JObjectiveCounter
    {
        [CName("guid")]
        public Guid Guid { get; set; }

        [CName("count")]
        public int Count { get; set; }
    }
}