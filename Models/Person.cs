using System.ComponentModel;
using System.Xml.Linq;

namespace ex4_encapsulation.Models
{
  public class Person
  {
    // jag är van vid att skriva private med '_' innan namnet.
    private string _firstName; 
    private string _lastName;
    private int _age;
    private decimal _salary;

    public string FirstName 
    { 
      get { return this._firstName; }
      private set
      {
        if (value.Length < 3)
        {
          throw new ArgumentException("First name cannot contain fewer than 3 symbols!");
        }

        this._firstName = value;
      }
    }

    public string LastName 
    { 
      get { return this._lastName; }
      private set
      {
        if(value.Length < 3)
        {
          throw new ArgumentException("Last name cannot contain fewer than 3 symbols!");
        }

        this._lastName = value;
      }
    }

    public int Age 
    { 
      get { return this._age; }
      private set
      {
        if(value <= 0)
        {
          throw new ArgumentException("Age cannot be zero or a negative integer!");
        }

        this._age = value;
      }
    }

    public decimal Salary 
    { 
      get { return this._salary; }
      private set
      {
        if(value < 460)
        {
          throw new ArgumentException("Salary cannot be less than 460 dollar!");
        }

        this._salary = value;
      }
    }

    public Person(string fName, string lName, int age, decimal salary)
    {
      this.FirstName = fName;
      this.LastName = lName;
      this.Age = age;
      this.Salary = salary;
    }

    public override string ToString()
    {
      return $"{this.FirstName} {this.LastName} receives {this._salary} dollars";
    }

    public void IncreaseSalary(decimal percentage)
    {
      if(this.Age < 30)
      {
        percentage /= 2;
      }

      this._salary += this._salary * percentage / 100;
    }
  }
}
