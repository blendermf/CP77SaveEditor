using CP77SaveEditor.Core.Savegame.Attributes;

namespace CP77SaveEditor.Core.Savegame.Values
{
    [CSerializable("SaveInfoItem", Custom = true)]
    public class SaveInfoItem
    {
        [CName("time")]
        public ulong Time { get; set; }

        [CName("type")]
        public byte Type { get; set; }

        [CName("v")]
        public ushort V { get; set; }
    }
}