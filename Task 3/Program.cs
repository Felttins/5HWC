// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.Write("Введите длинну массива - ");
int ArrayLenghts = int.Parse(Console.ReadLine()!);

int[] array = GetArray(ArrayLenghts, 1, 10);

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

void GetSumm(int[] arr)
{
    int Summ = 0;
    int max = arr[0];
    int min = arr[0];
        for (int i = 1; i < ArrayLenghts; i++)
        {
            if (arr[i] > max)
            {
                max = arr[i];
            }
            else
            {
            if (arr[i] < min)
            {
                min = arr[i];
            }
            }
        }
    Summ = min + max;
        
    
Console.Write($"Минимальное и максимальное числа массива в сумме дают - {Summ}, ");
}
GetSumm(array);