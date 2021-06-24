using System;

namespace SMS
{
  public abstract class AStudent
  {
    int ID
    {
      get;
      set;
    }
    double Score
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

    string Class
    {
      get;
      set;
    }

    string PhoneNo
    {
      get;
      set;
    }

    int Mobile
    {
      get;
      set;
    }
    int score
    {
      get;
      set;
    }
    string subject
    {
      get;
      set;
    }

    public void Display()
    {}
  }
}
