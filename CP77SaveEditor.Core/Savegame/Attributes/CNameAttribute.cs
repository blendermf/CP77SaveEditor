using System;

namespace CP77SaveEditor.Core.Savegame.Attributes
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Property)]
    public class CNameAttribute : Attribute
    {
        public string Name { get; set; }

        public CNameAttribute(string name)
        {
            Name = name;
        }
    }
}
