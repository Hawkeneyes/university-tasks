using System.IO;
using System.IO.Compression;

namespace CompressionDemo
{
    class Program
    {
        static void CompressFile(string inFilename, string outFilename)
        {
            inFilename = @"c:\ttt.txt";
            outFilename = @"c:\ttt.txt.gz";
            FileStream sourceFile = File.OpenRead(inFilename);
            FileStream destFile = File.Create(outFilename);

            GZipStream compStream = new GZipStream(destFile, CompressionMode.Compress);
            int theByte = sourceFile.ReadByte();
            while (theByte != -1)
            {
                compStream.WriteByte((byte)theByte);
                theByte = sourceFile.ReadByte();
            }

            compStream.Close();
        }

        static void UncompressFile(string inFilename, string outFilename)
        {
            string inFilename1 = @"c:\tttt.txt";
            FileStream sourceFile = File.OpenRead(outFilename);
            FileStream destFile = File.Create(inFilename1);
            GZipStream compStream =
                new GZipStream(sourceFile, CompressionMode.Decompress);
            int theByte = compStream.ReadByte();
            while (theByte != -1)
            {
                destFile.WriteByte((byte)theByte);
                theByte = compStream.ReadByte();
            }

            compStream.Close();
        }


        static void Main()
        {
            CompressFile(@"c:\boot.ini", @"с:\boot.ini.gz");
            UncompressFile(@"c:\boot.ini.gz", @"c:\boot.ini.test");
        }
    }
}
