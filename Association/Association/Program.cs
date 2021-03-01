using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Association
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Student s1 = new Student("19-39825-1", "Rakib", 3.58F);
            Student s2 = new Student("19-39820-1", "Alif", 3.6F);
            Student s3 = new Student("19-39855-1", "Audry", 3.7F);

            Department d1 = new Department("CS", "Computer Science & ENgineering");
            Department d2 = new Department("EEE", "Electrical & Electronic Engineering");

            s1.Dept = d1;
            s2.Dept = d2;
            s3.Dept = d2;

            s1.ShowInfo();
            s1.ShowDepartment();

            s2.ShowInfo();
            s2.ShowDepartment();

            s3.ShowInfo();
            s3.ShowDepartment();

            
            d1.Name = "Computer Science & Engineering";

            s1.ShowInfo();
            s1.ShowDepartment();


            

            d1.AddStudent(s1);
            d1.AddStudent(s2);

            d1.PrintStudent();
        }
    }
}