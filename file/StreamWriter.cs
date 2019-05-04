using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class StreamWriterExample
{
    public static void Main(string[] args)
    {
        FileStream f = new FileStream("e:\\output.txt", FileMode.Create);
        StreamWriter s = new StreamWriter(f);

        s.WriteLine("hello c#");
        s.Close();
        f.Close();
        Console.WriteLine("File created successfully...");
    }
}