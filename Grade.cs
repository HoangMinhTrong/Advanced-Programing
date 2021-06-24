using System;
using System.Collections.Generic;

namespace SMS
{
    public class GradeStudent : Subject
    {
        public string name {get; set;}
        public string _class{get; set;}
        public string phone{get; set;}
        public int grade{get; set;}
        string _name; 
        string __class; 
        string _phone; 
        int _grade;
        public void EnterGrade()
        {
            Console.Write("Input Name of Student: ");
            String name = Console.ReadLine();
            Console.Write("Input Grade of Student: ");
            int grade = int.Parse(Console.ReadLine());
            Console.Write("Input Class of Student: ");
            String _class = Console.ReadLine();
            Console.Write("Input Phone of Student: ");
            String phone = Console.ReadLine();

            if (grade >= 5)
            {
                System.Console.WriteLine($"Student {name} have Pass {subject}");
            }
            else
            {
                System.Console.WriteLine($"Student {name} have Not Pass {subject}");
            }
        }
        public static List<GradeStudent> grades = new List<GradeStudent>();
        public void UpdateGrade()
        {
           System.Console.WriteLine("Input grade to update");
           int grade = int.Parse(Console.ReadLine());
        }
        public void DeleteGrade()
        {
            bool founds = false;
            Console.Write("Input Name: ");
            String delete = Console.ReadLine();
            Console.WriteLine("Student of name " + delete);
            foreach (GradeStudent grade in grades)
            {
                if (grade.name.Equals(delete))
                {
                    System.Console.WriteLine($"Grade of Student {name} has been Delete");
                    founds = true;
                }
            }
            if (!founds)
            {
                Console.WriteLine("Grade of student has been deleted");
            }
        }
    }
}