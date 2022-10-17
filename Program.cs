/* Задача 38: Задайте массив вещественных чисел.
Найдите разницу между максимальным и минимальным элементов массива.
[3, 7, 22, 2, 78] -> 76 */

void MaxMinDiff()
{
int n = new Random().Next(10, 15); // Размер массива задан случайно
int [] num = new int[n];
int min, max, diff;
min = 1000;
max = num[0];
diff = 0;
for (int i = 0; i < n; i++)
    {
        num[i] = new Random().Next(1, 100);
        if (num[i] < min) min = num[i];
        if (num[i] > max) max = num[i];
    }

diff = max - min;

Console.WriteLine();
Console.WriteLine("Создан массив случайных чисел: " + String.Join(", ", num) + ".");
Console.WriteLine();
Console.WriteLine($"Созданный массив соодержит {n} элементов.");
Console.WriteLine();
Console.WriteLine($"Разница между максимальным {max} и минимальным {min} элементами массива = {diff}.");
Console.WriteLine();
}
MaxMinDiff();