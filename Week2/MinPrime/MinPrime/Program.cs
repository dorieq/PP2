using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinPrime
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = File.ReadAllText(@"C:\Users\USER\Desktop\pp\c#\piazza\W2\MinPrime\Maxmin.txt");
            string[] values = line.Split(' ');
            int min = 10000;
            for (int i = 0; i < values.Length; i++)
            {
                if (int.Parse(values[i]) < min && Prime(int.Parse(values[i]))) min = int.Parse(values[i]);
            }
            string[] files = new string[1];
            files[0] = Convert.ToString(min);
            File.WriteAllLines(@"C:\Users\USER\Desktop\pp\c#\piazza\W2\MinPrime\output.txt", files);
            
            //Console.WriteLine(min);
        }
        static bool Prime(int a) {
            if (a == 1) return false;
            for (int i =2; i <= Math.Sqrt(a); i++)
            {
                if (a % i == 0) return false;
            }
            return true;
        }
    }
}