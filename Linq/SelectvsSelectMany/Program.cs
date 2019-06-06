using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectvsSelectMany
{
    class Program
    {
        static void Main(string[] args)
        {
            //using select
            IEnumerable<List<string>> result = Student.GetAllStudetns().Select(s => s.Subjects);
            foreach (List<string> stringList in result)
            {
                foreach (string str in stringList)
                {
                    Console.WriteLine(str);
                }
            }

            Console.WriteLine("==============================");
            //using selectMany
            IEnumerable<string> result1 = Student.GetAllStudetns().SelectMany(s => s.Subjects);
            foreach (string str in result1)
            {
                Console.WriteLine(str);
            }
        }

        
}
}
