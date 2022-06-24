using System;
using System.IO;
namespace FileDirOpdracht
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo dir = new DirectoryInfo(@"C:\Users\Ed");
            foreach (var sub in dir.GetFiles())
            {
                Console.WriteLine(sub.Name);
            }
        }
    }
}
