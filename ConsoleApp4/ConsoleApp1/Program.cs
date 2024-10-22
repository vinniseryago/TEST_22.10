using System;
using System.Collections.Generic;

class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Введите строку: ");
        string input = Console.ReadLine();

        Dictionary<char, int> letterCount = CountLetters(input);

        Console.WriteLine("Количество букв:");
        foreach (var kvp in letterCount)
        {
            Console.WriteLine($"{kvp.Key}: {kvp.Value}");
        }
    }

    public static Dictionary<char, int> CountLetters(string str)
    {
        Dictionary<char, int> countDict = new Dictionary<char, int>();

        foreach (char c in str)
        {
            if (countDict.ContainsKey(c))
            {
                countDict[c]++;
            }
            else
            {
                countDict[c] = 1;
            }
        }

        return countDict;
    }
}