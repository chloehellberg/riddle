using System;

namespace Riddle.Answer {

  public class Phinx
  {
    public bool CheckAnswerOne(string userAnswerOne)
    {
      if ( userAnswerOne.Contains("all") )
      {
        return true;
      }
      else
      {
        switch (userAnswerOne.ToLower())
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

    public bool CheckAnswerTwo(string userAnswerTwo)
    {
      // bool answer = userAnswerTwo.Contains("river") ? true : false;
      // return answer;
      if ( userAnswerTwo.Contains("river") )
      {
        return true;
      }
      else
      {
        return false;
      }
    }    
  }
}