﻿using System;
using CP77SaveEditor.Core.Savegame.Attributes;

namespace CP77SaveEditor.Core.Savegame.Values.Journal
{
    public class JMonsterKnownGuid
    {
        [CName("guid")]
        public Guid Guid { get; set; }
    }
}