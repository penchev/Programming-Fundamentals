using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class AnonymousCache
{
    static void AddData(Dictionary<string, int> nestedDict, string dataKey, int dataSize)
    {
        if (!nestedDict.ContainsKey(dataKey))
        {
            nestedDict.Add(dataKey, dataSize);
        }
    }
    static void Main()
    {
        Dictionary<string, Dictionary<string, int>> data = new Dictionary<string, Dictionary<string, int>>();
        Dictionary<string, Dictionary<string, int>> cache = new Dictionary<string, Dictionary<string, int>>();

        var input = Console.ReadLine().Split(new char[] { ' ', '-', '>', '|' }, StringSplitOptions.RemoveEmptyEntries);

        while (input[0] != "thetinggoesskrra")
        {
            string dataSet = string.Empty;
            string dataKey = string.Empty;
            int dataSize = 0;
            bool toAddKey = false;
            if (input.Length == 1)
            {
                dataSet = input[0];
                toAddKey = true;
            }
            else
            {
                dataKey = input[0];
                dataSize = int.Parse(input[1]);
                dataSet = input[2];
            }

            if (!data.ContainsKey(dataSet) && toAddKey)
            {
                data.Add(dataSet, new Dictionary<string, int>());
                if (cache.ContainsKey(dataSet))
                {
                    foreach (var pair in cache[dataSet])
                    {
                        data[dataSet].Add(pair.Key, pair.Value);
                    }
                }
            }
            else if (input.Length > 1 && data.ContainsKey(dataSet))
            {
                AddData(data[dataSet], dataKey, dataSize);
            }
            else if (input.Length > 1 && !data.ContainsKey(dataSet))
            {
                if (!cache.ContainsKey(dataSet))
                    cache.Add(dataSet, new Dictionary<string, int>());
                AddData(cache[dataSet], dataKey, dataSize);
            }
            input = Console.ReadLine().Split(new char[] { ' ', '-', '>', '|' }, StringSplitOptions.RemoveEmptyEntries);
        }

        foreach (var set in data.OrderByDescending(x => x.Value.Values.Sum()))
        {
            Console.WriteLine($"Data Set: {set.Key}, Total Size: {set.Value.Values.Sum()}");
            foreach (var token in set.Value)
            {
                Console.WriteLine($"$.{token.Key}");
            }
            break;
        }
    }
}
