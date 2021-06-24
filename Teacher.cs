using System;
using System.Collections.Generic;
namespace SMS
{
    class Teacher : ATeacher
    {
        string ClassName;
        public string Class
        {
            get
            {
                return ClassName;
            }

            set
            {
                ClassName = value;
            }
        }

        DateTime dateofBirth;
        public DateTime DateofBirth
        {
            get
            {
                return dateofBirth;
            }

            set
            {
                dateofBirth = value;
            }
        }

        string fullName;
        public string FullName
        {
            get
            {
                return fullName;
            }

            set
            {
                fullName = value;
            }
        }

        int id;
        public int ID
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        int mobile;
        public int Mobile
        {
            get
            {
                return mobile;
            }

            set
            {
                mobile = value;
            }
        }

        string native;
        public string Native
        {
            get
            {
                return native;
            }

            set
            {
                native = value;
            }
        }
        public void Display()
        {
            Console.WriteLine("Full Name: " + FullName);
            Console.WriteLine("Date of Birth: " + DateofBirth.ToString("dd/MM/yyyy"));
            Console.WriteLine("Native: " + Native);
            Console.WriteLine("Mobile : " + Mobile);
        }
        static Dictionary<int, Teacher> listDictionary = new Dictionary<int, Teacher>();
        static Teacher()
        {
            while (true)
            {
                Console.WriteLine("+----------------------------+");
                Console.WriteLine("| TEACHER MANAGEMENT SYSTEM |");
                Console.WriteLine("+----------------------------+");
                Console.WriteLine("|1. Insert new Teacher       |");
                Console.WriteLine("|2. View list of Teacher    |");
                Console.WriteLine("|3. Search Teacher          |");
                Console.WriteLine("|4. Delete Teacher          |");
                Console.WriteLine("|5. Total Salary of Teacher  |");
                Console.WriteLine("|6. Exit                     |");
                Console.WriteLine("+----------------------------+");
                Console.Write("Your choice: ");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        InsertTeacher();
                        break;
                    case 2:
                        ViewList();
                        break;
                    case 3:
                        Search();
                        break;
                    case 4:
                        Delete();
                        break;
                    case 5:
                        TeacherSalary salary = new TeacherSalary();
                        salary.Enterworkhours();
                        salary.EnterSalary();
                        break;
                    case 6:
                        return;
                }
            }
        }

        private static void Search()
        {
            bool found = false;
            Console.Write("Input Class: ");
            String search = Console.ReadLine();
            Console.WriteLine("All Teacher " + search);
            foreach (Teacher teacher in listDictionary.Values)
            {
                if (teacher.Class.Equals(search))
                {
                    Console.WriteLine("----------------------------");
                    teacher.Display();
                    found = true;
                }
            }
            if (!found)
            {
                Console.WriteLine("No Teacher were found!");
            }
        }

        private static void ViewList()
        {
            foreach (Teacher i in listDictionary.Values)
            {
                Console.WriteLine("----------------------------");
                i.Display();
            }
        }
        private static void Delete()
        {
            bool founds = false;
            Console.Write("Input Name: ");
            String delete = Console.ReadLine();
            Console.WriteLine("Teacher of name " + delete);
            foreach (Teacher student in listDictionary.Values)
            {
                if (student.FullName.Equals(delete))
                {
                    System.Console.WriteLine("Teacher has been Delete");
                    founds = true;
                }
            }
            if (!founds)
            {
                Console.WriteLine("No teacher were found!");
            }
        }

        private static void InsertTeacher()
        {
            Teacher teacher = new Teacher();

            //Increament ID
            teacher.ID = listDictionary.Count + 1;

            //Input name
            Console.Write("Enter Fullname: ");
            teacher.FullName = Console.ReadLine();

            //Input date
            while (true)
            {
                Console.Write("Enter Date of Birth: ");
                try
                {
                    teacher.DateofBirth = DateTime.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("The date is not in the correct format!");
                    Console.WriteLine(ex.Message);
                }
            }

            //Input Native
            Console.Write("Enter Native: ");
            teacher.Native = Console.ReadLine();

            //Input Mobile
            while (true)
            {
                Console.Write("Enter Mobile: ");
                try
                {
                    teacher.Mobile = int.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("The number is not in the correct format!");
                    Console.WriteLine(ex.Message);
                }
            }

            listDictionary.Add(teacher.ID, teacher);
            Console.WriteLine("Successfully inserted a teacher!");
        }
        private static int Workhours()
        {
            Console.Write("Input Salary: ");
            int workhours = int.Parse(Console.ReadLine());
            Console.WriteLine("Total " + workhours);
            return workhours;
        }
    }
}