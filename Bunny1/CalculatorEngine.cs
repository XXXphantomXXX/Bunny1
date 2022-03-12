using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bunny1
{
    class CalculatorEngine
    {
        public double Calculate(string argOperation, double argFirstNum ,double argSecondNum)
        {
            double result;
            switch (argOperation.ToLower())
            {
                case "add":
                case "+":
                    result = argFirstNum + argSecondNum;
                    break;

                case "subtract":
                case "-":
                    result = argFirstNum - argSecondNum;
                    break;

                case "multiply":
                case "*":
                    result = argFirstNum * argSecondNum;
                    break;

                case "divide":
                case "/":
                    result = argFirstNum / argSecondNum;
                    break;

                default:
                    throw new InvalidOperationException("specified opertion not reconized.");


            }
            return result;

        }
    }
}
