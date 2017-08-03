using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo3
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }

    //Patron Singleton 

    public class Configuration
    {
        private static Configuration instance;
        private Configuration()
        {

        }

        public static Configuration Instance
        {
            get
            {
                if (null == instance) {
                    instance = new Configuration();
                }
                return instance;
            }
        }
    }
}
