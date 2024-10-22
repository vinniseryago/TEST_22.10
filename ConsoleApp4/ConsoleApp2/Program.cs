using System;
using System.Collections.Generic;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Введите количество элементов массива:");
        int n = int.Parse(Console.ReadLine());

        int[] numbers = new int[n];
        Console.WriteLine("Введите элементы массива:");

        for (int i = 0; i < n; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        Dictionary<int, int> numberCount = CountNumberOccurrences(numbers);

        Console.WriteLine("Числа, встречающиеся в массиве нечетное количество раз:");
        foreach (var kvp in numberCount)
        {
            if (kvp.Value % 2 != 0)
            {
                Console.WriteLine(kvp.Key);
            }
        }
    }

    public static Dictionary<int, int> CountNumberOccurrences(int[] arr)
    {
        Dictionary<int, int> countDict = new Dictionary<int, int>();

        foreach (int num in arr)
        {
            if (countDict.ContainsKey(num))
            {
                countDict[num]++;
            }
            else
            {
                countDict[num] = 1;
            }
        }

        return countDict;
    }
}