using System.IO;
using CP77SaveEditor.Core.Exceptions;
using CP77SaveEditor.Core.Savegame.Variables;

namespace CP77SaveEditor.Core.Savegame.VariableParsers
{
    public class AvalVariableParser : VariableParserBase<AvalVariable>
    {
        public override string MagicNumber => "AVAL";

        public override AvalVariable ParseImpl(BinaryReader reader, ref int size)
        {
            short nameIndex = reader.ReadInt16();
            string name = Names[nameIndex - 1];
            short typeIndex = reader.ReadInt16();
            string type = Names[typeIndex - 1];
            size -= 2 * sizeof(short);

            int unknown = reader.ReadInt32();
            size -= sizeof(int);

            var value = ReadValue(reader, type, ref size);

            return new AvalVariable
            {
                Name = name,
                Type = type,
                Value = value
            };
        }
    }
}
