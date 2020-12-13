using System;
using CP77SaveEditor.Core.Savegame.Attributes;

namespace CP77SaveEditor.Core.Savegame.Values.Quests
{
    [CSerializable("ExternalDialog")]
    public class ExternalDialog
    {
        [CName("tag")]
        public string Tag { get; set; }
        [CArray("dialogsCount")]
        public Guid[] Dialogs { get; set; }
    }
}