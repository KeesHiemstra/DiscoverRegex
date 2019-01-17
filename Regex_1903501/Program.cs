using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

/// <summary>
/// NOT WORKING YET
/// </summary>

namespace Regex_1903401
{
  class Program
  {
    static void Main(string[] args)
    {
      SplitWRegex(@"<html><body><h1>Title</h1><p class='Nope'>Maybe this was the title.</p><hr/><p>Try is it.</p></body></html>");

      Console.Write("\nPress any key...");
      Console.ReadKey();
    }

    private static void SplitWRegex(string body)
    {
      Console.WriteLine($"{body}\n");

      string pattern = @"(?:<.*)(?:>)";
      Regex regex = new Regex(pattern);

      var matches = regex.Matches(body);

      int count = 0;
      foreach (var Match in matches)
      {
        Console.WriteLine($"{count}: {Match}");
        count++;
      }
    }
  }
}
