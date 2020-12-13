using CP77SaveEditor.Core.Savegame.Attributes;

namespace CP77SaveEditor.Core.Savegame.Values
{
    [CName("SGameplayFact")]
    public class SGameplayFact
    {
        [CName("factName")]
        public string FactName { get; set; }

        [CName("value")]
        public int Value { get; set; }
    }
}