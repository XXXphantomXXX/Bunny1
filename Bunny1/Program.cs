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
            //simple Calculator- My virsion
            //    {
            //        Console.WriteLine("what type of operation would you like to preform?");
            //        string input = Console.ReadLine();


            //        switch (input.ToLower())
            //        {


            //            case "add":
            //            case "+":
            //                AddNums();
            //                break;

            //            case "subtract":
            //            case "-":
            //                SubtractNums();
            //                break;

            //            case "divide":
            //            case "/":
            //                DivideNums();
            //                break;

            //            case "multiply":
            //            case "*":
            //                MultiplyNums();
            //                break;

            //            case "close":
            //            case "end":
            //                runner = false;
            //                break;


            //            default:
            //                Console.WriteLine("try * + - /");
            //                break;

            //        }
            //    }
            //}

            //private static void DivideNums()
            //{
            //    Console.WriteLine("Enter first number you want to divide:");
            //    int NumA1 = int.Parse(Console.ReadLine());
            //    Console.WriteLine("Enter second number:");
            //    int NumB1 = int.Parse(Console.ReadLine());

            //    int result = NumA1 / NumB1;
            //    Console.WriteLine(result);
            //    Console.ReadKey();


            //}

            //private static void SubtractNums()
            //{
            //    Console.WriteLine("Enter first number you want to subtract:");
            //    int NumA1 = int.Parse(Console.ReadLine());
            //    Console.WriteLine("Enter second number:");
            //    int NumB1 = int.Parse(Console.ReadLine());


            //    int result = NumA1 - NumB1;
            //    Console.WriteLine(result);
            //    Console.ReadKey();


            //}

            //private static void AddNums()
            //{
            //    Console.WriteLine("Enter first number you want to Add:");
            //    var NumA1 = int.Parse(Console.ReadLine());
            //    Console.WriteLine("Enter second number:");
            //    var NumB1 = int.Parse(Console.ReadLine());


            //    int result = NumA1 + NumB1;
            //    Console.WriteLine(result);
            //    Console.ReadKey();


            //}

            //private static void MultiplyNums()
            //{
            //    Console.WriteLine("Enter first number you want to Multiply:");
            //    int NumA1 = int.Parse(Console.ReadLine());
            //    Console.WriteLine("Enter second number:");
            //    int NumB1 = int.Parse(Console.ReadLine());


            //    int result = NumA1 * NumB1;
            //    Console.WriteLine(result);
            //    Console.ReadKey();

            //    var testNUm = Math.PI;
            //    var testNum2 = 22 / 7;


            //}

            //from mega project list 
            //Find PI to the Nth Digit
            //Console.WriteLine("how many decimal of pi do you want?");
            //var input = int.Parse(Console.ReadLine());
            //var testNUm = Math.PI;
            //var N21 = Math.Round(testNUm, input);
            //Console.WriteLine("here you go! "+  N21 );
            //Console.ReadKey();

            //Find e to the Nth Digit
            //Console.WriteLine("How many decimal digit of E do you want?");
            //var input = int.Parse(Console.ReadLine());
            //var ENum = Math.E;
            //var OutPutNum = Math.Round(ENum, input);
            //Console.WriteLine(OutPutNum);

            //version in course 
            //(made custome types first in video)
            // creat a new object from the input-converter class
            InputConverter inputConverter = new InputConverter();
            // Calculator Engine
            CalculatorEngine calculatorEngine = new CalculatorEngine();
            // Takes the user first input and converts it to to number
            double firstNumber = inputConverter.ConvertInputToNumber(Console.ReadLine());
            double secondNumber = inputConverter.ConvertInputToNumber(Console.ReadLine());
            string operation = Console.ReadLine();
            double result = calculatorEngine.Calculate(operation, firstNumber, secondNumber);
            Console.WriteLine(result);
            //keep program open(could have added a while loop to do this...but i didnt.)
            Console.ReadKey();


        }
    }
    
}
