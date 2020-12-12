using System;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace W3SavegameEditor.Core.ChunkedLz4
{
    public static class ChunkedLz4File
    {
        public static Stream Decompress(Stream input, string name)
        {
            ChunkedLz4FileHeader header = ChunkedLz4FileHeader.Read(input);
            var table = ChunkedLz4FileTable.Read(input, header.ChunkCount);
            input.Position = header.HeaderSize;

            var data = new byte[header.HeaderSize + table.Chunks.Sum(c => c.DecompressedChunkSize)];
            var memoryStream = new MemoryStream(data) { Position = header.HeaderSize };

            string fName = Path.Combine(Environment.GetEnvironmentVariable("USERPROFILE"), "Saved Games\\CD Projekt Red\\Cyberpunk 2077\\" + name + "-Uncompressed.dat");

            using (BinaryWriter writer = new BinaryWriter(File.Open(fName, FileMode.Create)))
            {
                foreach (var chunk in table.Chunks)
                {
                    Span<byte> chunkData = chunk.Read(input);
                    writer.Write(chunkData.ToArray());
                    memoryStream.Write(chunkData);
                    Debug.Assert(input.Position == chunk.EndOfChunkOffset || chunk.EndOfChunkOffset == 0);
                }
            }

            memoryStream.Position = header.HeaderSize;
            return memoryStream;
        }
    }
}