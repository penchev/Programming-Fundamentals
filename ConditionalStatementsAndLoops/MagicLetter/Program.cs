﻿using System;

namespace MagicLetter
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstLetter = char.Parse(Console.ReadLine());
            char secondLetter = char.Parse(Console.ReadLine());
            char thirdLetter = char.Parse(Console.ReadLine());
            
            for (char i = firstLetter; i <= secondLetter; i++)
                for (char j = firstLetter; j <= secondLetter; j++)
                    for (char k = firstLetter; k <= secondLetter; k++)
                        if(i!=thirdLetter && j!=thirdLetter && k!=thirdLetter)
                        Console.Write("{0}{1}{2} ", i, j , k);
        }
    }
}