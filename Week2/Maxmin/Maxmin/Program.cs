using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maxmin
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = File.ReadAllText(@"C:\Users\USER\Desktop\pp\c#\piazza\W2\Maxmin\input.txt");
            string[] values = line.Split(' ');
            int min = 1000;
            int max = -1;
            for (int i = 0; i < values.Length; i++)
            {
                if (int.Parse(values[i]) > max) max = int.Parse(values[i]);
                if (int.Parse(values[i]) < min) min = int.Parse(values[i]);
            }
            /*string[] files = new string[2];
            files[0] = Convert.ToString(max);
            files[1] = Convert.ToString(min);
            File.WriteAllLines(@"C:\Users\USER\Desktop\pp\c#",files);
            */
            Console.WriteLine(max);
            Console.WriteLine(min);
        }
    }
}
