using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Input value: ");
            //int input =  Convert.ToInt32(Console.ReadLine());
            
            //int[] numbers = new int[input];

            //Console.WriteLine("Please Enter your User Input: ");

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    //int userInput = Convert.ToInt32(Console.ReadLine());
            //    String userInputText = Console.ReadLine();
            //    int userInput = Convert.ToInt32(userInputText);
            //    numbers[i] = userInput;
            //}

            //int result = 0;

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    int number = numbers[i];
            //    result = result + number;
            //}
            //Console.WriteLine("Result: "+result);
            //Console.ReadKey();


            int[] values = new[] { 1, 24, 5, 676, 7, 88, 8 };
            Array.Sort(values);
            Array.Reverse(values);

            for(int i = 0; i < values.Length; i++)
            {
                Console.WriteLine(values[i]);
            }
            Console.ReadKey();
        }
    }
}
