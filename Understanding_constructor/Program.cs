using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Understanding_constructor
{
    class Calc
    {
        public int result = 0; 
        static void Main(string[] args)
        {
            Calc square = new Calc(3);
            Calc mul = new Calc(4, 5);
            Console.WriteLine(mul.result + square.result);
        }
        // Modify the constructor below //
        public Calc(int a)
        {
            this.result = a * a;
        }
        public Calc(int a, int b)
        {
            this.result = a * b;
        }
    }
}
