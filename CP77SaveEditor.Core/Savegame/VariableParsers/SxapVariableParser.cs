using System.IO;
using CP77SaveEditor.Core.Exceptions;
using CP77SaveEditor.Core.Savegame.Variables;

namespace CP77SaveEditor.Core.Savegame.VariableParsers
{
    public class SxapVariableParser : VariableParserBase<SxapVariable>
    {
        public override string MagicNumber => "SXAP";

        public override SxapVariable ParseImpl(BinaryReader reader, ref int size)
        {
            int typeCode1 = reader.ReadInt32();
            int typeCode2 = reader.ReadInt32();
            int typeCode3 = reader.ReadInt32();
            size -= 3 * sizeof(int);

            return new SxapVariable
            {
                TypeCode1 = typeCode1,
                TypeCode2 = typeCode2,
                TypeCode3 = typeCode3
            };
        }
    }
}
