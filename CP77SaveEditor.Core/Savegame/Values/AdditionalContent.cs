using CP77SaveEditor.Core.Savegame.Attributes;

namespace CP77SaveEditor.Core.Savegame.Values
{
    public class AdditionalContent
    {
        [CName("count")]
        public uint Count { get; set; }

        public string[] Items { get; set; }
    }
}