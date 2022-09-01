/* Задача 34: Задайте массив заполненный случайными
положительными трёхзначными числами. Напишите
программу, которая покажет количество чётных чисел в
массиве.
[345, 897, 568, 234] -> 2 */

/* void Print(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine();
}

int[] mass = new int[7];
for (int i = 0; i < mass.Length; i++)
{
    mass[i] = new Random().Next(100, 1000);
}
Print(mass);
Console.WriteLine();

int count = 0;
for (int i = 0; i < mass.Length; i++)
{
    if (mass[i] % 2 == 0)
    {
        count++;
    }
    else
    {
        i++;
    }
}
Console.WriteLine("Четных чисел: " + count);
 */
////////////////////////////////////////////////////////////////////
/* Задача 36: Задайте одномерный массив, заполненный
случайными числами. Найдите сумму элементов, стоящих
на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */

/* void Print(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine();
}

int[] mass = new int[6];
for (int i = 0; i < mass.Length; i++)
{
    mass[i] = new Random().Next(-10, 10);
}
Print(mass);
Console.WriteLine();

int sumPos = 0;
for (int i = 1; i < mass.Length; i+=2)
{
    sumPos+=mass[i];
}
Console.WriteLine("Сумма элементов равна: "+sumPos);
Console.WriteLine(); 
*/
/////////////////////////////////////////////////////////////////////////////
/* Задача 38: Задайте массив вещественных чисел. Найдите
разницу между максимальным и минимальным
элементов массива. */

void Print(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine();
}

double[] mass = new double[10];
for (int i = 0; i < mass.Length; i++)
{
    mass[i] = new Random().Next(-10, 100) + new Random().NextDouble();
}
Print(mass);

Console.WriteLine();

double max = mass[0];
double min = mass[0];

for (int i = 1; i < mass.Length; i++)
{
    if (max < mass[i])
    {
        max = mass[i];
    }
}
for (int j = 0; j < mass.Length; j++)
{
    if (min > mass[j])
    {
        min = mass[j];
    }
}
Console.WriteLine("Max: " + max);
Console.WriteLine("Min: " + min);
Console.WriteLine($"Разница чисел: ({max}) - ({min}) = {max - min}");
