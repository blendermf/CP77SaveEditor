using CP77SaveEditor.Core.Savegame.Attributes;

namespace CP77SaveEditor.Core.Savegame.Values
{
    [CSerializable("CWitcherGameResource")]
    public class CWitcherGameResource
    {
        [CName("path")]
        public string Path { get; set; }
    }
}
