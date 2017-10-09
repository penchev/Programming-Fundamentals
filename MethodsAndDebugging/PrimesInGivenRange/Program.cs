using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimesInGivenRange
{
    class Program
    {
        static List<int> FindPrimesInRange(int startNum, int endNum)
        {
            List<int> list = new List<int>();
            bool prime = true;
            if (startNum <= 1)
                startNum=2;
            for (int i = startNum; i <= endNum; i++)
            {
                for (int k = 2; k < i; k++)
                {
                    if (i % k == 0)
                    {
                        prime = false;
                    }

                }
                if (prime == true)
                    list.Add(i);
                prime = true;
            }
            return list;
        }
        static void Main(string[] args)
        {
            List<int> list = FindPrimesInRange(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write($"{list[i]}");
                if(i!=list.Count-1)
                    Console.Write(", ");
                }
            Console.WriteLine();
        }
    }
}
