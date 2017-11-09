using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class AnonymousThreat
{
    static void Main()
    {
        List<string> inputData = Console.ReadLine().Split(' ').ToList();
        var input = Console.ReadLine().Split(' ').ToArray();

        while (input[0] != "3:1")
        {
            if (input[0] == "merge")
            {
                int startIndex = int.Parse(input[1]);
                if (startIndex < 0)
                    startIndex = 0;
                int endIndex = int.Parse(input[2]);
                if (endIndex > inputData.Count() - 1)
                    endIndex = inputData.Count() - 1;
                
                Merge(inputData, startIndex, endIndex);
            }
            else if (input[0] == "divide")
            {
                int index = int.Parse(input[1]);
                int partitions = int.Parse(input[2]);
                try
                {
                    Divide(inputData, index, partitions);
                }
                catch (Exception)
                {
                    Console.WriteLine("Divide to 0");
                };
            }
            input = Console.ReadLine().Split(' ').ToArray();
        }
        Console.WriteLine(string.Join(" ", inputData));
    }

    private static void Divide(List<string> inputData, int index, int partitions)
    {
        int length = inputData[index].Length;
        length /= partitions;
        int indexForSubstring = length;
        if (inputData[index].Length%2 == 0)
        {
            for (int i = 0; i < partitions; i++)
            {
                string substring = inputData[index].Substring(inputData[index].Length - indexForSubstring,length);
                indexForSubstring += length;
                inputData.Insert(index + 1, substring);
            }
        }
        else
        {
            string substring = inputData[index].Substring(inputData[index].Length - indexForSubstring - 1, length+1);
                indexForSubstring += length;
                inputData.Insert(index + 1, substring);

            for (int i = 0; i < partitions-1; i++)
            {
                substring = inputData[index].Substring(inputData[index].Length - indexForSubstring-1, length);
                indexForSubstring += length;
                inputData.Insert(index + 1, substring);
            }
        }
        inputData.RemoveAt(index);
    }

    static void Merge(List<string> inputData, int startIndex, int endIndex)
    {
        /*
        bool full = false;
        if (endIndex > inputData.Count() - 1)
        {
            endIndex = inputData.Count() - 1;
        }
        for (int i = startIndex + 1; i <= endIndex; i++)
        {
            if (endIndex > inputData.Count() - 1)
            {
                i = inputData.Count() - 1;
                full = true;
                endIndex--;
            }
            string next = inputData[startIndex + 1];

            inputData.RemoveAt(startIndex + 1);
        }
        */

        for (int i = startIndex+1; i <= endIndex; i++)
        {
            int j = startIndex + 1;
            string element = string.Concat(inputData[startIndex], inputData[j]);
            inputData[startIndex] = element;
            inputData.RemoveAt(j);
        }
    }
}

