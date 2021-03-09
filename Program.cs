using System;
using System.Linq;

namespace Homework1
{
    class Program
    {
     
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number1 operation and number2. Example: 2 + 3 ");

            string operation = Console.ReadLine();
            //remove whitespices
            string trimmedOperation = String.Concat(operation.Where(c => !Char.IsWhiteSpace(c)));

            //subs[0] will be number1 and subs[1] will be number2
            string[] subs = trimmedOperation.Split('+', '-', '/', '*');
            int number1 = Int32.Parse(subs[0].ToString());
            int number2 = Int32.Parse(subs[1].ToString());

            //subs2[] will have "" and operator, We don't know wich element will be operator
            string[] subs2 = trimmedOperation.Split('1', '2', '3', '4', '5', '6', '7', '8', '9', '0');
            //removing empty strings in array
            subs2 = subs2.Where(x => !string.IsNullOrEmpty(x)).ToArray();
            string operatorInput = subs2[0];
           
            if (operatorInput == "+")
            {
                Console.WriteLine($"{trimmedOperation} = {number1 + number2}");
            }
            else if (operatorInput == "-")
            {
                Console.WriteLine($"{trimmedOperation} = {number1 - number2}");
            }
            else if (operatorInput == "*")
            {
                Console.WriteLine($"{trimmedOperation} = {number1 * number2}");
            }
            else if (operatorInput == "/") {
                Console.WriteLine($"{trimmedOperation} = {number1 / number2}");
            }
            else
            {
                Console.WriteLine("Check operation. Data entered is not in the correct format.");
            }

        }
    }
}
