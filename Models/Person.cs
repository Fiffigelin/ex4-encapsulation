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
    }

    public string LastName 
    { 
      get { return this._lastName; }
    }

    public int Age 
    { 
      get { return this._age; }
    }
    public decimal Salary 
    { 
      get { return this._salary; }
    }

    public Person(string fName, string lName, int age, decimal salary)
    {
      this._firstName = fName;
      this._lastName = lName;
      this._age = age;
      this._salary = salary;
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
