using System;
using static System.Console;
using System.Threading;
using System.IO;
namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] ages)
        {
            Worker w = new Worker("sadasd","asdasd","sdaasd","sdasfdas","asdasd","asdasd");
            WriteLine(w.PrintID());

            w.Save();
            w.NewSave("dsdasd", "asdasd", "asdas", "sadasd", "dasasd", "xcvzxc");


               
            

        }
    }
}
