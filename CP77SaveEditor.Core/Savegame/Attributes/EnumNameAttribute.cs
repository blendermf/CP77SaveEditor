using System;

namespace CP77SaveEditor.Core.Savegame.Attributes
{
    [AttributeUsage(AttributeTargets.Enum | AttributeTargets.Property)]
    public class EnumNameAttribute : Attribute
    {
        private string Name { get; set; }

        public EnumNameAttribute(string name)
        {
            Name = name;
        }
    }
}