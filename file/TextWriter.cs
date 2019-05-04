using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextWriterExample
{
    class Program
    {
        static void Main(string[] args)
        {
            using (TextWriter writer = File.CreateText("e:\\f.txt"))
            {
                writer.WriteLine("Hello C#");
                writer.WriteLine("C# File Handling by JavaTpoint");
            }
            Console.WriteLine("Data written successfully...");
        }
    }
}
