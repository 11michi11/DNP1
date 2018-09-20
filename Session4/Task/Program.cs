using System;
using System.Threading.Tasks;

namespace Task
{
    class Program
    {
        static void Main(string[] args)
        {
            var r1 = new Reader("file1.txt");
            var r2 = new Reader("file2.txt");
            
            Parallel.Invoke(() => r1.Read(), () => r2.Read());
            
            Console.WriteLine(r1.Data.Equals(r2.Data));
            
        }
    }
}