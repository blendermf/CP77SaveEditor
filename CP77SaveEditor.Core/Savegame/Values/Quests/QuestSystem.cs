using CP77SaveEditor.Core.Savegame.Attributes;

namespace CP77SaveEditor.Core.Savegame.Values.Quests
{
    [CSerializable("questSystem")]
    public class QuestSystem
    {
        [CName("questExternalScenePlayers")]
        public QuestExternalScenePlayers QuestExternalScenePlayers { get; set; }

    }
}