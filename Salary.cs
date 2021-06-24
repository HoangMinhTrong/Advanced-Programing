using System;
using System.Collections.Generic;
namespace SMS
{
    public class TeacherSalary
    {
        public string name;
        public int workhours;
        public double salary;
        public void Enterworkhours()
        {
            Console.Write("Input Name of teacher: ");
            string name = Console.ReadLine();
            Console.Write("Input Workhours of teacher: ");
            int workhours = int.Parse(Console.ReadLine());
            System.Console.WriteLine($"{name} have {workhours} Work hours");
        }
        public void EnterSalary()
        {
            Console.Write("Input Salary of teacher: ");
            double salary = double.Parse(Console.ReadLine());
            if(workhours == 0)
            {
                System.Console.WriteLine($"Total of teacher {name} is 2400");
            }
            else
            {
                
                System.Console.WriteLine($"Teacher {name} haven't any Work Hours: ");
            }
        }
    }
}