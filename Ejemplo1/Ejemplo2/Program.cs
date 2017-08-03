using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            var a = 10;
            var result = a.BetWeen(9, 20);
            */

            foreach (var i in Iterator())
            {
                Console.WriteLine(i);
                
            }
            var numbers = new List<int>
            {
                1,2,3
            };
            var result = numbers.Where(Predicate);
            /*
            numbers.Where(n => n > 1);// Esto serviria para que no tengamos que crear el "Predicate" de abajo.
            */
            foreach(var value in result)
            {
                //Con esto conseguimos que entre en el "Predicate".
            }

            Console.WriteLine(result.GetType().Name);
            Console.ReadLine();
        }

        static bool Predicate( int value)
        {
            Console.WriteLine("He entrado");
            return value > 1;
            
        }

        static IEnumerable<int> Iterator()
        {
            for(var i =0; i < 1; i++)
            {
                yield return i;
            }
            //"Yield" sirve para que devuelva el control a la linea del "foreach" sin necesidad de terminar el bucle. Es decir es como si anidaramos bucles.
        }
    }

    public static class ExtensionInt
    {
        public static bool BetWeen(this int value, int from, int to) 
        {
            return value >= from && value <= to;
        }
    }

}

