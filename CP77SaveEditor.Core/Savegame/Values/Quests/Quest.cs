using CP77SaveEditor.Core.Savegame.Attributes;

namespace CP77SaveEditor.Core.Savegame.Values.Quests
{
    [CSerializable("quest")]
    public class Quest
    {
        [CName("fileName")]
        public string FileName { get; set; }

        [CName("questThread")]
        public QuestThread QuestThread { get; set; }

    }
}