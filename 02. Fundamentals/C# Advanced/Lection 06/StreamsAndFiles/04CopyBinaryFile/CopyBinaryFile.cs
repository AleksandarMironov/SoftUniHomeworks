using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04CopyBinaryFile
{
    class CopyBinaryFile
    {
        static void Main()
        {
            using (FileStream source = new FileStream("../../SoftUni.jpg", FileMode.Open))
            {
                using (FileStream dest = new FileStream("../../SoftUniCopy.jpg", FileMode.Create))
                {
                    byte[] buffer = new byte[4096];
                    int len;
                    while ((len = source.Read(buffer, 0, buffer.Length)) > 0)
                    {
                        dest.Write(buffer, 0, len);
                    }
                }
            }
            Console.WriteLine("Done!");
        }
    }
}
