﻿using System;

namespace FiveDifferentNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int i = 0;
            int j = a;

            if (b - a < 5)
            {
                Console.WriteLine("No");
            }else{
                for (int i1 = a; i1 <= b-4; i1++)
                    for (int i2 = i1+1; i2 <= b-3; i2++)
                        for (int i3 = i2+1; i3 <= b-2; i3++)
                            for (int i4 = i3+1; i4 <= b-1; i4++)
                                for (int i5 = i4+1; i5 <= b; i5++)
                                    Console.WriteLine("{0} {1} {2} {3} {4}", i1, i2, i3, i4, i5);
            }


        }
    }
}