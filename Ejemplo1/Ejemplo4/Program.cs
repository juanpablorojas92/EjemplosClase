using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo4
{
    class Program
    {
        static void Main(string[] args)
        {
            int? a = null;
            //int b = null; //Esto no se permite porque no utilizar el nulable para int

            System.Nullable<int> c = null; // Esto seria el código que se debería usar para hacer lo mismo que se hace poniendo "?" después del tipo de variable.
        }
    }

    /*
     * 
     * Ejemplo de una clase que seria una factoria.
     * 
     * 
    class Factory
    {
        IPolymorfica CreateConection(Type t)
        {
            return t.createInstance();
        }
    }
    */
}
