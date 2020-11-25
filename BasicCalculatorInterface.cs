﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TestInterfaces
{
    interface BasicCalculatorInterface
    {
        int sum(int x, int y);
        int sub(int x, int y);
        int multiplication(int x, int y);
        int division(int x, int y);
    }
    class BasicCalc : BasicCalculatorInterface
    {
        int result;
        public int sum(int number1, int number2)
        {
            result = number1 + number2;
            return result;
        }
        public int sub(int number1, int number2)
        {
            result = number1 - number2;
            return result;
        }
        public int multiplication(int number1, int number2)
        {
            result = number1 * number2;
            return result;
        }
        public int division(int number1, int number2)
        {
            result = number1 / number2;
            return result;
        }
        public void printStates()
        {
            Console.WriteLine("Result : " + result);
        }
    }
}
