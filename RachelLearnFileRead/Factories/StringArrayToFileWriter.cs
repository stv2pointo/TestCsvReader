using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RachelLearnFileRead.Factories
{
    public static class StringArrayToFileWriter
    {
        public static void write(string path, string[] array)
        {
            try
            {
                Directory.CreateDirectory(Path.GetDirectoryName(path));
                File.WriteAllLines(path, array);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}