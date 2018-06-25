using System;
using System.Collections.Generic;

class Program
{
  public static void Main()
  {
    int guess;
    string userResponse;
    List<int> range = new List<int>();
    for(int i = 1; i < 101; ++i)
    {
      range.Add(i);
    }

    while(true)
    {
      guess = range[(range.Count - 1) / 2];
      Console.WriteLine(guess);
      Console.WriteLine(range.Count);
      Console.WriteLine("Is your number higher or lower than {0}? (Lower, Higher, Correct)", guess);
      userResponse = Console.ReadLine();
      if (userResponse == "Higher")
      {
        range.RemoveRange(0, (range.Count - 1) / 2);
      }
      else if (userResponse == "Lower")
      {
        range.RemoveRange((range.Count - 1) / 2, range.Count / 2);
      }
      else if (userResponse == "Correct")
      {
        break;
      }

    }

    Console.WriteLine("Your number is {0}", guess);
  }

}
