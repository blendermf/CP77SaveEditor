using CP77SaveEditor.Core.Savegame.Attributes;

namespace CP77SaveEditor.Core.Savegame.Values.Journal
{
    public class JObjectiveCounters
    {
        [CName("Size")]
        public uint Size { get; set; }

        public JObjectiveCounter[] Counters { get; set; }
    }
}