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
            Console.WriteLine("Enter the first number you would like to preform an operation on");
            int NumA = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number you would like to preform an operation on");
            int NumB = int.Parse(Console.ReadLine());
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

        private static void MultiplyNums()
        {
            throw new NotImplementedException();
        }

        private static void DivideNums()
        {
            throw new NotImplementedException();
        }

        private static void SubtractNums()
        {
            throw new NotImplementedException();
        }

        private static void AddNums()
        {
            throw new NotImplementedException();
        }

        public int DivideNums(int NumA, int NumB)
        {
            Console.WriteLine("Enter first number you want to divide:");
            int NumA1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            int NumB1 = int.Parse(Console.ReadLine());
            
                int result = NumA1 / NumB1;
                Console.WriteLine(result);
                return result;
            
        }

        public int MultiplyNums(int NumA, int NumB)
        {
            Console.WriteLine("Enter first number you want to Multiply:");
            int NumA1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            int NumB1 = int.Parse(Console.ReadLine());


            int result = NumA1 * NumB1;
                Console.WriteLine(result);
                return result;
            
        }

        public int SubtractNums(int NumA, int NumB)
        {
            Console.WriteLine("Enter first number you want to subtract:");
            int NumA1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            int NumB1 = int.Parse(Console.ReadLine());


            int result = NumA1 - NumB1;
                Console.WriteLine(result);
                return result;
            
        }

        public int AddNums(int NumA, int NumB)
        {
            Console.WriteLine("Enter first number you want to Add:");
            var NumA1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            var NumB1 = int.Parse(Console.ReadLine());


            int result = NumA1 + NumB1;
                Console.WriteLine(result);
                return result;
            
        }
    }
    
}
