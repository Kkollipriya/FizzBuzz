using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            FizzBizzLogic objFizz = new FizzBizzLogic();
            List<string> inputStrings = new List<string>();
            Console.WriteLine("Please eneter the array length and enter");
            int n = 0;
            int.TryParse(Console.ReadLine(),out n);
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Please eneter the {i} index element and enter");
                inputStrings.Add(Console.ReadLine());
            }
            int value = 0;
            foreach (string input in inputStrings)
            {
                if(int.TryParse(input,out value))
                {
                    switch(objFizz.FizzBizz(value))
                    {
                        case 3: 
                            Console.WriteLine($"{input} : Fizz");
                            break;
                        case 5:
                            Console.WriteLine($"{input} : Buzz");
                            break;
                        case 15:
                            Console.WriteLine($"{input} : FizzBuzz");
                            break;
                        case -1:
                            Console.WriteLine($"{input} : Divided {input} by 3");
                            Console.WriteLine($"{input} : Divided {input} by 5");
                            break;
                    }
                }
                else
                Console.WriteLine($"{input} :Invalid Item");                
            }

            Console.Read();
        }
    }
}
