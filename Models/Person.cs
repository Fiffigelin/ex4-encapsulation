namespace ex4_encapsulation.Models
{
  public class Person
  {
    // jag är van vid att skriva private med '_' innan namnet.
    private string _firstName; 
    private string _lastName;
    private int _age;

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

    public Person(string fName, string lName, int age)
    {
      this._firstName = fName;
      this._lastName = lName;
      this._age = age;
    }

    public override string ToString()
    {
      return $"{this.FirstName} {this.LastName} is {this.Age} years old.";
    }
  }
}
