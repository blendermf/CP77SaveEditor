using CP77SaveEditor.Core.Savegame.Attributes;

namespace CP77SaveEditor.Core.Savegame.Values.Journal
{
    public class JMonsterKnown
    {
        [CName("Size")]
        public uint Size { get; set; }
        
        [CName("JMonsterKnownGuid")]
        public JMonsterKnownGuid[] MonsterKnownGuid { get; set; }
    }
}