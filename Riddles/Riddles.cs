using System;

namespace Riddle.Answer {

  public class Phinx
  {
    public bool CheckAnswer(string userAnswer)
    {
      if ( userAnswer.Contains("all") )
      {
        return true;
      }
      else
      {
        switch (userAnswer.ToLower())
        {
          case "january":
          case "february":
          case "march":
          case "april":
          case "may":
          case "june":
          case "july":
          case "august":
          case "september":
          case "october":
          case "november":
          case "december":
            return true;
          default:
            return false;
        }
      }
    }
  }
}