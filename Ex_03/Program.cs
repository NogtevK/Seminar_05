/* Задача 33: Задайте массив.Напишите программу, которая
определяет, присутствует ли заданное число в массиве.
4; массив[6, 7, 19, 345, 3]->нет
- 3; массив[6, 7, 19, 345, 3]->да */

void Print(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine();
}

int[] mass = new int[5];
for (int i = 0; i < mass.Length; i++)
{
    mass[i] = new Random().Next(1, 10);
}
Print(mass);

Console.WriteLine("Введите искомое число в массиве ");
int find = int.Parse(Console.ReadLine());
int index = 0;
while (index < mass.Length)
{
    if (mass[index] == find)
    {
        Console.WriteLine(find + " Элемент найден, index элемента :"+ index);
        break;
    }
    else if (index == mass.Length - 1)
    {
        Console.WriteLine("Элемент не найден");
    }
    index++;
}
