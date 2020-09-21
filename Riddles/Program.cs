using System;
using Riddle.Answer;

namespace Riddle {

  public class Program
  {
    public static void Main()
    {
      Phinx outPut = new Phinx();
 
      Console.WriteLine("Can you defeat the Sphinx? If you answer the riddle correctly, you win. Otherwise, you'll be eaten.");
      Console.WriteLine("What month of the year has 28 days?");
      string userAnswer = Console.ReadLine();

      bool result = outPut.CheckAnswer(userAnswer);
      if ( result )
      {
        Console.WriteLine("You defeat the Phinx.");
      }
      else
      {
        Console.WriteLine("You've been eaten by the Phinx.");
      }
    }
  }
}