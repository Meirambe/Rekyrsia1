using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите значение N: ");
        int N = Convert.ToInt32(Console.ReadLine());
        string result = PrintNaturalNumbers(N);
        Console.WriteLine(result);
    }

    static string PrintNaturalNumbers(int N)
    {
        if (N == 1)
        {
            return "1";
        }
        else
        {
            return N + ", " + PrintNaturalNumbers(N - 1);
        }
    }
}