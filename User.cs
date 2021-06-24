using System;
using System.Collections.Generic;
using System.Linq;


namespace SMS
{

    public class Login
    {
        public string email;
        public string password;
        public void Studentlogin()
        {
            Console.WriteLine("+----------------------------+");
            Console.WriteLine("+          LOGIN             +");
            Console.Write("Email: ");
            String email = Console.ReadLine();
            Console.Write("Password: ");
            String password = Console.ReadLine();
            Console.WriteLine("+----------------------------+");
            Console.WriteLine("Loading...");

            if (email == "tronggaw2@gmail.com")
            {
                Console.WriteLine("Login Success");
                Student studentnew = new Student();
            }
            else
            {
                Console.WriteLine("Wrong email please enter again!");
            }
        }
        public void TeacherLogin()
        {
            Console.WriteLine("+----------------------------+");
            Console.WriteLine("+          LOGIN             +");
            Console.Write("Email: ");
            String email = Console.ReadLine();
            Console.Write("Password: ");
            String password = Console.ReadLine();
            Console.WriteLine("+----------------------------+");
            Console.WriteLine("Loading...");

            if (email == "phihv3@fe.edu.vn")
            {
                Console.WriteLine("Login Success");
                Teacher teachernew = new Teacher();
            }
            else
            {
                Console.WriteLine("Wrong email please enter again!");
            }
        }
    }
}