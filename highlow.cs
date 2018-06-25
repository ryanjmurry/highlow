using System;
using System.Collections.Generic;

class HighLow
{
  private int _guess;
  private int _humanGuess;
  private int _computerNumber;
  private string _userResponse;
  private List<int> _range = new List<int>();

  public void WhichGame()
  {
    Console.WriteLine("Press 1 to have the computer guess your secret number.");
    Console.WriteLine("Press 2 to guess the computer's secret number.");
    string choice = Console.ReadLine();
    if (choice == "1")
    {
      ComputerGuessingGame();
    }
    else if (choice == "2")
    {
      HumanGuessingGame();
    }
    else
    {
      Console.WriteLine("Please enter a valid option");
      WhichGame();
    }

  }

  public void FillList()
  {
    for(int i = 1; i < 102; ++i)
    {
      _range.Add(i);
    }
  }

  public void HumanGuessingGame()
  {
    FillList();
    Random rnd = new Random();
    _computerNumber = rnd.Next(1, 101);
    Console.WriteLine(_computerNumber);
    while(true)
    {
      Console.WriteLine("What do you think the secret number is?");
      string stringHumanGuess = Console.ReadLine();
      _humanGuess = int.Parse(stringHumanGuess);

      if (_humanGuess < _computerNumber)
      {
        Console.WriteLine("Your guess is TOO LOW");
      }
      else if (_humanGuess > _computerNumber)
      {
        Console.WriteLine("Your guess is TOO HIGH");
      }
      else if (_humanGuess == _computerNumber)
      {
        Console.WriteLine("THAT IS THE NUMBER");
        break;
      }
    }
  }

  public void ComputerGuessingGame()
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
    newGame.WhichGame();
    Console.WriteLine("Play Again? (Y/N)");
    string again = Console.ReadLine();
    if (again == "Y")
    {
      Main();
    }
  }
}
