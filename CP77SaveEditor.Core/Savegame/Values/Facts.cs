using CP77SaveEditor.Core.Savegame.Attributes;

namespace CP77SaveEditor.Core.Savegame.Values
{
    [CSerializable("facts")]
    public class Facts
    {
        [CArray]
        public Fact[] Items { get; set; }
    }
}