using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите значение M: ");
        int M = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите значение N: ");
        int N = Convert.ToInt32(Console.ReadLine());

        int sum = SumNaturalNumbers(M, N);
        Console.WriteLine("Сумма натуральных элементов от " + M + " до " + N + " равна: " + sum);
    }

    static int SumNaturalNumbers(int M, int N)
    {
        if (M > N)
        {
            return 0;
        }
        else
        {
            return M + SumNaturalNumbers(M + 1, N);
        }
    }
}