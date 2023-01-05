using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcerciseIteration
{
    class Excercise
    {
         int count = 0;
        public  void GetDiv()//Qno1
        {
            for(var i=1;i<100;i++)
            {
                if (i%3==0)
                {
                    count ++;
                }
            }
            Console.WriteLine(count);
        }
        public static void GetNum()//Qno2
        {
            int sum = 0;
            while (true)
            {
                Console.WriteLine("Enter a number or (ok to exit):");
                var userInput = Console.ReadLine();
                
                if(userInput.ToLower() == "ok")
                {
                    break;
                }
                
                 sum = sum +Convert.ToInt32(userInput);
            }
            Console.WriteLine(sum);
        }
    }
}
