// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.Write("Введите длинну массива - ");
int ArrayLenghts = int.Parse(Console.ReadLine()!);

int[] array = GetArray(ArrayLenghts, 100, 999);

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
        Console.Write($"{res[i]} ");
    }
    return res;
}

void GetQuantity(int[] arr)
{
    int quantity = 0;

    foreach (int el in arr)
    {
        if (el%2 > 0)
        {
            
        }
        else
        {
            quantity ++;
        }
        
    }
Console.Write($"Количество положительных чисел = {quantity}");
}
GetQuantity(array);


