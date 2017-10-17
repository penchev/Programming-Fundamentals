using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<string> input = Console.ReadLine().Split(' ').ToList();
            while (input[0]!= "Odd" && input[0] != "Even")
            {
                if (input[0] == "Delete")
                {
                    for (int i = 0; i < input.Count; i++)
                    {
                        list.Remove(int.Parse(input[1]));
                    }
                }else if (input[0] == "Insert")
                {
                    list.Insert(int.Parse(input[2]), int.Parse(input[1]));
                }
                input = Console.ReadLine().Split(' ').ToList();
            }

            if (input[0] == "Even")
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i] % 2 == 0)
                    {
                        Console.Write(list[i]);
                        Console.Write(" ");
                    }
                }
            }
            else
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i] % 2 != 0)
                    {
                        Console.Write(list[i]);
                        Console.Write(" ");
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
