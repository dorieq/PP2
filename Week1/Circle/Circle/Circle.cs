using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle
{
    class Circle
    {
        double radius;
        public Circle()
        {
            radius = 2.5;
        }
        public double findArea() {
            return Math.PI * radius * radius;
        }
        public double findDiameter() {
            return 2 * radius;
        }
        public double findCircumreference()
        {
            return 2 * radius * Math.PI;
        }
        public override string ToString()
        {
            return Convert.ToString(this.radius);
        }
    }
}
