using System;
using System.Linq;
using Problem_1.Class_Students;

class Enrolled
{
    static void Main()
    {

       
        var stud =
        from stu in Program.Students
        where stu.FacultyNumber.ToString().EndsWith("14")
        select stu;


        foreach (var elements in stud)
        {
            Console.WriteLine("Name: {0} {1}, Marks: {2}",
            elements.FirstName, elements.LastName, string.Join(", ", elements.Marks));
        }
    }
}
