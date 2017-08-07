using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Ejemplo6
{
    class Program
    {
        static void Main(string[] args)
        {
            /* using (var connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=pizzeria;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")) ;
             {
                 connection.Open();//Esto sirve para verificar que siempre hay que poner "try" y "catch"
             };*/

            using (var person = new Person())
            {

            }
        }
    }


    class Person : IDisposable
    {
        public int Id { get; set; }
        public void Dispose()
        {
            throw new NotImplementedException();
        }

        
    }

    class Sql
    {
        public Sql where()
        {
            return this;
        }
        public Sql Select()
        {
            return this;
        }
    }
}
