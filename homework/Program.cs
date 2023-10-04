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



/*


System.Console.Write("Введите длину массива: ");
int arrayLength = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите начало диапазона случайных чисел: ");
// int Rstart = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите конец диапазона случайных чисел: ");
// int Rend = Convert.ToInt32(Console.ReadLine());

void MRandom(int col)
{
int[] array = new int[col];

System.Console.Write($"[");
for (int i = 0; i < array.Length; i++)
{
array[i] = new Random().Next(0, 10); // пытался добавить начало и конец диапазона, но так и не понял, как правильно записать это. 
// Искал в интернете варианты, но не смог найти. Пробовал через  new Random().Next(Rstart, Rend); При этом добавлял в функцию через , int Rstart, int Rend
// эти переменные, но выдавало ошибку. 
System.Console.Write($"{array[i]}, ");
}
System.Console.Write($"\b\b]");
}


MRandom(arrayLength);
System.Console.WriteLine();