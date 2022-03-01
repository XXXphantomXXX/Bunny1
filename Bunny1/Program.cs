using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bunny1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("what type of operation would you like to preform?");
            string input = Console.ReadLine();


            switch (input.ToLower())
            {


                case "add":
                case "+":
                    AddNums();
                    break;
                    
                case "subtract":
                case "-":
                    SubtractNums();
                    break;

                case "divide":
                case "/":
                    DivideNums();
                    break;

                case "multiply":
                case "*":
                    MultiplyNums();
                    break;

                default:
                    Console.WriteLine("try * + - /");
                    break;

            }
        }


        public static void DivideNums()
        {
            Console.WriteLine("Enter first number you want to divide:");
            int NumA1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            int NumB1 = int.Parse(Console.ReadLine());
            
                int result = NumA1 / NumB1;
                Console.WriteLine(result);
            Console.ReadKey();


        }

        public static void MultiplyNums()
        {
            Console.WriteLine("Enter first number you want to Multiply:");
            int NumA1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            int NumB1 = int.Parse(Console.ReadLine());


            int result = NumA1 * NumB1;
                Console.WriteLine(result);
            Console.ReadKey();


        }

        public static void SubtractNums()
        {
            Console.WriteLine("Enter first number you want to subtract:");
            int NumA1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            int NumB1 = int.Parse(Console.ReadLine());


            int result = NumA1 - NumB1;
                Console.WriteLine(result);
            Console.ReadKey();
                
            
        }

        public static void AddNums()
        {
            Console.WriteLine("Enter first number you want to Add:");
            var NumA1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            var NumB1 = int.Parse(Console.ReadLine());


            int result = NumA1 + NumB1;
                Console.WriteLine(result);
            Console.ReadKey();
                
            
        }
    }
    
}
