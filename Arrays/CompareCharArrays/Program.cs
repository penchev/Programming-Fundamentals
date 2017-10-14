using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareCharArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] array1 = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            char[] array2 = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            bool equals = false;
            int printArray = 0;

            if (array1.Length > array2.Length)
            {
                printArray = 2;
            }
            else if (array1.Length < array2.Length)
            {
                printArray = 1;
            }
            else
            {
                for (int i = 0; i < array1.Length; i++)
                {
                    if (array1[i] == array2[i])
                    {
                        if (i + 1 == array1.Length)
                        {
                            equals = true;
                            break;
                        }
                        continue;
                    }
                    else if (array1[i] > array2[i])
                    {
                        printArray = 2;
                        break;
                    }
                    else
                    {
                        printArray = 1;
                        break;
                    }
                }
            }

            if (printArray==1)
            {
                Console.WriteLine(string.Join("", array1));
                Console.WriteLine(string.Join("", array2));
            }
            else
            {
                Console.WriteLine(string.Join("", array2));
                Console.WriteLine(string.Join("", array1));
            }
        }
    }
}
