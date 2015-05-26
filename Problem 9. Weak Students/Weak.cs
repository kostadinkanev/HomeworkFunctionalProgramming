using System;
using System.Collections.Generic;
using System.Linq;
using Problem_1.Class_Students;


class Weak

    {
        static void Main()
        {
            int count = 0;
          var stud =
          from stu in Program.Students
          where stu.Marks.Count(x => x == 2) == 2
          select stu;


           foreach (var elements in stud)
            {
                    Console.WriteLine("Name: {0} {1}, Marks: {2}",
                    elements.FirstName, elements.LastName, string.Join(", ", elements.Marks));
            }
        }
    }

