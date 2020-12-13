using CP77SaveEditor.Core.Savegame.Attributes;

namespace CP77SaveEditor.Core.Savegame.Values.Quests
{
    [CSerializable("conditions")]
    public class QuestConditions
    {
        public QuestConditions()
        {
            
        }

        [CArray("numConditions", ElementName = "p")]
        public QuestCondition[] Conditions { get; set; }
    }
}