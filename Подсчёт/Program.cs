//Напишите рекурсивную функцию countDigits, которая вычисляет количество цифр в заданном целом числе. Функция countDigits должна принимать целое число n в качестве аргумента и возвращать количество цифр в числе n.

//Входные данные

//Целое число n, где n может быть как положительным, так и отрицательным.

//Выходные данные

//Целое число, представляющее количество цифр в числе n


internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine(countDigits(int.Parse(Console.ReadLine()!)));

    }

    public static int countDigits(int n) 
    {
        if (n == 0)
            return 0;
        else 
        {
            n/=10;
            return countDigits(n) + 1;
        }

    }
}