using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle
{
    class Rectangle
    {
        double width;
        double height;
        public double findArea()
        {
            return this.width * this.height;
        }
        public double findPerimeter()
        {
            return 2 * (this.width + this.height);
        }
        public Rectangle()
        {
            width = 10;
            height = 9.5;
        }
        public override string ToString()
        {
            return this.width+ " " + this.height;
        }
    }
}
