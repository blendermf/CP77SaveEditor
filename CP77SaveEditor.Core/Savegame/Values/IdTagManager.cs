using CP77SaveEditor.Core.Savegame.Attributes;

namespace CP77SaveEditor.Core.Savegame.Values
{
    [CName("idTagManager")]
    public class IdTagManager
    {
        [CName("tagIndex")]
        public ulong TagIndex { get; set; }
    }
}