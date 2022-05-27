using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenesisPinA3MAYOR
{
    class program
    {
        static void Main(string[] args)
        {
            int numr;
            int numr2;
            Console.WriteLine("ingrese primer numero");
            numr = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese segundo numero");
            numr2 = int.Parse(Console.ReadLine());
            if (numr > numr2)
            {
                Console.WriteLine("el numero mayor es " + numr);
            }
            else if (numr = numr2)
            {
                Console.WriteLine("los numeros son iguales");
            }
            else
            {
                Console.WriteLine("el numero mayor es " + numr2);
            }
            Console.ReadKey();
        }
    }
}