using System;
class Program
{
    public static void Main(string[] args)
    {
        int[] inputArray = new int[] { 2, 6, 0, 4, 0, 1, 0, 3, 0, 5 }; int[] resultArray = MoveZeroes(inputArray);
        Console.WriteLine("Результат:");
        Console.WriteLine(string.Join(", ", resultArray));
    }
    public static int[] MoveZeroes(int[] arr)
    {
        int count = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] != 0)
            {
                arr[count++] = arr[i];
            }
        }
        while (count < arr.Length)
        {
            arr[count++] = 0;
        }
        return arr;
    }
}