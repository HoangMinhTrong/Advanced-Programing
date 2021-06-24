using System;
using System.Collections.Generic;

namespace SMS
{
    public class Subject
    {
        public string subject 
        {
            get;
            set;
        }
        public void EnterSubject()
        {
            Console.Write("Enter Subject: ");
            String subject = Console.ReadLine();
        }
    }
}