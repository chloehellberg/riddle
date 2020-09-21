using System;
using Riddle.Answer;

namespace Riddle {

  public class Program
  {
    public static void Main()
    {
      Phinx outPut = new Phinx();
 
      Console.WriteLine("Can you defeat the Sphinx? If you answer the riddle correctly, you win. Otherwise, you'll be eaten.");
      Console.WriteLine("Question 1: What month of the year has 28 days?");
      string userAnswerOne = Console.ReadLine();

      bool result = outPut.CheckAnswerOne(userAnswerOne);
      if ( result )
      {
        Console.WriteLine("Nice work, now for a second question.");
      }
      else
      {
        Console.WriteLine("You've been eaten by the Phinx.");
      }

      Console.WriteLine("Question 2: What can run, but never walks; has a mouth, but never talks; has a head, but never weeps; has a bed, but never sleeps?");
      string userAnswerTwo = Console.ReadLine();

      bool resultTwo = outPut.CheckAnswerTwo(userAnswerTwo);
      if ( resultTwo )
      {
        Console.WriteLine("You win.");
      }
      else
      {
        Console.WriteLine("You've been eaten by the Phinx.");
      }
    }
  }
}

    // Riddle: This thing all things devour: birds, beasts, trees, flowers; gnaws iron, bites steel; grinds hard stones to meal; slays kings, ruins towns; and beats high mountains down.
    // Answer: Time
    // Riddle: In spring I am gay in handsome array; in summer more clothing I wear; when colder it grows, I fling off my clothes; and in winter quite naked appear.
    // Answer: A tree
    // Riddle: I’m alive, but without breath; I’m as cold in life as in death; I’m never thirsty, though I always drink.
    // Answer: A fish
    // Riddle: As small as your thumb, I am light in the air. You may hear me before you see me, but trust that I’m here.
    // Answer: A hummingbird
    // Riddle: Never resting, never still; moving silently from hill to hill; it does not walk, run or trot; all is cool where it is not.
    // Answer: The sun
    // Riddle: What can bring back the dead; make you cry, make you laugh, make you young; is born in an instant, yet lasts a lifetime.
    // Answer: Memory
    // Riddle: What is always old and sometimes new; never sad, sometimes blue; never empty, but sometimes full; never pushes, always pulls?
    // Answer: The moon
    // Riddle: What is large, yet never grows; has roots that cannot be seen; and is taller than trees?
    // Answer: A mountain
    // Riddle: At night they come without being fetched, and by day they are lost without being stolen.
    // Answer: Stars
    // Riddle: I create my lair with earthen string, and dispatch my prey with a biting sting.
    // Answer: A spider
    // Riddle: Some try to hide, some try to cheat; but time will show, we always will meet. Try as you might to guess my name.
    // Answer: Death
    // Riddle: What can run, but never walks; has a mouth, but never talks; has a head, but never weeps; has a bed, but never sleeps?
    // Answer: A river
