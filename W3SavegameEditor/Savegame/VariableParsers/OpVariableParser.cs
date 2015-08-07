﻿using System.IO;
using W3SavegameEditor.Savegame.Variables;

namespace W3SavegameEditor.Savegame.VariableParsers
{
    public class OpVariableParser : VariableParserBase<OpVariable>
    {
        public override string MagicNumber
        {
            get { return "OP"; }
        }

        public override OpVariable ParseImpl(BinaryReader reader, int size)
        {
            short nameIndex = reader.ReadInt16();
            string name = Names[nameIndex - 1];

            short typeIndex = reader.ReadInt16();
            string type = Names[typeIndex - 1];

            size -= 2 * sizeof(short);

            ReadData(reader, type, ref size);

            return new OpVariable
            {
                Name = name,
                Type = type
            };
        }
    }
}
