using System;
using System.Collections.Generic;

namespace GradeBook
{

  class Program
  {
    static void Main(string[] args)
    {

      var book = new Book(" Reginaldo Grade Book");
      book.AddGrade(89.1);
      book.AddGrade(90.5);
      book.AddGrade(77.5);
      var stats = book.GetStatistics();
      Console.WriteLine($"The lowest Grade grade is {stats.Low}!");
      Console.WriteLine($"The High grade is {stats.High}!");
      Console.WriteLine($"The Average grade is {stats.Average:N2}!");
    }
  }
}
