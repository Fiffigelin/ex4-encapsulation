# Övn. 4 - Lab: Encapsulation - Inkapsling  

## 1. Sort Persons by Name and Age**  
 
Create a class Person, which should have private fields for:  
• firstName: string  
• lastName: string  
• age: int  
• ToString(): string - override  
 
You should be able to use the class like this:  
```C#
Program.cs  
public static void Main()  
{  
   var lines = 5;  
   var persons = new List<Person>();   
   for (int i = 0; i < lines; i++)  
   {  
      var cmdArgs = Console.ReadLine().Split();  
      var person = new Person(cmdArgs[0], cmdArgs[1], int.Parse(cmdArgs[2]));     
      persons.Add(person);  
   }   
   persons.OrderBy(p => p.FirstName)  
          .ThenBy(p => p.Age)  
          .ToList()  
          .ForEach(p => Console.WriteLine(p.ToString()));  
}
```
 
Examples 
| Input| Output|
| :--- | :---: |
| Anna Persson 65 | Anna Persson is 65 years old. |
| Anna Andersson 34 | Anna Andersson is 34 years old. |
| Johanna Eriksson 57 | Johanna Eriksson is 57 years old. |
| Johanna Svensson 27 | Johanna Svensson is 27 years old. |
| Erika Samuelsson 35 | Erika Samuelsson is 35 years old. |   
 
## 2.Salary Increase
  
Refactor project from last task.

Read person with their names, age and salary. Read percent bonus to every person salary.  
People younger than 30 get half the increase. Expand Person from the previous task.  

**New fields and methods:**

salary: decimal   
IncreaseSalary(decimal percentage)  
You should be able to use the class like this: 
```c# 
StartUp.cs  
var lines = int.Parse(Console.ReadLine()); 
var persons = new List<Person>();  
for (int i = 0; i < lines; i++)  
{      
   var cmdArgs = Console.ReadLine().Split();         
   var person = new Person( 
       cmdArgs[0], cmdArgs[1],                 
       int.Parse(cmdArgs[2]),                                
       decimal.Parse(cmdArgs[3] 
    ));  
  
    persons.Add(person);  
} var bonus = decimal.Parse(Console.ReadLine()); 
persons.ForEach(p => p.IncreaseSalary(bonus)); 
persons.ForEach(p => Console.WriteLine(p.ToString()));
```
 
Examples  
| Input | Output | 
|--|--|
| Ida Svensson 65 2200 | Ida Svensson receives 2640.00 dollars. |  
| Berit Dahl 57 3333 | Berit Dahl receives 3999.60 dollars. |  
| Bert Lewinsson 27 600 | Bert Lewinsson receives 660.00 dollars. |  
| Anna Hamren 44 666.66 | Anna Hamren receives 799.99 dollars. | 
| Jacob Andersson 35 559.4 | Jacob Andersson receives 671.28 dollars. | 
 
## 3. Validation of Data  
Expand Person with proper validation for every field:  
• Names must be at least 3 symbols  
• Age must not be zero or negative  
• Salary can't be less than 460.0
   
Print proper messages to the user:  
• “Age cannot be zero or a negative integer!”  
• “First name cannot contain fewer than 3 symbols!”  
• “Last name cannot contain fewer than 3 symbols!”  
• “Salary cannot be less than 460 dollar!” 
 
Use ArgumentExeption with messages from example.  

Examples  
| Input | Output |
|--|--|
| Anna Ivanov -6 2200 | Age cannot be zero or a negative integer! |  
| B Dahl 57 3333 | First name cannot contain fewer than 3 symbols! |
| Hanna Ma 27 600 | Last name cannot contain fewer than 3 symbols! |  
| Asen Holm 44 200 | Salary cannot be less than 460 dollars! | 
| Mikael Johansson 35 500 | Boris Magnusson gets 660.00 dollars. |  
| 20 |   |  
 
### Solution 1.  
Create a **new class** and ensure **proper naming.** Define the private fields:
```C#
private string firstName;
private string lastName;
private int age;
``` 
Create a constructor for Person, which takes 3 parameters firstName, lastName, age:
```C#
public Person(string firstName, string lastName, int age)
{
  this.firstName = firstName;
  this.lastName = lastName;
  this.age = age;
}
``` 
Create properties for these fields, which are as strictly as possible: 
```C#
public string FirstName
{
  get { return this.firstName;}
}

public int Age
{
  get {return this:age}
}
```
Override ToString() method:
```C#
public override string ToString()
{
  return $"{this.FirstName} {this.LastName} is {this.Age} years old";
}
```