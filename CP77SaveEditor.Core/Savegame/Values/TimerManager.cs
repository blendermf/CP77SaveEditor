using CP77SaveEditor.Core.Savegame.Attributes;
using CP77SaveEditor.Core.Savegame.Values.Engine;

namespace CP77SaveEditor.Core.Savegame.Values
{
    [CName("timerManager")]
    public class TimerManager
    {
        [CName("time")]
        public GameTime Time { get; set; }

        public object Unknown1 { get; set; }

        [CName("isPaused")]
        public bool IsPaused { get; set; }

        [CName("timeScalePriorityIndexGenerator")]
        public uint TimeScalePriorityIndexGenerator { get; set; }
         
    }
}