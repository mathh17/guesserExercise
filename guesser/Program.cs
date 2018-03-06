using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guesser
{
    class Guesser
    {
        // the "const" keyword makes the value of the variable final, meaning it can never be modified
        // a variable with "const" acts also as if it had the "static" modifier, meaning it can be accessed without needing to instantiate an object
        const int MaxTrials = 10;

        static void Main(string[] args)
        {
         string[] Clues = new string[] { "", "It is an old danish name", "it is almost extinct", "A couple of years ago someone would give 10,000kr if a pair of parents would call their child this name", "It starts with P", "It ends on N", "It has the danish word for leg in it", "ooh come on man", "It also have Pre", "You have to try harder", "It starts with Pr and ends on ben" };

        Console.WriteLine("Welcome to the guessing game!");
            Console.WriteLine("I am thinking of a name, and you have to guess it! You have 10 tries, remember all names start with a capital letter!");
            for (int i = 1; i <= MaxTrials; i++)
            {
                if (Console.ReadLine() == "Preben" )
                {
                    Console.WriteLine("Good Job you guessed the name!");
                    break;
                }
                else
                {
                    Console.WriteLine("HAHAHAHA you guessed wrong!");
                    Console.WriteLine("sorry.... Guess again");
                    Console.WriteLine(Clues[i]);
                    Console.WriteLine("You have " + (MaxTrials - i) + " tries left");
                }
                
                if (i == MaxTrials )
                {
                    Console.WriteLine("Damn it! you used all of your tries! the right answer was Preben!!");
                }
            }

            Console.ReadLine();
        }
    }
}
