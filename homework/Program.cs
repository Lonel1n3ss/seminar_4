// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16



// System.Console.WriteLine("Введите число А: ");
// int a = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите число B: ");
// int b = Convert.ToInt32(Console.ReadLine());

// int Cube(int a)
// {
//     int sum = 1;
//     for (int i = 1; i <= b; i++)
//     {
//         sum = sum * a;
//     }
//     return sum;
// }
// System.Console.WriteLine($"{Cube(a)}");









// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


// System.Console.WriteLine("Введите число N: ");
// int n = Convert.ToInt32(Console.ReadLine());


// int Sum(int n)
// {
//     int count = Convert.ToString(n).Length;
//     int res = 0;
//     int n1 = 0;
//     for (int i = 0; i < count; i++)
//     {
//         n1 = n - n % 10;
//         res = res + (n - n1);
//         n = n / 10;
//     }
//     return res;
// }

// System.Console.WriteLine($"{Sum(n)} ");







// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]


int[] MRandom(int size, int min, int max)
{
    int[] array = new int[size];
    System.Console.Write($"[");
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max + 1);
        System.Console.Write($"{array[i]}, ");
    }
    System.Console.Write($"\b\b]");
    return array;
}

System.Console.Write("Введите длину массива: ");
int n = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите начало диапазона случайных чисел: ");
int MinA = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите конец диапазона случайных чисел: ");
int MaxA = Convert.ToInt32(Console.ReadLine());

int[] arr = MRandom(n, MinA, MaxA);

