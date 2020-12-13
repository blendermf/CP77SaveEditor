using CP77SaveEditor.Core.Savegame.Attributes;

namespace CP77SaveEditor.Core.Savegame.Values.Quests
{
    [CSerializable("questThread")]
    public class QuestThread
    {
        public QuestThread()
        {
            
        }

        [CArray("numBlocksToActivate")]
        public QuestBlock[] QuestBlocksToActivate { get; set; }

        [CArray("numBlocks")]
        public QuestBlock[] QuestBlocks { get; set; }

        [CArray("numThreads", ElementName = "questThread")]
        public QuestThreadKeyValue[] QuestThreads { get; set; }
    }
}