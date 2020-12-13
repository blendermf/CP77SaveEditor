using CP77SaveEditor.Core.Savegame.Attributes;

namespace CP77SaveEditor.Core.Savegame.Values.Quests
{
    [CSerializable("questExternalScenePlayers")]
    public class QuestExternalScenePlayers
    {

        public QuestExternalScenePlayers()
        {

        }

        [CName("")]
        public QuestExternalScenePlayer QuestExternalScenePlayer1 { get; set; }


        [CName("")]
        public QuestExternalScenePlayer QuestExternalScenePlayer2 { get; set; }
    }
}