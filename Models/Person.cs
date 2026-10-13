using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Text;

namespace ex4_encapsulation.Models
{
  internal class Person
  {
    private string _firstName;
    private string _lastName;
    private int _age;

    public string FirstName 
    { 
      get { return _firstName; }
    }

    public string LastName 
    { 
      get { return _lastName; }
    }

    public int Age 
    { 
      get { return _age; }
    }

    public Person(string fName, string lName, int age)
    {
      _firstName = fName;
      _lastName = lName;
      _age = age;
    }

    public override string ToString()
    {
      return $"{FirstName} {LastName} is {Age} years old.";
    }
  }
}
