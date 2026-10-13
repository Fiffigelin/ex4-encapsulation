using ex4_encapsulation.Models;

namespace ex4_encapsulation
{
  internal class Program
  {
    static void Main(string[] args)
    {
      var persons = new List<Person>();
      var lines = 0;

      do
      {
        Console.Write("Write a number of people you would like to add: ");
        var input = Console.ReadLine();

        if(int.TryParse(input, out lines) && lines > 0)
        {
          break;
        }

        Console.WriteLine("Please enter a whole number over 0.");
      } while(true);

      for(int i = 0; i < lines; i++)
      {
        try
        {
          Console.Write("Please insert firstname, lastname, age and salary: ");
          var input = Console.ReadLine();

          if(input == null || string.IsNullOrWhiteSpace(input))
          {
            throw new Exception("Input cannot be empty");
          }

          var cmdArgs = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

          if(cmdArgs.Length != 4)
          {
            throw new Exception("Please enter exaclty four values");
          }

          if(!int.TryParse(cmdArgs[2], out int age) || age <= 0)
          {
            throw new Exception("Age must be a number higher than 0.");
          }

          if(!decimal.TryParse(cmdArgs[3], out decimal salary) || salary <= 0)
          {
            throw new Exception("Salary must be a number higher than 0 and be written with ','");
          }

          var person = new Person(cmdArgs[0], cmdArgs[1], age, salary);
          persons.Add(person);
        }
        catch(Exception e)
        {
          Console.WriteLine(e.Message);
          i--; // <== upptäcktes vid manuell testning XD
        }

        if((i+1) == lines)
        {
          var bonus = 0m;
          bool isValid = false;
          do
          {
            Console.Write("Write bonus: ");

            isValid = decimal.TryParse(Console.ReadLine(), out bonus);
          } while(!isValid);

          persons.ForEach(p => p.IncreaseSalary(bonus));
          persons.ForEach(persons => Console.WriteLine(persons.ToString()));
        }
      }
    }
  }
}
