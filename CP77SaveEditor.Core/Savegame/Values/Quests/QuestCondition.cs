using CP77SaveEditor.Core.Savegame.Attributes;

namespace CP77SaveEditor.Core.Savegame.Values.Quests
{
    [CSerializable("questCondition", Custom = true)]
    public class QuestCondition
    {
        [CName("nP")]
        public uint Np { get; set; }

        [CName("active")]
        public bool Active { get; set; }
    }
}