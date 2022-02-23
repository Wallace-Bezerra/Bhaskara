using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bhaskara
{
    public class Bhaskara
    {
        public int A { get; set; }
        public int B { get; set; }
        public int C { get; set; }

        public double X1 { get; set; }
        public double X2 { get; set; }

        public Bhaskara(int a, int b, int c)
        {
            A = a;
            B = b;
            C = c;
        }

        public int Delta(int a, int b, int c)
        {
            int delta = (int)Math.Pow(b,2) - (4 * a * c);
            return delta;
        }
    }
}
