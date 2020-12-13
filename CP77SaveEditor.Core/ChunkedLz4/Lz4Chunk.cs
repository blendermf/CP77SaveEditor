using System;
using System.Diagnostics;
using System.IO;
using K4os.Compression.LZ4;

namespace CP77SaveEditor.Core.ChunkedLz4
{
    public class Lz4Chunk
    {
        public int CompressedChunkSize { get; set; }

        public int DecompressedChunkSize { get; set; }

        public int EndOfChunkOffset { get; set; }

        public Span<byte> Read(Stream inputStream)
        {
            Span<byte> inputData = stackalloc byte[CompressedChunkSize - 8];
            Span<byte> outputData = new byte[DecompressedChunkSize];
            inputStream.Seek(8, SeekOrigin.Current);
            inputStream.Read(inputData);
            int bytesDecoded = LZ4Codec.Decode(inputData, outputData);

            Debug.Assert(bytesDecoded == DecompressedChunkSize);
            
            Debug.Assert(inputStream.Position == EndOfChunkOffset || EndOfChunkOffset == 0);

            return outputData;
        }
    }
}