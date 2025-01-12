using System;

class Program
{
    static void Main()
    {
        string[] ArrayStart = new string[4] { "Hello", "2", "world", ":-)" };
        string[] ArrayFinish = new string[ArrayStart.Length];
        int n = 3;

        SecondArray(ArrayStart, ArrayFinish, n);
        PrintArray(ArrayFinish);
    }

    static void SecondArray(string[] ArrayStart, string[] ArrayFinish, int n)
    {
        int count = 0;
        for (int i = 0; i < ArrayStart.Length; i++)
        {
            if (ArrayStart[i].Length <= n)
            {
                ArrayFinish[count] = ArrayStart[i];
                count++;
            }
        }

        string[] resultArray = new string[count];
        Array.Copy(ArrayFinish, resultArray, count); 


        ArrayFinish = resultArray;
    }

    static void PrintArray(string[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (!string.IsNullOrEmpty(array[i])) 
            {
                Console.Write($"{array[i]} ");
            }
        }
        Console.WriteLine();
    }
}