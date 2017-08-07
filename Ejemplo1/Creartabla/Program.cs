using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creartabla
{
    class Program
    {
        static void Main(string[] args)
        {


            var id = new ID();


            
             SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand insertcommand = new SqlCommand(
                @"INSERT INTO Pizza (GuID, Name, Price, Size) 
                VALUES (@Id, @Name, @Price, @Size");
            insertcommand.Parameters.Add("@Id",SqlDbType.VarChar, 32, "id");
            insertcommand.Parameters.Add("@Name", SqlDbType.NVarChar , 24, "Barbacoa");
            insertcommand.Parameters.Add("@Price", SqlDbType.Decimal, 8, "21.30");
            insertcommand.Parameters.Add("@Size", SqlDbType.Decimal, 8, "25.36");


            SqlCommand selectcommand = new SqlCommand(@"SELECT Guid, Name, Price, Size FROM Pizza ");

            //SqlDataReader reader = selectcommand.ExecuteReader();

            //Con el arroba del principio podemos hacer saltos de linea en el código para que sea mas legible.
            var connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=pizzeria;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

            try
            {
                connection.Open();
                /*
                SqlDataAdapter adapter = new SqlDataAdapter();

                SqlCommand insertcommand = new SqlCommand(
               @"INSERT INTO Pizza (GuID, Name, Price, Size) 
                VALUES (@Id, @Name, @Price, @Size");
                insertcommand.Parameters.Add("@Id", SqlDbType.VarChar, 32, "id");
                insertcommand.Parameters.Add("@Name", SqlDbType.NVarChar, 24, "Barbacoa");
                insertcommand.Parameters.Add("@Price", SqlDbType.Decimal, 8, "21.30");
                insertcommand.Parameters.Add("@Size", SqlDbType.Decimal, 8, "25.36");
                */

                adapter.InsertCommand = insertcommand;

                adapter.SelectCommand = selectcommand;

                

                foreach (string registro in adapter)
                {

                    Console.WriteLine(adapter);

                    
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)//Siempre en el ultimo lugar. Las excepciones más especificas primeras. 
            {
                Console.WriteLine(e.GetType().Name);
                Console.ReadLine();
            }
            finally
            {


                //Console.WriteLine();
               Console.Read();


                connection.Dispose();
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }
    }

    class ID
    {

        public static Guid CreateIdentifier()
        {
            return Guid.NewGuid();
        }
    }

       
}


