using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ExcerciseIteration
{
    public class ExcerciseExtended
    {
        public static void GetFact()//Qno3
        {
            var fact = 1;
            Console.Write("Enter a number:");
            var userInput = Convert.ToInt32(Console.ReadLine());
            for(var i=1;i<=userInput;i++)
            {
                fact=fact*i ;
            }
            Console.WriteLine($"{userInput}! ={fact}");
        }
        public static void GuessRandom()
        {
            var count = 4;
            var random = new Random();
            var ranNum = random.Next(1, 10);
            Console.WriteLine(ranNum);
            Console.WriteLine("Here is a game to guess the number You have 4 chances");
           A: Console.WriteLine("Guess the Number:");
            var guess = Convert.ToInt32(Console.ReadLine());
            
            while (guess!=ranNum )
            {
                count--;
                if (count == 0)
                {
                    break;
                }
                else if(count==1)
                {
                   Console.WriteLine($"Wrong ans you have {count} chance left ");
                }
                else 
                {
                    Console.WriteLine($"Wrong ans you have {count} chances left ");
                goto A;
            }
            if (guess == ranNum)
            {
                Console.WriteLine("Hurray You won");
            }
            else
                Console.WriteLine("Sorry You lose");
        }
        public static void GetMax() 
        {
            Console.WriteLine("Enter a series of numbers separated by comma");
            var input = Console.ReadLine();
            var numbers = input.Split(',');
            // Assume the first number is the max 
            var max = Convert.ToInt32(numbers[0]);
            foreach (var str in numbers)
            {
                var number = Convert.ToInt32(str);
                if (number > max)
                    max = number;
            }
            Console.WriteLine("Max is " + max);
            //var name = "Mosh";
            //foreach (var character in name)
            //{
            //    Console.WriteLine(character);
            //}
        }
    }
}
