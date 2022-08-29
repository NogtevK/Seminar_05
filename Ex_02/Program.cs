/* Задача 32: Напишите программу замена элементов
массива: положительные элементы замените на
соответствующие отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2] */

void Print(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine();
}

int[] mass = new int[4];
for (int i = 0; i < mass.Length; i++)
{
    mass[i] = new Random().Next(-8, 9);
}
Print(mass);

for (int i = 0; i < mass.Length; i++)
{
 mass[i]*=-1;
}
Print(mass);