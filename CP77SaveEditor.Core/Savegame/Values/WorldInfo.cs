using System;
using CP77SaveEditor.Core.Savegame.Attributes;

namespace CP77SaveEditor.Core.Savegame.Values
{
    [CName("worldInfo")]
    public class WorldInfo
    {
        [CName("world")]
        public String World { get; set; }
    }
}