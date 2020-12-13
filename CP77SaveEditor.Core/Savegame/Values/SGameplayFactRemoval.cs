using CP77SaveEditor.Core.Savegame.Attributes;

namespace CP77SaveEditor.Core.Savegame.Values
{
    public class SGameplayFactRemoval
    {
        [CName("factName")]
        public string FactName { get; set; }

        [CName("value")]
        public int Value { get; set; }

        [CName("timerID")]
        public int TimerId { get; set; }
    }
}