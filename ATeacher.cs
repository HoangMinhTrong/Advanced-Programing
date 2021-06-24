using System;

namespace SMS
{
  public abstract class ATeacher
  {
    int ID
    {
      get;
      set;
    }

    string FullName
    {
      get;
      set;
    }

    DateTime DateofBirth
    {
      get;
      set;
    }

    string Native
    {
      get;
      set;
    }
    int Mobile
    {
      get;
      set;
    }
    double Salary
    {
        get;
        set;
    }
    int workhours
    {
        get;
        set;
    }
    void Display()
    {

    }
  }
}