using System;
using System.Collections.Generic;

namespace GradeBook
{

  class Program
  {
    static void Main(string[] args)
    {

      var book = new Book(" Reginaldo Grade Book");
      /*book.AddGrade(89.1);
      book.AddGrade(90.5);
      book.AddGrade(77.5);*/

      while (true)
      {
        Console.WriteLine("Enter a grade or 'q' to quit");
        var input = Console.ReadLine();
        if (input == "q")
        {
          break;
        }
        try
        {
           var grade = double.Parse(input);
           book.AddGrade(grade);
        }
        catch(Exception ex)
        {
          Console.WriteLine(ex.Message);
        }

      }
      var stats = book.GetStatistics();
      Console.WriteLine($"The lowest Grade grade is {stats.Low}!");
      Console.WriteLine($"The High grade is {stats.High}!");
      Console.WriteLine($"The Average grade is {stats.Average:N2}!");
    }
  }
}
