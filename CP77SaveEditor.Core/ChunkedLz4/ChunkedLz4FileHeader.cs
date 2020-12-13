using System;
using System.IO;
using System.Text;

namespace CP77SaveEditor.Core.ChunkedLz4
{
    public class ChunkedLz4FileHeader
    {
        public int ChunkCount { get; set; }
        public int HeaderSize { get; set; }

        public static ChunkedLz4FileHeader Read(Stream input)
        {
            using (var reader = new BinaryReader(input, Encoding.ASCII, true))
            {
                string saveFileHeader = reader.ReadString(4);
                if (saveFileHeader != "VASC")
                {
                    throw new InvalidOperationException();
                }

                // Currently Unknown data
                reader.ReadString(21);

                string chunkedLz4FileHeader = reader.ReadString(4);
                if (chunkedLz4FileHeader != "FZLC")
                {
                    throw new InvalidOperationException();
                }

                return new ChunkedLz4FileHeader
                {
                    ChunkCount = reader.ReadInt32(),
                    HeaderSize = reader.ReadInt32()
                };
            }
        }
    }
}