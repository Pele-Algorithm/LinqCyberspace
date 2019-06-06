using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaggingWithSkipAndTake
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<Student> students = Student.GetAllStudetns();
            do
            {
                Console.WriteLine("enter page number 1,2,3,4");
                int pagenumber = 0;
                if (int.TryParse(Console.ReadLine(), out pagenumber))
                {
                    if (pagenumber >= 1 && pagenumber <= 4)
                    {
                        int pagesize = 3;
                        var result = students.Skip((pagenumber - 1) * pagesize).Take(pagesize);
                        Console.WriteLine();
                        Console.WriteLine("displaying page" + pagenumber);

                        foreach (var s in result)
                        {
                            Console.WriteLine(s.StudentID + "\t" + s.Name + "\t" + s.TotalMarks);
                        }
                    }
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("please enter an integer n number betweeen 1 to 4");
                }

            } while (1==1);

        }
    }
}
