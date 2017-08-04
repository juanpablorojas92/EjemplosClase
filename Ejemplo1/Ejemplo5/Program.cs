using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Ejemplo5
{
    class Program
    {
        static void Main(string[] args)
        {
            var sql = @"Selec * 
                       from tabla 
                        where id = @id";//Con el arroba del principio podemos hacer saltos de linea en el código para que sea mas legible.
            var connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=pizzeria;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

            try
            {
                connection.Open();
    
            }
            catch(SqlException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(Exception e)//Siempre en el ultimo lugar. Las excepciones más especificas primeras. 
            {
                Console.WriteLine(e.GetType().Name);
                Console.ReadLine();
            }
            finally
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
                connection.Dispose();
                Console.WriteLine(connection.State);
                Console.Read();
            }
        }
    }
}
