using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            string[] command = Console.ReadLine().Split(' ').ToArray();
            int[] contains = new int[20];
            for (int i = 0; i < contains.Length; i++)
            {
                contains[i] = -2;
            }
            int j = 0;

            while (command[0] != "print")
            {
                switch (command[0])
                {
                    case "add":
                        input.Insert(int.Parse(command[1]), int.Parse(command[2]));
                        break;
                    case "addMany":
                        for (int i = command.Length-1; i > 1 ; i--)
                        {
                            input.Insert(int.Parse(command[1]), int.Parse(command[i]));
                        }
                        break;
                    case "contains":
                        for (int i = 0; i < input.Count; i++)
                        {
                            if (int.Parse(command[1]) == input[i])
                            {
                                contains[j] = i;
                                j++;
                                break;
                            }
                            else
                            {
                                contains[j] = -1;
                            }
                        }
                        break;
                    case "remove":
                        input.RemoveAt(int.Parse(command[1]));
                        break;
                    case "shift":
                        if (int.Parse(command[1]) <= input.Count-1)
                        {
                            int buffer = 0;
                            for (int i = 0; i < int.Parse(command[1]); i++)
                            {
                                buffer = input[0];
                                for (int k = 0; k < input.Count - 1; k++)
                                {
                                    input[k] = input[k + 1];

                                }
                                input[input.Count - 1] = buffer;
                            }
                        }
                        break;
                    case "sumPairs":
                        int count = input.Count;
                        j = 0;
                        int counter = 0;
                        if (input.Count % 2 != 0)
                            count = input.Count - 1;
                        for (int i = 0; i < count; i+=2)
                        {
                            input[j] = input[i] + input[i + 1];
                            j++;
                            counter++;
                        }
                        for (int i = 0; i < counter; i++)
                        {
                            input.RemoveAt(counter);
                        }
                        break;
                    default:
                        break;
                }
                command = Console.ReadLine().Split(' ').ToArray();
            }
            for (int i = 0; i < contains.Length ; i++)
            {
                //posible bug
                if(contains[i]!=-2)
                Console.WriteLine(contains[i]);
            }
            Console.Write("[");
            Console.Write(string.Join(", ", input));
            Console.Write("]");
            Console.WriteLine();
        }
    }
}
