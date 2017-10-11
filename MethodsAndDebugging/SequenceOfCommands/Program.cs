﻿using System;
using System.Linq;

public class SequenceOfCommands_broken
{
    private const char ArgumentsDelimiter = ' ';

    public static void Main()
    {
        int sizeOfArray = int.Parse(Console.ReadLine());
        bool entered = false;
        long[] array = Console.ReadLine()
            .Split(ArgumentsDelimiter)
            .Select(long.Parse)
            .ToArray();

        string command = string.Empty;

        while (!command.Equals("stop"))
        {
            if (!entered)
                command = Console.ReadLine().Trim();
            entered = false;
            int[] args = new int[2];
            string[] stringParams = command.Split(ArgumentsDelimiter);

            if (stringParams[0].Equals("add") ||
                stringParams[0].Equals("subtract") ||
                stringParams[0].Equals("multiply"))
            {

                args[0] = int.Parse(stringParams[1]);
                args[0] -= 1;
                args[1] = int.Parse(stringParams[2]);

                array = PerformAction(array, stringParams[0], args);
            }
            else
            {
                array = PerformAction(array, stringParams[0], args);
            }


            PrintArray(array);
            Console.WriteLine();

            if (!entered)
            {
                command = Console.ReadLine();
                entered = true;
            }
        }
    }

    static long[] PerformAction(long[] arr, string action, int[] args)
    {
        long[] array = arr.Clone() as long[];
        int pos = args[0];
        int value = args[1];

        switch (action)
        {
            case "multiply":
                array[pos] *= value;
                break;
            case "add":
                array[pos] += value;
                break;
            case "subtract":
                array[pos] -= value;
                break;
            case "lshift":
                ArrayShiftLeft(array);
                break;
            case "rshift":
                array=ArrayShiftRight(array);
                break;
        }
        return array;
    }

    private static long[] ArrayShiftRight(long[] array)
    {
        long num = array[array.Length - 1];
        for (int i = array.Length - 1; i >= 1; i--)
        {
            array[i] = array[i - 1];
        }
        array[0] = num;

        return array;
    }

    private static long[] ArrayShiftLeft(long[] array)
    {
        long num = array[0];
        for (int i = 0; i < array.Length - 1; i++)
        {
            array[i] = array[i + 1];
        }
        array[array.Length - 1] = num;
        return array;
    }

    private static void PrintArray(long[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
    }
}
