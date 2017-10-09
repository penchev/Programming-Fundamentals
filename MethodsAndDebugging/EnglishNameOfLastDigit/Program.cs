﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishNameOfLastDigit
{
    class Program
    {
        static string NameOFLastDigit(long number)
        {
            string name = string.Empty;
            number = Math.Abs(number);
            number = number % 10;
            switch (number)
            {
                case 0:
                    name = "zero";
                    break;
                case 1:
                    name = "one";
                    break;
                case 2:
                    name = "two";
                    break;
                case 3:
                    name = "three";
                    break;
                case 4:
                    name = "four";
                    break;
                case 5:
                    name = "five";
                    break;
                case 6:
                    name = "six";
                    break;
                case 7:
                    name = "seven";
                    break;
                case 8:
                    name = "eight";
                    break;
                case 9:
                    name = "nine";
                    break;
                default:
                    break;
            }
            return name;
        }
        static void Main(string[] args)
        {
            string name = NameOFLastDigit(long.Parse(Console.ReadLine()));
            Console.WriteLine(name);
        }
    }
}
