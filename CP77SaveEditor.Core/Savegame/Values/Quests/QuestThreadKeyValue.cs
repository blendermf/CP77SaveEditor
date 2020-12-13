using System;
using CP77SaveEditor.Core.Savegame.Attributes;

namespace CP77SaveEditor.Core.Savegame.Values.Quests
{
    [CSerializable("questThreadKeyValue", Custom = true)]
    public class QuestThreadKeyValue
    {
        public QuestThreadKeyValue()
        {

        }

        [CName("GUID")]
        public Guid Guid { get; set; }

        [CName("questThread")]
        public QuestThread Thread { get; set; }

    }
}