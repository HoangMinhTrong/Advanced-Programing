using System;
using System.Collections.Generic;
namespace SMS
{
    class Student : AStudent
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
        string phoneNo;
        public string PhoneNo
        {
            get
            {
                return phoneNo;
            }

            set
            {
                phoneNo = value;
            }
        }

        public new void Display()
        {
            Console.WriteLine("Full Name: " + FullName);
            Console.WriteLine("Date of Birth: " + DateofBirth.ToString("dd/MM/yyyy"));
            Console.WriteLine("Native: " + Native);
            Console.WriteLine("Class: " + Class);
            Console.WriteLine("Phone No : " + PhoneNo);
            Console.WriteLine("Mobile : " + Mobile);
        }
        static Dictionary<int, Student> listDictionary = new Dictionary<int, Student>();
        static Student()
        {
            while (true)
            {
                Console.WriteLine("+----------------------------------------+");
                Console.WriteLine("|       STUDENTS MANAGEMENT SYSTEM       |");
                Console.WriteLine("+----------------------------------------+");
                Console.WriteLine("|1. Insert new Student                   |");
                Console.WriteLine("|2. View list of Students                |");
                Console.WriteLine("|3. Search Students                      |");
                Console.WriteLine("|4. Delete Students                      |");
                Console.WriteLine("|5. Enter Grade and Subject Students     |");
                Console.WriteLine("|6. Update Grade Students                |");
                Console.WriteLine("|7. Delete Grade Students                |");
                Console.WriteLine("|8. Exit                                 |");
                Console.WriteLine("+----------------------------------------+");
                Console.Write("Your choice: ");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        InsertStudent();
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
                        GradeStudent grade = new GradeStudent();
                        grade.EnterSubject();
                        grade.EnterGrade();
                        break;
                    case 6:
                        GradeStudent grade1 = new GradeStudent();
                        grade1.UpdateGrade();
                        break;
                    case 7:
                        GradeStudent grade2 = new GradeStudent();
                        grade2.DeleteGrade();
                        break;
                    case 8:
                        return;
                }
            }
        }
        private static void Search()
        {
            bool found = false;
            Console.Write("Input Class: ");
            String search = Console.ReadLine();
            Console.WriteLine("All student of class " + search);
            foreach (Student student in listDictionary.Values)
            {
                if (student.Class.Equals(search))
                {
                    Console.WriteLine("----------------------------");
                    student.Display();
                    found = true;
                }
            }
            if (!found)
            {
                Console.WriteLine("No students were found!");
            }
        }

        private static void ViewList()
        {
            foreach (Student i in listDictionary.Values)
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
            Console.WriteLine("Student of name " + delete);
            foreach (Student student in listDictionary.Values)
            {
                if (student.FullName.Equals(delete))
                {
                    System.Console.WriteLine("Student has been Delete");
                    founds = true;
                }
            }
            if (!founds)
            {
                Console.WriteLine("No students were found!");
            }
        }

        private static void InsertStudent()
        {
            Student student = new Student();

            //Increament ID
            student.ID = listDictionary.Count + 1;

            //Input name
            Console.Write("Enter Fullname: ");
            student.FullName = Console.ReadLine();

            //Input date
            while (true)
            {
                Console.Write("Enter Date of Birth: ");
                try
                {
                    student.DateofBirth = DateTime.Parse(Console.ReadLine());
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
            student.Native = Console.ReadLine();

            //Input Class
            Console.Write("Enter Class: ");
            student.Class = Console.ReadLine();
            //Input Phone No
            Console.Write("Enter Phone No: ");
            student.PhoneNo = Console.ReadLine();

            //Input Mobile
            while (true)
            {
                Console.Write("Enter Mobile: ");
                try
                {
                    student.Mobile = int.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("The number is not in the correct format!");
                    Console.WriteLine(ex.Message);
                }
            }

            listDictionary.Add(student.ID, student);
            Console.WriteLine("Successfully inserted a student!");
        }
    }
}