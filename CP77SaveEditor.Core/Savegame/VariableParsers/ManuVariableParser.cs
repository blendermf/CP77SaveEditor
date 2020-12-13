using System.IO;
using CP77SaveEditor.Core.Exceptions;
using CP77SaveEditor.Core.Savegame.Variables;

namespace CP77SaveEditor.Core.Savegame.VariableParsers
{
    public class ManuVariableParser : VariableParserBase<ManuVariable>
    {
        public override string MagicNumber => "MANU";

        public override ManuVariable ParseImpl(BinaryReader reader, ref int size)
        {
            int stringCount = reader.ReadInt32();
            int unknown1 = reader.ReadInt32();
            size -= 2*sizeof (int);

            var strings = new string[stringCount];
            for (int i = 0; i < stringCount; i++)
            {
                byte stringSize = reader.ReadByte();
                strings[i] = reader.ReadString(stringSize);
                size -= sizeof (byte) + stringSize;
            }

            int unknown2 = reader.ReadInt32();
            string doneMagicNumber = reader.ReadString(4);
            size -= sizeof (int) + 4;
            if (doneMagicNumber != "ENOD")
            {
                throw new ParseVariableException();
            }
            
            return new ManuVariable
            {
                Strings = strings
            };
        }
    }
}
