
using System;
using System.Linq;
using Problem_1.Class_Students;

class Exellent
{
    static void Main()
    {
        var stud =
           from stu in Program.Students
           where stu.Marks.Exists(x => (x / 6 == 1) && (x % 6 == 0))
           select stu;


        foreach (var elements in stud)
        {


            Console.WriteLine("Name: {0} {1}, Marks: {2}",
                elements.FirstName, elements.LastName, string.Join(", ", elements.Marks));
        }
    }
}
