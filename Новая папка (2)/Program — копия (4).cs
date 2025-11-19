using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace прак17
{
  public  struct Color
    {
        public int R, G, B;
      
        public Color(int r, int g, int b) { 
            R= r;
            G = g;
           B = b;
     
        }
        public override string ToString()
        {
            return $"{R},{G},{B}";
        }
            }

    internal class Program
    {
        static void Main(string[] args)
        {
            var c1 = new Color(255, 128, 0);
            var c2 = c1;
            c2.R = 100;
            Console.WriteLine(c1); 
            Console.WriteLine(c2);

        }
    }
}
