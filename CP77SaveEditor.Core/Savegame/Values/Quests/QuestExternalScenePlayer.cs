using CP77SaveEditor.Core.Savegame.Attributes;

namespace CP77SaveEditor.Core.Savegame.Values.Quests
{
    [CSerializable("CQuestExternalScenePlayer")]
    public class QuestExternalScenePlayer
    {
        public QuestExternalScenePlayer()
        {
            
        }

        [CArray("tagsCount")]
        public ExternalDialog[] ExternalDialogs { get; set; }

        [CArray("numQuests")]
        public Quest[] Quests { get; set; }
    }
}