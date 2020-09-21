using System;

namespace Riddle.Answer {

  public class Phinx
  {
    public string GetQuestion(int num)
    {
      switch (num)
      {
        case 1:
          return "What month of the year has 28 days?";
        case 2:
          return "What can run, but never walks; has a mouth, but never talks; has a head, but never weeps; has a bed, but never sleeps?";
        case 3:
          return "This thing all things devour: birds, beasts, trees, flowers; gnaws iron, bites steel; grinds hard stones to meal; slays kings, ruins towns; and beats high mountains down.";
        case 4:
          return "In spring I am gay in handsome array; in summer more clothing I wear; when colder it grows, I fling off my clothes; and in winter quite naked appear.";
        case 5:
          return "I’m alive, but without breath; I’m as cold in life as in death; I’m never thirsty, though I always drink.";
        case 6:
          return "As small as your thumb, I am light in the air. You may hear me before you see me, but trust that I’m here.";
        case 7:
          return "Never resting, never still; moving silently from hill to hill; it does not walk, run or trot; all is cool where it is not.";
        case 8:
          return "What can bring back the dead; make you cry, make you laugh, make you young; is born in an instant, yet lasts a lifetime.";
        case 9:
          return "What is always old and sometimes new; never sad, sometimes blue; never empty, but sometimes full; never pushes, always pulls?";
        case 10:
          return "What is large, yet never grows; has roots that cannot be seen; and is taller than trees?";
        case 11:
          return "At night they come without being fetched, and by day they are lost without being stolen.";
        case 12:
          return "I create my lair with earthen string, and dispatch my prey with a biting sting.";
        case 13:
          return "Some try to hide, some try to cheat; but time will show, we always will meet. Try as you might to guess my name.";
        default:
          return "false";
      }
    }
    public bool CheckAnswer(int num, string userAnswer)
    {
      userAnswer.ToLower();

      switch (num)
      {
        case 1:
          if ( userAnswer.Contains("all") )
          {
            return true;
          }
          else
          {
            switch (userAnswer)
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
        case 2:
          return userAnswer.Contains("river") ? true : false;
        case 3:
          return userAnswer.Contains("time") ? true : false;
        case 4:
          return userAnswer.Contains("tree") ? true : false;
        case 5:
          return userAnswer.Contains("fish") ? true : false;
        case 6:
          return userAnswer.Contains("hummingbird") ? true : false;
        case 7:
          return userAnswer.Contains("sun") ? true : false;
        case 8:
          return userAnswer.Contains("memory") ? true : false;
        case 9:
          return userAnswer.Contains("moon") ? true : false;
        case 10:
          return userAnswer.Contains("mountain") ? true : false;
        case 11:
          return userAnswer.Contains("stars") ? true : false;
        case 12:
          return userAnswer.Contains("spider") ? true : false;
        case 13:
          return userAnswer.Contains("death") ? true : false;
        default:
          return false;
      }
    }   
  }
}