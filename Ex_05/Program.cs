/* Задача 37: Найдите произведение пар чисел в одномерном массиве.
Парой считаем первый и последний элемент, второй и предпоследний
и т.д. Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21 */

void Print(int[] arr)
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
    mass[i] = new Random().Next(0, 7);
}
Print(mass);
Console.WriteLine();

int j = 1;
for (int i = 0; i < mass.Length; i++)
{
    j = mass[i] * mass[mass.Length - i - 1];
    Console.Write(j + ", ");
}