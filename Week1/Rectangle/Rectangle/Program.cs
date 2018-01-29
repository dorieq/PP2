using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle R = new Rectangle();
            Console.WriteLine(R);
            Console.WriteLine(R.findArea());
            Console.WriteLine(R.findPerimeter());
        }
    }
}
