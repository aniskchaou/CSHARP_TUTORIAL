using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class StreamReaderExample
{
    public static void Main(string[] args)
    {
        FileStream f = new FileStream("e:\\a.txt", FileMode.OpenOrCreate);
        StreamReader s = new StreamReader(f);

        string line = "";
        while ((line = s.ReadLine()) != null)
        {
            Console.WriteLine(line);
        }
        s.Close();
        f.Close();
    }
}
