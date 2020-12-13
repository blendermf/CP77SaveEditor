using System;
using CP77SaveEditor.Core.Savegame.Attributes;

namespace CP77SaveEditor.Core.Savegame.Values.Journal
{
    public class JTrackedQuest
    {
        [CName("guid")]
        public Guid Guid { get; set; }
    }
}