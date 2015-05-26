using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem_1.Class_Student;

namespace Problem_1.Class_Students
{
   public class Program
    {
        public static List<Students> Students = new List<Students>
            {
                new Students("Todor", "Popov", 50, 801231, "02 6123456", "tt@yahoo.com",
                    new List<int> {4, 2, 6, 5, 3}, 1),
                new Students("Tonka", "Stancheva", 42, 801242, "0896123454", "mm@abv.bg",
                    new List<int> {6, 4, 6, 5, 6}, 2),
                new Students("Stoyan", "Yankov", 15, 801253, "+3592612342", "ss@gmail.com",
                    new List<int> {2, 2, 6, 5, 3}, 1),
                new Students("Svetla", "Kirilova", 18, 801214, "+359 2 6123450", "ii@outlook.com",
                    new List<int> {4, 2, 3, 5, 3}, 2),
                new Students("Kiril", "Evstatiev", 22, 801275, "0896123448", "kk@gmail.com",
                    new List<int> {2, 2, 3, 5, 3}, 3),
                new Students("Kameliya", "Videnova", 50, 801214, "0896123446", "ee@abv.bg",
                    new List<int> {4, 4, 4, 5, 3}, 4)
            };


        static void Main()
        {
           
        }
    }
}
