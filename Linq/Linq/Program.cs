using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Linq.Count;
namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            //Employee[] developer = new Employee[]
            //{
            //    new Employee{ Id = 1, Name = "salami" },
            //    new Employee{ Id = 2, Name = "White"}
            //};

            //List<Employee> sales = new List<Employee>()
            //{
            //    new Employee{Id = 3, Name = "Amaka" }
            //};

            //foreach(var person in sales)
            //{
            //    Console.WriteLine(person.Name);
            //}

            IEnumerable<Employee> developer = new Employee[]
            {
                new Employee{ Id = 1, Name = "salami" },
                new Employee{ Id = 2, Name = "White"}
            };

            IEnumerable<Employee> sales = new List<Employee>()
            {
                new Employee{Id = 3, Name = "Amaka" }
            };

            var enumerator = developer.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current.Name);
            }
            Console.WriteLine("pelegreeni");
        }
    }
}
