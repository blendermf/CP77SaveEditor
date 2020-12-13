using CP77SaveEditor.Core.Savegame.Attributes;

namespace CP77SaveEditor.Core.Savegame.Values
{
    [CSerializable("entry")]
    public class FactEntry
    {
        [CName("value")]
        public int Value { get; set; }
        [CName("time")]
        public double Time { get; set; }
        [CName("expiryTime")]
        public double ExpiryTime { get; set; }
    }
}