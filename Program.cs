using System;
using System.Collections.Generic;

namespace SMS
{
  class Program
  {
    
    static void Main(string[] args)
    {
       while (true)
      {
        Console.WriteLine("+----------------------------+");
        Console.WriteLine("| STUDENTS MANAGEMENT SYSTEM |");
        Console.WriteLine("+----------------------------+");
        Console.WriteLine("|1. Student Login            |");
        Console.WriteLine("|2. Teacher Login            |");
        Console.WriteLine("|3. Exit                     |");
        Console.Write("Your choice: ");
        int choice = int.Parse(Console.ReadLine());
        switch (choice)
        {
          case 1:
            Login stu = new Login();
            stu.Studentlogin();
            break;
          case 2:
            Login tea = new Login();
            tea.TeacherLogin();
            break;
          case 3:
            return;
    }
  }
}
}
}