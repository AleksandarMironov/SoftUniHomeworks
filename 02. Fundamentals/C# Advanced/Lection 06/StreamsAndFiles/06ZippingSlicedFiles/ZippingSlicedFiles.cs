﻿using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06ZippingSlicedFiles
{
    class ZippingSlicedFiles
    {
        private static void SliceGZip(string sourceFile, string destinationDir, int numParts)
        {
            FileInfo fileInfo = new FileInfo(sourceFile);

            //calculate size of each part
            int size = (int)fileInfo.Length; //size in bytes
            int partSize = size / numParts;
            int lastPartSize = size - (numParts - 1) * partSize;

            string name = fileInfo.Name;
            string[] nameExtArr = name.Split('.');

            //for each part, read input and write output
            FileStream source = new FileStream(sourceFile, FileMode.Open);
            source.Seek(0, SeekOrigin.Current);
            for (int i = 0; i < numParts; i++)
            {
                int currentSize = (i == (numParts - 1)) ? lastPartSize : partSize;

                byte[] buffer = new byte[currentSize];
                source.Read(buffer, 0, currentSize);

                string currentFilePath = destinationDir + "Part-" + i + "." + nameExtArr[1] + ".gz";
                using (FileStream dest = new FileStream(currentFilePath, FileMode.Create))
                using (GZipStream gzipDest = new GZipStream(dest, CompressionMode.Compress, false))
                    gzipDest.Write(buffer, 0, currentSize);

            }
            source.Close();
        }

        private static void AssembleGZip(List<string> files, string destinationDirectory)
        {
            //get the extenstion of the resulting file.
            string[] dotItems = files[0].Split('.');
            //pre-last extension - the one before '.gz'
            string ext = dotItems[dotItems.Length - 2];

            string destinationFile = destinationDirectory + "assembled." + ext;
            using (FileStream dest = new FileStream(destinationFile, FileMode.Append, FileAccess.Write))
            {

                foreach (string inFile in files)
                {
                    using (FileStream source = new FileStream(inFile, FileMode.Open))
                    {
                        using (GZipStream sourceGZip = new GZipStream(source, CompressionMode.Decompress, false))
                        {
                            byte[] buffer = new byte[4096];
                            int len;
                            while ((len = sourceGZip.Read(buffer, 0, buffer.Length)) > 0)
                                dest.Write(buffer, 0, len);
                        }

                    }
                }
            }
        }

        static void Main()
        {
            string sourceFile = "../../../03WordCount/bin/Debug/03WordCount.exe";
            string destinationDir = "../../parts/";
            int numParts = 5;
            SliceGZip(sourceFile, destinationDir, numParts);
            List<string> files = new List<string> {  
                                "../../parts/Part-0.exe.gz",
                                "../../parts/Part-1.exe.gz",
                                "../../parts/Part-2.exe.gz",
                                "../../parts/Part-3.exe.gz",
                                "../../parts/Part-4.exe.gz",
                             };

            AssembleGZip(files, destinationDir);
            Console.WriteLine("Done!");
        }
    }
}
