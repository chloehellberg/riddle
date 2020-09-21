using System;
using System.Collections.Generic;
using Riddle.Answer;

namespace Riddle {

  public class Program
  {
    public static void Main()
    {
      Phinx outPut = new Phinx();

      var random = new Random();

      List<int> qaList = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };

      for (int index = 1; index < 4; index++)
      {
        int ran = random.Next(qaList.Count);        // randomizer
        int num = qaList[ran - 1];
        qaList.Remove(num);                         // take away asked question
        string question = outPut.GetQuestion(num);  // send for question
        Console.WriteLine(index + ". " + question); // write question
        string userAnswer = Console.ReadLine();      // get answer
        bool result = outPut.CheckAnswer(num, userAnswer);    // send answer to check if correct
        if (result)                                   // if true ask next question or win and break
        {
          if ( index == 3 )
          {
            Console.WriteLine("You win the game.");
            break;
          }
        }
        else                                          // else false, user eaten and break.
        {
          Console.WriteLine("You have been eaten by the Sphinx.");
          break;
        }
      }
    }
  }
}