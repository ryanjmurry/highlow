using System;
using System.Collections.Generic;

class HighLow
{
  private int _guess;
  private string _userResponse;
  private List<int> _range = new List<int>();

  public void FillList()
  {
    for(int i = 1; i < 101; ++i)
    {
      _range.Add(i);
    }
  }

  public void GuessingGame()
  {
    FillList();
    while(true)
    {
      _guess = _range[(_range.Count - 1) / 2];
      Console.WriteLine(_guess);
      Console.WriteLine(_range.Count);
      Console.WriteLine("Is your number higher or lower than {0}? (Lower, Higher, Correct)", _guess);
      _userResponse = Console.ReadLine();
      if (_range.Count - 1 == 1)
      {
        break;
      }
      else if (_userResponse == "Higher")
      {
        _range.RemoveRange(0, (_range.Count - 1) / 2);
      }
      else if (_userResponse == "Lower")
      {
        _range.RemoveRange((_range.Count - 1) / 2, _range.Count / 2);
      }
      // else if (_userResponse == "Correct")
      // {
      //   break;
      // }
    }
    Console.WriteLine("Your number is {0}", _guess);
  }
}


class Program
{
  public static void Main()
  {
    HighLow newGame = new HighLow();
    newGame.GuessingGame();
  }

}
