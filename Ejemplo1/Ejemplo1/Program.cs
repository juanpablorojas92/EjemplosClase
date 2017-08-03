using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo1
{
    class Program
    {
        static void Main(string[] args)
        {
            var ticket = new Tiket() { Total = 1000 };
            var repositoryTicket = new RepositoryTicket();
            repositoryTicket.Add(ticket);

        }
    }

    public abstract class EntityBase
    {
        public Guid Id { get; set; }

        //Esto se utilizaría se la clase no fuera abstracta.
       /* protected EntityBase Create()
        {
            return new EntityBase() { Id = new Guid() };
        }*/

        public static Guid CreateIdentifier()
        {
            return Guid.NewGuid();
        }
    }

    public class Tiket : EntityBase
    {
        public Decimal Total { get; set; }
    }

    public class Person : EntityBase
    {
        public string Name { get; set; }
    }

    public class RepositoryTicket : RepositoryGeneric<Tiket>
    {
        
        //Al heredar del repositorio general no hace falta escribir el codigo de nuevo.
        /*
        public void Add(Tiket ticket)
        {
            ticket.Id = EntityBase.CreateIdentifier();
            //todod
        }
        */
    }

    public class RepositoryPerson : RepositoryGeneric<Person>
    {
        
    }

    public class RepositoryGeneric<T> where T:EntityBase
    {
        public virtual void Add(T entity)
        {
            entity.Id = EntityBase.CreateIdentifier();
        }
    }
}
