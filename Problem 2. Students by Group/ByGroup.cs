using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Problem_1.Class_Student;
using Problem_1.Class_Students;

class ByGroup
{
    static void Main()
    {
       
        
        var stud =
            from stu in Program.Students
            where stu.GroupNumber == 2
            orderby stu.FirstName
            select stu;


        foreach (var elements in stud)
        {


            Console.WriteLine("Name: {0} {1}, Age: {2}, Faculty Number: {3} " +
                              "\n\tPhone: {4}, Email: {5} \n\tGrades: {{{6}}}, Group: {7}",
                elements.FirstName, elements.LastName, elements.Age, elements.FacultyNumber,
                elements.Phone, elements.Email, string.Join(", ", elements.Marks), elements.GroupNumber);
        }

    }
}

