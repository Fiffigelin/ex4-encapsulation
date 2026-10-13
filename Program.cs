using ex4_encapsulation.Models;

namespace ex4_encapsulation
{
  internal class Program
  {
    static void Main(string[] args)
    {
      var lines = 5;
      var persons = new List<Person>();

      for(int i = 0; i < lines; i++)
      {
        try
        {
          Console.Write("Please insert firstname, lastname and age: ");
          var input = Console.ReadLine();

          if(input == null || string.IsNullOrWhiteSpace(input))
          {
            throw new Exception("Input cannot be empty");
          }

          var cmdArgs = input.Split(' ');

          if(cmdArgs.Length != 3)
          {
            throw new Exception("Please enter exaclty three values");
          }

          if(!int.TryParse(cmdArgs[2], out int age) || age <= 0)
          {
            throw new Exception("Age must be a number higher than 0.");
          }

          var person = new Person(cmdArgs[0], cmdArgs[1], age);
          persons.Add(person);
        }
        catch(Exception e)
        {
          Console.WriteLine(e.Message);
          i--; // <== upptäcktes vid manuell testning XD
        }

        if((i+1) == lines)
        {
          persons.OrderBy(p => p.FirstName)
            .ThenBy(p => p.Age)
            .ToList()
            .ForEach(persons => Console.WriteLine(persons.ToString()));
        }
      }
    }
  }
}
